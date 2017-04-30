using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.Data
{
    public class 編碼資料
    {
        [CsvColumn(Name = "類型")]
        public 列舉.編碼類型 類型 { get; set; }
        [CsvColumn(Name = "下個值")]
        public int 下個值 { get; set; }

        public 編碼資料()
        {
            類型 = 列舉.編碼類型.無;
            下個值 = 1;
        }

        public 編碼資料(列舉.編碼類型 類型_)
        {
            類型 = 類型_;
            下個值 = 1;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
