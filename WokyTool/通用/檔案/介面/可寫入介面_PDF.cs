using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可寫入介面_PDF
    {
        //string 樣板 { get; }

        string 密碼 { get; }

        void 寫入(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_);
        void 測試(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_);
    }
}
