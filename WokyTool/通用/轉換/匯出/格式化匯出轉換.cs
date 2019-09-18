using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WokyTool.通用
{
    public class 格式化匯出轉換 : 可寫入介面_EXCEL, 可寫入介面_CSV
    {
        public string 分類 { get; set; }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        public string 分格號 { get { return ","; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        private IEnumerable<object> _資料列舉;
        private List<通用匯出欄位方法資料> _欄位方法列;

        public 格式化匯出轉換(string 分類_, IEnumerable<object> 資料列舉_, List<通用匯出欄位方法資料> 欄位方法列_)
        {
            分類 = 分類_;
            _資料列舉 = 資料列舉_;
            _欄位方法列 = 欄位方法列_;
        }

        public void 寫入(Application App_)
        {
            int 目前欄數_ = 1;
            foreach (通用匯出欄位方法資料 方法_ in _欄位方法列)
            {
                if(方法_.方法.PropertyType == typeof(string))
                    App_.Cells[1, 目前欄數_].EntireColumn.NumberFormat = "@";

                App_.Cells[1, 目前欄數_++] = 方法_.名稱;
            }

            int 目前行數_ = 2;
            foreach (object 資料_ in _資料列舉)
            {
                目前欄數_ = 1;
                foreach (通用匯出欄位方法資料 方法_ in _欄位方法列)
                {
                    App_.Cells[目前行數_, 目前欄數_++] = 方法_.方法.GetValue(資料_);
                }

                目前行數_++;
            }
        }

        public void 寫入(CSVBuilder Builder_)
        {
            Builder_.加入標頭(_欄位方法列.Select(Value => Value.名稱).ToArray());

            foreach (object 資料_ in _資料列舉)
            {
                foreach (通用匯出欄位方法資料 方法_ in _欄位方法列)
                {
                    Builder_.加入(方法_.方法.GetValue(資料_));
                }

                Builder_.SB.AppendLine();
            }
        }
    }
}
