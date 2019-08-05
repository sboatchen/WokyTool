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
    public class 讀寫測試資料管理器 : 可列舉資料管理介面
    {
        protected Dictionary<int, 讀寫測試資料> _資料書 = null;

        public int 資料版本 { get; protected set; }
        
        public object 資料列舉 
        {   
            get 
            { 
                return _資料書.Select(Pair => Pair.Value); 
            } 
        }

        public IEnumerable<讀寫測試資料> 取得清單特殊選項()
        {
            yield return 讀寫測試資料.空白資料;
            yield return 讀寫測試資料.錯誤資料;
        }

        public 新版可篩選介面<讀寫測試資料> 取得篩選介面()
        {
            return new 讀寫測試資料篩選();
        }

        public 可篩選列舉資料管理介面 資料清單管理器
        {
            get
            {
                return new 讀寫測試資料清單管理器(this, 取得篩選介面(), 取得清單特殊選項());
            }
        }

        private 讀寫測試資料編輯管理器 _資料編輯管理器獨體 = null;
        public 可篩選列舉資料管理介面 資料編輯管理器
        {
            get
            {
                if (_資料編輯管理器獨體 == null)
                    _資料編輯管理器獨體 = new 讀寫測試資料編輯管理器(this, 取得篩選介面());
                return _資料編輯管理器獨體;
            }
        }

        private static readonly 讀寫測試資料管理器 _獨體 = new 讀寫測試資料管理器();
        public static 讀寫測試資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        protected 讀寫測試資料管理器()
        {
            _資料書 = new Dictionary<int, 讀寫測試資料>();

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

                _資料書.Add(讀寫測試資料_.整數, 讀寫測試資料_);
            }
        }
    }
}
