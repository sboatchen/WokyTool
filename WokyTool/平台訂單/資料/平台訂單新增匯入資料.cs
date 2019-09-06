using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.客製;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 平台訂單新增匯入資料 : 新版可匯入資料<平台訂單新增資料>
    {
        [可匯出]
        [JsonProperty]
        public DateTime 處理時間
        {
            get { return 新增資料.處理時間; }
            set { 新增資料.處理時間 = value; }
        }

        [可匯出]
        [JsonProperty]
        public 列舉.訂單處理狀態 處理狀態
        {
            get { return 新增資料.處理狀態; }
            set { 新增資料.處理狀態 = value; }
        }


        [可匯出]
        [JsonProperty]
        public string 商品識別
        {
            get
            {
                return _商品識別;
            }
            set
            {
                _商品識別 = value;
                新增資料.公司 = 公司資料管理器.獨體.取得(value);
            }
        }

        [可匯出]
        [JsonProperty]
        public int 數量
        {
            get { return 新增資料.數量; }
            set { 新增資料.數量 = value; }
        }

        [可匯出]
        [JsonProperty]
        public decimal 單價
        {
            get { return 新增資料.單價; }
            set { 新增資料.單價 = value; }
        }

        [可匯出]
        [JsonProperty]
        public decimal 含稅單價
        {
            get { return 新增資料.含稅單價; }
            set { 新增資料.含稅單價 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 姓名
        {
            get { return 新增資料.姓名; }
            set { 新增資料.姓名 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 地址
        {
            get { return 新增資料.地址; }
            set { 新增資料.地址 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 電話
        {
            get { return 新增資料.電話; }
            set { 新增資料.電話 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 手機
        {
            get { return 新增資料.手機; }
            set { 新增資料.手機 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 訂單編號
        {
            get { return 新增資料.訂單編號; }
            set { 新增資料.訂單編號 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 發票號碼
        {
            get { return 新增資料.發票號碼; }
            set { 新增資料.發票號碼 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 備註
        {
            get { return 新增資料.備註; }
            set { 新增資料.備註 = value; }
        }

        [可匯出]
        [JsonProperty]
        public 列舉.配送公司 配送公司
        {
            get { return 新增資料.配送公司; }
            set { 新增資料.配送公司 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string 配送單號
        {
            get { return 新增資料.配送單號; }
            set { 新增資料.配送單號 = value; }
        }

        [可匯出]
        [JsonProperty]
        public DateTime 指配日期    // 指配日期.Ticks == 0 代表不指定
        {
            get { return 新增資料.指配日期; }
            set { 新增資料.指配日期 = value; }
        }

        [可匯出]
        [JsonProperty]
        public 列舉.指配時段 指配時段
        {
            get { return 新增資料.指配時段; }
            set { 新增資料.指配時段 = value; }
        }

        [可匯出]
        [JsonProperty]
        public 列舉.代收方式 代收方式
        {
            get { return 新增資料.代收方式; }
            set { 新增資料.代收方式 = value; }
        }

        [可匯出]
        [JsonProperty]
        public decimal 代收金額
        {
            get { return 新增資料.代收金額; }
            set { 新增資料.代收金額 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string[] 標頭
        {
            get { return 新增資料.標頭; }
            set { 新增資料.標頭 = value; }
        }

        [可匯出]
        [JsonProperty]
        public string[] 內容
        {
            get { return 新增資料.內容; }
            set { 新增資料.內容 = value; }
        }

        /********************************/

        private string _商品識別;

        public 公司資料 公司
        {
            get { return 新增資料.公司; }
            set { 新增資料.公司 = value; }
        }

        public 客戶資料 客戶
        {
            get { return 新增資料.客戶; }
            set { 新增資料.客戶 = value; }
        }

        public 商品資料 商品
        {
            get { return 新增資料.商品; }
            set { 新增資料.商品 = value; }
        }

        public string 公司名稱 { get { return 新增資料.公司.名稱; } }
        public string 客戶名稱 { get { return 新增資料.客戶.名稱; } }
        public string 商品名稱 { get { return 新增資料.商品.名稱; } }

        public 平台訂單匯入處理介面 處理器
        {
            get { return 新增資料.處理器; }
            set { 新增資料.處理器 = value; }
        }
    }
}

