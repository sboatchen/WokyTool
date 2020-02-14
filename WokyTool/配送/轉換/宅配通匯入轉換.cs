using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 宅配通匯入轉換
    {
        public static void 轉換(IEnumerable<配送轉換資料> 資料列舉_, string 資料_)
        {
            string[] 資料列_ = 資料_.Split('\n');
            for (int i = 1; i < 資料列_.Length; i++)
            {
                string[] 欄位列_ = 資料列_[i].Split('-').Select(Value => Value.Trim()).Where(Value => String.IsNullOrEmpty(Value) == false).ToArray();
                if(欄位列_.Length < 2)
                    continue;

                string 姓名_ = 欄位列_[1];
                string 配送單號_ = 欄位列_[0].Split(' ', '\t').Where(Value => String.IsNullOrEmpty(Value) == false).ToArray()[1];

                訊息管理器.獨體.訊息(姓名_ + ":" + 配送單號_);

                配送轉換資料 配送轉換資料_ = 資料列舉_.Where(Value => string.IsNullOrEmpty(Value.配送單號) && 姓名_.Equals(Value.姓名)).FirstOrDefault();
                if (配送轉換資料_ == null)
                    訊息管理器.獨體.錯誤("找不到配送資料, 姓名:" + 姓名_);
                else
                    配送轉換資料_.配送單號 = 配送單號_;
            }
        }
    }
}

