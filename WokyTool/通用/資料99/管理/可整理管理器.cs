using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WokyTool.平台訂單;
using WokyTool.活動;
using WokyTool.配送;
using WokyTool.寄庫;
using WokyTool.進貨;

namespace WokyTool.通用
{
    public class 可整理管理器 : 可整理介面
    {
        public List<可整理介面> 資料列 { get; protected set; }

        // 獨體
        private static readonly 可整理管理器 _獨體 = new 可整理管理器();
        public static 可整理管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        private 可整理管理器()
        {
            資料列 = new List<可整理介面>();
            資料列.Add(平台訂單資料管理器.獨體);
            資料列.Add(寄庫資料管理器.獨體);
            資料列.Add(配送資料管理器.獨體);
            資料列.Add(進貨資料管理器.獨體);
            資料列.Add(活動資料管理器.獨體);
        }

        public bool 是否需整理()
        {
            foreach (可整理介面 資料_ in 資料列)
            {
                if (資料_.是否需整理())
                    return true;
            }

            return false;
        }

        public void 整理()
        {
            if (系統參數.修改設定資料 == false)
            {
                訊息管理器.獨體.通知("沒有權限執行整理");
                return;
            }

            foreach (可整理介面 資料_ in 資料列)
                資料_.整理();

            資料儲存管理器.獨體.儲存();

            訊息管理器.獨體.通知("完成整理");
        }
    }
}
