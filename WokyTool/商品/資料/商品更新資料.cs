using Newtonsoft.Json;
using System.Collections.Generic;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.商品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 商品更新資料 : 可更新資料<商品更新資料, 商品資料>
    {
        [可匯出]
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
                參考 = 商品資料管理器.獨體.取得(value);
                修改 = 參考.深複製();

                修改.編號 = value;
            }
        }

        [可匯出(名稱 = "公司")]
        [可匯入(優先級 = 2, 識別 = true, 名稱 = "公司")]
        [JsonProperty]
        public string 公司識別
        {
            get
            {
                return _公司識別;
            }
            set
            {
                _公司識別 = value;

                if (參考 != null)
                    修改.公司 = 公司資料管理器.獨體.取得(value);
            }
        }

        [可匯出(名稱 = "客戶")]
        [可匯入(優先級 = 3, 名稱 = "客戶", 說明 = "必填")]
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

                if (參考 != null)
                    修改.客戶 = 客戶資料管理器.獨體.取得(value);
            }
        }

        [可匯出]
        [可匯入(優先級 = 4, 識別 = true)]
        [JsonProperty]
        public string 品號
        {
            get
            {
                return 修改.品號;
            }
            set
            {
                if (參考 == null)
                {
                    if (_公司識別 != null)
                    {
                        客戶資料 客戶_ = 客戶資料管理器.獨體.取得(_客戶識別);
                        公司資料 公司_ = 公司資料管理器.獨體.取得(_公司識別);

                        參考 = 商品資料管理器.獨體.取得(公司_.編號, 客戶_.編號, value);
                    }
                    else
                    {
                        客戶資料 客戶_ = 客戶資料管理器.獨體.取得(_客戶識別);

                        參考 = 商品資料管理器.獨體.取得(客戶_.編號, value);
                    }

                    修改 = 參考.深複製();
                }

                修改.品號 = value;
            }
        }

        [可匯出]
        [可匯入(優先級 = 5, 識別 = true)]
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
                    if(_公司識別 != null)
                    {
                        客戶資料 客戶_ = 客戶資料管理器.獨體.取得(_客戶識別);
                        公司資料 公司_ = 公司資料管理器.獨體.取得(_公司識別);

                        參考 = 商品資料管理器.獨體.取得_名稱(公司_.編號, 客戶_.編號, value);
                    }
                    else
                    {
                        客戶資料 客戶_ = 客戶資料管理器.獨體.取得(_客戶識別);

                        參考 = 商品資料管理器.獨體.取得_名稱(客戶_.編號, value);
                    }

                    修改 = 參考.深複製();
                }

                修改.名稱 = value;
            }
        }

        [可匯出(名稱 = "大類")]
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
                修改.大類 = 商品大類資料管理器.獨體.取得(value);
            }
        }

        [可匯出(名稱 = "小類")]
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
                修改.小類 = 商品小類資料管理器.獨體.取得(value);
            }
        }

        [可匯出]
        [可匯入]
        [JsonProperty]
        public decimal 進價
        {
            get
            {
                return 修改.進價;
            }
            set
            {
                修改.進價 = value;
            }
        }

        [可匯出]
        [可匯入]
        [JsonProperty]
        public decimal 售價
        {
            get
            {
                return 修改.售價;
            }
            set
            {
                修改.售價 = value;
            }
        }

        [可匯出]
        [可匯入]
        [JsonProperty]
        public int 寄庫數量
        {
            get
            {
                return 修改.寄庫數量;
            }
            set
            {
                修改.寄庫數量 = value;
            }
        }

        [可匯出(名稱 = "組成")]
        [可匯入(名稱 = "組成")]
        [JsonProperty]
        public string 組成字串識別
        {
            get
            {
                return _組成字串識別;
            }
            set
            {
                _組成字串識別 = value;
                if (參考組成字串.Equals(_組成字串識別) == false)
                {
                    修改.組成 = 物品合併資料.共用.解構(_組成字串識別);
                    修改.更新組成();
                }
            }
        }

        /********************************/

        private string _公司識別;
        private string _客戶識別;

        private string _大類識別;
        private string _小類識別;

        private string _組成字串識別;

        public 公司資料 公司
        {
            get { return 修改.公司; }
            set
            {
                修改.公司 = value;
                _公司識別 = value.名稱;
            }
        }

        public 客戶資料 客戶
        {
            get { return 修改.客戶; }
            set
            {
                修改.客戶 = value;
                _客戶識別 = value.名稱;
            }
        }

        public 商品大類資料 大類
        {
            get { return 修改.大類; }
            set
            {
                修改.大類 = value;
                _大類識別 = value.名稱;
            }
        }

        public 商品小類資料 小類
        {
            get { return 修改.小類; }
            set
            {
                修改.小類 = value;
                _小類識別 = value.名稱;
            }
        }

        public List<商品組成資料> 組成
        {
            get { return 修改.組成; }
            set { 修改.組成 = value; }
        }

        public 品牌資料 品牌 { get {return 修改.品牌; } }
        public string 品牌名稱 { get { return 修改.品牌.名稱; } }

        public decimal 成本 { get { return 修改.成本; } }
        public decimal 利潤 { get { return 修改.利潤; } }

        public string 組成字串 { get { return 修改.組成字串; } }

        public string 參考名稱 { get { return 參考.名稱; } }
        public string 參考品號 { get { return 參考.品號; } }

        public 商品大類資料 參考大類 { get { return 參考.大類; } }
        public 商品小類資料 參考小類 { get { return 參考.小類; } }
        public 品牌資料 參考品牌 { get { return 參考.品牌; } }

        public 公司資料 參考公司 { get { return 參考.公司; } }
        public 客戶資料 參考客戶 { get { return 參考.客戶; } }

        public decimal 參考進價 { get { return 參考.進價; } }
        public decimal 參考售價 { get { return 參考.售價; } }
        public int 參考寄庫數量 { get { return 參考.寄庫數量; } }

        public decimal 參考成本 { get { return 參考.成本; } }
        public decimal 參考利潤 { get { return 參考.利潤; } }

        public List<商品組成資料> 參考組成 { get { return 參考.組成; } }
        public string 參考組成字串 { get { return 參考.組成字串; } }

        /********************************/

        public void 更新組成()
        {
            修改.更新組成();
            _組成字串識別 = 修改.組成字串;
        }
    }
}
