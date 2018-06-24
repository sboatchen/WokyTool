﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳資料管理器 : 資料管理器<月結帳資料>
    {
        public override string 檔案路徑 
        {
            get 
            { 
                return "進度/月結帳.json"; 
            } 
        }

        public override 月結帳資料 錯誤資料
        {
            get 
            {
                return 月結帳資料.ERROR; 
            } 
        }

        public override 列舉.編碼類型 編碼類型 
        { 
            get 
            { 
                return 列舉.編碼類型.月結帳; 
            } 
        }

        // 獨體
        private static readonly 月結帳資料管理器 _獨體 = new 月結帳資料管理器();
        public static 月結帳資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 月結帳資料管理器()
        {
        }
    }
}
