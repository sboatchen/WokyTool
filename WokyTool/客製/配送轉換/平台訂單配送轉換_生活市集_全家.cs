using IronOcr;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.客製
{
    public class 平台訂單配送轉換_生活市集_全家 : 可寫入介面_PDF
    {
        private static List<PDF清除元件> _清除資料列;
        public static List<PDF清除元件> 清除資料列
        {
            get
            {
                if (_清除資料列 == null)
                {
                    _清除資料列 = new List<PDF清除元件>();
                    _清除資料列.Add(new PDF清除元件(new Rectangle(10, 790, 590, 840)));
                    _清除資料列.Add(new PDF清除元件(new Rectangle(10, 0, 590, 25)));
                }

                return _清除資料列;
            }
        }

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
                    _設定資料書.Add(new PDF圖片字串讀出元件(new System.Drawing.Rectangle(435, 200, 265, 50)), new PDF字串寫入元件(new Rectangle(10, 785, 290, 840), 常數.通用字體));
                    _設定資料書.Add(new PDF圖片字串讀出元件(new System.Drawing.Rectangle(1685, 200, 265, 50)), new PDF字串寫入元件(new Rectangle(310, 785, 590, 840), 常數.通用字體));
                    _設定資料書.Add(new PDF圖片字串讀出元件(new System.Drawing.Rectangle(435, 1940, 265, 50)), new PDF字串寫入元件(new Rectangle(10, 0, 290, 50), 常數.通用字體));
                    _設定資料書.Add(new PDF圖片字串讀出元件(new System.Drawing.Rectangle(1685, 1940, 265, 50)), new PDF字串寫入元件(new Rectangle(310, 0, 590, 50), 常數.通用字體));
                }

                return _設定資料書;
            }
        }

        public string 密碼 { get { return null; } }

        public double X位移 { get { return 0; } }
        public double Y位移 { get { return -20; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單配送轉換_生活市集_全家(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(PdfReader PdfReader_, int 頁索引_, PdfContentByte PCB_)
        {
            foreach (var 資料_ in 清除資料列)
            {
                資料_.寫入(PCB_);
            }

            foreach (var Pair_ in 設定資料書)
            {
                string 訂單編號_ = Pair_.Key.讀出(PdfReader_, 頁索引_);
                if (string.IsNullOrEmpty(訂單編號_))
                    return;

                訊息管理器.獨體.訊息("讀出訂單編號:" + 訂單編號_);

                var 符合資料列_ = _資料列舉.Where(Value => 訂單編號_.Equals(Value.訂單編號)).ToArray();
                if (符合資料列_.Length == 0)
                {
                    Pair_.Value.寫入(PCB_, "找不到符合的訂單編號");
                    訊息管理器.獨體.通知("找不到符合的訂單編號:" + 訂單編號_);
                }
                else
                {
                    物品合併資料 物品合併資料_ = new 物品合併資料();
                    foreach (平台訂單新增資料 資料_ in 符合資料列_)
                        物品合併資料_.新增(資料_.商品, 資料_.數量);

                    Pair_.Value.寫入(PCB_, 物品合併資料_.ToString());
                }
            }
        }

        public void 測試(PdfReader PdfReader_, int 頁索引_, PdfContentByte PCB_)
        {
            foreach (var 資料_ in 清除資料列)
            {
                資料_.寫入(PCB_);
            }

            foreach (var Pair_ in 設定資料書)
            {
                Pair_.Value.寫入(PCB_, 字串.多字測試);
            }
        }
    }
}
