using iTextSharp.text;
using iTextSharp.text.pdf;
using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單配送轉換_松果_SEVEN : 可寫入介面_PDF
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
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(130, 745, 260, 770)), new PDF字串寫入元件(new Rectangle(5, 562, 295, 603), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(430, 745, 560, 770)), new PDF字串寫入元件(new Rectangle(305, 562, 595, 603), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(130, 465, 260, 485)), new PDF字串寫入元件(new Rectangle(5, 277, 295, 318), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(430, 465, 560, 485)), new PDF字串寫入元件(new Rectangle(305, 277, 595, 318), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(130, 190, 260, 210)), new PDF字串寫入元件(new Rectangle(5, -5, 295, 36), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(430, 190, 560, 210)), new PDF字串寫入元件(new Rectangle(305, -5, 595, 36), 常數.通用字體));
                }

                return _設定資料書;
            }
        }

        public string 密碼 { get { return null; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單配送轉換_松果_SEVEN(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_)
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

                配送單號_ = 配送單號_.Substring(3); // 移除前三碼
                訊息管理器.獨體.訊息("讀出配送單號:" + 配送單號_);

                var 符合資料列_ = _資料列舉.Where(Value => 配送單號_.Equals(Value.配送單號)).ToArray();
                if (符合資料列_.Length == 0)
                {
                    Pair_.Value.處理(PdfWriter_, "找不到符合的配送單號");
                    訊息管理器.獨體.通知("找不到符合的配送單號:" + 配送單號_);
                }
                else
                {
                    物品合併資料 物品合併資料_ = new 物品合併資料();
                    foreach(平台訂單新增資料 資料_ in 符合資料列_)
                        物品合併資料_.新增(資料_.商品, 資料_.數量);

                    Pair_.Value.處理(PdfWriter_, 物品合併資料_.ToString());
                }
            }
        }

        public void 測試(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_)
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
