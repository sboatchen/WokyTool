using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    public class 一般訂單資料篩選設定 : 可篩選介面<一般訂單資料>
    {
        public DateTime 開始時間 { get; set; }
        public DateTime 結束時間 { get; set; }

        public bool 是否需篩選()
        {
            return true;
        }

        public bool 篩選(一般訂單資料 Data_)
        {
            if (Data_.處理時間 < 開始時間)
                return false;

            if (Data_.處理時間 > 結束時間)
                return false;

            return true;
        }


        public IEnumerable<一般訂單資料> 排序(IEnumerable<一般訂單資料> 資料列舉_)
        {
            throw new NotImplementedException();
        }
    }
}
