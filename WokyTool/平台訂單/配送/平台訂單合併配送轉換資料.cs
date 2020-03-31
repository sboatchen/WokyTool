using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.單品;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 平台訂單合併配送轉換資料 : 配送轉換資料
    {
        public List<平台訂單新增資料> 來源資料列 { get; protected set; }

        private static 可檢查介面 合併檢查器 = new 例外檢查器();

        /********************************/

        public 平台訂單合併配送轉換資料(List<平台訂單新增資料> 來源資料列_)
        {
            if(來源資料列_.Count == 0)
                throw new Exception("併單數量為0");

            平台訂單新增資料 第一筆資料_ = 來源資料列_[0];

            來源資料列 = 來源資料列_;

            轉換.配送公司 = 第一筆資料_.配送公司;
            轉換.配送單號 = 第一筆資料_.配送單號;

            轉換.訂單編號 = 第一筆資料_.訂單編號;
            轉換.姓名 = 第一筆資料_.處理器.取得配送姓名(第一筆資料_);
            轉換.地址 = 第一筆資料_.地址;
            轉換.電話 = 第一筆資料_.電話;
            轉換.手機 = 第一筆資料_.手機;

            轉換.指配日期 = 第一筆資料_.指配日期;
            轉換.指配時段 = 第一筆資料_.指配時段;

            轉換.代收方式 = 第一筆資料_.代收方式;
            轉換.代收金額 = 第一筆資料_.代收金額;

            轉換.備註 = 第一筆資料_.處理器.取得配送備註(第一筆資料_);

            轉換.件數 = 1;

            單品合併資料.共用.清除();
            單品合併資料.共用.新增(第一筆資料_);

            foreach (平台訂單新增資料 來源資料_ in 來源資料列.Skip(1))
            {
                第一筆資料_.處理器.併單檢查合法(合併檢查器, 第一筆資料_, 來源資料_);

                轉換.代收金額 += 來源資料_.代收金額;

                單品合併資料.共用.新增(來源資料_);
            }

            轉換.內容 = 單品合併資料.共用.ToString();

            // 配送公司
            if (配送公司 != 列舉.配送公司.無)
                return;
            配送公司 = 單品合併資料.共用.推薦配送公司;
        }

        public override void 撿貨合併(單品合併資料 合併資料_)
        {
            foreach (平台訂單新增資料 來源資料_ in 來源資料列)
            {
                合併資料_.新增(來源資料_);
            }
        }

        public override bool 更新來源()
        {
            if (是否為新配送 == false)
                return false;

            foreach (平台訂單新增資料 來源資料_ in 來源資料列)
            {
                來源資料_.BeginEdit();

                來源資料_.配送公司 = 轉換.配送公司;
                來源資料_.處理狀態 = 列舉.訂單處理狀態.配送;
                來源資料_.配送單號 = 轉換.配送單號;
            }

            return true;
        }

        public override string 客戶名稱
        {
            get { return 來源資料列.First().客戶.名稱; }
        }
    }
}
