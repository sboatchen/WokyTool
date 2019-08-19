using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class 可匯出匯入Attribute : Attribute
    {
        public 可匯出匯入Attribute()
        {
            ;
        }

        public string 名稱 { get; set; }

        public bool 匯出 { get; set; }

        public bool 匯入 { get; set; }
    }
}
