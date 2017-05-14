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
    public enum 更新狀態
    {
        錯誤,
        新增,
        相同,
        更新,
    };

    [JsonObject(MemberSerialization.OptIn)]
    class 物品更新匯入結構 : 可格式化_Excel
    {
        [JsonProperty]
        public string 名稱 { get; set; }
        [JsonProperty]
        public string 縮寫 { get; set; }

        [JsonProperty] 
        public string 品牌名稱 { get; set; }
        [JsonProperty] 
        public string 大類名稱 { get; set; }
        [JsonProperty] 
        public string 小類名稱 { get; set; }

        [JsonProperty] 
        public int 體積 { get; set; }
        [JsonProperty] 
        public int 數量 { get; set; }
        [JsonProperty] 
        public int 最後進貨成本 { get; set; }

        [JsonProperty]
        public 更新狀態 狀態 { get; set; }
        [JsonProperty]
        public string 更新訊息 { get; set; }
        [JsonProperty]
        public int 總成本異動 { get; set; }

        protected 物品資料 更新目標物品 = 物品資料.ERROR;
        protected 物品大類資料 大類 = 物品大類資料.NULL;
        protected 物品小類資料 小類 = 物品小類資料.NULL;
        protected 物品品牌資料 品牌 = 物品品牌資料.NULL;

        public void Synchronize(物品資料 目標_)
        {
            目標_.名稱 = 名稱;
            目標_.縮寫 = 縮寫;
            目標_.品牌 = 品牌;
            目標_.大類 = 大類;
            目標_.小類 = 小類;
            目標_.體積 = 體積;
            目標_.內庫數量 = 數量;
            目標_.最後進貨成本 = 最後進貨成本;
            目標_.庫存總成本 += 總成本異動;
        }

        // 資料初始化
        public void Init()
        {
            // 取得連結資料
            大類 = 物品大類管理器.Instance.Get(大類名稱, 列舉.搜尋失敗處理類型.找不到時新增);
            小類 = 物品小類管理器.Instance.Get(小類名稱, 列舉.搜尋失敗處理類型.找不到時新增);
            品牌 = 物品品牌管理器.Instance.Get(品牌名稱, 列舉.搜尋失敗處理類型.找不到時新增);

            // 檢查為錯誤或新的資料，否則則取得對應的更新物件
            if (GetUpdateItem() == true)
                return;

            // 檢查為更新或相同的資料
            {
                狀態 = 更新狀態.相同;

                StringBuilder sb_ = new StringBuilder();

                CheckAndAppend(sb_, "名稱", 名稱, 更新目標物品.名稱);
                CheckAndAppend(sb_, "縮寫", 縮寫, 更新目標物品.縮寫);

                CheckAndAppend(sb_, "品牌名稱", 品牌.名稱, 更新目標物品.品牌.名稱);
                CheckAndAppend(sb_, "大類名稱", 大類.名稱, 更新目標物品.大類.名稱);
                CheckAndAppend(sb_, "小類名稱", 小類.名稱, 更新目標物品.小類.名稱);

                CheckAndAppend(sb_, "體積", 體積, 更新目標物品.體積);
                CheckAndAppend(sb_, "數量", 數量, 更新目標物品.內庫數量);
                CheckAndAppend(sb_, "最後進貨成本", 最後進貨成本, 更新目標物品.最後進貨成本);

                if (sb_.Length > 0)
                {
                    狀態 = 更新狀態.更新;
                    更新訊息 = sb_.ToString();

                    int 內庫數量差異 = 數量 - 更新目標物品.內庫數量;
                    if (更新目標物品.內庫數量 == 0 && 更新目標物品.成本 == 0)
                        總成本異動 = 內庫數量差異 * 最後進貨成本;
                    else
                        總成本異動 = 內庫數量差異 * 更新目標物品.成本;
                }
            }
        }

        // 取得是否有對應的更新物件
        // 回傳 true 代表結束處理(可能為新增或錯誤)
        private bool GetUpdateItem()
        {
            if (名稱 == null || 名稱.Length == 0 || 縮寫 == null || 縮寫.Length == 0)
            {
                狀態 = 更新狀態.錯誤;
                更新訊息 = 字串.名稱不合法;
                
                return true;
            }

            if (名稱 != null && 名稱.Length > 0)
            {
                更新目標物品 = 物品管理器.Instance.Get(名稱);
                if (更新目標物品 != 物品資料.ERROR)
                    return false;
            }

            if (縮寫 != null && 縮寫.Length > 0)
            {
                更新目標物品 = 物品管理器.Instance.GetBySName(縮寫);
                if (更新目標物品 != 物品資料.ERROR)
                    return false;
            }

            狀態 = 更新狀態.新增;
            總成本異動 = 數量 * 最後進貨成本;
            return true;
        }

        private void CheckAndAppend(StringBuilder sb_, String Title_, String New_, String Old_)
        {
            if (String.Compare(New_, Old_) == 0)
                return;

            if (sb_.Length != 0)
                sb_.Append(";");

            sb_.Append(Title_);
            sb_.Append(":");
            sb_.Append(New_);
            sb_.Append("/");
            sb_.Append(Old_);
        }

        private void CheckAndAppend(StringBuilder sb_, String Title_, int New_, int Old_)
        {
            if (New_ == Old_)
                return;

            if (sb_.Length != 0)
                sb_.Append(";");

            sb_.Append(Title_);
            sb_.Append(":");
            sb_.Append(New_);
            sb_.Append("/");
            sb_.Append(Old_);
        }

        // 資料匯入
        public void Import()
        {
            switch(狀態)
            {
                case 更新狀態.錯誤:
                    MessageBox.Show(ToString(), 字串.匯入異常, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 更新狀態.新增:
                {
                    更新目標物品 = 物品資料.New();
                    Synchronize(更新目標物品);
                    物品管理器.Instance.Add(更新目標物品);
                    break;
                }
                case 更新狀態.相同:
                    break;
                case 更新狀態.更新:
                {
                    Synchronize(更新目標物品);
                    //@@
                    物品管理器.Instance.SetDirty();
                    break;
                }
                default:
                    MessageBox.Show("物品更新匯入結構.Import.swith不支援,請通知苦逼程式", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        // 字串化
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "名稱";
            App_.Cells[1, 2] = "縮寫";
            App_.Cells[1, 3] = "品牌名稱";
            App_.Cells[1, 4] = "大類名稱";
            App_.Cells[1, 5] = "小類名稱";
            App_.Cells[1, 6] = "體積";
            App_.Cells[1, 7] = "數量";
            App_.Cells[1, 8] = "最後進貨成本";
            App_.Cells[1, 9] = "狀態";
            App_.Cells[1, 10] = "更新訊息";
            App_.Cells[1, 11] = "總成本異動";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = 名稱;
            App_.Cells[Row_, 2] = 縮寫;
            App_.Cells[Row_, 3] = 品牌名稱;
            App_.Cells[Row_, 4] = 大類名稱;
            App_.Cells[Row_, 5] = 小類名稱;
            App_.Cells[Row_, 6] = 體積;
            App_.Cells[Row_, 7] = 數量;
            App_.Cells[Row_, 8] = 最後進貨成本;
            App_.Cells[Row_, 9] = 狀態.ToString("G");
            App_.Cells[Row_, 10] = 更新訊息;
            App_.Cells[Row_, 11] = 總成本異動;

            return Row_ + 1;
        }



        // 資料是否合法
        /*public bool IsLegal()
        {
            return 大類編號 != 常數.錯誤資料編碼 && 小類編號 != 常數.錯誤資料編碼 && 品牌編號 != 常數.錯誤資料編碼;
        }*/
    }
}

/*    public 物品資料 ToData()
    {
        return new 物品資料
        {
            編號 = 編碼管理器.Instance.Get(列舉.編碼類型.物品),
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

        if (大類編號 != 常數.錯誤資料編碼)
            Result_.大類 = 字串.正確;
        else
            Result_.大類 = 大類名稱;

        if (小類編號 != 常數.錯誤資料編碼)
            Result_.小類 = 字串.正確;
        else
            Result_.小類 = 小類名稱;

        if (品牌編號 != 常數.錯誤資料編碼)
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
}*/