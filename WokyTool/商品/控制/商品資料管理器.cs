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
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.商品
{
    public class 商品資料管理器 : 可儲存資料管理器<商品資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.商品; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "設定/商品V2.1.1.json"; } }

        public override 商品資料 不篩選資料 { get { return 商品資料.不篩選; } }
        public override 商品資料 空白資料 { get { return 商品資料.空白; } }
        public override 商品資料 錯誤資料 { get { return 商品資料.錯誤; } }
        public 商品資料 折扣資料 { get { return 商品資料.折扣; } }

        protected override 新版可篩選介面<商品資料> 取得篩選器實體()
        {
            return new 商品資料篩選();
        }

        // 獨體
        private static readonly 商品資料管理器 _獨體 = new 商品資料管理器();
        public static 商品資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 商品資料管理器()
        {
            foreach (商品資料 資料_ in _資料書.Values)
                資料_.更新組成();
        }

        public override 商品資料 取得(int ID_)
        {
            if (ID_ == 常數.空白資料編碼)
                return 空白資料;

            if (ID_ == 常數.錯誤資料編碼)
                return 錯誤資料;

            if (ID_ == 常數.商品折扣資料編碼)
                return 折扣資料;

            商品資料 Item_;
            if (_資料書.TryGetValue(ID_, out Item_))
            {
                return Item_;
            }

            return 錯誤資料;
        }

        public 商品資料 取得(int 公司編號_, int 客戶編號_, string 品號_)
        {
            if (String.IsNullOrEmpty(品號_))
                return 空白資料;

            return _資料書.Values.Where(Value => Value.客戶編號 == 客戶編號_ && Value.公司編號 == 公司編號_ && 品號_.Equals(Value.品號)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        public 商品資料 取得(int 客戶編號_, string 品號_)
        {
            if (String.IsNullOrEmpty(品號_))
                return 空白資料;

            return _資料書.Values.Where(Value => Value.客戶編號 == 客戶編號_ && 品號_.Equals(Value.品號)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        public 商品資料 取得_名稱(int 公司編號_, int 客戶編號_, string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_))
                return 空白資料;

            return _資料書.Values.Where(Value => Value.客戶編號 == 客戶編號_ && Value.公司編號 == 公司編號_ && 名稱_.Equals(Value.名稱)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        public 商品資料 取得_名稱(int 客戶編號_, string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_))
                return 空白資料;

            return _資料書.Values.Where(Value => Value.客戶編號 == 客戶編號_ && 名稱_.Equals(Value.名稱)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        public void 舊資料轉換()
        {
            _資料書.Clear();

            // V2.0.X -> V2.1.X
            string json = 檔案.讀出("設定/商品.json");
            Dictionary<int, 舊商品資料> 舊資料書_ = JsonConvert.DeserializeObject<Dictionary<int, 舊商品資料>>(json);
            foreach (var Item_ in 舊資料書_.Values)
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
                if (Item_.需求1.編號是否有值())
                {
                    商品組成資料 組成_ = new 商品組成資料
                    {
                        物品 = Item_.需求1,
                        數量 = Item_.數量1,
                    };

                    New_.組成.Add(組成_);
                }
                if (Item_.需求2.編號是否有值())
                {
                    商品組成資料 組成_ = new 商品組成資料
                    {
                        物品 = Item_.需求2,
                        數量 = Item_.數量2,
                    };

                    New_.組成.Add(組成_);
                }
                if (Item_.需求3.編號是否有值())
                {
                    商品組成資料 組成_ = new 商品組成資料
                    {
                        物品 = Item_.需求3,
                        數量 = Item_.數量3,
                    };

                    New_.組成.Add(組成_);
                }
                if (Item_.需求4.編號是否有值())
                {
                    商品組成資料 組成_ = new 商品組成資料
                    {
                        物品 = Item_.需求4,
                        數量 = Item_.數量4,
                    };

                    New_.組成.Add(組成_);
                }
                if (Item_.需求5.編號是否有值())
                {
                    商品組成資料 組成_ = new 商品組成資料
                    {
                        物品 = Item_.需求5,
                        數量 = Item_.數量5,
                    };

                    New_.組成.Add(組成_);
                }

                New_.更新組成();

                _資料書.Add(New_.編號, New_);
            }

            if (_資料書.Count == 0)
                _下個編號 = 1;
            else
                _下個編號 = _資料書.Max(Value => Value.Key) + 1;

            資料版本++;
            儲存();

            訊息管理器.獨體.通知("商品轉換完成");
        }
    }
}

