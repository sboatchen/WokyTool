using System;
using WokyTool.通用;

namespace WokyTool.進貨
{
    public class 進貨新增資料管理器 : 資料管理器<進貨新增資料>
    {
        public override string 檔案路徑 
        {
            get 
            {
                return String.Format("進度/進貨/{0}.json", 系統參數.使用者名稱); 
            } 
        }

        public override 進貨新增資料 空白資料
        {
            get
            {
                return 進貨新增資料.NULL;
            }
        }

        public override 進貨新增資料 錯誤資料
        {
            get 
            {
                return 進貨新增資料.ERROR; 
            } 
        }

        public override 列舉.編號 編號類型
        { 
            get 
            { 
                return 列舉.編號.進貨新增; 
            } 
        }

        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.匯入進貨;
            }
        }

        // 獨體
        private static readonly 進貨新增資料管理器 _獨體 = new 進貨新增資料管理器();
        public static 進貨新增資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 進貨新增資料管理器()
        {
        }
    }
}
