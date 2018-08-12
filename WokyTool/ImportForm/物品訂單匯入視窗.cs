using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataExport;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.ImportForm
{
    public partial class 物品訂單匯入視窗 : Form
    {
        private List<物品訂單資料> _Source;
        private List<可配送> _DeilverSource;

        private 舊列舉.訂單處理進度類型 _處理進度;
        private System.Windows.Forms.DataGridViewCellEventHandler _錯誤修正檢查;

        public 物品訂單匯入視窗()
        {
            InitializeComponent();

            _錯誤修正檢查 = new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckImportValue);

            this.廠商.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.物品.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.指配時段DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.代收方式DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.配送公司DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            this.廠商.DataSource = 廠商管理器.Instance.Map.Values.ToList();    //@@ using binding
            this.物品.DataSource = 物品管理器.Instance.Map.Values.ToList();    //@@ using binding
            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));

            UpdateState(舊列舉.訂單處理進度類型.新建);

            this.Activated += new System.EventHandler(this.onEventActivated);
        }

        private void UpdateState(舊列舉.訂單處理進度類型 處理進度_)
        {
            if (_處理進度 == 處理進度_)
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
                if (_Source.Where(Value => Value.是否已配送()).Count() == _Source.Count)
                    UpdateState(舊列舉.訂單處理進度類型.配送完成);
            }
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Import() == false)
                return;

            ImportShow();
        }

        // 匯入格式
        private bool Import()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);

                    _Source = new List<物品訂單資料>();
                    foreach (var Item_ in Excel_.Worksheet<物品訂單資料>())
                    {
                        if (Item_.IsRead() == false)
                            continue;

                        Item_.Init();
                        _Source.Add(Item_);
                    }
                    _Source.Sort();

                    this.dataGridView1.DataSource = _Source.ToList();

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
        private void ImportShow()
        {
            // 顯示資料數
            int 總筆數_ = _Source.Count;
            int 忽略筆數_ = 0;
            this.資料筆數.Text = String.Format("處理:{0} / 忽略:{1}", 總筆數_ - 忽略筆數_, 忽略筆數_);
        }

        private void 分組ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeilverSource = _Source.Where(Value => Value.群組 == 0).Select(Value => (可配送)Value).ToList();

            var GroupQueue_ = _Source.Where(Value => Value.群組 != 0).GroupBy(Value => Value.群組);
            foreach (var Group_ in GroupQueue_)
            {
                // 不該只有一個
                if (Group_.Count() == 1)
                {
                    MessageBox.Show("Group不合法 " + Group_.Key.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                非平台訂單資料 CombineItem_ = new 非平台訂單資料();
                foreach (var Item in Group_)
                {
                    if (CombineItem_.Add(Item) == false)
                        return;
                }
                _DeilverSource.Add(CombineItem_);
            }

            UpdateState(舊列舉.訂單處理進度類型.分組完成);
        }

        private void 配送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var Item_ in _DeilverSource)
            {
                Item_.準備配送();
                配送管理器.Instance.Add(Item_);
            }

            UpdateState(舊列舉.訂單處理進度類型.要求配送);
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Items_ = _Source.Select(Value => new 回單號結構_通用((物品訂單資料)Value));
            string Title_ = String.Format("通用回單_{0}", 時間.目前日期);
            函式.ExportExcel<回單號結構_通用>(Title_, Items_);
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            函式.GetFile("通用匯入範本", "Template/OrderImport/通用匯入範本.xlsx");
        }

        private void 測試ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Number = 1;
            foreach (var Item_ in _DeilverSource)
            {
                Item_.完成配送(String.Format("測試配送單號{0:00}", Number));
                Number++;
            }
        }
    }
}
