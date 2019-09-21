using System;
using System.Collections.Generic;
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
            例外檢查器 管理器_ = new 例外檢查器();

            foreach (var 資料_ in _資料列)
            {
                資料_.合法檢查(管理器_);
            }

        }

        private void 列表_Click(object sender, EventArgs e)
        {
            列印檢查器 檢查器_ = new 列印檢查器();

            foreach (var 資料_ in _資料列)
            {
                資料_.合法檢查(檢查器_);
            }

            var i = new 錯誤總覽視窗(檢查器_);
            i.Show();
            i.BringToFront();
        }
    }
}
