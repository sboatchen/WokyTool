using WokyTool.通用;

namespace WokyTool.活動
{
    public partial class 活動篩選視窗 : 獨體篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.活動; } }

        public override 視窗可篩選介面 視窗篩選器 { get { return 活動資料管理器.獨體.編輯管理器.視窗篩選器; } }

        public 活動篩選視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            物品.初始化();

            base.初始化();

            資料綁定(this.最小活動日期, "最小活動日期");
            資料綁定(this.最大活動日期, "最大活動日期");

            資料綁定(this.名稱, "文字");
            資料綁定(this.姓名, "姓名");

            資料綁定(this.物品, "物品");
            資料綁定(this.備註, "備註");
        }
    }
}