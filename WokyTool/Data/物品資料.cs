using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;
using WokyTool.DataMgr;
using Newtonsoft.Json;
using WokyTool.Common;

namespace WokyTool.Data
{
    public class 物品資料
    {
        [CsvColumn(Name = "編號")]
        public int 編號 { get; set; }
        [CsvColumn(Name = "開啟")]
        public bool 開啟 { get; set; }

        public 物品大類資料 大類;
        [CsvColumn(Name = "大類編號")]
        public int 大類編號
        {
            get
            {
                return 大類.編號;
            }
            set
            {
                大類 = 物品大類管理器.Instance.Get(value);
            }
        }

        public 物品小類資料 小類;
        [CsvColumn(Name = "小類編號")]
        public int 小類編號
        {
            get
            {
                return 小類.編號;
            }
            set
            {
                小類 = 物品小類管理器.Instance.Get(value);
            }
        }

        public 物品品牌資料 品牌;
        [CsvColumn(Name = "品牌編號")]
        public int 品牌編號
        {
            get
            {
                return 品牌.編號;
            }
            set
            {
                品牌 = 物品品牌管理器.Instance.Get(value);
            }
        }

        [CsvColumn(Name = "條碼")]
        public string 條碼 { get; set; }

        [CsvColumn(Name = "名稱")]
        public string 名稱 { get; set; }
        [CsvColumn(Name = "縮寫")]
        public string 縮寫 { get; set; }

        [CsvColumn(Name = "體積")]
        public int 體積 { get; set; }
        [CsvColumn(Name = "數量")]
        public int 數量 { get; set; }
        [CsvColumn(Name = "庫存總成本")]
        public int 庫存總成本 { get; set; }
        [CsvColumn(Name = "最後進貨成本")]
        public int 最後進貨成本 { get; set; }

        public int 成本
        {
            get
            {
                if (數量 == 0)
                    return 最後進貨成本;
                else
                    return 庫存總成本 / 數量;
            }
        }

        public static 物品資料 New()
        {
            return new 物品資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編碼類型.物品),
                開啟 = false,

                大類 = 物品大類資料.NULL,
                小類 = 物品小類資料.NULL,
                品牌 = 物品品牌資料.NULL,

                條碼 = 字串.空,
                名稱 = 字串.空,
                縮寫 = 字串.空,

                體積 = 0,
                數量 = 0,
                庫存總成本 = 0,
                最後進貨成本 = 0,
            };
        }

        private static readonly 物品資料 _NULL = new 物品資料
        {
            編號 = 0,
            開啟 = false,

            大類 = 物品大類資料.NULL,
            小類 = 物品小類資料.NULL,
            品牌 = 物品品牌資料.NULL,

            名稱 = 字串.無,
            縮寫 = 字串.無,
        };
        public static 物品資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 物品資料 _ERROR = new 物品資料
        {
            編號 = -1,
            開啟 = false,

            大類 = 物品大類資料.ERROR,
            小類 = 物品小類資料.ERROR,
            品牌 = 物品品牌資料.ERROR,

            名稱 = 字串.錯誤,
            縮寫 = 字串.錯誤,
        };
        public static 物品資料 ERROR
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
    }
}
