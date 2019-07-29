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
using WokyTool.客戶;

namespace WokyTool.聯絡人
{
    public partial class 聯絡人選取元件 : 抽象選取元件
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
                return this.聯絡人資料BindingSource;
            }
        }

        protected override 可選取資料列管理介面 資料管理器
        {
            get
            {
                return 聯絡人資料管理器.獨體;
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

        private 子客戶資料 _綁定子客戶;
        public 子客戶資料 綁定子客戶
        {
            get
            {
                return _綁定子客戶;
            }
            set
            {
                _綁定子客戶 = value;
                篩選異動 = true;
            }
        }

        protected override object 篩選(String Name_)
        {
            if (綁定客戶 == null && 綁定子客戶 == null && Name_ == null)
                return 聯絡人資料管理器.獨體.唯讀BList;

            IEnumerable<聯絡人資料> query = 聯絡人資料管理器.獨體.唯讀BList;

            if (綁定子客戶 != null)
                query = query.Where(Value => 綁定子客戶.聯絡人編號列 != null && 綁定子客戶.聯絡人編號列.Contains(Value.編號));
            else if (綁定客戶 != null)
                query = query.Where(Value => 綁定客戶.聯絡人編號列 != null && 綁定客戶.聯絡人編號列.Contains(Value.編號));

            if (Name_ != null)
                query = query.Where(Value => Value.姓名.Contains(Name_));

            return query.ToList();
        }

        public 聯絡人選取元件()
        {
            InitializeComponent();
            初始化();
        }
    }
}
