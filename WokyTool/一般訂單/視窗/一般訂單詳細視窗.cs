using System;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    public partial class 一般訂單詳細視窗 : 獨體詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.一般訂單; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 一般訂單資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        public 一般訂單詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            資料綁定(this.處理時間, "處理時間");
            資料綁定(this.處理狀態, "處理狀態");
            資料綁定(this.處理者, "處理者");

            資料綁定(this.公司名稱, "公司名稱");
            資料綁定(this.客戶名稱, "客戶名稱");
            資料綁定(this.子客戶名稱, "子客戶名稱");
            資料綁定(this.單品名稱, "單品名稱");

            資料綁定(this.數量, "數量");
            資料綁定(this.單價, "單價");
            資料綁定(this.成本, "成本");
            資料綁定(this.利潤, "利潤");
            資料綁定(this.總利潤, "總利潤");

            資料綁定(this.姓名, "姓名");
            資料綁定(this.地址, "地址");
            資料綁定(this.電話, "電話");
            資料綁定(this.手機, "手機");
            資料綁定(this.備註, "備註");

            資料綁定(this.配送公司, "配送公司");
            資料綁定(this.配送單號, "配送單號");

            資料綁定(this.指配日期, "指配日期");
            資料綁定(this.指配時段, "指配時段");

            資料綁定(this.代收方式, "代收方式");
            資料綁定(this.代收金額, "代收金額");
        }
    }
}