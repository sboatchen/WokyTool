using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.客製;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public partial class Momo第三方訂單新增總覽視窗 : 總覽視窗
    {
        // Momo第三方專用
        private static char[] UserSeparators = new char[] { '\n', '/', '\r' };

        private static string FontPath = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\..\Fonts\kaiu.ttf";
        private static BaseFont MyBaseFont = BaseFont.CreateFont(
            FontPath,
            BaseFont.IDENTITY_H, //橫式中文
            BaseFont.NOT_EMBEDDED
        );
        private static iTextSharp.text.Font MyFont = new iTextSharp.text.Font(MyBaseFont, 12);

        private int _公司資料版本 = -1;
        private int _客戶資料版本 = -1;

        public Momo第三方訂單新增總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.平台訂單新增資料BindingSource, Momo第三方平台訂單新增資料管理器.獨體);

            this.處理狀態DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.訂單處理狀態));

            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.Notify("功能尚未實作");
            //視窗管理器.獨體.顯現(列舉.編號.平台訂單新增, 列舉.視窗.篩選);
        }

        private void 系統分組ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 清除所有舊的配送分組
            foreach(var Item_ in Momo第三方平台訂單新增資料管理器.獨體.可編輯BList)
            {
                if (Item_.處理狀態 == 列舉.訂單處理狀態.新增)
                {
                    Item_.自定義介面 = 平台訂單自定義工廠.MOMO第三方;
                    Item_.重新分組();
                }
            }

            int StartGroup_ = 1;
            var GroupQueue_ = Momo第三方平台訂單新增資料管理器.獨體.可編輯BList.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.新增).GroupBy(Value => Value.分組識別);
            foreach (var Group_ in GroupQueue_)
            {
                if (Group_.Count() == 1)
                    continue;

                foreach (var Item_ in Group_)
                    Item_.配送分組 = StartGroup_;
                
                StartGroup_--;

                var x = Group_.ToList();
            }

            this.dataGridView1.Refresh();

            訊息管理器.獨體.Notify("已完成系統分組");
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                var Items_ = Momo第三方平台訂單新增資料管理器.獨體.可編輯BList.Select(Value => new 平台訂單回單轉換_Momo第三方_分組(Value));
                String Title_ = String.Format("Momo第三方_分組_{0}", 時間.目前日期);
                函式.ExportExcel<平台訂單回單轉換_Momo第三方_分組>(Title_, Items_);
            }

            {
                var Items_ = Momo第三方平台訂單新增資料管理器.獨體.可編輯BList.Select(Value => new 平台訂單回單轉換_Momo第三方_進度(Value));
                String Title_ = String.Format("Momo第三方_進度_{0}", 時間.目前日期);
                函式.ExportExcel<平台訂單回單轉換_Momo第三方_進度>(Title_, Items_);
            }

            訊息管理器.獨體.Notify("已完成匯出");
        }

        private void 配送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 取得匯入檔案
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (.pdf)|*.pdf";
            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            // 寫入資料
            PdfReader reader = null;
            FileStream fs = null;
            Document document = null;
            PdfWriter writer = null;
            try
            {
                // 開啟匯入檔案
                reader = new PdfReader(dlg.FileName);

                // 開啟寫入檔案
                string OutputName = dlg.FileName.Replace(".pdf", "2.pdf");
                iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
                document = new Document(size);
                fs = new FileStream(OutputName, FileMode.Create, FileAccess.Write);
                writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                // 發票號碼過濾器
                RenderFilter[] IDfilter1_ = { new RegionTextRenderFilter(new iTextSharp.text.Rectangle(50, 450, 150, 550)) };
                RenderFilter[] IDfilter2_ = { new RegionTextRenderFilter(new iTextSharp.text.Rectangle(50, 50, 150, 150)) };

                // 宅配單號過濾器
                RenderFilter[] Nofilter1_ = { new RegionTextRenderFilter(new iTextSharp.text.Rectangle(50, 700, 100, 720)) };
                RenderFilter[] Nofilter2_ = { new RegionTextRenderFilter(new iTextSharp.text.Rectangle(50, 260, 100, 280)) };

                // 消費者地址/電話/名稱過濾器
                RenderFilter[] Userfilter1_ = { new RegionTextRenderFilter(new iTextSharp.text.Rectangle(70, 640, 280, 680)) };
                RenderFilter[] Userfilter2_ = { new RegionTextRenderFilter(new iTextSharp.text.Rectangle(70, 200, 280, 250)) };
                char[] UserSeparators = new char[] { '\n', '/', '\r' };

                StringBuilder sb = new StringBuilder();
                for (var i = 1; i <= reader.NumberOfPages; i++)
                {
                    document.NewPage();

                    momo第三方配送_設定(reader,
                                        i,
                                        new FilteredTextRenderListener(new LocationTextExtractionStrategy(), IDfilter1_),
                                        new FilteredTextRenderListener(new LocationTextExtractionStrategy(), Nofilter1_),
                                        new FilteredTextRenderListener(new LocationTextExtractionStrategy(), Userfilter1_),
                                        writer,
                                        465);

                    momo第三方配送_設定(reader,
                                       i,
                                       new FilteredTextRenderListener(new LocationTextExtractionStrategy(), IDfilter2_),
                                       new FilteredTextRenderListener(new LocationTextExtractionStrategy(), Nofilter2_),
                                       new FilteredTextRenderListener(new LocationTextExtractionStrategy(), Userfilter2_),
                                       writer,
                                       35);
                }
            }
            catch (Exception theException)
            {
                MessageBox.Show("momo第三方配送失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                /*if (writer != null)
                    writer.Close();*/
                if (document != null)
                    document.Close();
                if (fs != null)
                    fs.Close();
                if (reader != null)
                    reader.Close();
            }
        }

        private void momo第三方配送_設定(PdfReader File_, int PageIndex_, ITextExtractionStrategy IDStrategy_, ITextExtractionStrategy NoStrategy_, ITextExtractionStrategy UserStrategy_, PdfWriter Output_, int WritePosY_)
        {
            StringBuilder sb = new StringBuilder();

            // 取得發票號碼
            sb.AppendLine(PdfTextExtractor.GetTextFromPage(File_, PageIndex_, IDStrategy_));
            int StartIndex_ = sb.ToString().IndexOf("發票號碼");
            if (StartIndex_ == -1)
                return;
            string 發票號碼_ = sb.ToString().Substring(StartIndex_ + 7, 10);
            Console.WriteLine("發票號碼:{0}", 發票號碼_);
            sb.Clear();

            // 取得宅配單號
            sb.AppendLine(PdfTextExtractor.GetTextFromPage(File_, PageIndex_, NoStrategy_));
            StartIndex_ = sb.ToString().IndexOf("宅配單號");
            if (StartIndex_ == -1)
                return;
            string 宅配單號_ = sb.ToString().Substring(StartIndex_ + 5, 12);
            Console.WriteLine("宅配單號:{0}", 宅配單號_);
            sb.Clear();

            // 取得消費者資料
            sb.AppendLine(PdfTextExtractor.GetTextFromPage(File_, PageIndex_, UserStrategy_));
            var UserData_ = sb.ToString().Split(UserSeparators);
            string 地址_ = UserData_[0];
            string 電話_ = UserData_[1];
            string 手機_ = UserData_[2];
            string 名字_ = UserData_[3];
            Console.WriteLine("消費者:{0},{1},{2},{3}", 地址_, 電話_, 手機_, 名字_);

            // 取得物件
            var Item_ = Momo第三方平台訂單新增資料管理器.獨體.可編輯BList.Where(Value => 發票號碼_.Equals(Value.發票號碼)).FirstOrDefault();
            if (Item_ != null)
            {
                Item_.BeginEdit();

                Item_.姓名 = 名字_;
                Item_.電話 = 電話_;
                Item_.手機 = 手機_;
                Item_.地址 = 地址_;

                Item_.配送單號 = 宅配單號_;
                Item_.處理狀態 = 列舉.訂單處理狀態.配送;
                Item_.處理時間 = DateTime.Now;

                // 拷貝舊資料
                var importedPage = Output_.GetImportedPage(File_, PageIndex_);
                PdfContentByte contentByte = Output_.DirectContent;
                contentByte.AddTemplate(importedPage, 0, 0);

                // 計算加入的訊息  (排序)產品
                Phrase myText = new Phrase(Item_.組成.取得組合字串(), MyFont);

                // 塞入資訊
                ColumnText ct = new ColumnText(Output_.DirectContent);
                ct.SetSimpleColumn(myText, 290, WritePosY_ + 20, 520, WritePosY_ - 100, 15, Element.ALIGN_TOP);
                ct.Go();
            }
        }

        private void 歸檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Momo第三方平台訂單新增資料管理器.獨體.歸檔();

            this.OnActivated(null);

            訊息管理器.獨體.Notify("已完成歸檔");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 設定群組顏色
            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {
                int value = Convert.ToInt32(Myrow.Cells[1].Value);
                Myrow.DefaultCellStyle.BackColor = 顏色處理.GetRandomColor(value);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //訊息管理器.獨體.Notify("功能尚未實作");
            //int 編號_ = ((平台訂單新增資料)(this.平台訂單新增資料BindingSource.Current)).編號;
            //視窗管理器.獨體.顯現(列舉.編號.平台訂單新增, 列舉.視窗.詳細, 編號_);
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_公司資料版本 != 公司資料管理器.獨體.唯讀資料版本)
            {
                _公司資料版本 = 公司資料管理器.獨體.唯讀資料版本;
                this.公司資料BindingSource.DataSource = 公司資料管理器.獨體.唯讀BList;
            }

            if (_客戶資料版本 != 客戶資料管理器.獨體.唯讀資料版本)
            {
                _客戶資料版本 = 客戶資料管理器.獨體.唯讀資料版本;
                this.客戶資料BindingSource.DataSource = 客戶資料管理器.獨體.唯讀BList;
            }
        }
    }
}
