using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 平台訂單配送轉換資料 : 配送轉換資料
    {
        [可匯出]
        [JsonProperty]
        public override 列舉.配送公司 配送公司
        {
            get
            {
                return 目標資料.配送公司;
            }

            set
            {
                if(目標資料.配送公司 == value)
                    return;

                來源資料.BeginEdit();
                來源資料.配送公司 = value;
                目標資料.配送公司 = value;
            }
        }

        [可匯出]
        [JsonProperty]
        public override string 配送單號
        {
            get
            {
                return 目標資料.配送單號;
            }

            set
            {
                if (目標資料.配送單號 == value)
                    return;

                if (String.IsNullOrEmpty(value))
                {
                    訊息管理器.獨體.警告("目標資料單號不可設定為空");
                    return;
                }


                if (String.IsNullOrEmpty(目標資料.配送單號) == false)
                {
                    訊息管理器.獨體.警告("資料重複目標資料 " + this.ToString(false));
                    return;
                }

                來源資料.BeginEdit();
                來源資料.處理狀態 = 列舉.訂單處理狀態.配送;
                來源資料.配送單號 = value;
                目標資料.處理時間 = DateTime.Now;
                目標資料.配送單號 = value;
            }
        }

        /********************************/

        public 平台訂單新增資料 來源資料 { get; protected set; }

        /********************************/

        public 平台訂單配送轉換資料(平台訂單新增資料 來源資料_)
        {
            來源資料 = 來源資料_;

            目標資料.配送公司 = 來源資料.配送公司;
            目標資料.配送單號 = 來源資料.配送單號;

            目標資料.姓名 = 來源資料.處理器.取得配送姓名(來源資料_);
            目標資料.地址 = 來源資料.地址;
            目標資料.電話 = 來源資料.電話;
            目標資料.手機 = 來源資料.手機;

            目標資料.指配日期 = 來源資料.指配日期;
            目標資料.指配時段 = 來源資料.指配時段;

            目標資料.代收方式 = 來源資料.代收方式;
            目標資料.代收金額 = 來源資料.代收金額;

            目標資料.備註 = 來源資料.處理器.取得配送備註(來源資料_);

            目標資料.件數 = 1;

            物品合併資料.共用.清除();
            物品合併資料.共用.新增(來源資料.商品, 來源資料.數量);
            目標資料.內容 = 物品合併資料.共用.ToString();

            // 配送公司
            if (配送公司 != 列舉.配送公司.無)
                return;

            if (物品合併資料.共用.體積 >= 常數.宅配通配送最小體積)
                配送公司 = 列舉.配送公司.宅配通;
            else
                配送公司 = 列舉.配送公司.全速配;
        }
    }
}
