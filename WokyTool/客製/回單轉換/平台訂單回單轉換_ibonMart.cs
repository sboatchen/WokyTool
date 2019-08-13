using LINQtoCSV;
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
    // 配送商廠編' 目前有兩家公司午洋跟田和豐 午洋編號是45036257WD、田和豐是54867084WD
    // '外箱規格' -->固定填入'0001'			
    // 回單要託運公司代號要注意：12新竹貨運 14宅配通

    class 平台訂單回單轉換_ibonMart : 可寫入介面_CSV
    {
        private static string 全速配編號 = "'12'";
        private static string 宅配通編號 = "'14'";
        private static string 外箱規格格式 = "'0001'";
        private static string 午洋編號 = "'45036257WD'";
        private static string 田和豐編號 = "'54867084WD'";

        public string 分類 { get { return null; } }

        public string 分格號 { get { return ","; } }

        public string 密碼 { get { return null; } }

        public Encoding 編碼 { get { return Encoding.UTF8; } }

        private IEnumerable<平台訂單新增資料> _資料列;

        public 平台訂單回單轉換_ibonMart(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(CSVBuilder Builder_)
        {
            Builder_.加入標頭("'配送商廠編'", "'訂單編號'", "'出貨單編號'", "'託運單編號'", "'託運公司'", "'外箱規格'", "'商品品號'", "'實際出貨數量'");

            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                switch (資料_.公司.名稱)
                {
                    case "午洋":
                        Builder_.SB.Append(午洋編號).Append(",");
                        break;
                    case "田和豐":
                        Builder_.SB.Append(田和豐編號).Append(",");
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_ibonMart can't find 配送商廠編 " + 資料_.商品.公司.名稱);
                }

                Builder_.SB.Append(資料_.內容[4]).Append(",");
                Builder_.SB.Append(資料_.內容[5]).Append(",");
                Builder_.SB.Append("'").Append(資料_.配送單號).Append("',");

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        Builder_.SB.Append(全速配編號).Append(",");
                        break;
                    case 列舉.配送公司.宅配通:
                        Builder_.SB.Append(宅配通編號).Append(",");
                        break;
                    default:
                       throw new Exception("平台訂單回單轉換_Friday 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                Builder_.SB.Append(外箱規格格式).Append(",");
                Builder_.SB.Append(資料_.內容[15]).Append(",");
                Builder_.SB.AppendLine(資料_.內容[19]);
            }
        }
    }
}
