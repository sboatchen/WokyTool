using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class 可匯入Attribute : Attribute
    {
        public string 名稱 { get; set; }

        public string 說明 { get; set; }

        public int 優先級 { get; set; }    // 越小越優先

        public bool 識別 { get; set; }

        public 可匯入Attribute()
        {
            優先級 = Int32.MaxValue;
        }
    }
}
