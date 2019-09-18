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
        public 平台訂單新增資料 來源資料 { get; protected set; }

        /********************************/

        public 平台訂單配送轉換資料(平台訂單新增資料 來源資料_)
        {
            來源資料 = 來源資料_;

            轉換.配送公司 = 來源資料.配送公司;
            轉換.配送單號 = 來源資料.配送單號;

            轉換.姓名 = 來源資料.處理器.取得配送姓名(來源資料_);
            轉換.地址 = 來源資料.地址;
            轉換.電話 = 來源資料.電話;
            轉換.手機 = 來源資料.手機;

            轉換.指配日期 = 來源資料.指配日期;
            轉換.指配時段 = 來源資料.指配時段;

            轉換.代收方式 = 來源資料.代收方式;
            轉換.代收金額 = 來源資料.代收金額;

            轉換.備註 = 來源資料.處理器.取得配送備註(來源資料_);

            轉換.件數 = 1;

            物品合併資料.共用.清除();
            物品合併資料.共用.新增(來源資料);
            轉換.內容 = 物品合併資料.共用.ToString();

            // 配送公司
            if (配送公司 != 列舉.配送公司.無)
                return;
            配送公司 = 物品合併資料.共用.推薦配送公司;
        }

        public override void 撿貨合併(物品合併資料 合併資料_)
        {
            合併資料_.新增(來源資料.商品, 來源資料.數量);
        }

        public override bool 更新來源()
        {
            if (轉換.處理時間.Ticks == 0)
                return false;

            來源資料.BeginEdit();

            來源資料.配送公司 = 轉換.配送公司;
            來源資料.處理狀態 = 列舉.訂單處理狀態.配送;
            來源資料.配送單號 = 轉換.配送單號;

            return true;
        }

        public override string 客戶名稱
        {
            get { return 來源資料.客戶.名稱; }
        }
    }
}
