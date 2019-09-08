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
using WokyTool.客戶;
using WokyTool.捨棄;
using WokyTool.通用;
using WokyTool.廢棄;

namespace WokyTool.聯絡人
{
    public class 聯絡人資料管理器 : 可編號記錄資料管理器<聯絡人資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.聯絡人; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "設定/聯絡人V2_1_7.json"; } }

        public override 聯絡人資料 不篩選資料 { get { return 聯絡人資料.不篩選; } }
        public override 聯絡人資料 空白資料 { get { return 聯絡人資料.空白; } }
        public override 聯絡人資料 錯誤資料 { get { return 聯絡人資料.錯誤; } }

        protected override 新版可篩選介面<聯絡人資料> 取得篩選器實體()
        {
            return new 聯絡人資料篩選();
        }

        // 獨體
        private static readonly 聯絡人資料管理器 _獨體 = new 聯絡人資料管理器();
        public static 聯絡人資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 聯絡人資料管理器()
        {
        }

        // 取得資料
        public 聯絡人資料 取得(string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_) || 字串.無.Equals(名稱_))
                return 空白資料;

            return _資料書.Values.Where(Value => 名稱_.Equals(Value.姓名)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        public void 舊資料轉換()
        {
            if (File.Exists("設定/聯絡人.json") == false)
                return;
            if (File.Exists("設定/子客戶.json") == false)
                return;
            if (File.Exists("設定/客戶.json") == false)
                return;

            Dictionary<int, 舊聯絡人資料> 舊聯絡人資料書_;
            string json = 檔案.讀出("設定/聯絡人.json");
            if (String.IsNullOrEmpty(json))
                舊聯絡人資料書_ = new Dictionary<int, 舊聯絡人資料>();
            else
                舊聯絡人資料書_ = JsonConvert.DeserializeObject<Dictionary<int, 舊聯絡人資料>>(json);

            Dictionary<int, 舊子客戶資料> 舊子客戶資料書_;
            json = 檔案.讀出("設定/子客戶.json");
            if (String.IsNullOrEmpty(json))
                舊子客戶資料書_ = new Dictionary<int, 舊子客戶資料>();
            else
                舊子客戶資料書_ = JsonConvert.DeserializeObject<Dictionary<int, 舊子客戶資料>>(json);

            Dictionary<int, 舊客戶資料> 舊客戶資料書_;
            json = 檔案.讀出("設定/客戶.json");
            if (String.IsNullOrEmpty(json))
                舊客戶資料書_ = new Dictionary<int, 舊客戶資料>();
            else
                舊客戶資料書_ = JsonConvert.DeserializeObject<Dictionary<int, 舊客戶資料>>(json);


            Dictionary<int, 客戶資料> 客戶資料書_ = 舊客戶資料書_.Values.Select(Value => Value.轉換()).ToDictionary(Value => Value.編號);
            Dictionary<int, 子客戶資料> 子客戶資料書_ = 舊子客戶資料書_.Values.Select(Value => Value.轉換()).ToDictionary(Value => Value.編號);
            Dictionary<int, 聯絡人資料> 聯絡人資料書_ = 舊聯絡人資料書_.Values.Select(Value => Value.轉換()).ToDictionary(Value => Value.編號);


            foreach (舊客戶資料 舊客戶資料_ in 舊客戶資料書_.Values)
            {
                if (舊客戶資料_.子客戶編號列 != null)
                {
                    foreach (int 編號_ in 舊客戶資料_.子客戶編號列)
                    {
                        子客戶資料 子客戶資料_;
                        子客戶資料書_.TryGetValue(編號_, out 子客戶資料_);
                        if (子客戶資料_ == null)
                        {
                            訊息管理器.獨體.通知("客戶綁定子客戶失敗:" + 舊客戶資料_.名稱);
                            return;
                        }

                        子客戶資料_.客戶 = 舊客戶資料_.新資料;
                    }
                }

                if (舊客戶資料_.聯絡人編號列 != null)
                {
                    foreach (int 編號_ in 舊客戶資料_.聯絡人編號列)
                    {
                        聯絡人資料 聯絡人資料_;
                        聯絡人資料書_.TryGetValue(編號_, out 聯絡人資料_);
                        if (聯絡人資料_ == null)
                        {
                            訊息管理器.獨體.通知("客戶綁定聯絡人失敗:" + 舊客戶資料_.名稱);
                            return;
                        }

                        聯絡人資料_.客戶 = 舊客戶資料_.新資料;
                    }
                }
            }

            foreach (舊子客戶資料 舊子客戶資料_ in 舊子客戶資料書_.Values)
            {
                if (舊子客戶資料_.聯絡人編號列 != null)
                {
                    foreach (int 編號_ in 舊子客戶資料_.聯絡人編號列)
                    {
                        聯絡人資料 聯絡人資料_;
                        聯絡人資料書_.TryGetValue(編號_, out 聯絡人資料_);
                        if (聯絡人資料_ == null)
                        {
                            訊息管理器.獨體.通知("子客戶綁定聯絡人失敗:" + 舊子客戶資料_.名稱);
                            return;
                        }

                        聯絡人資料_.子客戶 = 舊子客戶資料_.新資料;
                        聯絡人資料_.客戶 = 舊子客戶資料_.新資料.客戶;
                    }
                }
            }

            檔案.備份("設定/聯絡人V2_1_7.json", true);
            檔案.寫入("設定/聯絡人V2_1_7.json", JsonConvert.SerializeObject(聯絡人資料書_, Formatting.Indented));

            檔案.備份("設定/子客戶V2_1_7.json", true);
            檔案.寫入("設定/子客戶V2_1_7.json", JsonConvert.SerializeObject(子客戶資料書_, Formatting.Indented));

            檔案.備份("設定/客戶V2_1_7.json", true);
            檔案.寫入("設定/客戶V2_1_7.json", JsonConvert.SerializeObject(客戶資料書_, Formatting.Indented));


            訊息管理器.獨體.訊息("聯絡資料轉換完成");
        }
    }
}