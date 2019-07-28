using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.Common
{
    public static class 舊列舉
    {
        public enum 訂單處理進度類型
        {
            錯誤 = 常數.錯誤資料編碼,
            無 = 常數.空白資料編碼,
            
            新建,
            匯入錯誤,
            匯入正確,
            分組完成,
            要求配送,
            配送完成,
        };

        public enum 搜尋失敗處理類型
        {
            無 = 常數.空白資料編碼,
            找不到時新增,
        };

        public enum 監測類型
        {
            主動通知_值 = 0,
            主動通知_公式,
            被動通知_值,
            被動通知_公式,
        };

        public static bool IsActive(this 監測類型 監測類型_)
        {
            switch (監測類型_)
            {
                case 監測類型.主動通知_值:
                case 監測類型.主動通知_公式:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsReturnValue(this 監測類型 監測類型_)
        {
            switch (監測類型_)
            {
                case 監測類型.主動通知_值:
                case 監測類型.被動通知_值:
                    return true;
                default:
                    return false;
            }
        }

        // 銷售狀態類型
        public enum 銷售狀態類型
        {
            出貨 = 0,
            結單,

            退貨,
            退貨結單,
        };

        public static bool IsClose(this 銷售狀態類型 銷售狀態類型_)
        {
            switch (銷售狀態類型_)
            {
                case 銷售狀態類型.結單:
                case 銷售狀態類型.退貨結單:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsAllowPrice(this 銷售狀態類型 銷售狀態類型_)
        {
            switch (銷售狀態類型_)
            {
                case 銷售狀態類型.出貨:
                    return true;
                default:
                    return false;
            }
        }

        // 盤點類型
        public enum 盤點類型
        {
            無 = -1,

            出貨 = 0,
            進貨 = 1,
        };
    }
}
