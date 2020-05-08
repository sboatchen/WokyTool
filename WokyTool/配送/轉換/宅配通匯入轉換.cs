using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 宅配通匯入轉換
    {
        /*
         * 範例
         * 項次 宅配單號 件數 出貨單號 收件人 代收款 作廢
             1  078120058085 1 咖啡展 邱金順 - -
             2  078120058096 1 咖啡展 吳小姐 - -
             3  078120058100 1 咖啡展 莊岳翰 - -
             4  078120058111 1 咖啡展 何宜軒 - -
             5  078120058122 1 咖啡展 何宗翰 - -
             6  078120058133 1
         * 
         */
        public static void 轉換(IEnumerable<配送轉換資料> 資料列舉_, string 資料_)
        {
            string[] 資料列_ = 資料_.Split('\n').Select(Value => Value.Trim()).Where(Value => String.IsNullOrEmpty(Value) == false).ToArray();
            for (int i = 1; i < 資料列_.Length; i++)
            {
                string[] 欄位列_ = 資料列_[i].Split(' ', '\t').Select(Value => Value.Trim()).Where(Value => String.IsNullOrEmpty(Value) == false).ToArray();
                if (欄位列_.Length <= 5)
                {
                    訊息管理器.獨體.通知("匯入資料:" + 資料列_[i] + "無法處理");
                    continue;
                }

                string 姓名_ = 欄位列_[4];
                string 訂單編號_ = 欄位列_[3];
                string 配送單號_ = 欄位列_[1];

                訊息管理器.獨體.訊息(姓名_ + ":" + 配送單號_);

                配送轉換資料 配送轉換資料_ = 資料列舉_.Where(Value => string.IsNullOrEmpty(Value.配送單號) && (訂單編號_.Equals(Value.訂單編號) || 姓名_.Equals(Value.姓名))).FirstOrDefault();
                if (配送轉換資料_ == null)
                    訊息管理器.獨體.錯誤("找不到配送資料, 姓名:" + 姓名_);
                else
                    配送轉換資料_.配送單號 = 配送單號_;
            }
        }
    }
}

