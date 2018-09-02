using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品新增匯入管理器 : 匯入資料管理器<物品新增匯入資料>
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
            物品資料管理器.獨體.新增(可編輯BList.Select(Value => 建立資料(Value)));
        }

        protected 物品資料 建立資料(物品新增匯入資料 匯入資料_)
        {
            物品資料 Data_ = new 物品資料
            {
                大類 = 匯入資料_.大類,
                小類 = 匯入資料_.小類,
                品牌 = 匯入資料_.品牌,

                條碼 = 匯入資料_.條碼,
                原廠編號 = 匯入資料_.原廠編號,
                代理編號 = 匯入資料_.代理編號,

                名稱 = 匯入資料_.名稱,
                縮寫 = 匯入資料_.縮寫,

                體積 = 匯入資料_.體積,
                顏色 = 匯入資料_.顏色,

                內庫數量 = 匯入資料_.內庫數量,
                外庫數量 = 匯入資料_.外庫數量,

                庫存總成本 = 匯入資料_.庫存總成本,
                最後進貨成本 = 匯入資料_.最後進貨成本,
                成本備註 = 匯入資料_.成本備註,
            };

            return Data_;
        } 
    }
}
