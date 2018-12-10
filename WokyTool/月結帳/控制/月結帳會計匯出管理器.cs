using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳會計匯出管理器 : 匯入資料管理器<月結帳會計資料>
    {
        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.匯入月結帳;
            }
        }

        protected override void 匯入()
        {
            可序列化_Excel 月結帳會計匯出轉換_ = new 月結帳會計匯出轉換(可編輯BList);

            List<可序列化_Excel> List_ = new List<可序列化_Excel>();

            月結帳總計匯出轉換 月結帳總計匯出轉換_ = new 月結帳總計匯出轉換();

            var ItemGroup_ = 月結帳資料管理器.獨體.可編輯BList
                                .GroupBy(
                                    Value => Value.公司.名稱 + " - " + Value.客戶.名稱,
                                    Value => Value);

            foreach (var x in ItemGroup_)
            {
                月結帳分頁匯出轉換 月結帳分頁匯出轉換_ = new 月結帳分頁匯出轉換(x.Key, x);
                List_.Add(月結帳分頁匯出轉換_);

                月結帳總計匯出轉換_.新增(月結帳分頁匯出轉換_);
            }

            List_.Add(月結帳總計匯出轉換_);
            List_.Add(月結帳會計匯出轉換_);

            string Title_ = String.Format("月結帳總覽_{0}", 時間.目前日期);
            檔案.寫入Excel(Title_, List_);
        }
    }
}
