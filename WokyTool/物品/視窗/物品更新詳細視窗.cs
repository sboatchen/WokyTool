using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.物品{

    public partial class 物品更新詳細視窗 : 更新詳細視窗
    {
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        // 介面編輯呈現用
        public 物品更新詳細視窗() : base()
        {
            InitializeComponent();
        }

        public 物品更新詳細視窗(可編輯列舉資料管理介面 更新管理器_) : base(更新管理器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            大類.初始化();
            小類.初始化();
            品牌.初始化();
            參考大類.初始化();
            參考小類.初始化();
            參考品牌.初始化();

            base.初始化();

            資料綁定(this.更新狀態, "更新狀態");
            資料綁定(this.錯誤訊息, "錯誤訊息");

            資料綁定(this.名稱, "名稱");
            資料綁定(this.縮寫, "縮寫");
            資料綁定(this.類別, "類別");
            資料綁定(this.顏色, "顏色");

            資料綁定(this.國際條碼, "國際條碼");

            資料綁定(this.大類, "大類");
            資料綁定(this.小類, "小類");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.體積, "體積");
            資料綁定(this.庫存, "庫存");
            資料綁定(this.庫存總成本, "庫存總成本");
            資料綁定(this.最後進貨成本, "最後進貨成本");
            資料綁定(this.成本, "成本");

            資料綁定(this.成本備註, "成本備註");


            資料綁定(this.參考名稱, "參考名稱");
            資料綁定(this.參考縮寫, "參考縮寫");
            資料綁定(this.參考類別, "參考類別");
            資料綁定(this.參考顏色, "參考顏色");

            資料綁定(this.參考國際條碼, "參考國際條碼");

            資料綁定(this.參考大類, "參考大類");
            資料綁定(this.參考小類, "參考小類");
            資料綁定(this.參考品牌, "參考品牌");

            資料綁定(this.參考體積, "參考體積");
            資料綁定(this.參考庫存, "參考庫存");
            資料綁定(this.參考庫存總成本, "參考庫存總成本");
            資料綁定(this.參考最後進貨成本, "參考最後進貨成本");
            資料綁定(this.參考成本, "參考成本");

            資料綁定(this.參考成本備註, "參考成本備註");

            資料異動顯示綁定(this.名稱, this.參考名稱);
            資料異動顯示綁定(this.縮寫, this.參考縮寫);
            資料異動顯示綁定(this.類別, this.參考類別);
            資料異動顯示綁定(this.顏色, this.參考顏色);

            資料異動顯示綁定(this.國際條碼, this.參考國際條碼);

            資料異動顯示綁定(this.大類, this.參考大類);
            資料異動顯示綁定(this.小類, this.參考小類);
            資料異動顯示綁定(this.品牌, this.參考品牌);

            資料異動顯示綁定(this.體積, this.參考體積);
            資料異動顯示綁定(this.庫存, this.參考庫存);
            資料異動顯示綁定(this.庫存總成本, this.參考庫存總成本);
            資料異動顯示綁定(this.最後進貨成本, this.參考最後進貨成本);

            資料異動顯示綁定(this.成本備註, this.參考成本備註);
        }
    }
}