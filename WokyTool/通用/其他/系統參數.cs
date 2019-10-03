using System;

namespace WokyTool.通用
{
    public class 系統參數
    {
        public static String 使用者名稱 { get; set; }
        public static int 使用者編號 { get; set; }

        public static bool 修改基本資料 { get; set; }
        public static bool 修改設定資料 { get; set; }

        public static bool 匯入訂單 { get; set; }   //@@ 改成 處理訂單
        public static bool 匯入進貨 { get; set; }   //@@ 改成 處理進貨
        public static bool 匯入月結帳 { get; set; }  //@@ 改成 處理月結帳

        public static string 訊息路徑 { get; set; }
        public static string 備份路徑 { get; set; }
    }
}
