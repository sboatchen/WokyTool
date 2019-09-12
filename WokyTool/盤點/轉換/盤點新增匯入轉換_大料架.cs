﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.寄庫;
using WokyTool.客戶;
using WokyTool.客製;
using WokyTool.配送;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.盤點
{
    public class 盤點新增匯入轉換_大料架 : 可讀出介面_EXCEL<寄庫新增匯入資料>
    {
        public int 分頁索引 { get { return 1; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        protected string[] _標頭列;

        protected 客戶資料 客戶;

        public 盤點新增匯入轉換_大料架()
        {
            客戶 = 客戶資料管理器.獨體.取得("Momo");
        }

        public void 讀出標頭(string[] 標頭列_)
        {
            this._標頭列 = 標頭列_;
        }

        public IEnumerable<寄庫新增匯入資料> 讀出資料(string[] 資料列_)
        {
            string 入庫單號_ = 資料列_[1].轉成字串();

            // 商品識別 = 商品編號 + 單品編碼
            string 商品編號_ = 資料列_[2].轉成字串();
            string 單品編碼_ = 資料列_[3].轉成字串();
            string 商品識別_ = 函式.取得商品識別(商品編號_, 單品編碼_);
            商品資料 商品_ = 商品資料管理器.獨體.取得(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[6].轉成整數();

            yield return new 寄庫新增匯入資料
            {
                客戶 = this.客戶,

                商品識別 = 商品識別_,
                商品 = 商品_,
                數量 = 數量_,

                入庫單號 = 入庫單號_,
            };
        }
    }
}
