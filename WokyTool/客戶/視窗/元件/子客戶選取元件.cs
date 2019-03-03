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
    public partial class 子客戶選取元件 : 抽象選取元件
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
                return this.子客戶資料BindingSource;
            }
        }

        protected override 資料管理器介面 資料管理器
        {
            get
            {
                return 子客戶資料管理器.獨體;
            }
        }

        private 客戶資料 _綁定客戶;
        public 客戶資料 綁定客戶
        {
            get
            {
                return _綁定客戶;
            }
            set
            {
                _綁定客戶 = value;
                篩選異動 = true;
            }
        }

        protected override object 篩選(String Name_)
        {
            if (綁定客戶 == null && Name_ == null)
                return 子客戶資料管理器.獨體.唯讀BList;

            IEnumerable<子客戶資料> query = 子客戶資料管理器.獨體.唯讀BList;

            if (綁定客戶 != null)
                query = query.Where(Value => 綁定客戶.子客戶編號列 != null && 綁定客戶.子客戶編號列.Contains(Value.編號));

            if(Name_ != null)
                query = query.Where(Value => Value.名稱.Contains(Name_));

            return query.ToList();
        }

        public 子客戶選取元件()
        {
            InitializeComponent();
            初始化();
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null)
                return;

            int 編號_ = ((子客戶資料)SelectedItem).編號;
            視窗管理器.獨體.顯現(列舉.編號.子客戶, 列舉.視窗.詳細, 編號_);
        }
    }
}