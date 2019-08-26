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
    public class 讀寫測試資料管理器 : 可管理資料管理器<讀寫測試資料>
    {
        protected List<讀寫測試資料> _資料列 = null;

        public override IEnumerable<讀寫測試資料> 資料列舉2 
        {   
            get 
            { 
                return _資料列; 
            } 
        }

        protected override IEnumerable<讀寫測試資料> 取得清單特殊選項()
        {
            yield return 讀寫測試資料.空白;
            yield return 讀寫測試資料.錯誤;
        }

        protected override IEnumerable<讀寫測試資料> 取得篩選特殊選項()
        {
            yield return 讀寫測試資料.不篩;
            yield return 讀寫測試資料.空白;
            yield return 讀寫測試資料.錯誤;
        }

        protected override 新版可篩選介面<讀寫測試資料> 取得篩選器實體()
        {
            return new 讀寫測試資料篩選();
        }

        public override bool 是否可編輯 { get { return true;  } }

        private static readonly 讀寫測試資料管理器 _獨體 = new 讀寫測試資料管理器();
        public static 讀寫測試資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        protected 讀寫測試資料管理器()
        {
            _資料列 = new List<讀寫測試資料>();

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

                _資料列.Add(讀寫測試資料_);
            }
        }

        public override void 更新資料(object 資料列obj_)
        {
            IEnumerable<讀寫測試資料> 資料列舉_ = 資料列obj_ as IEnumerable<讀寫測試資料>;
            if (資料列舉_ == null)
            {
                訊息管理器.獨體.錯誤("更新資料型別錯誤: " + 資料列obj_.GetType().Name);
                return;
            }

            _資料列 = 資料列舉_.ToList();
            資料版本++;
        }
    }
}
