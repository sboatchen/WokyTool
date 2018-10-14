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
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public partial class 平台訂單匯入視窗 : 匯入視窗
    {
        protected BindingSource 平台訂單匯入設定資料BindingSource = new BindingSource();
        protected 平台訂單匯入管理器 _平台訂單匯入管理器 = new 平台訂單匯入管理器();

        protected 公司資料 _公司 = null;
        protected 客戶資料 _客戶 = null;

        private int _商品資料版本 = -1;
        private int _平台訂單匯入設定資料版本 = -1;


        //protected 平台訂單匯入詳細視窗 _平台訂單匯入詳細視窗 = null;

        public 平台訂單匯入視窗()
        {
            InitializeComponent();

            this.初始化(this.平台訂單匯入資料BindingSource, _平台訂單匯入管理器);

            this.格式.ComboBox.DataSource = this.平台訂單匯入設定資料BindingSource;
            this.格式.ComboBox.DisplayMember = "名稱";
            this.格式.ComboBox.ValueMember = "Self";
            this.格式.ComboBox.FormattingEnabled = true;
            this.格式.ComboBox.TabIndex = 10;
            this.格式.ComboBox.BindingContext = this.BindingContext;  // 這行很重要

            this.處理狀態.DataSource = Enum.GetValues(typeof(列舉.訂單處理狀態));
            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));

            this.檢查ToolStripMenuItem.Enabled = false;
            this.匯出ToolStripMenuItem.Enabled = false;
            this.dataGridView1.Enabled = false;

            this.dataGridView1.DataError += new DataGridViewDataErrorEventHandler(this._DataGridView錯誤);
        }

        private void _DataGridView錯誤(object sender, DataGridViewDataErrorEventArgs e)
        {
            訊息管理器.獨體.Error("資料錯誤:" + e.RowIndex + "," + e.ColumnIndex);
            e.ThrowException = false;

            if (e.ColumnIndex == 3)
                _平台訂單匯入管理器.可編輯BList[e.RowIndex].商品 = 商品資料.ERROR;
        }

        private void 格式_SelectedIndexChanged(object sender, EventArgs e)
        {
            平台訂單匯入設定資料 資料_ = (平台訂單匯入設定資料)((ToolStripComboBox)sender).SelectedItem;
            if (資料_ == null)
                return;

            this._公司 = 資料_.公司;
            this._客戶 = 資料_.客戶;
            _商品資料版本 = 商品資料管理器.獨體.唯讀資料版本;
            this.商品資料BindingSource.DataSource = 商品資料管理器.獨體.唯讀BList
                                                          .Where(Value => (Value.客戶 == _客戶 && Value.公司 == _公司) || Value.編號 <= 常數.T錯誤資料編碼)
                                                          .ToList();

            _平台訂單匯入管理器.新增(資料_.匯入Excel());
            if (_平台訂單匯入管理器.是否正在編輯() == false)
                return;

            if (資料_.名稱.ToLower().Contains("momo第三方"))
                _平台訂單匯入管理器.平台訂單管理器 = Momo第三方平台訂單新增資料管理器.獨體;
            else
                _平台訂單匯入管理器.平台訂單管理器 = 平台訂單新增資料管理器.獨體;

            this.格式.Enabled = false;
            this.檢查ToolStripMenuItem.Enabled = true;
            this.匯出ToolStripMenuItem.Enabled = true;
            this.dataGridView1.Enabled = true;

            this.OnActivated(null);
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            更新資料合法性();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Items_ = _平台訂單匯入管理器.可編輯BList.Where(Value => Value.錯誤訊息 != null)
                                .Select(Value => new 平台訂單新增錯誤匯出轉換(Value));

            string Title_ = String.Format("平台訂單新增錯誤匯出_{0}_{1}_{2}", this._公司.名稱, this._客戶.名稱, 時間.目前日期);
            函式.ExportExcel<平台訂單新增錯誤匯出轉換>(Title_, Items_);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //訊息管理器.獨體.Notify("功能尚未實作");
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_平台訂單匯入設定資料版本 != 平台訂單匯入設定資料管理器.獨體.唯讀資料版本)
            {
                _平台訂單匯入設定資料版本 = 平台訂單匯入設定資料管理器.獨體.唯讀資料版本;
                this.平台訂單匯入設定資料BindingSource.DataSource = 平台訂單匯入設定資料管理器.獨體.可編輯BList.OrderBy(Value => Value.名稱).ToList();   // 這邊不呈現 無/錯誤 所以不選唯讀BList??
            }

            if (_商品資料版本 != 商品資料管理器.獨體.唯讀資料版本 && _客戶 != null)    // 有資料後才處理
            {
                _商品資料版本 = 商品資料管理器.獨體.唯讀資料版本;
                this.商品資料BindingSource.DataSource = 商品資料管理器.獨體.唯讀BList
                                                            .Where(Value => (Value.客戶 == _客戶 && Value.公司 == _公司) || Value.編號 <= 常數.T錯誤資料編碼)
                                                            .ToList();
            }
        }

        protected override void 視窗關閉()
        {
            //if (_平台訂單匯入詳細視窗 != null)
            //    _平台訂單匯入詳細視窗.關閉();
        }
    }
}
