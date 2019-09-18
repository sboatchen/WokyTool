
namespace WokyTool.通用
{
    public interface 可列舉資料來源管理介面 : 可列舉資料管理介面
    {
        void 更新資料(object 資料列obj_);

        void 合法檢查(可檢查介面 檢查器_);
    }
}
