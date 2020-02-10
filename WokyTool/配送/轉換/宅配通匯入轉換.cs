using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 宅配通匯入轉換 : 可讀出介面_EXCEL<配送轉換資料>
    {
        public int 分頁索引 { get { return 1; } }

        public string 分頁名稱 { get { return null; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<配送轉換資料> _資料列舉;

        public 宅配通匯入轉換(IEnumerable<配送轉換資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 讀出檔名(string 檔名_)
        {
        }

        public void 讀出標頭(string[] 標頭列_)
        {
        }

        public void 讀出額外資訊(int 索引_, string[] 資料列_)
        {
        }

        public IEnumerable<配送轉換資料> 讀出資料(string[] 資料列_)
        {
            string 姓名_ = 資料列_[4];
            string 配送單號_ = 資料列_[1];

            配送轉換資料 資料_ = _資料列舉.Where(Value => string.IsNullOrEmpty(Value.配送單號) && 姓名_.Equals(Value.姓名)).FirstOrDefault();
            if (資料_ == null)
            {
                訊息管理器.獨體.錯誤("找不到配送資料, 姓名:" + 姓名_);
                yield break;
            }

            資料_.配送單號 = 配送單號_;

            yield return 資料_;
        }

        public static void 轉換(IEnumerable<配送轉換資料> 資料列舉_, string 資料_)
        {
            string[] 資料列_ = 資料_.Split('\n');
            for (int i = 1; i < 資料列_.Length; i++)
            {
                string[] 欄位列_ = 資料列_[i].Split(' ', 'r').Where(Value => !string.IsNullOrEmpty(Value)).ToArray();
                if(欄位列_.Length < 5)
                    break;

                string 姓名_ = 欄位列_[4];
                string 配送單號_ = 欄位列_[1];

                配送轉換資料 配送轉換資料_ = 資料列舉_.Where(Value => string.IsNullOrEmpty(Value.配送單號) && 姓名_.Equals(Value.姓名)).FirstOrDefault();
                if (配送轉換資料_ == null)
                    訊息管理器.獨體.錯誤("找不到配送資料, 姓名:" + 姓名_);
                else
                    配送轉換資料_.配送單號 = 配送單號_;
            }
        }
    }
}

