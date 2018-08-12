using Newtonsoft.Json;
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

namespace WokyTool.公司
{
    public class 公司資料管理器 : 資料管理器<公司資料>
    {
        public override string 檔案路徑 
        {
            get 
            { 
                return "設定/公司.json"; 
            } 
        }

        public override 公司資料 空白資料
        {
            get
            {
                return 公司資料.NULL;
            }
        }

        public override 公司資料 錯誤資料
        {
            get 
            {
                return 公司資料.ERROR; 
            } 
        }

        public override 列舉.編號 編號類型
        { 
            get 
            { 
                return 列舉.編號.公司; 
            } 
        }

        // 獨體
        private static readonly 公司資料管理器 _獨體 = new 公司資料管理器();
        public static 公司資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 公司資料管理器()
        {
        }
    }
}
