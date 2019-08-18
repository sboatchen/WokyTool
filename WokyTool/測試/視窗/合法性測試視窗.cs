using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 合法性測試視窗 : Form
    {
        private List<讀寫測試資料> _資料列 = new List<讀寫測試資料>();

        public 合法性測試視窗()
        {
            InitializeComponent();


            _資料列.Add(
                new 讀寫測試資料
                {
                    整數 = -1,
                    浮點數 = -1,
                }
            );

            _資料列.Add(
                new 讀寫測試資料
                {
                    整數 = -2,
                    浮點數 = -2,
                }
            );
        }

        private void 例外_Click(object sender, EventArgs e)
        {
            例外處理檢查管理器 管理器_ = new 例外處理檢查管理器();

            foreach (var 資料_ in _資料列)
            {
                資料_.合法檢查(管理器_);
            }

        }

        private void 列表_Click(object sender, EventArgs e)
        {
            列表處理檢查管理器 管理器_ = new 列表處理檢查管理器();

            foreach (var 資料_ in _資料列)
            {
                資料_.合法檢查(管理器_);
            }

            var i = new 錯誤列表視窗(管理器_);
            i.Show();
            i.BringToFront();
        }
    }
}
