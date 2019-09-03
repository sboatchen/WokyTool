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
    public partial class 聯絡人更新篩選視窗 : 更新篩選視窗
    {
        // 介面編輯呈現用
        public 聯絡人更新篩選視窗() : base()
        {
            InitializeComponent();
        }

        public 聯絡人更新篩選視窗(視窗可篩選介面 視窗篩選器_) : base(視窗篩選器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            客戶.初始化();
            子客戶.初始化();

            base.初始化();

            資料綁定(this.更新狀態, "更新狀態");

            資料綁定(this.姓名, "文字");
            資料綁定(this.電話, "電話");
            資料綁定(this.手機, "手機");
            資料綁定(this.地址, "地址");
            資料綁定(this.客戶, "客戶");
            資料綁定(this.子客戶, "子客戶");

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
