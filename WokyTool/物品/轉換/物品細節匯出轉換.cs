using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品細節匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return "細節"; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<物品資料> _資料列;

        public 物品細節匯出轉換(IEnumerable<物品資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "編號";
            App_.Cells[1, 2] = "大類";
            App_.Cells[1, 3] = "小類";
            App_.Cells[1, 4] = "品牌";
            App_.Cells[1, 5] = "條碼";
            App_.Cells[1, 6] = "原廠編號";
            App_.Cells[1, 7] = "代理編號";
            App_.Cells[1, 8] = "名稱";
            App_.Cells[1, 9] = "縮寫";
            App_.Cells[1, 10] = "類別";
            App_.Cells[1, 11] = "體積";
            App_.Cells[1, 12] = "顏色";
            App_.Cells[1, 13] = "內庫數量";
            App_.Cells[1, 14] = "外庫數量";
            App_.Cells[1, 15] = "庫存總成本";
            App_.Cells[1, 16] = "最後進貨成本";
            App_.Cells[1, 17] = "成本備註";

            int 目前行數_ = 2;
            foreach (物品資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.編號;
                App_.Cells[目前行數_, 2] = 資料_.大類.名稱;
                App_.Cells[目前行數_, 3] = 資料_.小類.名稱;
                App_.Cells[目前行數_, 4] = 資料_.品牌.名稱;
                App_.Cells[目前行數_, 5] = 資料_.條碼;
                App_.Cells[目前行數_, 6] = 資料_.原廠編號;
                App_.Cells[目前行數_, 7] = 資料_.代理編號;
                App_.Cells[目前行數_, 8] = 資料_.名稱;
                App_.Cells[目前行數_, 9] = 資料_.縮寫;
                App_.Cells[目前行數_, 10] = 資料_.類別;
                App_.Cells[目前行數_, 11] = 資料_.體積;
                App_.Cells[目前行數_, 12] = 資料_.顏色;
                //@@@@App_.Cells[目前行數_, 13] = 資料_.內庫數量;
                //@@@@App_.Cells[目前行數_, 14] = 資料_.外庫數量;
                App_.Cells[目前行數_, 15] = 資料_.庫存總成本;
                App_.Cells[目前行數_, 16] = 資料_.最後進貨成本;
                App_.Cells[目前行數_, 17] = 資料_.成本備註;

                目前行數_++;
            }
        }
    }
}
