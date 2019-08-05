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
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 資料清單測試視窗 : Form
    {
        private 可篩選列舉資料管理介面 _管理介面;
        private 讀寫測試資料篩選 _篩選介面;
        private int _資料版本 = -1;

        public 資料清單測試視窗()
        {
            _管理介面 = 讀寫測試資料管理器.獨體.資料清單管理器;
            _篩選介面 = (讀寫測試資料篩選)_管理介面.篩選介面;
            _資料版本 = _管理介面.資料版本;

            InitializeComponent();

            this.排序.DataSource = typeof(讀寫測試資料).GetProperties().Select(Value => Value.Name).ToList();

            this.comboBox1.DataSource = _管理介面.資料列舉;
        }

        private void 字串_TextChanged(object sender, EventArgs e)
        {
            _篩選介面.字串 = this.字串.Text;

            Console.WriteLine("字串: " + _篩選介面.字串);
        }

        private void 整數1_ValueChanged(object sender, EventArgs e)
        {
            _篩選介面.最小整數 = (int)this.整數1.Value;

            Console.WriteLine("最小整數: " + _篩選介面.最小整數);
        }

        private void 整數2_ValueChanged(object sender, EventArgs e)
        {
            _篩選介面.最大整數 = (int)this.整數2.Value;

            Console.WriteLine("最大整數: " + _篩選介面.最大整數);
        }

        private void 排序_TextChanged(object sender, EventArgs e)
        {
            _篩選介面.排序欄位 = this.排序.Text;

            Console.WriteLine("排序: " + _篩選介面.排序欄位);
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (_資料版本 != _管理介面.資料版本)
            {
                _資料版本 = _管理介面.資料版本;
                this.comboBox1.DataSource = _管理介面.資料列舉;

                Console.WriteLine("更新選單");
            }
        }
    }
}
