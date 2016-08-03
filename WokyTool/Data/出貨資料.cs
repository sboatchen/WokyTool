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
    public class 出貨資料 : 可配送, IComparable<出貨資料>
    {
        [CsvColumn(Name = "姓名")]
        public string 姓名 { get; set; }
        [CsvColumn(Name = "地址")]
        public string 地址 { get; set; }
        [CsvColumn(Name = "電話")]
        public string 電話 { get; set; }
        [CsvColumn(Name = "手機")]
        public string 手機 { get; set; }

        public 廠商資料 廠商;
        [CsvColumn(Name = "廠商編號")]
        public int 廠商編號
        {
            get
            {
                return 廠商.編號;
            }
            set
            {
                廠商 = 廠商管理器.Instance.Get(value);
            }
        }
        [CsvColumn(Name = "訂單編號")]
        public string 訂單編號 { get; set; }

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

        [CsvColumn(Name = "數量")]
        public int 數量 { get; set; }

        [CsvColumn(Name = "備註")]
        public string 備註 { get; set; }

        [CsvColumn(Name = "指配日期")]
        public DateTime 指配日期 { get; set; }
        [CsvColumn(Name = "指配時段")]
        public WokyTool.Common.列舉.指配時段類型 指配時段 { get; set; }

        [CsvColumn(Name = "代收方式")]
        public WokyTool.Common.列舉.代收類型 代收方式 { get; set; }
        [CsvColumn(Name = "代收金額")]
        public int 代收金額 { get; set; }

        [CsvColumn(Name = "配送公司")]
        virtual public WokyTool.Common.列舉.配送公司類型 配送公司 { get; set; }
        [CsvColumn(Name = "配送單號")]
        public string 配送單號 { get; set; }

        /* 可配送其他欄位 */
        public string 配送姓名 { get; set; }
        
        public string 配送電話
        {
            get { return 電話; }
            set { 電話 = value; }
        }

        public string 配送手機
        {
            get{ return 手機; }
            set{ 手機 = value; }
        }

        public string 配送地址
        {
            get { return 地址; }
            set { 地址 = value; }
        }

        public string 配送商品 { get; set; }
        public string 配送備註 { get; set; }

        /* 其他欄位 */

        public int 群組 { get; set; }
        public string 商品序號 { get; set; }
        public string 重要備註 { get; set; }
        public int 總體積 { get; set; }

        // 是否為需處理物件
        virtual public bool IsRead()
        {
            return 姓名 != null;
        }

        // 是否合法
        virtual public bool IsLegal()
        {
            return IsIgnore() || (商品 != null && 商品.編號 > 0);
        }

        // 初始化
        virtual public void Init()
        {
            ;
        }

        // 是否忽略配送
        virtual public bool IsIgnore()
        {
            return false;
        }

        // 準備配送
        virtual public void PrepareDiliver()
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
            商品.GetCombine(物品列表_, 數量);
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
        virtual public void SetDiliver(string 配送單號_)
        {
            if(IsDilivered())
            {
                MessageBox.Show("出貨資料::SetDiliver fail, already exit, call programmer ", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            配送單號 = 配送單號_;

            //@@ 進行商品消耗
        }

        // 是否已經配送
        virtual public bool IsDilivered()
        {
            return IsIgnore() || (配送單號 != null && 配送單號.Length != 0);
        }

        // IComparable
        virtual public int CompareTo(出貨資料 Other)
        {
            // A null value means that this object is greater.
            if (Other == null)
                return 1;

            return 地址.CompareTo(Other.地址);
        }

        // 發票是否符合
        virtual public bool IsReceiptMatch(string 發票號碼_) { return false; }
    }
}
