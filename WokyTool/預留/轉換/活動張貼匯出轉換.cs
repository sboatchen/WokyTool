using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.活動
{
    public class 活動張貼匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return "樣板/活動張貼.xlsx"; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        public IGrouping<string, 活動資料> 群組 { get; protected set; }
        public 活動資料 參考 { get; protected set; }

        public 活動張貼匯出轉換(IGrouping<string, 活動資料> 群組_)
        {
            this.群組 = 群組_;
            this.參考 = 群組_.First();
        }

        public void 寫入(Application App_)
        {
            int 最大欄索引_ = 100, 最大列索引_ = 100, 物品細節開始欄索引_ = -1, 物品細節開始列索引_ = -1;
            for (int 列索引_ = 1; 列索引_ < 最大列索引_; 列索引_++)
            {
                for (int 欄索引_ = 1; 欄索引_ < 最大欄索引_; 欄索引_++)
                {
                    if (App_.Cells[列索引_, 欄索引_].Value2 != null)
                    {
                        string 內容_ = App_.Cells[列索引_, 欄索引_].Value2.ToString();
                        switch (內容_)
                        {
                            case "%結束欄":
                                最大欄索引_ = 欄索引_;
                                ((Range)App_.Cells[列索引_, 欄索引_]).EntireColumn.Delete();
                                break;
                            case "%結束列":
                                最大列索引_ = 列索引_;
                                ((Range)App_.Cells[列索引_, 欄索引_]).EntireRow.Delete();
                                break;
                            case "%開始日期":
                                App_.Cells[列索引_, 欄索引_] = 參考.開始日期.ToString("yyyy/MM/dd");
                                break;
                            case "%結束日期":
                                App_.Cells[列索引_, 欄索引_] = 參考.結束日期.ToString("yyyy/MM/dd");
                                break;
                            case "%名稱":
                                App_.Cells[列索引_, 欄索引_] = 參考.名稱;
                                break;
                            case "%姓名":
                                App_.Cells[列索引_, 欄索引_] = 參考.姓名;
                                break;
                            case "%物品細節":
                                物品細節開始列索引_ = 列索引_;
                                物品細節開始欄索引_ = 欄索引_;
                                break;
                            default:
                                break;
                        }

                    }
                }
            }

            if (物品細節開始欄索引_ == -1 || 物品細節開始列索引_ == -1)
                return;

            foreach (活動資料 資料_ in 群組)
            {
                App_.Cells[物品細節開始列索引_, 物品細節開始欄索引_] = String.Format("{0}*{1}", 資料_.物品.名稱, 資料_.數量);

                Range R1 = (Range)App_.Cells[物品細節開始列索引_, 物品細節開始欄索引_];
                R1.Copy(Type.Missing);

                物品細節開始列索引_++;

                Range R2 = (Range)App_.Cells[物品細節開始列索引_, 物品細節開始欄索引_];
                R2.PasteSpecial(XlPasteType.xlPasteFormats, XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
            }
        }
    }
}
