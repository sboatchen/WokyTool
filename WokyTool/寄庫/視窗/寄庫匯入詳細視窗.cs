using System;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    public partial class 寄庫匯入詳細視窗 : 新增詳細視窗
    {
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        // 介面編輯呈現用
        public 寄庫匯入詳細視窗() : base()
        {
            InitializeComponent();
        }

        public 寄庫匯入詳細視窗(可編輯列舉資料管理介面 更新管理器_)
            : base(更新管理器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            公司.初始化();
            客戶.初始化();
            商品.初始化();

            base.初始化();

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");

            資料綁定(this.商品, "商品");
            資料綁定(this.數量, "數量");

            資料綁定(this.入庫單號, "入庫單號");
            資料綁定(this.入庫時間, "入庫時間");
            資料綁定(this.備註, "備註");

            資料綁定(this.錯誤訊息, "錯誤訊息");

            this.公司.下拉選單.SelectedValueChanged += new EventHandler(this._on商品列表更新);
            this.客戶.下拉選單.SelectedValueChanged += new EventHandler(this._on商品列表更新);
        }

        private void _on商品列表更新(object sender, EventArgs e)
        {
            //Console.WriteLine("_on商品列表更新");
            this.商品.篩選器.公司 = (公司資料)this.公司.SelectedItem;
            this.商品.篩選器.客戶 = (客戶資料)this.客戶.SelectedItem;
        }
    }
}