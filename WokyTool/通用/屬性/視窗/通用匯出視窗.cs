using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public partial class 通用匯出視窗 : Form
    {
        public Type 資料類型 { get; protected set; }

        private List<PropertyInfo> _可用欄位列 = new List<PropertyInfo>();
        private List<string> _可用欄位名稱列 = new List<string>();

        public 通用匯出視窗(Type 資料類型_)
        {
            InitializeComponent();

            資料類型 = 資料類型_;

            foreach (PropertyInfo 欄位_ in 資料類型.GetProperties())
            {
                var 屬性列舉_ = 欄位_.GetCustomAttributes(typeof(可匯出匯入Attribute), true).Cast<可匯出匯入Attribute>();
                if (屬性列舉_.Count() == 0)
                    continue;

                可匯出匯入Attribute 屬性_ = 屬性列舉_.First();
                if (屬性_.匯出 == false)
                    continue;

                _可用欄位列.Add(欄位_);
                _可用欄位名稱列.Add(欄位_.Name);
            }

            //this.檔案格式BindingSource
            this.切檔方式.DataSource = _可用欄位名稱列;
            this.分頁方式.DataSource = _可用欄位名稱列;
            this.屬性.DataSource = _可用欄位名稱列;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
