using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 配送管理器 : 暫存資料管理器<可配送資料>
    {
        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.匯入訂單;
            }
        }

        // 獨體
        private static readonly 配送管理器 _獨體 = new 配送管理器();
        public static 配送管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 配送管理器()
        {
        }

        public override bool 是否正在編輯()
        {
            return false;
        }

        public override void 完成編輯(bool IsSave_)
        {
            if (IsSave_ == false)
            {
                訊息管理器.獨體.Warn("配送管理器不支援返回操作");
                return;
            }

            檢查合法();

            可編輯BList.RaiseListChangedEvents = false;

            var Temp_ = 可編輯BList.Where(Value => Value.是否已配送() == false).ToList();

            可編輯BList.Clear();
            foreach(var x in Temp_)
            {
                可編輯BList.Add(x);
            }

            編輯資料版本++;

            可編輯BList.RaiseListChangedEvents = true;
        }
    }
}
