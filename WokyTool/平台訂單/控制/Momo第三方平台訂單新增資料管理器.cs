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
    public class Momo第三方平台訂單新增資料管理器: 資料管理器<平台訂單新增資料>
    {
        public override string 檔案路徑 
        {
            get 
            {
                return String.Format("進度/Momo第三方平台訂單新增/{0}.json", 系統參數.使用者); 
            } 
        }

        public string 歸檔檔案路徑
        {
            get
            {
                return String.Format("進度/平台訂單歸檔/{0}_{1}.json", 系統參數.使用者, 時間.目前完整時間);
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
        private static readonly Momo第三方平台訂單新增資料管理器 _獨體 = new Momo第三方平台訂單新增資料管理器();
        public static Momo第三方平台訂單新增資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private Momo第三方平台訂單新增資料管理器()
        {
        }

        public void 歸檔()   //@@
        {
            var Item_ = 可編輯BList.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.配送).Select(Value => 平台訂單歸檔資料.新增(Value)).ToList();
            檔案.寫入檔案(歸檔檔案路徑, JsonConvert.SerializeObject(Item_, Formatting.Indented), false);

            可編輯BList.RaiseListChangedEvents = false;

            var Left_ = 可編輯BList.Where(Value => Value.處理狀態 != 列舉.訂單處理狀態.配送 && Value.處理狀態 != 列舉.訂單處理狀態.忽略).ToList();

            Map.Clear();
            可編輯BList.Clear();

            唯讀BList.Clear();
            唯讀BList.Add(空白資料);
            唯讀BList.Add(錯誤資料);

            foreach (var x in Left_)
            {
                可編輯BList.Add(x);
                唯讀BList.Add(x);
                Map[x.編號] = x;
            }

            資料異動();

            可編輯BList.RaiseListChangedEvents = true;
        }
    }
}
