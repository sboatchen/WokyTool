using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public partial class 盤點更新詳細視窗 : 更新詳細視窗
    {
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        // 介面編輯呈現用
        public 盤點更新詳細視窗() : base()
        {
            InitializeComponent();
        }

        public 盤點更新詳細視窗(可編輯列舉資料管理介面 更新管理器_)
            : base(更新管理器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            物品.初始化();
            參考物品.初始化();

            base.初始化();

            資料綁定(this.更新狀態, "更新狀態");
            資料綁定(this.錯誤訊息, "錯誤訊息");

            資料綁定(this.物品, "物品");

            資料綁定(this.大料架庫存, "大料架庫存");
            資料綁定(this.小料架庫存, "小料架庫存");
            資料綁定(this.萬通庫存, "萬通庫存");

            資料綁定(this.備註, "備註");

            資料綁定(this.參考物品, "參考物品");

            資料綁定(this.參考大料架庫存, "參考大料架庫存");
            資料綁定(this.參考小料架庫存, "參考小料架庫存");
            資料綁定(this.參考萬通庫存, "參考萬通庫存");

            資料綁定(this.參考備註, "參考備註");

            資料異動顯示綁定(this.物品, this.參考物品);

            資料異動顯示綁定(this.大料架庫存, this.參考大料架庫存);
            資料異動顯示綁定(this.小料架庫存, this.參考小料架庫存);
            資料異動顯示綁定(this.萬通庫存, this.參考萬通庫存);

            資料異動顯示綁定(this.備註, this.參考備註);
        }
    }
}