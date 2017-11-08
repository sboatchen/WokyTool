using LINQtoCSV;
using LinqToExcel;
using Microsoft.Office.Interop.Excel;
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
using WokyTool.Data;
using WokyTool.DataForm;
using WokyTool.DataImport;
using WokyTool.DataMgr;
using WokyTool.FormOther;
using WokyTool.FormOverview;
using WokyTool.ImportForm;
using WokyTool.OtherForm;

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
            //@@ 改到統一的關閉街口
            函式.SaveAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var i = new 編碼總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var i = new 廠商總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var i = new 物品大類總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var i = new 物品小類總覽視窗();
            i.Show();
            i.BringToFront();
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
            var i = new 物品總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var i = new 商品大類總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var i = new 商品小類總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var i = new 商品總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                    var i = new 商品匯入視窗(Excel_);
                    i.Show();
                    i.BringToFront();

                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var i = new 月結帳總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                    var Query_ = Excel_.Worksheet<月結帳匯入結構_Momo>()
                                        .Select(Value => Value.ToData());

                    var i = new 月結帳匯入視窗(Query_);
                    i.Show();
                    i.BringToFront();

                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var i = new 物品品牌總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var i = new 進貨總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var i = new 進貨匯入視窗(列舉.進貨類型.一般);
            i.Show();
            i.BringToFront();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            var i = new 進貨匯入視窗(列舉.進貨類型.退貨重進);
            i.Show();
            i.BringToFront();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            var i = new 進貨匯入視窗(列舉.進貨類型.庫存調整);
            i.Show();
            i.BringToFront();
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
            var i = new 待處理配送總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var i = new 商品訂單匯入視窗();
            i.Show();
            i.BringToFront();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var i = new 新增商品視窗();
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
            var i = new 公司總覽視窗();
            i.Show();
            i.BringToFront();
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
        }

        private void button32_Click(object sender, EventArgs e)
        {
            var i = new 工廠出貨視窗();
            i.Show();
            i.BringToFront();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            var i = new 工廠出貨視窗2();
            i.Show();
            i.BringToFront();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "測試1";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            Microsoft.Office.Interop.Excel.Application App = null;
            Microsoft.Office.Interop.Excel.Workbook Wbook = null;
            // 寫入資料
            try
            {
                App = new Microsoft.Office.Interop.Excel.Application();
                Wbook = App.Workbooks.Add();

                var xlSheets = Wbook.Sheets as Microsoft.Office.Interop.Excel.Sheets;
                Microsoft.Office.Interop.Excel.Worksheet NowSheet = Wbook.Worksheets["Sheet1"];

                NowSheet.Name = "測試1";
                App.Cells[1, 1] = "測試成功";

                // This works.
                Wbook.SaveAs(dlg.FileName);

                //關閉工作簿
                Wbook.Close();

                //離開程序
                App.Quit();
            }
            catch (Exception theException)
            {
                MessageBox.Show("匯出失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Wbook != null)
                    Wbook.Close();
                if (App != null)
                    App.Quit();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "測試2";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            Microsoft.Office.Interop.Excel.Application App = null;
            Microsoft.Office.Interop.Excel.Workbook Wbook = null;
            // 寫入資料
            try
            {
                App = new Microsoft.Office.Interop.Excel.Application();
                Wbook = App.Workbooks.Add();

                var xlSheets = Wbook.Sheets as Microsoft.Office.Interop.Excel.Sheets;
                Microsoft.Office.Interop.Excel.Worksheet NowSheet = xlSheets.get_Item(1);

                NowSheet.Name = "測試2";
                App.Cells[1, 1] = "測試成功";

                // This works.
                Wbook.SaveAs(dlg.FileName);

                //關閉工作簿
                Wbook.Close();

                //離開程序
                App.Quit();
            }
            catch (Exception theException)
            {
                MessageBox.Show("匯出失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Wbook != null)
                    Wbook.Close();
                if (App != null)
                    App.Quit();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "測試3";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            Microsoft.Office.Interop.Excel.Application App = null;
            Microsoft.Office.Interop.Excel.Workbook Wbook = null;
            // 寫入資料
            try
            {
                App = new Microsoft.Office.Interop.Excel.Application();
                Wbook = App.Workbooks.Add();

                var xlSheets = Wbook.Sheets as Microsoft.Office.Interop.Excel.Sheets;
                Microsoft.Office.Interop.Excel.Worksheet NowSheet = Wbook.ActiveSheet;

                NowSheet.Name = "測試3";
                App.Cells[1, 1] = "測試成功";

                // This works.
                Wbook.SaveAs(dlg.FileName);

                //關閉工作簿
                Wbook.Close();

                //離開程序
                App.Quit();
            }
            catch (Exception theException)
            {
                MessageBox.Show("匯出失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Wbook != null)
                    Wbook.Close();
                if (App != null)
                    App.Quit();
            }
        }
    }
}
