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
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public partial class 平台訂單匯入設定詳細視窗  : 詳細視窗
    {
        protected BindingList<欄位匯入設定資料> _BindingList = new BindingList<欄位匯入設定資料>();
        protected Boolean _isBingindChange = false;

        public 平台訂單匯入設定詳細視窗()
        {
            InitializeComponent();

            this.初始化(this.頁索引元件1, 平台訂單匯入設定資料管理器.獨體);

            this.檔案格式類型BindingSource.DataSource = Enum.GetValues(typeof(列舉.檔案格式));
            this.商品識別類型BindingSource.DataSource = Enum.GetValues(typeof(列舉.商品識別));
            this.匯入需求欄位BindingSource.DataSource = Enum.GetValues(typeof(平台訂單列舉.匯入需求欄位));
            this.資料格式類型BindingSource.DataSource = Enum.GetValues(typeof(列舉.資料格式));

            this.欄位匯入設定資料BindingSource.DataSource = _BindingList;

            bool 是否唯讀_ = 平台訂單匯入設定資料管理器.獨體.是否可編輯 == false;

            this.名稱.ReadOnly = 是否唯讀_;

            this.公司選取元件1.ReadOnly = 是否唯讀_;
            this.客戶選取元件1.ReadOnly = 是否唯讀_;

            if (是否唯讀_)
            {
                this.格式.DropDownStyle = ComboBoxStyle.Simple;
                this.商品識別.DropDownStyle = ComboBoxStyle.Simple;
            }
            else
            {
                this.格式.DropDownStyle = ComboBoxStyle.DropDown;
                this.商品識別.DropDownStyle = ComboBoxStyle.DropDown;
            }

            this.開始位置.ReadOnly = 是否唯讀_;
            this.結束位置.ReadOnly = 是否唯讀_;
            this.標頭位置.ReadOnly = 是否唯讀_;

            this._BindingList.AllowNew = !是否唯讀_;
            this._BindingList.AllowEdit = !是否唯讀_;
            this._BindingList.AllowRemove = !是否唯讀_;
        }

        /********************************/
        // 詳細視窗樣板

        protected override void 視窗激活()
        {
            this.客戶選取元件1.視窗激活();
            this.公司選取元件1.視窗激活();
        }

        /********************************/
        // 頁索引上層介面

        public override void 索引切換_異動儲存()
        {
            平台訂單匯入設定資料 目前資料_ = (平台訂單匯入設定資料)(this.頁索引元件1.目前資料);

            目前資料_.名稱 = this.名稱.Text;

            目前資料_.公司 = (公司資料)(this.公司選取元件1.SelectedItem);
            目前資料_.客戶 = (客戶資料)(this.客戶選取元件1.SelectedItem);

            目前資料_.格式 = (列舉.檔案格式)(this.格式.SelectedItem);
            目前資料_.商品識別 = (列舉.商品識別)(this.商品識別.SelectedItem);
            
            目前資料_.開始位置 = (int)(this.開始位置.Value);
            目前資料_.結束位置 = (int)(this.結束位置.Value);
            目前資料_.標頭位置 = (int)(this.標頭位置.Value);

            if (_isBingindChange)
            {
                目前資料_.資料List.Clear();
                目前資料_.資料List.AddRange(_BindingList);
            }
        }

        public override void 索引切換_更新呈現()
        {
            平台訂單匯入設定資料 目前資料_ = (平台訂單匯入設定資料)(this.頁索引元件1.目前資料);

            this.名稱.Text = 目前資料_.名稱;

            this.公司選取元件1.SelectedItem = 目前資料_.公司;
            this.客戶選取元件1.SelectedItem = 目前資料_.客戶;

            this.格式.SelectedItem = 目前資料_.格式;
            this.商品識別.SelectedItem = 目前資料_.商品識別;

            this.開始位置.Value = 目前資料_.開始位置;
            this.結束位置.Value = 目前資料_.結束位置;
            this.標頭位置.Value = 目前資料_.標頭位置;

            _BindingList.RaiseListChangedEvents = false;

            _BindingList.Clear();
            foreach(欄位匯入設定資料 Item_ in 目前資料_.資料List)
            {
                _BindingList.Add(Item_);
            }

            _BindingList.RaiseListChangedEvents = true;

            this.欄位匯入設定資料BindingSource.ResetBindings(false);
            this._isBingindChange = false;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            _isBingindChange = true;
        }
    }
}
