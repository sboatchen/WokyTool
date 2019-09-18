using System;

namespace WokyTool.通用
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class 可匯出Attribute : Attribute
    {
        public string 名稱 { get; set; }
    }
}
