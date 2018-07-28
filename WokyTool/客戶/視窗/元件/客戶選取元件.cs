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
    public partial class 客戶選取元件 : 抽象選取元件
    {
        protected override ComboBox 下拉選單
        {
            get
            {
                return this.comboBox1;
            } 
        }

        protected override BindingSource 綁定資源
        {
            get
            {
                return this.客戶資料BindingSource;
            }
        }

        protected override 資料管理器介面 資料管理器
        {
            get
            {
                return 客戶資料管理器.獨體;
            }
        }

        protected override object 篩選(String Name_)
        {
            return 客戶資料管理器.獨體.唯讀BList.Where(Value => Value.名稱.Contains(Name_)).ToList();
        }

        public 客戶選取元件()
        {
            InitializeComponent();
            初始化();
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null)
                return;

            int 編號_ = ((客戶資料)SelectedItem).編號;
            視窗管理器.獨體.顯現(列舉.編碼類型.客戶, 列舉.視窗類型.詳細, 編號_);
        }
    }
}