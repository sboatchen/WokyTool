using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WokyTool.通用
{
    public class 通用標頭匯出轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get; set; }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        public Type 資料類型 { get; protected set; }

        public 通用標頭匯出轉換(Type 資料類型_)
        {
            資料類型 = 資料類型_;
        }

        public void 寫入(Application App_)
        {
            List<Type> 繼承結構列_ = 函式.取得繼承結構列(資料類型);

            int 目前欄數_ = 1;
            foreach (PropertyInfo 欄位_ in 資料類型.GetProperties().OrderByDescending(Value => 繼承結構列_.IndexOf(Value.DeclaringType)))
            {
                可匯入Attribute 屬性_ = 欄位_.GetCustomAttributes(typeof(可匯入Attribute), true).Cast<可匯入Attribute>().DefaultIfEmpty(null).First();
                if (屬性_ == null)
                    continue;

                if (string.IsNullOrEmpty(屬性_.名稱))
                    App_.Cells[1, 目前欄數_] = 欄位_.Name;
                else
                    App_.Cells[1, 目前欄數_] = 屬性_.名稱;

                if (屬性_.識別)
                    App_.Cells[2, 目前欄數_] = "識別:" + 屬性_.優先級;

                if (false == string.IsNullOrEmpty(屬性_.說明))
                    App_.Cells[3, 目前欄數_] = 屬性_.說明;

                

                目前欄數_++;
            }
        }
    }
}
