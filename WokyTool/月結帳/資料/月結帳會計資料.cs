using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳會計資料 : 可匯入資料
    {
        public string 客戶 { get; set; }

        public decimal 營業額 { get; set; }

        public decimal 佣金 { get; set; }

        public decimal 作帳應收 { get; set; }

        public decimal 實收 { get; set; }

        public String 應收款日期 { get; set; }

        public decimal 本期欠收 { get; set; }
        public decimal 前期欠收 { get; set; }

        public decimal 前期實收 { get; set; }

        public decimal 利潤
        {
            get
            {
                return 作帳應收 - 進貨成本 - 營業額 * 0.07m - 佣金;
            }
        }

        public decimal 進貨成本 { get; set; }

        public decimal 毛利率 
        {
            get
            {
                return 利潤  * 100 / 營業額 ;
            }
        }

        public String 業務 { get; set; }
    }
}

