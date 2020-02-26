using Newtonsoft.Json;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.盤點
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 盤點更新資料 : 可更新資料<盤點更新資料, 盤點資料>
    {
        [可匯出]
        [JsonProperty]
        public string 單品識別
        {
            get { return _單品識別; }
            set { 
                _單品識別 = value;
                更新參考(盤點資料管理器.獨體.取得(value));
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

        private string _單品識別;

        public 單品資料 單品
        {
            get { return 修改.單品; }
            set
            {
                更新參考(盤點資料管理器.獨體.取得(value.編號));
            }
        }

        public string 單品名稱 { get { return 修改.單品.名稱; } }

        public int 參考大料架庫存 { get { return 參考.大料架庫存; } }
        public int 參考小料架庫存 { get { return 參考.小料架庫存; } }
        public int 參考萬通庫存 { get { return 參考.萬通庫存; } }

        public string 參考備註 { get { return 參考.備註; } }

        public 單品資料 參考單品 { get { return 參考.單品; } }

        /********************************/

        protected void 更新參考(盤點資料 新參考_)
        {
            if (參考 == null)
            {
                參考 = 新參考_;
                修改 = 參考.深複製();
            }
            else
            {
                修改.單品 = 新參考_.單品;
                _單品識別 = 新參考_.單品.名稱;

                if (修改.大料架庫存 == 參考.大料架庫存)
                    修改.大料架庫存 = 新參考_.大料架庫存;

                if (修改.小料架庫存 == 參考.小料架庫存)
                    修改.小料架庫存 = 新參考_.小料架庫存;

                if (修改.萬通庫存 == 參考.萬通庫存)
                    修改.萬通庫存 = 新參考_.萬通庫存;

                if (修改.備註 == 參考.備註)
                    修改.備註 = 新參考_.備註;

                參考 = 新參考_;
                初始化();
            }
        }
    }
}

