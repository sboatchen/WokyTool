using System;
using System.Collections.Generic;
using System.Text;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單匯入處理_生活市集 : 平台訂單匯入處理介面, 可讀出介面_CSV<平台訂單新增匯入資料>
    {
        public string 分格號 { get { return ","; } }

        public string 密碼 { get { return null; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public 平台訂單匯入處理_生活市集()
        {
            客戶 = 客戶資料管理器.獨體.取得("生活市集");
        }

        public IEnumerable<平台訂單新增匯入資料> 讀出資料(string[] 資料列_)
        {
            string 訂單編號_ = 資料列_[3].轉成字串();

            string 姓名_ = 資料列_[4].轉成字串();
            string 地址_ = 資料列_[5].轉成字串();
            string 電話_ = 資料列_[6].轉成字串();

            string 配送編號_ = 資料列_[1].轉成字串().Trim();

            // 範例 簡約陶瓷不沾保溫瓶550ML/簡約白*1;簡約陶瓷不沾保溫瓶550ML/經典原*1
            string[] 出貨明細列_ = 資料列_[7].轉成字串().Split(';');
            foreach (string 出貨明細_ in 出貨明細列_)
            {
                string[] 商品組成_ = 出貨明細_.Split('*');
                string 商品識別_ = 商品組成_[0];
                int 數量_ = 商品組成_[1].轉成整數();

                商品資料 商品_ = 商品資料管理器.獨體.取得_名稱(客戶.編號, 商品識別_);

                yield return new 平台訂單新增匯入資料
                {
                    處理狀態 = 列舉.訂單處理狀態.新增,

                    訂單編號 = 訂單編號_,

                    客戶 = this.客戶,

                    姓名 = 姓名_,
                    電話 = 電話_,
                    地址 = 地址_,

                    商品識別 = 商品識別_,
                    商品 = 商品_,
                    數量 = 數量_,

                    處理器 = this,
                    標頭 = _標頭列,
                    內容 = 資料列_,
                };
            }
        }

        public override String 取得分組識別(平台訂單新增資料 資料_)
        {
            // + 檔次編號
            return String.Format("{0}_{1}_{2}_{3}_{4}", 資料_.公司.名稱, 資料_.客戶.名稱, 資料_.姓名, 資料_.地址, 資料_.內容[0]);
        }

        public override void 後續處理(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            var 轉換_ = new 平台訂單回單轉換_生活市集(資料列舉_);

            String 標題_ = String.Format("回單_{0}_{1}_{2}", 公司.名稱, 客戶.名稱, 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);
        }
    }
}
