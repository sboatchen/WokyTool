using System;
using System.Linq;
using System.Collections.Generic;
using WokyTool.通用;
using Newtonsoft.Json;

namespace WokyTool.平台訂單
{
    public class 平台訂單新增資料管理器 : 可記錄資料管理器<平台訂單新增資料>
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.平台訂單新增; } }

        public override bool 是否可編輯 { get { return 系統參數.匯入訂單; } }

        public override string 檔案路徑 { get { return String.Format("進度/平台訂單新增/{0}.json", 系統參數.使用者名稱); } }

        public override 平台訂單新增資料 不篩選資料 { get { return null; } }
        public override 平台訂單新增資料 空白資料 { get { return 平台訂單新增資料.空白; } }
        public override 平台訂單新增資料 錯誤資料 { get { return 平台訂單新增資料.錯誤; } }

        protected override 新版可篩選介面<平台訂單新增資料> 取得篩選器實體()
        {
            return new 平台訂單新增資料篩選();
        }

        // 獨體
        private static readonly 平台訂單新增資料管理器 _獨體 = new 平台訂單新增資料管理器();
        public static 平台訂單新增資料管理器 獨體 { get { return _獨體; } }

        // 建構子
        private 平台訂單新增資料管理器()
        {
        }

        public void 完成()
        {
            List<平台訂單資料> 完成資料列_ = _資料列.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.配送).Select(Value => 平台訂單資料.建立(Value)).ToList();
            平台訂單資料管理器.獨體.待整理(完成資料列_);

            _資料列.RemoveAll(Value => Value.處理狀態 == 列舉.訂單處理狀態.配送 || Value.處理狀態 == 列舉.訂單處理狀態.忽略);
            資料版本++;
        }

        private Dictionary<int, 平台訂單匯入處理介面> _處理器資料書 = new Dictionary<int, 平台訂單匯入處理介面>();
        public 平台訂單匯入處理介面 取得處理器(平台訂單新增資料 資料_)
        {
            int Hash_ = 資料_.處理器Hash;

            平台訂單匯入處理介面 處理器_ = null;
            if (_處理器資料書.TryGetValue(Hash_, out 處理器_))
                return 處理器_;

            String 名稱_ = 資料_.客戶.名稱.ToLower().Replace(" ", "");

            switch (名稱_)
            {
                case "momo":
                    switch (資料_.配送公司)
                    {
                        case 列舉.配送公司.三方:
                            處理器_ = new 平台訂單匯入處理_Momo第三方();
                            break;
                        default:
                            訊息管理器.獨體.錯誤("尚未實作");
                            break;
                    }
                    break;
                case "中華電信":
                    處理器_ = new 平台訂單匯入處理_中華電信();
                    break;
                case "東森":
                    處理器_ = new 平台訂單匯入處理_東森();
                    break;
                case "friday":
                    處理器_ = new 平台訂單匯入處理_Friday();
                    break;
                case "udn":
                    處理器_ = new 平台訂單匯入處理_UDN();
                    break;
                case "udesign":
                    處理器_ = new 平台訂單匯入處理_uDesign();
                    break;
                case "ibonmart":
                    處理器_ = new 平台訂單匯入處理_ibonMart();
                    break;
                case "金石堂":
                    處理器_ = new 平台訂單匯入處理_金石堂();
                    break;
                case "百利市":
                    處理器_ = new 平台訂單匯入處理_百利市();
                    break;
                case "viva":
                    處理器_ = new 平台訂單匯入處理_viva();
                    break;
                case "特力屋":
                    處理器_ = new 平台訂單匯入處理_特力屋();
                    break;
                case "博客來":
                    處理器_ = new 平台訂單匯入處理_博客來();
                    break;
                case "松果":
                    switch (資料_.配送公司)
                    {
                        case 列舉.配送公司.全家:
                        case 列舉.配送公司.SEVEN:
                            處理器_ = new 平台訂單匯入處理_松果_超商();
                            break;
                        default:
                            處理器_ = new 平台訂單匯入處理_松果();
                            break;
                    }
                    break;
                case "生活市集":
                    switch (資料_.配送公司)
                    {
                        case 列舉.配送公司.全家:
                        case 列舉.配送公司.SEVEN:
                            處理器_ = new 平台訂單匯入處理_生活市集_超商();
                            break;
                        default:
                            處理器_ = new 平台訂單匯入處理_生活市集();
                            break;
                    }
                    break;
                case "神坊":
                    處理器_ = new 平台訂單匯入處理_神坊();
                    break;
                case "payeasy":
                    處理器_ = new 平台訂單匯入處理_PayEasy();
                    break;
                case "citiesocial":
                    處理器_ = new 平台訂單匯入處理_citiesocial();
                    break;
                case "WACA":
                    處理器_ = new 平台訂單匯入處理_WACA();
                    break;
                default:
                    訊息管理器.獨體.錯誤("平台訂單自定義工廠::不支援 " + 名稱_);
                    return null;
            }

            處理器_.公司 = 資料_.公司;

            _處理器資料書.Add(Hash_, 處理器_);

            return 處理器_;
        }
    }
}

