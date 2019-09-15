using System;
using System.Text;

namespace WokyTool.通用
{
    public class 例外檢查器 : 可檢查介面
    {
        public bool 是否合法 { get; protected set; }

        private StringBuilder _SB = new StringBuilder();

        public 例外檢查器()
        {
            是否合法 = true;
        }

        public void 錯誤(基本資料 資料_, string 訊息_)
        {
            是否合法 = false;

            _SB.Clear();

            Type Type_ = 資料_.GetType();
            _SB.Append(Type_.Name).Append(":").AppendLine(訊息_);
            _SB.Append(資料_.ToString());

            throw new 合法性錯誤(_SB.ToString());
        }
    }
}
