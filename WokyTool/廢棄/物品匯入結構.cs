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
    class 物品匯入結構
    {
        public string 大類名稱 { get; set; }
        public string 小類名稱 { get; set; }
        public string 品牌名稱 { get; set; }

        public string 名稱 { get; set; }
        public string 縮寫 { get; set; }

        public string 條碼 { get; set; }
        public string 原廠編號 { get; set; }
        public string 代理編號 { get; set; }

        public int 體積 { get; set; }
        public int 數量 { get; set; }
        public int 庫存總成本 { get; set; }
        public int 最後進貨成本 { get; set; }

        /**************************************************/

        public 物品大類資料 大類;
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


        // 資料初始化
        public void Init()
        {
            大類 = 物品大類管理器.Instance.Get(大類名稱);
            小類 = 物品小類管理器.Instance.Get(小類名稱);
            品牌 = 物品品牌管理器.Instance.Get(品牌名稱);
        }

        public static 物品匯入結構 New()
        {
            return new 物品匯入結構
            {
                名稱 = 字串.空,
                縮寫 = 字串.空,

                條碼 = 字串.空,
                原廠編號 = 字串.空,
                代理編號 = 字串.空,

                大類名稱 = 字串.空,
                小類名稱 = 字串.空,
                品牌名稱 = 字串.空,

                體積 = 0,
                數量 = 0,
                庫存總成本 = 0,
                最後進貨成本 = 0,

                大類 = 物品大類資料.NULL,
                小類 = 物品小類資料.NULL,
                品牌 = 物品品牌資料.NULL,
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
            return 大類編號 != 常數.錯誤資料編碼 && 小類編號 != 常數.錯誤資料編碼 && 品牌編號 != 常數.錯誤資料編碼;
        }
        
        public 物品資料 ToData()
        {
            return new 物品資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編號.物品),
                開啟 = true,
                大類 = this.大類,
                小類 = this.小類,
                品牌 = this.品牌,
                條碼 = this.條碼,
                原廠編號 = this.原廠編號,
                代理編號 = this.代理編號,
                名稱 = this.名稱,
                縮寫 = this.縮寫,
                體積 = this.體積,
                內庫數量 = this.數量,
                最後進貨成本 = this.最後進貨成本,
            };
        }

        public 物品匯入錯誤結構 ToError()
        {
            物品匯入錯誤結構 Result_ = new 物品匯入錯誤結構();

            Result_.名稱 = 名稱;

            if(大類編號 != 常數.錯誤資料編碼)
                Result_.大類 = 字串.正確;
            else
                Result_.大類 = 大類名稱;

             if(小類編號 != 常數.錯誤資料編碼)
                Result_.小類 = 字串.正確;
            else
                Result_.小類 = 小類名稱;

             if(品牌編號 != 常數.錯誤資料編碼)
                Result_.品牌 = 字串.正確;
            else
                Result_.品牌 = 品牌名稱;

             return Result_;
        }
    }

    class 物品匯入錯誤結構
    {
        [CsvColumn(Name = "名稱")]
        public string 名稱 { get; set; }
        [CsvColumn(Name = "大類")]
        public string 大類 { get; set; }
        [CsvColumn(Name = "小類")]
        public string 小類 { get; set; }
        [CsvColumn(Name = "品牌")]
        public string 品牌 { get; set; }
    }
}
