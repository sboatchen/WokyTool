using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataImport;
using WokyTool.平台訂單;
using WokyTool.通用;
using WokyTool.月結帳;

//@@ 捨棄
namespace WokyTool.月結帳
{
    class 月結帳總計匯出轉換 : 可序列化_Excel
    {
        public String 標頭 
        {
            get
            {
                return "總計";
            }
        }

        protected List<月結帳總計暫存資料> _資料列 = new List<月結帳總計暫存資料>();

        public 月結帳總計匯出轉換()
        {
            _資料列 = new List<月結帳總計暫存資料>();
        }

        public void 新增(月結帳總計暫存資料 總計資料_)
        {
            _資料列.Add(總計資料_);
        }

        public void 新增(月結帳分頁匯出轉換 月結帳分頁匯出轉換_)
        {
            月結帳總計暫存資料 月結帳總計暫存資料_ = new 月結帳總計暫存資料
            {
                名稱 = 月結帳分頁匯出轉換_.標頭,
                //營業額 = 月結帳分頁匯出轉換_.總營業額(),
                //進貨成本 = 月結帳分頁匯出轉換_.總成本(),
                //利潤 = 月結帳分頁匯出轉換_.總利潤(),
            };

            _資料列.Add(月結帳總計暫存資料_);
        }

        public void 寫入(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "名稱";
            App_.Cells[1, 2] = "營業額";
            App_.Cells[1, 3] = "進貨成本";
            App_.Cells[1, 4] = "利潤";

            int 目前行數_ = 2;
            decimal 總營業額 = 0;
            decimal 總進貨成本 = 0;
            decimal 總利潤 = 0;

            foreach (月結帳總計暫存資料 月結帳總計暫存資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 月結帳總計暫存資料_.名稱;
                App_.Cells[目前行數_, 2] = 月結帳總計暫存資料_.營業額;
                App_.Cells[目前行數_, 3] = 月結帳總計暫存資料_.進貨成本;
                App_.Cells[目前行數_, 4] = 月結帳總計暫存資料_.利潤;

                目前行數_++;
                總營業額 += 月結帳總計暫存資料_.營業額;
                總進貨成本 += 月結帳總計暫存資料_.進貨成本;
                總利潤 += 月結帳總計暫存資料_.利潤;
            }

            App_.Cells[目前行數_, 2] = 總營業額;
            App_.Cells[目前行數_, 3] = 總進貨成本;
            App_.Cells[目前行數_, 4] = 總利潤;
        }
    }
}
