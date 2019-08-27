using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace WokyTool.客製
{
    public class 平台訂單匯入轉換_松果_超商 : 平台訂單自定義介面, 可讀出介面_EXCEL<平台訂單匯入資料>
    {
        public int 分頁索引 { get { return 1; } }

        public int 標頭索引 { get { return 1; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 密碼 { get { return null; } }

        public 列舉.配送公司 配送公司 { get; set; }

        protected string[] _標頭列;

        public 平台訂單匯入轉換_松果_超商()
        {
            客戶 = 客戶資料管理器.獨體.取得("松果");
        }

        public void 讀出標頭(string[] 標頭列_)
        {
            if (配送公司 != 列舉.配送公司.SEVEN && 配送公司 != 列舉.配送公司.全家)
            {
                訊息管理器.獨體.錯誤("該模組需指定超商配送");
                return;
            }

            this._標頭列 = 標頭列_;
        }

        public IEnumerable<平台訂單匯入資料> 讀出資料(string[] 資料列_)
        {
            string 訂單編號_ = 資料列_[0].轉成字串().Trim();   // 前面有空白

            string 姓名_ = 資料列_[9].轉成字串();
            string 電話_ = 資料列_[10].轉成字串();
            string 地址_ = 資料列_[11].轉成字串();

            // 商品序號 = 商品編號 + 選項
            string 商品編號_ = 資料列_[13].轉成字串();
            string 款式_ = 資料列_[18].轉成字串();
            string 商品識別_ = 函式.取得商品識別(商品編號_, 款式_);
            商品資料 商品_ = 商品資料管理器.獨體.Get(客戶.編號, 商品識別_);

            int 數量_ = 資料列_[20].轉成整數();

            string 配送編號_ = 資料列_[2].轉成字串().Trim();   // 前面有空白

            yield return new 平台訂單匯入資料
            {
                處理狀態 = 列舉.訂單處理狀態.配送,
                訂單編號 = 訂單編號_,

                客戶 = this.客戶,

                姓名 = 姓名_,
                電話 = 電話_,
                地址 = 地址_,

                商品識別 = 商品識別_,
                商品 = 商品_,
                數量 = 數量_,

                配送公司 = 配送公司,
                配送單號 = 配送編號_,

                自定義介面 = this,
                標頭 = _標頭列,
                內容 = 資料列_,
            };
        }

        public override IEnumerable<平台訂單匯入資料> 轉換(動態匯入檔案結構 動態匯入檔案結構_)
        {
            throw new NotImplementedException();
        }

        public override String 取得分組識別(平台訂單新增資料 資料_)
        {
            return String.Format("{0}_{1}", 資料_.配送公司, 資料_.配送單號);
        }

        public override void 回單(IEnumerable<平台訂單新增資料> 資料列舉_)
        {
            {
                IEnumerable<平台訂單新增資料> 篩選資料列舉_ = 資料列舉_.Where(Value => Value.配送公司 == 列舉.配送公司.SEVEN);
                if (篩選資料列舉_.Any())
                {
                    var 轉換_ = new 平台訂單配送轉換_松果_SEVEN(篩選資料列舉_);
                    檔案.詢問並修改("松果Seven配送原始檔", 轉換_);
                }
            }

            {
                IEnumerable<平台訂單新增資料> 篩選資料列舉_ = 資料列舉_.Where(Value => Value.配送公司 == 列舉.配送公司.全家);
                if (篩選資料列舉_.Any())
                {
                    var 轉換_ = new 平台訂單配送轉換_松果_全家(篩選資料列舉_);
                    檔案.詢問並修改("松果全家配送原始檔", 轉換_);
                }
            }
        }
    }
}
