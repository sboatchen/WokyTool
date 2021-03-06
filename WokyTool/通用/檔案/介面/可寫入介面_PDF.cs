﻿using iTextSharp.text.pdf;

namespace WokyTool.通用
{
    public interface 可寫入介面_PDF
    {
        string 標頭 { get; }

        string 密碼 { get; }

        void 寫入(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_);
        void 測試(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_);
    }
}
