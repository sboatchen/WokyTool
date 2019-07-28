using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.配送
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 平台訂單配送資料 : 可配送資料
    {
        public 平台訂單新增資料 平台訂單 { get; protected set; }

        [JsonProperty]
        public override 列舉.配送公司 配送公司
        {
            get
            {
                return 平台訂單.配送公司;
            }

            set
            {
                平台訂單.BeginEdit();
                平台訂單.配送公司 = value;
            }
        }

        [JsonProperty]
        public override string 配送單號
        {
            get
            {
                return 平台訂單.配送單號;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    平台訂單.BeginEdit();
                    平台訂單.配送單號 = null;
                    平台訂單.處理狀態 = 列舉.訂單處理狀態.新增;
                    平台訂單.處理時間 = new DateTime();
                    return;
                }

                if (String.IsNullOrEmpty(平台訂單.配送單號) == false)
                {
                    訊息管理器.獨體.警告("資料重複配送 " + this.ToString());
                    return;
                }

                if (平台訂單.處理狀態 != 列舉.訂單處理狀態.新增)
                {
                    訊息管理器.獨體.警告("訂單處理狀態不合法 " + this.ToString());
                    return;
                }

                平台訂單.BeginEdit();
                平台訂單.配送單號 = value;
                平台訂單.處理狀態 = 列舉.訂單處理狀態.配送;
                平台訂單.處理時間 = DateTime.Now;
            }
        }

        public 平台訂單配送資料(平台訂單新增資料 平台訂單_)
        {
            this.平台訂單 = 平台訂單_;
            this.配送參考 = this.平台訂單;

            this.姓名 = 平台訂單_.自定義介面.取得配送姓名(平台訂單_);
            this.備註 = 平台訂單_.自定義介面.取得配送備註(平台訂單_);

            初始化();
        }
    }
}
