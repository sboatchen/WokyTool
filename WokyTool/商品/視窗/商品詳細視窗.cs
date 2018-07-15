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
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.商品{

    public partial class 商品詳細視窗 : 詳細視窗
    {
        public 商品詳細視窗()
        {
            InitializeComponent();

            this.初始化<商品資料>(this.頁索引元件1, 商品資料管理器.獨體);
        }

        /********************************/
        // 商品詳細視窗樣板

        protected override void 視窗激活()
        {
            this.商品大類選取元件1.視窗激活();
            this.商品小類選取元件1.視窗激活();

            this.公司選取元件1.視窗激活();
            this.客戶選取元件1.視窗激活();

            this.物品選取元件1.視窗激活();
            this.物品選取元件2.視窗激活();
            this.物品選取元件3.視窗激活();
            this.物品選取元件4.視窗激活();
            this.物品選取元件5.視窗激活();
        }

        /********************************/
        // 頁索引上層介面

        public override void 索引切換_異動儲存()
        {
            商品資料 目前資料_ = (商品資料)(this.頁索引元件1.目前資料);

            目前資料_.名稱 = this.名稱.Text;
            目前資料_.品號 = this.品號.Text;

            目前資料_.大類 = (商品大類資料)(this.商品大類選取元件1.SelectedItem);
            目前資料_.小類 = (商品小類資料)(this.商品小類選取元件1.SelectedItem);

            目前資料_.公司 = (公司資料)(this.公司選取元件1.SelectedItem);
            目前資料_.客戶 = (客戶資料)(this.客戶選取元件1.SelectedItem);

            目前資料_.需求1 = (物品資料)(this.物品選取元件1.SelectedItem);
            目前資料_.需求2 = (物品資料)(this.物品選取元件2.SelectedItem);
            目前資料_.需求3 = (物品資料)(this.物品選取元件3.SelectedItem);
            目前資料_.需求4 = (物品資料)(this.物品選取元件4.SelectedItem);
            目前資料_.需求5 = (物品資料)(this.物品選取元件5.SelectedItem);

            目前資料_.數量1 = (int)(this.數量1.Value);
            目前資料_.數量2 = (int)(this.數量2.Value);
            目前資料_.數量3 = (int)(this.數量3.Value);
            目前資料_.數量4 = (int)(this.數量4.Value);
            目前資料_.數量5 = (int)(this.數量5.Value);

            目前資料_.售價 = this.售價.Value;
            目前資料_.寄庫數量 = (int)(this.寄庫數量.Value);
        }

        public override void 索引切換_更新呈現()
        {
            商品資料 目前資料_ = (商品資料)(this.頁索引元件1.目前資料);

            this.名稱.Text = 目前資料_.名稱;
            this.品號.Text = 目前資料_.品號;

            this.商品大類選取元件1.SelectedItem = 目前資料_.大類;
            this.商品小類選取元件1.SelectedItem = 目前資料_.小類;

            this.公司選取元件1.SelectedItem = 目前資料_.公司;
            this.客戶選取元件1.SelectedItem = 目前資料_.客戶;

            this.物品選取元件1.SelectedItem = 目前資料_.需求1;
            this.物品選取元件2.SelectedItem = 目前資料_.需求2;
            this.物品選取元件3.SelectedItem = 目前資料_.需求3;
            this.物品選取元件4.SelectedItem = 目前資料_.需求4;
            this.物品選取元件5.SelectedItem = 目前資料_.需求5;

            this.數量1.Value = 目前資料_.數量1;
            this.數量2.Value = 目前資料_.數量2;
            this.數量3.Value = 目前資料_.數量3;
            this.數量4.Value = 目前資料_.數量4;
            this.數量5.Value = 目前資料_.數量5;

            this.成本.Value = 目前資料_.成本;
            this.售價.Value = 目前資料_.售價;
            this.利潤.Value = 目前資料_.利潤;
            this.體積.Value = 目前資料_.體積;

            this.寄庫數量.Value = 目前資料_.寄庫數量;
        }
    }
}
