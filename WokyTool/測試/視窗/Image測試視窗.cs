using IronOcr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            var Ocr = new AutoOcr();

            {
                Rectangle 範圍_ = new Rectangle(435, 200, 265, 50);
                var Result = Ocr.Read(OFD_.FileName, 範圍_);
                Console.WriteLine(Result.Text);
            }
            {
                Rectangle 範圍_ = new Rectangle(1685, 200, 265, 50);
                var Result = Ocr.Read(OFD_.FileName, 範圍_);
                Console.WriteLine(Result.Text);
            }
            {
                Rectangle 範圍_ = new Rectangle(435, 1940, 265, 50);
                var Result = Ocr.Read(OFD_.FileName, 範圍_);
                Console.WriteLine(Result.Text);
            }
            {
                Rectangle 範圍_ = new Rectangle(1685, 1940, 265, 50);
                var Result = Ocr.Read(OFD_.FileName, 範圍_);
                Console.WriteLine(Result.Text);
            }
            Console.WriteLine("@@@");
        }
    }
}
