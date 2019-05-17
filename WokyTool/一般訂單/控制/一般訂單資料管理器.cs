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

namespace WokyTool.一般訂單
{
    public class 一般訂單資料管理器 : 資料管理器<一般訂單資料>
    {
        public override string 檔案路徑 
        {
            get 
            {
                return "進度/一般訂單.json"; 
            } 
        }

        public string 合併檔案路徑
        {
            get
            {
                return "進度/一般訂單待合併";
            }
        }

        public override 一般訂單資料 空白資料
        {
            get
            {
                return 一般訂單資料.NULL;
            }
        }

        public override 一般訂單資料 錯誤資料
        {
            get 
            {
                return 一般訂單資料.ERROR; 
            } 
        }

        public override 列舉.編號 編號類型
        { 
            get 
            { 
                return 列舉.編號.一般訂單; 
            } 
        }

        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.修改設定資料;
            }
        }

        // 獨體
        private static readonly 一般訂單資料管理器 _獨體 = new 一般訂單資料管理器();
        public static 一般訂單資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 一般訂單資料管理器()
        {
        }

        public void 合併()   //@@
        {
            // 檢查路徑是否存在
            if (Directory.Exists(合併檔案路徑) == false)
                return;

            string[] files = Directory.GetFiles(合併檔案路徑, "*.json", SearchOption.AllDirectories);
            if (files.Length == 0)
                return;

            List<一般訂單資料> List = new List<一般訂單資料>();
            foreach(String fileName in files){
                string json = 檔案.讀出檔案(fileName, 資料是否加密);
                List<一般訂單資料> temp = JsonConvert.DeserializeObject<List<一般訂單資料>>(json);
                List.AddRange(temp);

                檔案.搬移(fileName);
            }

            this.新增(List);
        }
    }
}
