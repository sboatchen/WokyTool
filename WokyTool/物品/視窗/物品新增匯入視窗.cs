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
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.物品
{
    public partial class 物品新增匯入視窗 : 匯入視窗
    {
        protected 物品新增匯入管理器 _物品新增匯入管理器 = new 物品新增匯入管理器();
        protected 物品新增匯入詳細視窗 _物品新增匯入詳細視窗 = null;

        public 物品新增匯入視窗()
        {
            InitializeComponent();

            this.初始化(物品新增匯入資料BindingSource, _物品新增匯入管理器);
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            舊函式.GetFile("物品新增匯入範本", "樣板/設定/物品新增匯入範本.xlsx");
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _物品新增匯入管理器.新增(物品新增匯入資料.匯入Excel<物品新增匯入資料>());
            if (_物品新增匯入管理器.是否正在編輯() == false)
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
            var 轉換_ = new 物品新增錯誤匯出轉換(_物品新增匯入管理器.可編輯BList.Where(Value => Value.錯誤訊息 != null));

            string 標題_ = String.Format("物品新增錯誤匯出_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//
        {
            if (_物品新增匯入詳細視窗 == null)
                _物品新增匯入詳細視窗 = new 物品新增匯入詳細視窗(_物品新增匯入管理器);

            _物品新增匯入詳細視窗.顯現(this.物品新增匯入資料BindingSource.Position);
        }

        /********************************/

        protected override void 視窗激活()
        {
        }

        protected override void 視窗關閉()
        {
            if (_物品新增匯入詳細視窗 != null)
                _物品新增匯入詳細視窗.關閉();
        }
    }
}
