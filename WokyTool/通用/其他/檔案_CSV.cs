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
        public static void 寫入(string 預設檔名_, 可寫入_CSV 資料_)
        {
            // 開啟存檔位置
            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.FileName = 預設檔名_;
            SFD_.DefaultExt = ".csv";
            SFD_.Filter = "csv files (.csv)|*.csv";
            if (SFD_.ShowDialog() != DialogResult.OK)
                return;

            // 寫入資料
            try
            {
                StringBuilder SB_ = new StringBuilder();
                資料_.寫入(SB_);

                File.WriteAllText(SFD_.FileName, SB_.ToString(), Encoding.UTF8);

                訊息管理器.獨體.Debug("寫入檔案 " + SFD_.FileName);
            }
            catch (Exception e)
            {
                訊息管理器.獨體.Error("匯出失敗 " + 預設檔名_, e);
            }
        }

        public static void 寫入(string 預設檔名_, List<可寫入_CSV> 資料列_)
        {
            // 開啟存檔位置
            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.FileName = 預設檔名_;
            SFD_.DefaultExt = ".csv";
            SFD_.Filter = "csv files (.csv)|*.csv";
            if (SFD_.ShowDialog() != DialogResult.OK)
                return;

            // 寫入資料
            try
            {
                StringBuilder SB_ = new StringBuilder();

                int index = 0;
                foreach (可寫入_CSV 資料_ in 資料列_)
                {
                    SB_.Clear();
                    資料_.寫入(SB_);

                    String 路徑_;
                    if(String.IsNullOrEmpty(資料_.分類))
                        路徑_ = 增加檔名後綴(SFD_.FileName, index.ToString());
                    else
                        路徑_ = 增加檔名後綴(SFD_.FileName, 資料_.分類);

                    File.WriteAllText(路徑_, SB_.ToString(), Encoding.UTF8);

                    訊息管理器.獨體.Debug("寫入檔案 " + 路徑_);

                    index++;
                }
            }
            catch (Exception e)
            {
                訊息管理器.獨體.Error("匯出失敗 " + 預設檔名_, e);
            }
        }
    }
}
