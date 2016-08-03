using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.Data
{
    public class 合併可配送 : 可配送
    {
        protected List<出貨資料> _Child = new List<出貨資料>();

        public string 配送姓名 { get; set; }
        public string 配送電話 { get; set; }
        public string 配送手機 { get; set; }
        public string 配送地址 { get; set; }

        public string 配送商品 { get; set; }
        public string 配送備註 { get; set; }

        public DateTime 指配日期 { get; set; }
        public WokyTool.Common.列舉.指配時段類型 指配時段 { get; set; }

        public WokyTool.Common.列舉.代收類型 代收方式 { get; set; }
        public int 代收金額 { get; set; }

        protected WokyTool.Common.列舉.配送公司類型 _配送公司;
        public WokyTool.Common.列舉.配送公司類型 配送公司
        {
            get
            {
                return _配送公司;
            }
            set
            {
                _配送公司 = value;
                foreach (var Item in _Child)
                    Item.配送公司 = value;
            }
        }

        protected string _配送單號;
        public string 配送單號
        {
            get
            {
                return _配送單號;
            }
            set
            {
                _配送單號 = value;
                foreach (var Item in _Child)
                    Item.SetDiliver(value);
            }
        }

        public string 姓名 { get; set; }
        public string 廠商 { get; set; }
        public int 總體積 { get; set; }

        // 準備配送
        public void PrepareDiliver()
        {
            {
                StringBuilder sb = new StringBuilder(姓名);
                bool IsFrist_ = true;
                foreach (var Item_ in _Child)
                {
                    if (Item_.重要備註 == null || Item_.重要備註.Length == 0)
                        continue;

                    if (IsFrist_)
                    {
                        sb.Append('(');
                        sb.Append(Item_.重要備註);
                        IsFrist_ = false;
                    }
                    else
                    {
                        sb.Append(',');
                        sb.Append(Item_.重要備註);
                    }
                }
                if(IsFrist_ == false)
                    sb.Append(')');
                配送姓名 = sb.ToString();
            }

            {
                StringBuilder sb = new StringBuilder(廠商);
                bool IsFrist_ = true;
                foreach (var Item_ in _Child)
                {
                    if (Item_.備註 == null || Item_.備註.Length == 0)
                        continue;

                    if (IsFrist_)
                    {
                        sb.Append('(');
                        sb.Append(Item_.備註);
                        IsFrist_ = false;
                    }
                    else
                    {
                        sb.Append(',');
                        sb.Append(Item_.備註);
                    }
                }
                if (IsFrist_ == false)
                    sb.Append(')');
                配送備註 = sb.ToString();
            }

            Dictionary<String, int> 物品列表_ = new Dictionary<String, int>();
            總體積 = 0;
            foreach (var Item_ in _Child)
            {
                Item_.商品.GetCombine(物品列表_, Item_.數量);
                總體積 += Item_.總體積;
            }
            配送商品 = 函式.GetCombineItemString(物品列表_);
            
            // 配送公司
            if (配送公司 != 列舉.配送公司類型.無)
                return;
            if (總體積 >= 常數.宅配通配送最小體積)
                配送公司 = 列舉.配送公司類型.宅配通;
            else
                配送公司 = 列舉.配送公司類型.全速配;
        }

        // 完成配送
        public void SetDiliver(string 配送單號_)
        {
            if (IsDilivered())
            {
                MessageBox.Show("合併可配送::SetDiliver fail, already exit, call programmer ", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            配送單號 = 配送單號_;
        }

        // 是否已經配送
        public bool IsDilivered()
        {
            return 配送單號 != null && 配送單號.Length != 0;
        }

        public bool Add(出貨資料 Child_)
        {
            if (true == Child_.IsDilivered())
            {
                MessageBox.Show("合併可配送::Add fail, 已配送 " + Child_.姓名, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 第一筆資料
            if (_Child.Count == 0)
            {
                姓名 = Child_.姓名;
                廠商 = Child_.廠商.名稱;

                配送電話 = Child_.電話;
                配送手機 = Child_.手機;
                配送地址 = Child_.地址;

                指配日期 = Child_.指配日期;
                指配時段 = Child_.指配時段;
                代收方式 = Child_.代收方式;
                代收金額 = Child_.代收金額;

                _配送公司 = Child_.配送公司;
                _配送單號 = null;
            }
            else
            {
                if (姓名 != Child_.姓名)
                {
                    MessageBox.Show("姓名不統一 " + Child_.姓名, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (廠商 != Child_.廠商.名稱)
                {
                    MessageBox.Show("廠商不統一 " + Child_.姓名, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (配送地址 != Child_.地址)
                {
                    MessageBox.Show("配送地址不統一 " + Child_.姓名, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (配送電話 != Child_.電話)
                {
                    MessageBox.Show("配送電話不統一 " + Child_.姓名, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (配送手機 != Child_.手機)
                {
                    MessageBox.Show("配送手機不統一 " + Child_.姓名, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (指配日期 != Child_.指配日期)
                {
                    MessageBox.Show("指配日期不統一 " + Child_.姓名, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (指配時段 != Child_.指配時段)
                {
                    MessageBox.Show("指配時段不統一 " + Child_.姓名, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (代收方式 != Child_.代收方式)
                {
                    MessageBox.Show("代收方式不統一 " + Child_.姓名, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                代收金額 += Child_.代收金額;

                if (配送公司 != Child_.配送公司)
                {
                    MessageBox.Show("配送公司不統一 " + Child_.姓名, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            _Child.Add(Child_);

            return true;
        }

        // 發票是否符合
        public bool IsReceiptMatch(string 發票號碼_) 
        {
            // 第一筆資料
            if (_Child.Count == 0)
                return false; 
            else
                return _Child[0].IsReceiptMatch(發票號碼_);
        }
    }
}
