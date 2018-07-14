using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.物品
{
    public partial class 物品條碼更新匯入視窗 : Form
    {
        protected BindingList<物品條碼更新資料> _BList = null;

        public 物品條碼更新匯入視窗()
        {
            InitializeComponent();

            this.更新狀態BindingSource.DataSource = Enum.GetValues(typeof(列舉.更新狀態));
            this.匯出ToolStripMenuItem.Enabled = false;
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _BList = 物品條碼更新資料.匯入Excel<物品條碼更新資料>();
            if (_BList == null)
                return;

            this.匯入ToolStripMenuItem.Enabled = false;
            this.物品條碼更新資料BindingSource.DataSource = _BList;
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            函式.GetFile("條碼更新範本", "樣板/設定/條碼更新範本.xlsx");
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = _BList
                                .GroupBy(
                                    Value => Value.狀態.ToString(),
                                    Value => new 物品條碼更新匯出轉換(Value));

            string Title_ = String.Format("物品條碼更新_{0}", 共用.NowYMDDec);
            函式.ExportExcel<物品條碼更新匯出轉換>(Title_, ItemGroup_);
        }

        private void 物品條碼更新匯入視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_BList == null)
                return;

            try
            {
                foreach (var Data in _BList)
                {
                    Data.檢查合法();
                }

            }
            catch (Exception Error_)
            {
                var result = MessageBox.Show(Error_.ToString(), 字串.匯入錯誤, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }

                return;
            }

            var Result_ = MessageBox.Show(字串.匯入內容, 字串.匯入確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result_ == DialogResult.No)
                return;

            foreach (var Data in _BList)
            {
                Data.更新();
            }
        }
    }
}
