using WokyTool.通用;

namespace WokyTool.盤點
{
    public partial class 盤點更新篩選視窗 : 更新篩選視窗
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
            物品.初始化();

            base.初始化();

            資料綁定(this.物品, "物品");
            資料綁定(this.備註, "備註");
        }
    }
}