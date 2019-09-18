using System;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public /*abstract*/ class 抽象選取元件 : UserControl, 選取元件介面
    {
        private int _資料版本 = -1;

        public virtual ComboBox 下拉選單
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

        protected virtual 可選取資料列管理介面 資料管理器
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

        protected Boolean 篩選異動{ get; set; }

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

        public bool ReadOnly 
        {
            get
            {
                return this.下拉選單.DropDownStyle == ComboBoxStyle.Simple;
            }

            set
            {
                if(value == true)
                    this.下拉選單.DropDownStyle = ComboBoxStyle.Simple;
                else
                    this.下拉選單.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        public void 初始化()
        {
            this.下拉選單.DropDown += new System.EventHandler(this.開啟選單);
            this.下拉選單.TextChanged += new System.EventHandler(this.篩選文字異動);
        }

        public void 視窗激活()
        {
            if (_資料版本 != 資料管理器.可選取資料列版本)
            {
                _資料版本 = 資料管理器.可選取資料列版本;
                更新資源();
            }
        }

        private void 開啟選單(object sender, EventArgs e)
        {
            if (篩選異動)
            {
                更新資源();
            }
        }

        private void 篩選文字異動(object sender, EventArgs e)
        {
            篩選異動 = true;
        }

        private void 更新資源()
        {
            _資料版本 = 資料管理器.可選取資料列版本;
            篩選異動 = false;

            if (this.下拉選單.SelectedItem != null)
            {
                this.綁定資源.DataSource = 篩選(null);
            }
            else
            {
                this.綁定資源.DataSource = 篩選(this.下拉選單.Text);
            }

            this.綁定資源.ResetBindings(false);
        }
    }
}
