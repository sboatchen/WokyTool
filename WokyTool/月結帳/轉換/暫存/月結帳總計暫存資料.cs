using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.月結帳
{
    public class 月結帳總計暫存資料
    {
        public string 名稱 { get; set; }

        public decimal 營業額 { get; set; }

        public decimal 進貨成本 { get; set; }

        public decimal 利潤 { get; set; }
    }
}

