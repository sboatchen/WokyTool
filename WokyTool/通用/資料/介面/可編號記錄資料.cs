using Newtonsoft.Json;

namespace WokyTool.通用
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 可編號記錄資料 : 新版可記錄資料, 可編號介面, 可索引介面
    {
        [可匯出]
        [JsonProperty]
        public virtual int 編號 { get; set; }

        public virtual bool 編號是否合法()
        {
            return 編號 != 常數.新建資料編碼 && 編號 != 常數.錯誤資料編碼 && 編號 != 常數.不篩選資料編碼;  //@@
        }

        public bool 編號是否有值()
        {
            return 編號 > 常數.新建資料編碼;
        }

        [可匯出]
        public object 索引 { get { return 編號; } }
    }
}
