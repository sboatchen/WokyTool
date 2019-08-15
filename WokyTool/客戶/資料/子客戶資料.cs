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
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class 子客戶資料 : 新版可記錄資料<子客戶資料>
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public List<int> 聯絡人編號列 { get; set; }

        /********************************/

        public 子客戶資料 Self { get { return this; } }

        public static readonly 子客戶資料 空白 = new 子客戶資料
        {
            編號 = 常數.空白資料編碼,
            名稱 = 字串.無,
            聯絡人編號列 = null,
        };

        public static 子客戶資料 錯誤 = new 子客戶資料
        {
             編號 = 常數.錯誤資料編碼,
            名稱 = 字串.錯誤,
            聯絡人編號列 = null,
        };

         public int 聯絡人數量
        {
            get 
            {
                if (聯絡人編號列 == null)
                    return 0;
                return 聯絡人編號列.Count;
            }
        }

        /********************************/

        public override void 檢查合法(可處理合法介面 介面_)
        {
            if (String.IsNullOrEmpty(名稱))
                介面_.錯誤(this, "名稱不合法");
        }
    }
}
