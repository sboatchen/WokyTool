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

namespace WokyTool.通用
{
    public class 列表檢查器 : 可檢查介面
    {
        public bool 是否合法
        {
            get { return 字串列.Count == 0; }
        }

        private StringBuilder _SB = new StringBuilder();

        public List<String> 字串列 { get; set; }

        public 列表檢查器()
        {
            字串列 = new List<string>();
        }

        public void 錯誤(基本資料 資料_, string 訊息_)
        {
            _SB.Clear();

            Type Type_ = 資料_.GetType();
            _SB.Append(Type_.Name).Append(":").Append(訊息_);
            _SB.Append(資料_.ToString(false));

            字串列.Add(_SB.ToString());
        }
    }
}
