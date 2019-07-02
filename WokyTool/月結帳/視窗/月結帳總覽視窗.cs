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
using WokyTool.物品;
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
            視窗管理器.獨體.顯現(列舉.編號.月結帳, 列舉.視窗.篩選);
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.月結帳會計, 列舉.視窗.總覽);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((月結帳資料)(this.月結帳資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編號.月結帳, 列舉.視窗.詳細, 編號_);
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

        private void 物品統計ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.物品統計ToolStripMenuItem.Enabled = false;

            物品合併資料 物品合併資料_ = new 物品合併資料();
            foreach (月結帳資料 月結帳資料_ in 月結帳資料管理器.獨體.可編輯BList)
            {
                物品合併資料_.新增_忽視錯誤(月結帳資料_.商品, 月結帳資料_.數量);
            }

            var GroupQueue_ = 物品合併資料_.Map.GroupBy(Value => Value.Key.品牌);

            List<可序列化_Excel> 資料列_ = new List<可序列化_Excel>();
            foreach (var Group_ in GroupQueue_)
            {
                資料列_.Add(new 月結帳物品統計匯出轉換(Group_));
            }
            資料列_.Add(new 月結帳物品統計總覽匯出轉換(GroupQueue_));

            String Title_ = String.Format("物品統計_{0}", 時間.目前日期);
            檔案.寫入Excel(Title_, 資料列_);

            訊息管理器.獨體.Notify("已完成匯出");

            this.物品統計ToolStripMenuItem.Enabled = true;
        }

            

        private void 品牌營業額ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.品牌營業額ToolStripMenuItem.Enabled = false;

            Dictionary<物品品牌資料, decimal> Map_ = new Dictionary<物品品牌資料, decimal>();
            foreach (月結帳資料 月結帳資料_ in 月結帳資料管理器.獨體.可編輯BList)
            {
                物品品牌資料 品牌_ = 月結帳資料_.商品.品牌;

                decimal 目前金額_ = 0;
                if (Map_.TryGetValue(品牌_, out 目前金額_))
                {
                    Map_[品牌_] = 目前金額_ + 月結帳資料_.總金額;
                }
                else
                {
                    Map_.Add(品牌_, 月結帳資料_.總金額);
                }
            }

            可序列化_Excel 可序列化_ = new 月結帳品牌營業額匯出轉換(Map_);

            String Title_ = String.Format("品牌營業額_{0}", 時間.目前日期);
            檔案.寫入Excel(Title_, 可序列化_);

            訊息管理器.獨體.Notify("已完成匯出");

            this.品牌營業額ToolStripMenuItem.Enabled = true;
        }

        private void 商品統計ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.商品統計ToolStripMenuItem.Enabled = false;

            Dictionary<商品資料, 月結帳商品統計暫存資料> Map_ = new Dictionary<商品資料, 月結帳商品統計暫存資料>();
            foreach (月結帳資料 月結帳資料_ in 月結帳資料管理器.獨體.可編輯BList)
            {
                商品資料 商品_ = 月結帳資料_.商品;

                月結帳商品統計暫存資料 暫存資料_ = null;
                if (Map_.TryGetValue(商品_, out 暫存資料_))
                {
                    暫存資料_.營業額 += 月結帳資料_.總金額;
                    暫存資料_.數量 += 月結帳資料_.數量;
                }
                else
                {
                    暫存資料_ = new 月結帳商品統計暫存資料
                    {
                        數量 = 月結帳資料_.數量,
                        營業額 = 月結帳資料_.總金額,
                    };

                    Map_.Add(商品_, 暫存資料_);
                }
            }

            可序列化_Excel 可序列化_ = new 月結帳商品統計匯出轉換(Map_);

            String Title_ = String.Format("商品統計_{0}", 時間.目前日期);
            檔案.寫入Excel(Title_, 可序列化_);

            訊息管理器.獨體.Notify("已完成匯出");

            this.商品統計ToolStripMenuItem.Enabled = true;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            Console.WriteLine(e.Exception.Message);
        }
    }
}
