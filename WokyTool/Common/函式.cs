using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WokyTool.通用;
using Excel = Microsoft.Office.Interop.Excel;

namespace WokyTool.Common
{
    public static class 舊函式
    {
        // 拷貝檔案
        public static void GetFile(String FileName_, String Resource_)
        {
            // 取得副檔名
            int Index_ = Resource_.LastIndexOf(".");
            string Type_ = Resource_.Substring(Index_, Resource_.Length - Index_);

            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = FileName_;
            dlg.DefaultExt = Type_;                // Default file extension
            //dlg.Filter = "csv files (.csv)|*.csv";  // Filter files by extension
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;

            // 寫入資料
            System.IO.File.Copy(Resource_, dlg.FileName);
        }
    }
}
