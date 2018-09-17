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

    class 平台訂單回單轉換_ibonMart : 可格式化_Csv
    {
        private static string 全速配編號 = "'12'";
        private static string 宅配通編號 = "'14'";
        private static string 外箱規格格式 = "'0001'";
        private static string 午洋編號 = "'45036257WD'";
        private static string 田和豐編號 = "'54867084WD'";
        private static string 輸出字串格式 = "'{0}'";

        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_ibonMart(平台訂單新增資料 Data_)
        {
            _Data = Data_;
        }

        [CsvColumn(Name = "'配送商廠編'", FieldIndex = 1)]
        public string 配送商廠編
        {
            get
            {
                switch (_Data.商品.公司.名稱)
                {
                    case "午洋":
                        return 午洋編號;
                    case "田和豐":
                        return 田和豐編號;
                    default:
                        MessageBox.Show("平台訂單回單轉換_ibonMart can't find 配送商廠編 " + _Data.商品.公司.名稱, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 字串.空;
                }
            }
        }

        [CsvColumn(Name = "'訂單編號'", FieldIndex = 2)]
        public string 訂單編號 { get { return 通用函式.取得字串(_Data.額外資訊, 5); } }
        [CsvColumn(Name = "'出貨單編號'", FieldIndex = 3)]
        public string 出貨單編號 { get { return 通用函式.取得字串(_Data.額外資訊, 6); } }

        [CsvColumn(Name = "'託運單編號'", FieldIndex = 4)]
        public string 託運單編號 { get { return "'" + _Data.配送單號 + "'"; } }
        [CsvColumn(Name = "託運公司'", FieldIndex = 5)]
        public string 託運公司
        {
            get
            {
                switch (_Data.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        return 全速配編號;
                    case 列舉.配送公司.宅配通:
                        return 宅配通編號;
                    default:
                        MessageBox.Show("平台訂單回單轉換_ibonMart can't find 託運公司 " + _Data.配送公司.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 字串.空;
                }
            }
        }
        [CsvColumn(Name = "'外箱規格'", FieldIndex = 6)]
        public string 外箱規格 { get { return 外箱規格格式; } }

        [CsvColumn(Name = "商品品號'", FieldIndex = 7)]
        public string 商品品號 { get { return 通用函式.取得字串(_Data.額外資訊, 16); } }
        [CsvColumn(Name = "'實際出貨數量'", FieldIndex = 8)]
        public string 實際出貨數量 { get { return 通用函式.取得字串(_Data.額外資訊, 20); } }
    }
}
