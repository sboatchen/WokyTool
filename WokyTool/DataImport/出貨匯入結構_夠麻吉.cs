using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.通用;
using Excel = Microsoft.Office.Interop.Excel;

namespace WokyTool.DataImport
{
    public class 出貨匯入結構_夠麻吉
    {
        public static List<出貨匯入結構_夠麻吉> Read(String Path_)
        {
            // 寫入資料
            try
            {
                // 開啟程序
                Excel.Application App = new Excel.Application();
                // App.Visible = true;
                // App.UserControl = true;

                // 開啟工作簿
                Excel.Workbook Wbook = App.Workbooks.Open(Path_);

                // 取得分頁
                var xlSheets = Wbook.Sheets as Excel.Sheets;
                Excel.Worksheet NowSheet = Wbook.ActiveSheet;

                /*for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(NowSheet.Cells[i, j].value);
                        Console.Write(",");
                    }
                    訊息管理器.獨體.Info("");
                }*/


                Range xlRange = NowSheet.UsedRange;
                foreach (Range c in xlRange.Cells)
                {
                    訊息管理器.獨體.Info("Address: " + c.Row + c.Column + " - Value: " + c.Value + ";" + c.MergeCells);
                }





                //關閉工作簿
                Wbook.Close();

                //離開程序
                App.Quit();
            }
            catch (Exception theException)
            {
                MessageBox.Show("匯出失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }



            return null;
        }
    }
}
