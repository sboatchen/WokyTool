using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 測試主視窗 : Form
    {
        List<讀寫測試資料> _資料列 = new List<讀寫測試資料>();

        public 測試主視窗()
        {
            InitializeComponent();

            Random 隨機_ = new Random();
            for (int i = 0; i < 100; i++)
            {
                讀寫測試資料 讀寫測試資料_ = new 讀寫測試資料
                {
                    字串 = "字串" + i,
                    整數 = i,
                    浮點數 = (float)隨機_.NextDouble(),
                    倍精準浮點數 = 隨機_.NextDouble(),
                    時間 = DateTime.Now.AddMinutes(i),
                    列舉 = (列舉.編號)(i % 10 + 1),
                };

                _資料列.Add(讀寫測試資料_);
            }
        }

        private void 時間ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 時間測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 檔案測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 綁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 資料綁定測試視窗(_資料列);
            i.Show();
            i.BringToFront();
        }

        private void 拷貝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 拷貝測試視窗();
            i.Show();
            i.BringToFront();
        }
    }
}
