using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 檔案測試視窗 : Form
    {
        public 檔案測試視窗()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void 檔名測試_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                String 路徑_ = openFileDialog1.FileName;
                Console.WriteLine(路徑_);

                String 備份檔名_ = 檔案.取得備份檔名(路徑_);
                Console.WriteLine(備份檔名_);

                String 備份資料夾_ = 檔案.取得備份資料夾(路徑_, new String[]{"測試", "123"});
                Console.WriteLine(備份資料夾_);
            }

            {
                String 路徑_ = "設定/公司.json";
                Console.WriteLine(路徑_);

                String 備份檔名_ = 檔案.取得備份檔名(路徑_);
                Console.WriteLine(備份檔名_);

                String 備份資料夾_ = 檔案.取得備份資料夾(路徑_, new String[]{ "測試", "123" });
                Console.WriteLine(備份資料夾_);
            }

        }
    }
}
