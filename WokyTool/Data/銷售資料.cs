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
using WokyTool.通用;

namespace WokyTool.Data
{
    public class 銷售資料
    {
        [CsvColumn(Name = "編號")]
        public int 編號 { get; set; }
        [CsvColumn(Name = "銷售狀態類型")]
        public 舊列舉.銷售狀態類型 狀態 { get; set; }
        [CsvColumn(Name = "建立日期")]
        public DateTime 建立日期 { get; set; }
        [CsvColumn(Name = "結單日期")]
        public DateTime 結單日期 { get; set; }

        [CsvColumn(Name = "姓名")]
        public string 姓名 { get; set; }
        [CsvColumn(Name = "地址")]
        public string 地址 { get; set; }
        [CsvColumn(Name = "電話")]
        public string 電話 { get; set; }
        [CsvColumn(Name = "手機")]
        public string 手機 { get; set; }

        [CsvColumn(Name = "廠商")]
        public string 廠商 { get; set; }
        [CsvColumn(Name = "公司")]
        public string 公司 { get; set; }
        [CsvColumn(Name = "訂單編號")]
        public string 訂單編號 { get; set; }
        
        [CsvColumn(Name = "寄庫出貨")]
        public bool 寄庫出貨 { get; set; }
        [CsvColumn(Name = "備註")]
        public string 備註 { get; set; }

        [CsvColumn(Name = "指配日期")]
        public DateTime 指配日期 { get; set; }
        [CsvColumn(Name = "指配時段")]
        public string 指配時段 { get; set; }

        [CsvColumn(Name = "代收方式")]
        public string 代收方式 { get; set; }
        [CsvColumn(Name = "代收金額")]
        public int 代收金額 { get; set; }

        [CsvColumn(Name = "配送公司")]
        public string 配送公司 { get; set; }
        [CsvColumn(Name = "配送單號")]
        public string 配送單號 { get; set; }

        [CsvColumn(Name = "商品")]
        public string 商品名稱 { get; set; }
        [CsvColumn(Name = "類型")]
        public string 商品類型 { get; set; }
        [CsvColumn(Name = "商品編號")]
        public int 商品編號 { get; set; }

        [CsvColumn(Name = "數量")]
        public int 數量 { get; set; }
        [CsvColumn(Name = "成本")]
        public int 成本 { get; set; }
        [CsvColumn(Name = "售價")]
        public int 售價 { get; set;}

        public int 利潤
        {
            get 
            {
                return 售價 - 成本;
            }
        }

        public int 總利潤
        {
            get
            {
                return 利潤 * 數量;
            }
        }

        public void Set狀態(舊列舉.銷售狀態類型 value)
        {
            if (狀態.IsClose())
            {
                MessageBox.Show("已結單，不允許修改", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                狀態 = value;
                if (狀態 == 舊列舉.銷售狀態類型.退貨)
                    售價 = 0;
                if (狀態.IsClose())
                    結單日期 = DateTime.Now;
            }
        }

        public void Set售價(int value)
        {
             if (狀態.IsAllowPrice())
                    售價 = value;
                else
                    MessageBox.Show("不允許修改售價", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public static 銷售資料 New(商品訂單資料 From_)
        {
            return new 銷售資料
            {
                //編號 = 編碼管理器.Instance.Get(列舉.編號.銷售),
                狀態 = 舊列舉.銷售狀態類型.出貨,
                建立日期 = DateTime.Now,
                結單日期 = 時間.NULL,

                姓名 = From_.姓名,
                地址 = From_.地址,
                電話 = From_.電話,
                手機 = From_.手機,

                廠商 = From_.廠商.名稱,
                公司 = From_.商品.公司.名稱,
                訂單編號 = From_.訂單編號,

                寄庫出貨 = From_.寄庫出貨,
                備註 = From_.重要備註 + From_.備註,

                指配日期 = From_.指配日期,
                指配時段 = From_.指配時段.ToString(),

                代收方式 = From_.代收方式.ToString(),
                代收金額 = From_.代收金額,

                配送公司 = From_.配送公司.ToString(),
                配送單號 = From_.配送單號,

                商品名稱 = From_.商品.名稱,
                商品類型 = 字串.商品,
                商品編號 = From_.商品.編號,

                數量 = From_.數量,
                成本 = From_.商品.成本,
                售價 = From_.單價,
            };
        }

        public static 銷售資料 New(物品訂單資料 From_)
        {
            return new 銷售資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編號.銷售),
                狀態 = 舊列舉.銷售狀態類型.出貨,
                建立日期 = DateTime.Now,
                結單日期 = 時間.NULL,

                姓名 = From_.姓名,
                地址 = From_.地址,
                電話 = From_.電話,
                手機 = From_.手機,

                廠商 = From_.廠商.名稱,
                //@@公司 = From_.商品.公司.名稱,
                訂單編號 = From_.訂單編號,

                寄庫出貨 = false,
                備註 = From_.重要備註 + From_.備註,

                指配日期 = From_.指配日期,
                指配時段 = From_.指配時段.ToString(),

                代收方式 = From_.代收方式.ToString(),
                代收金額 = From_.代收金額,

                配送公司 = From_.配送公司.ToString(),
                配送單號 = From_.配送單號,

                商品名稱 = From_.物品.名稱,
                商品類型 = 字串.物品,
                商品編號 = From_.物品.編號,

                數量 = From_.數量,
                成本 = From_.物品.成本,
                售價 = From_.單價,
            };
        }

        private static readonly 銷售資料 _NULL = new 銷售資料
        {
            編號 = 常數.舊的空白資料編碼,
            狀態 = 舊列舉.銷售狀態類型.結單,
            建立日期 = 時間.NULL,
            結單日期 = 時間.NULL,

            姓名 = 字串.無,
            地址 = 字串.無,
            電話 = 字串.無,
            手機 = 字串.無,

            廠商 = 字串.無,
            公司 = 字串.無,
            訂單編號 = 字串.無,

            寄庫出貨 = false,
            備註 = 字串.無,

            指配日期 = 時間.NULL,
            指配時段 = 字串.無,

            代收方式 = 字串.無,
            代收金額 = 0,

            配送公司 = 字串.無,
            配送單號 = 字串.無,

            商品名稱 = 字串.無,
            商品類型 = 字串.無,
            商品編號 = 常數.舊的空白資料編碼,

            數量 = 0,
            成本 = 0,
            售價 = 0
        };
        public static 銷售資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 銷售資料 _ERROR = new 銷售資料
        {
            編號 = 常數.舊的錯誤資料編碼,
            狀態 = 舊列舉.銷售狀態類型.結單,
            建立日期 = 時間.NULL,
            結單日期 = 時間.NULL,

            姓名 = 字串.錯誤,
            地址 = 字串.錯誤,
            電話 = 字串.錯誤,
            手機 = 字串.錯誤,

            廠商 = 字串.錯誤,
            公司 = 字串.錯誤,
            訂單編號 = 字串.錯誤,

            寄庫出貨 = false,
            備註 = 字串.錯誤,

            指配日期 = 時間.NULL,
            指配時段 = 字串.錯誤,

            代收方式 = 字串.錯誤,
            代收金額 = 0,

            配送公司 = 字串.錯誤,
            配送單號 = 字串.錯誤,

            商品名稱 = 字串.錯誤,
            商品類型 = 字串.錯誤,
            商品編號 = 常數.舊的錯誤資料編碼,

            數量 = 0,
            成本 = 0,
            售價 = 0
        };
        public static 銷售資料 ERROR
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
