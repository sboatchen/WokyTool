using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public static class 列舉
    {
        // ID管理器用Key
        public enum 編碼類型
        {
            無 = 0,

            廠商,

            物品大類,
            物品小類,
            物品品牌,
            物品,

            商品大類,
            商品小類,
            商品,

            月結帳,

            支出,

            幣值,
        };

        // 配送指定時段類型
        public enum 指配時段類型
        {
            無 = 0,

            上午,
            下午,
            晚上,
        };

        // 配送代收款方式
        public enum 代收類型
        {
            無 = 0,

            現金,
            刷卡,
        };

        // 配送公司類型
        public enum 配送公司類型
        {
            無 = 0,

            全速配,
            宅配通,
        };

        public enum 進貨處理進度類型
        {
            無 = 0,
            
            新建,
            匯入錯誤,
            匯入正確,
            分組完成,
            要求配送,
            配送完成,
        };
    }
}
