using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 檔案匯入轉換介面<T> where T : MyData
    {
        BindingList<T> 轉換綁定陣列(動態匯入檔案結構 動態匯入檔案結構_);
    }
}
