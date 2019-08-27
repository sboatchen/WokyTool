using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.一般訂單;
using WokyTool.公司;
using WokyTool.月結帳;
using WokyTool.平台訂單;
using WokyTool.使用者;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.配送;
using WokyTool.商品;
using WokyTool.進貨;
using WokyTool.幣值;
using WokyTool.廠商;
using WokyTool.聯絡人;

namespace WokyTool.通用
{
    public class 視窗管理器
    {
        public static int 取得編號(列舉.編號 編號類型_, 列舉.視窗 視窗類型_){
            return (int)編號類型_ * 10000 + (int)視窗類型_;
        }

        protected Dictionary<int, Type> _資料書 = new Dictionary<int, Type>();
        protected Dictionary<int, 通用視窗介面> _視窗書 = new Dictionary<int, 通用視窗介面>();


        // 獨體
        private static readonly 視窗管理器 _獨體 = new 視窗管理器();
        public static 視窗管理器 獨體 { get { return _獨體; } }

        private 視窗管理器()
        {
            _資料書.Add(取得編號(列舉.編號.使用者, 列舉.視窗.總覽), typeof(使用者總覽視窗));

            _資料書.Add(取得編號(列舉.編號.公司, 列舉.視窗.總覽), typeof(公司總覽視窗));

            _資料書.Add(取得編號(列舉.編號.聯絡人, 列舉.視窗.總覽), typeof(聯絡人總覽視窗));
            _資料書.Add(取得編號(列舉.編號.聯絡人, 列舉.視窗.詳細), typeof(聯絡人詳細視窗));

            _資料書.Add(取得編號(列舉.編號.子客戶, 列舉.視窗.總覽), typeof(子客戶總覽視窗));
            _資料書.Add(取得編號(列舉.編號.子客戶, 列舉.視窗.詳細), typeof(子客戶詳細視窗));

            _資料書.Add(取得編號(列舉.編號.客戶, 列舉.視窗.總覽), typeof(客戶總覽視窗));
            _資料書.Add(取得編號(列舉.編號.客戶, 列舉.視窗.詳細), typeof(客戶詳細視窗));

            _資料書.Add(取得編號(列舉.編號.物品大類, 列舉.視窗.總覽), typeof(物品大類總覽視窗));
            _資料書.Add(取得編號(列舉.編號.物品小類, 列舉.視窗.總覽), typeof(物品小類總覽視窗));
            _資料書.Add(取得編號(列舉.編號.物品品牌, 列舉.視窗.總覽), typeof(物品品牌總覽視窗));

            _資料書.Add(取得編號(列舉.編號.物品, 列舉.視窗.總覽), typeof(物品總覽視窗));
            _資料書.Add(取得編號(列舉.編號.物品, 列舉.視窗.詳細), typeof(物品詳細視窗));
            _資料書.Add(取得編號(列舉.編號.物品, 列舉.視窗.篩選), typeof(物品篩選視窗));

            //TODO

            _資料書.Add(取得編號(列舉.編號.商品大類, 列舉.視窗.總覽), typeof(商品大類總覽視窗));
            _資料書.Add(取得編號(列舉.編號.商品小類, 列舉.視窗.總覽), typeof(商品小類總覽視窗));
            _資料書.Add(取得編號(列舉.編號.商品, 列舉.視窗.總覽), typeof(商品總覽視窗));
            _資料書.Add(取得編號(列舉.編號.商品, 列舉.視窗.詳細), typeof(商品詳細視窗));
            _資料書.Add(取得編號(列舉.編號.商品, 列舉.視窗.篩選), typeof(商品篩選視窗));

            _資料書.Add(取得編號(列舉.編號.月結帳設定, 列舉.視窗.總覽), typeof(月結帳匯入設定總覽視窗));
            _資料書.Add(取得編號(列舉.編號.月結帳設定, 列舉.視窗.詳細), typeof(月結帳匯入設定詳細視窗));
            _資料書.Add(取得編號(列舉.編號.月結帳, 列舉.視窗.總覽), typeof(月結帳總覽視窗));
            _資料書.Add(取得編號(列舉.編號.月結帳, 列舉.視窗.詳細), typeof(月結帳詳細視窗));
            _資料書.Add(取得編號(列舉.編號.月結帳, 列舉.視窗.篩選), typeof(月結帳篩選視窗));
            _資料書.Add(取得編號(列舉.編號.月結帳會計, 列舉.視窗.總覽), typeof(月結帳會計總覽視窗));
            _資料書.Add(取得編號(列舉.編號.月結帳支出, 列舉.視窗.總覽), typeof(月結帳支出總覽視窗));

            _資料書.Add(取得編號(列舉.編號.平台訂單設定, 列舉.視窗.總覽), typeof(平台訂單匯入設定總覽視窗));
            _資料書.Add(取得編號(列舉.編號.平台訂單設定, 列舉.視窗.詳細), typeof(平台訂單匯入設定詳細視窗));
            _資料書.Add(取得編號(列舉.編號.平台訂單新增, 列舉.視窗.總覽), typeof(平台訂單新增總覽視窗));
            _資料書.Add(取得編號(列舉.編號.平台訂單新增_Momo三方, 列舉.視窗.總覽), typeof(Momo第三方訂單新增總覽視窗));

            _資料書.Add(取得編號(列舉.編號.一般訂單新增, 列舉.視窗.總覽), typeof(一般訂單新增總覽視窗));
            _資料書.Add(取得編號(列舉.編號.一般訂單新增, 列舉.視窗.詳細), typeof(一般訂單新增詳細視窗));
            _資料書.Add(取得編號(列舉.編號.一般訂單, 列舉.視窗.總覽), typeof(一般訂單總覽視窗));

            _資料書.Add(取得編號(列舉.編號.配送, 列舉.視窗.總覽), typeof(待配送總覽視窗));

            _資料書.Add(取得編號(列舉.編號.廠商, 列舉.視窗.總覽), typeof(廠商總覽視窗));

            _資料書.Add(取得編號(列舉.編號.幣值, 列舉.視窗.總覽), typeof(幣值總覽視窗));

            _資料書.Add(取得編號(列舉.編號.進貨新增, 列舉.視窗.總覽), typeof(進貨新增總覽視窗));
            _資料書.Add(取得編號(列舉.編號.進貨, 列舉.視窗.總覽), typeof(進貨總覽視窗));


            _資料書.Add(取得編號(列舉.編號.月結帳, 列舉.視窗.匯入), typeof(月結帳匯入視窗));
        }

