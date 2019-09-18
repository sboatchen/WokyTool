using iTextSharp.text;
using iTextSharp.text.pdf;
using System;

namespace WokyTool.通用
{
    public static class 常數
    {
        //@@@ 待整理
        public static int 舊的新資料編碼 = -2;
        public static int 舊的錯誤資料編碼 = -1;
        public static int 舊的空白資料編碼 = 0;

        public const int 新建資料編碼 = 0;
        public const int 空白資料編碼 = -1;
        public const int 錯誤資料編碼 = -2;
        public const int 不篩選資料編碼 = -5;

        public const int 商品折扣資料編碼 = -3; //@@
        public const int 品牌混和資料編碼 = -4; //@@

        public const int 空白列舉編碼 = 0;
        public const int 錯誤列舉編碼 = -2;
        public const int 不篩選列舉編碼 = -5;

        public static int 宅配通配送最小體積 = 0;

        public static BaseFont 通用字體設定 = BaseFont.CreateFont(
            Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\..\Fonts\kaiu.ttf",
            BaseFont.IDENTITY_H, //橫式中文
            BaseFont.NOT_EMBEDDED
        );
        public static Font 通用字體 = new Font(通用字體設定, 13);
    }
}
