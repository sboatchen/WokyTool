using System;
using System.Collections.Generic;
using System.Text;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    class 平台訂單回單轉換_Friday : 可寫入介面_CSV
    {
        private static string 全速配 = "4";
        private static string 宅配通 = "3";

        public string 分類 { get { return null; } }

        public string 分格號 { get { return ","; } }

        public string 密碼 { get { return null; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_Friday(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(CSVBuilder Builder_)
        {
            Builder_.加入標頭("訂單編號", "出貨單號", "宅配廠商代碼", "宅配單號");

            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                string 宅配廠商代碼_;
                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        宅配廠商代碼_ = 全速配;
                        break;
                    case 列舉.配送公司.宅配通:
                        宅配廠商代碼_ = 宅配通;
                        break;
                    default:
                    {
                        if (資料_.處理狀態 != 列舉.訂單處理狀態.忽略)
                            throw new Exception("平台訂單回單轉換_Friday 不支援配送公司 " + 資料_.配送公司.ToString());
                        宅配廠商代碼_ = 字串.空;
                        break;
                    }   
                }

                Builder_.加入(資料_.內容[6].轉成字串(), 資料_.內容[3].轉成字串(), 宅配廠商代碼_, 資料_.配送單號);
            }
        }
    }
}
