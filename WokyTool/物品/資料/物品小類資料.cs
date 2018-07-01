using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.物品
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品小類資料 : MyKeepableData
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        /********************************/

        private static readonly 物品小類資料 _NULL = new 物品小類資料
        {
            編號 = 常數.空白資料編碼,
            名稱 = 字串.空,
        };
        public static 物品小類資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 物品小類資料 _ERROR = new 物品小類資料
        {
            編號 = 常數.錯誤資料編碼,
            名稱 = 字串.空,
        };
        public static 物品小類資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override object 拷貝()
        {
            物品小類資料 Data_ = new 物品小類資料
            {
                編號 = this.編號,
                名稱 = this.名稱,
            };

            return Data_;
        }

        public override void 覆蓋(object Item_)
        {
            物品小類資料 Data_ = Item_ as 物品小類資料;
            if (Data_ == null)
                throw new Exception("物品小類資料:覆蓋失敗:" + this.GetType());

            編號 = Data_.編號;
            名稱 = Data_.名稱;
        }

        public override Boolean 是否一致(object Item_)
        {
            物品小類資料 Data_ = Item_ as 物品小類資料;
            if (Data_ == null)
                throw new Exception("物品小類資料:比較失敗:" + this.GetType());

            return
                編號 == Data_.編號 &&
                名稱 == Data_.名稱;
        }

        public override void 檢查合法()
        {
            if (String.IsNullOrEmpty(名稱))
                throw new Exception("物品小類資料:名稱不合法:" + this.ToString());
        }
    }
}
