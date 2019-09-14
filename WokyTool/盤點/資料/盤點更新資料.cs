using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.客製;
using WokyTool.通用;

namespace WokyTool.盤點
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 盤點更新資料 : 可更新資料<盤點更新資料, 盤點資料>
    {
        [可匯出]
        [JsonProperty]
        public string 物品識別
        {
            get { return _物品識別; }
            set { 
                _物品識別 = value;

                參考 = 盤點資料管理器.獨體.取得(value);
                修改 = 參考.深複製();
            }
        }

        [可匯出]
        [JsonProperty]
        public int 大料架庫存
        {
            get { return 修改.大料架庫存; }
            set { 修改.大料架庫存 = value; }
        }

        [可匯出]
        [JsonProperty]
        public int 小料架庫存
        {
            get { return 修改.小料架庫存; }
            set { 修改.小料架庫存 = value; }
        }

        [可匯出]
        [JsonProperty]
        public int 萬通庫存
        {
            get { return 修改.萬通庫存; }
            set { 修改.萬通庫存 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 備註
        {
            get { return 修改.備註; }
            set { 修改.備註 = value; }
        }

        /********************************/

        private string _物品識別;

        public 物品資料 物品
        {
            get { return 修改.物品; }
            set
            {
                盤點資料 舊參考_ = 參考;

                參考 = 盤點資料管理器.獨體.取得(物品.編號);
                修改.物品 = value;
                _物品識別 = value.名稱;

                if (修改.大料架庫存 == 舊參考_.大料架庫存)
                    修改.大料架庫存 = 參考.大料架庫存;
                if (修改.小料架庫存 == 舊參考_.小料架庫存)
                    修改.小料架庫存 = 參考.小料架庫存;
                if (修改.萬通庫存 == 舊參考_.萬通庫存)
                    修改.萬通庫存 = 參考.萬通庫存;
                if (修改.備註 == 舊參考_.備註)
                    修改.備註 = 參考.備註;

                初始化();
            }
        }

        public string 物品名稱 { get { return 修改.物品.名稱; } }

        public int 參考大料架庫存 { get { return 參考.大料架庫存; } }
        public int 參考小料架庫存 { get { return 參考.小料架庫存; } }
        public int 參考萬通庫存 { get { return 參考.萬通庫存; } }

        public string 參考備註 { get { return 參考.備註; } }

        public 物品資料 參考物品 { get { return 參考.物品; } }
    }
}

