
namespace WokyTool.通用
{
    public interface 可檢查介面
    {
        bool 是否合法 { get;  }

        void 重置();

        void 錯誤(基本資料 資料_, string 訊息_);
    }
}
