using WokyTool.通用;

namespace WokyTool.聯絡人
{
    public class 聯絡人更新資料管理器 : 可更新資料管理器<聯絡人更新資料, 聯絡人資料>
    {
        protected override 新版可篩選介面<聯絡人更新資料> 取得篩選器實體()
        {
            return new 聯絡人更新資料篩選();
        }

        protected override 可編號記錄資料管理器<聯絡人資料> 記錄器 { get { return 聯絡人資料管理器.獨體; } }

        // 建構子
        public 聯絡人更新資料管理器()
        {
        }
    }
}