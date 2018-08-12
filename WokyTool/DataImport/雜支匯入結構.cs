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
    class 雜支匯入結構
    {
        public DateTime 時間 { get; set; }

        public string 廠商名稱 { get; set; }
        public string 物品名稱 { get; set; }

        public int 數量 { get; set; }
        public double 單價 { get; set; }
        public string 幣值 { get; set; }

        public string 備註 { get; set; }

        /**************************************************/
        [JsonIgnore]
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

        [JsonIgnore]
        public 幣值資料 _幣值;
        public int 幣值編號
        {
            get
            {
                return _幣值.編號;
            }
            set
            {
                _幣值 = 幣值管理器.Instance.Get(value);
            }
        }

        // 資料初始化
        public void Init()
        {
            廠商 = 廠商管理器.Instance.Get(廠商名稱);
            _幣值 = 幣值管理器.Instance.Get(幣值);

            if (時間.Year <= 1)
                時間 = DateTime.Now;
        }

        public static 雜支匯入結構 New()
        {
            return new 雜支匯入結構
            {
                時間 = DateTime.Now,
                廠商名稱 = 字串.空,
                廠商 = 廠商資料.NULL,
                物品名稱 = 字串.空,
                數量 = 0,
                單價 = 0,
                幣值 = 字串.TW,
                _幣值 = 幣值資料.DEFAULT,

                備註 = 字串.空,
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
            return 廠商編號 >= 0 && 物品名稱 != null && 物品名稱 != 字串.空 && 數量 != 0 && 幣值編號 >= 0;
        }
        
        public 雜支資料 ToData()
        {
            return new 雜支資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編號.支出),
                時間 = this.時間,
                廠商 = this.廠商,
                物品名稱 = this.物品名稱,
                數量 = this.數量,
                單價 = this.單價,
                幣值 = this._幣值,
                匯率 = this._幣值.數值,
                備註 = this.備註,
            };
        }

        public 雜支匯入錯誤結構 ToError()
        {
            雜支匯入錯誤結構 Result_ = new 雜支匯入錯誤結構();

            if (廠商編號 >= 0)
                Result_.廠商名稱 = 廠商名稱 + 字串.正確;
            else
                Result_.廠商名稱 = 廠商名稱;

            if (物品名稱 != null && 物品名稱 != 字串.空)
                Result_.物品名稱 = 物品名稱 + 字串.正確;
            else
                Result_.物品名稱 = 物品名稱;

            if (數量 != 0)
                Result_.數量 = 數量.ToString() + 字串.正確;
            else
                Result_.數量 = 數量.ToString();

            Result_.單價 = 單價.ToString() + 字串.正確;

            if (幣值編號 >= 0)
                Result_.幣值 = 幣值 + 字串.正確;
            else
                Result_.幣值 = 幣值;

             return Result_;
        }
    }

    class 雜支匯入錯誤結構
    {
        [CsvColumn(Name = "廠商名稱")]
        public string 廠商名稱 { get; set; }
        [CsvColumn(Name = "物品名稱")]
        public string 物品名稱 { get; set; }
        [CsvColumn(Name = "數量")]
        public string 數量 { get; set; }
        [CsvColumn(Name = "單價")]
        public string 單價 { get; set; }
        [CsvColumn(Name = "幣值")]
        public string 幣值 { get; set; }
    }
}
