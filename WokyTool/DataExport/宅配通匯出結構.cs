using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataImport;

namespace WokyTool.DataExport
{
    class 宅配通匯出結構
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
                case 列舉.指配時段類型.上午:
                    指配時段 = "1";
                    break;
                case 列舉.指配時段類型.下午:
                    指配時段 = "2";
                    break;
                case 列舉.指配時段類型.晚上:
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
                case 列舉.代收類型.現金:
                    代收方式 = "1";
                    break;
                case 列舉.代收類型.刷卡:
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

            _資料來源.SetDiliver(Import_.配送單號);
            return true;
        }

        // 清除配送單號 - 匯入失敗用
        public void CleanDeliveryNO()
        {
            _資料來源.SetDiliver(null);
        }
    }
}
