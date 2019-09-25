using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單回單轉換_Momo第三方_進度 : 可寫入介面_EXCEL
    {
        private static string 可出貨 = "可出貨";
        private static string 已確認指定配送日 = "已確認指定配送日";

        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return "0"; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_Momo第三方_進度(IEnumerable<平台訂單新增資料> 資料列舉_)
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

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                欄位索引_ = 1;
                foreach (string 欄位內容_ in 資料_.內容)
                {
                    App_.Cells[目前行數_, 欄位索引_++] = 欄位內容_;
                }

                // 預計出貨日須為2日內(今天+明天) 才進行出貨處理 並將配送狀態改為 可出貨
                // 2日外的 將配送狀態改為 已確認指定配送日 並將配送訊息 寫上預計出貨日
                switch (資料_.處理狀態)
                {
                    case 列舉.訂單處理狀態.新增:
                        App_.Cells[目前行數_, 2] = 可出貨;
                        break;
                    case 列舉.訂單處理狀態.忽略:
                        App_.Cells[目前行數_, 2] = 已確認指定配送日;

                        String 配送訊息_ = 資料_.內容[13].轉成時間().ToString("yyyy/MM/dd");
                        App_.Cells[目前行數_, 3] = 配送訊息_;    // 配送訊息
                        App_.Cells[目前行數_, 4] = 配送訊息_;    // 約定配送日;
                        break;
                    default:
                        訊息管理器.獨體.錯誤("平台訂單回單轉換_Momo第三方_進度 不支援處理狀態 " + 資料_.處理狀態.ToString());
                        break;
                }

                目前行數_++;
            }
        }
    }
}
