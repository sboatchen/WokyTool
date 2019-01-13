using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳支出匯出轉換 : 可序列化_Excel
    {
        protected IEnumerable<月結帳支出資料> _資料列;

        public String 標頭 
        { 
            get
            {
                return "支出";
            }
        }

        public String 樣板 { get { return null; } }

        public 月結帳支出匯出轉換(IEnumerable<月結帳支出資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "傳票號碼";
            App_.Cells[1, 2] = "廠商名稱";
            App_.Cells[1, 3] = "費用";

            int 目前行數_ = 2;
            foreach (月結帳支出資料 月結帳支出資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 月結帳支出資料_.傳票號碼;
                App_.Cells[目前行數_, 2] = 月結帳支出資料_.廠商.名稱;
                App_.Cells[目前行數_, 3] = 月結帳支出資料_.費用;

                目前行數_++;
            }
        }
    }
}
