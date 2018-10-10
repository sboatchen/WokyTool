using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.平台訂單
{
    public static class 平台訂單列舉
    {
        public enum 匯入需求欄位
        {
            客戶訂單編號,

            客戶商品編號,
            客戶商品子編號,

            //商品名稱,
            顏色,

            數量,

            //單價,
            //含稅單價,
            //總價,
            //含稅總價,

            姓名,
            地址,
            電話,
            手機,

            備註,

            發票號碼,

            檢查_訂單類別,
            檢查_出貨狀態,
            檢查_出貨日期,
        };
    }
}
