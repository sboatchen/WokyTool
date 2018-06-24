using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public static class 列舉
    {
        // ID管理器用Key
        public enum 編碼類型
        {
            無 = 0,

            公司,
            廠商,

            物品大類,
            物品小類,
            物品品牌,
            物品,

            商品大類,
            商品小類,
            商品,

            月結帳,

            支出,

            幣值,

            入庫,
            入庫紀錄,

            銷售,
            盤點,

            訂單,
        };

        // 配送指定時段類型
        public enum 指配時段類型
        {
            無 = 0,

            上午,
            下午,
            晚上,
        };

        // 配送代收款方式
        public enum 代收類型
        {
            無 = 0,

            現金,
            刷卡,
        };

        // 配送公司類型
        public enum 配送公司類型
        {
            無 = 0,

            全速配,
            宅配通,
        };

        public enum 訂單處理進度類型
        {
            無 = 0,
            
            新建,
            匯入錯誤,
            匯入正確,
            分組完成,
            要求配送,
            配送完成,
        };

        public enum 搜尋失敗處理類型
        {
            無 = 0,
            找不到時新增,
        };

        public enum 進貨類型
        {
            一般 = 0,
            退貨重進,
            庫存調整,
        };

        public static bool IsAutoPrice(this 進貨類型 進貨類型_)
        {
            switch (進貨類型_)
            {
                case 進貨類型.退貨重進:
                case 進貨類型.庫存調整:
                    return true;
                default:
                    return false;
            }
        }

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

        // 檔案格式類型
        public enum 檔案格式類型
        {
            錯誤 = -1,
            無 = 0,

            CSV = 1,
            EXCEL = 2,
            PDF = 3,
            JSON = 4,
        };

        public enum 更新狀態
        {
            錯誤,
            新增,
            相同,
            更新,
        };

        public enum 資料格式類型
        {
            錯誤 = -1,
            無 = 0,

            整數 = 1,
            金額 = 2,
            文字 = 3,
        };

        public enum 商品識別類型
        {
            錯誤 = -1,
            無 = 0,

            商品編號 = 1,
            商品編號_顏色 = 2,
            商品名稱 = 3,
        };
    }
}
