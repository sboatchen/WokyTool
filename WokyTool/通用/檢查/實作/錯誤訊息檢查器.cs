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
    public class 錯誤訊息檢查器 : 可檢查介面
    {
        public bool 是否合法 { get; protected set; }

        public 錯誤訊息檢查器()
        {
            是否合法 = true;
        }

        public void 錯誤(基本資料 資料_, string 訊息_)
        {
            是否合法 = false;

            可記錄錯誤介面 可記錄錯誤資料_ = 資料_ as 可記錄錯誤介面;
            if (可記錄錯誤資料_ == null)
                throw new Exception("錯誤訊息檢查器處理失敗:不是可記錄錯誤資料");

            if (string.IsNullOrEmpty(可記錄錯誤資料_.錯誤訊息))
                可記錄錯誤資料_.錯誤訊息 = 訊息_;
            else
                可記錄錯誤資料_.錯誤訊息 += ";" + 訊息_;
        }
    }
}
