using System;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.進貨
{
    public partial class 進貨新增詳細視窗 : 獨體詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.進貨新增; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 進貨新增資料管理器.獨體; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        // 介面編輯呈現用
        public 進貨新增詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            廠商.初始化();
            單品.初始化();

            base.初始化();

            資料綁定(this.類型, "類型");

            資料綁定(this.廠商, "廠商");

            資料綁定(this.單品, "單品");
            資料綁定(this.數量, "數量");
            資料綁定(this.單價, "單價");

            資料綁定(this.備註, "備註");
        }
    }
}