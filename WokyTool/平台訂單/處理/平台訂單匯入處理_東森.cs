using System;
using System.Collections.Generic;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單匯入處理_東森 : 平台訂單匯入處理介面, 可讀出介面_EXCEL<平台訂單新增匯入資料>
    {
        private static string 一般訂單 = "一般訂單";
        private static string 員購訂單 = "員購訂單";

        public int 分頁索引 { get { return 1; } }

        public string 分頁名稱 { get { return null; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        public 平台訂單匯入處理_東森()
        {
            客戶 = 客戶資料管理器.獨體.取得("東森");
        }

        public IEnumerable<平台訂單新增匯入資料> 讀出資料(string[] 資料列_)
        {
            // 訂單類別為 "一般訂單", "員購訂單" 才處理
            string 訂單類別_ = 資料列_[10].轉成字串();
            列舉.訂單處理狀態 處理狀態_ = 列舉.訂單處理狀態.新增;
            if (一般訂單.Equals(訂單類別_) == false && 員購訂單.Equals(訂單類別_) == false)
            {
                處理狀態_ = 列舉.訂單處理狀態.忽略;
            }

            string 訂單編號_ = 資料列_[0].轉成字串();

            string 姓名_ = 資料列_[14].轉成字串();
            string 手機_ = 資料列_[15].轉成字串();
            string 電話_ = 資料列_[16].轉成字串();
            string 地址_ = 資料列_[17].轉成字串();

            // 商品序號 = 商品編號 + 款式 + 顏色
            string 商品編號_ = 資料列_[5].轉成字串();
            string 款式_ = 資料列_[8].轉成字串();
            string 顏色_ = 資料列_[7].轉成字串();
            string 商品識別_ = 函式.取得商品識別(商品編號_, 款式_, 顏色_);
            商品資料 商品_ = 商品資料管理器.獨體.取得(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[11].轉成整數();

            string 備註_ = 資料列_[23].轉成字串();

            yield return new 平台訂單新增匯入資料
            {
                處理狀態 = 處理狀態_,

                訂單編號 = 訂單編號_,

                客戶 = this.客戶,

                姓名 = 姓名_,
                手機 = 手機_,
                電話 = 電話_,
                地址 = 地址_,

                商品識別 = 商品識別_,
                商品 = 商品_,
                數量 = 數量_,

                備註 = 備註_,

                處理器 = this,
                標頭 = _標頭列,
                內容 = 資料列_,
            };
        }

        public override void 後續處理(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            var 轉換_ = new 平台訂單回單轉換_東森(資料列舉_);

            String 標題_ = String.Format("回單_{0}_{1}_{2}", 公司.名稱, 客戶.名稱, 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);
        }
    }
}
