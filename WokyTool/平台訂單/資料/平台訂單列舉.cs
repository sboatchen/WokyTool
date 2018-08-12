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
            商品編號,
            商品名稱,
            顏色,

            收件姓名,
            收件地址,
            收件電話,
            收件手機,

            數量,

            單價,
            含稅單價,
            總價,
            含稅總價,

            姓名,
            地址,
            電話,
            手機,

            訂單編號,
            備註,
        };
    }
}
