using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;

namespace WokyTool.Data
{
    public class 出貨資料 : 訂單資料
    {
        public 商品資料 商品;
        [CsvColumn(Name = "商品編號")]
        public int 商品編號
        {
            get
            {
                return 商品.編號;
            }
            set
            {
                商品 = 商品管理器.Instance.Get(value);
            }
        }

        /* 其他欄位 */

        public string 商品序號 { get; set; }
        public bool 寄庫出貨 { get; set; }


        // 是否合法
        override public bool IsLegal()
        {
            return IsIgnore() || (商品 != null && 商品.編號 > 0);
        }

        // 初始化
        override public void Init()
        {
            ;
        }

        // 準備配送
        override public void PrepareDiliver()
        {
            if (IsIgnore())
                return;

            if (重要備註 == null || 重要備註.Length == 0)
                配送姓名 = 姓名;
            else
                配送姓名 = string.Format("{0}({1})", 姓名, 重要備註);

            if (備註 == null || 備註.Length == 0)
                配送備註 = 廠商.名稱;
            else
                配送備註 = string.Format("{0}({1})", 廠商.名稱, 備註);


            Dictionary<String, int> 物品列表_ = new Dictionary<String, int>();
            GetItemMap(物品列表_);
            配送商品 = 函式.GetCombineItemString(物品列表_);

            總體積 = 商品.體積 * 數量;

            // 配送公司
            if (配送公司 != 列舉.配送公司類型.無)
                return;
            if (總體積 >= 常數.宅配通配送最小體積)
                配送公司 = 列舉.配送公司類型.宅配通;
            else
                配送公司 = 列舉.配送公司類型.全速配;
        }

        // 完成配送
        override public void SetDiliver(string 配送單號_)
        {
            if(IsDilivered())
            {
                MessageBox.Show("出貨資料::SetDiliver fail, already exit, call programmer ", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            配送單號 = 配送單號_;

            // 庫存處理
            商品.Sell(寄庫出貨, 數量);

            //@@ 填寫收入資料
            int 成本_ = 商品.成本;
        }

        // 取出內容物
        override public void GetItemMap(Dictionary<String, int> 物品列表_)
        {
            if (商品 != null)
                 商品.GetCombine(物品列表_, 數量);
        }
    }
}
