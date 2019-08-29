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
    public class PDF清除元件 
    {
        public Rectangle 範圍{ get; set; }

        public PDF清除元件(Rectangle 範圍_)
        {
            this.範圍 = 範圍_;
        }

        public void 處理(PdfWriter PdfWriter_)
        {
            PdfContentByte PdfContentByte_ = PdfWriter_.DirectContent;

            Image image = Image.GetInstance(new System.Drawing.Bitmap((int)範圍.Width, (int)範圍.Height), BaseColor.WHITE);
            image.SetAbsolutePosition(範圍.Left, 範圍.Bottom);
            PdfContentByte_.AddImage(image);
        }
    }
}
