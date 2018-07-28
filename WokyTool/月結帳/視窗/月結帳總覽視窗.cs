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
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public partial class 月結帳總覽視窗 : 總覽視窗
    {
        private int _公司資料版本 = -1;
        private int _客戶資料版本 = -1;
        private int _商品資料版本 = -1;

        public 月結帳總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.月結帳資料BindingSource, 月結帳資料管理器.獨體);
        }


        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編碼類型.月結帳, 列舉.視窗類型.篩選);
        }

        private void 總覽ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            //var ItemGroup_ = 月結帳資料管理器.獨體.可編輯BList
            //                    .GroupBy(
            //                        Value => Value.客戶.名稱,
            //                        Value => new 月結帳總覽匯出轉換(Value));

            //string Title_ = String.Format("月結帳總覽_{0}", 時間.目前日期);
            //函式.ExportExcel<月結帳總覽匯出轉換>(Title_, ItemGroup_);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((月結帳資料)(this.月結帳資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編碼類型.月結帳, 列舉.視窗類型.詳細, 編號_);
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_公司資料版本 != 公司資料管理器.獨體.唯讀資料版本)
            {
                _公司資料版本 = 公司資料管理器.獨體.唯讀資料版本;
                this.公司資料BindingSource.DataSource = 公司資料管理器.獨體.唯讀BList;
            }

            if (_客戶資料版本 != 客戶資料管理器.獨體.唯讀資料版本)
            {
                _客戶資料版本 = 客戶資料管理器.獨體.唯讀資料版本;
                this.客戶資料BindingSource.DataSource = 客戶資料管理器.獨體.唯讀BList;
            }

            if (_商品資料版本 != 商品資料管理器.獨體.唯讀資料版本)
            {
                _商品資料版本 = 商品資料管理器.獨體.唯讀資料版本;
                this.商品資料BindingSource.DataSource = 商品資料管理器.獨體.唯讀BList;
            }
        }
    }
}
