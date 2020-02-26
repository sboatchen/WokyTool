using WokyTool.通用;

namespace WokyTool.商品{

    public partial class 商品更新篩選視窗 : 新增篩選視窗
    {
        // 介面編輯呈現用
        public 商品更新篩選視窗() : base()
        {
            InitializeComponent();
        }

        public 商品更新篩選視窗(視窗可篩選介面 視窗篩選器_) : base(視窗篩選器_)
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

            物品.初始化();

            base.初始化();

            資料綁定(this.更新狀態, "更新狀態");

            資料綁定(this.名稱, "文字");
            資料綁定(this.品號, "品號");

            資料綁定(this.品類, "品類");
            資料綁定(this.供應商, "供應商");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");

            資料綁定(this.物品, "物品");

            資料綁定(this.最小寄庫數量, "最小寄庫數量");
            資料綁定(this.最大寄庫數量, "最大寄庫數量");

            資料綁定(this.最小利潤, "最小利潤");
            資料綁定(this.最大利潤, "最大利潤");
        }
    }
}

