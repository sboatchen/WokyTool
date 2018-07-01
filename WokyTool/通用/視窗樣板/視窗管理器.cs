using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.客戶;

namespace WokyTool.通用
{
    public class 視窗管理器
    {

        private Dictionary<列舉.編碼類型, Type> 詳細視窗設定Map { get; set; }
        private Dictionary<列舉.編碼類型, 通用視窗介面> 詳細視窗Map { get; set; }

        // 獨體
        private static readonly 視窗管理器 _獨體 = new 視窗管理器();
        public static 視窗管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        private 視窗管理器()
        {
            詳細視窗設定Map = new Dictionary<列舉.編碼類型, Type>();
            詳細視窗Map = new Dictionary<列舉.編碼類型, 通用視窗介面>();

            詳細視窗設定Map.Add(列舉.編碼類型.客戶, typeof(客戶詳細視窗));
            詳細視窗設定Map.Add(列舉.編碼類型.子客戶, typeof(子客戶詳細視窗));
            詳細視窗設定Map.Add(列舉.編碼類型.物品, typeof(物品詳細視窗));
        }

        private 通用視窗介面 取得詳細視窗(列舉.編碼類型 類型_)
        {
            通用視窗介面 視窗_ = null;
            if ( 詳細視窗Map.TryGetValue(類型_, out 視窗_) == false)
            {
                Type Type_ = null;
                if ( 詳細視窗設定Map.TryGetValue(類型_, out Type_) == false)
                    throw new Exception("視窗管理器:取得 詳細視窗實體 失敗, " + 類型_);

                視窗_ = (通用視窗介面)(Activator.CreateInstance(Type_));
                詳細視窗Map.Add(類型_, 視窗_);
            }

            return 視窗_;
        }

        public void 顯現(列舉.編碼類型 類型_)
        {
            通用視窗介面 視窗_ = 取得詳細視窗(類型_);

            if (視窗_.是否顯現())
                視窗_.隱藏();
            視窗_.顯現();
        }

        public void 顯現(列舉.編碼類型 類型_, int 編號_)
        {
            通用視窗介面 視窗_ = 取得詳細視窗(類型_);
            
            //@@ 視窗隱藏->關閉視窗->儲存修改 這是如果要看的資料是新建立的 還沒設定內容 會出錯(因為儲存時會檢查資料是否合法)
            //if (視窗_.是否顯現())
            //    視窗_.隱藏();

            視窗_.顯現(編號_);
        }

        public void 隱藏(列舉.編碼類型 類型_)
        {
            通用視窗介面 視窗_ = 取得詳細視窗(類型_);
            視窗_.隱藏();
        }
    }
}
