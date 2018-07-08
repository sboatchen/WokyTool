using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品資料篩選設定 : 可篩選介面<物品資料>
    {
        public 物品大類資料 大類 { get; set; }
        public 物品小類資料 小類 { get; set; }
        public 物品品牌資料 品牌 { get; set; }
        
        public string 條碼 { get; set; }
        public string 原廠編號 { get; set; }
        public string 代理編號 { get; set; }
        
        public string 名稱 { get; set; }
        public string 縮寫 { get; set; }

        
        //public int 體積 { get; set; }
        
        //public string 顏色 { get; set; }

        
        //public int 內庫數量 { get; set; }
        
        //public int 外庫數量 { get; set; }

        //public int 庫存總量 { get { return 內庫數量 + 外庫數量; } }

        
        //public decimal 庫存總成本 { get; set; }
        
        //public decimal 最後進貨成本 { get; set; }
        
        //public string 成本備註 { get; set; }

        //public decimal 成本  { get; set; }

        public Boolean 是否需篩選()
        {
            return
                大類 != null ||
                小類 != null ||
                品牌 != null ||
                string.IsNullOrEmpty(條碼) == false ||
                string.IsNullOrEmpty(原廠編號) == false ||
                string.IsNullOrEmpty(代理編號) == false ||
                string.IsNullOrEmpty(名稱) == false ||
                string.IsNullOrEmpty(縮寫) == false;
        }

        public Boolean 篩選(物品資料 Data_)
        {
            if (大類 != null && 大類 != Data_.大類)
                return false;

            if (小類 != null && 小類 != Data_.小類)
                return false;

            if (品牌 != null && 品牌 != Data_.品牌)
                return false;

            if (string.IsNullOrEmpty(條碼) == false)
            {
                if(string.IsNullOrEmpty(Data_.條碼) || Data_.條碼.Contains(條碼) == false)
                    return false;
            }

            if (string.IsNullOrEmpty(原廠編號) == false)
            {
                if (string.IsNullOrEmpty(Data_.原廠編號) || Data_.原廠編號.Contains(原廠編號) == false)
                    return false;
            }

            if (string.IsNullOrEmpty(代理編號) == false)
            {
                if (string.IsNullOrEmpty(Data_.代理編號) || Data_.代理編號.Contains(代理編號) == false)
                    return false;
            }

            if (string.IsNullOrEmpty(名稱) == false)
            {
                if (string.IsNullOrEmpty(Data_.名稱) || Data_.名稱.Contains(名稱) == false)
                    return false;
            }

            if (string.IsNullOrEmpty(縮寫) == false)
            {
                if (string.IsNullOrEmpty(Data_.縮寫) || Data_.縮寫.Contains(縮寫) == false)
                    return false;
            }

            return true;
        }
    }
}
