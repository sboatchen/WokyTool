using System;
using System.Collections.Generic;
using System.Text;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單匯入處理_PINKOI : 平台訂單匯入處理介面, /*可讀出介面_EXCEL<平台訂單新增匯入資料>*/ 可讀出介面_CSV<平台訂單新增匯入資料>
    {
        public string 分格號 { get { return "\t"; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        public string 密碼 { get { return null; } }

        public int 分頁索引 { get { return 1; } }

        public string 分頁名稱 { get { return null; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public 平台訂單匯入處理_PINKOI()
        {
            客戶 = 客戶資料管理器.獨體.取得("PINKOI");
        }

        public IEnumerable<平台訂單新增匯入資料> 讀出資料(string[] 資料列_)
        {
            // 運送地區必須為台灣
            string 運送地區_ = 資料列_[8].轉成字串();
            if (運送地區_.Equals("台灣") == false)
            {
                yield break;
            }

            string 訂單編號_ = 資料列_[2].轉成字串();

            string 姓名_ = 資料列_[4].轉成字串();
            string 電話_ = 資料列_[6].轉成字串();
            string 地址_ = 資料列_[5].轉成字串();

            string 商品名稱_ = 資料列_[9].轉成字串();
            商品資料 商品_ = 商品資料管理器.獨體.取得_名稱(客戶.編號, 商品名稱_);

            int 數量_ = 資料列_[12].轉成整數();

            yield return new 平台訂單新增匯入資料
            {
                處理狀態 = 列舉.訂單處理狀態.新增,

                訂單編號 = 訂單編號_,

                客戶 = this.客戶,

                姓名 = 姓名_,
                //手機 = 手機_,
                電話 = 電話_,
                地址 = 地址_,

                商品識別 = 商品名稱_,
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
