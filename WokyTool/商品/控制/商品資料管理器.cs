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

namespace WokyTool.商品
{
    public class 商品資料管理器 : 資料管理器<商品資料>
    {
        public override string 檔案路徑 
        {
            get 
            { 
                return "設定/商品.json"; 
            } 
        }

        public override 商品資料 空白資料
        {
            get
            {
                return 商品資料.NULL;
            }
        }

        public override 商品資料 錯誤資料
        {
            get 
            {
                return 商品資料.ERROR; 
            } 
        }

        public 商品資料 折扣資料
        {
            get
            {
                return 商品資料.折扣;
            }
        }

        public override 列舉.編號 編號類型
        { 
            get 
            { 
                return 列舉.編號.商品; 
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
        private static readonly 商品資料管理器 _獨體 = new 商品資料管理器();
        public static 商品資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 商品資料管理器()
        {
        }

        // 商品特殊資料
        protected override void 更新唯讀列表特殊資料()
        {
            唯讀BList.Add(折扣資料);
        }

        // 取得資料
        public override 商品資料 Get(int ID_)
        {
            if (ID_ == 常數.T空白資料編碼)
                return 空白資料;

            if (ID_ == 常數.T錯誤資料編碼)
                return 錯誤資料;

            if (ID_ == 常數.商品折扣資料編碼)
                return 折扣資料;

            商品資料 Item_;
            if (Map.TryGetValue(ID_, out Item_))
            {
                return Item_;
            }

            return 錯誤資料;
        }

        // 取得資料
        public 商品資料 Get(int 客戶編號, string 品號)
        {
            if (String.IsNullOrEmpty(品號))
                return 空白資料;

            商品資料 Item_ = Map.Values
                                   .Where(Value => Value.客戶編號 == 客戶編號)
                                   .Where(Value => 品號.Equals(Value.品號))
                                   .FirstOrDefault();

            if (Item_ == null)
                return 錯誤資料;
            else
                return Item_;
        }

        // 取得資料
        public 商品資料 GetByName(int 客戶編號, string 商品名稱)
        {
            if (String.IsNullOrEmpty(商品名稱))
                return 空白資料;

            商品資料 Item_ = Map.Values
                                   .Where(Value => Value.客戶編號 == 客戶編號)
                                   .Where(Value => 商品名稱.Equals(Value.名稱))
                                   .FirstOrDefault();

            if (Item_ == null)
                return 錯誤資料;
            else
                return Item_;
        }
    }
}
