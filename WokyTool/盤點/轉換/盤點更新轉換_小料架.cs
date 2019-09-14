using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.寄庫;
using WokyTool.客戶;
using WokyTool.客製;
using WokyTool.配送;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public class 盤點更新轉換_小料架 : 可讀出介面_EXCEL<盤點更新資料>
    {
        public int 分頁索引 { get { return 1; } }

        public int 標頭索引 { get { return 2; } }

        public int 資料開始索引 { get { return 3; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        protected string[] _標頭列;

        public 盤點更新轉換_小料架()
        {
        }

        public void 讀出標頭(string[] 標頭列_)
        {
            this._標頭列 = 標頭列_;
        }

        public IEnumerable<盤點更新資料> 讀出資料(string[] 資料列_)
        {
            string 物品識別_ = 資料列_[5].轉成字串();
            if (string.IsNullOrEmpty(物品識別_))
            {
                物品識別_ = 資料列_[3].轉成字串();
                if (string.IsNullOrEmpty(物品識別_))
                    yield break;
            }

            int 數量_ = 資料列_[6].轉成整數();

            盤點更新資料 資料_ = new 盤點更新資料();
            資料_.物品識別 = 物品識別_;
            資料_.小料架庫存 = 數量_;

            Console.WriteLine(資料_.ToString(false));

            yield return 資料_;
        }
    }
}
