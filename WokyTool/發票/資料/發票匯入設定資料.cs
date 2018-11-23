using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.發票
{
    public class 發票匯入設定資料 : 檔案匯入設定資料<發票匯入設定資料>  //@@
    {
        // 獨體
        private static readonly 發票匯入設定資料 _獨體 = new 發票匯入設定資料();
        public static 發票匯入設定資料 獨體
        {
            get
            {
                return _獨體;
            }
        }

        private 發票匯入設定資料()
        {
            編號 = 常數.T錯誤資料編碼;
            名稱 = 字串.未定義;
            格式 = 列舉.檔案格式.EXCEL;
            開始位置 = 2;
            結束位置 = 0;
            標頭位置 = 1;
            資料List = new List<欄位匯入設定資料>();
        }

        public override 發票匯入設定資料 拷貝() 
        {
            訊息管理器.獨體.Error("不支援此項功能");
            return null;
        }

        public override void 覆蓋(發票匯入設定資料 Item_)
        {
            訊息管理器.獨體.Error("不支援此項功能");
        }

        public override Boolean 是否一致(發票匯入設定資料 Item_)
        {
            訊息管理器.獨體.Error("不支援此項功能");
            return false;
        }
    }
}
