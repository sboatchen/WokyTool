using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Data;
//@@ 帶整理
namespace WokyTool.DataImport
{
    class 月結帳匯入結構_Momo
    {
        public string 品號 { get; set; }
        public string 單品編號 { get; set; }

        public int 含稅進價 { get; set; }
        public int 對帳數量 { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        
        public 月結帳資料 ToData()
        {
            月結帳資料 New_ = new 月結帳資料
            {
                廠商編號 = 5,
                商品品號 = this.品號 + "@" + this.單品編號,
                時間 = DateTime.Now,

                單價 = this.含稅進價,
                數量 = this.對帳數量,
            };

            New_.成本 = New_.商品.成本;

            return New_;
        }
    }

}
