﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public static class 常數
    {
        //@@ 考慮改成讀設定黨
        public static string 支出歷史檔案路徑 = "History/Outlay.csv";


        public static int 宅配通配送最小體積 = 5;

        //@@ 統一所有使用的地方
        public static int 新資料編碼 = -2;
        public static int 錯誤資料編碼 = -1;
        public static int 空白資料編碼 = 0;

        //@@
        public const int T新建資料編碼 = 0;
        public const int T空白資料編碼 = -1;
        public const int T錯誤資料編碼 = -2;

        public const int 空白列舉編碼 = 0;
        public const int 錯誤列舉編碼 = -2;
    }
}
