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
                return "設定/商品V2.1.1.json"; 
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

        protected override void 初始化資料()
        {
            if (File.Exists(檔案路徑))
            {
                string json = 檔案.讀出檔案(檔案路徑, 資料是否加密);
                if (String.IsNullOrEmpty(json))
                    Map = new Dictionary<int, 商品資料>();
                else
                    Map = JsonConvert.DeserializeObject<Dictionary<int, 商品資料>>(json);

                資料是否異動 = false;
            }
            else
            {
                Map = new Dictionary<int, 商品資料>();

                // V2.0.X -> V2.1.X
                string json = 檔案.讀出檔案("設定/商品.json", false);
                Dictionary<int, 舊商品資料> 舊Map_ = JsonConvert.DeserializeObject<Dictionary<int, 舊商品資料>>(json);
                foreach (var Item_ in 舊Map_.Values)
                {
                    商品資料 New_ = new 商品.商品資料
                    {
                        編號 = Item_.編號,

                        大類 = Item_.大類,
                        小類 = Item_.小類,

                        公司 = Item_.公司,
                        客戶 = Item_.客戶,

                        品號 = Item_.品號,
                        名稱 = Item_.名稱,

                        寄庫數量 = Item_.寄庫數量,
                        售價 = Item_.售價,
                    };

                    New_.組成 = new List<商品組成資料>();
                    if (Item_.需求1 != 物品.物品資料.NULL)
                    {
                        商品組成資料 組成_ = new 商品組成資料
                        {
                            物品 = Item_.需求1,
                            數量 = Item_.數量1,
                        };

                        New_.組成.Add(組成_);
                    }
                    if (Item_.需求2 != 物品.物品資料.NULL)
                    {
                        商品組成資料 組成_ = new 商品組成資料
                        {
                            物品 = Item_.需求2,
                            數量 = Item_.數量2,
                        };

                        New_.組成.Add(組成_);
                    }
                    if (Item_.需求3 != 物品.物品資料.NULL)
                    {
                        商品組成資料 組成_ = new 商品組成資料
                        {
                            物品 = Item_.需求3,
                            數量 = Item_.數量3,
                        };

                        New_.組成.Add(組成_);
                    }
                    if (Item_.需求4 != 物品.物品資料.NULL)
                    {
                        商品組成資料 組成_ = new 商品組成資料
                        {
                            物品 = Item_.需求4,
                            數量 = Item_.數量4,
                        };

                        New_.組成.Add(組成_);
                    }
                    if (Item_.需求5 != 物品.物品資料.NULL)
                    {
                        商品組成資料 組成_ = new 商品組成資料
                        {
                            物品 = Item_.需求5,
                            數量 = Item_.數量5,
                        };

                        New_.組成.Add(組成_);
                    }

                    Map.Add(New_.編號, New_);
                }

                資料是否異動 = true;
            }

            if (Map.Count == 0)
                下個編號 = 1;
            else
                下個編號 = Map.Max(Value => Value.Key) + 1;
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
