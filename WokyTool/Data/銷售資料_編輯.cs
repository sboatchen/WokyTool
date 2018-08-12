using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;

namespace WokyTool.Data
{
    public class 銷售資料_編輯
    {
        protected 銷售資料 _Data;

        public 銷售資料_編輯(銷售資料 Data_)
        {
            _Data = Data_;
        }

        public int 編號 { get{ return _Data.編號; } }
        public 舊列舉.銷售狀態類型 狀態 
        {
            get{ return _Data.狀態; }
            set { _Data.Set狀態(value); } 
        }
        public DateTime 建立日期 { get { return _Data.建立日期; } }
        public DateTime 結單日期 { get { return _Data.結單日期; } }

        public string 姓名 { get{ return _Data.姓名; } }
        public string 地址 { get{ return _Data.地址; } }
        public string 電話 { get{ return _Data.電話; } }
        public string 手機 { get{ return _Data.手機; } }

        public string 廠商 { get{ return _Data.廠商; } }
        public string 公司 { get { return _Data.公司; } }
        public string 訂單編號 { get{ return _Data.訂單編號; } }

        public bool 寄庫出貨 { get { return _Data.寄庫出貨; } }
        public string 備註 { get{ return _Data.備註; } }

        public DateTime 指配日期 { get{ return _Data.指配日期; } }
        public string 指配時段 { get{ return _Data.指配時段; } }

        public string 代收方式 { get{ return _Data.代收方式; } }
        public int 代收金額 { get{ return _Data.代收金額; } }

        public string 配送公司 { get{ return _Data.配送公司; } }
        public string 配送單號 { get{ return _Data.配送單號; } }

        public string 商品 { get{ return _Data.商品名稱; } }
        public string 商品類型 { get { return _Data.商品類型; } }
        public int 商品編號 { get { return _Data.商品編號; } }

        public int 數量 { get{ return _Data.數量; } }
        public int 成本 { get{ return _Data.成本; } }
        public int 售價 
        { 
            get{ return _Data.售價; }
            set { _Data.Set售價(value); } 
        }

        public int 利潤 { get { return _Data.利潤; } }
        public int 總利潤 { get { return _Data.總利潤; } }
    }
}
