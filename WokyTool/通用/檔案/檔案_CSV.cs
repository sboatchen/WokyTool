using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace WokyTool.通用
{
    public partial class 檔案
    {
        public static void 詢問並寫入(string 預設檔名_, 可寫入_CSV 資料_)
        {
            // 開啟存檔位置
            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.FileName = 預設檔名_;
            SFD_.DefaultExt = ".csv";
            SFD_.Filter = "csv files (.csv)|*.csv";
            if (SFD_.ShowDialog() != DialogResult.OK)
                return;

            // 寫入資料
            StringBuilder SB_ = new StringBuilder();
            資料_.寫入(SB_);

            寫入(SFD_.FileName, SB_.ToString(), 資料_.密碼);
        }

        public static void 詢問並寫入(string 預設檔名_, List<可寫入_CSV> 資料列_)
        {
            // 開啟存檔位置
            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.FileName = 預設檔名_;
            SFD_.DefaultExt = ".csv";
            SFD_.Filter = "csv files (.csv)|*.csv";
            if (SFD_.ShowDialog() != DialogResult.OK)
                return;

            // 寫入資料
            StringBuilder SB_ = new StringBuilder();
            int index = 0;
            foreach (可寫入_CSV 資料_ in 資料列_)
            {
                SB_.Clear();
                資料_.寫入(SB_);

                String 路徑_;
                if (String.IsNullOrEmpty(資料_.分類))
                    路徑_ = 增加檔名後綴(SFD_.FileName, index.ToString());
                else
                    路徑_ = 增加檔名後綴(SFD_.FileName, 資料_.分類);

                寫入(路徑_, SB_.ToString(), 資料_.密碼);
                index++;
            }
        }

        public static List<T> 詢問並讀出<T>(可讀出_CSV<T> 轉換_)
        {
            // 開啟存檔位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "csv files (.csv)|*.csv";
            if (OFD_.ShowDialog() != DialogResult.OK)
                return null;

            string 內容_ = 讀出(OFD_.FileName, 轉換_.密碼);

            return 轉換_.讀出(內容_);
        }
    }
}
