using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataImport;
using WokyTool.通用;

namespace WokyTool.DataExport
{
    class 宅配通匯出結構 : 可格式化_Excel
    {
        public string 姓名 { get; set; }
        public string 地址 { get; set; }
        public string 電話 { get; set; }

        public string 備註 { get; set; }
        public string 商品 { get; set; }

        public string 指配日期 { get; set; }
        public string 指配時段 { get; set; }

        public string 代收方式 { get; set; }
        public string 代收金額 { get; set; }

        protected 可配送 _資料來源;

        public 宅配通匯出結構(可配送 From_)
        {
            _資料來源 = From_;
            姓名 = From_.配送姓名;
            地址 = From_.配送地址;

            // 優先使用手機資料 沒有才用電話資料
            if (From_.配送手機 != null && From_.配送手機.Length != 0)
                電話 = From_.配送手機;
            else
                電話 = From_.配送電話;

            備註 = From_.配送備註;
            商品 = From_.配送商品;

            if (From_.指配日期.Ticks == 0)
                指配日期 = "";
            else
                指配日期 = From_.指配日期.ToString("yyyy/MM/dd");

            switch (From_.指配時段)
            {
                case 列舉.指配時段.上午:
                    指配時段 = "1";
                    break;
                case 列舉.指配時段.下午:
                    指配時段 = "2";
                    break;
                case 列舉.指配時段.晚上:
                    指配時段 = "3";
                    break;
                default:
                    指配時段 = "";
                    break;
            }

            if (From_.代收金額 == 0)
                代收金額 = "";
            else
                代收金額 = From_.代收金額.ToString();

            switch (From_.代收方式)
            {
                case 列舉.代收方式.現金:
                    代收方式 = "1";
                    break;
                case 列舉.代收方式.刷卡:
                    代收方式 = "2";
                    break;
                default:
                    代收方式 = "";
                    break;
            }
        }

        // 更新配送單號
        public bool SetDeliveryNO(宅配通匯入結構 Import_)
        {
            if (Import_.姓名.CompareTo(this.姓名) != 0)
                return false;

            _資料來源.完成配送(Import_.配送單號);
            return true;
        }

        // 清除配送單號 - 匯入失敗用
        public void CleanDeliveryNO()
        {
            _資料來源.完成配送(null);
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            // 不加會錯
            App_.Cells[1, 1] = 1;

            return 1;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 13] = 姓名;
            App_.Cells[Row_, 14] = 電話;
            App_.Cells[Row_, 16] = 地址;
            App_.Cells[Row_, 18] = 指配日期;
            App_.Cells[Row_, 19] = 指配時段;
            App_.Cells[Row_, 20] = 代收方式;
            App_.Cells[Row_, 21] = 代收金額;
            App_.Cells[Row_, 26] = 備註;
            App_.Cells[Row_, 27] = 商品;

            return Row_ + 1;
        }
    }
}
