using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;

namespace WokyTool.DataImport
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 條碼更新匯入結構 : 可格式化_Excel
    {
        [JsonProperty]
        public string 縮寫 { get; set; }
        [JsonProperty]
        public string 條碼 { get; set; }

        [JsonProperty]
        public 列舉.更新狀態 狀態 { get; set; }
        [JsonProperty]
        public string 更新訊息 { get; set; }

        protected 物品資料 更新目標物品 = 物品資料.ERROR;
        public string 舊條碼 
        {
            get
            {
                return 更新目標物品.條碼;
            }
        }


        // 資料初始化
        public void Init()
        {
            if (縮寫 == null || 縮寫.Length == 0)
            {
                狀態 = 列舉.更新狀態.錯誤;
                更新訊息 = 字串.名稱不合法;
                return;
            }

            更新目標物品 = 物品管理器.Instance.GetBySName(縮寫);
            if (更新目標物品 == 物品資料.ERROR)
            {
                狀態 = 列舉.更新狀態.錯誤;
                更新訊息 = 字串.物件不存在;
                return;
            }

            if (舊條碼 != null && 舊條碼.CompareTo(條碼) == 0)
                狀態 = 列舉.更新狀態.相同;
            else 
                狀態 = 列舉.更新狀態.更新;
        }

        public void Save()
        {
            if (狀態 != 列舉.更新狀態.更新)
                return;

            更新目標物品.條碼 = 條碼;
        }

        // 設定title，回傳下筆資料的輸入行位置
        public int SetExcelTitle(Microsoft.Office.Interop.Excel.Application App_)
        {
            App_.Cells[1, 1] = "縮寫";
            App_.Cells[1, 2] = "條碼";
            App_.Cells[1, 3] = "更新訊息";

            return 2;
        }

        // 設定資料
        public int SetExcelData(Microsoft.Office.Interop.Excel.Application App_, int Row_)
        {
            App_.Cells[Row_, 1] = 縮寫;
            App_.Cells[Row_, 2] = 條碼;
            App_.Cells[Row_, 3] = 更新訊息;

            return Row_ + 1;
        }
    }
}
