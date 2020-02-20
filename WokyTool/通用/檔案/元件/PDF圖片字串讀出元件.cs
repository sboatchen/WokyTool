using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Linq;
using System.Collections.Generic;
using Tesseract;
using System.Drawing;

namespace WokyTool.通用
{
    public class PDF圖片字串讀出元件
    {
        private static TesseractEngine _OCR = null;
        protected static TesseractEngine OCR
        {
            get
            {
                if(_OCR == null)
                    _OCR = new TesseractEngine("./tessdata", "chi_tra");
                return _OCR;
            }
        }

        // 請注意 這邊的範圍 不是指圖片文字在PDF上的範圍，而是指文字在圖片上的範圍
        public Rect 範圍 { get; set; }

        public int 索引 { get; set; }

        public PDF圖片字串讀出元件(Rect 範圍_, int 索引_ = 0, string 語系_ = "chi_tra")
        {
            this.範圍 = 範圍_;
            this.索引 = 索引_;
        }

        public string 處理(PdfReader PdfReader_, int 頁索引_)
        {
            PdfDictionary pg = PdfReader_.GetPageN(頁索引_);

            // recursively search pages, forms and groups for images.
            //Console.WriteLine("圖片數量:" + FindImageInPDFDictionary(pg).Count());
            PdfObject obj = FindImageInPDFDictionary(pg).Skip(索引).DefaultIfEmpty(null).First();
            if (obj != null)
            {
                int XrefIndex = Convert.ToInt32(((PRIndirectReference)obj).Number.ToString(System.Globalization.CultureInfo.InvariantCulture));
                PdfObject pdfObj = PdfReader_.GetPdfObject(XrefIndex);

                PRStream pst = (PRStream)pdfObj; //cast object to stream
                PdfImageObject pio = new PdfImageObject(pst); //get the image

                using (System.Drawing.Image img = pio.GetDrawingImage())
                {
                    using (Bitmap bit = new Bitmap(img))
                    {
                        //bit = PreprocesImage(bit);//進行影象處理,如果識別率低可試試

                        using (Page page = OCR.Process(bit))
                        {
                            page.RegionOfInterest = 範圍;

                            string str = page.GetText();//識別後的內容

                            return str.Replace(" ", "");
                        }
                    }
                }
            }

            return null;
        }

        private static IEnumerable<PdfObject> FindImageInPDFDictionary(PdfDictionary pg)
        {
            PdfDictionary res = (PdfDictionary)PdfReader.GetPdfObject(pg.Get(PdfName.RESOURCES));
            PdfDictionary xobj = (PdfDictionary)PdfReader.GetPdfObject(res.Get(PdfName.XOBJECT));
            if (xobj != null)
            {
                foreach (PdfName name in xobj.Keys)
                {

                    PdfObject obj = xobj.Get(name);
                    if (obj.IsIndirect())
                    {
                        PdfDictionary tg = (PdfDictionary)PdfReader.GetPdfObject(obj);

                        PdfName type =
                          (PdfName)PdfReader.GetPdfObject(tg.Get(PdfName.SUBTYPE));

                        //image at the root of the pdf
                        if (PdfName.IMAGE.Equals(type))
                        {
                            yield return obj;
                        }// image inside a form
                        else if (PdfName.FORM.Equals(type))
                        {
                            foreach(var Item_ in FindImageInPDFDictionary(tg))
                                yield return Item_;
                        } //image inside a group
                        else if (PdfName.GROUP.Equals(type))
                        {
                            foreach (var Item_ in FindImageInPDFDictionary(tg))
                                yield return Item_;
                        }
                    }
                }
            }
        }
    }
}
