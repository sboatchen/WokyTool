using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 可匯入匯出測試視窗 : Form
    {
        public 可匯入匯出測試視窗()
        {
            InitializeComponent();
        }

        private void 屬性取得_Click(object sender, EventArgs e)
        {
            var 欄位列舉_ = typeof(物品資料).GetProperties();
            foreach (var 欄位_ in 欄位列舉_)
            {
                var 屬性列舉_ = 欄位_.GetCustomAttributes(typeof(可匯出匯入Attribute), true).Cast<可匯出匯入Attribute>();
                if (屬性列舉_.Count() == 0)
                    continue;

                var 屬性_ = 屬性列舉_.First();
                Console.WriteLine(欄位_.ToString());
                Console.WriteLine(屬性_.ToString());
            }
        }
    }
}
