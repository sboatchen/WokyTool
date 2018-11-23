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
using WokyTool.通用;

namespace WokyTool.物品
{
    public partial class 物品條碼更新匯入視窗 : 匯入視窗
    {
        protected int _物品資料版本 = -1; 

        protected 物品條碼更新匯入管理器 _匯入管理器 = new 物品條碼更新匯入管理器();

        public 物品條碼更新匯入視窗()
        {
            InitializeComponent();

            this.更新狀態BindingSource.DataSource = Enum.GetValues(typeof(列舉.更新狀態));

            this.初始化(物品條碼更新匯入資料BindingSource, _匯入管理器);
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            函式.GetFile("物品條碼更新匯入範本", "樣板/設定/物品條碼更新匯入範本.xlsx");
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _匯入管理器.新增(物品條碼更新匯入資料.匯入Excel<物品條碼更新匯入資料>());
            if (_匯入管理器.是否正在編輯() == false)
                return;

            this.匯入ToolStripMenuItem.Enabled = false;

            this.OnActivated(null);
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            更新資料合法性();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Items_ = new 物品條碼更新錯誤匯出轉換(_匯入管理器.可編輯BList.Where(Value => Value.錯誤訊息 != null));

            string Title_ = String.Format("物品條碼更新錯誤匯出_{0}", 時間.目前日期);
            檔案.寫入Excel(Title_, Items_);
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_物品資料版本 != 物品資料管理器.獨體.唯讀資料版本)
            {
                _物品資料版本 = 物品資料管理器.獨體.唯讀資料版本;
                this.物品資料BindingSource.DataSource = 物品資料管理器.獨體.唯讀BList;
            }
        }

        protected override void 視窗關閉()
        {
        }
    }
}
