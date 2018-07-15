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
        private int _商品大類資料版本 = -1; //@@ 嘗試建立 下拉選單選取元件(選取元件介面) 統一處理; 視窗介面 新增 綁定(編碼類型, BindingSource)
        private int _商品小類資料版本 = -1;
        private int _公司資料版本 = -1;
        private int _客戶資料版本 = -1;
        private int _物品資料版本 = -1;

        public 商品總覽視窗()
        {
            InitializeComponent();

            this.初始化<商品資料>(this.商品資料BindingSource, 商品資料管理器.獨體);
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編碼類型.商品, 列舉.視窗類型.篩選);
        }

        private void 總表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            //var ItemGroup_ = 商品資料管理器.獨體.可編輯BList
            //                    .Where(Value => Value.編號 > 0)
            //                    .GroupBy(
            //                        Value => Value.品牌.名稱,
            //                        Value => new 商品總覽匯出轉換(Value));

            //string Title_ = String.Format("商品總覽_{0}", 共用.NowYMDDec);
            //函式.ExportExcel<商品總覽匯出轉換>(Title_, ItemGroup_);
        }

        private void 自訂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            MessageBox.Show("功能尚未實作", 字串.確認, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void 商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            MessageBox.Show("功能尚未實作", 字串.確認, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /********************************/
        // 詳細視窗樣板_子客戶

        protected override void 視窗激活()
        {
            if (_商品大類資料版本 != 商品大類資料管理器.獨體.BindingVersion)
            {
                _商品大類資料版本 = 商品大類資料管理器.獨體.BindingVersion;
                this.商品大類資料BindingSource.DataSource = 商品大類資料管理器.獨體.唯讀BList;
            }

            if (_商品小類資料版本 != 商品小類資料管理器.獨體.BindingVersion)
            {
                _商品小類資料版本 = 商品小類資料管理器.獨體.BindingVersion;
                this.商品小類資料BindingSource.DataSource = 商品小類資料管理器.獨體.唯讀BList;
            }

            if (_公司資料版本 != 公司資料管理器.獨體.BindingVersion)
            {
                _公司資料版本 = 公司資料管理器.獨體.BindingVersion;
                this.公司資料BindingSource.DataSource = 公司資料管理器.獨體.唯讀BList;
            }

            if (_客戶資料版本 != 客戶資料管理器.獨體.BindingVersion)
            {
                _客戶資料版本 = 客戶資料管理器.獨體.BindingVersion;
                this.客戶資料BindingSource.DataSource = 客戶資料管理器.獨體.唯讀BList;
            }

            if (_物品資料版本 != 物品資料管理器.獨體.BindingVersion)
            {
                _物品資料版本 = 物品資料管理器.獨體.BindingVersion;
                this.物品資料BindingSource.DataSource = 物品資料管理器.獨體.唯讀BList;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int 編號_ = ((商品資料)(this.商品資料BindingSource.Current)).編號;
            //視窗管理器.獨體.顯現(列舉.編碼類型.商品, 列舉.視窗類型.詳細, 編號_);
        }
    }
}
