
namespace WokyTool.通用
{
    public interface 可編輯資料列管理介面
    {
         // 資料BindingList
        object 可編輯資料列 { get; }

        int 可編輯資料列版本 { get; }

        bool 是否正在編輯();
        void 完成編輯(bool 是否存檔_);

        void 資料異動();

        void 檢查合法();    // will throw exception
    }
}
