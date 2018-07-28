using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 資料儲存管理器 : 可儲存介面
    {
        private Dictionary<列舉.編碼類型, 可儲存介面> 資料管理器Map { get; set; }

        // 獨體
        private static readonly 資料儲存管理器 _獨體 = new 資料儲存管理器();
        public static 資料儲存管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        private 資料儲存管理器()
        {
            資料管理器Map = new Dictionary<列舉.編碼類型, 可儲存介面>();
        }

        public void 註冊(列舉.編碼類型 類型_, 可儲存介面 資料_)
        {
            if (資料管理器Map.ContainsKey(類型_))
                throw new Exception("資料儲存管理器:已註冊此類型 " + 類型_);

            資料管理器Map.Add(類型_, 資料_);
        }

        public void 儲存()
        {
            foreach (var Item_ in 資料管理器Map.Values)
                Item_.儲存();
        }
    }
}
