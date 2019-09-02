using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.聯絡人
{
    public partial class 聯絡人詳細視窗 : 新版詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.聯絡人; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 聯絡人資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }


        public 聯絡人詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            資料綁定(this.姓名, "姓名");
            資料綁定(this.電話, "電話");
            資料綁定(this.手機, "手機");
            資料綁定(this.地址, "地址");
            資料綁定(this.客戶選取元件1, "客戶");
            資料綁定(this.子客戶選取元件1, "子客戶");

            this.客戶選取元件1.下拉選單.SelectedValueChanged += new EventHandler(this._on客戶更新);
        }

        private void _on客戶更新(object sender, EventArgs e)
        {
            if (this.客戶選取元件1.SelectedItem != null)
                this.子客戶選取元件1.篩選器.客戶 = (客戶資料)this.客戶選取元件1.SelectedItem;
            else
                this.子客戶選取元件1.篩選器.客戶 = 客戶資料.空白;
        }
    }
}
