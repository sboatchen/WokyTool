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
using WokyTool.物品;
using WokyTool.通用;
using WokyTool.廠商;

namespace WokyTool.進貨
{
    public partial class 進貨總覽視窗 : 總覽視窗
    {
        private int _廠商資料版本 = -1;
        private int _物品資料版本 = -1;

        public 進貨總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.進貨資料BindingSource, 進貨資料管理器.獨體);

            this.進貨BindingSource.DataSource = Enum.GetValues(typeof(列舉.進貨));
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.Notify("尚未實作");
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Item_ = new 進貨總覽匯出轉換(進貨資料管理器.獨體.可編輯BList);

            string Title_ = String.Format("進貨總覽_{0}", 時間.目前日期);
            檔案.寫入Excel(Title_, Item_);
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 進貨新增匯入視窗();
            i.Show();
            i.BringToFront();
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_廠商資料版本 != 廠商資料管理器.獨體.唯讀資料版本)
            {
                _廠商資料版本 = 廠商資料管理器.獨體.唯讀資料版本;
                this.廠商資料BindingSource.DataSource = 廠商資料管理器.獨體.唯讀BList;
            }

            if (_物品資料版本 != 物品資料管理器.獨體.唯讀資料版本)
            {
                _物品資料版本 = 物品資料管理器.獨體.唯讀資料版本;
                this.物品資料BindingSource.DataSource = 物品資料管理器.獨體.唯讀BList;
            }
        }
    }
}
