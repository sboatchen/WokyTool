﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    class 平台訂單回單轉換_myfone : 可寫入介面_CSV
    {
        private static string 全速配 = "hct_s";
        private static string 宅配通 = "e_can_s";

        public string 分類 { get { return null; } }

        public string 分格號 { get { return ","; } }

        public string 密碼 { get { return null; } }

        public Encoding 編碼 { get { return Encoding.UTF8; } }

        private IEnumerable<平台訂單新增資料> _資料列舉;

        public 平台訂單回單轉換_myfone(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public void 寫入(CSVBuilder Builder_)
        {
            平台訂單新增資料 平台訂單新增資料_ = _資料列舉.DefaultIfEmpty(null).First();
            if (平台訂單新增資料_ == null)
                return;

            Builder_.加入標頭(平台訂單新增資料_.標頭);

            foreach (平台訂單新增資料 資料_ in _資料列舉)
            {
                string[] 輸出資料_ = 資料_.內容.深複製();

                switch (資料_.配送公司)
                {
                    case 列舉.配送公司.全速配:
                        輸出資料_[4] = 全速配;
                        break;
                    case 列舉.配送公司.宅配通:
                        輸出資料_[4] = 宅配通;
                        break;
                    default:
                        throw new Exception("平台訂單回單轉換_myfone 不支援配送公司 " + 資料_.配送公司.ToString());
                }

                輸出資料_[5] = 資料_.配送單號;

                Builder_.加入(輸出資料_);
            }
        }
    }
}
