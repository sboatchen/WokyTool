using WokyTool.通用;

namespace WokyTool.預留
{
    public partial class 預留詳細視窗 : 獨體詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.預留; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 預留資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        // 介面編輯呈現用
        public 預留詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            物品.初始化();

            base.初始化();

            資料綁定(this.開始日期, "開始日期");
            資料綁定(this.結束日期, "結束日期");

            資料綁定(this.名稱, "名稱");
            資料綁定(this.姓名, "姓名");

            資料綁定(this.物品, "物品");
            資料綁定(this.數量, "數量");

            資料綁定(this.備註, "備註");
        }
    }
}