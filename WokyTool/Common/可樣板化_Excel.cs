using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 可樣板化_Excel
    {
        // 取得樣板位置
        string GetTemplate();

        // 設定資料
        void SetData(Application App_);
    }
}
