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

namespace WokyTool.編號
{
    public class 編號資料管理器 : 資料管理器<編號資料>
    {
        public override string 檔案路徑 
        {
            get 
            { 
                return "設定/編號.json"; 
            } 
        }

        public override 編號資料 空白資料
        {
            get
            {
                return 編號資料.NULL;
            }
        }

        public override 編號資料 錯誤資料
        {
            get 
            {
                return 編號資料.ERROR; 
            } 
        }

        public override 列舉.編號 編號類型
        { 
            get 
            {
                return 列舉.編號.編號; 
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
        private static readonly 編號資料管理器 _獨體 = new 編號資料管理器();
        public static 編號資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 編號資料管理器()
        {
        }

        // 取得下個唯一識別碼,並進行更新
        public int 下個值(int 編號_)
        {
            編號資料 Item_;
            if (Map.TryGetValue(編號_, out Item_) == false)
            {
                Item_ = new 編號.編號資料
                {
                    編號 = 編號_,
                    下個值 = 0,
                };

                可編輯BList.Add(Item_);
                唯讀BList.Add(Item_);
                Map.Add(編號_, Item_);

                編輯資料版本++;
                唯讀資料版本++;
                資料是否異動 = true;
            }

            int Value_ = Item_.下個值++;

            編輯資料版本++;
            唯讀資料版本++;
            資料是否異動 = true;

            return Value_;
        }
    }
}
