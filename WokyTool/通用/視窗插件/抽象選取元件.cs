using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public /*abstract*/ class 抽象選取元件 : UserControl, 選取元件介面
    {
        private int _資料版本 = -1;

        protected virtual ComboBox 下拉選單
        {
            get
            {
                throw new Exception("抽象選取元件:下拉選單 尚未實作");
            }
        }

        protected virtual BindingSource 綁定資源
        {
            get
            {
                throw new Exception("抽象選取元件:綁定資源 尚未實作");
            }
        }

        protected virtual 資料管理器介面 資料管理器
        {
            get
            {
                throw new Exception("抽象選取元件:資料管理器 尚未實作");
            }
        }

        protected virtual object 篩選(String Name_)
        {
            throw new Exception("抽象選取元件:篩選 尚未實作");
        }

        public object SelectedItem
        {
            get
            {
                return this.下拉選單.SelectedItem;
            }

            set
            {
                if (this.下拉選單.SelectedItem != value)
                    this.下拉選單.SelectedItem = value;
            }
        }

        public void 初始化()
        {
            this.下拉選單.DropDown += new System.EventHandler(this.開啟選單);
        }

        public void 視窗激活()
        {
            if (_資料版本 != 資料管理器.唯讀資料版本)
            {
                _資料版本 = 資料管理器.唯讀資料版本;
                this.綁定資源.DataSource = 資料管理器.物件_唯讀BList;
                this.綁定資源.ResetBindings(false);
            }
        }

        private void 開啟選單(object sender, EventArgs e)
        {
            if (this.下拉選單.SelectedValue != null)
            {
                this.綁定資源.DataSource = 資料管理器.物件_唯讀BList;
            }
            else
            {
                this.綁定資源.DataSource = 篩選(this.下拉選單.Text);
            }
        }
    }
}
