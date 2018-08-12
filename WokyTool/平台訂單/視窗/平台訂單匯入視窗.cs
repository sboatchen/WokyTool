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
        private int _公司資料版本 = -1;
        private int _客戶資料版本 = -1;
        private int _商品資料版本 = -1;
        private int _平台訂單匯入設定資料版本 = -1;

        protected BindingSource 平台訂單匯入設定資料BindingSource = new BindingSource();
        protected 平台訂單匯入管理器 _平台訂單匯入管理器 = new 平台訂單匯入管理器();

        //protected 平台訂單匯入詳細視窗 _平台訂單匯入詳細視窗 = null;

        public 平台訂單匯入視窗()
        {
            InitializeComponent();

            this.初始化(this.平台訂單匯入資料BindingSource, _平台訂單匯入管理器);

            this.設定.ComboBox.DataSource = this.平台訂單匯入設定資料BindingSource;
            this.設定.ComboBox.DisplayMember = "名稱";
            this.設定.ComboBox.ValueMember = "Self";
            this.設定.ComboBox.FormattingEnabled = true;
            this.設定.ComboBox.TabIndex = 10;
            this.設定.ComboBox.BindingContext = this.BindingContext;  // 這行很重要

            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));
        }

        private void 設定_SelectedIndexChanged(object sender, EventArgs e)
        {
            平台訂單匯入設定資料 資料_ = (平台訂單匯入設定資料)((ToolStripComboBox)sender).SelectedItem;
            if (資料_ == null)
                return;

            _平台訂單匯入管理器.新增(資料_.匯入Excel());
            if (_平台訂單匯入管理器.是否正在編輯() == false)
                return;

            this.設定.Enabled = false;

            this.OnActivated(null);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//
        {
            //if (_平台訂單匯入詳細視窗 == null)
            //    _平台訂單匯入詳細視窗 = new 平台訂單匯入詳細視窗(_平台訂單匯入管理器);

            //_平台訂單匯入詳細視窗.顯現(this.平台訂單匯入資料BindingSource.Position);
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

            if (_商品資料版本 != 商品資料管理器.獨體.唯讀資料版本)
            {
                _商品資料版本 = 商品資料管理器.獨體.唯讀資料版本;
                this.商品資料BindingSource.DataSource = 商品資料管理器.獨體.唯讀BList;
            }

            if (_平台訂單匯入設定資料版本 != 平台訂單匯入設定資料管理器.獨體.唯讀資料版本)
            {
                _平台訂單匯入設定資料版本 = 平台訂單匯入設定資料管理器.獨體.唯讀資料版本;
                this.平台訂單匯入設定資料BindingSource.DataSource = 平台訂單匯入設定資料管理器.獨體.唯讀BList;   // 這邊不呈現 無/錯誤 所以不選唯讀BList??
            }
        }

        protected override void 視窗關閉()
        {
            //if (_平台訂單匯入詳細視窗 != null)
            //    _平台訂單匯入詳細視窗.關閉();
        }
    }
}
