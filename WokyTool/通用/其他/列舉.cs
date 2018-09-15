using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 列舉
    {
        public static bool 是否合法(int 編號)
        {
            return 編號 >= 常數.空白列舉編碼;
        }

        public static bool 是否有值(int 編號)
        {
            return 編號 > 常數.空白列舉編碼;
        }

        public enum 編號
        {
            錯誤 = 常數.錯誤列舉編碼,
            無 = 常數.空白列舉編碼,

            編號 = 1,
            使用者,

            聯絡人,

            客戶,
            子客戶,

            公司,

            物品品牌,
            物品大類,
            物品小類,
            物品,

            商品大類,
            商品小類,
            商品,

            月結帳設定,
            月結帳,

            平台訂單設定,
            平台訂單新增,
            平台訂單,

            使用者自動產生類型 = 1000,   // 編號 = "編號" + 使用者ID * 1000


            /***************/

            廠商 = 10000,

            支出,

            幣值,

            入庫,
            入庫紀錄,

            銷售,
            盤點,

            訂單,
        };

        // 配送指定時段
        public enum 指配時段
        {
            錯誤 = 常數.錯誤列舉編碼,
            無 = 常數.空白列舉編碼,

            上午 = 1,
            下午,
            晚上,
        };

        // 配送代收款方式
        public enum 代收方式
        {
            錯誤 = 常數.錯誤列舉編碼,
            無 = 常數.空白列舉編碼,

            現金 = 1,
            刷卡,
        };

        // 配送公司
        public enum 配送公司
        {
            錯誤 = 常數.錯誤列舉編碼,
            無 = 常數.空白列舉編碼,

            全速配 = 1,
            宅配通,
        };

      
        // 檔案格式
        public enum 檔案格式
        {
            錯誤 = 常數.錯誤列舉編碼,
            無 = 常數.空白列舉編碼,

            CSV = 1,
            EXCEL = 2,
            PDF = 3,
            JSON = 4,
        };

        public enum 更新狀態
        {
            錯誤 = 常數.錯誤列舉編碼,
            無 = 常數.空白列舉編碼,

            新增 = 1,
            相同,
            更新,
        };

        public enum 資料格式
        {
            錯誤 = 常數.錯誤列舉編碼,
            無 = 常數.空白列舉編碼,

            整數 = 1,
            金額 = 2,
            文字 = 3,
        };

        public enum 商品識別
        {
            錯誤 = 常數.錯誤列舉編碼,
            無 = 常數.空白列舉編碼,

            商品編號 = 1,
            商品編號_顏色 = 2,
            商品名稱 = 3,
        };

        public enum 視窗
        {
            錯誤 = 常數.錯誤列舉編碼,
            無 = 常數.空白列舉編碼,

            總覽 = 1,
            詳細 = 2,
            篩選 = 3,
            匯入 = 4,
        };

        public enum 訂單處理狀態
        {
            錯誤 = 常數.錯誤列舉編碼,
            新增 = 常數.空白列舉編碼,

            配送 = 1,
            歸檔 = 2,
            結單 = 3,
        };
    }
}
