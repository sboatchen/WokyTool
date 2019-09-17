using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.平台訂單;
using WokyTool.客戶;
using WokyTool.配送;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public class 平台訂單匯入處理_生活市集 : 平台訂單匯入處理介面, 可讀出介面_CSV<平台訂單新增匯入資料>
    {
        public string 分格號 { get { return ","; } }

        public bool 是否有標頭 { get { return true; } }

        public string 密碼 { get { return null; } }

        public Encoding 編碼 { get { return Encoding.Default; } }

        public 平台訂單匯入處理_生活市集()
        {
            客戶 = 客戶資料管理器.獨體.取得("生活市集");
        }

        public IEnumerable<平台訂單新增匯入資料> 讀出資料(string[] 資料列_)
        {
            string 訂單編號_ = 資料列_[0].轉成字串();

            string 姓名_ = 資料列_[17].轉成字串();
            string 手機_ = 資料列_[19].轉成字串();
            string 電話_ = 資料列_[20].轉成字串();
            if ("#".Equals(電話_))
                電話_ = null;

            string 地址_ = 資料列_[18].轉成字串();

            string 商品識別_ = 資料列_[4].轉成字串();
            商品資料 商品_ = 商品資料管理器.獨體.取得(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[9].轉成整數();

            string 備註_ = 資料列_[14].轉成字串();

            yield return new 平台訂單新增匯入資料
            {
                處理時間 = DateTime.Now,
                處理狀態 = 列舉.訂單處理狀態.新增,

                訂單編號 = 訂單編號_,

                客戶 = this.客戶,

                姓名 = 姓名_,
                手機 = 手機_,
                電話 = 電話_,
                地址 = 地址_,

                商品識別 = 商品識別_,
                商品 = 商品_,
                數量 = 數量_,

                備註 = 備註_,

                處理器 = this,
                標頭 = _標頭列,
                內容 = 資料列_,
            };
        }
    }
}
