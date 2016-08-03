using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataMgr;

namespace WokyTool.Data
{
    public class 商品資料
    {
        [CsvColumn(Name = "編號")]
        public int 編號 { get; set; }
        [CsvColumn(Name = "開啟")]
        public bool 開啟 { get; set; }

        public 商品大類資料 大類;
        [CsvColumn(Name = "大類編號")]
        public int 大類編號
        {
            get
            {
                return 大類.編號;
            }
            set
            {
                大類 = 商品大類管理器.Instance.Get(value);
            }
        }

        public 商品小類資料 小類;
        [CsvColumn(Name = "小類編號")]
        public int 小類編號
        {
            get
            {
                return 小類.編號;
            }
            set
            {
                小類 = 商品小類管理器.Instance.Get(value);
            }
        }

        [CsvColumn(Name = "品號")]
        public string 品號 { get; set; }  // 對方使用的產品編號
        [CsvColumn(Name = "名稱")]
        public string 名稱 { get; set; }  // 對方使用的產品名稱

        public 廠商資料 廠商;
        [CsvColumn(Name = "廠商編號")]
        public int 廠商編號
        {
            get
            {
                return 廠商.編號;
            }
            set
            {
                廠商 = 廠商管理器.Instance.Get(value);
            }
        }

        public 物品資料 需求1 = 物品資料.NULL;
        [CsvColumn(Name = "需求編號1")]
        public int 需求編號1
        {
            get
            {
                return 需求1.編號;
            }
            set
            {
                需求1 = 物品管理器.Instance.Get(value);
            }
        }

        public 物品資料 需求2 = 物品資料.NULL;
        [CsvColumn(Name = "需求編號2")]
        public int 需求編號2
        {
            get
            {
                return 需求2.編號;
            }
            set
            {
                需求2 = 物品管理器.Instance.Get(value);
            }
        }

        public 物品資料 需求3 = 物品資料.NULL;
        [CsvColumn(Name = "需求編號3")]
        public int 需求編號3
        {
            get
            {
                return 需求3.編號;
            }
            set
            {
                需求3 = 物品管理器.Instance.Get(value);
            }
        }

        public 物品資料 需求4 = 物品資料.NULL;
        [CsvColumn(Name = "需求編號4")]
        public int 需求編號4
        {
            get
            {
                return 需求4.編號;
            }
            set
            {
                需求4 = 物品管理器.Instance.Get(value);
            }
        }

        public 物品資料 需求5 = 物品資料.NULL;
        [CsvColumn(Name = "需求編號5")]
        public int 需求編號5
        {
            get
            {
                return 需求5.編號;
            }
            set
            {
                需求5 = 物品管理器.Instance.Get(value);
            }
        }

        [CsvColumn(Name = "數量1")]
        public int 數量1 { get; set; }
        [CsvColumn(Name = "數量2")]
        public int 數量2 { get; set; }
        [CsvColumn(Name = "數量3")]
        public int 數量3 { get; set; }
        [CsvColumn(Name = "數量4")]
        public int 數量4 { get; set; }
        [CsvColumn(Name = "數量5")]
        public int 數量5 { get; set; }

        [CsvColumn(Name = "價格")]
        public int 價格 { get; set; }

        // 成本
        public int 成本
        {
            get
            {
                return 需求1.成本 * 數量1 + 需求2.成本 * 數量2 + 需求3.成本 * 數量3 + 需求4.成本 * 數量4 + 需求5.成本 * 數量5;
            }
        }

        // 體積
        public int 體積
        {
            get
            {
                return 需求1.體積 * 數量1 + 需求2.體積 * 數量2 + 需求3.體積 * 數量3 + 需求4.體積 * 數量4 + 需求5.體積 * 數量5;
            }
        }

        // 利潤
        public int 利潤
        {
            get
            {
                return 價格 - 成本;
            }
        }

        public static 商品資料 New()
        {
            return new 商品資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編碼類型.商品),
                開啟 = false,
                大類 = 商品大類資料.NULL,
                小類 = 商品小類資料.NULL,
                品號 = string.Empty,
                名稱 = string.Empty,
                廠商 = 廠商資料.NULL,
                需求1 = 物品資料.NULL,
                需求2 = 物品資料.NULL,
                需求3 = 物品資料.NULL,
                需求4 = 物品資料.NULL,
                需求5 = 物品資料.NULL,
                數量1 = 0,
                數量2 = 0,
                數量3 = 0,
                數量4 = 0,
                數量5 = 0,
                價格 = 0,
            };
        }

        private static readonly 商品資料 _NULL = new 商品資料
        {
            編號 = 0,
            開啟 = false,
            名稱 = 字串.無,

            大類 = 商品大類資料.NULL,
            小類 = 商品小類資料.NULL,

            廠商 = 廠商資料.NULL,
        };
        public static 商品資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 商品資料 _ERROR = new 商品資料
        {
            編號 = -1,
            開啟 = false,
            名稱 = 字串.錯誤,

            大類 = 商品大類資料.ERROR,
            小類 = 商品小類資料.ERROR,

            廠商 = 廠商資料.ERROR,
        };
        public static 商品資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public void GetCombine(Dictionary<String, int> 物品列表_, int 總數量_)
        {
            do
            {
                if (需求編號1 <= 0)
                    break;
                if(物品列表_.ContainsKey(需求1.縮寫))
                    物品列表_[需求1.縮寫] += 數量1 * 總數量_;
                else
                    物品列表_[需求1.縮寫] = 數量1 * 總數量_;

                if (需求編號2 <= 0)
                    break;
                if (物品列表_.ContainsKey(需求2.縮寫))
                    物品列表_[需求2.縮寫] += 數量2 * 總數量_;
                else
                    物品列表_[需求2.縮寫] = 數量2 * 總數量_;

                if (需求編號3 <= 0)
                    break;
                if (物品列表_.ContainsKey(需求3.縮寫))
                    物品列表_[需求3.縮寫] += 數量3 * 總數量_;
                else
                    物品列表_[需求3.縮寫] = 數量3 * 總數量_;

                if (需求編號4 <= 0)
                    break;
                if (物品列表_.ContainsKey(需求4.縮寫))
                    物品列表_[需求4.縮寫] += 數量4 * 總數量_;
                else
                    物品列表_[需求4.縮寫] = 數量4 * 總數量_;

                if (需求編號5 <= 0)
                    break;
                if (物品列表_.ContainsKey(需求5.縮寫))
                    物品列表_[需求5.縮寫] += 數量5 * 總數量_;
                else
                    物品列表_[需求5.縮寫] = 數量5 * 總數量_;

            } while (false);
        }
    }
}
