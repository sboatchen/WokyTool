using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.聯絡人
{
    public class 聯絡人資料匯入轉換 : 可讀出介面_EXCEL<聯絡人更新資料>
    {
        public int 分頁索引 { get { return 1; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        protected string[] _標頭列;

        public 聯絡人資料匯入轉換()
        {
        }



        public void 讀出標頭(string[] 標頭列_)
        {
            this._標頭列 = 標頭列_;


            /*List<聯絡人更新資料> list = new List<聯絡人更新資料>();

            list.Where(Value => true)
            

            IEnumerable<聯絡人更新資料>*/
        }

        public IEnumerable<聯絡人更新資料> 讀出資料(string[] 資料列_)
        {
            /*string 訂單編號_ = 資料列_[0].轉成字串();

            string 姓名_ = 資料列_[13].轉成字串();
            string 手機_ = 資料列_[15].轉成字串();
            string 電話_ = 資料列_[14].轉成字串();
            string 地址_ = 資料列_[16].轉成字串();

            string 商品識別_ = 資料列_[5].轉成字串();
            商品資料 商品_ = 商品資料管理器.獨體.Get(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[9].轉成整數();

            string 備註_ = 資料列_[17].轉成字串();

            yield return new 平台訂單匯入資料
            {
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

                自定義介面 = this,
                標頭 = _標頭列,
                內容 = 資料列_,

            };*/

            return null;
        }
    }
}
