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
//@@ 帶整理
namespace WokyTool.Data
{
    public class 月結帳資料
    {
        [CsvColumn(Name = "編號")]
        public Int64 編號 { get; set; }
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

        public string 廠商名稱
        {
            get
            {
                return 廠商.名稱;
            }
            set
            {
                MessageBox.Show("月結帳資料::廠商名稱 不支援設定值", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public 商品資料 商品;
        [CsvColumn(Name = "商品編號")]
        public int 商品編號
        {
            get
            {
                return 商品.編號;
            }
            set
            {
                商品 = 商品管理器.Instance.Get(value);
            }
        }

        public string 商品品號
        {
            get
            {
                return 商品.品號;
            }
            set
            {
                商品 = 商品管理器.Instance.Get(廠商編號, value);
            }
        }

        public string 商品名稱
        {
            get
            {
                return 商品.名稱;
            }
            set
            {
                MessageBox.Show("月結帳資料::商品名稱 不支援設定值", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [CsvColumn(Name = "數量")]
        public int 數量 { get; set; }
        [CsvColumn(Name = "單價")]
        public int 單價 { get; set; }
        [CsvColumn(Name = "成本")]
        public int 成本 { get; set; }

        //@@ 暫時
        public int 利潤 
        {
            get
            {
                return 單價 - 成本;
            }
            set
            {
                MessageBox.Show("月結帳資料::利潤 不支援設定值", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //@@ 暫時
        public int 總利潤
        {
            get
            {
                return 利潤 * 數量;
            }
            set
            {
                MessageBox.Show("月結帳資料::總利潤 不支援設定值", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static 月結帳資料 New()
        {
            return new 月結帳資料
            {
                編號 = 編碼管理器.Instance.Get(列舉.編碼類型.月結帳),

                時間 = new DateTime(),

                廠商 = 廠商資料.NULL,
                商品 = 商品資料.NULL,

                數量 = 0,
                單價 = 0,
                成本 = 0,
            };
        }

         private static readonly 月結帳資料 _NULL = new 月結帳資料
         {
            編號 = 常數.空白資料編碼,
            時間 = new DateTime(),
            廠商 = 廠商資料.NULL,
            商品 = 商品資料.NULL,
            數量 = 0,
            單價 = 0,
            成本 = 0,
         };
         public static 月結帳資料 NULL
         {
             get
             {
                 return _NULL;
             }
         }

         private static 月結帳資料 _ERROR = new 月結帳資料
         {
            編號 = 常數.錯誤資料編碼,
            時間 = new DateTime(),
            廠商 = 廠商資料.ERROR,
            商品 = 商品資料.ERROR,
            數量 = 0,
            單價 = 0,
            成本 = 0,
         };
         public static 月結帳資料 ERROR
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

         public bool IsLegal()
         {
             return 廠商編號 != -1 && 商品編號 != -1 && 數量 != 0;
         }
    } 
}
