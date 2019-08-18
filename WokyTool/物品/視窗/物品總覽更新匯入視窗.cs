using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.通用;
using Excel = Microsoft.Office.Interop.Excel;

namespace WokyTool.物品
{
    public partial class 物品總覽更新匯入視窗 : 匯入視窗
    {

        protected 物品總覽更新匯入管理器 _匯入管理器 = new 物品總覽更新匯入管理器();

        public 物品總覽更新匯入視窗()
        {
            InitializeComponent();

            this.更新狀態BindingSource.DataSource = Enum.GetValues(typeof(列舉.更新狀態));

            this.初始化(物品總覽更新匯入資料BindingSource, _匯入管理器);
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files|*.*";

            if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            int rw = 0;
            int cl = 0;

            int rCnt = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(openFileDialog.FileName, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            // 讀取內容
            dynamic dValue_ = null;
            try
            {
                List<物品總覽更新匯入資料> 資料列_ = new List<物品總覽更新匯入資料>();
                List<int> 舊資料號碼列_ = 物品資料管理器.獨體.Map.Select(Value => Value.Key).ToList();
                List<int> 更新資料號碼列_ = new List<int>();

                int SheetCount_ = xlWorkBook.Worksheets.Count;
                for (int i = 1; i <= SheetCount_; i++)
                {
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(i);
                    Console.WriteLine(xlWorkSheet.Name);

                    range = xlWorkSheet.UsedRange;
                    rw = range.Rows.Count;
                    cl = range.Columns.Count;

                    String 品牌名稱_ = xlWorkSheet.Name;
                    物品品牌資料 品牌_ = 物品品牌資料管理器.獨體.取得(品牌名稱_);

                    for (rCnt = 2; rCnt <= rw; rCnt++)
                    {
                        if ((range.Cells[rCnt, 1] as Excel.Range).Value2 == null)
                            continue;

                        物品總覽更新匯入資料 資料_ = new 物品總覽更新匯入資料();

                        String 名稱_ = ((range.Cells[rCnt, 1] as Excel.Range).Value2 as object).ToString();
                        
                        String 大類名稱_ = ((range.Cells[rCnt, 2] as Excel.Range).Value2 as object).ToString();
                        物品大類資料 大類_ = 物品大類資料管理器.獨體.取得(大類名稱_);

                        String 小類名稱_ = ((range.Cells[rCnt, 3] as Excel.Range).Value2 as object).ToString();
                        物品小類資料 小類_ = 物品小類資料管理器.獨體.取得(小類名稱_);

                        String 縮寫_ = ((range.Cells[rCnt, 4] as Excel.Range).Value2 as object).ToString();

                        decimal 最後進貨成本_ = Convert.ToDecimal(((range.Cells[rCnt, 5] as Excel.Range).Value2 as object).ToString());

                        物品資料 物品_ = 物品資料管理器.獨體.Get(名稱_);
                        if(物品_.編號是否有值() == false)
                            物品_ = 物品資料管理器.獨體.GetBySName(縮寫_);

                        if(物品_ == 物品資料.NULL)
                        {
                            資料_.更新狀態 = 列舉.更新狀態.錯誤;
                            資料_.錯誤訊息 = "物品名稱為空";
                            資料_.物品 = 物品資料.ERROR;
                            資料列_.Add(資料_);
                            continue;
                        }

                        if(物品_ == 物品資料.ERROR)
                        {
                            資料_.更新狀態 = 列舉.更新狀態.新增;
                            資料_.物品 = new 物品資料();
                        }
                        else
                        {
                            資料_.物品 = 物品_.拷貝();
                            舊資料號碼列_.Remove(資料_.物品.編號);

                            if (更新資料號碼列_.Contains(物品_.編號))
                            {
                                資料_.更新狀態 = 列舉.更新狀態.錯誤;
                                資料_.錯誤訊息 = "物品重複出現";
                            }
                            else
                            {
                                資料_.更新狀態 = 列舉.更新狀態.更新;
                                更新資料號碼列_.Add(物品_.編號);
                            }
                        }

                        資料_.物品.名稱 = 名稱_;
                        資料_.物品.縮寫 = 縮寫_;
                        資料_.物品.大類 = 大類_;
                        資料_.物品.小類 = 小類_;
                        資料_.物品.品牌 = 品牌_;
                        資料_.物品.最後進貨成本 = 最後進貨成本_;

                        資料列_.Add(資料_);
                      
                    }
                }

                // 加入被刪除的資料
                foreach (var 編號_ in 舊資料號碼列_)
                {
                    物品總覽更新匯入資料 資料_ = new 物品總覽更新匯入資料();
                    資料_.物品 = 物品資料管理器.獨體.Get(編號_).拷貝();
                    資料_.更新狀態 = 列舉.更新狀態.刪除;
                    資料列_.Add(資料_);
                }

                _匯入管理器.新增(資料列_);
                if (_匯入管理器.是否正在編輯() == false)
                    return;

                this.匯入ToolStripMenuItem.Enabled = false;

                this.OnActivated(null);
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.錯誤("失敗位置:" + rCnt + " " + dValue_);
                throw ex;
            }
            finally
            {
                if (xlWorkBook != null)
                    xlWorkBook.Close(false, null, null);

                if (xlApp != null)
                    xlApp.Quit();

                //Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
        }

        /********************************/

        protected override void 視窗激活()
        {
        }

        protected override void 視窗關閉()
        {
        }
    }
}
