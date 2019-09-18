using System.Collections.Generic;

namespace WokyTool.通用
{
    public interface 檔案匯入轉換介面<T> where T : 基本資料
    {
        IEnumerable<T> 轉換(動態匯入檔案結構 動態匯入檔案結構_);
    }
}
