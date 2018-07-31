using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.客戶;

namespace WokyTool.通用
{
    public interface 可下訂介面
    {
        string 姓名 { get; set; }
        string 地址 { get; set; }
        string 電話 { get; set; }
        string 手機 { get; set; }

        公司資料 公司 { get; set; }
        客戶資料 客戶 { get; set; }

        int 數量 { get; set; }
        decimal 單價 { get; set; }
        decimal 含稅單價 { get; set; }
        decimal 總金額 { get; }
        decimal 成本 { get; set; }
        decimal 利潤 { get; }
        decimal 總利潤 { get; }

        string 訂單編號 { get; set; }
        string 訂單內容 { get; set; }
        string 備註 { get; set; }

        列舉.配送公司類型 配送公司 { get; set; }
        string 配送單號 { get; set; }
    }
}
