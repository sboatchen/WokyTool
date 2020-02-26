using WokyTool.通用;

namespace WokyTool.預留
{
    public partial class 預留匯入篩選視窗 : 新增篩選視窗
    {
        // 介面編輯呈現用
        public 預留匯入篩選視窗()
            : base()
        {
            InitializeComponent();
        }

        public 預留匯入篩選視窗(視窗可篩選介面 視窗篩選器_)
            : base(視窗篩選器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            單品.初始化();

            base.初始化();

            資料綁定(this.最小預留日期, "最小預留日期");
            資料綁定(this.最大預留日期, "最大預留日期");

            資料綁定(this.名稱, "文字");
            資料綁定(this.姓名, "姓名");

            資料綁定(this.單品, "單品");
            資料綁定(this.備註, "備註");
        }
    }
}