using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.通用
{
    public interface 可配送介面
    {
        string 姓名 { get; set; }
        string 電話 { get; set; }
        string 手機 { get; set; }
        string 地址 { get; set; }

        string 內容 { get; set; }
        string 備註 { get; set; }

        DateTime 指配日期 { get; set; }     // 指配日期.Ticks == 0 代表不指定
        列舉.指配時段 指配時段 { get; set; }

        列舉.代收方式 代收方式 { get; set; }
        int 代收金額 { get; set; }

        列舉.配送公司 配送公司 { get; set; }
        string 配送單號 { get; set; }

        // 完成配送
        void 完成配送(string 配送單號_);
        // 是否已經配送
        bool 是否已配送();

        Dictionary<String, int> 內容清單 { get; set; }
    }
}
