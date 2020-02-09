using System.Collections.Generic;
using System.Text;

namespace WokyTool.通用
{
    public interface 可讀出介面_CSV<T>
    {
        string 分格號 { get; }

        string 密碼 { get; }

        Encoding 編碼 { get; }

        int 標頭索引 { get; }

        int 資料開始索引 { get; }

        int 資料結尾忽略行數 { get; }

        void 讀出檔名(string 檔名_);

        void 讀出標頭(string[] 標頭列_);

        IEnumerable<T> 讀出資料(string[] 資料列_);
    }
}
