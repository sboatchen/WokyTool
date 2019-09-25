using System;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    public partial class 寄庫篩選視窗 : 獨體篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.寄庫; } }

        public override 視窗可篩選介面 視窗篩選器 { get { return 寄庫資料管理器.獨體.編輯管理器.視窗篩選器; } }

        public 寄庫篩選視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            公司.初始化();
            客戶.初始化();
            商品.初始化();

            base.初始化();

            資料綁定(this.最小處理時間, "最小處理時間");
            資料綁定(this.最大處理時間, "最大處理時間");
            資料綁定(this.處理者, "處理者");

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");

            資料綁定(this.商品, "商品");

            資料綁定(this.入庫單號, "文字");
            資料綁定(this.備註, "備註");

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