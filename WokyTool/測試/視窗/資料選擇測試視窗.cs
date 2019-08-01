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

namespace WokyTool.測試
{
    public partial class 資料選擇測試視窗 : Form
    {
        private bool _條件異動 = false;

        public 資料選擇測試視窗()
        {
            InitializeComponent();

            this.排序.DataSource = typeof(讀寫測試資料).GetProperties().Select(Value => Value.Name).ToList();
            this.comboBox1.DataSource = 讀寫測試資料管理器.獨體.取得可選取資料列舉(讀寫測試資料管理器.獨體.篩選介面);
        }

        private void 字串_TextChanged(object sender, EventArgs e)
        {
            讀寫測試資料管理器.獨體.篩選介面.字串 = this.字串.Text;
            _條件異動 = true;

            Console.WriteLine("字串: " + 讀寫測試資料管理器.獨體.篩選介面.字串);
        }

        private void 整數1_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)this.整數1.Value;
            if (value < 0)
                讀寫測試資料管理器.獨體.篩選介面.最小整數 = null;
            else
                讀寫測試資料管理器.獨體.篩選介面.最小整數 = value;

            _條件異動 = true;

            Console.WriteLine("最小整數: " + 讀寫測試資料管理器.獨體.篩選介面.最小整數);
        }

        private void 整數2_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)this.整數2.Value;
            if (value < 0)
                讀寫測試資料管理器.獨體.篩選介面.最大整數 = null;
            else
                讀寫測試資料管理器.獨體.篩選介面.最大整數 = value;

            _條件異動 = true;

            Console.WriteLine("最大整數: " + 讀寫測試資料管理器.獨體.篩選介面.最大整數);
        }

        private void 排序_TextChanged(object sender, EventArgs e)
        {
            讀寫測試資料管理器.獨體.篩選介面.排序欄位 = this.排序.Text;
            _條件異動 = true;
            Console.WriteLine("排序: " + 讀寫測試資料管理器.獨體.篩選介面.排序欄位);
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (_條件異動)
            {
                _條件異動 = false;
                this.comboBox1.DataSource = 讀寫測試資料管理器.獨體.取得可選取資料列舉(讀寫測試資料管理器.獨體.篩選介面);

                Console.WriteLine("更新選單");
            }
        }
    }
}
