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
    public class 錯誤訊息處理檢查管理器 : 可處理檢查介面
    {
        public bool 是否合法 { get; protected set; }

        public 錯誤訊息處理檢查管理器()
        {
            是否合法 = true;
        }

        public void 錯誤(基本資料 資料_, string 訊息_)
        {
            是否合法 = false;

            可匯入資料 可匯入資料_ = 資料_ as 可匯入資料;
            if (可匯入資料_ == null)
                throw new Exception("錯誤訊息處理檢查管理器處理失敗:不是可匯入資料");

            if (string.IsNullOrEmpty(可匯入資料_.錯誤訊息))
                可匯入資料_.錯誤訊息 = 訊息_;
            else
                可匯入資料_.錯誤訊息 += ";" + 訊息_;
        }
    }
}
