using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WokyTool.通用;
using WokyTool.月結帳;
using WokyTool.發票;
using WokyTool.測試;
using WokyTool.廢棄;
using WokyTool.預留;

namespace WokyTool
{
    public partial class 主視窗 : Form
    {
        public 主視窗()
        {
            InitializeComponent();

            預留資料管理器.獨體.更新();
        }

        private void 主視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void 使用者_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.使用者, 列舉.視窗.總覽);
        }

        private void 參數_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.參數, 列舉.視窗.總覽);
        }

        /*****************************/

        private void 公司_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.公司, 列舉.視窗.總覽);
        }

        private void 客戶_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.客戶, 列舉.視窗.總覽);
        }

        private void 子客戶_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.子客戶, 列舉.視窗.總覽);
        }

        private void 聯絡人_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.聯絡人, 列舉.視窗.總覽);
        }

        private void 品類_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.品類, 列舉.視窗.總覽);
        }

        private void 供應商_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.供應商, 列舉.視窗.總覽);
        }

        private void 品牌_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.品牌, 列舉.視窗.總覽);
        }

        private void 物品_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.物品, 列舉.視窗.總覽);
        }

        private void 商品_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.商品, 列舉.視窗.總覽);
        }

        private void 廠商_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.廠商, 列舉.視窗.總覽);
        }

        private void 整理_Click(object sender, EventArgs e)
        {
            可整理管理器.獨體.整理();
        }

        /*****************************/

        private void 平台_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.平台訂單新增, 列舉.視窗.總覽);
        }

        private void 一般_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.一般訂單新增, 列舉.視窗.總覽);
        }

        private void 訂單_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.平台訂單, 列舉.視窗.總覽);
        }

        /*****************************/

        private void 寄庫總覽_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.寄庫, 列舉.視窗.總覽);
        }

        private void 寄庫新增_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.寄庫新增, 列舉.視窗.總覽);
        }

        private void 進貨新增_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.進貨新增, 列舉.視窗.總覽);
        }

        private void 進貨總覽_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.進貨, 列舉.視窗.總覽);
        }

        private void 預留新增_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.預留新增, 列舉.視窗.總覽);
        }

        private void 預留總覽_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.預留, 列舉.視窗.總覽);
        }

        private void 盤點_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.盤點, 列舉.視窗.總覽);
        }

        /*****************************/


        private void button35_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.月結帳設定, 列舉.視窗.總覽);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var i = new 月結帳匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.月結帳, 列舉.視窗.總覽);
        }

        private void button38_Click(object sender, EventArgs e)
        {
        }

        private int 編號轉換(int Old_)
        {
            if(Old_ == -1)
                return 常數.錯誤資料編碼;
            if(Old_ == 0)
                return 常數.空白資料編碼;

            return Old_;
        }

        // test
        private void button27_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            Dictionary<int, 月結帳匯入設定資料> Map;
            if (File.Exists(openFileDialog.FileName))
            {
                string json = 檔案.讀出(openFileDialog.FileName);
                if (String.IsNullOrEmpty(json))
                    Map = new Dictionary<int, 月結帳匯入設定資料>();
                else
                    Map = JsonConvert.DeserializeObject<Dictionary<int, 月結帳匯入設定資料>>(json);
            }
            else
            {
                Map = new Dictionary<int, 月結帳匯入設定資料>();
            }

            foreach (var x in Map.Values)
                x.編號 = 常數.新建資料編碼;

            月結帳匯入設定資料管理器.獨體.新增(Map.Values);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            var i = new 發票匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            訊息管理器.獨體.訊息("月結帳資料轉換");
            月結帳資料管理器.獨體.Map.Clear();

            Dictionary<int, 月結帳舊資料> Map = null;

            if (File.Exists("進度/月結帳.json"))
            {
                string json = 檔案.讀出("進度/月結帳.json");
                if (String.IsNullOrEmpty(json))
                    Map = new Dictionary<int, 月結帳舊資料>();
                else
                    Map = JsonConvert.DeserializeObject<Dictionary<int, 月結帳舊資料>>(json);
            }
            else
            {
                Map = new Dictionary<int, 月結帳舊資料>();
            }

            foreach (var Item_ in Map.Values)
            {
                if (Item_.編號 <= 0)
                    continue;

                月結帳匯入設定資料 設定_ = 月結帳匯入設定資料管理器.獨體.Get(Item_.公司.編號, Item_.客戶.編號);

                月結帳資料 New_ = new 月結帳資料
                {
                    編號 = Item_.編號,
                    訂單編號 = Item_.訂單編號,
                    設定 = 設定_,
                    商品 = Item_.商品,
                    數量 = Item_.數量,
                    單價 = Item_.單價,
                    含稅單價 = Item_.含稅單價,
                };

                月結帳資料管理器.獨體.Map.Add(New_.編號, New_);
            }
            月結帳資料管理器.獨體.資料搬移();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            資料儲存管理器.獨體.儲存();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.月結帳支出, 列舉.視窗.總覽);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.一般訂單, 列舉.視窗.總覽);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            var i = new 測試主視窗();
            i.Show();
            i.BringToFront();
        }

        private void 客戶資料轉換_Click(object sender, EventArgs e)
        {
            舊客戶資料轉換 轉換 = new 舊客戶資料轉換();
            轉換.轉換();
        }
    }
}
