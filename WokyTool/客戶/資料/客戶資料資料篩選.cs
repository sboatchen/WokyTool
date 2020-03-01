using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.客戶
{
    public class 客戶資料篩選 : 通用可篩選介面<客戶資料>
    {
        public override IEnumerable<客戶資料> 篩選(IEnumerable<客戶資料> 資料列舉_)
        {
            IEnumerable<客戶資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字));

            if (目前列舉_ != 資料列舉_)
                return 目前列舉_.DefaultIfEmpty(客戶資料.空白);
            return 目前列舉_;
        }
    }
}
