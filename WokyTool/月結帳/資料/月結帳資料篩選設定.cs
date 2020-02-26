using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.公司;
using WokyTool.單品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳資料篩選設定 : 可篩選介面<月結帳資料>
    {
        public 公司資料 公司 { get; set; }
        public 客戶資料 客戶 { get; set; }

        public bool 是否需篩選()
        {
            return
                公司 != null ||
                客戶 != null;
        }

        public bool 篩選(月結帳資料 Data_)
        {
            if (公司 != null && 公司 != Data_.公司)
                return false;

            if (客戶 != null && 客戶 != Data_.客戶)
                return false;

            return true;
        }
    }
}
