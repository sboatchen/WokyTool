﻿using Newtonsoft.Json;
using System;
using System.Linq;

namespace WokyTool.通用
{
    public enum 更新處理方式
    {
        更新 = 0,
        新增,
        刪除,
    };

    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 可更新資料<TCovert, TValue> : 可編輯資料, 可初始化介面, 可記錄錯誤介面  where TCovert:可更新資料<TCovert, TValue> where TValue : 可編號記錄資料
    {
        [可匯出]
        [JsonProperty]
        public string 錯誤訊息 { get; set; }

        [可匯入(優先級 = 0, 名稱 = "處理方式", 說明 = "更新/新增/刪除")]
        public string 處理方式識別
        {
            get
            {
                return 處理方式.ToString();
            }
            set
            {
                try
                {
                    處理方式 = (更新處理方式)Enum.Parse(typeof(更新處理方式), value);
                }
                catch
                {
                    訊息管理器.獨體.警告("不支援的處理方式:" + value + ", 調整為更新");
                    處理方式 = 更新處理方式.更新;
                }

                if (處理方式 == 更新處理方式.新增)
                {
                    參考 = (TValue)Activator.CreateInstance(typeof(TValue));
                    修改 = (TValue)Activator.CreateInstance(typeof(TValue));

                    修改.編號 = 常數.新建資料編碼;
                }
            }
        }

        /********************************/

        [JsonProperty]
        public 更新處理方式 處理方式 { get; protected set; }

        [JsonProperty]
        public 列舉.更新狀態 更新狀態 { get; protected set; }

        public TValue 參考 { get; protected set; }
        public TValue 修改 { get; protected set; }

        protected string _參考Hash;

        public 可更新資料管理器<TCovert, TValue> 管理器 { get; set; }

        /********************************/

        public 可更新資料()
        {
            處理方式 = 更新處理方式.更新;
            更新狀態 = 列舉.更新狀態.無;
        }

        public virtual void 初始化()
        {
            if (更新處理方式.刪除 == 處理方式)
            {
                if (參考.編號是否有值() == false)
                {
                    更新狀態 = 列舉.更新狀態.錯誤;
                    是否編輯中 = false;
                }
                else
                {
                    更新狀態 = 列舉.更新狀態.刪除;
                    是否編輯中 = true;
                }
            }
            else if (更新處理方式.新增 == 處理方式)
            {
                更新狀態 = 列舉.更新狀態.新增;
                是否編輯中 = true;
            }
            else    // 更新處理方式.更新 == 處理方式
            {
                if (參考.編號是否有值() == false)
                {
                    更新狀態 = 列舉.更新狀態.錯誤;
                    是否編輯中 = false;
                }
                else
                {
                    _參考Hash = 參考.ToString(false);
                    修改.BeginEdit(_參考Hash);
                    更新編輯狀態();
                }
            }
        }

        public override void EndEdit()
        {
            //Console.WriteLine("完成編輯:" + this.ToString(false));
            更新編輯狀態();
        }

        private static 可檢查介面 更新檢查器 = new 錯誤訊息檢查器();
        public override bool 更新編輯狀態()
        {
            if (_參考Hash != null)
            {
                string 資料_ = 修改.ToString(false);
                是否編輯中 = _參考Hash.Equals(資料_) == false;
                更新狀態 = 是否編輯中 ? 列舉.更新狀態.更新 : 列舉.更新狀態.相同;
            }

            合法檢查(更新檢查器);

            return 是否編輯中;
        }

        public override void 取消編輯()
        { 
        }

        public override void 紀錄編輯(bool 是否列印_ = false)
        {
            if (是否列印_)
            {
                switch (更新狀態)
                {
                    case 列舉.更新狀態.相同:
                        break;
                    case 列舉.更新狀態.刪除:
                        訊息管理器.獨體.訊息("資料刪除");
                        訊息管理器.獨體.訊息(_參考Hash);
                        訊息管理器.獨體.訊息("---------");
                        break;
                    case 列舉.更新狀態.更新:
                        訊息管理器.獨體.訊息("資料更新");
                        訊息管理器.獨體.訊息(_參考Hash);
                        訊息管理器.獨體.訊息(修改.ToString(false));
                        訊息管理器.獨體.訊息("---------");
                        break;
                    case 列舉.更新狀態.新增:
                        訊息管理器.獨體.訊息("資料新增");
                        訊息管理器.獨體.訊息(修改.ToString(false));
                        訊息管理器.獨體.訊息("---------");
                        break;
                    default:
                        訊息管理器.獨體.錯誤("不支援更新狀態:" + 更新狀態);
                        break;
                }
            }
        }

        public override void 合法檢查(可檢查介面 檢查器_, 基本資料 資料上層_ = null, 基本資料 資料參考_ = null)
        {
            基本資料 資料_ = (資料上層_ == null) ? this : 資料上層_;
            基本資料 參考_ = (資料參考_ == null) ? 參考 : 資料參考_;

            if (檢查器_ is 錯誤訊息檢查器)
                錯誤訊息 = null;

            //Console.WriteLine("合法檢查:" + this.ToString(false));
            switch (更新狀態)
            {
                case 列舉.更新狀態.相同:
                    return;
                case 列舉.更新狀態.錯誤:
                    檢查器_.錯誤(資料_, "找不到指定的物件");
                    return;
                case 列舉.更新狀態.刪除:
                    修改.刪除檢查(檢查器_, 資料_);
                    break;
                case 列舉.更新狀態.新增:
                    修改.合法檢查(檢查器_, 資料_);
                    break;
                case 列舉.更新狀態.更新:
                    修改.合法檢查(檢查器_, 資料_, 參考);
                    break;
                default:
                    訊息管理器.獨體.錯誤("未處理類型:" + 更新狀態);
                    break;
            }

            if (管理器.資料列.Where(Value => Value != this && Value.參考 == 參考_).Any())
            {
                檢查器_.錯誤(資料_, "重複更新");
            }
        }
    }
}
