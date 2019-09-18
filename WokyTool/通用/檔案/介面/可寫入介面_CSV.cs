using System.Text;

namespace WokyTool.通用
{
    public interface 可寫入介面_CSV
    {
        string 分類 { get; }

        string 分格號 { get; }

        string 密碼 { get; }

        Encoding 編碼 { get; }

        void 寫入(CSVBuilder Builder_);
    }
}
