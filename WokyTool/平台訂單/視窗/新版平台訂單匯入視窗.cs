using Newtonsoft.Json;
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
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.客製;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public partial class 新版平台訂單匯入視窗 : 匯入視窗
    {
        protected BindingSource 平台訂單匯入設定資料BindingSource = new BindingSource();
        protected 平台訂單匯入管理器 _平台訂單匯入管理器 = new 平台訂單匯入管理器();

        protected 公司資料 _公司 = null;
        protected 客戶資料 _客戶 = null;

        private int _公司資料版本 = -1;
        private int _商品資料版本 = -1;

        //protected 平台訂單匯入詳細視窗 _平台訂單匯入詳細視窗 = null;

        public 新版平台訂單匯入視窗()
        {
            InitializeComponent();

            this.初始化(this.平台訂單匯入資料BindingSource, _平台訂單匯入管理器);

            this.處理狀態.DataSource = Enum.GetValues(typeof(列舉.訂單處理狀態));
            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));

            this.檢查ToolStripMenuItem.Enabled = false;
            this.匯出ToolStripMenuItem.Enabled = false;
            this.dataGridView1.Enabled = false;

            this._公司資料版本 = 公司資料管理器.獨體.可編輯資料列版本;
            this.公司.ComboBox.DataSource = 公司資料管理器.獨體.可編輯BList;
            this.公司.ComboBox.DisplayMember = "名稱";
            this.公司.ComboBox.ValueMember = "Self";
            this.公司.ComboBox.FormattingEnabled = true;
            //this.公司.ComboBox.TabIndex = 10;
            this.公司.ComboBox.BindingContext = this.BindingContext;  // 這行很重要
            this.公司.ComboBox.SelectedIndex = 0;

            this.dataGridView1.DataError += new DataGridViewDataErrorEventHandler(this._DataGridView錯誤);
        }

        private void _DataGridView錯誤(object sender, DataGridViewDataErrorEventArgs e)
        {
            訊息管理器.獨體.訊息("資料錯誤:" + e.RowIndex + "," + e.ColumnIndex);
            e.ThrowException = false;

            if (e.ColumnIndex == 3)
                _平台訂單匯入管理器.可編輯BList[e.RowIndex].商品 = 商品資料.ERROR;
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            更新資料合法性();
        }

         private void 公司_SelectedIndexChanged(object sender, EventArgs e)
        {
            _公司 = (公司資料)((ToolStripComboBox)sender).SelectedItem;
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 平台訂單新增錯誤匯出轉換(_平台訂單匯入管理器.可編輯BList.Where(Value => Value.錯誤訊息 != null));

            string 標題_ = String.Format("平台訂單新增錯誤匯出_{0}_{1}_{2}", this._公司.名稱, this._客戶.名稱, 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //訊息管理器.獨體.通知("功能尚未實作");
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_公司資料版本 != 平台訂單匯入設定資料管理器.獨體.可選取資料列版本)
            {
                _公司資料版本 = 公司資料管理器.獨體.可編輯資料列版本;
                this.公司.ComboBox.DataSource = 公司資料管理器.獨體.可編輯BList;
            }

            if (_商品資料版本 != 商品資料管理器.獨體.可選取資料列版本 && _客戶 != null)    // 有資料後才處理
            {
                _商品資料版本 = 商品資料管理器.獨體.可選取資料列版本;
                this.商品資料BindingSource.DataSource = 商品資料管理器.獨體.唯讀BList
                                                            .Where(Value => (Value.客戶 == _客戶 && Value.公司 == _公司) || Value.編號 <= 常數.錯誤資料編碼)
                                                            .ToList();
            }
        }

        protected override void 視窗關閉()
        {
            //if (_平台訂單匯入詳細視窗 != null)
            //    _平台訂單匯入詳細視窗.關閉();
        }

        private void 匯入完成(IEnumerable<平台訂單匯入資料> 資料列舉_, bool momo第三方_ = false)
        {
            _平台訂單匯入管理器.新增(資料列舉_);
            if (_平台訂單匯入管理器.是否正在編輯() == false)
            {
                訊息管理器.獨體.通知("沒有資料");
                return;
            }

            if (momo第三方_)
                _平台訂單匯入管理器.平台訂單管理器 = Momo第三方平台訂單新增資料管理器.獨體;
            else
                _平台訂單匯入管理器.平台訂單管理器 = 平台訂單新增資料管理器.獨體;

            this.公司ToolStripMenuItem.Enabled = false;
            this.匯入ToolStripMenuItem.Enabled = false;
            this.檢查ToolStripMenuItem.Enabled = true;
            this.匯出ToolStripMenuItem.Enabled = true;
            this.dataGridView1.Enabled = true;

            訊息管理器.獨體.通知("匯入完成");
            //this.OnActivated(null);
        }

        private void 中華電信_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_中華電信 轉換_ = new 平台訂單匯入轉換_中華電信(_公司);
            _客戶 = 轉換_.客戶;

            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);

            匯入完成(資料列舉_);
        }

        private void 東森_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_東森 轉換_ = new 平台訂單匯入轉換_東森(_公司);
            _客戶 = 轉換_.客戶;

            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);

            匯入完成(資料列舉_);
        }

        private void friday_Click(object sender, EventArgs e)
        {

            平台訂單匯入轉換_Friday 轉換_ = new 平台訂單匯入轉換_Friday(_公司);
            _客戶 = 轉換_.客戶;

            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);

            匯入完成(資料列舉_);
        }

        private void Momo第三方_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_Momo第三方 轉換_ = new 平台訂單匯入轉換_Momo第三方(_公司);
            _客戶 = 轉換_.客戶;

            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);

            匯入完成(資料列舉_, true);
        }
    }
}
