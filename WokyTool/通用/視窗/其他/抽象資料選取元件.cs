using System;
using System.Reflection;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public enum 選取元件類型
    {
        指定 = 0,
        篩選,
    };

    public class 抽象資料選取元件 : UserControl, 可初始化介面
    {
        public virtual BindingSource 資料BS { get { throw new Exception(this.GetType().Name + " 未設定資料BS"); } }
        public virtual ComboBox 下拉選單 { get { throw new Exception(this.GetType().Name + " 未設定下拉選單"); } }

        public 選取元件類型 元件類型 { get; set; }

        protected virtual 可清單列舉資料管理介面 取得管理器實體()
        {
            throw new Exception(this.GetType().Name + " 未複寫 取得管理器實體");
        }

        public 可清單列舉資料管理介面 管理器 { get; protected set; }

        public int 資料版本 { get; protected set; }

        private PropertyInfo _呈現屬性;

        public virtual void 初始化()
        {
            管理器 = 取得管理器實體();

            Type Type_ = (Type)this.資料BS.DataSource;
            _呈現屬性 = Type_.GetProperty(this.下拉選單.DisplayMember);

            this.下拉選單.DropDown += new System.EventHandler(this._on開啟選單);
            this.下拉選單.TextChanged += new System.EventHandler(this._on文字異動);

            資料版本 = -1;
            更新資料();
        }

        public bool ReadOnly
        {
            get
            {
                return this.下拉選單.DropDownStyle == ComboBoxStyle.Simple;
            }

            set
            {
                if (value == true)
                    this.下拉選單.DropDownStyle = ComboBoxStyle.Simple;
                else
                    this.下拉選單.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        public object SelectedItem
        {
            get
            {
                return this.下拉選單.SelectedItem;
            }

            set
            {
                //Console.WriteLine("設定物件-" + this.GetType().Name);
                if (管理器 != null)
                {
                    管理器.視窗篩選器.文字 = null;
                    更新資料();
                }

                if (this.下拉選單.SelectedItem != value)
                    this.下拉選單.SelectedItem = value;
            }
        }

        private void 更新資料()
        {
            if (資料版本 != 管理器.資料版本)
            {
                object 舊選取物件_ = this.下拉選單.SelectedItem;

                資料版本 = 管理器.資料版本;
                資料BS.DataSource = 管理器.資料列舉;

                this.下拉選單.SelectedItem = 舊選取物件_;
                //Console.WriteLine("更新資料");
            }
        }

        private void _on開啟選單(object sender, EventArgs e)
        {
            //Console.WriteLine("開啟選單");
            更新資料();
        }

        private void _on文字異動(object sender, EventArgs e)
        {
            //Console.WriteLine("文字異動");
            if (this.下拉選單.SelectedItem != null)
            {
                string 目前物件呈現_ = (string)_呈現屬性.GetValue(this.下拉選單.SelectedItem);
                if (this.下拉選單.Text.Equals(目前物件呈現_))
                {
                    管理器.視窗篩選器.文字 = null;
                    return;
                }
            }

            管理器.視窗篩選器.文字 = this.下拉選單.Text;
        }
    }
}
