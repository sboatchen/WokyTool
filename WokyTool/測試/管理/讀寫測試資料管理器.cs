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
    public class 讀寫測試資料管理器 /*: 可選取資料列管理介面*/
    {
        // 資料Map
        public Dictionary<int, 讀寫測試資料> 資料書 { get; set; }
        public List<讀寫測試資料> 資料列 { get; set; }

        public int 資料版本 { get; protected set; }

        public 讀寫測試資料篩選 篩選介面 { get; set; }

        private static readonly 讀寫測試資料管理器 _獨體 = new 讀寫測試資料管理器();
        public static 讀寫測試資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        protected 讀寫測試資料管理器()
        {
            資料書 = new Dictionary<int, 讀寫測試資料>();
            資料列 = new List<讀寫測試資料>();

            篩選介面 = new 讀寫測試資料篩選();

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

                資料書.Add(讀寫測試資料_.整數, 讀寫測試資料_);
                資料列 = 
            }
        }

        public 讀寫測試資料 空白資料 { get { return 讀寫測試資料.空白資料; } }
        public 讀寫測試資料 錯誤資料 { get { return 讀寫測試資料.錯誤資料; } }

        private IEnumerable<讀寫測試資料> 取得特殊選取資料()
        {
            yield return 錯誤資料;
            yield return 空白資料;
        }

        private object _可選取資料列 = null;
        public object 取得可選取資料列舉(讀寫測試資料篩選 介面_)
        {
            return 取得特殊選取資料().Union(介面_.篩選(資料書.Select(Pair => Pair.Value))).ToList();
        }

        public IEnumerable<讀寫測試資料> 取得編輯資料列舉(讀寫測試資料篩選 介面_)
        {
            return 介面_.篩選(資料書.Select(Pair => Pair.Value));
        }
    }
}
