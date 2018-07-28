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

namespace WokyTool.月結帳
{
    public partial class 月結帳匯入視窗 : 匯入視窗
    {
        private int _公司資料版本 = -1;
        private int _客戶資料版本 = -1;
        private int _商品資料版本 = -1;
        private int _月結帳匯入設定資料版本 = -1;

        protected BindingSource 月結帳匯入設定資料BindingSource = new BindingSource();
        protected 月結帳匯入管理器 _月結帳匯入管理器 = new 月結帳匯入管理器();

        protected 月結帳匯入詳細視窗 _月結帳匯入詳細視窗 = null;

        public 月結帳匯入視窗()
        {
            InitializeComponent();

            this.初始化(月結帳匯入資料BindingSource, _月結帳匯入管理器);

            this.設定.ComboBox.DataSource = this.月結帳匯入設定資料BindingSource;
            this.設定.ComboBox.DisplayMember = "名稱";
            this.設定.ComboBox.ValueMember = "Self";
            this.設定.ComboBox.FormattingEnabled = true;
            this.設定.ComboBox.TabIndex = 10;
            this.設定.ComboBox.BindingContext = this.BindingContext;  // 這行很重要
        }

        private void 設定_SelectedIndexChanged(object sender, EventArgs e)
        {
            月結帳匯入設定資料 資料_ = (月結帳匯入設定資料)((ToolStripComboBox)sender).SelectedItem;
            if (資料_ == null)
                return;

            _月結帳匯入管理器.新增(資料_.匯入Excel());
            if (_月結帳匯入管理器.是否正在編輯() == false)
                return;

            this.設定.Enabled = false;

            this.OnActivated(null);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//
        {
            if (_月結帳匯入詳細視窗 == null)
                _月結帳匯入詳細視窗 = new 月結帳匯入詳細視窗(_月結帳匯入管理器);

            _月結帳匯入詳細視窗.顯現(this.月結帳匯入資料BindingSource.Position);
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

            if (_月結帳匯入設定資料版本 != 月結帳匯入設定資料管理器.獨體.唯讀資料版本)
            {
                _月結帳匯入設定資料版本 = 月結帳匯入設定資料管理器.獨體.唯讀資料版本;
                this.月結帳匯入設定資料BindingSource.DataSource = 月結帳匯入設定資料管理器.獨體.唯讀BList;   // 這邊不呈現 無/錯誤 所以不選唯讀BList??
            }
        }

        protected override void 視窗關閉()
        {
            if (_月結帳匯入詳細視窗 != null)
                _月結帳匯入詳細視窗.關閉();
        }
    }
}
