using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品小類資料篩選 : 通用可篩選介面<物品小類資料>
    {
        public override IEnumerable<物品小類資料> 篩選(IEnumerable<物品小類資料> 資料列舉_)
        {
            IEnumerable<物品小類資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字));

            return 目前列舉_;
        }
    }
}
