using Newtonsoft.Json;
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
    public partial class 物品總覽視窗 : 新版總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.物品; } }

        public override 可編輯列舉資料管理介面 管理介面 { get { return 物品資料管理器.獨體.編輯管理器; } }
        public override DataGridView 資料GV { get { return this.dataGridView1; } }

        public 物品總覽視窗()
        {
            InitializeComponent();

            this.初始化();

            this.更新ToolStripMenuItem.Enabled = 管理介面.是否可編輯;
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.物品, 列舉.視窗.篩選);
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            列表處理檢查管理器 檢查管理器_ = new 列表處理檢查管理器();
            管理介面.合法檢查(檢查管理器_);

            var i = new 錯誤列表視窗(檢查管理器_, 編號類型.ToString());
            i.Show();
            i.BringToFront();

            //@@@@
            //List<可寫入介面_EXCEL> 所有錯誤_ = new List<可寫入介面_EXCEL>();

            //List<String> 合法性檢查_ = new List<string>();
            //foreach(var Item_ in 物品資料管理器.獨體.可編輯BList)
            //{
            //    try
            //    {
            //        Item_.檢查合法();
            //    }
            //    catch (Exception ex)
            //    {
            //        合法性檢查_.Add(Item_.名稱 + ":" + ex.Message);
            //    }
            //}

            //if (合法性檢查_.Count != 0)
            //    所有錯誤_.Add(new 字串轉換("合法性", 合法性檢查_));

            ///******************/

            //List<String> 名稱重複檢查_ = 物品資料管理器.獨體.可編輯BList
            //                                .GroupBy(Value => Value.名稱)
            //                                .Where(Value => Value.Count() > 1)
            //                                .Select(Value => Value.Key)
            //                                .ToList();

            //if (名稱重複檢查_.Count != 0)
            //    所有錯誤_.Add(new 字串轉換("名稱重複", 名稱重複檢查_));

            ///******************/

            //List<String> 縮寫重複檢查_ = 物品資料管理器.獨體.可編輯BList
            //                               .GroupBy(Value => Value.縮寫)
            //                               .Where(Value => Value.Count() > 1)
            //                               .Select(Value => Value.Key)
            //                               .ToList();

            //if (縮寫重複檢查_.Count != 0)
            //    所有錯誤_.Add(new 字串轉換("縮寫重複", 縮寫重複檢查_));

            //if (所有錯誤_.Count > 0)
            //{
            //    string 標題_ = String.Format("物品錯誤匯出_{0}", 時間.目前日期);
            //    檔案.詢問並寫入(標題_, 所有錯誤_);
            //}

            //訊息管理器.獨體.通知("處理完畢");
        }



        private void 總表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            //@@ TODO
            /*var ItemGroup_ = 物品資料管理器.獨體.可編輯BList
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

            訊息管理器.獨體.通知("匯出完成");*/
        }

        private void 庫存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            /*var ItemGroup_ = 物品資料管理器.獨體.可編輯BList
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

            訊息管理器.獨體.通知("匯出完成");*/
        }

        private void 盤點ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@@ TODO
            /*var Item_ = 物品資料管理器.獨體.可編輯BList
                               .Where(Value => (Value.編號 > 0) && (String.IsNullOrEmpty(Value.條碼) == false))
                               .Select(Value => new 物品盤點匯出轉換(Value));

            string Title_ = String.Format("盤點匯出_{0}", 時間.目前日期);
            舊函式.ExportCSV<物品盤點匯出轉換>(Title_, Item_);*/
        }

        private void 細節ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*this.Enabled = false;

            物品細節匯出轉換 轉換_ = new 物品細節匯出轉換(物品資料管理器.獨體.可編輯BList);

            string 標題_ = String.Format("物品細節_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            this.Enabled = true;

            訊息管理器.獨體.通知("匯出完成");*/
        }

        private void 自訂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void 類別ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "json files (.json)|*.json";
            if (OFD_.ShowDialog() != DialogResult.OK)
                return;

            string 內容_ = 檔案.讀出(OFD_.FileName);
            Dictionary<int, 物品資料> 資料書_ = JsonConvert.DeserializeObject<Dictionary<int, 物品資料>>(內容_);
            
            列表處理檢查管理器 檢查_ = new 列表處理檢查管理器();

            foreach(物品資料 更新資料_ in 資料書_.Values)
            {
                if(string.IsNullOrEmpty(更新資料_.類別) && string.IsNullOrEmpty(更新資料_.顏色))
                    continue;

                物品資料 物品資料_ = 物品資料管理器.獨體.取得(更新資料_.名稱);
                if(物品資料_.編號是否有值() == false)
                {
                    檢查_.錯誤(更新資料_, "編號有問題");
                    continue;
                }

                物品資料_.BeginEdit();
                物品資料_.類別 = 更新資料_.類別;
                物品資料_.顏色 = 更新資料_.顏色;
            }

            if (檢查_.字串列.Count > 0)
            {
                var i = new 錯誤列表視窗(檢查_, "類別更新錯誤");
                i.Show();
                i.BringToFront();
            }
        }
    }
}
