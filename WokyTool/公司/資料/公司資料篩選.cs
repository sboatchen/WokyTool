using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.公司
{
    public class 公司資料篩選 : 通用可篩選介面<公司資料>
    {
        public override IEnumerable<公司資料> 篩選(IEnumerable<公司資料> 資料列舉_)
        {
            IEnumerable<公司資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字));

            return 目前列舉_;
        }
    }
}
