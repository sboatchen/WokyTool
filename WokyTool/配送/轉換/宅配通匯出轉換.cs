using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 宅配通匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<配送轉換資料> _資料列舉;

        public 宅配通匯出轉換(IEnumerable<配送轉換資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(Application App_)
        {
            // 不加會錯
            App_.Cells[1, 1] = 1;

            int 目前行數_ = 1;
            foreach (配送轉換資料 資料_ in _資料列舉)
            {
                App_.Cells[目前行數_, 5] = 資料_.件數;
                App_.Cells[目前行數_, 13] = 資料_.姓名;

                // 優先使用手機資料 沒有才用電話資料
                if (string.IsNullOrEmpty(資料_.手機))
                    App_.Cells[目前行數_, 14] = 資料_.電話;
                else
                    App_.Cells[目前行數_, 14] = 資料_.手機;

                App_.Cells[目前行數_, 16] = 資料_.地址;

                if (資料_.指配日期.Ticks != 0)
                    App_.Cells[目前行數_, 18] = 資料_.指配日期.ToString("yyyyMMdd");

                switch (資料_.指配時段)
                {
                    case 列舉.指配時段.上午:
                        App_.Cells[目前行數_, 19] = "1";
                        break;
                    case 列舉.指配時段.下午:
                        App_.Cells[目前行數_, 19] = "2";
                        break;
                    case 列舉.指配時段.晚上:
                        App_.Cells[目前行數_, 19] = "3";
                        break;
                    default:
                        break;
                }

                switch (資料_.代收方式)
                {
                    case 列舉.代收方式.現金:
                        App_.Cells[目前行數_, 20] = "1";
                        break;
                    case 列舉.代收方式.刷卡:
                        App_.Cells[目前行數_, 20] = "2";
                        break;
                    default:
                        break;
                }

                if (資料_.代收金額 > 0)
                    App_.Cells[目前行數_, 21] = 資料_.代收金額.ToString();

                App_.Cells[目前行數_, 26] = 資料_.備註;
                App_.Cells[目前行數_, 27] = 資料_.內容;

                目前行數_++;
            }
        }
    }
}

