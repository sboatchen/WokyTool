using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 通用更新匯入欄位方法資料    // where T: ??
    {
        public int 優先級 { get; set; }

        public Action<object, string[]> 方法 { get; set; }
    }
}
