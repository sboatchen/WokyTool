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
    public class 子客戶資料 : MyKeepableData
    {
        [JsonProperty]
        public override int 編號 { get; set; }

        [JsonProperty]
        public string 名稱 { get; set; }

        [JsonProperty]
        public List<int> 聯絡人編號列 { get; set; }

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

        private static readonly 子客戶資料 _NULL = new 子客戶資料
        {
            編號 = 常數.空白資料編碼,
            名稱 = 字串.空,
            聯絡人編號列 = null,
        };
        public static 子客戶資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 子客戶資料 _ERROR = new 子客戶資料
        {
            編號 = 常數.錯誤資料編碼,
            名稱 = 字串.空,
            聯絡人編號列 = null,
        };
        public static 子客戶資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        /********************************/

        public override object 拷貝()
        {
            子客戶資料 Data_ = new 子客戶資料
            {
                編號 = this.編號,
                名稱 = this.名稱,
            };

            if (this.聯絡人編號列 != null)
            {
                Data_.聯絡人編號列 = new List<int>();
                foreach (int value in 聯絡人編號列)
                {
                    Data_.聯絡人編號列.Add(value);
                }
            }

            return Data_;
        }

        public override void 覆蓋(object Item_)
        {
            子客戶資料 Data_ = Item_ as 子客戶資料;
            if (Data_ == null)
                throw new Exception("子客戶資料:覆蓋失敗:" + this.GetType());

            編號 = Data_.編號;
            名稱 = Data_.名稱;

            if (Data_.聯絡人編號列 != null)
            {
                聯絡人編號列 = new List<int>();
                foreach (int value in Data_.聯絡人編號列)
                {
                    聯絡人編號列.Add(value);
                }
            }
            else
            {
                聯絡人編號列 = null;
            }
        }

        public override Boolean 是否一致(object Item_)
        {
            子客戶資料 Data_ = Item_ as 子客戶資料;
            if (Data_ == null)
                throw new Exception("子客戶資料:比較失敗:" + this.GetType());

            if (編號 != Data_.編號 || 名稱 != Data_.名稱 || 聯絡人數量 != Data_.聯絡人數量)
                return false;

            for (int i = 0; i < 聯絡人數量; i++)
            {
                if (聯絡人編號列[i] != Data_.聯絡人編號列[i])
                    return false;
            }

            return true;
        }

        public override void 檢查合法()
        {
            if (String.IsNullOrEmpty(名稱))
                throw new Exception("子客戶資料:名稱不合法:" + this.ToString());

            // 考慮使用者可能先建 客戶資料 再建 聯絡人資料
            //if(聯絡人數量 == 0)
            //    throw new Exception("子客戶資料:聯絡人數量為0:" + this.ToString());
        }
    }
}
