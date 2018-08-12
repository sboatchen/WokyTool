using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.Data
{
    public class 公司資料
    {
        [CsvColumn(Name = "編號")]
        public int 編號 { get; set; }
        [CsvColumn(Name = "開啟")]
        public bool 開啟 { get; set; }

        [CsvColumn(Name = "名稱")]
        public string 名稱 { get; set; }

        public static 公司資料 New()
        {
            return new 公司資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編號.公司),
                開啟 = true,
                名稱 = 字串.空,
            };
        }

        private static readonly 公司資料 _NULL = new 公司資料
        {
            編號 = 常數.空白資料編碼,
            開啟 = false,
            名稱 = 字串.無,
        };
        public static 公司資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 公司資料 _ERROR = new 公司資料
        {
            編號 = 常數.錯誤資料編碼,
            開啟 = false,
            名稱 = 字串.錯誤,
        };
        public static 公司資料 ERROR
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
