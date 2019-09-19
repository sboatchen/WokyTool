using LINQtoCSV;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.通用;

namespace WokyTool.客製
{
    class 平台訂單回單轉換_PC商店街 : 可格式化_Csv
    {
        private static string 全速配編號 = "8";
        private static string 宅配通編號 = "4";

        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_PC商店街(平台訂單新增資料 Data_)
        {
            _Data = Data_;
        }

        [CsvColumn(Name = "訂單編號", FieldIndex = 1)]
        public string 訂單編號
        {
            get
            {
                return _Data.訂單編號;
            }
        }

        [CsvColumn(Name = "出貨日期", FieldIndex = 2)]
        public string 出貨日期
        {
            get
            {
                return 時間.目前日期_斜線;
            }
        }

        [CsvColumn(Name = "出貨物流商", FieldIndex = 3)]
        public string 出貨物流商
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
                        訊息管理器.獨體.錯誤("平台訂單回單轉換_PC商店街 不支援配送公司 " + _Data.配送公司.ToString());
                        return 字串.空;
                }
            }
        }

        [CsvColumn(Name = "物流單號", FieldIndex = 4)]
        public string 物流單號
        {
            get
            {
                return _Data.配送單號;
            }
        }
    }
}
