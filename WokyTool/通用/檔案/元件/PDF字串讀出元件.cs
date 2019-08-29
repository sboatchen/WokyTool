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
    public class PDF字串讀出元件
    {
        public Rectangle 範圍{ get; set; }


        public PDF字串讀出元件(Rectangle 範圍_)
        {
            this.範圍 = 範圍_;
        }

        public string 處理(PdfReader PdfReader_, int 頁索引_)
        {
            return PdfTextExtractor.GetTextFromPage(PdfReader_, 頁索引_, 
                new FilteredTextRenderListener(
                    new LocationTextExtractionStrategy(), 
                        new RenderFilter[]{
                            new RegionTextRenderFilter(範圍)})).Trim();
        }
    }
}
