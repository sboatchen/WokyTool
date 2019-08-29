using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public class PDF拷貝元件
    {
        public Rectangle 範圍{ get; set; }

        public int 位置X { get; set; }

        public int 位置Y { get; set; }

        public PDF拷貝元件()
        {
            // 全拷貝
        }

        public PDF拷貝元件(Rectangle 範圍_)
        {
            this.範圍 = 範圍_;
            this.位置X = (int)範圍_.Left;
            this.位置Y = (int)範圍_.Bottom;
        }

        public PDF拷貝元件(int 位置X_, int 位置Y_)
        {
            // 全拷貝
            this.位置X = 位置X_;
            this.位置Y = 位置Y_;
        }

        public PDF拷貝元件(Rectangle 範圍_, int 位置X_, int 位置Y_)
        {
            this.範圍 = 範圍_;
            this.位置X = 位置X_;
            this.位置Y = 位置Y_;
        }

        public void 處理(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_)
        {
            PdfImportedPage PdfImportedPage_ = PdfWriter_.GetImportedPage(PdfReader_, 頁索引_);
            PdfContentByte PdfContentByte_ = PdfWriter_.DirectContent;

            if (範圍 != null)
            {
                Rectangle 整頁範圍_ = PdfReader_.GetPageSize(頁索引_);

                PdfTemplate PdfTemplate_ = PdfContentByte_.CreateTemplate(整頁範圍_.Width, 整頁範圍_.Height);
                PdfTemplate_.Rectangle(範圍.Left, 範圍.Bottom, 範圍.Width, 範圍.Height);
                PdfTemplate_.Clip();
                PdfTemplate_.NewPath();
                PdfTemplate_.AddTemplate(PdfImportedPage_, 0, 0);
                PdfContentByte_.AddTemplate(PdfTemplate_, 位置X, 位置Y);
            }
            else
            {
                PdfContentByte_.AddTemplate(PdfImportedPage_, 位置X, 位置Y);
            }
        }
    }
}
