﻿using WokyTool.通用;

namespace WokyTool.單品{

    public partial class 單品更新詳細視窗 : 新增詳細視窗
    {
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        // 介面編輯呈現用
        public 單品更新詳細視窗() : base()
        {
            InitializeComponent();
        }

        public 單品更新詳細視窗(可編輯列舉資料管理介面 更新管理器_) : base(更新管理器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            品類.初始化();
            供應商.初始化();
            品牌.初始化();
            參考品類.初始化();
            參考供應商.初始化();
            參考品牌.初始化();

            base.初始化();

            資料綁定(this.更新狀態, "更新狀態");
            資料綁定(this.錯誤訊息, "錯誤訊息");

            資料綁定(this.名稱, "名稱");
            資料綁定(this.縮寫, "縮寫");
            資料綁定(this.類別, "類別");
            資料綁定(this.顏色, "顏色");

            資料綁定(this.國際條碼, "國際條碼");

            資料綁定(this.品類, "品類");
            資料綁定(this.供應商, "供應商");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.體積, "體積");
            資料綁定(this.庫存, "庫存");
            資料綁定(this.保留, "保留");

            資料綁定(this.庫存總成本, "庫存總成本");
            資料綁定(this.最後進貨成本, "最後進貨成本");
            資料綁定(this.成本, "成本");

            資料綁定(this.成本備註, "成本備註");
            資料綁定(this.儲位, "儲位");


            資料綁定(this.參考名稱, "參考名稱");
            資料綁定(this.參考縮寫, "參考縮寫");
            資料綁定(this.參考類別, "參考類別");
            資料綁定(this.參考顏色, "參考顏色");

            資料綁定(this.參考國際條碼, "參考國際條碼");

            資料綁定(this.參考品類, "參考品類");
            資料綁定(this.參考供應商, "參考供應商");
            資料綁定(this.參考品牌, "參考品牌");

            資料綁定(this.參考體積, "參考體積");
            資料綁定(this.參考庫存, "參考庫存");
            資料綁定(this.參考保留, "參考保留");

            資料綁定(this.參考庫存總成本, "參考庫存總成本");
            資料綁定(this.參考最後進貨成本, "參考最後進貨成本");
            資料綁定(this.參考成本, "參考成本");

            資料綁定(this.參考成本備註, "參考成本備註");
            資料綁定(this.參考儲位, "參考儲位");

            資料異動顯示綁定(this.名稱, this.參考名稱);
            資料異動顯示綁定(this.縮寫, this.參考縮寫);
            資料異動顯示綁定(this.類別, this.參考類別);
            資料異動顯示綁定(this.顏色, this.參考顏色);

            資料異動顯示綁定(this.國際條碼, this.參考國際條碼);

            資料異動顯示綁定(this.品類, this.參考品類);
            資料異動顯示綁定(this.供應商, this.參考供應商);
            資料異動顯示綁定(this.品牌, this.參考品牌);

            資料異動顯示綁定(this.體積, this.參考體積);
            資料異動顯示綁定(this.庫存, this.參考庫存);
            資料異動顯示綁定(this.庫存總成本, this.參考庫存總成本);
            資料異動顯示綁定(this.最後進貨成本, this.參考最後進貨成本);

            資料異動顯示綁定(this.成本備註, this.參考成本備註);
            資料異動顯示綁定(this.儲位, this.參考儲位);
        }
    }
}