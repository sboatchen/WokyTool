using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.配送
{
    public class 撿貨資料
    {
        public string 物品名稱 { get; set; }

        public int 數量 { get; set; }

        public 撿貨資料()
        { 
        }

        public 撿貨資料(String 物品名稱_, int 數量_)
        {
            this.物品名稱 = 物品名稱_;
            this.數量 = 數量_;
        }

    }
}
