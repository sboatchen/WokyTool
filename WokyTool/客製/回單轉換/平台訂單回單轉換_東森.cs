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

namespace WokyTool.客製
{
    class 平台訂單回單轉換_東森 : 可寫入介面_CSV
    {
        public string 分類 { get { return null; } }

        public string 分格號 { get { return ","; } }

        public String 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列;

        public 平台訂單回單轉換_東森(IEnumerable<平台訂單新增資料> 資料列_)
        {
            _資料列 = 資料列_;
        }

        public void 寫入(CSVBuilder Builder_)
        {
            平台訂單新增資料 平台訂單新增資料_ = _資料列.First();
            if (平台訂單新增資料_ == null)
                return;

            Builder_.加入標頭(平台訂單新增資料_.標頭);

            foreach (平台訂單新增資料 資料_ in _資料列)
            {
                string[] 輸出資料_ = 資料_.內容.深複製();

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        輸出資料_[18] =  字串.新竹物流;
                        break;
                    case 列舉.配送公司.宅配通:
                        輸出資料_[18] =  字串.宅配通;
                        break;
                    default:
                        訊息管理器.獨體.錯誤("平台訂單回單轉換_東森 不支援配送公司 " + 資料_.配送公司.ToString());
                        break;
                }

                輸出資料_[19] = 資料_.配送單號;

                Builder_.加入(輸出資料_);
            }
        }
    }
}
