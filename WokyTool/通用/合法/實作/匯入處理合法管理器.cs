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
    public class 匯入處理合法管理器 : 可處理合法介面
    {
        private StringBuilder _SB = new StringBuilder();

        public List<String> 字串列 { get; set; }

        public 匯入處理合法管理器()
        {
            字串列 = new List<string>();
        }


        public void 錯誤(基本資料 資料_, string 訊息_)
        {
            可匯入資料 可匯入資料_ = 資料_ as 可匯入資料;
            if (可匯入資料_ == null)
                throw new Exception("匯入處理合法管理器處理失敗:不是可匯入資料");

            if (string.IsNullOrEmpty(可匯入資料_.錯誤訊息))
                可匯入資料_.錯誤訊息 = 訊息_;
            else
                可匯入資料_.錯誤訊息 += ";" + 訊息_;
        }
    }
}
