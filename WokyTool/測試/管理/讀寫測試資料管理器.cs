using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.測試
{
    public class 讀寫測試資料管理器 : 可暫存資料管理器<讀寫測試資料>
    {
        protected override 新版可篩選介面<讀寫測試資料> 取得篩選器實體()
        {
            return new 讀寫測試資料篩選();
        }

        private static readonly 讀寫測試資料管理器 _獨體 = new 讀寫測試資料管理器();
        public static 讀寫測試資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        protected 讀寫測試資料管理器()
        {
            Random 隨機_ = new Random();
            for (int i = 1; i <= 100; i++)
            {
                讀寫測試資料 讀寫測試資料_ = new 讀寫測試資料
                {
                    字串 = "字串" + i,
                    整數 = i,
                    浮點數 = (float)隨機_.NextDouble(),
                    倍精準浮點數 = 隨機_.NextDouble(),
                    時間 = DateTime.Now.AddMinutes(i),
                    列舉 = (列舉.編號)(i % 10 + 1),
                };

                資料列.Add(讀寫測試資料_);
            }
        }
    }
}
