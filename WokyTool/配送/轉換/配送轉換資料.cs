using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.配送
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 配送轉換資料 : 可轉換資料<配送資料>
    {
        [可匯出]
        [JsonProperty]
        public virtual 列舉.配送公司 配送公司
        {
           get { return 目標資料.配送公司; }
           set { 目標資料.配送公司 = value; }
        }

        [可匯出]
        [JsonProperty]
        public virtual string 配送單號
        {
            get
            {
                return 目標資料.配送單號;
            }

            set
            {
                if (目標資料.配送單號 == value)
                    return;

                if (String.IsNullOrEmpty(value))
                {
                    訊息管理器.獨體.警告("目標資料單號不可設定為空");
                    return;
                }


                if (String.IsNullOrEmpty(目標資料.配送單號) == false)
                {
                    訊息管理器.獨體.警告("資料重複目標資料 " + this.ToString(false));
                    return;
                }

                目標資料.處理時間 = DateTime.Now;
                目標資料.配送單號 = value;
            }
        }

        [可匯出]
        [JsonProperty]
        public string 姓名
        {
            get { return 目標資料.姓名; }
            set { 目標資料.姓名 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 地址
        {
            get { return 目標資料.地址; }
            set { 目標資料.地址 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 電話
        {
            get { return 目標資料.電話; }
            set { 目標資料.電話 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 手機
        {
            get { return 目標資料.手機; }
            set { 目標資料.手機 = value; }
        }

        [可匯出]
        [JsonProperty]
        public DateTime 指配日期
        {
            get { return 目標資料.指配日期; }
            set {
                目標資料.指配日期 = value;
                /*if (value == null)
                    目標資料.指配日期 = DateTime.MinValue;
                else
                    目標資料.指配日期 = value.Value; */
            }
        }

        [可匯出]
        [JsonProperty]
        public 列舉.指配時段 指配時段
        {
            get { return 目標資料.指配時段; }
            set { 目標資料.指配時段 = value; }
        }

        [可匯出]
        [JsonProperty]
        public 列舉.代收方式 代收方式
        {
            get { return 目標資料.代收方式; }
            set { 目標資料.代收方式 = value; }
        }

        [可匯出]
        [JsonProperty]
        public virtual decimal 代收金額
        {
            get { return 目標資料.代收金額; }
            set { 目標資料.代收金額 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 備註
        {
            get { return 目標資料.備註; }
            set { 目標資料.備註 = value; }
        }

        [可匯出]
        [JsonProperty]
        public int 件數
        {
            get { return 目標資料.件數; }
            set { 目標資料.件數 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 內容
        {
            get { return 目標資料.內容; }
            set { 目標資料.內容 = value; }
        }

        /********************************/

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            //基本資料 參考_ = (資料參考_ == null) ? this : 資料參考_;

            if (String.IsNullOrEmpty(姓名))
                檢查器_.錯誤(資料_, "姓名不合法");

            if (String.IsNullOrEmpty(地址))
                檢查器_.錯誤(資料_, "地址不合法");

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                檢查器_.錯誤(資料_, "電話/手機不合法");

            if (列舉.是否合法((int)指配時段) == false)
                檢查器_.錯誤(資料_, "指配時段不合法");

            if (列舉.是否合法((int)代收方式) == false)
                檢查器_.錯誤(資料_, "代收方式不合法");

            if (代收金額 < 0)
                檢查器_.錯誤(資料_, "代收金額不合法");

            if (件數 <= 0)
                檢查器_.錯誤(資料_, "件數不合法");
        }

        public virtual void 撿貨合併(物品合併資料 合併資料_) { ; }
    }
}
