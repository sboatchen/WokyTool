using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;
using WokyTool.Common;

namespace WokyTool.客戶
{
    public partial class 客戶選取元件 : 新版抽象選取元件
    {
        public override BindingSource 資料BS { get { return this.客戶資料BindingSource; } }
        public override ComboBox 下拉選單 { get { return this.comboBox1; } }

        protected override 可清單列舉資料管理介面 取得管理器實體()
        {
            switch (元件類型)
            {
                case 選取元件類型.指定:
                    return 客戶資料管理器.獨體.清單管理器;
                case 選取元件類型.篩選:
                    return 客戶資料管理器.獨體.篩選管理器;
                default:
                    訊息管理器.獨體.錯誤(this.GetType().Name + "不支援元件類型:" + 元件類型);
                    return null;
            }
        }

        public 客戶資料篩選 篩選器 { get; protected set; }

        public 客戶選取元件(選取元件類型 元件類型_)
        {
            元件類型 = 元件類型_;

            InitializeComponent();
            初始化();

            篩選器 = (客戶資料篩選)管理器.視窗篩選器;
        }

        public 客戶選取元件() : this(選取元件類型.指定)
        {
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null)
                return;

            int 編號_ = ((客戶資料)SelectedItem).編號;
            視窗管理器.獨體.顯現(列舉.編號.客戶, 列舉.視窗.詳細, 編號_);
        }
    }
}