using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 檔案測試視窗 : Form
    {
        public 檔案測試視窗()
        {
            InitializeComponent();
        }

        private void 路徑測試_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                String 路徑_ = openFileDialog1.FileName;
                Console.WriteLine(路徑_);

                String 備份檔名_ = 檔案.取得備份檔名(路徑_);
                Console.WriteLine(備份檔名_);

                String 備份資料夾_ = 檔案.取得備份資料夾(路徑_, new String[]{"測試", "123"});
                Console.WriteLine(備份資料夾_);

                String 檔案後綴測試 = 檔案.增加檔名後綴(路徑_, "a", "b");
                Console.WriteLine(檔案後綴測試);
            }

            Console.WriteLine("---------");

            {
                String 路徑_ = "設定/公司.json";
                Console.WriteLine(路徑_);

                String 備份檔名_ = 檔案.取得備份檔名(路徑_);
                Console.WriteLine(備份檔名_);

                String 備份資料夾_ = 檔案.取得備份資料夾(路徑_, new String[]{ "測試", "123" });
                Console.WriteLine(備份資料夾_);
            }

        }

        private void CSV_Click(object sender, EventArgs e)
        {
            讀寫測試轉換 讀寫測試轉換_ = new 讀寫測試轉換();
            檔案.詢問並寫入("CSV測試", (可寫入介面_CSV)讀寫測試轉換_);

            List<可寫入介面_CSV> 讀寫測試轉換列_ = new List<可寫入介面_CSV>();
            讀寫測試轉換列_.Add(new 讀寫測試轉換());
            讀寫測試轉換列_.Add(new 讀寫測試轉換());

            檔案.詢問並寫入("CSV測試2", 讀寫測試轉換列_);

            讀寫測試轉換_.密碼 = "12345678";
            檔案.詢問並寫入("CSV測試3", (可寫入介面_CSV)讀寫測試轉換_);
        }

        private void CSV讀出_Click(object sender, EventArgs e)
        {
            讀寫測試轉換 讀寫測試轉換_ = new 讀寫測試轉換();


            var 內容列_ = 檔案.詢問並讀出((可讀出介面_CSV<讀寫測試資料>)讀寫測試轉換_);
            foreach(var 內容_ in 內容列_)
                Console.WriteLine(內容_);

            Console.WriteLine("-------------");

            讀寫測試轉換_.密碼 = "12345678";
            內容列_ = 檔案.詢問並讀出((可讀出介面_CSV<讀寫測試資料>)讀寫測試轉換_);
            foreach (var 內容_ in 內容列_)
                Console.WriteLine(內容_);
        }

        private void EXCEL寫入_Click(object sender, EventArgs e)
        {
            /*讀寫測試轉換 讀寫測試轉換_ = new 讀寫測試轉換();
            //讀寫測試轉換_.格式 = Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal;
            讀寫測試轉換_.格式 = Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook;

            讀寫測試轉換_.樣板 = "樣板/一般訂單/一般出貨銷售匯出樣板.xlsx";

            讀寫測試轉換_.密碼 = "1234";

            檔案.詢問並寫入("EXCEL測試", (可寫入介面_EXCEL)讀寫測試轉換_);*/

            List<可寫入介面_EXCEL> 讀寫測試轉換列_ = new List<可寫入介面_EXCEL>();
            讀寫測試轉換列_.Add(new 讀寫測試轉換() { 格式 = Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook });
            讀寫測試轉換列_.Add(new 讀寫測試轉換());

            檔案.詢問並寫入("EXCEL測試2", 讀寫測試轉換列_);
        }

        private void EXCEL讀出_Click(object sender, EventArgs e)
        {
            讀寫測試轉換 讀寫測試轉換_ = new 讀寫測試轉換(){ 格式 = Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook };
            var 內容列_ = 檔案.詢問並讀出((可讀出介面_EXCEL<讀寫測試資料>)讀寫測試轉換_);
            foreach (var 內容_ in 內容列_)
                Console.WriteLine(內容_);
        }

        private void EXCEL快速讀出_Click(object sender, EventArgs e)
        {
            var 內容列_ = 檔案.詢問並讀出<讀寫測試資料>();
            foreach (var 內容_ in 內容列_)
                Console.WriteLine(內容_);
        }
    }
}
