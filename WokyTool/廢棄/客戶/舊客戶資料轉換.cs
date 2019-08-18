using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.客戶;
using WokyTool.捨棄;
using WokyTool.通用;
using WokyTool.聯絡人;

namespace WokyTool.廢棄
{
    public class 舊客戶資料轉換
    {
        public void 轉換()
        {
            if (轉換V2())
                return;

        }

        private bool 轉換V2()
        {
            if (File.Exists("設定/聯絡人.json") == false)
                return false;
            if (File.Exists("設定/子客戶.json") == false)
                return false;
            if (File.Exists("設定/客戶.json") == false)
                return false;

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
                            return false;
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
                            return false;
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
                            return false;
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


            訊息管理器.獨體.訊息("舊客戶資料轉換:轉換V2");
            訊息管理器.獨體.通知("舊客戶資料轉換:轉換V2");
            return true;
        }
    }
}
