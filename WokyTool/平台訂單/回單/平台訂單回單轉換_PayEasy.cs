using System;
using System.Collections.Generic;
using System.Text;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    class 平台訂單回單轉換_PayEasy : 可寫入介面_CSV
    {
        private static int 全速配 = 51;
        private static int 宅配通 = 53;

        public string 分類 { get { return null; } }

        public string 分格號 { get { return ","; } }

        public string 密碼 { get { return null; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_PayEasy(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(CSVBuilder Builder_)
        {
            Builder_.加入標頭("訂單編號", "物流公司", "配送單號", "其他物流公司");

            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                int 代碼_;
                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        代碼_ = 全速配;
                        break;
                    case 列舉.配送公司.宅配通:
                        代碼_ = 宅配通;
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_PayEasy 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                Builder_.加入(資料_.訂單編號, 代碼_, 資料_.配送單號, 字串.空);
            }
        }
    }
}
