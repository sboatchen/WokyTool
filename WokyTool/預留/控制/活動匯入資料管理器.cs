using WokyTool.通用;

namespace WokyTool.活動
{
    public class 活動匯入資料管理器 : 可轉換資料管理器<活動匯入資料, 活動資料>
    {
        public override bool 是否自動存檔 { get { return false; } }

        protected override 新版可篩選介面<活動匯入資料> 取得篩選器實體()
        {
            return new 活動匯入資料篩選();
        }

        protected override 可新增介面<活動資料> 記錄器
        {
            get { return 活動新增資料管理器.獨體; }
        }

        // 建構子
        public 活動匯入資料管理器()
        {
        }
    }
}
