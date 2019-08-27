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
    public class 平台訂單配送轉換_松果_全家 : 可寫入介面_PDF
    {
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
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(130, 755, 250, 775)), new PDF字串寫入元件(new Rectangle(10, 811, 290, 840), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(430, 755, 550, 775)), new PDF字串寫入元件(new Rectangle(310, 811, 590, 840), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(130, 475, 250, 490)), new PDF字串寫入元件(new Rectangle(10, 534, 290, 563), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(430, 475, 550, 490)), new PDF字串寫入元件(new Rectangle(310, 534, 590, 563), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(130, 195, 250, 210)), new PDF字串寫入元件(new Rectangle(10, -4, 290, 25), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(430, 195, 550, 210)), new PDF字串寫入元件(new Rectangle(310, -4, 590, 25), 常數.通用字體));
                }

                return _設定資料書;
            }
        }

        public string 密碼 { get { return null; } }

        public double X位移 { get { return 0; } }
        public double Y位移 { get { return 0; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單配送轉換_松果_全家(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(PdfReader PdfReader_, int 頁索引_, PdfContentByte PCB_)
        {
            foreach (var Pair_ in 設定資料書)
            {
                string 配送單號_ = Pair_.Key.讀出(PdfReader_, 頁索引_);
                if (string.IsNullOrEmpty(配送單號_))
                    return;

                訊息管理器.獨體.訊息("讀出配送單號:" + 配送單號_);

                var 符合資料列_ = _資料列舉.Where(Value => 配送單號_.Equals(Value.配送單號)).ToArray();
                if (符合資料列_.Length == 0)
                {
                    Pair_.Value.寫入(PCB_, "找不到符合的配送單號");
                    訊息管理器.獨體.通知("找不到符合的配送單號:" + 配送單號_);
                }
                else
                {
                    物品合併資料 物品合併資料_ = new 物品合併資料();
                    foreach(平台訂單新增資料 資料_ in 符合資料列_)
                        物品合併資料_.新增(資料_.商品, 資料_.數量);

                    Pair_.Value.寫入(PCB_, 物品合併資料_.ToString());
                }
            }
        }

        public void 測試(PdfReader PdfReader_, int 頁索引_, PdfContentByte PCB_)
        {
            foreach (var Pair_ in 設定資料書)
            {
                Pair_.Value.寫入(PCB_, 字串.多字測試);
            }
        }
    }
}
