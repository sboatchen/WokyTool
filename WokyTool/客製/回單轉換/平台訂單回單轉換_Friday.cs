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
    class 平台訂單回單轉換_Friday : 可格式化_Csv
    {
        private static string 全速配編號 = "4";
        private static string 宅配通編號 = "3";

        protected 平台訂單新增資料 _Data;

        public 平台訂單回單轉換_Friday(平台訂單新增資料 Data_)
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

        [CsvColumn(Name = "出貨單號", FieldIndex = 2)]
        public string 出貨單號
        {
            get
            {
                return 函式.取得字串(_Data.額外資訊, 4);
            }
        }

        [CsvColumn(Name = "宅配廠商代碼", FieldIndex = 3)]
        public string 配送公司
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
                        if (_Data.處理狀態 != 列舉.訂單處理狀態.忽略)
                            訊息管理器.獨體.錯誤("平台訂單回單轉換_Friday 不支援配送公司 " + _Data.配送公司.ToString());
                        return 字串.空;
                }
            }
        }

        [CsvColumn(Name = "宅配單號", FieldIndex = 4)]
        public string 配送單號
        {
            get
            {
                return _Data.配送單號;
            }
        }
    }
}