        public 通用視窗介面 取得視窗(列舉.編號 編號類型_, 列舉.視窗 視窗類型_, bool 是否允許不存在_)
        {
            int 編號_ = 取得編號(編號類型_, 視窗類型_);

            通用視窗介面 視窗_ = null;
            if (_視窗書.TryGetValue(編號_, out 視窗_) == false)
            {
                Type Type_ = null;
                if (_資料書.TryGetValue(編號_, out Type_) == false)
                {
                    if (是否允許不存在_)
                        return null;
                    else
                        throw new Exception("視窗管理器:取得實體失敗, " + 編號類型_ + "," + 視窗類型_);
                }

                視窗_ = (通用視窗介面)(Activator.CreateInstance(Type_));
                _視窗書.Add(編號_, 視窗_);
            }

            return 視窗_;
        }

        public bool 顯現(列舉.編號 編號類型_, 列舉.視窗 視窗類型_, bool 是否允許不存在_ = false)
        {
            通用視窗介面 視窗_ = 取得視窗(編號類型_, 視窗類型_, 是否允許不存在_);
            if (視窗_ == null)
                return false;

            if (視窗_.是否顯現)
                視窗_.隱藏();
            視窗_.顯現();

            return true;
        }

        public bool 顯現(列舉.編號 編號類型_, 列舉.視窗 視窗類型_, int 資料編號_, bool 是否允許不存在_ = false)
        {
            通用視窗介面 視窗_ = 取得視窗(編號類型_, 視窗類型_, 是否允許不存在_);
            if (視窗_ == null)
                return false;

            //@@ 視窗隱藏->關閉視窗->儲存修改 這是如果要看的資料是新建立的 還沒設定內容 會出錯(因為儲存時會檢查資料是否合法)
            //if (視窗_.是否顯現)
            //    視窗_.隱藏();

            視窗_.顯現(資料編號_);

            return true;
        }

        public bool 隱藏(列舉.編號 編號類型_, 列舉.視窗 視窗類型, bool 是否允許不存在_ = false)
        {
            通用視窗介面 視窗_ = 取得視窗(編號類型_, 視窗類型, 是否允許不存在_);
            if (視窗_ == null)
                return false;

            視窗_.隱藏();

            return true;
        }
    }
}
