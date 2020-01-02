
namespace WokyTool.通用
{
    public abstract class 新版可記錄資料 : 可編輯資料
    {
        private static string _新資料副本 = "";

        protected string _副本;

        public override void BeginEdit()
        {
            if (_副本 == null)
                _副本 = this.ToString(false);
        }

        public void BeginEdit(string 副本_)
        {
            _副本 = 副本_;
        }

        public override void EndEdit()
        {
            //@@todo    //更新編輯狀態()
        }

        public override void 取消編輯()
        {
            if (是否編輯中 && _副本 != _新資料副本)
            {
                object 資料_ = _副本.轉成物件(this.GetType());
                this.完全拷貝(資料_);
            }

            _副本 = null;
        }

        public override void 紀錄編輯(bool 是否列印_ = false)
        {
            if (是否列印_ && 是否編輯中)
            {
                訊息管理器.獨體.訊息("資料修改");

                訊息管理器.獨體.訊息(_副本);

                訊息管理器.獨體.訊息(this.ToString(false));

                訊息管理器.獨體.訊息("---------");
            }

            _副本 = null;
        }

        public override bool 更新編輯狀態()
        {
            if (_副本 == null)
            {
                是否編輯中 = false;
                return false;
            }

            if(_副本 == _新資料副本)
            {
                是否編輯中 = true;
                return true;
            }

            string 資料_ = this.ToString(false);
            if (_副本.Equals(資料_))
            {
                _副本 = null;
                是否編輯中 = false;
                return false;
            }

            是否編輯中 = true;
            return true;
        }

        public void 新增資料()
        {
            _副本 = _新資料副本;
        }
    }
}
