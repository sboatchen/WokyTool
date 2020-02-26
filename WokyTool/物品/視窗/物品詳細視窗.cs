using WokyTool.通用;

namespace WokyTool.單品{

    public partial class 單品詳細視窗 : 獨體詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.單品; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 單品資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        public 單品詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            品類.初始化();
            供應商.初始化();
            品牌.初始化();

            base.初始化();

            資料綁定(this.名稱, "名稱");
            資料綁定(this.縮寫, "縮寫");
            資料綁定(this.類別, "類別");
            資料綁定(this.顏色, "顏色");

            資料綁定(this.國際條碼, "國際條碼");

            資料綁定(this.品類, "品類");
            資料綁定(this.供應商, "供應商");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.體積, "體積");
            資料綁定(this.庫存, "庫存");
            資料綁定(this.保留, "保留");

            資料綁定(this.庫存總成本, "庫存總成本");
            資料綁定(this.最後進貨成本, "最後進貨成本");
            資料綁定(this.成本, "成本");

            資料綁定(this.成本備註, "成本備註");
            資料綁定(this.儲位, "儲位");
        }
    }
}