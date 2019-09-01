using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.商品
{
    public class 商品小類資料篩選 : 通用可篩選介面<商品小類資料>
    {
        public override IEnumerable<商品小類資料> 篩選(IEnumerable<商品小類資料> 資料列舉_)
        {
            IEnumerable<商品小類資料> 目前列舉_ = 資料列舉_;

            if (null != _文字)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(_文字));

            return 目前列舉_;
        }
    }
}
