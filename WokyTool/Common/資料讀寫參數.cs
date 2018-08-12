using LINQtoCSV;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.Common
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 資料讀寫參數
    {
        [JsonProperty]
        public String 檔名 = null;
        [JsonProperty]
        public 列舉.檔案格式 檔案格式 = 列舉.檔案格式.無;

        //public static XlFileFormat xls格式 = XlFileFormat.xlWorkbookNormal;
        //public static XlFileFormat xlsx格式 = XlFileFormat.xlOpenXMLWorkbook;

        public virtual bool InitRead()
        {
            if (檔案格式 == 列舉.檔案格式.無)
                return false;

            if (檔名 == null || 檔名.Length == 0)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "All files (*.*)|*.*";

                if (dlg.ShowDialog() != DialogResult.OK)
                    return false;

                檔名 = dlg.FileName;
            }

            return true;
        }

        /*public bool InitWrite()
        {
            if (檔案格式 == 列舉.檔案格式類型.無)
                return false;

            OpenFileDialog dlg = new OpenFileDialog();
            switch()
            dlg.Filter = "All files (*.*)|*.*";

            if (dlg.ShowDialog() != DialogResult.OK)
                return false;

            檔名 = dlg.FileName;

            return true;
        }

        // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = Param_.檔名;
            dlg.DefaultExt = ".csv";                // Default file extension
            dlg.Filter = "csv files (.csv)|*.csv";  // Filter files by extension
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                Log.Warn("未選擇匯出檔案");
                return;
            }

            Param_.檔名 = dlg.FileName;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }*/
    }
}
