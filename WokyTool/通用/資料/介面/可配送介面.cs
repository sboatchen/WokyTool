using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.通用
{
    public interface 可配送介面
    {
        string 姓名 { get; set; }
        string 備註 { get; set; }

        string 電話 { get; }
        string 手機 { get; }
        string 地址 { get; }

        物品組成資料 組成 { get; }
        string 內容 { get; }

        DateTime 指配日期 { get; }     // 指配日期.Ticks == 0 代表不指定
        列舉.指配時段 指配時段 { get; }

        列舉.代收方式 代收方式 { get; }
        decimal 代收金額 { get; }

        列舉.配送公司 配送公司 { get; set; }
        string 配送單號 { get; set; }

        // 是否已經配送
        bool 是否已配送();
    }
}
