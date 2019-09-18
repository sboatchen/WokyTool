using Microsoft.Office.Interop.Excel;

namespace WokyTool.通用
{
    public interface 可寫入介面_EXCEL
    {
        string 分類 { get; }

        string 樣板 { get; }

        XlFileFormat 格式 { get; }

        string 密碼 { get; }

        void 寫入(Application App_);
    }
}
