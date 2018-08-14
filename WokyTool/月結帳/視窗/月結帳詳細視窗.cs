using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public partial class 月結帳詳細視窗 : 詳細視窗
    {
        public 月結帳詳細視窗()
        {
            InitializeComponent();

            this.初始化(this.頁索引元件1, 月結帳資料管理器.獨體);

            bool 是否唯讀_ = 月結帳資料管理器.獨體.是否可編輯 == false;

            this.商品選取元件1.ReadOnly = 是否唯讀_;

            this.公司選取元件1.ReadOnly = 是否唯讀_;
            this.客戶選取元件1.ReadOnly = 是否唯讀_;

            this.數量.ReadOnly = 是否唯讀_;
            this.單價.ReadOnly = 是否唯讀_;
            this.含稅單價.ReadOnly = 是否唯讀_;
        }

        /********************************/
        // 月結帳詳細視窗樣板

        protected override void 視窗激活()
        {
            this.公司選取元件1.視窗激活();
            this.客戶選取元件1.視窗激活();

            this.商品選取元件1.視窗激活();    //@@ 商品列表 應在根據 公司 客戶 進行篩檢
        }

        /********************************/
        // 頁索引上層介面

        public override void 索引切換_異動儲存()
        {
            月結帳資料 目前資料_ = (月結帳資料)(this.頁索引元件1.目前資料);

            目前資料_.商品 = (商品資料)(this.商品選取元件1.SelectedItem);

            目前資料_.公司 = (公司資料)(this.公司選取元件1.SelectedItem);
            目前資料_.客戶 = (客戶資料)(this.客戶選取元件1.SelectedItem);

            目前資料_.數量 = (int)(this.數量.Value);
            目前資料_.單價 = this.單價.Value;
            目前資料_.含稅單價 = this.含稅單價.Value;
        }

        public override void 索引切換_更新呈現()
        {
            月結帳資料 目前資料_ = (月結帳資料)(this.頁索引元件1.目前資料);

            this.商品選取元件1.SelectedItem = 目前資料_.商品;

            this.公司選取元件1.SelectedItem = 目前資料_.公司;
            this.客戶選取元件1.SelectedItem = 目前資料_.客戶;

            this.數量.Value = 目前資料_.數量;
            this.單價.Value = 目前資料_.單價;
            this.含稅單價.Value = 目前資料_.含稅單價;
            this.總金額.Value = 目前資料_.總金額;
            this.成本.Value = 目前資料_.成本;
            this.利潤.Value = 目前資料_.利潤;
            this.總利潤.Value = 目前資料_.總利潤;
        }
    }
}
