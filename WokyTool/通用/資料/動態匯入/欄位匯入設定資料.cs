using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 欄位匯入設定資料 : MyKeepableData<欄位匯入設定資料>
    {
        // >= 0
        [JsonProperty]
        public int 列索引 { get; set; }

        [JsonProperty]
        public bool 可合併儲存格 { get; set; }

        [JsonProperty]
        public 列舉.資料格式 格式 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        public override int 編號 
        {
            get { return 列索引; }
            set { 列索引 = value; }
        }

        /********************************/

        private static readonly 欄位匯入設定資料 _NULL = new 欄位匯入設定資料
        {
            列索引 = -1,
            可合併儲存格 = false,
            格式 = 列舉.資料格式.無,
            名稱 = 字串.空
        };
        public static 欄位匯入設定資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 欄位匯入設定資料 _ERROR = new 欄位匯入設定資料
        {
            列索引 = -1,
            可合併儲存格 = false,
            格式 = 列舉.資料格式.錯誤,
            名稱 = 字串.錯誤
        };
        public static 欄位匯入設定資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 欄位匯入設定資料 拷貝()
        {
            return new 欄位匯入設定資料
            {
                列索引 = this.列索引,
                可合併儲存格 = this.可合併儲存格,
                格式 = this.格式,
                名稱 = this.名稱
            };
        }

        public override void 覆蓋(欄位匯入設定資料 Data_)
        {
            列索引 = Data_.列索引;
            可合併儲存格 = Data_.可合併儲存格;
            格式 = Data_.格式;
            名稱 = Data_.名稱;
        }

        public override Boolean 是否一致(欄位匯入設定資料 Data_)
        {
            return
                列索引 == Data_.列索引 &&
                可合併儲存格 == Data_.可合併儲存格 &&
                格式 == Data_.格式 &&
                名稱 == Data_.名稱;
        }

        // 如果不合法 回傳例外
        public override void 檢查合法()
        {
            if (列索引 < 0)
                throw new Exception("欄位匯入設定資料:列索引不合法:" + 列索引);

            if (列舉.是否有值((int)格式) == false)
                throw new Exception("欄位匯入設定資料:格式不合法" + 格式);

            //if (String.IsNullOrEmpty(名稱))
            //    throw new Exception(欄位匯入設定資料:名稱不合法";
        }
    }
}
