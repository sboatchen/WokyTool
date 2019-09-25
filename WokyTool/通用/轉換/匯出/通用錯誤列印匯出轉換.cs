using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WokyTool.通用
{
    public class 通用錯誤列印匯出轉換 : 可寫入介面_EXCEL, 可寫入介面_CSV
    {
        public string 分類 { get; set; }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        public string 分格號 { get { return ","; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        private Dictionary<object, string> _資料書;
        private List<通用匯出欄位方法資料> _欄位方法列;

        public 通用錯誤列印匯出轉換(Dictionary<object, string> 資料書_)
        {
            _資料書 = 資料書_;
            if(_資料書.Count == 0)
                return;

            Type 資料類型_ = _資料書.First().Key.GetType();

            List<Type> 繼承結構列_ = 函式.取得繼承結構列(資料類型_);

            _欄位方法列 = new List<通用匯出欄位方法資料>();
            foreach (PropertyInfo 欄位_ in 資料類型_.GetProperties().OrderByDescending(Value => 繼承結構列_.IndexOf(Value.DeclaringType)))
            {
                可匯出Attribute 屬性_ = 欄位_.GetCustomAttributes(typeof(可匯出Attribute), true).Cast<可匯出Attribute>().DefaultIfEmpty(null).First();
                if (屬性_ == null)
                    continue;

                string 名稱_ = 欄位_.Name;
                if (false == string.IsNullOrEmpty(屬性_.名稱))
                    名稱_ = 屬性_.名稱;

                通用匯出欄位方法資料 方法資料_ = new 通用匯出欄位方法資料
                {
                    名稱 = 名稱_,
                    方法 = 資料類型_.GetProperty(欄位_.Name)
                };

                _欄位方法列.Add(方法資料_);
            }
        }

        public void 寫入(Application App_)
        {
            if (_資料書.Count == 0)
                return;

            int 目前欄數_ = 1;
            foreach (通用匯出欄位方法資料 方法_ in _欄位方法列)
            {
                if (方法_.方法.PropertyType == typeof(string))
                    App_.Cells[1, 目前欄數_].EntireColumn.NumberFormat = "@";

                App_.Cells[1, 目前欄數_++] = 方法_.名稱;
            }

            App_.Cells[1, 目前欄數_].EntireColumn.NumberFormat = "@";
            App_.Cells[1, 目前欄數_++] = "訊息";

            int 目前行數_ = 2;
            foreach (var 資料組_ in _資料書)
            {
                目前欄數_ = 1;
                object 資料_ = 資料組_.Key;

                foreach (通用匯出欄位方法資料 方法_ in _欄位方法列)
                {
                    App_.Cells[目前行數_, 目前欄數_++] = 方法_.方法.GetValue(資料_);
                }

                App_.Cells[目前行數_, 目前欄數_++] = 資料組_.Value;

                目前行數_++;
            }
        }

        public void 寫入(CSVBuilder Builder_)
        {
            if (_資料書.Count == 0)
                return;

            foreach (通用匯出欄位方法資料 方法_ in _欄位方法列)
                Builder_.加入(方法_.名稱);

            Builder_.SB.AppendLine("\"訊息\"");

            foreach (var 資料組_ in _資料書)
            {
                object 資料_ = 資料組_.Key;

                foreach (通用匯出欄位方法資料 方法_ in _欄位方法列)
                {
                    Builder_.加入(方法_.方法.GetValue(資料_));
                }

                Builder_.SB.AppendLine(資料組_.Value);
            }
        }
    }
}
