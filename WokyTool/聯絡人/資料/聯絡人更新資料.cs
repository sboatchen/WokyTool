using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.聯絡人
{
    public enum 更新處理方式
    {
        更新 = 0,
        刪除,
    };

    [JsonObject(MemberSerialization.OptIn)]
    public class 聯絡人更新資料 : 新版可匯入資料<聯絡人更新資料>
    {
        [可匯入(名稱 = "處理方式")]
        public string 處理方式識別
        {
            set
            {
                處理方式 = (更新處理方式)Enum.Parse(typeof(更新處理方式), value);
                if (處理方式 == 更新處理方式.刪除)
                    更新狀態 = 列舉.更新狀態.刪除;
            } 
        }

        [可匯入(名稱 = "編號", 優先級 = Int32.MaxValue)]
        [JsonProperty]
        public string 編號識別 
        {
            get
            {
                return _編號識別;
            }
            set
            {
                _編號識別 = value;
                if (參考 == null)
                {
                    int 編號_ = Int32.Parse(value);
                    參考 = 聯絡人資料管理器.獨體.取得(編號_);
                    修改 = 參考.深複製();
                }
            }
        }

        [可匯入(優先級 = 1)]
        [JsonProperty]
        public string 姓名
        {
            get
            {
                return 修改.姓名;
            }
            set
            {
                if (參考 == null)
                {
                    參考 = 聯絡人資料管理器.獨體.取得(value);
                    修改 = 參考.深複製();
                }
                else
                    修改.姓名 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public string 電話
        {
            get
            {
                return 修改.電話;
            }
            set
            {
                修改.電話 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public string 手機
        {
            get
            {
                return 修改.手機;
            }
            set
            {
                修改.手機 = value;
            }
        }

        [可匯入]
        [JsonProperty]
        public string 地址
        {
            get
            {
                return 修改.地址;
            }
            set
            {
                修改.地址 = value;
            }
        }

        [可匯入(名稱 = "客戶")]
        [JsonProperty]
        public string 客戶識別
        {
            get
            {
                return _客戶識別;
            }
            set
            {
                _客戶識別 = value;
                修改.客戶 = 客戶資料管理器.獨體.取得(value);
            }
        }

        [可匯入(名稱 = "子客戶")]
        [JsonProperty]
        public string 子客戶識別
        {
            get
            {
                return _子客戶識別;
            }
            set
            {
                _子客戶識別 = value;
                修改.子客戶 = 子客戶資料管理器.獨體.取得(value);
            }
        }

        /********************************/

        private string _編號識別;
        private string _客戶識別;
        private string _子客戶識別;

        [JsonProperty]
        public 更新處理方式 處理方式 { get; protected set; }

        [JsonProperty]
        public 列舉.更新狀態 更新狀態 { get; protected set; }

        public 聯絡人資料 參考 { get; protected set; }
        public 聯絡人資料 修改 { get; protected set; }

        /********************************/

        public 聯絡人更新資料()
        {
            處理方式 = 更新處理方式.更新;
            更新狀態 = 列舉.更新狀態.更新;
        }

        public override void 初始化()
        {
            是否編輯中 = true;

            /*if (false == string.IsNullOrEmpty(編號))
            {
                參考 = 聯絡人資料管理器.獨體.取得(Int32.Parse(編號));
                if (參考 == 聯絡人資料.錯誤)
                {
                    更新狀態 = 列舉.更新狀態.錯誤;
                    錯誤訊息 = "找不到指定編號";
                    return;
                }
            }
            else if (false == string.IsNullOrEmpty(姓名))
            {
                參考 = 聯絡人資料管理器.獨體.取得(姓名);
                if (參考 == 聯絡人資料.錯誤)
                {
                    更新狀態 = 列舉.更新狀態.錯誤;
                    錯誤訊息 = "找不到指定姓名";
                    return;
                }
            }
            else
            {
                更新狀態 = 列舉.更新狀態.錯誤;
                錯誤訊息 = "未設定編號或姓名";
                return;
            }

            修改 = 參考.深複製();

            if (null != 姓名)
                修改.姓名 = 姓名;

            if (null != 電話)
                修改.電話 = 電話;

            if (null != 手機)
                修改.手機 = 手機;

            if (null != 地址)
                修改.地址 = 地址;

            if (null != 客戶)
                修改.客戶 = 客戶資料管理器.獨體.取得(客戶);

            if (null != 子客戶)
                修改.子客戶 = 子客戶資料管理器.獨體.取得(子客戶);

            訊息管理器.獨體.訊息(參考.ToString(false));
            訊息管理器.獨體.訊息(修改.ToString(false));
            訊息管理器.獨體.訊息("-----------------------");*/
        }

        public override void 合法檢查(可處理檢查介面 介面_, object 資料列舉_)
        {
            /*IEnumerable<聯絡人匯入資料> 聯絡人匯入資料列舉_ = (IEnumerable<聯絡人匯入資料>)資料列舉_;

            if (String.IsNullOrEmpty(姓名))
                介面_.錯誤(this, "姓名不合法");
            else if (聯絡人匯入資料列舉_.Where(Value => 姓名.Equals(Value.姓名)).Count() > 1)
                介面_.錯誤(this, "姓名重複");

            if (String.IsNullOrEmpty(電話) && String.IsNullOrEmpty(手機))
                介面_.錯誤(this, "電話/手機不合法");

            if (String.IsNullOrEmpty(地址))
                介面_.錯誤(this, "地址不合法");

            if (false == 客戶.編號是否有值())
                介面_.錯誤(this, "客戶不合法");

            // 可以不設定子客戶, 但若設定了 必須屬於上層客戶
            if (子客戶.編號是否有值() && 子客戶.客戶 != 客戶)
                介面_.錯誤(this, "子客戶不屬於客戶");*/
        }
    }
}