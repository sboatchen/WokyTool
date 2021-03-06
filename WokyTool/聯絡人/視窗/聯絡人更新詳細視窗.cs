﻿using System;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.聯絡人
{
    public partial class 聯絡人更新詳細視窗 : 新增詳細視窗
    {
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        // 介面編輯呈現用
        public 聯絡人更新詳細視窗() : base()
        {
            InitializeComponent();
        }

        public 聯絡人更新詳細視窗(可編輯列舉資料管理介面 更新管理器_) : base(更新管理器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            資料綁定(this.更新狀態選取元件1, "更新狀態");
            資料綁定(this.錯誤訊息, "錯誤訊息");

            資料綁定(this.姓名, "姓名");
            資料綁定(this.電話, "電話");
            資料綁定(this.手機, "手機");
            資料綁定(this.地址, "地址");
            資料綁定(this.客戶, "客戶");
            資料綁定(this.子客戶, "子客戶");

            資料綁定(this.參考姓名, "參考姓名");
            資料綁定(this.參考電話, "參考電話");
            資料綁定(this.參考手機, "參考手機");
            資料綁定(this.參考地址, "參考地址");
            資料綁定(this.參考客戶, "參考客戶");
            資料綁定(this.參考子客戶, "參考子客戶");

            資料異動顯示綁定(this.姓名, this.參考姓名);
            資料異動顯示綁定(this.電話, this.參考電話);
            資料異動顯示綁定(this.手機, this.參考手機);
            資料異動顯示綁定(this.地址, this.參考地址);
            資料異動顯示綁定(this.客戶, this.參考客戶);
            資料異動顯示綁定(this.子客戶, this.參考子客戶);

            this.客戶.下拉選單.SelectedValueChanged += new EventHandler(this._on客戶更新);
        }

        private void _on客戶更新(object sender, EventArgs e)
        {
            if (this.客戶.SelectedItem != null)
                this.子客戶.篩選器.客戶 = (客戶資料)this.客戶.SelectedItem;
            else
                this.子客戶.篩選器.客戶 = 客戶資料.空白;
        }
    }
}
