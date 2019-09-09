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
    public class 平台訂單合併配送轉換資料 : 配送轉換資料
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
                if (目標資料.配送公司 == value)
                    return;

                foreach (平台訂單新增資料 來源資料_ in 來源資料列)
                {
                    來源資料_.BeginEdit();
                    來源資料_.配送公司 = value;
                }

                目標資料.配送公司 = value;
            }
        }

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

                foreach (平台訂單新增資料 來源資料_ in 來源資料列)
                {
                    來源資料_.BeginEdit();
                    來源資料_.處理狀態 = 列舉.訂單處理狀態.配送;
                    來源資料_.配送單號 = value;
                }

                目標資料.處理時間 = DateTime.Now;
                目標資料.配送單號 = value;
            }
        }

        /********************************/

        public List<平台訂單新增資料> 來源資料列 { get; protected set; }

        private static 可檢查介面 合併檢查器 = new 例外檢查器();

        /********************************/

        public 平台訂單合併配送轉換資料(List<平台訂單新增資料> 來源資料列_)
        {
            if(來源資料列_.Count == 0)
                throw new Exception("併單數量為0");

            平台訂單新增資料 第一筆資料_ = 來源資料列_[0];

            來源資料列 = 來源資料列_;

            目標資料.配送公司 = 第一筆資料_.配送公司;
            目標資料.配送單號 = 第一筆資料_.配送單號;

            目標資料.姓名 = 第一筆資料_.處理器.取得配送姓名(第一筆資料_);
            目標資料.地址 = 第一筆資料_.地址;
            目標資料.電話 = 第一筆資料_.電話;
            目標資料.手機 = 第一筆資料_.手機;

            目標資料.指配日期 = 第一筆資料_.指配日期;
            目標資料.指配時段 = 第一筆資料_.指配時段;

            目標資料.代收方式 = 第一筆資料_.代收方式;
            目標資料.代收金額 = 第一筆資料_.代收金額;

            目標資料.備註 = 第一筆資料_.處理器.取得配送備註(第一筆資料_);

            目標資料.件數 = 1;

            物品合併資料.共用.清除();
            物品合併資料.共用.新增(第一筆資料_.商品, 第一筆資料_.數量);

            foreach (平台訂單新增資料 來源資料_ in 來源資料列.Skip(1))
            {
                第一筆資料_.處理器.併單檢查合法(合併檢查器, 第一筆資料_, 來源資料_);

                目標資料.代收金額 += 來源資料_.代收金額;

                物品合併資料.共用.新增(來源資料_.商品, 來源資料_.數量);
            }

            目標資料.內容 = 物品合併資料.共用.ToString();

            // 配送公司
            if (配送公司 != 列舉.配送公司.無)
                return;
            配送公司 = 物品合併資料.共用.推薦配送公司;
        }

        public override void 撿貨合併(物品合併資料 合併資料_)
        {
            foreach (平台訂單新增資料 來源資料_ in 來源資料列)
            {
                合併資料_.新增(來源資料_.商品, 來源資料_.數量);
            }
        }
    }
}
