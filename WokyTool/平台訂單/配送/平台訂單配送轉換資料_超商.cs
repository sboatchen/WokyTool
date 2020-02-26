using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.單品;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public abstract class 平台訂單配送轉換資料_超商 : 配送轉換資料, 可寫入介面_PDF
    {
        public abstract string 標頭 { get; }

        public abstract string 密碼 { get; }

        public List<平台訂單新增資料> 來源資料列 { get; protected set; }

        public 平台訂單配送轉換資料_超商(List<平台訂單新增資料> 來源資料列_)
        {
            //if (來源資料列_.Count == 0)
            //    throw new Exception("併單數量為0");

            來源資料列 = 來源資料列_;

            轉換.配送單號 = "合併訂單";

            /*轉換.姓名 = 第一筆資料_.處理器.取得配送姓名(第一筆資料_);    //@@ 取得超商配送相關資料
            轉換.地址 = 第一筆資料_.地址;
            轉換.電話 = 第一筆資料_.電話;
            轉換.手機 = 第一筆資料_.手機;*/

            轉換.件數 = 1;
            轉換.內容 = "請看明細";
        }

        public override void 撿貨合併(單品合併資料 合併資料_)
        {
            foreach (平台訂單新增資料 來源資料_ in 來源資料列)
            {
                合併資料_.新增(來源資料_.商品, 來源資料_.數量);
            }
        }

        public override string 客戶名稱
        {
            get { return 來源資料列.First().客戶.名稱; }
        }

        public abstract void 寫入(iTextSharp.text.pdf.PdfReader PdfReader_, int 頁索引_, iTextSharp.text.pdf.PdfWriter PdfWriter_);

        public abstract void 測試(iTextSharp.text.pdf.PdfReader PdfReader_, int 頁索引_, iTextSharp.text.pdf.PdfWriter PdfWriter_);
    }
}
