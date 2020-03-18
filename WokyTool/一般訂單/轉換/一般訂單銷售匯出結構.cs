using Microsoft.Office.Interop.Excel;
using System.IO;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    public class 一般訂單銷售匯出結構 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return "明細"; } }

        public string 樣板
        {
            get
            {
                if (資料.列印單價)
                    return Path.GetFullPath("樣板/一般訂單/一般出貨銷售匯出樣板.xlsx");
                else
                    return Path.GetFullPath("樣板/一般訂單/一般出貨銷售匯出樣板_無售價.xlsx");
            }
        }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        public 一般訂單新增資料 資料 { get; set; }
        public int 編號 { get; set; }

        public 一般訂單銷售匯出結構(一般訂單新增資料 資料_, int 編號_)
        {
            資料 = 資料_;
            編號 = 編號_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 2] = 編號;
            App_.Cells[1, 3] = (資料.子客戶編號 > 0) ? 資料.客戶名稱 + " - " + 資料.子客戶名稱 : 資料.客戶名稱;
            App_.Cells[2, 2] = 時間.目前日期_斜線;
            App_.Cells[3, 2] = 資料.姓名;
            App_.Cells[4, 2] = 資料.電話;
            App_.Cells[5, 2] = 資料.手機;
            App_.Cells[6, 2] = 資料.地址;

            int Row_ = 9;
            decimal Total_ = 0;
            int 備註欄數 = 0;
            foreach (一般訂單新增組成資料 Item_ in 資料.組成)
            {
                if (Row_ > 9)
                {
                    Range line = (Range)App_.Rows[Row_];
                    line.Insert();
                }

                int Column_ = 0;

                App_.Cells[Row_, ++Column_] = Row_ - 8;
                App_.Cells[Row_, ++Column_] = Item_.單品編號;
                App_.Cells[Row_, ++Column_] = Item_.單品名稱;
                App_.Cells[Row_, ++Column_] = Item_.數量;

                if (資料.列印單價)
                {
                    App_.Cells[Row_, ++Column_] = Item_.售價.ToString("0.###");
                    App_.Cells[Row_, ++Column_] = Item_.總金額.ToString("0.###");

                    Total_ += Item_.總金額;
                }

                App_.Cells[Row_, ++Column_] = Item_.備註;
                備註欄數 = Column_;

                Row_++;
            }

            // set total
            if (資料.列印單價)
            {
                Row_ += 1;
                App_.Cells[Row_, 6] = Total_.ToString("0.###");
            }

            // 製表人
            Row_ += 2;
            App_.Cells[Row_, 備註欄數] = "製表人:" + 系統參數.使用者名稱;
        }
    }
}
