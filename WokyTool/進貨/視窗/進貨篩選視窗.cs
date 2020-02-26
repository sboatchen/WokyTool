using System;
using WokyTool.廠商;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.進貨
{
    public partial class 進貨篩選視窗 : 獨體篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.進貨; } }

        public override 視窗可篩選介面 視窗篩選器 { get { return 進貨資料管理器.獨體.編輯管理器.視窗篩選器; } }

        public 進貨篩選視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            廠商.初始化();
            單品.初始化();

            base.初始化();

            資料綁定(this.最小處理時間, "最小處理時間");
            資料綁定(this.最大處理時間, "最大處理時間");
            資料綁定(this.處理者, "處理者");

            資料綁定(this.類型, "類型");

            資料綁定(this.廠商, "廠商");
            
            資料綁定(this.單品, "單品");

            資料綁定(this.備註, "備註");
        }
    }
}