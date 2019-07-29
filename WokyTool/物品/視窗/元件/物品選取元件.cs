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

namespace WokyTool.物品
{
    public partial class 物品選取元件 : 抽象選取元件
    {
        public override ComboBox 下拉選單
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
                return this.物品資料BindingSource;
            }
        }

        protected override 可選取資料列管理介面 資料管理器
        {
            get
            {
                return 物品資料管理器.獨體;
            }
        }

        protected override object 篩選(String Name_)
        {
            if (Name_ == null)
                return 物品資料管理器.獨體.唯讀BList;
            return 物品資料管理器.獨體.唯讀BList.Where(Value => Value.名稱.Contains(Name_)).ToList();
        }

        public 物品選取元件()
        {
            InitializeComponent();
            初始化();
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null)
                return;

            int 編號_ = ((物品資料)SelectedItem).編號;
            視窗管理器.獨體.顯現(列舉.編號.物品, 列舉.視窗.詳細, 編號_);
        }
    }
}
