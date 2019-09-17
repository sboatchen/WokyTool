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

namespace WokyTool.寄庫
{
    public partial class 寄庫匯入篩選視窗 : 新增篩選視窗
    {
        // 介面編輯呈現用
        public 寄庫匯入篩選視窗()
            : base()
        {
            InitializeComponent();
        }

        public 寄庫匯入篩選視窗(視窗可篩選介面 視窗篩選器_)
            : base(視窗篩選器_)
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

            資料綁定(this.備註, "備註");

            資料綁定(this.最小處理時間, "最小處理時間");
            資料綁定(this.最大處理時間, "最大處理時間");

            資料綁定(this.入庫單號, "文字");

            this.公司.下拉選單.SelectedValueChanged += new EventHandler(this._on商品列表更新);
            this.客戶.下拉選單.SelectedValueChanged += new EventHandler(this._on商品列表更新);
        }

        private void _on商品列表更新(object sender, EventArgs e)
        {
            Console.WriteLine("_on商品列表更新");
            this.商品.篩選器.公司 = (公司資料)this.公司.SelectedItem;
            this.商品.篩選器.客戶 = (客戶資料)this.客戶.SelectedItem;
        }
    }
}