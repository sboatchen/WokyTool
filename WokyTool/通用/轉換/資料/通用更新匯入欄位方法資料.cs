using System;

namespace WokyTool.通用
{
    public class 通用更新匯入欄位方法資料    // where T: ??
    {
        public int 優先級 { get; set; }

        public Action<object, string[]> 方法 { get; set; }
    }
}
