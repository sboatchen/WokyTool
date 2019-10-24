using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.客戶;
using WokyTool.配送;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單匯入處理_松果_超商 : 平台訂單匯入處理介面, 可讀出介面_EXCEL<平台訂單新增匯入資料>
    {
        public int 分頁索引 { get { return 1; } }

        public string 分頁名稱 { get { return null; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        public 列舉.配送公司 配送公司 { get; set; }

        public 平台訂單匯入處理_松果_超商()
        {
            客戶 = 客戶資料管理器.獨體.取得("松果");
        }

        public override void 讀出標頭(string[] 標頭列_)
        {
            if (配送公司 != 列舉.配送公司.SEVEN && 配送公司 != 列舉.配送公司.全家)
            {
                訊息管理器.獨體.錯誤("該模組需指定超商配送");
                return;
            }

            this._標頭列 = 標頭列_;
        }

        public IEnumerable<平台訂單新增匯入資料> 讀出資料(string[] 資料列_)
        {
            string 訂單編號_ = 資料列_[0].轉成字串().Trim();   // 前面有空白

            string 姓名_ = 資料列_[9].轉成字串();
            string 電話_ = 資料列_[10].轉成字串();
            string 地址_ = 資料列_[11].轉成字串();

            // 商品序號 = 商品編號 + 選項
            string 商品編號_ = 資料列_[13].轉成字串();
            string 款式_ = 資料列_[18].轉成字串();
            string 商品識別_ = 函式.取得商品識別(商品編號_, 款式_);
            商品資料 商品_ = 商品資料管理器.獨體.取得(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[20].轉成整數();

            string 配送編號_ = 資料列_[2].轉成字串().Trim();   // 前面有空白

            yield return new 平台訂單新增匯入資料
            {
                處理狀態 = 列舉.訂單處理狀態.配送,

                訂單編號 = 訂單編號_,

                客戶 = this.客戶,

                姓名 = 姓名_,
                電話 = 電話_,
                地址 = 地址_,

                商品識別 = 商品識別_,
                商品 = 商品_,
                數量 = 數量_,

                配送公司 = 配送公司,
                配送單號 = 配送編號_,

                處理器 = this,
                標頭 = _標頭列,
                內容 = 資料列_,
            };
        }

        public override String 取得分組識別(平台訂單新增資料 資料_)
        {
            return String.Format("{0}_{1}", this.GetType().Name, 資料_.配送公司);
        }

        public override IEnumerable<配送轉換資料> 配送轉換(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            var GroupQueue_ = 資料列舉_.GroupBy(Value => Value.配送分組);

            foreach (var Group_ in GroupQueue_)
            {
                平台訂單新增資料 第一單_ = Group_.First();

                switch (第一單_.配送公司)
                {
                    case 列舉.配送公司.SEVEN:
                        yield return new 平台訂單配送轉換資料_松果_SEVEN(Group_.ToList());
                        break;
                    case 列舉.配送公司.全家:
                        yield return new 平台訂單配送轉換資料_松果_全家(Group_.ToList());
                        break;
                    default:
                        訊息管理器.獨體.錯誤("不支援配送公司 " + 第一單_.配送公司);
                        break;
                }
            }
        }
    }
}
