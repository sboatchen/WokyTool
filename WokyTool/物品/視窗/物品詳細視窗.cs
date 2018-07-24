using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.物品{

    public partial class 物品詳細視窗 : 詳細視窗
    {
        public 物品詳細視窗()
        {
            InitializeComponent();

            this.初始化(this.頁索引元件1, 物品資料管理器.獨體);
        }

        /********************************/
        // 物品詳細視窗樣板

        protected override void 視窗激活()
        {
            this.物品品牌選取元件1.視窗激活();
            this.物品大類選取元件1.視窗激活();
            this.物品小類選取元件1.視窗激活();
        }

        /********************************/
        // 頁索引上層介面

        public override void 索引切換_異動儲存()
        {
            物品資料 目前資料_ = (物品資料)(this.頁索引元件1.目前資料);

            目前資料_.名稱 = this.名稱.Text;
            目前資料_.縮寫 = this.縮寫.Text;

            目前資料_.大類 = (物品大類資料)(this.物品大類選取元件1.SelectedItem);
            目前資料_.小類 = (物品小類資料)(this.物品小類選取元件1.SelectedItem);
            目前資料_.品牌 = (物品品牌資料)(this.物品品牌選取元件1.SelectedItem);

            if (String.IsNullOrEmpty(this.條碼.Text))
                目前資料_.條碼 = null;
            else
                目前資料_.條碼 = this.條碼.Text;

            if (String.IsNullOrEmpty(this.原廠編號.Text))
                目前資料_.原廠編號 = null;
            else
                目前資料_.原廠編號 = this.原廠編號.Text;

            if (String.IsNullOrEmpty(this.代理編號.Text))
                目前資料_.代理編號 = null;
            else
                目前資料_.代理編號 = this.代理編號.Text;

            目前資料_.體積 = (int)(this.體積.Value);

            if (String.IsNullOrEmpty(this.顏色.Text))
                目前資料_.顏色 = null;
            else
                目前資料_.顏色 = this.顏色.Text;

            目前資料_.內庫數量 = (int)(this.內庫數量.Value);
            目前資料_.外庫數量 = (int)(this.外庫數量.Value);

            目前資料_.庫存總成本 = this.庫存總成本.Value;
            目前資料_.最後進貨成本 = this.最後進貨成本.Value;

            if (String.IsNullOrEmpty(this.成本備註.Text))
                目前資料_.成本備註 = null;
            else
                目前資料_.成本備註 = this.成本備註.Text;
        }

        public override void 索引切換_更新呈現()
        {
            物品資料 目前資料_ = (物品資料)(this.頁索引元件1.目前資料);

            this.名稱.Text = 目前資料_.名稱;
            this.縮寫.Text = 目前資料_.縮寫;

            this.物品大類選取元件1.SelectedItem = 目前資料_.大類;
            this.物品小類選取元件1.SelectedItem = 目前資料_.小類;
            this.物品品牌選取元件1.SelectedItem = 目前資料_.品牌;

            this.條碼.Text = 目前資料_.條碼;
            this.原廠編號.Text = 目前資料_.原廠編號;
            this.代理編號.Text = 目前資料_.代理編號;

            this.體積.Value = 目前資料_.體積;
            this.顏色.Text = 目前資料_.顏色;

            this.內庫數量.Value = 目前資料_.內庫數量;
            this.外庫數量.Value = 目前資料_.外庫數量;
            this.庫存總量.Value = 目前資料_.庫存總量;

            this.庫存總成本.Value = 目前資料_.庫存總成本;
            this.最後進貨成本.Value = 目前資料_.最後進貨成本;
            this.成本.Value = 目前資料_.成本;
            this.成本備註.Text = 目前資料_.成本備註;
        }
    }
}
