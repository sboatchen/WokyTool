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
    public partial class 月結帳匯入詳細視窗 : 匯入詳細視窗
    {
        public 月結帳匯入詳細視窗(資料管理器介面 資料管理器_)
        {
            InitializeComponent();

            this.初始化(this.頁索引元件1, 資料管理器_);
        }

        /********************************/
        // 月結帳匯入詳細視窗樣板

        protected override void 視窗激活()
        {
            this.公司選取元件1.視窗激活();
            this.客戶選取元件1.視窗激活();

            this.商品選取元件1.視窗激活();
        }

        /********************************/
        // 頁索引上層介面

        public override void 索引切換_異動儲存()
        {
            月結帳匯入資料 目前資料_ = (月結帳匯入資料)(this.頁索引元件1.目前資料);

            目前資料_.訂單編號 = this.訂單編號.Text;

            目前資料_.商品 = (商品資料)(this.商品選取元件1.SelectedItem);

            //目前資料_.公司 = (公司資料)(this.公司選取元件1.SelectedItem);
            //目前資料_.客戶 = (客戶資料)(this.客戶選取元件1.SelectedItem);

            目前資料_.數量 = (int)(this.數量.Value);
            目前資料_.單價 = (decimal)(this.單價.Value);
        }

        public override void 索引切換_更新呈現()
        {
            月結帳匯入資料 目前資料_ = (月結帳匯入資料)(this.頁索引元件1.目前資料);

            this.訂單編號.Text = 目前資料_.訂單編號;

            this.商品選取元件1.SelectedItem = 目前資料_.商品;
            this.商品識別.Text = 目前資料_.商品識別;

            this.公司選取元件1.SelectedItem = 目前資料_.設定.公司;
            this.客戶選取元件1.SelectedItem = 目前資料_.設定.客戶;

            this.數量.Value = 目前資料_.數量;
            this.單價.Value = 目前資料_.單價;
            this.含稅單價.Value = 目前資料_.含稅單價;
            this.總金額.Value = 目前資料_.總金額;
        }
    }
}
