using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.編號
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 編號資料 : MyKeepableData<編號資料>
    {
        [JsonProperty]
        public 列舉.編號 類型 { get; set; }

        public override int 編號
        {
            get
            {
                return (int)類型;
            }
            set
            {
                類型 = (列舉.編號)value;
            }
        }

        public string 名稱
        {
            get
            {
                return 類型.ToString("g");
            }
        }

        [JsonProperty]
        public int 下個值 { get; set; }

        /********************************/

        public 編號資料 Self
        {
            get { return this; }
        }

        private static readonly 編號資料 _NULL = new 編號資料
        {
            類型 = 列舉.編號.無,
            下個值 = 0,
        };
        public static 編號資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 編號資料 _ERROR = new 編號資料
        {
            類型 = 列舉.編號.錯誤,
            下個值 = 0,
        };
        public static 編號資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override 編號資料 拷貝()
        {
            編號資料 Data_ = new 編號資料
            {
                類型 = this.類型,
                下個值 = this.下個值,
            };

            return Data_;
        }

        public override void 覆蓋(編號資料 Data_)
        {
            類型 = Data_.類型;
            下個值 = Data_.下個值;
        }

        public override Boolean 是否一致(編號資料 Data_)
        {
            return
                類型 == Data_.類型 &&
                下個值 == Data_.下個值;
        }

        public override void 檢查合法()
        {
            if (列舉.是否有值(編號) == false)
                throw new Exception("編號資料:類型不合法:" + this.ToString());

            if (下個值 <= 常數.T新建資料編碼)
                throw new Exception("編號資料:值域不合法:" + this.ToString());
        }
    }
}
