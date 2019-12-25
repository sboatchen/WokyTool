using System.Collections.Generic;

namespace WokyTool.通用
{
    public interface 可讀出介面_EXCEL<T>
    {
        int 分頁索引 { get; }

        string 分頁名稱 { get; }

        int 標頭索引 { get; }

        int 資料開始索引 { get; }

        int 資料結尾忽略行數 { get; }

        string 密碼 { get; }

        void 讀出標頭(string[] 標頭列_);

        IEnumerable<T> 讀出資料(string[] 資料列_);

        void 讀出額外資訊(int 索引_, string[] 資料列_);
    }
}
