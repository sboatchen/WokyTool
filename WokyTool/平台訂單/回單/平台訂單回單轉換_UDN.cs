using LINQtoCSV;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單回單轉換_UDN : 可寫入介面_EXCEL
    {
        private static string 宅配通 = "CAN-台灣宅配通";

        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_UDN(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            int 欄位索引_ = 1;
            foreach (string 標頭_ in _資料列舉.First().標頭)
            {
                App_.Cells[1, 欄位索引_++] = 標頭_;
            }

            // 第二行資料目前無法處理

            int 目前行數_ = 3;
            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                欄位索引_ = 1;
                foreach (string 欄位內容_ in 資料_.內容)
                {
                    App_.Cells[目前行數_, 欄位索引_++] = 欄位內容_;
                }

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 26] = 宅配通;
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_UDN 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                App_.Cells[目前行數_, 27] = 資料_.配送單號;

                目前行數_++;
            }
        }
    }
}
