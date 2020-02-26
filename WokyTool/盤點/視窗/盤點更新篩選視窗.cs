using WokyTool.通用;

namespace WokyTool.盤點
{
    public partial class 盤點更新篩選視窗 : 新增篩選視窗
    {
        // 介面編輯呈現用
        public 盤點更新篩選視窗()
            : base()
        {
            InitializeComponent();
        }

        public 盤點更新篩選視窗(視窗可篩選介面 視窗篩選器_)
            : base(視窗篩選器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            單品.初始化();

            base.初始化();

            資料綁定(this.更新狀態, "更新狀態");
            資料綁定(this.單品, "單品");
            資料綁定(this.備註, "備註");
        }
    }
}