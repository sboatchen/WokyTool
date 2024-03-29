﻿using System;
using System.Linq;
using System.Text;
using WokyTool.通用;

namespace WokyTool.單品
{
    // 輸出
    // 條碼號, 商品描述, 0
    public class 單品盤點匯出轉換 : 可寫入介面_CSV
    {
        public string 分類 { get { return null; } }

        public string 分格號 { get { return ","; } }

        public string 密碼 { get { return null; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        //條碼號, 商品描述, 0

        public 單品盤點匯出轉換()
        {
        }

        public void 寫入(CSVBuilder Builder_)
        {
            Builder_.加入標頭("條碼號", "商品描述", "類型");

            var Queqe_ = 單品資料管理器.獨體.資料列舉2.Where(Value => (Value.編號 > 0) && (String.IsNullOrEmpty(Value.國際條碼) == false));

            foreach (單品資料 資料_ in Queqe_)
            {
                Builder_.加入(
                    String.Format("{0:0000000000000}", 資料_.國際條碼),
                    資料_.縮寫,
                    0
                );
            }
        }
    }
}
