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
    public class 幣值資料
    {
        [CsvColumn(Name = "編號")]
        public int 編號 { get; set; }
        [CsvColumn(Name = "名稱")]
        public string 名稱 { get; set; }
        [CsvColumn(Name = "數值")]
        public double 數值 { get; set; }

        public static 幣值資料 New()
        {
            return new 幣值資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編碼類型.幣值),
                名稱 = 字串.空,
                數值 = 0,
            };
        }

        private static readonly 幣值資料 _DEFAULT = new 幣值資料
        {
            編號 = 常數.空白資料編碼,
            名稱 = 字串.TW,
            數值 = 1,
        };
        public static 幣值資料 DEFAULT
        {
            get
            {
                return _DEFAULT;
            }
        }

        private static 幣值資料 _ERROR = new 幣值資料
        {
            編號 = 常數.錯誤資料編碼,
            名稱 = 字串.錯誤,
            數值 = -1,
        };
        public static 幣值資料 ERROR
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
