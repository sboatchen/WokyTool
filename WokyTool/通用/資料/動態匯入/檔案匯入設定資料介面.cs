using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    public interface 檔案匯入設定資料介面
    {
        int 編號 { get; set; }

        列舉.檔案格式類型 格式 { get; set; }

        int 開始位置 { get; set; }

        int 結束位置 { get; set; }

        int 標頭位置 { get; set; }

        string 名稱 { get; set; }

        List<欄位匯入設定資料> 資料List { get; set; }

        Dictionary<int, 欄位匯入設定資料> 欄位位置對應表 { get; }
        Dictionary<string, 欄位匯入設定資料> 名稱映射對應表 { get; }

        欄位匯入設定資料 取得欄位匯入設定資料(int Index_);
        欄位匯入設定資料 取得欄位匯入設定資料(int Index_, 欄位匯入設定資料 Defualt_);

        欄位匯入設定資料 取得欄位匯入設定資料(String Name_);
        欄位匯入設定資料 取得欄位匯入設定資料(String Name_, 欄位匯入設定資料 Defualt_);
    }
}
