using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.平台訂單;
using WokyTool.客戶;
using WokyTool.配送;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.客製
{
    public abstract class 平台訂單自定義介面 : 檔案匯入轉換介面<平台訂單匯入資料>
    {
        public abstract IEnumerable<平台訂單匯入資料> 轉換(動態匯入檔案結構 動態匯入檔案結構_);

        public abstract void 回單(IEnumerable<平台訂單新增資料> 資料_);


        public virtual String 取得分組識別(平台訂單新增資料 資料_)
        {
            return String.Format("{0}_{1}_{2}_{3}", 資料_.公司.名稱, 資料_.客戶.名稱, 資料_.姓名, 資料_.地址);
        }

        public virtual String 取得配送姓名(平台訂單新增資料 資料_)
        {
            return 資料_.姓名;
        }

        public virtual String 取得配送備註(平台訂單新增資料 資料_)
        {
            if (String.IsNullOrEmpty(資料_.備註))
                return 資料_.客戶.名稱;
            else
                return String.Format("{0}({1})", 資料_.客戶.名稱, 資料_.備註);
        }

        public virtual void 併單檢查合法(平台訂單新增資料 主單_, 平台訂單新增資料 子單_)
        {
            if (主單_.公司 != 子單_.公司)
                throw new Exception("併單檢查合法:公司不一致:" + 主單_.配送分組);

            if (主單_.客戶 != 子單_.客戶)
                throw new Exception("併單檢查合法:客戶不一致:" + 主單_.配送分組);

            if (主單_.姓名 != 子單_.姓名)
                throw new Exception("併單檢查合法:姓名不一致:" + 主單_.配送分組);

            if (主單_.地址 != 子單_.地址)
                throw new Exception("併單檢查合法:地址不一致:" + 主單_.配送分組);

            if (主單_.配送公司 != 子單_.配送公司)
                throw new Exception("併單檢查合法:配送不一致:" + 主單_.配送分組);

            if (主單_.指配日期 != 子單_.指配日期)
                throw new Exception("併單檢查合法:指配日期不一致:" + 主單_.配送分組);

            if (主單_.指配時段 != 子單_.指配時段)
                throw new Exception("併單檢查合法:指配時段不一致:" + 主單_.配送分組);

            if (主單_.代收方式 != 子單_.代收方式)
                throw new Exception("併單檢查合法:代收方式不一致:" + 主單_.配送分組);
        }
    }
}
