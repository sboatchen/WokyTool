using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Linq;
using WokyTool.單品;
using WokyTool.通用;
using System;

namespace WokyTool.平台訂單
{
    public class 平台訂單配送轉換資料_蝦皮_SEVEN : 平台訂單配送轉換資料_超商
    {
        private static List<PDF拷貝元件> _拷貝資料列;
        private static List<PDF拷貝元件> 拷貝資料列
        {
            get
            {
                if (_拷貝資料列 == null)
                {
                    _拷貝資料列 = new List<PDF拷貝元件>();
                    _拷貝資料列.Add(new PDF拷貝元件(new Rectangle(0, 60, 595, 290), 0, -15));
                    _拷貝資料列.Add(new PDF拷貝元件(new Rectangle(0, 320, 595, 545), 0, 15));
                    _拷貝資料列.Add(new PDF拷貝元件(new Rectangle(0, 570, 595, 800), 0, 40));
                }

                return _拷貝資料列;
            }
        }

        private static Dictionary<PDF字串讀出元件, PDF字串寫入元件> _設定資料書;
        private static Dictionary<PDF字串讀出元件, PDF字串寫入元件> 設定資料書
        {
            get 
            {
                if (_設定資料書 == null)
                {
                    // 讀出 配送單號
                    // 寫入 單品組成
                    _設定資料書 = new Dictionary<PDF字串讀出元件, PDF字串寫入元件>();
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(50, 750, 220, 800)) , new PDF字串寫入元件(new Rectangle(5, 562, 295, 610), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(330, 750, 500, 800)), new PDF字串寫入元件(new Rectangle(305, 562, 595, 610), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(50, 485, 220, 535)), new PDF字串寫入元件(new Rectangle(5, 285, 295, 330), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(330, 485, 500, 535)), new PDF字串寫入元件(new Rectangle(305, 285, 595, 330), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(50, 215, 220, 265)), new PDF字串寫入元件(new Rectangle(5, 0, 295, 45), 常數.通用字體));
                    _設定資料書.Add(new PDF字串讀出元件(new Rectangle(330, 215, 500, 265)), new PDF字串寫入元件(new Rectangle(305, 0, 595, 45), 常數.通用字體));
                }

                return _設定資料書;
            }
        }

        public override string 標頭 { get { return "請提供 蝦皮 Seven 配送原始檔"; } }

        public override string 密碼 { get { return null; } }

        public 平台訂單配送轉換資料_蝦皮_SEVEN(List<平台訂單新增資料> 來源資料列_)
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
                string 內容_ = Pair_.Key.處理(PdfReader_, 頁索引_);
                if (string.IsNullOrEmpty(內容_))
                    return;

                string[] 內容列_ = 內容_.Split(內容切割, StringSplitOptions.RemoveEmptyEntries);

                string 配送單號_ = (內容列_.Length == 4) ? 內容列_[3].Trim() : 內容列_[2].Split(配送切割)[1].Trim();
                string 消費者_ = 內容列_[0].Trim();


                訊息管理器.獨體.訊息("配送單號:" + 配送單號_);
                訊息管理器.獨體.訊息("消費者:" + 消費者_);

                var 符合資料列_ = 來源資料列.Where(Value => 配送單號_.Equals(Value.配送單號)).ToArray();
                if (符合資料列_.Length == 0)
                {
                    Pair_.Value.處理(PdfWriter_, "找不到符合的配送單號");
                    訊息管理器.獨體.通知("找不到符合的配送單號:" + 配送單號_);
                }
                else
                {
                    單品合併資料 單品合併資料_ = new 單品合併資料();
                    foreach (平台訂單新增資料 資料_ in 符合資料列_)
                    {
                        單品合併資料_.新增(資料_);

                        資料_.BeginEdit();
                        資料_.姓名 = 消費者_;
                    }

                    //Pair_.Value.處理(PdfWriter_, 單品合併資料_.ToString());   // 目前沒位置可以寫
                }
            }
        }

        private char[] 內容切割 = new char[] { '\r','\n' };
        private char[] 配送切割 = new char[] { ':', '：' };
        public override void 測試(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_)
        {
            foreach (PDF拷貝元件 拷貝資料_ in 拷貝資料列)
            {
                拷貝資料_.處理(PdfReader_, 頁索引_, PdfWriter_);
            }

            foreach (var Pair_ in 設定資料書)
            {
                string 內容_ = Pair_.Key.處理(PdfReader_, 頁索引_);
                if (string.IsNullOrEmpty(內容_))
                    return;

                string[] 內容列_ = 內容_.Split(內容切割, StringSplitOptions.RemoveEmptyEntries);

                string 配送單號_ = (內容列_.Length == 4) ? 內容列_[3].Trim() : 內容列_[2].Split(配送切割)[1].Trim();
                string 消費者_ = 內容列_[0].Trim();


                訊息管理器.獨體.訊息("配送單號:" + 配送單號_);
                訊息管理器.獨體.訊息("消費者:" + 消費者_);

                //Pair_.Value.處理(PdfWriter_, 字串.多字測試);
            }
        }
    }
}
