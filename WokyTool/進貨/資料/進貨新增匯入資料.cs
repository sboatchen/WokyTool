﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;
using WokyTool.廠商;

namespace WokyTool.進貨
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 進貨新增匯入資料 : 靜態匯入資料
    {
        [JsonProperty]
        public 列舉.進貨 類型 { get; set; }

        [JsonProperty]
        public string 廠商識別 { get; set; }

        protected 廠商資料 _廠商;
        public 廠商資料 廠商
        {
            get
            {
                if (_廠商 == null)
                    _廠商 = 廠商資料.NULL;
                else if (廠商資料管理器.獨體.唯讀BList.Contains(_廠商) == false)
                    _廠商 = 廠商資料.ERROR;

                return _廠商;
            }
            set
            {
                _廠商 = value;
            }
        }

        [JsonProperty]
        public string 物品識別 { get; set; }

        protected 物品資料 _物品;
        public 物品資料 物品
        {
            get
            {
                if (_物品 == null)
                    _物品 = 物品資料.NULL;
                else if (物品資料管理器.獨體.唯讀BList.Contains(_物品) == false)
                    _物品 = 物品資料.ERROR;

                return _物品;
            }
            set
            {
                _物品 = value;
            }
        }

        [JsonProperty]
        public int 數量 { get; set; }
        [JsonProperty]
        public decimal 單價 { get; set; }

        public decimal 總金額
        {
            get
            {
                return 數量 * 單價;
            }
        }


        [JsonProperty]
        public string 備註 { get; set; }

        /********************************/

        public override void 初始化() 
        {
            廠商 = 廠商資料管理器.獨體.Get(廠商識別);
            物品 = 物品資料管理器.獨體.Get(物品識別);
        }

        public override void 檢查合法()
        {
            if (廠商.編號是否合法() == false)
                throw new Exception("進貨新增匯入資料:廠商不合法:" + 廠商識別);

            if (物品.編號是否合法() == false)
                throw new Exception("進貨新增匯入資料:物品不合法:" + 物品識別);

            if (列舉.是否合法((int)類型) == false)
                throw new Exception("進貨新增匯入資料:類型不合法:" + 類型);

            if (數量 <= 0)
                throw new Exception("進貨新增匯入資料:數量不合法:" + 數量);
        }
    }
}
