using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;

namespace WokyTool.DataImport
{
    public class 進貨匯入結構
    {
        public DateTime 時間 { get; set; }
       
        public string 類型名稱 { get; set; }    // 依需求將各種類型切成不同的匯入視窗，所以該欄位已無用處
        public string 廠商名稱 { get; set; }
        public string 物品名稱 { get; set; }

        public int 數量 { get; set; }
        public double 單價 { get; set; }

        public string 幣值 { get; set; }

        public string 備註 { get; set; }

        /**************************************************/

        public 列舉.進貨類型 類型 { get; set; }

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
        public 物品資料 物品;
        public int 物品編號
        {
            get
            {
                return 物品.編號;
            }
            set
            {
                物品 = 物品管理器.Instance.Get(value);
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

        public string 單價呈現
        {
            get
            {
                if (類型.IsAutoPrice())
                    return 字串.自動填寫;
                else
                    return Convert.ToString(單價);
            }
            set
            {
                if (類型.IsAutoPrice())
                {
                    MessageBox.Show("該類型單價自動設定", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    double x;
                    if (Double.TryParse(value, out x))
                        單價 = x;
                    else
                        MessageBox.Show("輸入異常", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 資料初始化
        public void Init()
        {
            if (類型名稱 == null || 類型名稱.Length == 0)
                類型 = 列舉.進貨類型.一般;
            else
            {
                try
                {
                    類型 = (列舉.進貨類型)Enum.Parse(typeof(列舉.進貨類型), 類型名稱);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("列舉資料異常(" + 類型名稱 + "),改用一般進貨", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    類型 = 列舉.進貨類型.一般;
                }
            }

            Init(類型);
        }

        public void Init(列舉.進貨類型 Type_)
        {
            類型 = Type_;
            廠商 = 廠商管理器.Instance.Get(廠商名稱);
            物品 = 物品管理器.Instance.GetBySName(物品名稱);
            _幣值 = 幣值管理器.Instance.Get(幣值);

            if (時間.Year <= 1)
                時間 = DateTime.Now;
        }

        public static 進貨匯入結構 New()
        {
            return new 進貨匯入結構
            {
                時間 = DateTime.Now,
                類型 = 列舉.進貨類型.一般,
                廠商名稱 = 字串.空,
                廠商 = 廠商資料.NULL,
                物品名稱 = 字串.空,
                物品 = 物品資料.NULL,
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
            if (類型 == 列舉.進貨類型.庫存調整)
                return 廠商編號 >= 0 && 物品編號 > 0 && 幣值編號 >= 0;
            return 廠商編號 >= 0 && 物品編號 > 0 && 數量 != 0 && 幣值編號 >= 0;
        }

        public 進貨資料 Import()
        {
            進貨資料_暫時 Temp_ = 進貨資料_暫時.New(this);

            return Temp_.Save();
        }

        public 進貨匯入錯誤結構 ToError()
        {
            進貨匯入錯誤結構 Result_ = new 進貨匯入錯誤結構();

            if (廠商編號 >= 0)
                Result_.廠商名稱 = 廠商名稱 + 字串.正確;
            else
                Result_.廠商名稱 = 廠商名稱;

            if (物品編號 > 0)
                Result_.物品名稱 = 物品名稱 + 字串.正確;
            else
                Result_.物品名稱 = 物品名稱;

            if (類型 != 列舉.進貨類型.庫存調整 || 數量 != 0)
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

    public class 進貨匯入錯誤結構
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
