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
using WokyTool.使用者;
using WokyTool.通用;

public delegate void 使用者登入事件(使用者資料 使用者資料_);

namespace WokyTool.使用者
{
    public class 使用者資料管理器 : 資料管理器<使用者資料>
    {
        public override string 檔案路徑 
        {
            get 
            { 
                return "設定/使用者.json"; 
            } 
        }

        public override 使用者資料 空白資料
        {
            get
            {
                return 使用者資料.NULL;
            }
        }

        public override 使用者資料 錯誤資料
        {
            get 
            {
                return 使用者資料.ERROR; 
            } 
        }

        public override 列舉.編號 編號類型
        { 
            get 
            { 
                return 列舉.編號.使用者; 
            } 
        }

        public override bool 資料是否加密
        {
            get
            {
                return true;
            } 
        }

        public override bool 資料是否備份
        {
            get
            {
                return false;
            }
        }

        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.修改基本資料;
            }
        }

        public 使用者資料 使用者 { get; set; }

        protected static 使用者資料 _管理者 = null;
        protected static 使用者資料 管理者 
        {
            get
            {
                if (_管理者 == null)
                {
                    _管理者 = new 使用者資料
                    {
                        編號 = 0,
                        名稱 = "root",
                        密碼 = "Aptx4869",
                        修改基本資料 = true,
                        修改設定資料 = true,
                        匯入進貨 = true,
                        匯入訂單 = true,
                        匯入月結帳 = true,
                    };
                }

                return _管理者;
            }
        }

        public event 使用者登入事件 登入事件管理器;

        // 獨體
        private static readonly 使用者資料管理器 _獨體 = new 使用者資料管理器();
        public static 使用者資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 使用者資料管理器()
        {
            使用者 = 錯誤資料;
        }

        // 取得資料
        public 使用者資料 Get(string Name)
        {
            if (String.IsNullOrEmpty(Name) || 字串.無.Equals(Name))
                return 錯誤資料;

            if (管理者.名稱.Equals(Name))
                return 管理者;

            使用者資料 Item_ = Map.Values
                                   .Where(Value => Name.Equals(Value.名稱) || Name.Equals(Value.帳號))
                                   .FirstOrDefault();

            if (Item_ == null)
                return 錯誤資料;
            else
                return Item_;
        }

        public 使用者資料 登入(String 帳號_, String 密碼_)
        {
            if (使用者 != 錯誤資料)
                throw new Exception("已登入:" + 使用者.名稱);

            if(String.IsNullOrEmpty(帳號_))
                throw new Exception("未輸入帳號");

            if (String.IsNullOrEmpty(密碼_))
                throw new Exception("未輸入密碼_");

            使用者 = Get(帳號_);
            if (使用者 == 錯誤資料)
                throw new Exception("帳號不存在:" + 帳號_);

            if (使用者.密碼.CompareTo(密碼_) != 0)
            {
                使用者 = 錯誤資料;
                throw new Exception("密碼錯誤");
            }

            系統參數.使用者 = 使用者.名稱;
            系統參數.使用者編號 = 使用者.編號;
            系統參數.修改基本資料 = 使用者.修改基本資料;
            系統參數.修改設定資料 = 使用者.修改設定資料;
            系統參數.匯入訂單 = 使用者.匯入訂單;
            系統參數.匯入進貨 = 使用者.匯入進貨;
            系統參數.匯入月結帳 = 使用者.匯入月結帳;

            可編輯BList.AllowEdit = 是否可編輯;
            可編輯BList.AllowNew = 是否可編輯;
            可編輯BList.AllowRemove = 是否可編輯;

            if (登入事件管理器 != null)
            {
                登入事件管理器(使用者);
            }

            訊息管理器.獨體.訊息("使用者登入");

            return 使用者;
        }
    }
}
