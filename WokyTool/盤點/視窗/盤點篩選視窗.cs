using WokyTool.通用;

namespace WokyTool.盤點
{
    public partial class 盤點篩選視窗 : 獨體篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.盤點; } }

        public override 視窗可篩選介面 視窗篩選器 { get { return 盤點資料管理器.獨體.編輯管理器.視窗篩選器; } }

        public 盤點篩選視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            物品.初始化();

            base.初始化();

            資料綁定(this.物品, "物品");
            資料綁定(this.備註, "備註");
            資料綁定(this.是否一致, "是否一致");
        }
    }
}