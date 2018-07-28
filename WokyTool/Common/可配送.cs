using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 可配送
    {
        string 配送姓名 { get; set; }
        string 配送電話 { get; set; }
        string 配送手機 { get; set; }
        string 配送地址 { get; set; }

        string 配送商品 { get; set; }
        string 配送備註 { get; set; }

        DateTime 指配日期 { get; set; }     // 指配日期.Ticks == 0 代表不指定
        列舉.指配時段類型 指配時段 { get; set; }

        列舉.代收類型 代收方式 { get; set; }
        int 代收金額 { get; set; }

        列舉.配送公司類型 配送公司 { get; set; }
        string 配送單號 { get; set; }

        // 準備配送
        void 準備配送();
        // 完成配送
        void 完成配送(string 配送單號_);
        // 是否已經配送
        bool 是否已配送();


        Dictionary<String, int> 配送物品清單 { get; set; }

        // 發票是否符合
        bool IsReceiptMatch(string 發票號碼_);
    }
}
