﻿using WokyTool.通用;

namespace WokyTool.配送
{
    public partial class 配送新增篩選視窗 : 新增篩選視窗
    {
        // 介面編輯呈現用
        public 配送新增篩選視窗()
            : base()
        {
            InitializeComponent();
        }

        public 配送新增篩選視窗(視窗可篩選介面 視窗篩選器_)
            : base(視窗篩選器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            資料綁定(this.配送公司, "配送公司");
            資料綁定(this.配送單號, "配送單號");

            資料綁定(this.姓名, "姓名");
            資料綁定(this.地址, "地址");
            資料綁定(this.電話, "電話");
            資料綁定(this.手機, "手機");
            資料綁定(this.備註, "備註");

            資料綁定(this.指配日期, "指配日期");
            資料綁定(this.指配時段, "指配時段");

            資料綁定(this.代收方式, "代收方式");
            資料綁定(this.最小代收金額, "最小代收金額");
            資料綁定(this.最大代收金額, "最大代收金額");

            資料綁定(this.最小件數, "最小件數");
            資料綁定(this.最大件數, "最大件數");
            資料綁定(this.內容, "文字");
        }
    }
}