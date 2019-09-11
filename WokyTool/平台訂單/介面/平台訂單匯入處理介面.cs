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

namespace WokyTool.平台訂單
{
    public abstract class 平台訂單匯入處理介面
    {
        public 公司資料 公司 { get; set; }
        public 客戶資料 客戶 { get; set; }

        public virtual void 後續處理(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
        }

        public virtual String 取得分組識別(平台訂單新增資料 資料_)
        {
            return String.Format("{0}_{1}_{2}_{3}", 資料_.公司.名稱, 資料_.客戶.名稱, 資料_.姓名, 資料_.地址);
            //return String.Format("{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}", 資料_.公司.名稱, 資料_.客戶.名稱, 資料_.姓名, 資料_.地址, 資料_.配送公司, 資料_.指配日期, 資料_.指配時段, 資料_.代收方式);
            //@@ 請確認合理分組方法 + 併單檢查合法
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

        public virtual void 併單檢查合法(可檢查介面 檢查器_, 平台訂單新增資料 主單_, 平台訂單新增資料 子單_)
        {
            if (主單_.公司 != 子單_.公司)
                檢查器_.錯誤(主單_, "公司不一致");

            if (主單_.客戶 != 子單_.客戶)
                 檢查器_.錯誤(主單_, "客戶不一致");

            if (主單_.姓名 != 子單_.姓名)
                 檢查器_.錯誤(主單_, "姓名不一致");

            if (主單_.地址 != 子單_.地址)
                 檢查器_.錯誤(主單_, "地址不一致");

            if (主單_.配送公司 != 子單_.配送公司)
                檢查器_.錯誤(主單_, "配送公司不一致");

            if (主單_.配送單號 != 子單_.配送單號)
                檢查器_.錯誤(主單_, "配送單號不一致");

            if (主單_.指配日期 != 子單_.指配日期)
                 檢查器_.錯誤(主單_, "指配日期不一致");

            if (主單_.指配時段 != 子單_.指配時段)
                 檢查器_.錯誤(主單_, "指配時段不一致");

            if (主單_.代收方式 != 子單_.代收方式)
                 檢查器_.錯誤(主單_, "代收方式不一致");
        }
    }
}
