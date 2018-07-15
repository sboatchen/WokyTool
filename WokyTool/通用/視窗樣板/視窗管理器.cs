﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.聯絡人;

namespace WokyTool.通用
{
    public class 視窗管理器
    {
        private Dictionary<列舉.編碼類型, Type> 總覽視窗設定Map { get; set; }
        private Dictionary<列舉.編碼類型, 通用視窗介面> 總覽視窗Map { get; set; }

        private Dictionary<列舉.編碼類型, Type> 詳細視窗設定Map { get; set; }
        private Dictionary<列舉.編碼類型, 通用視窗介面> 詳細視窗Map { get; set; }

        private Dictionary<列舉.編碼類型, Type> 篩選視窗設定Map { get; set; }
        private Dictionary<列舉.編碼類型, 通用視窗介面> 篩選視窗Map { get; set; }

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
            總覽視窗設定Map = new Dictionary<列舉.編碼類型, Type>();
            總覽視窗Map = new Dictionary<列舉.編碼類型, 通用視窗介面>();

            總覽視窗設定Map.Add(列舉.編碼類型.公司, typeof(公司總覽視窗));

            總覽視窗設定Map.Add(列舉.編碼類型.客戶, typeof(客戶總覽視窗));
            總覽視窗設定Map.Add(列舉.編碼類型.子客戶, typeof(子客戶總覽視窗));
            總覽視窗設定Map.Add(列舉.編碼類型.聯絡人, typeof(聯絡人總覽視窗));

            總覽視窗設定Map.Add(列舉.編碼類型.物品大類, typeof(物品大類總覽視窗));
            總覽視窗設定Map.Add(列舉.編碼類型.物品小類, typeof(物品小類總覽視窗));
            總覽視窗設定Map.Add(列舉.編碼類型.物品品牌, typeof(物品品牌總覽視窗));
            總覽視窗設定Map.Add(列舉.編碼類型.物品, typeof(物品總覽視窗));

            總覽視窗設定Map.Add(列舉.編碼類型.商品大類, typeof(商品大類總覽視窗));
            總覽視窗設定Map.Add(列舉.編碼類型.商品小類, typeof(商品小類總覽視窗));
            總覽視窗設定Map.Add(列舉.編碼類型.商品, typeof(商品總覽視窗));

            /********************************/

            詳細視窗設定Map = new Dictionary<列舉.編碼類型, Type>();
            詳細視窗Map = new Dictionary<列舉.編碼類型, 通用視窗介面>();

            詳細視窗設定Map.Add(列舉.編碼類型.客戶, typeof(客戶詳細視窗));
            詳細視窗設定Map.Add(列舉.編碼類型.子客戶, typeof(子客戶詳細視窗));
            詳細視窗設定Map.Add(列舉.編碼類型.物品, typeof(物品詳細視窗));

            詳細視窗設定Map.Add(列舉.編碼類型.商品, typeof(商品詳細視窗));

            /********************************/

            篩選視窗設定Map = new Dictionary<列舉.編碼類型, Type>();
            篩選視窗Map = new Dictionary<列舉.編碼類型, 通用視窗介面>();

            篩選視窗設定Map.Add(列舉.編碼類型.物品, typeof(物品篩選視窗));
        }

        private 通用視窗介面 取得總覽視窗(列舉.編碼類型 類型_)
        {
            通用視窗介面 視窗_ = null;
            if (總覽視窗Map.TryGetValue(類型_, out 視窗_) == false)
            {
                Type Type_ = null;
                if (總覽視窗設定Map.TryGetValue(類型_, out Type_) == false)
                    throw new Exception("視窗管理器:取得總覽視窗實體失敗, " + 類型_);

                視窗_ = (通用視窗介面)(Activator.CreateInstance(Type_));
                總覽視窗Map.Add(類型_, 視窗_);
            }

            return 視窗_;
        }

        private 通用視窗介面 取得詳細視窗(列舉.編碼類型 類型_)
        {
            通用視窗介面 視窗_ = null;
            if ( 詳細視窗Map.TryGetValue(類型_, out 視窗_) == false)
            {
                Type Type_ = null;
                if ( 詳細視窗設定Map.TryGetValue(類型_, out Type_) == false)
                    throw new Exception("視窗管理器:取得詳細視窗實體失敗, " + 類型_);

                視窗_ = (通用視窗介面)(Activator.CreateInstance(Type_));
                詳細視窗Map.Add(類型_, 視窗_);
            }

            return 視窗_;
        }

        private 通用視窗介面 取得篩選視窗(列舉.編碼類型 類型_)
        {
            通用視窗介面 視窗_ = null;
            if (篩選視窗Map.TryGetValue(類型_, out 視窗_) == false)
            {
                Type Type_ = null;
                if (篩選視窗設定Map.TryGetValue(類型_, out Type_) == false)
                    throw new Exception("視窗管理器:取得篩選視窗實體失敗, " + 類型_);

                視窗_ = (通用視窗介面)(Activator.CreateInstance(Type_));
                篩選視窗Map.Add(類型_, 視窗_);
            }

            return 視窗_;
        }

        private 通用視窗介面 取得視窗(列舉.編碼類型 編碼類型_, 列舉.視窗類型 視窗類型_)
        {
            switch (視窗類型_)
            {
                case 列舉.視窗類型.總覽:
                    return 取得總覽視窗(編碼類型_);
                case 列舉.視窗類型.詳細:
                    return 取得詳細視窗(編碼類型_);
                case 列舉.視窗類型.篩選:
                    return 取得篩選視窗(編碼類型_);
                default:
                    throw new Exception("視窗管理器::取得視窗 為支援的視窗類型 " + 視窗類型_);
            }
        }

        public void 顯現(列舉.編碼類型 編碼類型_, 列舉.視窗類型 視窗類型)
        {
            通用視窗介面 視窗_ = 取得視窗(編碼類型_, 視窗類型);

            if (視窗_.是否顯現())
                視窗_.隱藏();
            視窗_.顯現();
        }

        public void 顯現(列舉.編碼類型 編碼類型_, 列舉.視窗類型 視窗類型, int 編號_)
        {
            通用視窗介面 視窗_ = 取得視窗(編碼類型_, 視窗類型);
            
            //@@ 視窗隱藏->關閉視窗->儲存修改 這是如果要看的資料是新建立的 還沒設定內容 會出錯(因為儲存時會檢查資料是否合法)
            //if (視窗_.是否顯現())
            //    視窗_.隱藏();

            視窗_.顯現(編號_);
        }

        public void 隱藏(列舉.編碼類型 編碼類型_, 列舉.視窗類型 視窗類型)
        {
            通用視窗介面 視窗_ = 取得視窗(編碼類型_, 視窗類型);

            視窗_.隱藏();
        }
    }
}
