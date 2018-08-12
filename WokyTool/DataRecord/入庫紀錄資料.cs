using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.DataRecord
{
    class 入庫紀錄資料
    {
        public DateTime 時間 { get; set; }

        public int 編號 { get; set; }

        public string 公司 { get; set; }
        public string 廠商 { get; set; }
        public string 商品 { get; set; }
        public int 數量 { get; set; }

        public 入庫紀錄資料()
        {
            編號 = 常數.新資料編碼;
            時間 = DateTime.Now;

            公司 = string.Empty;
            廠商 = string.Empty;

            商品 = string.Empty;
            數量 = 0;
        }

        //@@ 該class 尚未完成實作 從 入庫資料到入庫紀錄資料

        public static 入庫紀錄資料 New()
        {
            入庫紀錄資料 New_ = new 入庫紀錄資料();
            New_.編號 = 編碼管理器.Instance.Get(列舉.編號.入庫紀錄);

            return New_;
        }

        private static readonly 入庫紀錄資料 _NULL = new 入庫紀錄資料
        {
            編號 = 常數.空白資料編碼,
            時間 = new DateTime(0),
            公司 = 字串.無,
            廠商 = 字串.無,
            商品 = 字串.無,
            數量 = 0,
        };
        public static 入庫紀錄資料 NULL{ get{ return _NULL; } }

        private static 入庫紀錄資料 _ERROR = new 入庫紀錄資料
        {
            編號 = 常數.錯誤資料編碼,
            時間 = new DateTime(0),
            公司 = 字串.錯誤,
            廠商 = 字串.錯誤,
            商品 = 字串.錯誤,
            數量 = 0,
        };
        public static 入庫紀錄資料 ERROR{ get{ return _ERROR; } }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
