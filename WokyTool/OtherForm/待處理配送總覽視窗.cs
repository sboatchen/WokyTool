using LINQtoCSV;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataExport;
using WokyTool.DataImport;
using WokyTool.DataMgr;
using Excel = Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace WokyTool.OtherForm
{
    public partial class 待處理配送總覽視窗 : Form
    {
        private List<可配送> _Source = new List<可配送>();
        private BindingSource _Binding = new BindingSource();

        // 匯出暫存
        private List<全速配匯出結構> _Export1 = new List<全速配匯出結構>();
        private List<宅配通匯出結構> _Export2 = new List<宅配通匯出結構>();

        public 待處理配送總覽視窗()
        {
            InitializeComponent();

            // 初始化目前顯示資料
            InitData();

            // 預設關掉匯入
            this.全速配ToolStripMenuItem.Enabled = false;
            this.宅配通ToolStripMenuItem.Enabled = false;
        }

        // 初始化目前顯示資料
        private void InitData()
        {
            _Source = 配送管理器.Instance.List
                            .OrderBy(x => x.配送公司)
                            .ThenBy(x => x.配送商品)
                            .ToList();

            _Binding.DataSource = _Source;
            this.dataGridView1.DataSource = _Binding;
        }

        private void 略過ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((可配送)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }
        }

        private void 全速配ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = String.Format("全速配匯出_{0}", 共用.NowYMDDec);
            dlg.DefaultExt = ".csv";                // Default file extension
            dlg.Filter = "csv files (.csv)|*.csv";  // Filter files by extension
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            int x = 1;
            _Export1 = _Source.Where(Value => Value.配送公司 == 列舉.配送公司類型.全速配)
                                .Select(Value => new 全速配匯出結構(x++, Value))
                                .ToList();

            StreamWriter sw = new StreamWriter(dlg.FileName, false, Encoding.Default);
            CsvContext cc = new CsvContext();
            cc.Write(_Export1, sw, 共用.OutputDefine);
            sw.Close();

            // 如果有資料匯出，則鎖定不再允許匯出，並開放匯入
            if (_Export1.Count > 0)
            {
                this.全速配ToolStripMenuItem1.Enabled = false;
                this.全速配ToolStripMenuItem.Enabled = true;
            }
        }

        private void 宅配通ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = String.Format("宅配通匯出_{0}", 共用.NowYMDDec);
            dlg.DefaultExt = ".xls";                // Default file extension
            dlg.Filter = "xls files (.xls)|*.xls";  // Filter files by extension
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                // 開啟程序
                Excel.Application App = new Excel.Application();
                // App.Visible = true;
                // App.UserControl = true;

                // 開啟工作簿
                Excel.Workbook Wbook = App.Workbooks.Add();

                // 取得資料
                _Export2 = _Source.Where(Value => Value.配送公司 == 列舉.配送公司類型.宅配通)
                                .Select(Value => new 宅配通匯出結構(Value))
                                .ToList();

                //@@ 修改參考回單號結構_Momo
                int x = 1;
                {
                    ((Range)App.Cells[1, 1]).EntireColumn.ColumnWidth = 8.38f;
                    ((Range)App.Cells[1, 2]).EntireColumn.ColumnWidth = 9.0f;
                    ((Range)App.Cells[1, 3]).EntireColumn.ColumnWidth = 4.25f;
                    ((Range)App.Cells[1, 4]).EntireColumn.ColumnWidth = 9.5f;
                    ((Range)App.Cells[1, 5]).EntireColumn.ColumnWidth = 4.25f;
                    ((Range)App.Cells[1, 6]).EntireColumn.ColumnWidth = 4.88f;
                    ((Range)App.Cells[1, 7]).EntireColumn.ColumnWidth = 11.0f;
                    ((Range)App.Cells[1, 8]).EntireColumn.ColumnWidth = 10.75f;
                    ((Range)App.Cells[1, 9]).EntireColumn.ColumnWidth = 7.38f;
                    ((Range)App.Cells[1, 10]).EntireColumn.ColumnWidth = 13.75f;
                    ((Range)App.Cells[1, 11]).EntireColumn.ColumnWidth = 4.75f;
                    ((Range)App.Cells[1, 12]).EntireColumn.ColumnWidth = 21.25f;
                    ((Range)App.Cells[1, 13]).EntireColumn.ColumnWidth = 9.25f;
                    ((Range)App.Cells[1, 14]).EntireColumn.ColumnWidth = 16.75f;
                    ((Range)App.Cells[1, 15]).EntireColumn.ColumnWidth = 7.5f;
                    ((Range)App.Cells[1, 16]).EntireColumn.ColumnWidth = 40.5f;
                    ((Range)App.Cells[1, 17]).EntireColumn.ColumnWidth = 4.25f;
                    ((Range)App.Cells[1, 18]).EntireColumn.ColumnWidth = 8.5f;
                    ((Range)App.Cells[1, 19]).EntireColumn.ColumnWidth = 5.5f;
                    ((Range)App.Cells[1, 20]).EntireColumn.ColumnWidth = 4.25f;
                    ((Range)App.Cells[1, 21]).EntireColumn.ColumnWidth = 5.75f;
                    ((Range)App.Cells[1, 22]).EntireColumn.ColumnWidth = 5.75f;
                    ((Range)App.Cells[1, 23]).EntireColumn.ColumnWidth = 4.25f;
                    ((Range)App.Cells[1, 24]).EntireColumn.ColumnWidth = 4.25f;
                    ((Range)App.Cells[1, 25]).EntireColumn.ColumnWidth = 4.25f;
                    ((Range)App.Cells[1, 26]).EntireColumn.ColumnWidth = 12.25f;
                    ((Range)App.Cells[1, 27]).EntireColumn.ColumnWidth = 48.25f;

                }
                foreach (var Item in _Export2)
                {
                    App.Cells[x, 13] = Item.姓名;
                    App.Cells[x, 14] = Item.電話;
                    App.Cells[x, 16] = Item.地址;
                    App.Cells[x, 18] = Item.指配日期;
                    App.Cells[x, 19] = Item.指配時段;
                    App.Cells[x, 20] = Item.代收方式;
                    App.Cells[x, 21] = Item.代收金額;
                    App.Cells[x, 26] = Item.備註;
                    App.Cells[x, 27] = Item.商品;
                    x++;
                }

                // This works.
                Wbook.SaveAs(dlg.FileName, Excel.XlFileFormat.xlWorkbookNormal);

                //關閉工作簿
                Wbook.Close();

                //離開程序
                App.Quit();
            }
            catch (Exception theException)
            {
                MessageBox.Show("匯出失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 如果有資料匯出，則鎖定不再允許匯出，並開放匯入
            if (_Export2.Count > 0)
            {
                this.宅配通ToolStripMenuItem1.Enabled = false;
                this.宅配通ToolStripMenuItem.Enabled = true;
            }
        }

        private void 全速配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel files|*.*";

            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            try
            {
                var Excel_ = new ExcelQueryFactory(dlg.FileName);
                var Data_ = Excel_.Worksheet<全速配匯入結構>().ToList();

                // 檢查資料數是否一致
                if (Data_.Count != _Export1.Count)
                {
                    MessageBox.Show("資料筆數不符合", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool IsRight_ = true;
                for (int i = 0; i < _Export1.Count; i++)
                {
                    if (_Export1[i].SetDeliveryNO(Data_[i]) == false)
                    {
                        IsRight_ = false;
                        break;
                    }
                }
                if (IsRight_ == false)
                {
                    foreach (var Item_ in _Export1)
                    {
                        Item_.CleanDeliveryNO();
                    }

                    MessageBox.Show("資料內容不符合", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 清除暫存，並關閉匯入
                _Export1.Clear();
                this.全速配ToolStripMenuItem.Enabled = false;
                配送管理器.Instance.RemoveDeliverd();

                // 更新UI
                this.dataGridView1.Refresh();
            }
            catch (Exception Error_)
            {
                MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 宅配通ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel files|*.*";

            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            try
            {
                var Excel_ = new ExcelQueryFactory(dlg.FileName);
                var Data_ = Excel_.Worksheet<宅配通匯入結構>().ToList();

                // 檢查資料數是否一致
                if (Data_.Count != _Export2.Count)
                {
                    MessageBox.Show("資料筆數不符合", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool IsRight_ = true;
                for (int i = 0; i < _Export2.Count; i++)
                {
                    if (_Export2[i].SetDeliveryNO(Data_[i]) == false)
                    {
                        IsRight_ = false;
                        break;
                    }
                }
                if (IsRight_ == false)
                {
                    foreach (var Item_ in _Export2)
                    {
                        Item_.CleanDeliveryNO();
                    }

                    MessageBox.Show("資料內容不符合", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 清除暫存，並關閉匯入
                _Export2.Clear();
                this.宅配通ToolStripMenuItem.Enabled = false;
                配送管理器.Instance.RemoveDeliverd();

                // 更新UI
                this.dataGridView1.Refresh();

            }
            catch (Exception Error_)
            {
                MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
