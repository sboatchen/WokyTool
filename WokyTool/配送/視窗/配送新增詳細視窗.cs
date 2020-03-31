using WokyTool.通用;

namespace WokyTool.配送
{
    public partial class 配送新增詳細視窗 : 新增詳細視窗
    {
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        // 介面編輯呈現用
        public 配送新增詳細視窗()
            : base()
        {
            InitializeComponent();
        }

        public 配送新增詳細視窗(可編輯列舉資料管理介面 更新管理器_)
            : base(更新管理器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            資料綁定(this.配送公司, "配送公司");
            資料綁定(this.配送單號, "配送單號");

            資料綁定(this.訂單編號, "訂單編號");
            資料綁定(this.姓名, "姓名");
            資料綁定(this.地址, "地址");
            資料綁定(this.電話, "電話");
            資料綁定(this.手機, "手機");
            資料綁定(this.備註, "備註");

            資料綁定(this.指配日期, "指配日期");
            資料綁定(this.指配時段, "指配時段");

            資料綁定(this.代收方式, "代收方式");
            資料綁定(this.代收金額, "代收金額");

            資料綁定(this.件數, "件數");
            資料綁定(this.內容, "內容");
        }
    }
}