using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品資料管理器 : 資料管理器<物品資料>
    {
        public override string 檔案路徑 
        {
            get 
            { 
                return "設定/物品.json"; 
            } 
        }

        public override 物品資料 空白資料
        {
            get
            {
                return 物品資料.NULL;
            }
        }

        public override 物品資料 錯誤資料
        {
            get 
            {
                return 物品資料.ERROR; 
            } 
        }

        public override 列舉.編碼類型 編碼類型 
        { 
            get 
            { 
                return 列舉.編碼類型.物品; 
            } 
        }

        // 獨體
        private static readonly 物品資料管理器 _獨體 = new 物品資料管理器();
        public static 物品資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 物品資料管理器()
        {
        }

        // 取得資料
        public 物品資料 Get(string Name)
        {
            物品資料 Item_ = Map.Values
                                   .Where(Value => Value.名稱.Equals(Name))
                                   .FirstOrDefault();

            if (Item_ == null)
                return 錯誤資料;
            else
                return Item_;
        }

        // 取得資料
        public 物品資料 GetBySName(string Name)
        {
            if (Name == null || Name.Length == 0)
                return 物品資料.NULL;

            物品資料 Item_ = Map.Values
                                .Where(Value => Value.縮寫.Equals(Name))
                                .FirstOrDefault();

            if (Item_ == null)
                return 錯誤資料;
            else
                return Item_;
        }

        // 取得資料
        public 物品資料 GetByCode(string Code)
        {
            if (Code == null || Code.Length == 0)
                return 物品資料.NULL;

            物品資料 Item_ = Map.Values
                                .Where(Value => Code.Equals(Value.條碼))
                                .FirstOrDefault();

            if (Item_ == null)
                return 錯誤資料;
            else
                return Item_;
        }
    }
}
