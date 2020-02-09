using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public partial class 檔案
    {
        public static bool 詢問並寫入(string 預設檔名_, 可寫入介面_CSV 轉換_)
        {
            // 開啟存檔位置
            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.FileName = 預設檔名_;
            SFD_.DefaultExt = ".csv";
            SFD_.Filter = "csv files (.csv)|*.csv";
            if (SFD_.ShowDialog() != DialogResult.OK)
                return false;

            // 寫入資料
            CSVBuilder Builder_ = new CSVBuilder(轉換_.分格號);
            轉換_.寫入(Builder_);

            return 寫入(SFD_.FileName, Builder_.ToString(), 轉換_.密碼, 轉換_.編碼);
        }

        public static bool 詢問並寫入(string 預設檔名_, IEnumerable<可寫入介面_CSV> 轉換列_)
        {
            // 開啟存檔位置
            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.FileName = 預設檔名_;
            SFD_.DefaultExt = ".csv";
            SFD_.Filter = "csv files (.csv)|*.csv";
            if (SFD_.ShowDialog() != DialogResult.OK)
                return false;

            // 寫入資料
            CSVBuilder Builder_ = new CSVBuilder();
            int index = 0;
            foreach (可寫入介面_CSV 轉換_ in 轉換列_)
            {
                Builder_.重置(轉換_.分格號);
                轉換_.寫入(Builder_);

                String 路徑_;
                if (String.IsNullOrEmpty(轉換_.分類))
                    路徑_ = 增加檔名後綴(SFD_.FileName, index.ToString());
                else
                    路徑_ = 增加檔名後綴(SFD_.FileName, 轉換_.分類);

                bool 結果_ = 寫入(路徑_, Builder_.ToString(), 轉換_.密碼, 轉換_.編碼);
                if (結果_ == false)
                    return false;

                index++;
            }

            return true;
        }

        public static List<T> 詢問並讀出<T>(可讀出介面_CSV<T> 轉換_)
        {
            // 開啟存檔位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "csv files (.csv)|*.csv";
            if (OFD_.ShowDialog() != DialogResult.OK)
                return null;

            // 備份
            if (false == 備份(OFD_.FileName, 轉換_.GetType().Name, "檔案讀出"))
                return null;

            轉換_.讀出檔名(OFD_.FileName);

            string 內容_ = 讀出(OFD_.FileName, 轉換_.密碼, 轉換_.編碼);
            if (String.IsNullOrEmpty(內容_))
                return null;

            return 轉換_.讀出(內容_).ToList();
        }

        private static List<T> 詢問並讀出_CSV<T>(string 路徑_) where T : 可初始化介面
        {
            訊息管理器.獨體.錯誤("尚未實作"); //@@
            return null;
        }
    }
}
