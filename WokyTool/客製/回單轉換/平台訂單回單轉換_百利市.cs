﻿using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataImport;
using WokyTool.平台訂單;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單回單轉換_百利市 : 可序列化_Excel
    {
        private static string 全速配編號 = "新竹物流";
        private static string 宅配通編號 = "台灣宅配通";

        protected IEnumerable<平台訂單新增資料> _資料列;

        public String 標頭 { get; set; }

        public String 樣板 { get { return null; } }

        public 平台訂單回單轉換_百利市(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "商品Line*";
            App_.Cells[1, 2] = "訂單編號*";
            App_.Cells[1, 3] = "商品品號";
            App_.get_Range("C1").EntireColumn.NumberFormat = "@";   // 強迫以字串的方式記錄
            App_.Cells[1, 4] = "物流公司";
            App_.Cells[1, 5] = "運單號";
            App_.Cells[1, 6] = "出貨時間";
            App_.Cells[1, 7] = "是否客約";
            App_.Cells[1, 8] = "客約送貨時間";

            int 目前行數_ = 2;
            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 函式.取得字串(資料_.額外資訊, 7);
                App_.Cells[目前行數_, 2] = 資料_.訂單編號;
                App_.Cells[目前行數_, 3] = 資料_.商品編號;

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        App_.Cells[目前行數_, 4] = 全速配編號;
                        break;
                    case 列舉.配送公司.宅配通:
                        App_.Cells[目前行數_, 4] = 宅配通編號;
                        break;
                    default:
                        訊息管理器.獨體.Error("平台訂單回單轉換_百利市 不支援配送公司 " + 資料_.配送公司.ToString());
                        break;
                }
            
                App_.Cells[目前行數_, 5] = 資料_.配送單號;

                // 出貨時間格式應該為年月日時分秒。例如：2015.12.30 12：00：00，例如：2015.12.30，則默認是2015.12.30 0：00:00
                App_.Cells[目前行數_, 6] = DateTime.Now.ToString("yyyy.MM.dd") + " 0:00:00";

                目前行數_++;
            }
        }
    }
}
