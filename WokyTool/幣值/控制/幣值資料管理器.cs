using System;
using System.Linq;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.幣值
{
    public class 幣值資料管理器 : 資料管理器<幣值資料>
    {
        public override string 檔案路徑 
        {
            get 
            { 
                return "設定/幣值.json"; 
            } 
        }

        public override 幣值資料 空白資料
        {
            get
            {
                return 幣值資料.NULL;
            }
        }

        public override 幣值資料 錯誤資料
        {
            get 
            {
                return 幣值資料.ERROR; 
            } 
        }

        public override 列舉.編號 編號類型
        { 
            get 
            { 
                return 列舉.編號.幣值; 
            } 
        }

        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.修改設定資料;
            }
        }

        // 獨體
        private static readonly 幣值資料管理器 _獨體 = new 幣值資料管理器();
        public static 幣值資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 幣值資料管理器()
        {
        }

        // 取得資料
        public 幣值資料 Get(string Name)
        {
            if (String.IsNullOrEmpty(Name) || 字串.無.Equals(Name))
                return 空白資料;

            幣值資料 Item_ = Map.Values
                                   .Where(Value => Name.Equals(Value.名稱))
                                   .FirstOrDefault();

            if (Item_ == null)
                return 錯誤資料;
            else
                return Item_;
        }
    }
}
