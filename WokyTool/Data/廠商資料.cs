using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataMgr;

namespace WokyTool.Data
{
    public class 廠商資料
    {
        [CsvColumn(Name = "編號")]
        public int 編號 { get; set; }
        [CsvColumn(Name = "開啟")]
        public bool 開啟 { get; set; }

        [CsvColumn(Name = "名稱")]
        public string 名稱 { get; set; }

        public static 廠商資料 New()
        {
            return new 廠商資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編碼類型.廠商),
                開啟 = false,
                名稱 = 字串.空,
            };
        }

        private static readonly 廠商資料 _NULL = new 廠商資料
        {
            編號 = 0,
            開啟 = false,
            名稱 = 字串.無,
        };
        public static 廠商資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 廠商資料 _ERROR = new 廠商資料
        {
            編號 = -1,
            開啟 = false,
            名稱 = 字串.錯誤,
        };
        public static 廠商資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
