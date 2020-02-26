using System;
using System.Collections.Generic;
using System.Linq;
using WokyTool.Common;
using WokyTool.一般訂單;
using WokyTool.平台訂單;
using WokyTool.預留;
using WokyTool.庫存;
using WokyTool.商品;
using WokyTool.寄庫;
using WokyTool.通用;
using WokyTool.進貨;
using WokyTool.盤點;
using System.IO;
using Newtonsoft.Json;

namespace WokyTool.單品
{
    public class 單品資料管理器 : 可編號記錄資料管理器<單品資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.單品; } }

        public override bool 是否可編輯 { get { return 系統參數.修改設定資料; } }

        public override string 檔案路徑 { get { return "設定/單品V3.0.0.json"; } }

        public override 單品資料 不篩選資料 { get { return 單品資料.不篩選; } }
        public override 單品資料 空白資料 { get { return 單品資料.空白; } }
        public override 單品資料 錯誤資料 { get { return 單品資料.錯誤; } }

        protected override 新版可篩選介面<單品資料> 取得篩選器實體()
        {
            return new 單品資料篩選();
        }

        // 獨體
        private static readonly 單品資料管理器 _獨體 = new 單品資料管理器();
        public static 單品資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 單品資料管理器()
        {
        }

        protected override void 初始化資料()
        {
            if (File.Exists("設定/單品V3.0.0.json"))
                base.初始化資料();
            else
            {
                string json = 檔案.讀出("設定/物品.json");
                if (String.IsNullOrEmpty(json))
                    _資料書 = new Dictionary<int, 單品資料>();
                else
                    _資料書 = JsonConvert.DeserializeObject<Dictionary<int, 舊單品資料>>(json).ToDictionary(Pair => Pair.Key, Pair => 舊單品資料.轉換(Pair.Value));

                if (_資料書.Count == 0)
                    _下個編號 = 1;
                else
                    _下個編號 = _資料書.Max(Value => Value.Key) + 1;

                資料版本++;
                儲存();
            }
        }

        // 取得資料
        public 單品資料 取得(string 名稱_)  //@@ check use
        {
            if (String.IsNullOrEmpty(名稱_) || 字串.無.Equals(名稱_))
                return 空白資料;

            return _資料書.Values.Where(Value => 名稱_.Equals(Value.名稱) || 名稱_.Equals(Value.縮寫)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        public 單品資料 取得_名稱(string 名稱_)
        {
            if (String.IsNullOrEmpty(名稱_))
                return 空白資料;

            return _資料書.Values.Where(Value => 名稱_.Equals(Value.名稱)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        public 單品資料 取得_縮寫(string 縮寫_)
        {
            if (String.IsNullOrEmpty(縮寫_))
                return 空白資料;

            return _資料書.Values.Where(Value => 縮寫_.Equals(Value.縮寫)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        public 單品資料 取得_國際條碼(string 國際條碼_)
        {
            if (String.IsNullOrEmpty(國際條碼_))
                return 空白資料;

            return _資料書.Values.Where(Value => 國際條碼_.Equals(Value.國際條碼)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        public 單品資料 取得_類別(string 類別_, string 顏色_)
        {
            return _資料書.Values.Where(Value => 類別_.Equals(Value.類別) && 顏色_.Equals(Value.顏色)).DefaultIfEmpty(錯誤資料).FirstOrDefault();
        }

        public override void 更新資料(object 資料列obj_)
        {
            base.更新資料(資料列obj_);

            商品資料管理器.獨體.更新組成();
        }

        // 測試用
        public void 清除庫存()
        {
            foreach (單品資料 資料_ in 資料列舉2)
            {
                資料_.庫存 = 0;
                資料_.庫存總成本 = 0;
            }

            資料版本++;
        }

        public void 更新庫存(IEnumerable<盤點資料> 資料列_)
        {
            List<單品庫存封存資料> 庫存列_ = new List<單品庫存封存資料>();
            foreach (盤點資料 資料_ in 資料列_)
            {
                int 數量異動_ = 資料_.目前庫存 - 資料_.單品.庫存;
                if (數量異動_ != 0)
                {
                    資料_.單品.取消編輯();

                    資料_.單品.庫存 = 資料_.目前庫存;

                    庫存列_.Add(new 單品庫存封存資料
                    {
                        處理時間 = DateTime.Now,
                        處理者 = 系統參數.使用者名稱,

                        類型 = "盤點",

                        單品編號 = 資料_.單品.編號,
                        名稱 = 資料_.單品.名稱,
                        縮寫 = 資料_.單品.縮寫,

                        異動 = 數量異動_,
                        庫存 = 資料_.單品.庫存,
                        最後進貨成本 = 資料_.單品.最後進貨成本,
                        庫存總成本 = 資料_.單品.庫存總成本,
                    });
                }
            }

            單品庫存封存資料管理器.獨體.新增(庫存列_);

            資料版本++;
        }

        public void 更新庫存(IEnumerable<平台訂單資料> 資料列舉_)
        {
            List<單品庫存封存資料> 庫存列_ = new List<單品庫存封存資料>();
            foreach (平台訂單資料 資料_ in 資料列舉_)
            {
                商品資料 商品_ = 商品資料管理器.獨體.取得(資料_.商品編號);
                if (商品_.編號是否有值() == false)
                {
                    訊息管理器.獨體.警告("平台訂單商品已不存在:" + 資料_.商品名稱);
                    continue;
                }

                if (商品_.組成 == null)
                    continue;

                decimal 消耗成本_ = 0;

                foreach (商品組成資料 組成資料_ in 商品_.組成)
                {
                    單品資料 單品_ = 組成資料_.單品;
                    單品_.取消編輯();

                    int 數量異動_ = 0 - 組成資料_.數量 * 資料_.數量;
                    decimal 目前成本_ = 單品_.成本;

                    if (單品_.庫存 <= 0)
                    {
                        單品_.庫存 += 數量異動_;
                        單品_.庫存總成本 = 0;
                        消耗成本_ -= 數量異動_ * 單品_.最後進貨成本;
                    }
                    else
                    {
                        單品_.庫存 += 數量異動_;
                        if (單品_.庫存 <= 0)
                        {
                            消耗成本_ += 單品_.庫存總成本 - 單品_.庫存 * 單品_.最後進貨成本;
                            單品_.庫存總成本 = 0;
                        }
                        else
                        {
                            消耗成本_ -= 數量異動_ * 目前成本_;
                            單品_.庫存總成本 += 數量異動_ * 目前成本_;
                        }
                    }

                    庫存列_.Add(new 單品庫存封存資料
                        {
                            處理時間 = 資料_.處理時間,
                            處理者 = 資料_.處理者,

                            類型 = "平台訂單",
                            編號 = 資料_.訂單編號,

                            公司 = 資料_.公司名稱,
                            客戶 = 資料_.客戶名稱,

                            單品編號 = 單品_.編號,
                            名稱 = 單品_.名稱,
                            縮寫 = 單品_.縮寫,

                            異動 = 數量異動_,
                            庫存 = 單品_.庫存,
                            最後進貨成本 = 單品_.最後進貨成本,
                            庫存總成本 = 單品_.庫存總成本,

                            備註 = string.Format("{{\"商品\":\"{0}\"}}", 商品_.名稱),
                        });
                }

                資料_.成本 = 消耗成本_ / 資料_.數量;
            }

            單品庫存封存資料管理器.獨體.新增(庫存列_);

            資料版本++;
        }

        public void 更新庫存(IEnumerable<一般訂單資料> 資料列舉_)
        {
            List<單品庫存封存資料> 庫存列_ = new List<單品庫存封存資料>();
            foreach (一般訂單資料 資料_ in 資料列舉_)
            {
                單品資料 單品_ = 單品資料管理器.獨體.取得(資料_.單品編號);
                if (單品_.編號是否有值() == false)
                {
                    訊息管理器.獨體.警告("一般訂單單品已不存在:" + 資料_.單品名稱);
                    continue;
                }

                decimal 消耗成本_ = 0;

                單品_.取消編輯();

                int 數量異動_ = 0 - 資料_.數量;
                decimal 目前成本_ = 單品_.成本;

                if (單品_.庫存 <= 0)
                {
                    單品_.庫存 += 數量異動_;
                    單品_.庫存總成本 = 0;
                    消耗成本_ -= 數量異動_ * 單品_.最後進貨成本;
                }
                else
                {
                    單品_.庫存 += 數量異動_;
                    if (單品_.庫存 <= 0)
                    {
                        消耗成本_ += 單品_.庫存總成本 - 單品_.庫存 * 單品_.最後進貨成本;
                        單品_.庫存總成本 = 0;
                    }
                    else
                    {
                        消耗成本_ -= 數量異動_ * 目前成本_;
                        單品_.庫存總成本 += 數量異動_ * 目前成本_;
                    }
                }

                庫存列_.Add(new 單品庫存封存資料
                {
                    處理時間 = 資料_.處理時間,
                    處理者 = 資料_.處理者,

                    類型 = "一般訂單",
                    //編號 = 資料_.訂單編號,

                    公司 = 資料_.公司名稱,
                    客戶 = 資料_.客戶名稱,

                    單品編號 = 單品_.編號,
                    名稱 = 單品_.名稱,
                    縮寫 = 單品_.縮寫,

                    異動 = 數量異動_,
                    庫存 = 單品_.庫存,
                    最後進貨成本 = 單品_.最後進貨成本,
                    庫存總成本 = 單品_.庫存總成本,

                    備註 = string.Format("{{\"單品\":\"{0}\"}}", 單品_.名稱),
                });

                資料_.成本 = 消耗成本_ / 資料_.數量;
            }

            單品庫存封存資料管理器.獨體.新增(庫存列_);

            資料版本++;
        }

        public void 更新庫存(IEnumerable<寄庫資料> 資料列舉_)
        {
            List<單品庫存封存資料> 庫存列_ = new List<單品庫存封存資料>();
            foreach (寄庫資料 資料_ in 資料列舉_)
            {
                商品資料 商品_ = 商品資料管理器.獨體.取得(資料_.商品編號);
                if (商品_.編號是否有值() == false)
                {
                    訊息管理器.獨體.警告("寄庫商品已不存在:" + 資料_.商品);
                    continue;
                }

                if (商品_.組成 == null)
                    continue;

                decimal 消耗成本_ = 0;

                foreach (商品組成資料 組成資料_ in 商品_.組成)
                {
                    單品資料 單品_ = 組成資料_.單品;
                    單品_.取消編輯();

                    int 數量異動_ = 0 - 組成資料_.數量 * 資料_.數量;
                    decimal 目前成本_ = 單品_.成本;

                    if (單品_.庫存 <= 0)
                    {
                        單品_.庫存 += 數量異動_;
                        單品_.庫存總成本 = 0;
                        消耗成本_ -= 數量異動_ * 單品_.最後進貨成本;
                    }
                    else
                    {
                        單品_.庫存 += 數量異動_;
                        if (單品_.庫存 <= 0)
                        {
                            消耗成本_ += 單品_.庫存總成本 - 單品_.庫存 * 單品_.最後進貨成本;
                            單品_.庫存總成本 = 0;
                        }
                        else
                        {
                            消耗成本_ -= 數量異動_ * 目前成本_;
                            單品_.庫存總成本 += 數量異動_ * 目前成本_;
                        }
                    }

                    庫存列_.Add(new 單品庫存封存資料
                    {
                        處理時間 = 資料_.處理時間,
                        處理者 = 資料_.處理者,

                        類型 = "寄庫",
                        編號 = 資料_.入庫單號,

                        公司 = 商品_.公司名稱,
                        客戶 = 商品_.客戶名稱,

                        單品編號 = 單品_.編號,
                        名稱 = 單品_.名稱,
                        縮寫 = 單品_.縮寫,

                        異動 = 數量異動_,
                        庫存 = 單品_.庫存,
                        最後進貨成本 = 單品_.最後進貨成本,
                        庫存總成本 = 單品_.庫存總成本,

                        備註 = string.Format("{{\"商品\":\"{0}\"}}", 資料_.商品),
                    });
                }

                資料_.成本 = 消耗成本_ / 資料_.數量;
            }

            單品庫存封存資料管理器.獨體.新增(庫存列_);

            資料版本++;
        }

        public void 更新庫存(IEnumerable<進貨資料> 資料列舉_)
        {
            List<單品庫存封存資料> 庫存列_ = new List<單品庫存封存資料>();
            foreach (進貨資料 資料_ in 資料列舉_)
            {
                單品資料 單品_ = 單品資料管理器.獨體.取得(資料_.單品編號);
                if (單品_.編號是否有值() == false)
                {
                    訊息管理器.獨體.警告("進貨單品已不存在:" + 資料_.單品名稱);
                    continue;
                }

                單品_.取消編輯();

                switch (資料_.類型)
                {
                    case 列舉.進貨類型.一般:
                    {
                        單品_.最後進貨成本 = 資料_.單價;

                        if (單品_.庫存 <= 0)
                        {
                            單品_.庫存 += 資料_.數量;

                            if (單品_.庫存 <= 0)
                                單品_.庫存總成本 = 0;
                            else
                                單品_.庫存總成本 = 單品_.庫存 * 資料_.單價;
                        }
                        else
                        {
                            單品_.庫存 += 資料_.數量;
                            單品_.庫存總成本 += 資料_.數量 * 資料_.單價;
                        }

                        break;
                    }
                    case 列舉.進貨類型.退貨重進:
                    {
                        if (單品_.庫存 <= 0)
                        {
                            單品_.庫存 += 資料_.數量;

                            if (單品_.庫存 <= 0)
                                單品_.庫存總成本 = 0;
                            else
                                單品_.庫存總成本 = 單品_.庫存 * 資料_.單價;
                        }
                        else
                        {
                            單品_.庫存 += 資料_.數量;
                            單品_.庫存總成本 += 資料_.數量 * 資料_.單價;
                        }

                        break;
                    }
                    case 列舉.進貨類型.未開發平台:
                    {
                        decimal 目前成本_ = 單品_.成本;

                        單品_.庫存 -= 資料_.數量;
                        if (單品_.庫存 <= 0)
                            單品_.庫存總成本 = 0;
                        else
                            單品_.庫存總成本 -= 資料_.數量 * 目前成本_;

                        break;
                    }
                    default:
                        訊息管理器.獨體.錯誤("不支援的進貨類型 " + 資料_.類型);
                        break;
                }

                庫存列_.Add(new 單品庫存封存資料
                {
                    處理時間 = 資料_.處理時間,
                    處理者 = 資料_.處理者,

                    類型 = "進貨",
                    編號 = 字串.空,

                    公司 = 字串.空,
                    客戶 = 資料_.供應商名稱,

                    單品編號 = 單品_.編號,
                    名稱 = 單品_.名稱,
                    縮寫 = 單品_.縮寫,

                    異動 = 資料_.數量,
                    庫存 = 單品_.庫存,
                    最後進貨成本 = 單品_.最後進貨成本,
                    庫存總成本 = 單品_.庫存總成本,

                    備註 = string.Format("{{\"類型\":\"{0}\", \"備註\":\"{1}\"}}", 資料_.類型, 資料_.備註),
                });
            }

            單品庫存封存資料管理器.獨體.新增(庫存列_);

            資料版本++;
        }

        public void 更新保留()
        {
            Dictionary<單品資料, int> 更新書_ = 預留資料管理器.獨體.資料列舉2
                                    .Where(Value => Value.是否保留中)
                                    .GroupBy(Value => Value.單品)
                                    .ToDictionary(Value => Value.Key, Value => Value.Sum(Value2 => Value2.數量));

            bool 是否有更新_ = false;
            foreach (單品資料 資料_ in this.資料列舉2)
            {
                資料_.取消編輯();

                int 更新保留_ = 0;
                更新書_.TryGetValue(資料_, out 更新保留_);

                if (資料_.保留 != 更新保留_)
                    是否有更新_ = true;

                資料_.保留 = 更新保留_;
            }

            if (是否有更新_)
                資料版本++;
        }
    }
}