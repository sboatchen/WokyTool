using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.Common;
using WokyTool.客戶;
using WokyTool.配送;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單匯入處理_蝦皮 : 平台訂單匯入處理介面, 可讀出介面_EXCEL<平台訂單新增匯入資料>
    {
        public int 分頁索引 { get { return 1; } }

        public string 分頁名稱 { get { return null; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        public 列舉.配送公司 配送公司 { get; set; }

        public 平台訂單匯入處理_蝦皮()
        {
            客戶 = 客戶資料管理器.獨體.取得("蝦皮");
        }

        private static string 待出貨 = "待出貨";
        private static string 賣家宅配 = "賣家宅配";
        public IEnumerable<平台訂單新增匯入資料> 讀出資料(string[] 資料列_)
        {
            string 訂單編號_ = 資料列_[0].轉成字串();

            string 訂單狀態_ = 資料列_[1].轉成字串();
            if (待出貨.Equals(訂單狀態_) == false)
                yield break;

            string 寄送方式_ = 資料列_[36].轉成字串();
            if (賣家宅配.Equals(寄送方式_) == false)
                yield break;

            string 姓名_ = 資料列_[35].轉成字串();
            string 地址_ = 資料列_[29].轉成字串();
            string 電話_ = 資料列_[30].轉成字串();

            // 商品序號 = 商品名稱 + 選項
            string 商品名稱_ = 資料列_[20].轉成字串();
            string 款式_ = 資料列_[21].轉成字串();
            string 商品識別_ = 函式.取得商品識別(商品名稱_, 款式_);
            商品資料 商品_ = 商品資料管理器.獨體.取得(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[26].轉成整數();

            yield return new 平台訂單新增匯入資料
            {
                處理狀態 = 列舉.訂單處理狀態.新增,

                訂單編號 = 訂單編號_,

                客戶 = this.客戶,

                姓名 = 姓名_,
                電話 = 電話_,
                //手機 = 手機_,
                地址 = 地址_,

                商品識別 = 商品識別_,
                商品 = 商品_,
                數量 = 數量_,

                //備註 = 備註_,

                處理器 = this,
                標頭 = _標頭列,
                內容 = 資料列_,
            };
        }
    }
}
