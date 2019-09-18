
namespace WokyTool.通用
{
    public interface 視窗可篩選介面
    {
        string 排序欄位 { get; set; }

        bool 是否排序 { get; }
        bool 是否篩選 { get; }

        string 文字 { get; set; }
    }
}
