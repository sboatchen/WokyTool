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
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;
using WokyTool.聯絡人;

namespace WokyTool.一般訂單
{

    public partial class  一般訂單新增詳細視窗 : 詳細視窗
    {
        private BindingList<一般訂單新增商品資料> _清單BList = new BindingList<一般訂單新增商品資料>();

        public 一般訂單新增詳細視窗()
        {
            InitializeComponent();

            this.初始化(this.頁索引元件1, 一般訂單新增資料管理器.獨體);
            this.一般訂單新增商品資料BindingSource.DataSource = _清單BList;

            bool 是否唯讀_ = 一般訂單新增資料管理器.獨體.是否可編輯 == false;

            this.公司選取元件.ReadOnly = 是否唯讀_;
            this.客戶選取元件.ReadOnly = 是否唯讀_;
            this.子客戶選取元件.ReadOnly = 是否唯讀_;
            this.聯絡人選取元件.ReadOnly = 是否唯讀_;

            this.姓名.ReadOnly = 是否唯讀_;
            this.地址.ReadOnly = 是否唯讀_;
            this.電話.ReadOnly = 是否唯讀_;
            this.手機.ReadOnly = 是否唯讀_;

            this.列印單價.Enabled = !是否唯讀_;

            this.商品選取元件.ReadOnly = 是否唯讀_;
            this.數量.ReadOnly = 是否唯讀_;
            this.單價.ReadOnly = 是否唯讀_;

            this.客戶選取元件.下拉選單.SelectedIndexChanged += 客戶選擇改變;
            this.子客戶選取元件.下拉選單.SelectedIndexChanged += 子客戶選擇改變;
            this.聯絡人選取元件.下拉選單.SelectedIndexChanged += 聯絡人選擇改變;
        }

        private void 客戶選擇改變(object sender, EventArgs e)
        {
            客戶資料 客戶_ = (客戶資料)(this.客戶選取元件.SelectedItem);

            this.商品選取元件.綁定客戶 = (客戶資料)(this.客戶選取元件.下拉選單.SelectedValue);

            this.子客戶選取元件.SelectedItem = null;
            this.聯絡人選取元件.SelectedItem = null;

            this.子客戶選取元件.篩選.客戶 = 客戶_;
            this.聯絡人選取元件.篩選.客戶 = 客戶_;
        }

        private void 子客戶選擇改變(object sender, EventArgs e)
        {
            子客戶資料 子客戶_ = (子客戶資料)(this.子客戶選取元件.SelectedItem);

            this.聯絡人選取元件.SelectedItem = null;

            this.聯絡人選取元件.篩選.子客戶 = 子客戶_;
        }

        private void 聯絡人選擇改變(object sender, EventArgs e)
        {
            聯絡人資料 聯絡人_ = (聯絡人資料)(this.聯絡人選取元件.SelectedItem);
            if (聯絡人_ != null)
            {
                this.姓名.Text = 聯絡人_.姓名;
                this.地址.Text = 聯絡人_.地址;
                this.電話.Text = 聯絡人_.電話;
                this.手機.Text = 聯絡人_.手機;
            }
        }

        /********************************/

        protected override void 視窗激活()
        {
            this.商品選取元件.視窗激活();
        }

        /********************************/
        // 頁索引上層介面

        public override void 索引切換_異動儲存()
        {
            一般訂單新增資料 目前資料_ = (一般訂單新增資料)(this.頁索引元件1.目前資料);

            目前資料_.公司 = (公司資料)(this.公司選取元件.SelectedItem);
            目前資料_.客戶 = (客戶資料)(this.客戶選取元件.SelectedItem);
            目前資料_.子客戶 = (子客戶資料)(this.子客戶選取元件.SelectedItem);

            目前資料_.姓名 = this.姓名.Text;
            目前資料_.地址 = this.地址.Text;
            目前資料_.電話 = this.電話.Text;
            目前資料_.手機 = this.手機.Text;

            目前資料_.列印單價 = this.列印單價.Checked;

            if(_清單BList.Count == 0 )
                目前資料_.清單 = null;
            else
            {
                目前資料_.清單 = new List<一般訂單新增商品資料>();
                foreach (var Item_ in _清單BList)
                    目前資料_.清單.Add(Item_);
            }
        }

        public override void 索引切換_更新呈現()
        {
            一般訂單新增資料 目前資料_ = (一般訂單新增資料)(this.頁索引元件1.目前資料);

            this.公司選取元件.SelectedItem = 目前資料_.公司;
            this.客戶選取元件.SelectedItem = 目前資料_.客戶;
            this.子客戶選取元件.SelectedItem = 目前資料_.子客戶;

            this.姓名.Text = 目前資料_.姓名;
            this.地址.Text = 目前資料_.地址;
            this.電話.Text = 目前資料_.電話;
            this.手機.Text = 目前資料_.手機;

            this.列印單價.Checked = 目前資料_.列印單價;

            _清單BList.RaiseListChangedEvents = false;

            _清單BList.Clear();
            if (目前資料_.清單 != null)
            {
                foreach (var Item_ in 目前資料_.清單)
                     _清單BList.Add(Item_);
            }

            _清單BList.RaiseListChangedEvents = true;
            _清單BList.ResetBindings();
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            商品資料 商品_ = (商品資料)(this.商品選取元件.SelectedItem);
            if(商品_ == null || 商品_.編號是否有值() == false){
                訊息管理器.獨體.通知("商品不合法");
                return;
            }

            一般訂單新增商品資料 newItem_ = new 一般訂單新增商品資料();
            newItem_.商品 = 商品_;
            newItem_.數量 = (int)this.數量.Value;
            newItem_.單價 = this.單價.Value;
            newItem_.備註 = this.備註.Text;

            _清單BList.Add(newItem_);
        }
    }
}
