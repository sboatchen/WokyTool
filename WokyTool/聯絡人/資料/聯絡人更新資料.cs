using Newtonsoft.Json;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.聯絡人
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 聯絡人更新資料 : 可更新資料<聯絡人更新資料, 聯絡人資料>
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
                參考 = 聯絡人資料管理器.獨體.取得(value);
                修改 = 參考.深複製();

                修改.編號 = value;
            }
        }

        [可匯入(優先級 = 2, 識別 = true)]
        [JsonProperty]
        public string 姓名
        {
            get
            {
                return 修改.姓名;
            }
            set
            {
                if (參考 == null)
                {
                    參考 = 聯絡人資料管理器.獨體.取得(value);
                    修改 = 參考.深複製();
                }

                修改.姓名 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public string 電話
        {
            get
            {
                return 修改.電話;
            }
            set
            {
                修改.電話 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public string 手機
        {
            get
            {
                return 修改.手機;
            }
            set
            {
                修改.手機 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public string 地址
        {
            get
            {
                return 修改.地址;
            }
            set
            {
                修改.地址 = value;
            }
        }

        [可匯入(名稱 = "客戶")]
        [JsonProperty]
        public string 客戶識別
        {
            get
            {
                return _客戶識別;
            }
            set
            {
                _客戶識別 = value;
                修改.客戶 = 客戶資料管理器.獨體.取得(value);
            }
        }

        [可匯入(名稱 = "子客戶")]
        [JsonProperty]
        public string 子客戶識別
        {
            get
            {
                return _子客戶識別;
            }
            set
            {
                _子客戶識別 = value;
                修改.子客戶 = 子客戶資料管理器.獨體.取得(value);
            }
        }

        /********************************/

        private string _客戶識別;
        private string _子客戶識別;

        public 客戶資料 客戶 
        {
            get { return 修改.客戶; }
            set 
            { 
                修改.客戶 = value;
                _客戶識別 = value.名稱;
            }
        }

        public 子客戶資料 子客戶
        {
            get { return 修改.子客戶; }
            set 
            { 
                修改.子客戶 = value;
                _子客戶識別 = value.名稱;
            }
        }

        public string 參考姓名 { get { return 參考.姓名; } }
        public string 參考電話 { get { return 參考.電話; } }
        public string 參考手機 { get { return 參考.手機; } }
        public string 參考地址 { get { return 參考.地址; } }

        public 客戶資料 參考客戶 { get { return 參考.客戶; } }
        public 子客戶資料 參考子客戶 { get { return 參考.子客戶; } }

        /********************************/

        public static readonly 聯絡人更新資料 空白 = new 聯絡人更新資料
        {
            修改 = 聯絡人資料.空白,
            參考 = 聯絡人資料.空白,
        };
    }
}