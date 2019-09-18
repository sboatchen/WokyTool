using Newtonsoft.Json;
using System;
using System.IO;
using WokyTool.通用;

namespace WokyTool.發票
{
    public class 發票匯入管理器 : 匯入資料管理器<發票匯入資料>
    {
        private const string 樣板設定檔案路徑 = "樣板/發票/匯入設定.json";

        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.修改設定資料;
            }
        }

        protected override void 匯入()
        {
            //發票資料管理器.獨體.新增(可編輯BList.Select(Value => 建立資料(Value)));
        }

        public 通用檔案匯入設定資料 取得樣板()
        {
            if (File.Exists(樣板設定檔案路徑))
            {
                string json = 檔案.讀出(樣板設定檔案路徑);
                if (String.IsNullOrEmpty(json) == false)
                    return JsonConvert.DeserializeObject<通用檔案匯入設定資料>(json);
            }

            return null;
        }
    }
}
