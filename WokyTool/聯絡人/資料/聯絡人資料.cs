using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.聯絡人
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 聯絡人資料 : MyKeepableData
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public string 姓名 { get; set; }

        [JsonProperty]
        public string 電話 { get; set; }

        [JsonProperty]
        public string 手機 { get; set; }

        [JsonProperty]
        public string 地址 { get; set; }

        /********************************/

        private static readonly 聯絡人資料 _NULL = new 聯絡人資料
        {
            編號 = 常數.T空白資料編碼,
            姓名 = 字串.無,
            電話 = 字串.無,
            手機 = 字串.無,
            地址 = 字串.無,
        };
        public static 聯絡人資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 聯絡人資料 _ERROR = new 聯絡人資料
        {
            編號 = 常數.T錯誤資料編碼,
            姓名 = 字串.錯誤,
            電話 = 字串.錯誤,
            手機 = 字串.錯誤,
            地址 = 字串.錯誤,
        };
        public static 聯絡人資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override object 拷貝()
        {
            聯絡人資料 Data_ = new 聯絡人資料
            {  
                編號 = this.編號,
                姓名 = this.姓名,
                電話 = this.電話,
                手機 = this.手機,
                地址 = this.地址,
            };

            return Data_;
        }

        public override void 覆蓋(object Item_)
        {
            聯絡人資料 Data_ = Item_ as 聯絡人資料;
            if (Data_ == null)
                throw new Exception("聯絡人資料:覆蓋失敗:" + this.GetType());

            編號 = Data_.編號;
            姓名 = Data_.姓名;
            電話 = Data_.電話;
            手機 = Data_.手機;
            地址 = Data_.地址;
        }

        public override Boolean 是否一致(object Item_)
        {
            聯絡人資料 Data_ = Item_ as 聯絡人資料;
            if (Data_ == null)
                throw new Exception("聯絡人資料:比較失敗:" + this.GetType());

            return
                編號 == Data_.編號 &&
                姓名 == Data_.姓名 &&
                電話 == Data_.電話 &&
                手機 == Data_.手機 &&
                地址 == Data_.地址;
        }

        public override void 檢查合法()
        {
            if (String.IsNullOrEmpty(姓名))
                throw new Exception("聯絡人資料:姓名不合法:" + this.ToString());

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                throw new Exception("聯絡人資料:電話/手機不合法:" + this.ToString());

            if (String.IsNullOrEmpty(地址))
                throw new Exception("聯絡人資料:地址不合法:" + this.ToString());
        }
    }
}
