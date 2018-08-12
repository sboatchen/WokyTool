using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.DataImport
{
    class 商品匯入結構
    {
        public string 品號 { get; set; }
        public string 名稱 { get; set; }

        public string 大類名稱 { get; set; }
        public string 小類名稱 { get; set; }

        public string 公司名稱 { get; set; }
        public string 廠商名稱 { get; set; }

        public string 需求名稱1 { get; set; }
        public string 需求名稱2 { get; set; }
        public string 需求名稱3 { get; set; }
        public string 需求名稱4 { get; set; }
        public string 需求名稱5 { get; set; }

        public int 數量1 { get; set; }
        public int 數量2 { get; set; }
        public int 數量3 { get; set; }
        public int 數量4 { get; set; }
        public int 數量5 { get; set; }

        public int 價格 { get; set; }

        /**************************************************/

        public 商品大類資料 大類;
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

        public 公司資料 公司;
        public int 公司編號
        {
            get
            {
                return 公司.編號;
            }
            set
            {
                公司 = 公司管理器.Instance.Get(value);
            }
        }

        public 廠商資料 廠商;
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

        public 物品資料 需求1;
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

        public 物品資料 需求2;
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

        public 物品資料 需求3;
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

        public 物品資料 需求4;
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

        public 物品資料 需求5;
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

        // 資料初始化
        public void Init()
        {
            大類 = 商品大類管理器.Instance.Get(大類名稱);
            小類 = 商品小類管理器.Instance.Get(小類名稱);

            公司 = 公司管理器.Instance.Get(公司名稱);
            廠商 = 廠商管理器.Instance.Get(廠商名稱);

            需求1 = 物品管理器.Instance.GetBySName(需求名稱1);
            需求2 = 物品管理器.Instance.GetBySName(需求名稱2);
            需求3 = 物品管理器.Instance.GetBySName(需求名稱3);
            需求4 = 物品管理器.Instance.GetBySName(需求名稱4);
            需求5 = 物品管理器.Instance.GetBySName(需求名稱5);
        }

        public static 商品匯入結構 New()
        {
            return new 商品匯入結構
            {
                品號 = 字串.空,
                名稱 = 字串.空,

                大類名稱 = 字串.空,
                小類名稱 = 字串.空,

                公司名稱 = 字串.空,
                廠商名稱 = 字串.空,

                需求名稱1 = 字串.空,
                需求名稱2 = 字串.空,
                需求名稱3 = 字串.空,
                需求名稱4 = 字串.空,
                需求名稱5 = 字串.空,

                數量1 = 0,
                數量2 = 0,
                數量3 = 0,
                數量4 = 0,
                數量5 = 0,

                價格 = 0,

                大類 = 商品大類資料.NULL,
                小類 = 商品小類資料.NULL,
                公司 = 公司資料.NULL,
                廠商 = 廠商資料.NULL,

                需求1 = 物品資料.NULL,
                需求2 = 物品資料.NULL,
                需求3 = 物品資料.NULL,
                需求4 = 物品資料.NULL,
                需求5 = 物品資料.NULL,
            };
        }

        // 字串化
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        // 資料是否合法
        public bool IsLegal()
        {
            //@@ 這邊要調整 至少要有需求1
            bool IsError_ = 公司編號 == -1 ||
                            廠商編號 == -1 ||
                            大類編號 == -1 ||
                            小類編號 == -1 ||
                            需求編號1 == -1 || (需求編號1 == 0 && 數量1 > 0 ) || (需求編號1 > 0 && 數量1 == 0 ) ||
                            需求編號2 == -1 || (需求編號2 == 0 && 數量2 > 0 ) || (需求編號2 > 0 && 數量2 == 0 ) ||
                            需求編號3 == -1 || (需求編號3 == 0 && 數量3 > 0 ) || (需求編號3 > 0 && 數量3 == 0 ) ||
                            需求編號4 == -1 || (需求編號4 == 0 && 數量4 > 0 ) || (需求編號4 > 0 && 數量4 == 0 ) ||
                            需求編號5 == -1 || (需求編號5 == 0 && 數量5 > 0 ) || (需求編號5 > 0 && 數量5 == 0 );

            return !IsError_;
        }
        
        public 商品資料 ToData()
        {
            return new 商品資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編號.商品),
                開啟 = true,
                大類 = this.大類,
                小類 = this.小類,
                品號 = this.品號,
                名稱 = this.名稱,
                公司 = this.公司,
                廠商 = this.廠商,
                需求1 = this.需求1,
                需求2 = this.需求2,
                需求3 = this.需求3,
                需求4 = this.需求4,
                需求5 = this.需求5,
                數量1 = this.數量1,
                數量2 = this.數量2,
                數量3 = this.數量3,
                數量4 = this.數量4,
                數量5 = this.數量5,
                價格 = this.價格,
            };
        }

        public 商品匯入錯誤結構 ToError()
        {
            商品匯入錯誤結構 Result_ = new 商品匯入錯誤結構();

            Result_.名稱 = 名稱;

            if (公司編號 != 常數.錯誤資料編碼)
                Result_.公司 = 字串.正確;
            else
                Result_.公司 = 公司名稱;

            if (廠商編號 != 常數.錯誤資料編碼)
                Result_.廠商 = 字串.正確;
            else
                Result_.廠商 = 廠商名稱;

            if (大類編號 != 常數.錯誤資料編碼)
                Result_.大類 = 字串.正確;
            else
                Result_.大類 = 大類名稱;

            if (小類編號 != 常數.錯誤資料編碼)
                Result_.小類 = 字串.正確;
            else
                Result_.小類 = 小類名稱;

            if (需求編號1 == -1 || (需求編號1 == 0 && 數量1 > 0 ) || (需求編號1 > 0 && 數量1 == 0 ))
            {
                Result_.需求1 = 需求名稱1;
                Result_.數量1 = 數量1.ToString();
            }
            else
            {
                Result_.需求1 = 字串.正確;
                Result_.數量1 = 字串.正確;
            }

            if (需求編號2 == -1 || (需求編號2 == 0 && 數量2 > 0 ) || (需求編號2 > 0 && 數量2 == 0 ))
            {
                Result_.需求2 = 需求名稱2;
                Result_.數量2 = 數量2.ToString();
            }
            else
            {
                Result_.需求2 = 字串.正確;
                Result_.數量2 = 字串.正確;
            }

            if (需求編號3 == -1 || (需求編號3 == 0 && 數量3 > 0) || (需求編號3 > 0 && 數量3 == 0))
            {
                Result_.需求3 = 需求名稱3;
                Result_.數量3 = 數量3.ToString();
            }
            else
            {
                Result_.需求3 = 字串.正確;
                Result_.數量3 = 字串.正確;
            }

            if (需求編號4 == -1 || (需求編號4 == 0 && 數量4 > 0) || (需求編號4 > 0 && 數量4 == 0))
            {
                Result_.需求4 = 需求名稱4;
                Result_.數量4 = 數量4.ToString();
            }
            else
            {
                Result_.需求4 = 字串.正確;
                Result_.數量4 = 字串.正確;
            }

            if (需求編號5 == -1 || (需求編號5 == 0 && 數量5 > 0) || (需求編號5 > 0 && 數量5 == 0))
            {
                Result_.需求5 = 需求名稱5;
                Result_.數量5 = 數量5.ToString();
            }
            else
            {
                Result_.需求5 = 字串.正確;
                Result_.數量5 = 字串.正確;
            }

            return Result_;
        }
    }

    class 商品匯入錯誤結構
    {
        [CsvColumn(Name = "名稱")]
        public string 名稱 { get; set; }
        [CsvColumn(Name = "公司")]
        public string 公司 { get; set; }
        [CsvColumn(Name = "廠商")]
        public string 廠商 { get; set; }
        [CsvColumn(Name = "大類")]
        public string 大類 { get; set; }
        [CsvColumn(Name = "小類")]
        public string 小類 { get; set; }

        [CsvColumn(Name = "需求1")]
        public string 需求1 { get; set; }
        [CsvColumn(Name = "數量1")]
        public string 數量1 { get; set; }

        [CsvColumn(Name = "需求2")]
        public string 需求2 { get; set; }
        [CsvColumn(Name = "數量2")]
        public string 數量2 { get; set; }

        [CsvColumn(Name = "需求3")]
        public string 需求3 { get; set; }
        [CsvColumn(Name = "數量3")]
        public string 數量3 { get; set; }

        [CsvColumn(Name = "需求4")]
        public string 需求4 { get; set; }
        [CsvColumn(Name = "數量4")]
        public string 數量4 { get; set; }

        [CsvColumn(Name = "需求5")]
        public string 需求5 { get; set; }
        [CsvColumn(Name = "數量5")]
        public string 數量5 { get; set; }
       
    }
}
