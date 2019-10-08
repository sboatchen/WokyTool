using Newtonsoft.Json;
using WokyTool.通用;

namespace WokyTool.物品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品更新資料 : 可更新資料<物品更新資料, 物品資料>
    {
        [可匯入(優先級 = 1, 識別 = true)]
        [JsonProperty]
        public int 編號
        {
            get
            {
                return 修改.編號;
            }
            set
            {
                參考 = 物品資料管理器.獨體.取得(value);
                修改 = 參考.深複製();

                修改.編號 = value;
            }
        }

        [可匯入(優先級 = 2, 識別 = true)]
        [JsonProperty]
        public string 名稱
        {
            get
            {
                return 修改.名稱;
            }
            set
            {
                if (參考 == null)
                {
                    參考 = 物品資料管理器.獨體.取得_名稱(value);
                    修改 = 參考.深複製();
                }

                修改.名稱 = value;
            }
        }

        [可匯入(優先級 = 3, 識別 = true)]
        [JsonProperty]
        public string 縮寫
        {
            get
            {
                return 修改.縮寫;
            }
            set
            {
                if (參考 == null)
                {
                    參考 = 物品資料管理器.獨體.取得_縮寫(value);
                    修改 = 參考.深複製();
                }

                修改.縮寫 = value;
            }
        }

        [可匯入(名稱 = "大類")]
        [JsonProperty]
        public string 大類識別
        {
            get
            {
                return _大類識別;
            }
            set
            {
                _大類識別 = value;
                修改.大類 = 物品大類資料管理器.獨體.取得(value);
            }
        }

        [可匯入(名稱 = "小類")]
        [JsonProperty]
        public string 小類識別
        {
            get
            {
                return _小類識別;
            }
            set
            {
                _小類識別 = value;
                修改.小類 = 物品小類資料管理器.獨體.取得(value);
            }
        }

        [可匯入(名稱 = "品牌")]
        [JsonProperty]
        public string 品牌識別
        {
            get
            {
                return _品牌識別;
            }
            set
            {
                _品牌識別 = value;
                修改.品牌 = 物品品牌資料管理器.獨體.取得(value);
            }
        }

        [可匯入]
        [JsonProperty]
        public string 國際條碼
        {
            get
            {
                return 修改.國際條碼;
            }
            set
            {
                修改.國際條碼 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public string 類別
        {
            get
            {
                return 修改.類別;
            }
            set
            {
                修改.類別 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public string 顏色
        {
            get
            {
                return 修改.顏色;
            }
            set
            {
                修改.顏色 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public int 體積
        {
            get
            {
                return 修改.體積;
            }
            set
            {
                修改.體積 = value;
            }
        }


        [可匯入]
        [JsonProperty]
        public int 庫存
        {
            get
            {
                return 修改.庫存;
            }
            set
            {
                修改.庫存 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public decimal 庫存總成本
        {
            get
            {
                return 修改.庫存總成本; ;
            }
            set
            {
                修改.庫存總成本 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public decimal 最後進貨成本
        {
            get
            {
                return 修改.最後進貨成本;
            }
            set
            {
                修改.最後進貨成本 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public string 成本備註
        {
            get
            {
                return 修改.成本備註;
            }
            set
            {
                修改.成本備註 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public string 儲位
        {
            get
            {
                return 修改.儲位;
            }
            set
            {
                修改.儲位 = value;
            }
        }

        /********************************/

        private string _大類識別;
        private string _小類識別;
        private string _品牌識別;

        public 物品大類資料 大類
        {
            get { return 修改.大類; }
            set
            {
                修改.大類 = value;
                _大類識別 = value.名稱;
            }
        }

        public 物品小類資料 小類
        {
            get { return 修改.小類; }
            set
            {
                修改.小類 = value;
                _小類識別 = value.名稱;
            }
        }

        public 物品品牌資料 品牌
        {
            get { return 修改.品牌; }
            set
            {
                修改.品牌 = value;
                _品牌識別 = value.名稱;
            }
        }

        public decimal 成本
        {
            get
            {
                return 修改.成本;
            }
        }

        public int 保留 { get { return 參考.保留; } }

        public string 參考名稱 { get { return 參考.名稱; } }
        public string 參考縮寫 { get { return 參考.縮寫; } }

        public 物品大類資料 參考大類 { get { return 參考.大類; } }
        public 物品小類資料 參考小類 { get { return 參考.小類; } }
        public 物品品牌資料 參考品牌 { get { return 參考.品牌; } }

        public string 參考國際條碼 { get { return 參考.國際條碼; } }

        public string 參考類別 { get { return 參考.類別; } }
        public string 參考顏色 { get { return 參考.顏色; } }

        public int 參考體積 { get { return 參考.體積; } }
        public int 參考庫存 { get { return 參考.庫存; } }
        public int 參考保留 { get { return 參考.保留; } }
        public decimal 參考庫存總成本 { get { return 參考.庫存總成本; } }
        public decimal 參考最後進貨成本 { get { return 參考.最後進貨成本; } }
        public decimal 參考成本 { get { return 參考.成本; } }
        public string 參考成本備註 { get { return 參考.成本備註; } }
        public string 參考儲位 { get { return 參考.儲位; } }
    }
}
