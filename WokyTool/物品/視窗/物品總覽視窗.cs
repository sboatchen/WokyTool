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
using WokyTool.通用;

namespace WokyTool.物品
{
    public partial class 物品總覽視窗 : 總覽視窗
    {
        private int _物品大類資料版本 = -1;
        private int _物品小類資料版本 = -1;
        private int _物品品牌資料版本 = -1;

        public 物品總覽視窗()
        {
            InitializeComponent();

            this.初始化<物品資料>(this.物品資料BindingSource, 物品資料管理器.獨體);
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編碼類型.物品, 列舉.視窗類型.篩選);
        }

        private void 總表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            var ItemGroup_ = 物品資料管理器.獨體.可編輯BList
                                .Where(Value => Value.編號 > 0)
                                .GroupBy(
                                    Value => Value.品牌.名稱,
                                    Value => new 物品總覽匯出轉換(Value));

            string Title_ = String.Format("物品總覽_{0}", 共用.NowYMDDec);
            函式.ExportExcel<物品總覽匯出轉換>(Title_, ItemGroup_);
        }

        private void 庫存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            var ItemGroup_ = 物品資料管理器.獨體.可編輯BList
                                .Where(Value => Value.編號 > 0)
                                .GroupBy(
                                    Value => Value.品牌.名稱,
                                    Value => new 物品庫存匯出轉換(Value));

            通用匯出結構 總結_ = new 通用匯出結構("總結");

            decimal 總庫存成本_ = 物品資料管理器.獨體.可編輯BList.Select(Value => Value.庫存總成本).Sum();
            總結_.Add("總庫存成本", 總庫存成本_.ToString());

            string Title_ = String.Format("物品庫存_{0}", 共用.NowYMDDec);
            函式.ExportExcel<物品庫存匯出轉換>(Title_, ItemGroup_, 總結_);
        }

        private void 盤點ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            var Item_ = 物品資料管理器.獨體.可編輯BList
                               .Where(Value => (Value.編號 > 0) && (String.IsNullOrEmpty(Value.條碼) == false))
                               .Select(Value => new 物品盤點匯出轉換(Value));

            string Title_ = String.Format("盤點匯出_{0}", 共用.NowYMDDec);
            函式.ExportCSV<物品盤點匯出轉換>(Title_, Item_);
        }

        private void 自訂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            MessageBox.Show("功能尚未實作", 字串.確認, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void 物品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            MessageBox.Show("功能尚未實作", 字串.確認, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void 條碼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 物品條碼更新匯入視窗();
            i.Show();
            i.BringToFront();
        }

        /********************************/
        // 詳細視窗樣板_子客戶

        protected override void 視窗激活()
        {
            if (_物品大類資料版本 != 物品大類資料管理器.獨體.BindingVersion)
            {
                _物品大類資料版本 = 物品大類資料管理器.獨體.BindingVersion;
                this.物品大類資料BindingSource.DataSource = 物品大類資料管理器.獨體.唯讀BList;
            }

            if (_物品小類資料版本 != 物品小類資料管理器.獨體.BindingVersion)
            {
                _物品小類資料版本 = 物品小類資料管理器.獨體.BindingVersion;
                this.物品小類資料BindingSource.DataSource = 物品小類資料管理器.獨體.唯讀BList;
            }

            if (_物品品牌資料版本 != 物品品牌資料管理器.獨體.BindingVersion)
            {
                _物品品牌資料版本 = 物品品牌資料管理器.獨體.BindingVersion;
                this.物品品牌資料BindingSource.DataSource = 物品品牌資料管理器.獨體.唯讀BList;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((物品資料)(this.物品資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編碼類型.物品, 列舉.視窗類型.詳細, 編號_);
        }
    }
}
