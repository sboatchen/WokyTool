using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WokyTool.通用
{
    public partial class 檔案
    {
        public static void 詢問並修改(string 標頭_, 可寫入介面_PDF 轉換_, bool 是否測試_ = false)
        {
            // 開啟參考檔案位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "pdf files (.pdf)|*.pdf";
            OFD_.Title = 標頭_;

            if (OFD_.ShowDialog() != DialogResult.OK)
                return;

            PdfReader.unethicalreading = true;

            byte[] 密碼_ = null;
            if(轉換_.密碼 != null)
                密碼_ = Encoding.UTF8.GetBytes(轉換_.密碼);

            using (PdfReader PdfReader_ = (密碼_ == null) ? new PdfReader(OFD_.FileName) : new PdfReader(OFD_.FileName, 密碼_))
            {
                // 開啟寫入檔案
                string 寫檔名稱_ = OFD_.FileName.Replace(".pdf", "_修改.pdf");
                Rectangle 尺寸_ = PdfReader_.GetPageSizeWithRotation(1);

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
                            contentByte.AddTemplate(importedPage, 轉換_.X位移, 轉換_.Y位移);

                            if (是否測試_)
                                轉換_.測試(PdfReader_, 頁索引_, contentByte);
                            else
                                轉換_.寫入(PdfReader_, 頁索引_, contentByte);
                        }
                    }
                }
            }
        }
    }
}
