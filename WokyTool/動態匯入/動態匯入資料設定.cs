using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.動態匯入
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 動態匯入資料設定 : MyData
    {
        // >= 0
        [JsonProperty]
        public int 列索引 { get; set; }

        [JsonProperty]
        public bool 可合併儲存格 { get; set; }

        [JsonProperty]
        public 列舉.資料格式類型 格式 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        /********************************/

        public static 動態匯入資料設定 New()
        {
            return new 動態匯入資料設定
            {
                列索引 = -1,
                可合併儲存格 = false,
                格式 = 列舉.資料格式類型.整數,
                名稱 = 字串.空
            };
        }

        private static readonly 動態匯入資料設定 _NULL = new 動態匯入資料設定
        {
            列索引 = -1,
            可合併儲存格 = false,
            格式 = 列舉.資料格式類型.無,
            名稱 = 字串.空
        };
        public static 動態匯入資料設定 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 動態匯入資料設定 _ERROR = new 動態匯入資料設定
        {
            列索引 = -1,
            可合併儲存格 = false,
            格式 = 列舉.資料格式類型.錯誤,
            名稱 = 字串.錯誤
        };
        public static 動態匯入資料設定 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        public override object 拷貝()
        {
            return new 動態匯入資料設定
            {
                列索引 = this.列索引,
                可合併儲存格 = this.可合併儲存格,
                格式 = this.格式,
                名稱 = this.名稱
            };
        }

        // 如果不合法 回傳例外
        public override void 檢查合法()
        {
            if (列索引 < 0)
                throw new Exception("動態匯入資料設定:列索引不合法:" + 列索引);

            if (格式 <= 列舉.資料格式類型.無)
                throw new Exception("動態匯入資料設定:格式不合法" + 格式);

            //if (String.IsNullOrEmpty(名稱))
            //    throw new Exception(動態匯入資料設定:名稱不合法";
        }
    }
}
