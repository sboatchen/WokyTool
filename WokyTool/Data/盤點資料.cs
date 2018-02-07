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
    [JsonObject(MemberSerialization.OptIn)]
    public class 盤點資料 : 可格式化_Csv
    {
        [CsvColumn(FieldIndex = 1)]
        [JsonProperty]
        public DateTime 時間 { get; set; }

        [CsvColumn(FieldIndex = 2)]
        public string 物品條碼字串 { get; set; }

        public 物品資料 物品 = 物品資料.NULL;
        [JsonProperty]
        public string 物品條碼
        {
            get
            {
                return 物品.條碼;
            }
            set
            {
                物品 = 物品管理器.Instance.GetByCode(value);
            }
        }

        [CsvColumn(FieldIndex = 3)]
        public string 無用 { get; set; }

        [CsvColumn(FieldIndex = 4)]
        [JsonProperty]
        public int 數量 { get; set; }
    
        [CsvColumn(FieldIndex = 5)]
        public 列舉.盤點類型 類型 { get; set; }

        public static 盤點資料 New()
        {
            return new 盤點資料
            {
                時間 = DateTime.Now,

                物品 = 物品資料.NULL,
                無用 = 字串.空,

                數量 = 0,
                類型 = 列舉.盤點類型.無,
            };
        }

        public bool Init(列舉.盤點類型 類型)
        {
            if (this.類型 != 類型)
            {
                MessageBox.Show("盤點資料::Init 類型錯誤," + 類型, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                物品條碼 = 物品條碼字串;
            }
            catch
            {
                MessageBox.Show("盤點資料::Init 編號讀取錯誤," + 物品條碼字串, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public bool isLegal()
        {
            return 物品 != null && 物品.編號 > 常數.空白資料編碼;
        }
    }
}
