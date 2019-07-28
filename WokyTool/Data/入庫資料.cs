using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 入庫資料 : 可運作
    {
        [CsvColumn(Name = "編號")]
        [JsonProperty]
        public int 編號 { get; set; }

        [CsvColumn(Name = "時間")]
        [JsonProperty]
        public DateTime 時間 { get; set; }

        [CsvColumn(Name = "運作")]
        public bool _運作;

        // 可運作
        [JsonProperty]
        public bool 運作 
        {
            get { return _運作; }
            set
            {
                if (_運作 == value)
                    return;
                _運作 = value;

                if (_運作)
                    商品.Borrow(數量);
                else
                    商品.Borrow(-數量);
            }
        }

        public 商品資料 商品;
        [CsvColumn(Name = "商品編號")]
        [JsonProperty]
        public int 商品編號
        {
            get
            {
                return 商品.編號;
            }
            set
            {
                商品 = 商品管理器.Instance.Get(value);
            }
        }

        public string 公司名稱 { get { return 商品.公司.名稱; } }
        public string 廠商名稱 { get { return 商品.廠商.名稱; } }

        [CsvColumn(Name = "數量")]
        [JsonProperty]
        public int 數量 { get; set; }

        public 入庫資料()
        {
            編號 = 常數.舊的新資料編碼;
            時間 = DateTime.Now;
            _運作 = false;

            商品 = 商品資料.NULL;
            數量 = 0;
        }

        public static 入庫資料 New()
        {
            入庫資料 New_ = new 入庫資料();
            New_.編號 = 編碼管理器.Instance.Get(列舉.編號.入庫);

            return New_;
        }

        private static readonly 入庫資料 _NULL = new 入庫資料
        {
            編號 = 常數.舊的空白資料編碼,
            時間 = 通用.時間.NULL,
            _運作 = true,
            商品 = 商品資料.NULL,
            數量 = 0,
        };
        public static 入庫資料 NULL{ get{ return _NULL; } }

        private static 入庫資料 _ERROR = new 入庫資料
        {
            編號 = 常數.舊的錯誤資料編碼,
            時間 = 通用.時間.NULL,
            _運作 = true,
            商品 = 商品資料.ERROR,
            數量 = 0,
        };
        public static 入庫資料 ERROR{ get{ return _ERROR; } }

        //@@ 檢查所有其他的統一增加 [JsonProperty] 
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
