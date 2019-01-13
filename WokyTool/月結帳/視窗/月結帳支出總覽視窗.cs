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
using WokyTool.廠商;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public partial class 月結帳支出總覽視窗 : 總覽視窗
    {
        private int _廠商資料版本 = -1;

        public 月結帳支出總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.月結帳支出資料BindingSource, 月結帳支出資料管理器.獨體);
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 月結帳支出新增匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            可序列化_Excel 月結帳支出匯出轉換_ = new 月結帳支出匯出轉換(月結帳支出資料管理器.獨體.可編輯BList);

            string Title_ = String.Format("月結帳支出總覽_{0}", 時間.目前日期);
            檔案.寫入Excel(Title_, 月結帳支出匯出轉換_);

            訊息管理器.獨體.Notify("匯出完成");
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_廠商資料版本 != 廠商資料管理器.獨體.唯讀資料版本)
            {
                _廠商資料版本 = 廠商資料管理器.獨體.唯讀資料版本;
                this.廠商資料BindingSource.DataSource = 廠商資料管理器.獨體.唯讀BList;
            }
        }
    }
}
