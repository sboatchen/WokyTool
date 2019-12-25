using WokyTool.通用;

namespace WokyTool.寄庫
{
    public partial class 寄庫詳細視窗 : 獨體詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.寄庫; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 寄庫資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.頁索引元件; } }

        // 介面編輯呈現用
        public 寄庫詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            資料綁定(this.處理時間, "處理時間");
            資料綁定(this.處理者, "處理者");

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");

            資料綁定(this.商品, "商品");
            資料綁定(this.數量, "數量");
            資料綁定(this.成本, "成本");

            資料綁定(this.入庫單號, "入庫單號");
            資料綁定(this.入庫時間, "入庫時間");

            資料綁定(this.備註, "備註");
        }
    }
}