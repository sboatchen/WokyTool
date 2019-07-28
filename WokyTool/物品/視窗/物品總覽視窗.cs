using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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

            this.初始化(this.物品資料BindingSource, 物品資料管理器.獨體);

            this.更新ToolStripMenuItem.Enabled = 物品資料管理器.獨體.是否可編輯;
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.物品, 列舉.視窗.篩選);
        }

        private void 總表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            var ItemGroup_ = 物品資料管理器.獨體.可編輯BList
                                .Where(Value => Value.編號 > 0)
                                .GroupBy(
                                    Value => Value.品牌.名稱,
                                    Value => Value);

            List<可寫入介面_EXCEL> 轉換列_ = new List<可寫入介面_EXCEL>();
            foreach (var x in ItemGroup_)
            {
                物品總覽匯出轉換 匯出轉換_ = new 物品總覽匯出轉換(x.Key, x);
                轉換列_.Add(匯出轉換_);
            }

            string 標題_ = String.Format("物品總覽_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換列_);

            訊息管理器.獨體.通知("匯出完成");
        }

        private void 庫存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            var ItemGroup_ = 物品資料管理器.獨體.可編輯BList
                                .Where(Value => Value.編號 > 0)
                                .GroupBy(
                                    Value => Value.品牌.名稱,
                                    Value => Value);

            List<可寫入介面_EXCEL> 轉換列_ = new List<可寫入介面_EXCEL>();
            foreach (var x in ItemGroup_)
            {
                物品庫存匯出轉換 匯出轉換_ = new 物品庫存匯出轉換(x.Key, x);
                轉換列_.Add(匯出轉換_);
            }

            //通用匯出結構 總結_ = new 通用匯出結構("總結");

            //decimal 總庫存成本_ = 物品資料管理器.獨體.可編輯BList.Select(Value => Value.庫存總成本).Sum();
            //總結_.Add("總庫存成本", 總庫存成本_.ToString());

            string 標題_ = String.Format("物品庫存_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換列_); ;

            訊息管理器.獨體.通知("匯出完成");
        }

        private void 盤點ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            var Item_ = 物品資料管理器.獨體.可編輯BList
                               .Where(Value => (Value.編號 > 0) && (String.IsNullOrEmpty(Value.條碼) == false))
                               .Select(Value => new 物品盤點匯出轉換(Value));

            string Title_ = String.Format("盤點匯出_{0}", 時間.目前日期);
            舊函式.ExportCSV<物品盤點匯出轉換>(Title_, Item_);
        }

        private void 細節ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            物品細節匯出轉換 轉換_ = new 物品細節匯出轉換(物品資料管理器.獨體.可編輯BList);

            string 標題_ = String.Format("物品細節_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            this.Enabled = true;

            訊息管理器.獨體.通知("匯出完成");
        }

        private void 自訂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            訊息管理器.獨體.通知(字串.功能尚未實作);
        }

        private void 物品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 物品新增匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void 條碼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 物品條碼更新匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void 重新匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 物品總覽更新匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((物品資料)(this.物品資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編號.物品, 列舉.視窗.詳細, 編號_);
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_物品大類資料版本 != 物品大類資料管理器.獨體.唯讀資料版本)
            {
                _物品大類資料版本 = 物品大類資料管理器.獨體.唯讀資料版本;
                this.物品大類資料BindingSource.DataSource = 物品大類資料管理器.獨體.唯讀BList;
            }

            if (_物品小類資料版本 != 物品小類資料管理器.獨體.唯讀資料版本)
            {
                _物品小類資料版本 = 物品小類資料管理器.獨體.唯讀資料版本;
                this.物品小類資料BindingSource.DataSource = 物品小類資料管理器.獨體.唯讀BList;
            }

            if (_物品品牌資料版本 != 物品品牌資料管理器.獨體.唯讀資料版本)
            {
                _物品品牌資料版本 = 物品品牌資料管理器.獨體.唯讀資料版本;
                this.物品品牌資料BindingSource.DataSource = 物品品牌資料管理器.獨體.唯讀BList;
            }
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<可寫入介面_EXCEL> 所有錯誤_ = new List<可寫入介面_EXCEL>();

            List<String> 合法性檢查_ = new List<string>();
            foreach(var Item_ in 物品資料管理器.獨體.可編輯BList)
            {
                try
                {
                    Item_.檢查合法();
                }
                catch (Exception ex)
                {
                    合法性檢查_.Add(Item_.名稱 + ":" + ex.Message);
                }
            }

            if (合法性檢查_.Count != 0)
                所有錯誤_.Add(new 通用轉換("合法性", 合法性檢查_));

            /******************/

            List<String> 名稱重複檢查_ = 物品資料管理器.獨體.可編輯BList
                                            .GroupBy(Value => Value.名稱)
                                            .Where(Value => Value.Count() > 1)
                                            .Select(Value => Value.Key)
                                            .ToList();

            if (名稱重複檢查_.Count != 0)
                所有錯誤_.Add(new 通用轉換("名稱重複", 名稱重複檢查_));

            /******************/

            List<String> 縮寫重複檢查_ = 物品資料管理器.獨體.可編輯BList
                                           .GroupBy(Value => Value.縮寫)
                                           .Where(Value => Value.Count() > 1)
                                           .Select(Value => Value.Key)
                                           .ToList();

            if (縮寫重複檢查_.Count != 0)
                所有錯誤_.Add(new 通用轉換("縮寫重複", 縮寫重複檢查_));

            if (所有錯誤_.Count > 0)
            {
                string 標題_ = String.Format("物品錯誤匯出_{0}", 時間.目前日期);
                檔案.詢問並寫入(標題_, 所有錯誤_);
            }

            訊息管理器.獨體.通知("處理完畢");
        }
    }
}
