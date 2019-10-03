using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.參數
{
    public class 參數資料篩選 : 通用可篩選介面<參數資料>
    {
        public override IEnumerable<參數資料> 篩選(IEnumerable<參數資料> 資料列舉_)
        {
            IEnumerable<參數資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字));

            return 目前列舉_;
        }
    }
}
