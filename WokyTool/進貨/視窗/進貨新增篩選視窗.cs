﻿using WokyTool.通用;

namespace WokyTool.進貨
{
    public partial class 進貨新增篩選視窗 : 獨體篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.進貨新增; } }

        public override 視窗可篩選介面 視窗篩選器 { get { return 進貨新增資料管理器.獨體.視窗篩選器; } }

        public 進貨新增篩選視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            廠商.初始化();
            物品.初始化();

            base.初始化();

            資料綁定(this.類型, "類型");

            資料綁定(this.廠商, "廠商");

            資料綁定(this.物品, "物品");

            資料綁定(this.備註, "備註");
        }
    }
}