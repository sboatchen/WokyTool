using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Linq;
using System.Collections.Generic;
using Tesseract;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WokyTool.通用
{
    public class PDF圖片數值讀出元件
    {
        // 請注意 這邊的範圍 不是指圖片文字在PDF上的範圍，而是指文字在圖片上的範圍
        public Rect 範圍 { get; set; }

        public int 索引 { get; set; }

        public string 語系 { get; set; }

        public PDF圖片數值讀出元件(Rect 範圍_, int 索引_ = 0)
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
                System.Drawing.Image img = pio.GetDrawingImage();

                Bitmap bit = new Bitmap(img);
                //bit = PreprocesImage(bit);//進行影象處理,如果識別率低可試試

                using (TesseractEngine OCR_ = new TesseractEngine("./tessdata", "eng"))
                {
                    OCR_.SetVariable("tessedit_char_whitelist", "0123456789");

                    using (Page page = OCR_.Process(bit))
                    {
                        page.RegionOfInterest = 範圍;

                        string str = page.GetText();//識別後的內容

                        return str;
                    }
                }

                // Old OCR
                /*AutoOcr OCR = new AutoOcr();
                var Result = OCR.Read(img, 範圍);
                return Result.Text;*/
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

        /// <summary>
        /// 圖片顏色區分，剩下白色和黑色
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private Bitmap PreprocesImage(Bitmap image)
        {
            //You can change your new color here. Red,Green,LawnGreen any..
            Color actualColor;
            //make an empty bitmap the same size as scrBitmap
            image = ResizeImage(image, image.Width * 5, image.Height * 5);
            //image.Save(@"D:\UpWork\OCR_WinForm\Preprocess_Resize.jpg");

            Bitmap newBitmap = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    actualColor = image.GetPixel(i, j);
                    // > 150 because.. Images edges can be of low pixel colr. if we set all pixel color to new then there will be no smoothness left.
                    if (actualColor.R > 23 || actualColor.G > 23 || actualColor.B > 23)//在這裡設定RGB
                        newBitmap.SetPixel(i, j, Color.White);
                    else
                        newBitmap.SetPixel(i, j, Color.Black);
                }
            }
            return newBitmap;
        }

        /// <summary>
        /// 調整圖片大小和對比度
        /// </summary>
        /// <param name="image"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution * 2);//2,3
            //image.Save(@"D:\UpWork\OCR_WinForm\Preprocess_HighRes.jpg");

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceOver;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.Clamp);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
