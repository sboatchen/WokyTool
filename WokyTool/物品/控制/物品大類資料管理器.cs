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

namespace WokyTool.物品
{
    public class 物品大類資料管理器 : 資料管理器<物品大類資料>
    {
        public override string 檔案路徑 
        {
            get 
            { 
                return "設定/物品大類.json"; 
            } 
        }

        public override 物品大類資料 空白資料
        {
            get
            {
                return 物品大類資料.NULL;
            }
        }

        public override 物品大類資料 錯誤資料
        {
            get 
            {
                return 物品大類資料.ERROR; 
            } 
        }

        public override 列舉.編碼類型 編碼類型 
        { 
            get 
            { 
                return 列舉.編碼類型.物品大類; 
            } 
        }

        // 獨體
        private static readonly 物品大類資料管理器 _獨體 = new 物品大類資料管理器();
        public static 物品大類資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 物品大類資料管理器()
        {
        }
    }
}
