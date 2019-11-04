using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class PDF測試視窗 : Form
    {
        private static string 字體路徑 = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\..\Fonts\kaiu.ttf";
        private static BaseFont 字體 = BaseFont.CreateFont(
            字體路徑,
            BaseFont.IDENTITY_H, //橫式中文
            BaseFont.NOT_EMBEDDED
        );
        private static iTextSharp.text.Font 小字格式 = new iTextSharp.text.Font(字體, 9);

        public PDF測試視窗()
        {
            InitializeComponent();
            Console.WriteLine(字體路徑);
        }

        private void 定位_Click(object sender, EventArgs e)
        {
            // 取得匯入檔案
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (.pdf)|*.pdf";
            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            // 寫入資料
            PdfReader reader = null;
            FileStream fs = null;
            Document document = null;
            PdfWriter writer = null;
            try
            {
                PdfReader.unethicalreading = true;

                // 開啟匯入檔案
                reader = new PdfReader(dlg.FileName);

                // 開啟寫入檔案
                string OutputName = dlg.FileName.Replace(".pdf", "_定位.pdf");
                iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
                document = new Document(size);
                fs = new FileStream(OutputName, FileMode.Create, FileAccess.Write);
                writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                for (var i = 1; i <= reader.NumberOfPages; i++)
                {
                    document.NewPage();

                    // 拷貝舊資料
                    var importedPage = writer.GetImportedPage(reader, i);
                    PdfContentByte contentByte = writer.DirectContent;
                    contentByte.AddTemplate(importedPage, 0, 0);

                    Phrase myText;
                    for (int x = 0; x < 60; x++)
                    {
                        for (int y = 0; y < 90; y++)
                        {
                            if (x == 0 && y == 0)
                                myText = new Phrase("X", 小字格式);
                            else if(y % 10 == 0)
                                myText = new Phrase((y / 10).ToString(), 小字格式);
                            else if (x % 10 == 0)
                                myText = new Phrase((x / 10).ToString(), 小字格式);
                            else
                                myText = new Phrase(".", 小字格式);

                            ColumnText ct = new ColumnText(writer.DirectContent);

                            ct.SetSimpleColumn(myText, x * 10, y * 10, x * 10 + 10, y * 10, 0, Element.ALIGN_LEFT);
                            ct.Go();
                        }
                    }
                }
            }
            catch (Exception theException)
            {
                MessageBox.Show("momo第三方配送失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                /*if (writer != null)
                    writer.Close();*/
                if (document != null)
                    document.Close();
                if (fs != null)
                    fs.Close();
                if (reader != null)
                    reader.Close();
            }
        }

        private void 位移_Click(object sender, EventArgs e)
        {
            // 取得匯入檔案
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "pdf files (.pdf)|*.pdf";
            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            // 寫入資料
            PdfReader reader = null;
            FileStream fs = null;
            Document document = null;
            PdfWriter writer = null;
            try
            {
                PdfReader.unethicalreading = true;

                // 開啟匯入檔案
                reader = new PdfReader(dlg.FileName);

                // 開啟寫入檔案
                string OutputName = dlg.FileName.Replace(".pdf", "_位移.pdf");
                iTextSharp.text.Rectangle size = reader.GetPageSizeWithRotation(1);
                document = new Document(size);
                fs = new FileStream(OutputName, FileMode.Create, FileAccess.Write);
                writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                for (var i = 1; i <= reader.NumberOfPages; i++)
                {
                    document.NewPage();

                    // 拷貝舊資料
                    var importedPage = writer.GetImportedPage(reader, i);
                    PdfContentByte contentByte = writer.DirectContent;
                    contentByte.AddTemplate(importedPage, 0, 20);
                }
            }
            catch (Exception theException)
            {
                MessageBox.Show("momo第三方配送失敗，請通知苦逼程式," + theException.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                /*if (writer != null)
                    writer.Close();*/
                if (document != null)
                    document.Close();
                if (fs != null)
                    fs.Close();
                if (reader != null)
                    reader.Close();
            }
        }

        private void 取出影像_Click(object sender, EventArgs e)
        {
            // 開啟參考檔案位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "pdf files (.pdf)|*.pdf";

            if (OFD_.ShowDialog() != DialogResult.OK)
                return;

            string 路徑_ = System.IO.Path.GetDirectoryName(OFD_.FileName);
            Console.WriteLine("路徑: " + 路徑_);

            PdfReader.unethicalreading = true;
            using (PdfReader PdfReader_ = new PdfReader(OFD_.FileName))
            {
                int n = PdfReader_.XrefSize;
                for (int i = 0; i < n; i++)
                {
                    PdfObject po = PdfReader_.GetPdfObject(i); //get the object at the index i in the objects collection
                    if (po == null || !po.IsStream()) //object not found so continue
                        continue;

                    PRStream pst = (PRStream)po; //cast object to stream
                    PdfObject type = pst.Get(PdfName.SUBTYPE); //get the object type

                    //check if the object is the image type object
                    if (type == null || type.ToString().Equals(PdfName.IMAGE.ToString()) == false)
                        continue;

                    PdfImageObject pio = new PdfImageObject(pst); //get the image

                    FileStream fs = new FileStream(路徑_ + "/image" + i + ".jpg", FileMode.Create);
                    //read bytes of image in to an array
                    byte[] imgdata = pio.GetImageAsBytes();
                    //write the bytes array to file
                    fs.Write(imgdata, 0, imgdata.Length);
                    fs.Flush();
                    fs.Close();
                }
            }   
        }

        private void 抓取_Click(object sender, EventArgs e)
        {
            // 開啟參考檔案位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "pdf files (.pdf)|*.pdf";

            if (OFD_.ShowDialog() != DialogResult.OK)
                return;

            string 路徑_ = System.IO.Path.GetDirectoryName(OFD_.FileName);
            Console.WriteLine("路徑: " + 路徑_);

            using (PdfReader PdfReader_ = new PdfReader(OFD_.FileName))
            {
                // 開啟寫入檔案
                string 寫檔名稱_ = OFD_.FileName.Replace(".pdf", "_覆蓋.pdf");
                iTextSharp.text.Rectangle 尺寸_ = PdfReader_.GetPageSizeWithRotation(1);

                using (FileStream FS_ = new FileStream(寫檔名稱_, FileMode.Create, FileAccess.Write))
                {
                    using (Document Document_ = new Document(尺寸_))
                    {
                        PdfWriter PdfWriter_ = PdfWriter.GetInstance(Document_, FS_);
                        Document_.Open();

                        for (int 頁索引_ = 1; 頁索引_ <= PdfReader_.NumberOfPages; 頁索引_++)
                        {
                            Document_.NewPage();

                            // 拷貝舊資料
                            PdfImportedPage importedPage = PdfWriter_.GetImportedPage(PdfReader_, 頁索引_);
                            PdfContentByte contentByte = PdfWriter_.DirectContent;
                            contentByte.AddTemplate(importedPage, 0, 0);

                            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(new Bitmap(200, 200), BaseColor.WHITE);
                            image.SetAbsolutePosition(100, 100);
                            contentByte.AddImage(image);
                        }
                    }
                }
            }
        }

        private void 移動_Click(object sender, EventArgs e)
        {
            // 開啟參考檔案位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "pdf files (.pdf)|*.pdf";

            if (OFD_.ShowDialog() != DialogResult.OK)
                return;

            string 路徑_ = System.IO.Path.GetDirectoryName(OFD_.FileName);
            Console.WriteLine("路徑: " + 路徑_);

            using (PdfReader PdfReader_ = new PdfReader(OFD_.FileName))
            {
                // 開啟寫入檔案
                string 寫檔名稱_ = OFD_.FileName.Replace(".pdf", "_移動2.pdf");
                iTextSharp.text.Rectangle 尺寸_ = PdfReader_.GetPageSizeWithRotation(1);

                using (FileStream FS_ = new FileStream(寫檔名稱_, FileMode.Create, FileAccess.Write))
                {
                    using (Document Document_ = new Document(尺寸_))
                    {
                        PdfWriter PdfWriter_ = PdfWriter.GetInstance(Document_, FS_);
                        Document_.Open();

                        for (int 頁索引_ = 1; 頁索引_ <= PdfReader_.NumberOfPages; 頁索引_++)
                        {
                            Document_.NewPage();

                            PdfImportedPage importedPage = PdfWriter_.GetImportedPage(PdfReader_, 頁索引_);
                            PdfContentByte contentByte = PdfWriter_.DirectContent;

                            PdfTemplate template = contentByte.CreateTemplate(300, 600);
                            template.Rectangle(0, 0, 150, 300);
                            template.Clip();
                            template.NewPath();
                            template.AddTemplate(importedPage, 0, 0);
                            contentByte.AddTemplate(template, 100, 100);
                        }
                    }
                }
            }
        }

        private void 測試_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 平台訂單配送轉換資料_蝦皮_全家(null);
            檔案.詢問並修改(轉換_, true);
        }
    }
}
