using Newtonsoft.Json;
using System;
using WokyTool.Common;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.配送
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 配送轉換資料 : 可轉換資料<配送資料>
    {
        [可匯出]
        [JsonProperty]
        public 列舉.配送公司 配送公司
        {
            get { return 轉換.配送公司; }
            set
            {
                if (String.IsNullOrEmpty(轉換.配送單號) == false)
                {
                    訊息管理器.獨體.警告("已配送目標無法充新配送 " + this.ToString(false));
                    return;
                }

                轉換.配送公司 = value;
            }
        }

        [可匯出]
        [JsonProperty]
        public string 配送單號
        {
            get { return 轉換.配送單號; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    訊息管理器.獨體.警告("配送單號不可設定為空");
                    return;
                }

                if (String.IsNullOrEmpty(轉換.配送單號) == false)
                {
                    訊息管理器.獨體.警告("已配送目標無法充新配送 " + this.ToString(false));
                    return;
                }

                轉換.處理時間 = DateTime.Now;   // 這個值會同時用來判斷是否為新配送的資料
                轉換.處理者 = 系統參數.使用者名稱;
                轉換.配送單號 = value;
            }
        }

        [可匯出]
        [JsonProperty]
        public string 姓名
        {
            get { return 轉換.姓名; }
            set { 轉換.姓名 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 地址
        {
            get { return 轉換.地址; }
            set { 轉換.地址 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 電話
        {
            get { return 轉換.電話; }
            set { 轉換.電話 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 手機
        {
            get { return 轉換.手機; }
            set { 轉換.手機 = value; }
        }

        [可匯出]
        [JsonProperty]
        public DateTime 指配日期
        {
            get { return 轉換.指配日期; }
            set { 轉換.指配日期 = value; }
        }

        [可匯出]
        [JsonProperty]
        public 列舉.指配時段 指配時段
        {
            get { return 轉換.指配時段; }
            set { 轉換.指配時段 = value; }
        }

        [可匯出]
        [JsonProperty]
        public 列舉.代收方式 代收方式
        {
            get { return 轉換.代收方式; }
            set { 轉換.代收方式 = value; }
        }

        [可匯出]
        [JsonProperty]
        public virtual decimal 代收金額
        {
            get { return 轉換.代收金額; }
            set { 轉換.代收金額 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 備註
        {
            get { return 轉換.備註; }
            set { 轉換.備註 = value; }
        }

        [可匯出]
        [JsonProperty]
        public int 件數
        {
            get { return 轉換.件數; }
            set { 轉換.件數 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 內容
        {
            get { return 轉換.內容; }
            set { 轉換.內容 = value; }
        }

        /********************************/

        public bool 是否為新配送
        {
            get { return 轉換.處理時間.Ticks != 0; }
        }

        public bool 已配送
        {
            get { return string.IsNullOrEmpty(轉換.配送單號) == false; }
        }

        public virtual string 客戶名稱
        {
            get { return 字串.空; }
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

        public virtual void 撿貨合併(單品合併資料 合併資料_) { ; }

        public virtual bool 更新來源() 
        {
            if (是否為新配送 == false)
                return false;

            // do something
            return true;
        }
    }
}
