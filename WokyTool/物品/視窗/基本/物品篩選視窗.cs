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

namespace WokyTool.物品
{
    public partial class 物品篩選視窗 : 新版篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.物品; } }

        public override 可篩選介面_視窗 可篩選視窗介面 { get { return 物品資料管理器.獨體.編輯管理器.篩選介面; } }

        //protected 物品資料篩選設定 _物品資料篩選設定 = new 物品資料篩選設定();

        public 物品篩選視窗()
        {
            InitializeComponent();

            this.初始化();

            資料綁定(this.名稱, "名稱");
            資料綁定(this.類別, "類別");
            資料綁定(this.顏色, "顏色");

            資料綁定(this.條碼, "條碼");
            資料綁定(this.原廠編號, "原廠編號");
            資料綁定(this.代理編號, "代理編號");

            資料綁定(this.物品大類選取元件1, "大類");
            資料綁定(this.物品小類選取元件1, "小類");
            資料綁定(this.物品品牌選取元件1, "品牌");

            資料綁定(this.最小庫存, "最小庫存");
            資料綁定(this.最大庫存, "最大庫存");
        }
    }
}
