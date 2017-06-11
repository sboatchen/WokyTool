using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using LINQtoCSV;
using LinqToExcel;
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
using WokyTool.Data;
using WokyTool.DataExport;
using WokyTool.DataImport;
using WokyTool.DataMgr;

namespace WokyTool.ImportForm
{
    public partial class 商品訂單匯入視窗 : Form
    {
        private List<商品訂單資料> _Source;
        private List<可配送> _DeilverSource;

        private 列舉.訂單處理進度類型 _處理進度;
        private System.Windows.Forms.DataGridViewCellEventHandler _錯誤修正檢查;
        private string 廠商類型;

        // Momo第三方專用
        private static char[] UserSeparators = new char[] { '\n', '/', '\r' };

        private static string FontPath = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\..\Fonts\kaiu.ttf";
        private static BaseFont MyBaseFont = BaseFont.CreateFont(
            FontPath,
            BaseFont.IDENTITY_H, //橫式中文
            BaseFont.NOT_EMBEDDED
        );
        private static iTextSharp.text.Font MyFont = new iTextSharp.text.Font(MyBaseFont, 12);

        public 商品訂單匯入視窗()
        {
            InitializeComponent();

            _錯誤修正檢查 = new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckImportValue);

            this.商品編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.指配時段DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.代收方式DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.配送公司DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段類型));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收類型));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司類型));

            UpdateState(列舉.訂單處理進度類型.新建);

            this.Activated += new System.EventHandler(this.onEventActivated);
        }

        private void UpdateState(列舉.訂單處理進度類型 處理進度_)
        {
            if( _處理進度 == 處理進度_)
                return;
            _處理進度 = 處理進度_;

            switch (_處理進度)
            {
                case 列舉.訂單處理進度類型.新建:
                    匯入ToolStripMenuItem.Enabled = true;
                    分組ToolStripMenuItem.Enabled = false;
                    配送ToolStripMenuItem.Enabled = false;
                    匯出ToolStripMenuItem.Enabled = false;
                    break;
                case 列舉.訂單處理進度類型.匯入錯誤:
                    匯入ToolStripMenuItem.Enabled = false;
                    分組ToolStripMenuItem.Enabled = false;
                    配送ToolStripMenuItem.Enabled = false;
                    匯出ToolStripMenuItem.Enabled = false;
                    break;
                case 列舉.訂單處理進度類型.匯入正確:
                    匯入ToolStripMenuItem.Enabled = false;
                    分組ToolStripMenuItem.Enabled = true;
                    配送ToolStripMenuItem.Enabled = false;
                    匯出ToolStripMenuItem.Enabled = false;
                    break;
                case 列舉.訂單處理進度類型.分組完成:
                    匯入ToolStripMenuItem.Enabled = false;
                    分組ToolStripMenuItem.Enabled = false;
                    配送ToolStripMenuItem.Enabled = true;
                    匯出ToolStripMenuItem.Enabled = false;
                    this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.BlockEvent);
                    break;
                case 列舉.訂單處理進度類型.要求配送:
                    匯入ToolStripMenuItem.Enabled = false;
                    分組ToolStripMenuItem.Enabled = false;
                    配送ToolStripMenuItem.Enabled = false;
                    匯出ToolStripMenuItem.Enabled = false;
                    break;
                case 列舉.訂單處理進度類型.配送完成:
                    匯入ToolStripMenuItem.Enabled = false;
                    分組ToolStripMenuItem.Enabled = false;
                    配送ToolStripMenuItem.Enabled = false;
                    匯出ToolStripMenuItem.Enabled = true;
                    break;
                default:
                    MessageBox.Show("不支援的switch格式，請洽苦逼程式" + _處理進度.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        // 註冊事件:資料異動 - 檢查匯入資料是否合法
        private void CheckImportValue(object sender, DataGridViewCellEventArgs e)
        {
            if (_Source.Where(Value => Value.IsLegal() == false).Count() > 0)
                UpdateState(列舉.訂單處理進度類型.匯入錯誤);
            else
            {
                UpdateState(列舉.訂單處理進度類型.匯入正確);
                this.dataGridView1.CellValueChanged -= _錯誤修正檢查;
            }
        }

        // 避免Close呼叫CellValidating
        protected override void WndProc(ref Message m)
        {
            switch (((m.WParam.ToInt64() & 0xffff) & 0xfff0))
            {
                case 0xf060:
                    this.dataGridView1.CausesValidation = false;
                    break;
            }

            base.WndProc(ref m);
        }

        // 註冊事件:資料準備異動 - 不允許事件發生
        private void BlockEvent(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // 目前階段 >= 分組完成 不再允許修改
            MessageBox.Show("不再允許修改", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
             e.Cancel = true;
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            this.dataGridView1.Refresh();

            // 如果已經配送，檢查是否已全部配送完成
            if (_處理進度 == 列舉.訂單處理進度類型.要求配送)
            {
                if(_Source.Where(Value => Value.IsDilivered()).Count() == _Source.Count)
                    UpdateState(列舉.訂單處理進度類型.配送完成);
            }
        }

        private void 分組ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeilverSource = _Source.Where(Value => Value.群組 == 0 && Value.IsIgnore() == false).Select(Value => (可配送)Value).ToList();

            var GroupQueue_ = _Source.Where(Value => Value.群組 != 0).GroupBy(Value => Value.群組);
            foreach (var Group_ in GroupQueue_)
            {
                // 不該只有一個
                if (Group_.Count() == 1)
                {
                    MessageBox.Show("Group不合法 " + Group_.Key.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                合併訂單資料 CombineItem_ = new 合併訂單資料();
                foreach (var Item in Group_)
                {
                    if (CombineItem_.Add(Item) == false)
                        return;
                }
                _DeilverSource.Add(CombineItem_);
            }

            UpdateState(列舉.訂單處理進度類型.分組完成);

            switch (廠商類型)
            {
                case "Momo第三方":
                    {
                        {
                            var Items_ = _Source.Select(Value => new 回單號結構_Momo第三方_進度((出貨匯入結構_Momo第三方)Value));
                            string Title_ = String.Format("{0}進度回單_{1}", 廠商類型, 共用.NowYMDDec);
                            函式.ExportExcel<回單號結構_Momo第三方_進度>(Title_, Items_);
                        }

                        {
                            var Items_ = _Source.Select(Value => new 回單號結構_Momo第三方_分組((出貨匯入結構_Momo第三方)Value));
                            string Title_ = String.Format("{0}分組回單_{1}", 廠商類型, 共用.NowYMDDec);
                            函式.ExportExcel<回單號結構_Momo第三方_分組>(Title_, Items_);
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void 配送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (廠商類型)
            {
                case "Momo第三方":
                    {
                        foreach (var Item_ in _DeilverSource)
                        {
                            Item_.PrepareDiliver();
                        }
                        momo第三方配送();
                        break;
                    }
                default:
                    {
                        foreach (var Item_ in _DeilverSource)
                        {
                            Item_.PrepareDiliver();
                            配送管理器.Instance.Add(Item_);
                        }

                        UpdateState(列舉.訂單處理進度類型.要求配送);
                        break;
                    }
            }
        }
        
        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (廠商類型)
            {
                case "ibon mart":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_ibonMart((出貨匯入結構_ibonMart)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportCSV<回單號結構_ibonMart>(Title_, Items_);
                        break;
                    }
                case "myfone":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_myfone((出貨匯入結構_myfone)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportCSV<回單號結構_myfone>(Title_, Items_);
                        break;
                    }
                case "遠傳":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_遠傳((出貨匯入結構_遠傳)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportExcel<回單號結構_遠傳>(Title_, Items_);
                        break;
                    }
                case "遠傳加購":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_遠傳加購((出貨匯入結構_遠傳加購)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportExcel<回單號結構_遠傳加購>(Title_, Items_);
                        break;
                    }
                case "神坊":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_神坊((出貨匯入結構_神坊)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportExcel<回單號結構_神坊>(Title_, Items_);
                        break;
                    }
                case "citiesocial":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_citiesocial((出貨匯入結構_citiesocial)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportExcel<回單號結構_citiesocial>(Title_, Items_);
                        break;
                    }
                case "PayEasy":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_PayEasy((出貨匯入結構_PayEasy)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportCSV<回單號結構_PayEasy>(Title_, Items_);
                        break;
                    }
                case "GoHappy":
                    {
                        var Items_ = _Source.Where(Value => Value.IsIgnore() == false).Select(Value => new 回單號結構_GoHappy((出貨匯入結構_GoHappy)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportCSV<回單號結構_GoHappy>(Title_, Items_);
                        break;
                    }
                case "東森":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_東森((出貨匯入結構_東森)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportCSV<回單號結構_東森>(Title_, Items_);
                        break;
                    }
                case "森森":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_森森((出貨匯入結構_森森)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportCSV<回單號結構_森森>(Title_, Items_);
                        break;
                    }
                 case "創業家兄弟":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_創業家兄弟((出貨匯入結構_創業家兄弟)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportCSV<回單號結構_創業家兄弟>(Title_, Items_);
                        break;
                    }
                 case "PCHome":
                    {
                        MessageBox.Show("PCHome平台不支援匯出，請手動回單號", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                 case "Momo":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_Momo((出貨匯入結構_Momo)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 共用.NowYMDDec);
                        函式.ExportExcel<回單號結構_Momo>(Title_, Items_);
                        break;
                    }
                case "Momo第三方":
                    {
                        break;
                    }
                default:
                    MessageBox.Show("匯出ToolStripMenuItem_Click unspport " + 廠商類型, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
         
        }

        // 通用匯入格式
        private bool Import<T>() where T : 商品訂單資料
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);

                    _Source = new List<商品訂單資料>();
                    foreach (var Item_ in Excel_.Worksheet<T>())
                    {
                        if (Item_.訂單編號 == null)
                            break;

                        if (Item_.IsRead() == false)
                            continue;

                        Item_.Init();
                        _Source.Add(Item_);
                    }
                    _Source.Sort();

                    this.dataGridView1.DataSource = _Source.Where(Value => Value.IsIgnore() == false).ToList();

                    if (_Source.Where(Value => Value.IsLegal() == false).Count() > 0)
                    {
                        UpdateState(列舉.訂單處理進度類型.匯入錯誤);
                        this.dataGridView1.CellValueChanged += _錯誤修正檢查;
                    }
                    else
                    {
                        UpdateState(列舉.訂單處理進度類型.匯入正確);
                        this.dataGridView1.CellValueChanged -= _錯誤修正檢查;
                    }

                    return true;
                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        // 匯入資料呈現
        private void ImportShow(string 廠商名稱_)
        {
            this.Text = String.Format("商品訂單匯入視窗_{0}", this.廠商類型);
            int 廠商編號_ = 廠商管理器.Instance.Get(廠商名稱_).編號;
            this.商品編號DataGridViewTextBoxColumn.DataSource = 商品管理器.Instance.Map.Values.Where(value => value.廠商編號 == 廠商編號_ || value.編號 <= 0).ToList();

            // 顯示資料數
            int 總筆數_ = _Source.Count;
            int 忽略筆數_ = _Source.Where(Value => Value.IsIgnore() == true).Count();
            this.資料筆數.Text = String.Format("處理:{0} / 忽略:{1}", 總筆數_ - 忽略筆數_, 忽略筆數_);
        }

        // GoHappy匯入
        private void goHappyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "GoHappy";

            if (Import<出貨匯入結構_GoHappy>() == false)
                return;

            ImportShow(廠商類型);
        }

        private void 東森ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "東森";

            if (Import<出貨匯入結構_東森>() == false)
                return;

            ImportShow(廠商類型);
        }

        private void 森森ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "森森";

            if (Import<出貨匯入結構_森森>() == false)
                return;

            ImportShow(廠商類型);
        }

        private void 創業家兄弟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "創業家兄弟";

            if (Import<出貨匯入結構_創業家兄弟>() == false)
                return;

            ImportShow(廠商類型);
        }

        private void pCHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "PCHome";

            if (Import<出貨匯入結構_PCHome>() == false)
                return;

            ImportShow(廠商類型);
        }

        private void momoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "Momo";

            if (Import<出貨匯入結構_Momo>() == false)
                return;

            ImportShow(廠商類型);
        }

        private void momo第三方ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "Momo第三方";

            if (Import<出貨匯入結構_Momo第三方>() == false)
                return;

            ImportShow("Momo");
        }

        private void 博客來ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "博客來";

            if (Import<出貨匯入結構_博客來>() == false)
                return;

            ImportShow("博客來");
        }

        private void payEasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "PayEasy";

            if (Import<出貨匯入結構_PayEasy>() == false)
                return;

            ImportShow("PayEasy");
        }

        private void 神坊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "神坊";

            if (Import<出貨匯入結構_神坊>() == false)
                return;

            ImportShow("神坊");
        }

        private void citiesocialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            廠商類型 = "citiesocial";

            if (Import<出貨匯入結構_citiesocial>() == false)
                return;

            ImportShow("citiesocial");
        }

        private void 遠傳ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "遠傳";

            if (Import<出貨匯入結構_遠傳>() == false)
                return;

            ImportShow("遠傳");
        }

        private void 遠傳加購ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "遠傳加購";

            if (Import<出貨匯入結構_遠傳加購>() == false)
                return;

            ImportShow("遠傳加購");
        }

        private void myfoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "myfone";

            if (Import<出貨匯入結構_myfone>() == false)
                return;

            ImportShow("myfone");
        }


        private void ibonMartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "ibon mart";

            if (Import<出貨匯入結構_ibonMart>() == false)
                return;

            ImportShow("ibon mart");
        }

        private bool momo第三方配送()
        {
            // 進行排序
            _DeilverSource.Sort((x, y) => { return x.配送商品.CompareTo(y.配送商品); });

            // 取得匯入檔案
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (.pdf)|*.pdf";
            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return false;

            // 寫入資料
            try
            {
                // 開啟匯入檔案
                PdfReader reader = new PdfReader(dlg.FileName);

                // 開啟寫入檔案
                string OutputName = dlg.FileName.Replace(".pdf", "2.pdf");
                iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
                Document document = new Document(size);
                FileStream fs = new FileStream(OutputName, FileMode.Create, FileAccess.Write);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
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

                    momo第三方配送_設定( reader,
                                        i,
                                        new FilteredTextRenderListener(new LocationTextExtractionStrategy(), IDfilter1_),
                                        new FilteredTextRenderListener(new LocationTextExtractionStrategy(), Nofilter1_),
                                        new FilteredTextRenderListener(new LocationTextExtractionStrategy(), Userfilter1_),
                                        writer,
                                        500);

                    momo第三方配送_設定(reader,
                                       i,
                                       new FilteredTextRenderListener(new LocationTextExtractionStrategy(), IDfilter2_),
                                       new FilteredTextRenderListener(new LocationTextExtractionStrategy(), Nofilter2_),
                                       new FilteredTextRenderListener(new LocationTextExtractionStrategy(), Userfilter2_),
                                       writer,
                                       70);
                }

                document.Close();
                writer.Close();

                fs.Close();
                reader.Close();
            }
            catch (Exception theException)
            {
                MessageBox.Show("momo第三方配送失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        private void momo第三方配送_設定(PdfReader File_,int PageIndex_, ITextExtractionStrategy IDStrategy_, ITextExtractionStrategy NoStrategy_, ITextExtractionStrategy UserStrategy_, PdfWriter Output_, int WritePosY_)
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
            var Item_ = _DeilverSource.Where(Value => Value.IsReceiptMatch(發票號碼_)).FirstOrDefault();
            if (Item_ != null)
            {
                //@Item_.姓名 = 名字_;
                //@@Item_.電話 = 電話_;
                //@@Item_.手機 = 手機_;
                //@@Item_.地址 = 地址_;
                Item_.SetDiliver(宅配單號_);

                // 拷貝舊資料
                var importedPage = Output_.GetImportedPage(File_, PageIndex_);
                PdfContentByte contentByte = Output_.DirectContent;
                contentByte.AddTemplate(importedPage, 0, 0);

                // 計算加入的訊息  (排序)產品
                int Index_ = _DeilverSource.IndexOf(Item_) + 1;
                Phrase myText = new Phrase(String.Format("({0}){1}", Index_, Item_.配送商品), MyFont);
                
                // 塞入資訊
                ColumnText ct = new ColumnText(Output_.DirectContent);
                ct.SetSimpleColumn(myText, 290, WritePosY_+20, 520, WritePosY_-100, 15, Element.ALIGN_TOP);
                ct.Go();

                // 設定組成
                /*var importedPage = Output_.GetImportedPage(File_, PageIndex_);
                PdfContentByte contentByte = Output_.DirectContent;
                contentByte.SetFontAndSize(MyBaseFont, 12);

                // 計算加入的訊息  (排序)產品
                int Index_ = _DeilverSource.IndexOf(Item_) + 1;
                String AddData_ = String.Format("({0}){1}", Index_, Item_.配送商品);

                contentByte.BeginText();
                contentByte.ShowTextAligned(0, AddData_, 290, WritePosY_, 0);
                contentByte.EndText();

                contentByte.AddTemplate(importedPage, 0, 0);*/
            }
        }

        private void 測試ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Number = 1;
            foreach(var Item_ in _DeilverSource)
            {
                Item_.SetDiliver(String.Format("測試配送單號{0:00}", Number));
                Number++;
            }
        }

        private void 東森ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("東森匯入樣板", "Template/OrderImport/東森匯入樣板.xlsx");
        }

        private void goHappyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("GoHappy匯入樣板", "Template/OrderImport/GoHappy匯入樣板.xlsx");
        }

        private void 博客來ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("博客來匯入樣板", "Template/OrderImport/博客來匯入樣板.xlsx");
        }
        
        private void payEasyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("PayEasy匯入樣板", "Template/OrderImport/PayEasy匯入樣板.xlsx");
        }

        private void 神坊ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("神坊匯入樣板", "Template/OrderImport/神坊匯入樣板.xlsx");
        }

        private void citiesocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            函式.GetFile("citiesocial匯入樣板", "Template/OrderImport/citiesocial匯入樣板.xlsx");
        }
        
        private void 遠傳ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("遠傳匯入樣板", "Template/OrderImport/遠傳匯入樣板.xlsx");
        }

        private void myfoneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("myfone匯入樣板", "Template/OrderImport/myfone匯入樣板.xlsx");
        }

        private void ibonMartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("ibon mart匯入樣板", "Template/OrderImport/ibon mart匯入樣板.xlsx");
        }

        private void 遠傳加購ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("遠傳加購匯入樣板", "Template/OrderImport/遠傳加購匯入樣板.xlsx");
        }
    }
}
