using WokyTool.通用;

namespace WokyTool.廠商
{
    public partial class 廠商篩選視窗 : 獨體篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.廠商; } }

        public override 視窗可篩選介面 視窗篩選器 { get { return 廠商資料管理器.獨體.編輯管理器.視窗篩選器; } }

        public 廠商篩選視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            資料綁定(this.名稱, "文字");
            資料綁定(this.電話, "電話");
            資料綁定(this.手機, "手機");
            資料綁定(this.地址, "地址");
        }
    }
}
