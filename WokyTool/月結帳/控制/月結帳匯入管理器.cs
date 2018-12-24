using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳匯入管理器 : 匯入資料管理器<月結帳匯入資料>
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
            月結帳資料管理器.獨體.新增(可編輯BList.Select(Value => 建立資料(Value)));
        }

        protected 月結帳資料 建立資料(月結帳匯入資料 匯入資料_)
        {
            月結帳資料 Data_ = new 月結帳資料
            {
                訂單編號 = 匯入資料_.訂單編號,

                設定 = 匯入資料_.設定,

                商品 = 匯入資料_.商品,

                數量 = 匯入資料_.數量,
                單價 = 匯入資料_.單價,
                含稅單價 = 匯入資料_.含稅單價,
            };

            return Data_;
        }
    }
}
