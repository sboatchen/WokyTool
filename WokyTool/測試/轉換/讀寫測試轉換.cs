using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.測試
{
    public class 讀寫測試轉換 : 可寫入_CSV, 可讀出_CSV<讀寫測試資料>
    {
        private static int 測試編號_ = 0;
        private static string 分格號_ = ",";

        protected IEnumerable<讀寫測試資料> _資料列;

        public String 分類 { get; set; }

        public 讀寫測試轉換()
        {
            測試編號_++;
            分類 = "測試編號" + 測試編號_;

            List<讀寫測試資料> 資料列_ = new List<讀寫測試資料>();
            for(int i = 0 ; i < 5 ; i++){
                資料列_.Add(new 讀寫測試資料{
                    字串 = 分類 + "," + i,
                    整數 = i,
                    浮點數 = (float)(i / 1000.0),
                    倍精準浮點數 = (float)(i / 1000.0),
                    時間 = DateTime.Now,
                    列舉 = (列舉.編號)i,
                });
            }

            // 空資料
            資料列_.Add(new 讀寫測試資料());

            _資料列 = 資料列_;
        }

        public void 寫入(StringBuilder SB_)
        {
            SB_.Append("字串").Append(分格號_)
                .Append("整數").Append(分格號_)
                .Append("浮點數").Append(分格號_)
                .Append("倍精準浮點數").Append(分格號_)
                .Append("時間").Append(分格號_)
                .Append("列舉").Append(分格號_);
            SB_.AppendLine();

            foreach (讀寫測試資料 資料_ in _資料列)
            {
                SB_.Append("\"").Append(資料_.字串).Append("\"").Append(分格號_)
                    .Append(資料_.整數).Append(分格號_)
                    .Append(資料_.浮點數).Append(分格號_)
                    .Append(資料_.倍精準浮點數).Append(分格號_)
                    .Append(資料_.時間).Append(分格號_)
                    .Append(資料_.列舉).Append(分格號_);
                SB_.AppendLine();
            }
        }

        public List<讀寫測試資料> 讀出(String 內容_)
        {
            return null;
        }
    }
}
