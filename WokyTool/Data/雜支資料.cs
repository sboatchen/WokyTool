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
    public class 雜支資料
    {
        //@@ 是否同進貨資料 鎖死廠商,數量,單價....

        // 是否為新物件
        public bool IsNew = false;

        [CsvColumn(Name = "編號")]
        public int 編號 { get; set; }

        [CsvColumn(Name = "時間")]
        public DateTime 時間 { get; set; }

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

        [CsvColumn(Name = "物品名稱")]
        public string 物品名稱 { get; set; }

        [CsvColumn(Name = "數量")]
        public int 數量 { get; set; }
        [CsvColumn(Name = "單價")]
        public double 單價 { get; set; }  // 因為可能為多種幣值，所以需使用浮點數

        public 幣值資料 幣值;
        [CsvColumn(Name = "幣值編號")]
        public int 幣值編號
        {
            get
            {
                return 幣值.編號;
            }
            set
            {
                幣值 = 幣值管理器.Instance.Get(value);

                if (IsNew)
                {
                    匯率 = 幣值.數值;
                }
            }
        }

        [CsvColumn(Name = "匯率")]
        public double 匯率 { get; set; }

        [CsvColumn(Name = "備註")]
        public string 備註 { get; set; }

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

        public static 雜支資料 New()
        {
            return new 雜支資料
            {
                IsNew = true,
                編號 = 編碼管理器.Instance.Get(列舉.編碼類型.支出),
                時間 = DateTime.Now,
                廠商 = 廠商資料.NULL,
                物品名稱 = 字串.空,
                數量 = 0,
                單價 = 0,
                幣值 = 幣值資料.DEFAULT,
                匯率 = 幣值資料.DEFAULT.數值,
                備註 = 字串.空,
            };
        }

        private static readonly 雜支資料 _NULL = new 雜支資料
        {
            IsNew = false,
            編號 = 常數.空白資料編碼,
            時間 = 通用.時間.NULL,
            廠商 = 廠商資料.NULL,
            物品名稱 = 字串.無,
            數量 = 0,
            單價 = 0,
            幣值 = 幣值資料.DEFAULT,
            匯率 = 幣值資料.DEFAULT.數值,
            備註 = 字串.空,
        };
        public static 雜支資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 雜支資料 _ERROR = new 雜支資料
        {
            IsNew = false,
            編號 = 常數.錯誤資料編碼,
            時間 = 通用.時間.NULL,
            廠商 = 廠商資料.ERROR,
            物品名稱 = 字串.錯誤,
            數量 = 0,
            單價 = 0,
            幣值 = 幣值資料.ERROR,
            匯率 = 幣值資料.ERROR.數值,
            備註 = 字串.空,
        };
        public static 雜支資料 ERROR
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

        public 支出資料 ToOutlay()
        {
            return new 支出資料
            {
                結算時間 = DateTime.Now,
                類型 = 字串.雜支,
                編號 = this.編號,
                建立時間 = this.時間,
                廠商 = this.廠商.名稱,
                物品 = this.物品名稱,
                數量 = this.數量,
                單價 = this.單價,
                幣值 = this.幣值.名稱,
                匯率 = this.匯率,
                總價 = this.總價,
                總金額 = this.總金額,
                備註 = this.備註,
            };
        }

        // 存檔
        public void Save()
        {
            if (IsNew == true)
                IsNew = false;
        }
    }
}
