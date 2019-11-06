using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單配送轉換資料_蝦皮_SEVEN : 平台訂單配送轉換資料_超商
    {
        private class 讀出元件組
        {
            public PDF字串讀出元件 配送單號讀出元件;
            public PDF字串讀出元件 消費者讀出元件;
        }

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

        private static Dictionary<讀出元件組, PDF字串寫入元件> _設定資料書;
        private static Dictionary<讀出元件組, PDF字串寫入元件> 設定資料書
        {
            get 
            {
                if (_設定資料書 == null)
                {
                    // 讀出 配送單號
                    // 寫入 物品組成
                    _設定資料書 = new Dictionary<讀出元件組, PDF字串寫入元件>();
                    _設定資料書.Add(new 讀出元件組
                    {
                        配送單號讀出元件 = new PDF字串讀出元件(new Rectangle(160, 720, 240, 740)),
                        消費者讀出元件 = new PDF字串讀出元件(new Rectangle(170, 740, 260, 765))
                    }, new PDF字串寫入元件(new Rectangle(5, 562, 295, 610), 常數.通用字體));
                    _設定資料書.Add(new 讀出元件組
                    {
                        配送單號讀出元件 = new PDF字串讀出元件(new Rectangle(420, 720, 500, 740)),
                        消費者讀出元件 = new PDF字串讀出元件(new Rectangle(420, 740, 520, 765))
                    }, new PDF字串寫入元件(new Rectangle(305, 562, 595, 610), 常數.通用字體));
                    _設定資料書.Add(new 讀出元件組
                    {
                        配送單號讀出元件 = new PDF字串讀出元件(new Rectangle(160, 465, 240, 485)),
                        消費者讀出元件 = new PDF字串讀出元件(new Rectangle(170, 485, 260, 510))
                    }, new PDF字串寫入元件(new Rectangle(5, 285, 295, 330), 常數.通用字體));
                    _設定資料書.Add(new 讀出元件組
                    {
                        配送單號讀出元件 = new PDF字串讀出元件(new Rectangle(420, 465, 500, 485)),
                        消費者讀出元件 = new PDF字串讀出元件(new Rectangle(420, 485, 520, 510))
                    }, new PDF字串寫入元件(new Rectangle(305, 285, 595, 330), 常數.通用字體));
                    _設定資料書.Add(new 讀出元件組
                    {
                        配送單號讀出元件 = new PDF字串讀出元件(new Rectangle(160, 210, 240, 230)),
                        消費者讀出元件 = new PDF字串讀出元件(new Rectangle(170, 230, 260, 255))
                    }, new PDF字串寫入元件(new Rectangle(5, 0, 295, 45), 常數.通用字體));
                    _設定資料書.Add(new 讀出元件組
                    {
                        配送單號讀出元件 = new PDF字串讀出元件(new Rectangle(420, 210, 500, 230)),
                        消費者讀出元件 = new PDF字串讀出元件(new Rectangle(420, 230, 520, 255))
                    }, new PDF字串寫入元件(new Rectangle(305, 0, 595, 45), 常數.通用字體));
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
                string 配送單號_ = Pair_.Key.配送單號讀出元件.處理(PdfReader_, 頁索引_);
                if (string.IsNullOrEmpty(配送單號_))
                    return;

                配送單號_ = 整理字串(配送單號_);

                訊息管理器.獨體.訊息("讀出配送單號:" + 配送單號_);

                string 消費者_ = Pair_.Key.消費者讀出元件.處理(PdfReader_, 頁索引_);

                消費者_ = 整理字串(消費者_);

                訊息管理器.獨體.訊息("消費者:" + 消費者_);

                var 符合資料列_ = 來源資料列.Where(Value => 配送單號_.Equals(Value.配送單號)).ToArray();
                if (符合資料列_.Length == 0)
                {
                    Pair_.Value.處理(PdfWriter_, "找不到符合的配送單號");
                    訊息管理器.獨體.通知("找不到符合的配送單號:" + 配送單號_);
                }
                else
                {
                    物品合併資料 物品合併資料_ = new 物品合併資料();
                    foreach (平台訂單新增資料 資料_ in 符合資料列_)
                    {
                        物品合併資料_.新增(資料_);

                        資料_.BeginEdit();
                        資料_.姓名 = 消費者_;
                    }

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

            foreach (var Pair_ in 設定資料書)
            {
                string 配送單號_ = Pair_.Key.配送單號讀出元件.處理(PdfReader_, 頁索引_);
                if (string.IsNullOrEmpty(配送單號_))
                    return;

                配送單號_ = 整理字串(配送單號_);

                訊息管理器.獨體.訊息("讀出配送單號:" + 配送單號_);

                string 消費者_ = Pair_.Key.消費者讀出元件.處理(PdfReader_, 頁索引_);

                消費者_ = 整理字串(消費者_);

                訊息管理器.獨體.訊息("消費者:" + 消費者_);

                Pair_.Value.處理(PdfWriter_, 字串.多字測試);
            }
        }

        private static char[] _切割列 = new char[] { ':', '：' };
        private string 整理字串(string 字串_)
        { 
            if(string.IsNullOrEmpty(字串_))
                return 字串_;

            int 切割位置_ = 字串_.LastIndexOfAny(_切割列);
            if (切割位置_ != -1)
                字串_ = 字串_.Substring(切割位置_ + 1);

            if(字串_.Length % 2 != 0)
                return 字串_;

            StringBuilder 新字串_ = new StringBuilder();
            for (int i = 0; i < 字串_.Length; i += 2)
            {
                if (字串_[i].Equals(字串_[i + 1]) == false)
                    return 字串_;
                新字串_.Append(字串_[i]);
            }

            return 新字串_.ToString();
        }
    }
}
