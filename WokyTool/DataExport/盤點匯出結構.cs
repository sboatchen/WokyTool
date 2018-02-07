using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataImport;
using WokyTool.Data;

namespace WokyTool.DataExport
{
    class 盤點匯出結構 : 可格式化_Csv
    {
        protected 物品資料 _Data;

        //條碼號, 商品描述, 0

        public 盤點匯出結構(物品資料 Data_)
        {
            _Data = Data_;
        }

        [CsvColumn(Name = "條碼號", FieldIndex = 1)]
        public string 條碼號
        {
            get
            {
                return String.Format("{0:0000000000000}", _Data.條碼);
            }
        }

        [CsvColumn(Name = "商品描述", FieldIndex = 2)]
        public string 商品描述
        {
            get
            {
                return _Data.縮寫;
            }
        }

        [CsvColumn(FieldIndex = 3)]
        public int 類型
        {
            get
            {
                return 0;
            }
        }
    }
}
