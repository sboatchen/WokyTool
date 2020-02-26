using WokyTool.通用;

namespace WokyTool.商品{

    public partial class 商品篩選視窗 : 獨體篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.商品; } }

        public override 視窗可篩選介面 視窗篩選器 { get { return 商品資料管理器.獨體.編輯管理器.視窗篩選器; } }

        public 商品篩選視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            客戶.初始化();
            公司.初始化();

            品類.初始化();
            供應商.初始化();
            品牌.初始化();

            單品.初始化();

            base.初始化();

            資料綁定(this.名稱, "文字");
            資料綁定(this.品號, "品號");

            資料綁定(this.品類, "品類");
            資料綁定(this.供應商, "供應商");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");

            資料綁定(this.單品, "單品");

            資料綁定(this.最小寄庫數量, "最小寄庫數量");
            資料綁定(this.最大寄庫數量, "最大寄庫數量");

            資料綁定(this.最小利潤, "最小利潤");
            資料綁定(this.最大利潤, "最大利潤");
        }
    }
}

