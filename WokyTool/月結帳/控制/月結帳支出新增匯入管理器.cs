using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳支出新增匯入管理器 : 匯入資料管理器<月結帳支出新增匯入資料>
    {
        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.匯入月結帳;
            }
        }

        protected override void 匯入()
        {
            月結帳支出資料管理器.獨體.新增(可編輯BList.Select(Value => 建立資料(Value)));
        }

        protected 月結帳支出資料 建立資料(月結帳支出新增匯入資料 匯入資料_)
        {
            月結帳支出資料 Data_ = new 月結帳支出資料
            {
                傳票號碼 = 匯入資料_.傳票號碼,
                廠商 = 匯入資料_.廠商,
                費用 = 匯入資料_.費用,
            };

            return Data_;
        } 
    }
}
