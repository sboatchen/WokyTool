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
            /*公司.初始化();
            客戶.初始化();
            商品.初始化();

            base.初始化();
            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");

            資料綁定(this.商品, "商品");
            資料綁定(this.數量, "數量");

            資料綁定(this.備註, "備註");

            資料綁定(this.處理時間, "處理時間");
            資料綁定(this.入庫單號, "入庫單號");

            資料綁定(this.錯誤訊息, "錯誤訊息");*/
        }
    }
}