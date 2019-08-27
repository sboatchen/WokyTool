using IronOcr;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單配送轉換_生活市集_全家 : 可寫入介面_PDF
    {
        private static Dictionary<PDF字串讀出元件, PDF字串寫入元件> _設定資料書;
        public static Dictionary<PDF字串讀出元件, PDF字串寫入元件> 設定資料書
        {
            get 
            {
                if (_設定資料書 == null)
                {
                    // 讀出 訂單編號
                    // 寫入 物品組成
                    _設定資料書 = new Dictionary<PDF字串讀出元件, PDF字串寫入元件>();
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(125, 750, 180, 770)), new PDF字串寫入元件(new Rectangle(10, 785, 290, 840), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(390, 750, 450, 770)), new PDF字串寫入元件(new Rectangle(310, 785, 590, 840), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(125, 385, 180, 400)), new PDF字串寫入元件(new Rectangle(10, 0, 290, 53), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(390, 385, 450, 400)), new PDF字串寫入元件(new Rectangle(310, 0, 590, 53), 常數.通用字體));
                }

                return _設定資料書;
            }
        }

        public string 密碼 { get { return null; } }

        public double X位移 { get { return 0; } }
        public double Y位移 { get { return -20; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        private Dictionary<string, 物品合併資料> _物品合併資料書;
        private List<物品合併資料> _物品合併資料列;
        private int _以處理資料索引 = 0;

        public 平台訂單配送轉換_生活市集_全家(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;

            _物品合併資料列 = new List<物品合併資料>();
            _物品合併資料書 = new Dictionary<string, 物品合併資料>();

            foreach (var 資料_ in 資料列舉_)
            {
                物品合併資料 物品合併資料_;
                if (_物品合併資料書.TryGetValue(資料_.配送單號, out 物品合併資料_) == false)
                {
                    物品合併資料_ = new 物品合併資料();
                    _物品合併資料書.Add(資料_.配送單號, 物品合併資料_);
                    _物品合併資料列.Add(物品合併資料_);
                }

                物品合併資料_.新增(資料_.商品, 資料_.數量);
            }
        }

        public void 寫入(PdfReader PdfReader_, int 頁索引_, PdfContentByte PCB_)
        {
            if(_以處理資料索引 == 1)
                return;
            _以處理資料索引++;

            /*foreach (var Pair_ in 設定資料書)
            {
                if (_以處理資料索引 >= _物品合併資料列.Count)
                    return;

                物品合併資料 物品合併資料_ = _物品合併資料列.ElementAt(_以處理資料索引++);
                Pair_.Value.寫入(PCB_, 物品合併資料_.ToString());
            }*/

            PdfDictionary pg = PdfReader_.GetPageN(頁索引_);

            // recursively search pages, forms and groups for images.
            PdfObject obj = FindImageInPDFDictionary(pg);
            if (obj != null)
            {
                int XrefIndex = Convert.ToInt32(((PRIndirectReference)obj).Number.ToString(System.Globalization.CultureInfo.InvariantCulture));
                PdfObject pdfObj = PdfReader_.GetPdfObject(XrefIndex);

                PRStream pst = (PRStream)pdfObj; //cast object to stream
                PdfImageObject pio = new PdfImageObject(pst); //get the image
                System.Drawing.Image img = pio.GetDrawingImage();

                var Ocr = new AutoOcr();

                {
                    System.Drawing.Rectangle 範圍_ = new System.Drawing.Rectangle(435, 200, 265, 50);
                    var Result = Ocr.Read(img, 範圍_);
                    Console.WriteLine(Result.Text);

                    Console.WriteLine("@@@@");
                }
            }


            /*int n = PdfReader_.XrefSize;
            for (int i = 0; i < n; i++)
            {
                PdfObject  po = PdfReader_.GetPdfObject(i); //get the object at the index i in the objects collection
                if (po == null || !po.IsStream()) //object not found so continue
                    continue;

                PRStream pst = (PRStream)po; //cast object to stream
                PdfObject type = pst.Get(PdfName.SUBTYPE); //get the object type

                //check if the object is the image type object
                if (type == null || type.ToString().Equals(PdfName.IMAGE.ToString()) == false)
                    continue;

                PdfImageObject  pio = new PdfImageObject(pst); //get the image

                FileStream fs = new FileStream("ABC/image" + i + ".jpg", FileMode.Create);
                //read bytes of image in to an array
                byte[] imgdata=pio.GetImageAsBytes();
                //write the bytes array to file
                fs.Write(imgdata, 0, imgdata.Length);
                fs.Flush();
                fs.Close();
            }*/
        }

        private static PdfObject FindImageInPDFDictionary(PdfDictionary pg)
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
                            return obj;
                        }// image inside a form
                        else if (PdfName.FORM.Equals(type))
                        {
                            return FindImageInPDFDictionary(tg);
                        } //image inside a group
                        else if (PdfName.GROUP.Equals(type))
                        {
                            return FindImageInPDFDictionary(tg);
                        }

                    }
                }
            }

            return null;
        }
    }
}
