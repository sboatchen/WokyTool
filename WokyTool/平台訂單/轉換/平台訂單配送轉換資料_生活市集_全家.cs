using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Linq;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單配送轉換資料_生活市集_全家 : 平台訂單配送轉換資料_超商
    {
        private static PDF拷貝元件 拷貝資料 = new PDF拷貝元件(new Rectangle(0, 50, 595, 810), 0, -20);

        private static Dictionary<PDF圖片字串讀出元件, PDF字串寫入元件> _設定資料書;
        public static Dictionary<PDF圖片字串讀出元件, PDF字串寫入元件> 設定資料書
        {
            get 
            {
                if (_設定資料書 == null)
                {
                    // 讀出 訂單編號
                    // 寫入 物品組成
                    _設定資料書 = new Dictionary<PDF圖片字串讀出元件, PDF字串寫入元件>();
                    _設定資料書.Add(new PDF圖片字串讀出元件(new System.Drawing.Rectangle(435, 200, 265, 50)), new PDF字串寫入元件(new Rectangle(5, 785, 295, 830), 常數.通用字體));
                    _設定資料書.Add(new PDF圖片字串讀出元件(new System.Drawing.Rectangle(1685, 200, 265, 50)), new PDF字串寫入元件(new Rectangle(305, 785, 595, 830), 常數.通用字體));
                    _設定資料書.Add(new PDF圖片字串讀出元件(new System.Drawing.Rectangle(435, 1940, 265, 50)), new PDF字串寫入元件(new Rectangle(5, 0, 295, 45), 常數.通用字體));
                    _設定資料書.Add(new PDF圖片字串讀出元件(new System.Drawing.Rectangle(1685, 1940, 265, 50)), new PDF字串寫入元件(new Rectangle(305, 0, 595, 45), 常數.通用字體));
                }

                return _設定資料書;
            }
        }

        public override string 標頭 { get { return "請提供 生活市集 全家 配送原始檔"; } }

        public override string 密碼 { get { return null; } }

        public 平台訂單配送轉換資料_生活市集_全家(List<平台訂單新增資料> 來源資料列_)
            : base(來源資料列_)
        {
            轉換.配送公司 = 列舉.配送公司.全家;
        }

        public override void 寫入(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_)
        {
            拷貝資料.處理(PdfReader_, 頁索引_, PdfWriter_);

            foreach (var Pair_ in 設定資料書)
            {
                string 訂單編號_ = Pair_.Key.處理(PdfReader_, 頁索引_);
                if (string.IsNullOrEmpty(訂單編號_))
                    return;

                訊息管理器.獨體.訊息("讀出訂單編號:" + 訂單編號_);

                var 符合資料列_ = 來源資料列.Where(Value => 訂單編號_.Equals(Value.訂單編號)).ToArray();
                if (符合資料列_.Length == 0)
                {
                    Pair_.Value.處理(PdfWriter_, "找不到符合的訂單編號");
                    訊息管理器.獨體.通知("找不到符合的訂單編號:" + 訂單編號_);
                }
                else
                {
                    物品合併資料 物品合併資料_ = new 物品合併資料();
                    foreach (平台訂單新增資料 資料_ in 符合資料列_)
                        物品合併資料_.新增(資料_.商品, 資料_.數量);

                    Pair_.Value.處理(PdfWriter_, 物品合併資料_.ToString());
                }
            }
        }

        public override void 測試(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_)
        {
            拷貝資料.處理(PdfReader_, 頁索引_, PdfWriter_);

            //PDF定位元件 PDF定位元件_ = new PDF定位元件();
            //PDF定位元件_.處理(PdfWriter_);

            foreach (var Pair_ in 設定資料書)
            {
                string 訂單編號_ = Pair_.Key.處理(PdfReader_, 頁索引_);
                if (string.IsNullOrEmpty(訂單編號_))
                    return;

                訊息管理器.獨體.訊息("讀出訂單編號:" + 訂單編號_);

                Pair_.Value.處理(PdfWriter_, 字串.多字測試);
            }
        }
    }
}
