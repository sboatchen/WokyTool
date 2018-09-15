using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單新增資料管理器: 資料管理器<平台訂單新增資料>
    {
        public override string 檔案路徑 
        {
            get 
            {
                return String.Format("進度/平台訂單新增/{0}.json", 系統參數.使用者); 
            } 
        }

        public override 平台訂單新增資料 空白資料
        {
            get
            {
                return 平台訂單新增資料.NULL;
            }
        }

        public override 平台訂單新增資料 錯誤資料
        {
            get 
            {
                return 平台訂單新增資料.ERROR; 
            } 
        }

        public override 列舉.編號 編號類型
        { 
            get 
            {
                return 列舉.編號.平台訂單新增; 
            } 
        }

        public override int 編號代碼
        {
            get
            {
                return (int)編號類型 + 系統參數.使用者編號 * 1000;
            }
        }

        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.匯入訂單;
            }
        }

        // 獨體
        private static readonly 平台訂單新增資料管理器 _獨體 = new 平台訂單新增資料管理器();
        public static 平台訂單新增資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 平台訂單新增資料管理器()
        {
        }
    }
}
