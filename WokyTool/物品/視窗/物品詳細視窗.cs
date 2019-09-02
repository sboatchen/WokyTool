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

    public partial class 物品詳細視窗 : 新版詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.物品; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 物品資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        public 物品詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            大類.初始化();
            小類.初始化();
            品牌.初始化();

            base.初始化();

            資料綁定(this.名稱, "名稱");
            資料綁定(this.縮寫, "縮寫");
            資料綁定(this.類別, "類別");
            資料綁定(this.顏色, "顏色");

            資料綁定(this.條碼, "條碼");
            資料綁定(this.原廠編號, "原廠編號");
            資料綁定(this.代理編號, "代理編號");

            資料綁定(this.大類, "大類");
            資料綁定(this.小類, "小類");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.體積, "體積");
            資料綁定(this.庫存, "庫存");
            資料綁定(this.庫存總成本, "庫存總成本");
            資料綁定(this.最後進貨成本, "最後進貨成本");
            資料綁定(this.成本, "成本");

            資料綁定(this.成本備註, "成本備註");
        }
    }
}