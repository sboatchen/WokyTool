using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WokyTool.月結帳;
using WokyTool.平台訂單;
using WokyTool.單品;
using WokyTool.商品;
using WokyTool.通用;
using WokyTool.聯絡人;
using System.Linq;
using WokyTool.客戶;
using WokyTool.一般訂單;

namespace WokyTool.測試
{
    public partial class 測試主視窗 : Form
    {
        public 測試主視窗()
        {
            InitializeComponent();      
        }

        private void 時間ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 時間測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 檔案測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 綁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 資料編輯總覽測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 拷貝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 拷貝測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 清單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 資料清單測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 合法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 合法性測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 訊息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 訊息測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 詳細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 資料編輯詳細測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 可匯出匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 可匯入匯出測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new PDF測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new Image測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 單品合併ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = new 單品合併測試視窗();
            i.Show();
            i.BringToFront();
        }

        private void 快速清除庫存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            單品資料管理器.獨體.清除庫存();
            單品資料管理器.獨體.儲存();
            商品資料管理器.獨體.清除庫存();
            商品資料管理器.獨體.儲存();
        }

        /*private void 月結帳匯出(object sender, EventArgs e)
        {
            string 月分 = "09";

            string json = 檔案.讀出("歷史/" + 月分 + "/物品.json");
            var 單品資料書_ = JsonConvert.DeserializeObject<Dictionary<int, 月結帳單品資料>>(json).Where(Value => Value.Value.縮寫.Contains("真瓷")).ToDictionary(Value => Value.Key, Value => Value.Value);

            foreach (var x in 單品資料書_.Keys)
            {
                訊息管理器.獨體.訊息(x);
            }

            訊息管理器.獨體.訊息("-----------");

            json = 檔案.讀出("歷史/" + 月分 + "/商品V2.1.1.json");
            var 商品資料書_ = JsonConvert.DeserializeObject<Dictionary<int, 月結帳商品資料>>(json).Where(Value => Value.Value.初始化(單品資料書_)).ToDictionary(Value => Value.Key, Value => Value.Value);

            foreach (var x in 商品資料書_.Keys)
            {
                訊息管理器.獨體.訊息(x);
            }

            訊息管理器.獨體.訊息("-----------");

            json = 檔案.讀出("歷史/" + 月分 + "/月結帳.json");
            var 月結帳資料書_ = JsonConvert.DeserializeObject<Dictionary<int, 月結帳統計資料>>(json);

            月結帳統計轉換 月結帳統計轉換_ = new 月結帳統計轉換();
            月結帳商品資料 月結帳商品資料_ = null;
            foreach (var x in 月結帳資料書_.Values)
            {
                if (商品資料書_.TryGetValue(x.商品編號, out 月結帳商品資料_))
                {
                    foreach (var 需求Pair_ in 月結帳商品資料_.需求)
                    {
                        if(月結帳統計轉換_.資料書.ContainsKey(需求Pair_.Key))
                        {
                            月結帳統計轉換_.資料書[需求Pair_.Key] += 需求Pair_.Value * x.數量;
                        } 
                        else
                        {
                            月結帳統計轉換_.資料書[需求Pair_.Key] = 需求Pair_.Value * x.數量;
                        }
                    }
                }
            }

            String 標題_ = String.Format("真瓷統計_{0}", 月分);
            檔案.詢問並寫入(標題_, 月結帳統計轉換_);
        }*/

        private void 快速_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 平台訂單配送轉換資料_蝦皮_全家(null);
            檔案.詢問並修改(轉換_, true);
        }
    }
}
