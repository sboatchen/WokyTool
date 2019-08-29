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
    public class PDF定位元件
    {
        public Font 字體 { get; set; }

        public PDF定位元件()
        {
            字體 = new Font(常數.通用字體設定, 7); 
        }

        public void 處理(PdfWriter PdfWriter_)
        {
            PdfContentByte PdfContentByte_ = PdfWriter_.DirectContent;

            Phrase Phrase_;
            for (int x = 0; x <= 60; x++)
            {
                for (int y = 0; y <= 85; y++)
                {
                    if (x == 0 && y == 0)
                        Phrase_ = new Phrase("X", 字體);
                    else if (y % 10 == 0)
                        Phrase_ = new Phrase((y / 10).ToString(), 字體);
                    else if (x % 10 == 0)
                        Phrase_ = new Phrase((x / 10).ToString(), 字體);
                    else
                        Phrase_ = new Phrase(".", 字體);

                    ColumnText ct = new ColumnText(PdfContentByte_);

                    ct.SetSimpleColumn(Phrase_, x * 10, y * 10, x * 10 + 10, y * 10, 0, Element.ALIGN_LEFT);
                    ct.Go();
                }
            }
        }
    }
}
