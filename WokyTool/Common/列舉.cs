﻿using System;
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
    }
}
