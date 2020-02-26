using WokyTool.通用;

namespace WokyTool.進貨
{
    public partial class 進貨新增匯入詳細視窗 : 新增詳細視窗
    {
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        // 介面編輯呈現用
        public 進貨新增匯入詳細視窗() : base()
        {
            InitializeComponent();
        }

        public 進貨新增匯入詳細視窗(可編輯列舉資料管理介面 更新管理器_)
            : base(更新管理器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            供應商.初始化();
            單品.初始化();

            base.初始化();

            資料綁定(this.類型, "類型");

            資料綁定(this.供應商, "供應商");

            資料綁定(this.單品, "單品");

            資料綁定(this.數量, "數量");
            資料綁定(this.單價, "單價");

            資料綁定(this.備註, "備註");

            資料綁定(this.錯誤訊息, "錯誤訊息");
        }
    }
}