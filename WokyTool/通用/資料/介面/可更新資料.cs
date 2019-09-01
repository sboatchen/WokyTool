using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.通用
{
    public enum 更新處理方式
    {
        更新 = 0,
        新增,
        刪除,
    };

    [JsonObject(MemberSerialization.OptIn)]
    public abstract class 可更新資料<T> : 可編輯資料, 可初始化介面, 可記錄錯誤介面 where T : 新版可記錄資料<T>
    {
        [可匯出]
        [JsonProperty]
        public string 錯誤訊息 { get; set; }

        [可匯入(名稱 = "處理方式", 說明 = "更新/新增/刪除")]
        public string 處理方式識別
        {
            get
            {
                return 處理方式.ToString();
            }
            set
            {
                處理方式 = (更新處理方式)Enum.Parse(typeof(更新處理方式), value);
            }
        }

        /********************************/

        [JsonProperty]
        public 更新處理方式 處理方式 { get; protected set; }

        [JsonProperty]
        public 列舉.更新狀態 更新狀態 { get; protected set; }

        public T 參考 { get; protected set; }
        public T 修改 { get; protected set; }

        protected string _參考Hash;

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
                    錯誤訊息 = "找不到指定的物件";
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
                    錯誤訊息 = "找不到指定的物件";
                    更新狀態 = 列舉.更新狀態.錯誤;
                    是否編輯中 = false;
                }
                else
                {
                    _參考Hash = 參考.ToString(false);
                    更新編輯狀態();
                }
            }
        }

        public override void BeginEdit()
        {
        }

        public override void CancelEdit()
        {
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
            //Console.WriteLine("合法檢查:" + this.ToString(false));
            switch (更新狀態)
            {
                case 列舉.更新狀態.相同:
                    錯誤訊息 = null;
                    break;
                case 列舉.更新狀態.錯誤:
                    break;
                case 列舉.更新狀態.刪除:
                    錯誤訊息 = null;
                    參考.刪除檢查(檢查器_);
                    break;
                case 列舉.更新狀態.新增:
                    錯誤訊息 = null;
                    修改.合法檢查(檢查器_, this);
                    break;
                case 列舉.更新狀態.更新:
                    錯誤訊息 = null;
                    修改.合法檢查(檢查器_, this, 參考);
                    break;
                default:
                    訊息管理器.獨體.錯誤("未處理類型:" + 更新狀態);
                    break;
            }
        }
    }
}
