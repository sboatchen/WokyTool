using WokyTool.通用;

namespace WokyTool.單品
{
    public class 單品更新資料管理器 : 可更新資料管理器<單品更新資料, 單品資料>
    {
        protected override 新版可篩選介面<單品更新資料> 取得篩選器實體()
        {
            return new 單品更新資料篩選();
        }

        protected override 可編號記錄資料管理器<單品資料> 記錄器 { get { return 單品資料管理器.獨體; } }

        // 建構子
        public 單品更新資料管理器()
        {
        }
    }
}