using System.Collections.Generic;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public class 盤點更新轉換_大料架 : 可讀出介面_EXCEL<盤點更新資料>
    {
        public int 分頁索引 { get { return 1; } }

        public string 分頁名稱 { get { return null; } }

        public int 標頭索引 { get { return 2; } }

        public int 資料開始索引 { get { return 3; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        protected string[] _標頭列;

        public 盤點更新轉換_大料架()
        {
        }

        public void 讀出檔名(string 檔名_)
        {
        }

        public void 讀出標頭(string[] 標頭列_)
        {
            this._標頭列 = 標頭列_;
        }

        public void 讀出額外資訊(int 索引_, string[] 資料列_)
        {
        }

        public IEnumerable<盤點更新資料> 讀出資料(string[] 資料列_)
        {
            string 貨架號_ = 資料列_[0];
            if (string.IsNullOrEmpty(貨架號_))
                yield break;

            for (int 單品索引_ = 1; 單品索引_ < 資料列_.Length; 單品索引_ += 4)
            {
                string 單品識別_ = 資料列_[單品索引_].轉成字串();
                if (string.IsNullOrEmpty(單品識別_))
                    continue;

                int 數量_ = 資料列_[單品索引_+3].轉成整數();
                if (數量_ == 0)
                    continue;

                盤點更新資料 資料_ = new 盤點更新資料();
                資料_.單品識別 = 單品識別_;
                資料_.大料架庫存 = 數量_;

                //Console.WriteLine(資料_.ToString(false));

                yield return 資料_;
            }
        }
    }
}
