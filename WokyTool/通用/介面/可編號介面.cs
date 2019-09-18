
namespace WokyTool.通用
{
    public interface 可編號介面  //@@ remove
    {
        int 編號 { get; set; }

        bool 編號是否合法();

        bool 編號是否有值();
    }
}
