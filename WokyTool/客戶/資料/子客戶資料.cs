using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;
using WokyTool.聯絡人;

namespace WokyTool.客戶
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 子客戶資料 : 新版可記錄資料<子客戶資料>
    {
        [可匯出]
        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public int 客戶編號
        {
            get
            {
                return 客戶.編號;
            }
            set
            {
                客戶 = 客戶資料管理器.獨體.取得(value);
            }
        }

        /********************************/

        public 客戶資料 客戶 { get; set; }

        [可匯出(名稱 = "客戶")]
        public string 客戶名稱 { get { return 客戶.名稱; } }

        public IEnumerable<聯絡人資料> 聯絡人列舉
        {
            get
            {
                return 聯絡人資料管理器.獨體.資料列舉2.Where(Value => Value.子客戶 == this);
            }
        }

        public int 聯絡人數量 { get { return 聯絡人列舉.Count(); } }

        public 子客戶資料 Self { get { return this; } }

        public 子客戶資料()
        {
            客戶 = 客戶資料.空白;
        }

        public static readonly 子客戶資料 不篩 = new 子客戶資料
        {
            編號 = 常數.不篩資料編碼,
            名稱 = 字串.不篩選,
            客戶 = 客戶資料.不篩,
        };

        public static readonly 子客戶資料 空白 = new 子客戶資料
        {
            編號 = 常數.空白資料編碼,
            名稱 = 字串.無,
            客戶 = 客戶資料.空白,
        };

        public static 子客戶資料 錯誤 = new 子客戶資料
        {
            編號 = 常數.錯誤資料編碼,
            名稱 = 字串.錯誤,
            客戶 = 客戶資料.錯誤,
        };

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (String.IsNullOrEmpty(名稱))
                檢查器_.錯誤(資料_, "名稱不合法");
            else if (子客戶資料管理器.獨體.資料列舉2.Where(Value => Value != 參考_ && 名稱.Equals(Value.名稱)).Any())
                檢查器_.錯誤(資料_, "名稱重複");

            if (false == 客戶.編號是否有值())
                檢查器_.錯誤(資料_, "客戶不合法");
        }

        public override void 刪除檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;

            foreach (聯絡人資料 聯絡人資料_ in 聯絡人列舉)
            {
                檢查器_.錯誤(資料_, "資料綁定中:" + 聯絡人資料_.ToString(false));
            }
        }
    }
}
