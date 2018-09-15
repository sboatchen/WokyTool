using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public class 系統參數
    {
        public static String 使用者 { get; set; }
        public static int 使用者編號 { get; set; }


        public static bool 修改基本資料 { get; set; }
        public static bool 修改設定資料 { get; set; }

        public static bool 匯入訂單 { get; set; }
        public static bool 匯入月結帳 { get; set; }
    }
}
