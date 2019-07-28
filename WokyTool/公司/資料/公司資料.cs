using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.公司
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 公司資料 : 可記錄資料<公司資料>
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        /********************************/

        public 公司資料 Self
        {
            get { return this; }
        }

        private static readonly 公司資料 _NULL = new 公司資料
        {
            編號 = 常數.空白資料編碼,
            名稱 = 字串.無,
        };
        public static 公司資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 公司資料 _ERROR = new 公司資料
        {
            編號 = 常數.錯誤資料編碼,
            名稱 = 字串.錯誤,
        };
        public static 公司資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 公司資料 拷貝()
        {
            公司資料 Data_ = new 公司資料
            {
                編號 = this.編號,
                名稱 = this.名稱,
            };

            return Data_;
        }

        public override void 覆蓋(公司資料 Data_)
        {
            編號 = Data_.編號;
            名稱 = Data_.名稱;
        }

        public override bool 是否一致(公司資料 Data_)
        {
            return
                編號 == Data_.編號 &&
                名稱 == Data_.名稱;
        }

        public override void 檢查合法()
        {
            if (String.IsNullOrEmpty(名稱))
                throw new Exception("公司資料:名稱不合法:" + this.ToString());
        }
    }
}
