using System;
using System.Drawing;
using System.Windows.Forms;
using Tesseract;

namespace WokyTool.測試
{
    public partial class Image測試視窗 : Form
    {
        public Image測試視窗()
        {
            InitializeComponent();
        }

        private void 字串_Click(object sender, EventArgs e)
        {
            // 開啟存檔位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            //OFD_.Filter = "csv files (.csv)|*.csv";
            if (OFD_.ShowDialog() != DialogResult.OK)
                return;

            Bitmap bit = new Bitmap(Image.FromFile(OFD_.FileName));

            using (TesseractEngine OCR_ = new TesseractEngine("./tessdata", "eng"))
            {
                OCR_.SetVariable("tessedit_char_whitelist", "0123456789");

                using (Page page = OCR_.Process(bit))
                {
                    string str = page.GetText();//識別後的內容

                    Console.WriteLine(str);
                }
            }

            Console.WriteLine("@@@");
        }
    }
}
