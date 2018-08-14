using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.客戶
{
    public class 客戶資料管理器 : 資料管理器<客戶資料>
    {
        public override string 檔案路徑 
        {
            get 
            { 
                return "設定/客戶.json"; 
            } 
        }

        public override 客戶資料 空白資料
        {
            get
            {
                return 客戶資料.NULL;
            }
        }

        public override 客戶資料 錯誤資料
        {
            get 
            {
                return 客戶資料.ERROR; 
            } 
        }

        public override 列舉.編號 編號類型
        { 
            get 
            { 
                return 列舉.編號.客戶; 
            } 
        }

        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.是否允許修改基本資料;
            }
        }

        // 獨體
        private static readonly 客戶資料管理器 _獨體 = new 客戶資料管理器();
        public static 客戶資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 客戶資料管理器()
        {
        }
    }
}
