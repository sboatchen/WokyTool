using WokyTool.通用;

namespace WokyTool.活動
{
    public partial class 活動匯入篩選視窗 : 新增篩選視窗
    {
        // 介面編輯呈現用
        public 活動匯入篩選視窗()
            : base()
        {
            InitializeComponent();
        }

        public 活動匯入篩選視窗(視窗可篩選介面 視窗篩選器_)
            : base(視窗篩選器_)
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