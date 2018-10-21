using LINQtoCSV;
using LinqToExcel;
using log4net;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataForm;
using WokyTool.DataImport;
using WokyTool.DataMgr;
using WokyTool.FormOther;
using WokyTool.FormOverview;
using WokyTool.ImportForm;
using WokyTool.通用;
using WokyTool.月結帳;
using Excel = Microsoft.Office.Interop.Excel;
using WokyTool.聯絡人;
using WokyTool.客戶;
using WokyTool.物品;
using WokyTool.公司;
using WokyTool.商品;
using WokyTool.平台訂單;
using WokyTool.使用者;

namespace WokyTool
{
    public partial class 主視窗 : Form
    {
        public 主視窗()
        {
            InitializeComponent();
        }

        private void 主視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.編號, 列舉.視窗.總覽);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.物品大類, 列舉.視窗.總覽);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.物品小類, 列舉.視窗.總覽);
        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //@@ 搬進去
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                    var i = new 物品匯入視窗(Excel_);
                    i.Show();
                    i.BringToFront();

                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.物品, 列舉.視窗.總覽);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.商品大類, 列舉.視窗.總覽);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.商品小類, 列舉.視窗.總覽);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.商品, 列舉.視窗.總覽);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.物品品牌, 列舉.視窗.總覽);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.廠商, 列舉.視窗.總覽);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.進貨, 列舉.視窗.總覽);
        }

        private void button28_Click(object sender, EventArgs e)
        {
        }

        private void button29_Click(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var i = new 雜支總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                    var i = new 雜支匯入視窗(Excel_);
                    i.Show();
                    i.BringToFront();

                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var i = new 支出總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var i = new 幣值總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.配送, 列舉.視窗.總覽);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var i = new 商品訂單匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            var i = new 入庫總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.公司, 列舉.視窗.總覽);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);

                    var i = new 物品更新匯入視窗(Excel_);
                    i.Show();
                    i.BringToFront();
                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            var i = new 物品訂單匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            var i = new 銷售總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            函式.SaveAll();
        }

        private void 盤點出貨_Click(object sender, EventArgs e)
        {
            var i = new 盤點出貨匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            var i = new 工廠出貨視窗();
            i.Show();
            i.BringToFront();
        }

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

        private void button36_Click(object sender, EventArgs e)
        {
            非平台訂單資料管理器.Instance.Get(1);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.聯絡人, 列舉.視窗.總覽);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.客戶, 列舉.視窗.總覽);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.子客戶, 列舉.視窗.總覽);
        }


        private void button38_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.Info("公司資料轉換");
            公司資料管理器.獨體.Map.Clear();
            foreach (var Item_ in 公司管理器.Instance.Map.Values)
            {
                if (Item_.編號 <= 0)
                    continue;

                公司.公司資料 New_ = new 公司.公司資料
                {
                    編號 = Item_.編號,
                    名稱 = Item_.名稱,
                };

                公司資料管理器.獨體.Map.Add(New_.編號, New_);
            }
            公司資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("客戶資料轉換");
            客戶資料管理器.獨體.Map.Clear();
            foreach (var Item_ in 廠商管理器.Instance.Map.Values)
            {
                if (Item_.編號 <= 0)
                    continue;

                if (String.IsNullOrEmpty(Item_.聯絡人) == false)
                    continue;

                if (Item_.名稱.CompareTo("沃廚") == 0)
                    continue;

                if (Item_.名稱.CompareTo("洋承") == 0)
                    continue;

                客戶.客戶資料 New_ = new 客戶.客戶資料
                {
                    編號 = Item_.編號,
                    名稱 = Item_.名稱,
                };

                客戶資料管理器.獨體.Map.Add(New_.編號, New_);
            }
            客戶資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("物品大類資料轉換");
            物品大類資料管理器.獨體.Map.Clear();
            foreach (var Item_ in 物品大類管理器.Instance.Map.Values)
            {
                if (Item_.編號 <= 0)
                    continue;

                物品.物品大類資料 New_ = new 物品.物品大類資料
                {
                    編號 = Item_.編號,
                    名稱 = Item_.名稱,
                };

                物品大類資料管理器.獨體.Map.Add(New_.編號, New_);
            }
            物品大類資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("物品小類資料轉換");
            物品小類資料管理器.獨體.Map.Clear();
            foreach (var Item_ in 物品小類管理器.Instance.Map.Values)
            {
                if (Item_.編號 <= 0)
                    continue;

                物品.物品小類資料 New_ = new 物品.物品小類資料
                {
                    編號 = Item_.編號,
                    名稱 = Item_.名稱,
                };

                物品小類資料管理器.獨體.Map.Add(New_.編號, New_);
            }
            物品小類資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("物品品牌資料轉換");
            物品品牌資料管理器.獨體.Map.Clear();
            foreach (var Item_ in 物品品牌管理器.Instance.Map.Values)
            {
                if (Item_.編號 <= 0)
                    continue;

                物品.物品品牌資料 New_ = new 物品.物品品牌資料
                {
                    編號 = Item_.編號,
                    名稱 = Item_.名稱,
                };

                物品品牌資料管理器.獨體.Map.Add(New_.編號, New_);
            }
            物品品牌資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("物品資料轉換");
            物品資料管理器.獨體.Map.Clear();
            foreach (var Item_ in 物品管理器.Instance.Map.Values)
            {
                if (Item_.編號 <= 0)
                    continue;

                物品.物品資料 New_ = new 物品.物品資料
                {
                    編號 = Item_.編號,

                    大類編號 = 編號轉換(Item_.大類編號),
                    小類編號 = 編號轉換(Item_.小類編號),
                    品牌編號 = 編號轉換(Item_.品牌編號),

                    條碼 = Item_.條碼,
                    原廠編號 = Item_.原廠編號,
                    代理編號 = Item_.代理編號,

                    名稱 = Item_.名稱,
                    縮寫 = Item_.縮寫,

                    體積 = Item_.體積,
                    顏色 = Item_.顏色,

                    內庫數量 = Item_.內庫數量,
                    外庫數量 = Item_.外庫數量,
                    庫存總成本 = Item_.庫存總成本,
                    最後進貨成本 = Item_.最後進貨成本,
                    成本備註 = Item_.成本備註,
                };

                物品資料管理器.獨體.Map.Add(New_.編號, New_);
            }
            物品資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("商品大類資料轉換");
            商品大類資料管理器.獨體.Map.Clear();
            foreach (var Item_ in 商品大類管理器.Instance.Map.Values)
            {
                if (Item_.編號 <= 0)
                    continue;

                商品.商品大類資料 New_ = new 商品.商品大類資料
                {
                    編號 = Item_.編號,
                    名稱 = Item_.名稱,
                };

                商品大類資料管理器.獨體.Map.Add(New_.編號, New_);
            }
            商品大類資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("商品小類資料轉換");
            商品小類資料管理器.獨體.Map.Clear();
            foreach (var Item_ in 商品小類管理器.Instance.Map.Values)
            {
                if (Item_.編號 <= 0)
                    continue;

                商品.商品小類資料 New_ = new 商品.商品小類資料
                {
                    編號 = Item_.編號,
                    名稱 = Item_.名稱,
                };

                商品小類資料管理器.獨體.Map.Add(New_.編號, New_);
            }
            商品小類資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("商品資料轉換");
            商品資料管理器.獨體.Map.Clear();
            foreach (var Item_ in 商品管理器.Instance.Map.Values)
            {
                if (Item_.編號 <= 0)
                    continue;

                商品.商品資料 New_ = new 商品.商品資料
                {
                    編號 = Item_.編號,

                    大類編號 = 編號轉換(Item_.大類編號),
                    小類編號 = 編號轉換(Item_.小類編號),

                    公司編號 = 編號轉換(Item_.公司編號),
                    客戶編號 = 編號轉換(Item_.廠商編號),

                    品號 = Item_.品號,
                    名稱 = Item_.名稱,

                    需求編號1 = 編號轉換(Item_.需求編號1),
                    需求編號2 = 編號轉換(Item_.需求編號2),
                    需求編號3 = 編號轉換(Item_.需求編號3),
                    需求編號4 = 編號轉換(Item_.需求編號4),
                    需求編號5 = 編號轉換(Item_.需求編號5),

                    數量1 = Item_.數量1,
                    數量2 = Item_.數量2,
                    數量3 = Item_.數量3,
                    數量4 = Item_.數量4,
                    數量5 = Item_.數量5,

                    寄庫數量 = Item_.寄庫,
                    售價 = Item_.價格,
                };
                商品資料管理器.獨體.Map.Add(New_.編號, New_);
            }
            商品資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("使用者資料轉換");
            使用者資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("月結帳匯入設定資料轉換");
            月結帳匯入設定資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("平台訂單匯入設定資料轉換");
            平台訂單匯入設定資料管理器.獨體.資料搬移();

            訊息管理器.獨體.Info("轉換完畢");
        }

        private int 編號轉換(int Old_)
        {
            if(Old_ == -1)
                return 常數.T錯誤資料編碼;
            if(Old_ == 0)
                return 常數.T空白資料編碼;

            return Old_;
        }

        // test
        private void button27_Click(object sender, EventArgs e)
        {
            登入視窗 i = new 登入視窗();
            i.Show();
            i.BringToFront();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.平台訂單設定, 列舉.視窗.總覽);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var i = new 平台訂單匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.使用者, 列舉.視窗.總覽);
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.平台訂單新增, 列舉.視窗.總覽);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.平台訂單新增_Momo三方, 列舉.視窗.總覽);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            視窗管理器.獨體.顯現(列舉.編號.幣值, 列舉.視窗.總覽);
        }
    }
}
