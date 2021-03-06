﻿using WokyTool.通用;

namespace WokyTool.進貨
{
    public partial class 進貨新增匯入篩選視窗 : 新增篩選視窗
    {
        // 介面編輯呈現用
        public 進貨新增匯入篩選視窗()
            : base()
        {
            InitializeComponent();
        }

        public 進貨新增匯入篩選視窗(視窗可篩選介面 視窗篩選器_)
            : base(視窗篩選器_)
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

            資料綁定(this.備註, "備註");
        }
    }
}