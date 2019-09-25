
namespace WokyTool.通用
{
    public abstract class 可暫存資料管理器<T> : 抽象資料列管理器<T> where T : 可編輯資料
    {
        public override bool 是否可編輯 { get { return true; } }
        public override bool 是否編輯中 { get { return 資料列.Count > 0; } }

        protected override void 新增資料處理(T 資料_)
        {
        }

        protected override void 刪除資料處理(T 資料_)
        {
        }

        public override void 完成編輯(bool 是否紀錄_)
        {
        }
    }
}
