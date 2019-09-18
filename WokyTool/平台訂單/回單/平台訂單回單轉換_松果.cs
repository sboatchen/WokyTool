using System;
using System.Collections.Generic;
using System.Text;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    class 平台訂單回單轉換_松果 : 可寫入介面_CSV
    {
        public string 分類 { get { return null; } }

        public string 分格號 { get { return ","; } }

        public string 密碼 { get { return null; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_松果(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(CSVBuilder Builder_)
        {
            Builder_.加入標頭("訂單編號", "收件人", "收件地址", "電話", "訂購內容", "物流商", "物流單號");

            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                Builder_.SB.Append(" ' ").Append(資料_.訂單編號).Append(" ,");
                Builder_.SB.Append(資料_.姓名).Append(",");
                Builder_.SB.Append(資料_.地址).Append(",");
                Builder_.SB.Append(" ' ").Append(資料_.電話).Append(" ,");
                Builder_.SB.Append(資料_.商品名稱).Append(" ( ").Append(資料_.數量).Append(" ) ,");

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        Builder_.SB.Append(字串.全速配).Append(",");
                        break;
                    case 列舉.配送公司.宅配通:
                        Builder_.SB.Append(字串.宅配通).Append(",");
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_松果 不支援配送公司 " + 資料_.配送公司.ToString());
                }
                
                Builder_.SB.Append(資料_.配送單號).AppendLine();
            }
        }
    }
}
