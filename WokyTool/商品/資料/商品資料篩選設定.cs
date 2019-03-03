using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.商品
{
    public class 商品資料篩選設定 : 可篩選介面<商品資料>
    {
        public 商品大類資料 大類 { get; set; }
        public 商品小類資料 小類 { get; set; }

        public 公司資料 公司 { get; set; }
        public 客戶資料 客戶 { get; set; }

        public 物品資料 物品 { get; set; }

        public string 品號 { get; set; }
        public string 名稱 { get; set; }

        public Boolean 是否需篩選()
        {
            return
                大類 != null ||
                小類 != null ||
                公司 != null ||
                客戶 != null ||
                物品 != null ||
                string.IsNullOrEmpty(品號) == false ||
                string.IsNullOrEmpty(名稱) == false;
        }

        public Boolean 篩選(商品資料 Data_)
        {
            if (大類 != null && 大類 != Data_.大類)
                return false;

            if (小類 != null && 小類 != Data_.小類)
                return false;

            if (公司 != null && 公司 != Data_.公司)
                return false;

            if (客戶 != null && 客戶 != Data_.客戶)
                return false;

            if (物品 != null)
            {
                if (Data_.組成 == null || Data_.組成.Where(Value => Value.物品 == 物品).First() == null)
                    return false;
            }

            if (string.IsNullOrEmpty(品號) == false)
            {
                if (string.IsNullOrEmpty(Data_.品號) || Data_.品號.Contains(品號) == false)
                    return false;
            }

            if (string.IsNullOrEmpty(名稱) == false)
            {
                if (string.IsNullOrEmpty(Data_.名稱) || Data_.名稱.Contains(名稱) == false)
                    return false;
            }

            return true;
        }
    }
}
