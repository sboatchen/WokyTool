using LINQtoCSV;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataImport;
using WokyTool.平台訂單;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單回單轉換_Momo第三方_分組 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return "0"; } }

        private IEnumerable<平台訂單新增資料> _資料列;


        public 平台訂單回單轉換_Momo第三方_分組(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "項次+燈號";
            App_.Cells[1, 2] = "併箱編號";

            // 以下同匯入訂單
            int 欄位索引_ = 3;
            foreach (string 標頭_ in _資料列.First().標頭.Skip(5))
            {
                App_.Cells[1, 欄位索引_++] = 標頭_;
            }

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.內容[0];
                App_.Cells[目前行數_, 2] = 資料_.配送分組;

                // 以下同匯入訂單
                欄位索引_ = 3;
                foreach (string 欄位內容_ in 資料_.內容.Skip(5))
                {
                    App_.Cells[目前行數_, 欄位索引_++] = 欄位內容_;
                }

                目前行數_++;
            }
        }
    }
}
