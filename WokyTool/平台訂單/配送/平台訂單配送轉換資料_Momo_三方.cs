using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單配送轉換資料_Momo_三方 : 平台訂單配送轉換資料_超商
    {
        private static char[] 消費者資料拆分字元組 = new char[] { '\n', '/', '\r' };

        public class 三方讀出元件組
        {
            public PDF字串讀出元件 發票讀出元件;
            public PDF字串讀出元件 配送單號讀出元件;
            public PDF字串讀出元件 消費者讀出元件;
        }

        private static List<PDF拷貝元件> _拷貝資料列;
        public static List<PDF拷貝元件> 拷貝資料列
        {
            get
            {
                if (_拷貝資料列 == null)
                {
                    _拷貝資料列 = new List<PDF拷貝元件>();
                    _拷貝資料列.Add(new PDF拷貝元件(new Rectangle(0, 0, 600, 840), 0, 0));
                }
                return _拷貝資料列;
            }
        }

        private static Dictionary<三方讀出元件組, PDF字串寫入元件> _設定資料書;
        public static Dictionary<三方讀出元件組, PDF字串寫入元件> 設定資料書
        {
            get 
            {
                if (_設定資料書 == null)
                {
                    // 讀出 發票
                    // 寫入 物品組成
                    _設定資料書 = new Dictionary<三方讀出元件組, PDF字串寫入元件>();
                    _設定資料書.Add(new 三方讀出元件組
                    {
                        發票讀出元件 = new PDF字串讀出元件(new Rectangle(80, 515, 130, 525)),
                        配送單號讀出元件 = new PDF字串讀出元件(new Rectangle(75, 695, 150, 710)),
                        消費者讀出元件 = new PDF字串讀出元件(new Rectangle(70, 640, 280, 680))
                    }, new PDF字串寫入元件(new Rectangle(5, 562, 295, 603), 常數.通用字體));    //465 ct.SetSimpleColumn(myText, 290, WritePosY_ + 20, 520, WritePosY_ - 100, 15, Element.ALIGN_TOP);

                    _設定資料書.Add(new 三方讀出元件組
                    {
                        發票讀出元件 = new PDF字串讀出元件(new Rectangle(80, 80, 130, 90)),
                        配送單號讀出元件 = new PDF字串讀出元件(new Rectangle(75, 265, 100, 280)),
                        消費者讀出元件 = new PDF字串讀出元件(new Rectangle(70, 200, 280, 250))
                    }, new PDF字串寫入元件(new Rectangle(5, 562, 295, 603), 常數.通用字體));    //30 ct.SetSimpleColumn(myText, 290, WritePosY_ + 20, 520, WritePosY_ - 100, 15, Element.ALIGN_TOP);
                }

                return _設定資料書;
            }
        }

        public override string 標頭 { get { return "請提供 Momo 三方 配送原始檔"; } }

        public override string 密碼 { get { return "27723845t"; } }

        public 平台訂單配送轉換資料_Momo_三方(List<平台訂單新增資料> 來源資料列_)
            : base(來源資料列_)
        {
            轉換.配送公司 = 列舉.配送公司.三方;
        }

        public override void 寫入(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_)
        {
            foreach (PDF拷貝元件 拷貝資料_ in 拷貝資料列)
            {
                拷貝資料_.處理(PdfReader_, 頁索引_, PdfWriter_);
            }

            foreach (var Pair_ in 設定資料書)
            {
                string 發票號碼_ = Pair_.Key.發票讀出元件.處理(PdfReader_, 頁索引_);
                if(string.IsNullOrEmpty(發票號碼_))
                    return;

                發票號碼_ = 發票號碼_.Substring(7);
                Console.WriteLine("發票號碼 " + 發票號碼_);

                this.配送單號 = Pair_.Key.配送單號讀出元件.處理(PdfReader_, 頁索引_).Substring(5);
                Console.WriteLine("配送單號 " + 配送單號);

                // 取得消費者資料
                string 消費者資料字串_ = Pair_.Key.消費者讀出元件.處理(PdfReader_, 頁索引_);
                string[] 消費者資料_ = 消費者資料字串_.ToString().Split(消費者資料拆分字元組);
                this.地址 = 消費者資料_[0];
                this.電話 = 消費者資料_[1];
                this.手機 = 消費者資料_[2];
                this.姓名 = 消費者資料_[3];
                Console.WriteLine("消費者:{0},{1},{2},{3}", this.姓名, this.地址, this.電話, this.手機);

                var 符合資料列_ = 來源資料列.Where(Value => 發票號碼_.Equals(Value.發票號碼) && Value.處理狀態 == 列舉.訂單處理狀態.新增).ToArray();
                if (符合資料列_.Length == 0)
                {
                    Pair_.Value.處理(PdfWriter_, "找不到符合的發票號碼");
                    訊息管理器.獨體.通知("找不到符合的發票號碼:" + 發票號碼_);
                }
                else
                {
                    var 分組群_ =  符合資料列_.GroupBy(Value => Value.配送分組);
                    if(分組群_.Count() > 1)
                        訊息管理器.獨體.警告("找到多個同發票號碼的組別，請注意: " + 名字_);

                    物品合併資料 物品合併資料_ = new 物品合併資料();
                    foreach (平台訂單新增資料 資料_ in 符合資料列_)
                    {
                        物品合併資料_.新增(資料_);

                        姓名 = 名字_;
                        電話 = 電話_;
                        手機 = 手機_;
                        地址 = 地址_;
                        配送單號 = 配送單號_;
                        資料_.處理狀態 = 列舉.訂單處理狀態.配送;

                        資料_.
                    }
                        物品合併資料_.新增(資料_);

                    Pair_.Value.處理(PdfWriter_, 物品合併資料_.ToString());
                }
            }
        }

        public override void 測試(PdfReader PdfReader_, int 頁索引_, PdfWriter PdfWriter_)
        {
            /*foreach (PDF拷貝元件 拷貝資料_ in 拷貝資料列)
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
            }*/
        }
    }
}
