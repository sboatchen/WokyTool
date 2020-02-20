using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WokyTool.庫存;
using WokyTool.寄庫;
using WokyTool.通用;

namespace WokyTool.商品
{
    public class 商品資料管理器 : 可編號記錄資料管理器<商品資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.商品; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "設定/商品V3.0.0.json"; } }

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
        }

        protected override void 初始化資料()
        {
            if (File.Exists("設定/商品V3.0.0.json"))
                base.初始化資料();
            else {
                string json = 檔案.讀出("設定/商品V2.1.1.json");
                Dictionary<int, 舊商品資料> 舊資料書_ = JsonConvert.DeserializeObject<Dictionary<int, 舊商品資料>>(json);
                _資料書 = 舊資料書_.ToDictionary(Pair => Pair.Key, Pair => 舊商品資料.轉換(Pair.Value));
                
                if (_資料書.Count == 0)
                    _下個編號 = 1;
                else
                    _下個編號 = _資料書.Max(Value => Value.Key) + 1;

                資料版本++;
                儲存();
            }

            foreach (var 商品_ in _資料書.Values)
                商品_.更新組成();
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

        // 測試用
        public void 清除庫存()
        {
            foreach (商品資料 資料_ in 資料列舉2)
            {
                資料_.寄庫數量 = 0;
            }

            資料版本++;
        }

        public void 更新組成()
        {
            foreach (var Item_ in 商品資料管理器.獨體.資料列舉2)
            {
                Item_.更新組成();
            }

            資料版本++;
            儲存();
        }

        public void 更新庫存(IEnumerable<寄庫資料> 資料列_)
        {
            List<商品庫存封存資料> 庫存列_ = new List<商品庫存封存資料>();
            foreach (寄庫資料 資料_ in 資料列_)
            {
                商品資料 商品_ = 取得(資料_.商品編號);
                if (商品_.編號是否有值() == false)
                {
                    訊息管理器.獨體.警告("寄庫商品已不存在:" + 資料_.商品);
                    continue;
                }

                商品_.寄庫數量 += 資料_.數量;
                商品_.更新組成();  // 請注意成本可能異動

                庫存列_.Add(new 商品庫存封存資料
                {
                    處理時間 = 資料_.處理時間,
                    處理者 = 資料_.處理者,

                    類型 = "寄庫",
                    編號 = 資料_.入庫單號,

                    公司 = 資料_.公司,
                    客戶 = 資料_.客戶,

                    商品編號 = 資料_.商品編號,
                    名稱 = 資料_.商品,

                    異動 = 資料_.數量,
                    庫存 = 商品_.寄庫數量,
                    成本 = 資料_.成本,    // 最新商品成本 不一定 等於 寄庫時 計算出來的成本
                    利潤 = 商品_.進價 - 資料_.成本,
                    進價 = 商品_.進價,
                    售價 = 商品_.售價,
                });
            }


            商品庫存封存資料管理器.獨體.新增(庫存列_);

            資料版本++;
        }
    }
}

