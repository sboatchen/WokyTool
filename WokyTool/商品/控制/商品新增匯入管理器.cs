using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.商品
{
    public class 商品新增匯入管理器 : 匯入資料管理器<商品新增匯入資料>
    {
        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.修改設定資料;
            }
        }

        protected override void 匯入()
        {
            商品資料管理器.獨體.新增(可編輯BList.Select(Value => 建立資料(Value)));
        }

        protected 商品資料 建立資料(商品新增匯入資料 匯入資料_)
        {
            商品資料 Data_ = new 商品資料
            {
                大類 = 匯入資料_.大類,
                小類 = 匯入資料_.小類,

                公司 = 匯入資料_.公司,
                客戶 = 匯入資料_.客戶,

                品號 = 匯入資料_.品號,
                名稱 = 匯入資料_.名稱,

                需求1 = 匯入資料_.需求1,
                需求2 = 匯入資料_.需求2,
                需求3 = 匯入資料_.需求3,
                需求4 = 匯入資料_.需求4,
                需求5 = 匯入資料_.需求5,

                數量1 = 匯入資料_.數量1,
                數量2 = 匯入資料_.數量2,
                數量3 = 匯入資料_.數量3,
                數量4 = 匯入資料_.數量4,
                數量5 = 匯入資料_.數量5,

                寄庫數量 = 匯入資料_.寄庫數量,
                售價 = 匯入資料_.售價,
            };

            return Data_;
        } 
    }
}
