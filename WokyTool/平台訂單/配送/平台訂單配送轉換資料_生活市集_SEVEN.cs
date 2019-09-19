using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Linq;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單配送轉換資料_生活市集_SEVEN : 平台訂單配送轉換資料_超商
    {
        private static List<PDF拷貝元件> _拷貝資料列;
        public static List<PDF拷貝元件> 拷貝資料列
        {
            get
            {
                if (_拷貝資料列 == null)
                {
                    _拷貝資料列 = new List<PDF拷貝元件>();
                    _拷貝資料列.Add(new PDF拷貝元件(new Rectangle(0, 0, 595, 280), 0, 19));
                    _拷貝資料列.Add(new PDF拷貝元件(new Rectangle(0, 280, 595, 560), 0, 22));
                    _拷貝資料列.Add(new PDF拷貝元件(new Rectangle(0, 560, 595, 840), 0, 24));
                }

                return _拷貝資料列;
            }
        }

        private static Dictionary<PDF字串讀出元件, PDF字串寫入元件> _設定資料書;
        public static Dictionary<PDF字串讀出元件, PDF字串寫入元件> 設定資料書
        {
            get 
            {
                if (_設定資料書 == null)
                {
                    // 讀出 配送單號
                    // 寫入 物品組成
                    _設定資料書 = new Dictionary<PDF字串讀出元件, PDF字串寫入元件>();
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(135, 765, 260, 780)), new PDF字串寫入元件(new Rectangle(5, 562, 295, 603), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(430, 765, 560, 780)), new PDF字串寫入元件(new Rectangle(305, 562, 595, 603), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(135, 485, 260, 500)), new PDF字串寫入元件(new Rectangle(5, 277, 295, 318), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(430, 485, 560, 500)), new PDF字串寫入元件(new Rectangle(305, 277, 595, 318), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(135, 205, 260, 220)), new PDF字串寫入元件(new Rectangle(5, -5, 295, 36), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(430, 205, 560, 220)), new PDF字串寫入元件(new Rectangle(305, -5, 595, 36), 常數.通用字體));
                }

                return _設定資料書;
            }
        }

        public override string 標頭 { get { return "請提供 生活市集 Seven 配送原始檔"; } }

        public override string 密碼 { get { return null; } }

        public 平台訂單配送轉換資料_生活市集_SEVEN(List<平台訂單新增資料> 來源資料列_)
            : base(來源資料列_)
        {
            轉換.配送公司 = 列舉.配送公司.SEVEN;
        }

        public override void 寫入(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_)
        {
            foreach (PDF拷貝元件 拷貝資料_ in 拷貝資料列)
            {
                拷貝資料_.處理(PdfReader_, 頁索引_, PdfWriter_);
            }

            foreach (var Pair_ in 設定資料書)
            {
                string 配送單號_ = Pair_.Key.處理(PdfReader_, 頁索引_);
                if (string.IsNullOrEmpty(配送單號_))
                    return;

                訊息管理器.獨體.訊息("讀出配送單號:" + 配送單號_);

                var 符合資料列_ = 來源資料列.Where(Value => 配送單號_.Equals(Value.配送單號)).ToArray();
                if (符合資料列_.Length == 0)
                {
                    Pair_.Value.處理(PdfWriter_, "找不到符合的配送單號");
                    訊息管理器.獨體.通知("找不到符合的配送單號:" + 配送單號_);
                }
                else
                {
                    物品合併資料 物品合併資料_ = new 物品合併資料();
                    foreach(平台訂單新增資料 資料_ in 符合資料列_)
                        物品合併資料_.新增(資料_);

                    Pair_.Value.處理(PdfWriter_, 物品合併資料_.ToString());
                }
            }
        }

        public override void 測試(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_)
        {
            foreach (PDF拷貝元件 拷貝資料_ in 拷貝資料列)
            {
                拷貝資料_.處理(PdfReader_, 頁索引_, PdfWriter_);
            }

            //PDF定位元件 PDF定位元件_ = new PDF定位元件();
            //PDF定位元件_.處理(PdfWriter_);

            foreach (var Pair_ in 設定資料書)
            {
                string 配送單號_ = Pair_.Key.處理(PdfReader_, 頁索引_);
                if (string.IsNullOrEmpty(配送單號_))
                    return;

                訊息管理器.獨體.訊息("讀出配送單號:" + 配送單號_);

                Pair_.Value.處理(PdfWriter_, 字串.多字測試);
            }
        }
    }
}
