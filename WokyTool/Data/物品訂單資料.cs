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
    [JsonObject(MemberSerialization.OptIn)]
    public class 物品訂單資料 : 訂單資料
    {
        public 物品資料 物品;
        [CsvColumn(Name = "物品編號")]
        [JsonProperty]
        public int 物品編號
        {
            get
            {
                if (物品 == null)
                    return 常數.舊的錯誤資料編碼;
                return 物品.編號;
            }
            set
            {
                物品 = 物品管理器.Instance.Get(value);
            }
        }

        public string 物品顯示名稱
        {
            get
            {
                if (物品 == null)
                    return 字串.空;
                return 物品.名稱;
            }
        }

        /* 其他欄位 */

        override public int 總體積
        {
            get
            {
                if (物品 == null)
                    return 0;
                return 物品.體積 * 數量;
            }
        }

        public string 廠商名稱 { get; set; }
        public string 物品名稱 { get; set; }

        // 是否合法
        override public bool IsLegal()
        {
            return IsIgnore() || (物品 != null && 物品.編號 > 0 && 數量 != 0);
        }
        
        // 初始化
        override public void Init()
        {
            群組 = 0;

            廠商 = 廠商管理器.Instance.Get(廠商名稱);
            物品 = 物品管理器.Instance.Get(物品名稱);

            指配日期 = 時間.NULL;
            指配時段 = 列舉.指配時段.無;

            代收方式 = 列舉.代收方式.無;
            代收金額 = 0;

            配送單號 = null;
        }

        // 完成配送
        override public void 完成配送(string 配送單號_)
        {
            if(是否已配送())
            {
                MessageBox.Show("出貨匯入結構_通用::完成配送 fail, already exit, call programmer ", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            配送單號 = 配送單號_;

            // 庫存處理
            //!!物品.Sell(false, 數量);

            // 轉入銷售資料
            銷售管理器.Instance.Add(銷售資料.New(this));
        }

        // 取出內容物
        override public void AppendItemDetail(Dictionary<String, int> 物品列表_)
        {
            if (物品 == null)
                return;

            if (物品列表_.ContainsKey(物品.縮寫))
                物品列表_[物品.縮寫] += 數量;
            else
                物品列表_[物品.縮寫] = 數量;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public 舊列舉.銷售狀態類型 getType()
        {
            if (數量 > 0)
                return 舊列舉.銷售狀態類型.出貨;
            else
                return 舊列舉.銷售狀態類型.退貨;
        }
    }
}


