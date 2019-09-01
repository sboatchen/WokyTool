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
using WokyTool.廠商;

namespace WokyTool.月結帳
{
    public partial class 月結帳支出新增匯入視窗 : 匯入視窗
    {
        protected 月結帳支出新增匯入管理器 _月結帳支出新增匯入管理器 = new 月結帳支出新增匯入管理器();

        private int _廠商資料版本 = -1;

        public 月結帳支出新增匯入視窗()
        {
            InitializeComponent();

            this.初始化(月結帳支出新增匯入資料BindingSource, _月結帳支出新增匯入管理器);
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            舊函式.GetFile("月結帳支出新增匯入範本", "樣板/月結帳/月結帳支出新增匯入範本.xlsx");
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _月結帳支出新增匯入管理器.新增(月結帳支出新增匯入資料.匯入Excel<月結帳支出新增匯入資料>());
            if (_月結帳支出新增匯入管理器.是否正在編輯() == false)
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
            var 轉換_ = new 月結帳支出新增錯誤匯出轉換(_月結帳支出新增匯入管理器.可編輯BList.Where(Value => Value.錯誤訊息 != null));

            string 標題_ = String.Format("月結帳支出新增錯誤匯出_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_廠商資料版本 != 廠商資料管理器.獨體.可選取資料列版本)
            {
                _廠商資料版本 = 廠商資料管理器.獨體.可選取資料列版本;
                this.廠商資料BindingSource.DataSource = 廠商資料管理器.獨體.唯讀BList;
            }
        }

        protected override void 視窗關閉()
        {
        }
    }
}
