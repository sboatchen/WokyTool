using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.通用;

namespace WokyTool.配送
{
    public class 配送明細轉換 : 可寫入介面_EXCEL
    {
        public string 分類 { get { return null; } }

        public string 樣板 { get { return null; } }

        public XlFileFormat 格式 { get { return XlFileFormat.xlWorkbookNormal; } }

        public string 密碼 { get { return null; } }

        private IEnumerable<配送轉換資料> _資料列舉;
        private 平台訂單配送轉換資料_超商 _超商資料;

        public 配送明細轉換(IEnumerable<配送轉換資料> 資料列舉_)
        {
            _資料列舉 = 資料列舉_;
        }

        public 配送明細轉換(平台訂單配送轉換資料_超商 超商資料_)
        {
            _超商資料 = 超商資料_;
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "平台";
            App_.Cells[1, 2] = "姓名";
            App_.Cells[1, 3] = "明細";

            int 目前行數_ = 2;

            if (_資料列舉 != null)
            {
                foreach (配送轉換資料 資料_ in _資料列舉)
                {
                    App_.Cells[目前行數_, 1] = 資料_.客戶名稱;
                    App_.Cells[目前行數_, 2] = 資料_.姓名;
                    App_.Cells[目前行數_, 3] = 資料_.內容;

                    目前行數_++;
                }
            }

            if (_超商資料 != null)
            {
                foreach (var Group_ in _超商資料.來源資料列.GroupBy(Value => Value.配送單號))
                {
                    var 第一筆_ = Group_.First();

                    App_.Cells[目前行數_, 1] = 第一筆_.客戶名稱;
                    App_.Cells[目前行數_, 2] = 第一筆_.姓名;

                    物品合併資料.共用.清除();
                    物品合併資料.共用.新增(第一筆_);

                    foreach (平台訂單新增資料 資料_ in Group_.Skip(1))
                    {
                        if (第一筆_.姓名 != 資料_.姓名)
                            throw new Exception("併單姓名不統一 " + Group_.Key);

                        物品合併資料.共用.新增(資料_);
                    }

                    App_.Cells[目前行數_, 3] = 物品合併資料.共用.ToString();

                    目前行數_++;
                }
            }
        }
    }
}
