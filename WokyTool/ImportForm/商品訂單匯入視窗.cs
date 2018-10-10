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
using WokyTool.通用;

namespace WokyTool.ImportForm
{
    public partial class 商品訂單匯入視窗 : Form
    {
        private List<商品訂單資料> _Source;
        private List<可配送> _DeilverSource;

        private 舊列舉.訂單處理進度類型 _處理進度;
        private System.Windows.Forms.DataGridViewCellEventHandler _錯誤修正檢查;
        private string 廠商類型;

        public 商品訂單匯入視窗()
        {
            InitializeComponent();

            _錯誤修正檢查 = new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckImportValue);

            this.商品編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.指配時段DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.代收方式DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.配送公司DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));

            UpdateState(舊列舉.訂單處理進度類型.新建);

            this.Activated += new System.EventHandler(this.onEventActivated);
        }

        private void UpdateState(舊列舉.訂單處理進度類型 處理進度_)
        {
            if( _處理進度 == 處理進度_)
                return;
            _處理進度 = 處理進度_;

            switch (_處理進度)
            {
                case 舊列舉.訂單處理進度類型.新建:
                    匯入ToolStripMenuItem.Enabled = true;
                    分組ToolStripMenuItem.Enabled = false;
                    配送ToolStripMenuItem.Enabled = false;
                    匯出ToolStripMenuItem.Enabled = false;
                    break;
                case 舊列舉.訂單處理進度類型.匯入錯誤:
                    匯入ToolStripMenuItem.Enabled = false;
                    分組ToolStripMenuItem.Enabled = false;
                    配送ToolStripMenuItem.Enabled = false;
                    匯出ToolStripMenuItem.Enabled = false;
                    break;
                case 舊列舉.訂單處理進度類型.匯入正確:
                    匯入ToolStripMenuItem.Enabled = false;
                    分組ToolStripMenuItem.Enabled = true;
                    配送ToolStripMenuItem.Enabled = false;
                    匯出ToolStripMenuItem.Enabled = false;
                    break;
                case 舊列舉.訂單處理進度類型.分組完成:
                    匯入ToolStripMenuItem.Enabled = false;
                    分組ToolStripMenuItem.Enabled = false;
                    配送ToolStripMenuItem.Enabled = true;
                    匯出ToolStripMenuItem.Enabled = false;
                    this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.BlockEvent);
                    break;
                case 舊列舉.訂單處理進度類型.要求配送:
                    匯入ToolStripMenuItem.Enabled = false;
                    分組ToolStripMenuItem.Enabled = false;
                    配送ToolStripMenuItem.Enabled = false;
                    匯出ToolStripMenuItem.Enabled = false;
                    break;
                case 舊列舉.訂單處理進度類型.配送完成:
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
                UpdateState(舊列舉.訂單處理進度類型.匯入錯誤);
            else
            {
                UpdateState(舊列舉.訂單處理進度類型.匯入正確);
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
            if (_處理進度 == 舊列舉.訂單處理進度類型.要求配送)
            {
                if(_Source.Where(Value => Value.是否已配送()).Count() == _Source.Count)
                    UpdateState(舊列舉.訂單處理進度類型.配送完成);
            }
        }

        private void 分組ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 配送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        
        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (廠商類型)
            {
                case "遠傳":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_遠傳((出貨匯入結構_遠傳)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 時間.目前日期);
                        函式.ExportExcel<回單號結構_遠傳>(Title_, Items_);
                        break;
                    }
                case "citiesocial":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_citiesocial((出貨匯入結構_citiesocial)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 時間.目前日期);
                        函式.ExportExcel<回單號結構_citiesocial>(Title_, Items_);
                        break;
                    }
                 case "創業家兄弟":
                    {
                        var Items_ = _Source.Select(Value => new 回單號結構_創業家兄弟((出貨匯入結構_創業家兄弟)Value));
                        string Title_ = String.Format("{0}回單_{1}", 廠商類型, 時間.目前日期);
                        函式.ExportCSV<回單號結構_創業家兄弟>(Title_, Items_);
                        break;
                    }
                default:
                    MessageBox.Show(廠商類型 + "不支援匯出功能" + 廠商類型, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        _Source.AddRange(Item_.ToList());
                    }

                    _Source = _Source.Where(Value => Value.IsIgnore() == false).ToList();
                    _Source.Sort();

                    // pre group
                    商品訂單資料 NowCheck_ = null;
                    int NowGroup_ = 1;
                    int NextGroup_ = 1;
                    foreach(var Item_ in _Source){
                        if (NowCheck_ == null)
                        {
                            NowCheck_ = Item_;
                            continue;
                        }

                        if (NowCheck_.CompareTo(Item_) == 0)
                        {
                            NowCheck_.群組 = NowGroup_;
                            Item_.群組 = NowGroup_;
                            NextGroup_ = NowGroup_ + 1;
                        }
                        else 
                        {
                            NowCheck_ = Item_;
                            NowGroup_ = NextGroup_;
                        }
                    }

                    this.dataGridView1.DataSource = _Source;

                    if (_Source.Where(Value => Value.IsLegal() == false).Count() > 0)
                    {
                        UpdateState(舊列舉.訂單處理進度類型.匯入錯誤);
                        this.dataGridView1.CellValueChanged += _錯誤修正檢查;
                    }
                    else
                    {
                        UpdateState(舊列舉.訂單處理進度類型.匯入正確);
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
        }

        private void 東森ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 森森ToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void momo第三方ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void momo摩天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 博客來ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void payEasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 神坊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void myfoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void ibonMartToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 金石堂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aSAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "ASAP";

            if (Import<出貨匯入結構_ASAP>() == false)
                return;

            ImportShow("ASAP");
        }

        private void 百利市ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pCToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void pC購物中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 愛料理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            廠商類型 = "愛料理";

            if (Import<出貨匯入結構_愛料理>() == false)
                return;

            ImportShow("愛料理");
        }

        private void uDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 測試ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 東森ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void goHappyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void 博客來ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }
        
        private void payEasyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void 神坊ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
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
        }

        private void ibonMartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void 遠傳加購ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void 金石堂ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void aSAPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("ASAP匯入樣板", "Template/OrderImport/ASAP匯入樣板.xlsx");
        }
        
        private void 百利市ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void pC專櫃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pC商店街ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pC購物中心ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void 愛料理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            函式.GetFile("愛料理匯入樣板", "Template/OrderImport/愛料理匯入樣板.xlsx");
        }

        private void momo摩天ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }
        
        private void uDesignToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void momo第三方ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
