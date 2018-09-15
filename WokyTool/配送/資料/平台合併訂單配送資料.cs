using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.配送
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 平台合併訂單配送資料 : MyData, 可配送介面
    {
        public List<平台訂單新增資料> 列表 { get; private set; }
        public 平台訂單新增資料 主單 { get; private set; }

        public 物品組成資料 組成 { get; private set; }

        [JsonProperty]
        public string 內容 { get; private set; }

        [JsonProperty]
        public string 姓名 { get; set; }

        [JsonProperty]
        public string 備註 { get; set; }

        [JsonProperty]
        public string 電話
        {
            get
            {
                return 主單.電話;
            }
        }

        [JsonProperty]
        public string 手機
        {
            get
            {
                return 主單.手機;
            }
        }

        [JsonProperty]
        public string 地址
        {
            get
            {
                return 主單.地址;
            }
        }

        [JsonProperty]
        public DateTime 指配日期
        {
            get
            {
                return 主單.指配日期;
            }
        }

        [JsonProperty]
        public 列舉.指配時段 指配時段
        {
            get
            {
                return 主單.指配時段;
            }
        }

        [JsonProperty]
        public 列舉.代收方式 代收方式
        {
            get
            {
                return 主單.代收方式;
            }
        }

        [JsonProperty]
        public decimal 代收金額 { get; private set; }

        [JsonProperty]
        public 列舉.配送公司 配送公司
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
        public string 配送單號 
        {
            get
            {
                return 主單.配送單號;
            }

            set
            {
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
                }
            }
        }

        public bool 是否已配送()
        {
            return String.IsNullOrEmpty(配送單號) == false;
        }

        public 平台合併訂單配送資料(List<平台訂單新增資料> 列表_, 平台訂單自定義介面 介面_)
        {
            this.列表 = 列表_;
            this.主單 = 列表_[0];

            this.組成 = new 物品組成資料();

            foreach (平台訂單新增資料 子單_ in 列表_)
            {
                if (this.主單 != 子單_)
                    介面_.併單檢查合法(主單, 子單_);

                this.組成.append(子單_.商品, 子單_.數量);

                this.代收金額 += 子單_.代收金額;
            }

            this.內容 = this.組成.取得組合字串();

            this.姓名 = 介面_.取得配送姓名(主單);
            this.備註 = 介面_.取得配送備註(主單);
        }
    }
}
