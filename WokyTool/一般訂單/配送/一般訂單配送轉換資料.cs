﻿using Newtonsoft.Json;
using WokyTool.Common;
using WokyTool.單品;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 一般訂單配送轉換資料 : 配送轉換資料
    {
        public 一般訂單新增資料 來源資料 { get; protected set; }

        /********************************/

        public 一般訂單配送轉換資料(一般訂單新增資料 來源資料_)
        {
            來源資料 = 來源資料_;

            轉換.配送公司 = 來源資料.配送公司;
            轉換.配送單號 = 來源資料.配送單號;

            //轉換.訂單編號 = 來源資料.訂單編號;
            轉換.姓名 = 來源資料.姓名;
            轉換.地址 = 來源資料.地址;
            轉換.電話 = 來源資料.電話;
            轉換.手機 = 來源資料.手機;

            轉換.指配日期 = 來源資料.指配日期;
            轉換.指配時段 = 來源資料.指配時段;

            轉換.代收方式 = 來源資料.代收方式;
            轉換.代收金額 = 來源資料.代收金額;

            轉換.備註 = 字串.空;

            轉換.件數 = 1;

            單品合併資料.共用.清除();
            單品合併資料.共用.新增(來源資料);
            轉換.內容 = 單品合併資料.共用.ToString();

            // 配送公司
            if (配送公司 != 列舉.配送公司.無)
                return;
            配送公司 = 單品合併資料.共用.推薦配送公司;
        }

        public override void 撿貨合併(單品合併資料 合併資料_)
        {
            合併資料_.新增(來源資料);
        }

        public override bool 更新來源()
        {
            if (是否為新配送 == false)
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
