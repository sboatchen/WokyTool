﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.配送
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 可配送資料 : 基本資料, 可配送介面
    {
        public 可配送介面 配送參考 { get; protected set; }

        public virtual 物品合併資料 合併
        {
            get
            {
                return 配送參考.合併;
            }

            protected set
            {
                throw new Exception("Not Support 可配送資料::合併");
            }
        }

        private int _件數 = 1;
        [JsonProperty]
        public int 件數 
        {
            get { return _件數; }
            set { _件數 = value; }
        }

        [JsonProperty]
        public int 體積 { get; protected set; }

        [JsonProperty]
        public string 內容 { get; protected set; }

        [JsonProperty]
        public string 姓名 { get; set; }

        [JsonProperty]
        public string 備註 { get; set; }

        [JsonProperty]
        public string 電話
        {
            get
            {
                return 配送參考.電話;
            }
        }

        [JsonProperty]
        public string 手機
        {
            get
            {
                return 配送參考.手機;
            }
        }

        [JsonProperty]
        public string 地址
        {
            get
            {
                return 配送參考.地址;
            }
        }

        [JsonProperty]
        public DateTime 指配日期
        {
            get
            {
                return 配送參考.指配日期;
            }
        }

        [JsonProperty]
        public 列舉.指配時段 指配時段
        {
            get
            {
                return 配送參考.指配時段;
            }
        }

        [JsonProperty]
        public 列舉.代收方式 代收方式
        {
            get
            {
                return 配送參考.代收方式;
            }
        }

        [JsonProperty]
        public virtual decimal 代收金額
        {
            get
            {
                return 配送參考.代收金額;
            }

            protected set
            {
                throw new Exception("Not Support 可配送資料::代收金額");
            }
        }

        [JsonProperty]
        public virtual 列舉.配送公司 配送公司
        {
            get
            {
                return 配送參考.配送公司;
            }

            set
            {
                配送參考.配送公司 = value;
            }
        }

        [JsonProperty]
        public virtual string 配送單號
        {
            get
            {
                return 配送參考.配送單號;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    配送參考.配送單號 = null;
                    return;
                }

                if (String.IsNullOrEmpty(配送參考.配送單號) == false)
                {
                    訊息管理器.獨體.警告("資料重複配送 " + this.ToString());
                    return;
                }

                配送參考.配送單號 = value;
            }
        }

        public bool 是否已配送()
        {
            return String.IsNullOrEmpty(配送單號) == false;
        }

        public void 初始化()
        {
            if(this.合併 == null)
                訊息管理器.獨體.錯誤("缺少合併資料 " + this.ToString());

            this.內容 = this.合併.ToString();
            this.體積 = this.合併.體積;

            // 配送公司
            if (配送公司 != 列舉.配送公司.無)
                return;

            if (體積 >= 常數.宅配通配送最小體積)
                配送公司 = 列舉.配送公司.宅配通;
            else
                配送公司 = 列舉.配送公司.全速配;
        }
    }
}
