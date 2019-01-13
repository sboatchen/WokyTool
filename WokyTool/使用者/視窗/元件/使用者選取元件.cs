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

namespace WokyTool.使用者
{
    public partial class 使用者選取元件 : 抽象選取元件
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
                return this.使用者資料BindingSource;
            }
        }

        protected override 資料管理器介面 資料管理器
        {
            get
            {
                return 使用者資料管理器.獨體;
            }
        }

        protected override object 篩選(String Name_)
        {
            if (Name_ == null)
                return 使用者資料管理器.獨體.唯讀BList;
            return 使用者資料管理器.獨體.唯讀BList.Where(Value => Value.名稱.Contains(Name_)).ToList();
        }

        public 使用者選取元件()
        {
            InitializeComponent();
            初始化();
        }
    }
}
