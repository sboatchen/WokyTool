using System;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    public partial class 一般訂單新增篩選視窗 : 獨體篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.一般訂單新增; } }

        public override 視窗可篩選介面 視窗篩選器 { get { return 一般訂單新增資料管理器.獨體.編輯管理器.視窗篩選器; } }

        public 一般訂單新增篩選視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            公司.初始化();
            客戶.初始化();
            單品.初始化();

            base.初始化();

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");
            資料綁定(this.子客戶, "子客戶");
            資料綁定(this.單品, "單品");

            資料綁定(this.姓名, "姓名");
            資料綁定(this.地址, "地址");
            資料綁定(this.電話, "電話");
            資料綁定(this.手機, "手機");
            資料綁定(this.備註, "備註");

            資料綁定(this.處理狀態, "處理狀態");

            資料綁定(this.配送公司, "配送公司");
            資料綁定(this.配送單號, "配送單號");

            資料綁定(this.指配日期, "指配日期");
            資料綁定(this.指配時段, "指配時段");

            資料綁定(this.代收方式, "代收方式");
            資料綁定(this.最小代收金額, "最小代收金額");
            資料綁定(this.最大代收金額, "最大代收金額");
        }
    }
}