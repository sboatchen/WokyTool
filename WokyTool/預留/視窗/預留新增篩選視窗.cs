﻿using WokyTool.通用;

namespace WokyTool.預留
{
    public partial class 預留新增篩選視窗 : 獨體篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.預留新增; } }

        public override 視窗可篩選介面 視窗篩選器 { get { return 預留新增資料管理器.獨體.視窗篩選器; } }

        public 預留新增篩選視窗()
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