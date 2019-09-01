using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataExport;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.商品
{
    public partial class 商品總覽視窗 : 總覽視窗
    {
        public 商品總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.商品資料BindingSource, 商品資料管理器.獨體);

            this.更新ToolStripMenuItem.Enabled = 商品資料管理器.獨體.是否可編輯;
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.商品, 列舉.視窗.篩選);
        }

        private void 總表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = 商品資料管理器.獨體.可編輯BList
                               .GroupBy(
                                   Value => Value.客戶.名稱,
                                   Value => Value);

            List<可寫入介面_EXCEL> 轉換列_ = new List<可寫入介面_EXCEL>();
            foreach (var x in ItemGroup_)
            {
                商品總覽匯出轉換 匯出轉換_ = new 商品總覽匯出轉換(x.Key, x);
                轉換列_.Add(匯出轉換_);
            }

            string 標題_ = String.Format("商品總覽_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換列_);
        }

        private void 自訂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            訊息管理器.獨體.通知(字串.功能尚未實作);
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 商品新增匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((商品資料)(this.商品資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編號.商品, 列舉.視窗.詳細, 編號_);
        }

        /********************************/

        protected override void 視窗激活()
        {
        }
    }
}
