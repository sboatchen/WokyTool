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
    public class 平台合併訂單配送資料 : 可配送資料
    {
        public List<平台訂單新增資料> 列表 { get; protected set; }
        public 平台訂單新增資料 主單 { get; protected set; }

        public override 物品合併資料 合併{ get; protected set; }

        [JsonProperty]
        public override decimal 代收金額 { get; protected set; }

        [JsonProperty]
        public override 列舉.配送公司 配送公司
        {
            get
            {
                return 主單.配送公司;
            }

            set
            {
                foreach (平台訂單新增資料 訂單_ in 列表)
                {
                    訂單_.BeginEdit();
                    訂單_.配送公司 = value;
                }
            }
        }

        [JsonProperty]
        public override string 配送單號 
        {
            get
            {
                return 主單.配送單號;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    foreach (平台訂單新增資料 訂單_ in 列表)
                    {
                        訂單_.BeginEdit();
                        訂單_.配送單號 = null;
                        訂單_.處理狀態 = 列舉.訂單處理狀態.新增;
                        訂單_.處理時間 = new DateTime();
                    }

                    return;
                }

                if (String.IsNullOrEmpty(主單.配送單號) == false) 
                {
                    訊息管理器.獨體.Warn("資料重複配送 " + this.ToString());
                    return;
                }

                if (主單.處理狀態 != 列舉.訂單處理狀態.新增)
                {
                    訊息管理器.獨體.Warn("訂單處理狀態不合法 " + this.ToString());
                    return;
                }

                foreach (平台訂單新增資料 訂單_ in 列表)
                {
                    訂單_.BeginEdit();
                    訂單_.配送單號 = value;
                    訂單_.處理狀態 = 列舉.訂單處理狀態.配送;
                    訂單_.處理時間 = DateTime.Now;
                }
            }
        }

        public 平台合併訂單配送資料(List<平台訂單新增資料> 列表_)
        {
            this.列表 = 列表_;
            this.主單 = 列表_[0];
            this.配送參考 = this.主單;

            this.合併 = new 物品合併資料();

            foreach (平台訂單新增資料 子單_ in 列表_)
            {
                if (this.主單 != 子單_)
                    主單.自定義介面.併單檢查合法(主單, 子單_);

                this.合併.新增(子單_.商品, 子單_.數量);

                this.代收金額 += 子單_.代收金額;
            }

            this.姓名 = 主單.自定義介面.取得配送姓名(主單);
            this.備註 = 主單.自定義介面.取得配送備註(主單);

            初始化();
        }
    }
}
