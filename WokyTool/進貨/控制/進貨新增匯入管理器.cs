using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.進貨
{
    public class 進貨新增匯入管理器 : 匯入資料管理器<進貨新增匯入資料>
    {
        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.匯入進貨;
            }
        }

        protected override void 匯入()
        {
            進貨資料管理器.獨體.新增(可編輯BList.Select(Value => 建立資料(Value)));
        }

        protected 進貨資料 建立資料(進貨新增匯入資料 匯入資料_)
        {
            進貨資料 Data_ = new 進貨資料
            {
                時間 = DateTime.Now,
                類型 = 匯入資料_.類型,
                廠商 = 匯入資料_.廠商,

                物品 = 匯入資料_.物品,
                數量 = 匯入資料_.數量,
                單價 = 匯入資料_.單價,

                備註 = 匯入資料_.備註,
            };

            return Data_;
        } 
    }
}
