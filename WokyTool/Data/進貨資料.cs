using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;

namespace WokyTool.Data
{
    public abstract class 進貨資料
    {
        [CsvColumn(Name = "編號")]
        abstract public int 編號 { get; set; }
        [CsvColumn(Name = "時間")]
        abstract public DateTime 時間 { get; set; }
        [CsvColumn(Name = "進貨類型")]
        abstract public 舊列舉.進貨類型 類型{ get; set; }

        public 廠商資料 廠商 { get; protected set; }
        [CsvColumn(Name = "廠商編號")]
        abstract public int 廠商編號 { get; set; }

        public 物品資料 物品 { get; protected set; }
        [CsvColumn(Name = "物品編號")]
        abstract public int 物品編號 { get; set; }

        [CsvColumn(Name = "數量")]
        abstract public int 數量{ get; set; }
        [CsvColumn(Name = "單價")]
        abstract public double 單價{ get; set; }

        public 幣值資料 幣值 { get; protected set; }
        [CsvColumn(Name = "幣值編號")]
        abstract public int 幣值編號{ get; set; }

        [CsvColumn(Name = "匯率")]
        abstract public double 匯率{ get; set; }

        [CsvColumn(Name = "備註")]
        abstract public String 備註 { get; set; }

        public double 總價
        {
            get
            {
                return 數量 * 單價;
            }
        }

        // 換算台幣
        public int 總金額
        {
            get
            {
                return (int)(總價 * 匯率);
            }
        }

        public 支出資料 ToOutlay()
        {
            return new 支出資料
            {
                結算時間 = DateTime.Now,
                類型 = 字串.進貨,
                編號 = this.編號,
                建立時間 = this.時間,
                廠商 = this.廠商.名稱,
                物品 = this.物品.名稱,
                數量 = this.數量,
                單價 = this.單價,
                幣值 = this.幣值.名稱,
                匯率 = this.匯率,
                總價 = this.總價,
                總金額 = this.總金額,
                備註 = this.備註,
            };
        }

        // 是否已經存檔
        abstract public bool IsSave();

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        // 紀錄
        abstract public 進貨資料 Save();
        // 存檔
        abstract public void Delete();

        public static 進貨資料 NULL
        {
            get
            {
                return 進貨資料_唯讀._NULL;
            }
        }

        public static 進貨資料 ERROR
        {
            get
            {
                return 進貨資料_唯讀._ERROR;
            }
        }
    }
}