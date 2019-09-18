using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public class 抽象列舉選取元件 : UserControl
    {
        public virtual ComboBox 下拉選單 { get { throw new Exception(this.GetType().Name + " 未設定下拉選單"); } }
        public virtual Type 列舉類型 { get { throw new Exception(this.GetType().Name + " 未設定列舉類型"); } }

        public bool ReadOnly
        {
            get
            {
                return this.下拉選單.DropDownStyle == ComboBoxStyle.Simple;
            }

            set
            {
                if (value == true)
                    this.下拉選單.DropDownStyle = ComboBoxStyle.Simple;
                else
                    this.下拉選單.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        public object SelectedItem
        {
            get
            {
                return this.下拉選單.SelectedItem;
            }

            set
            {
                if (this.下拉選單.SelectedItem != value)
                    this.下拉選單.SelectedItem = value;
            }
        }

        private 選取元件類型 _元件類型 = 選取元件類型.指定;
        public 選取元件類型 元件類型
        {
            get
            {
                return _元件類型;
            }
            set
            {
                _元件類型 = value;

                switch (_元件類型)
                {
                    case 選取元件類型.指定:
                        {
                            List<Object> 資料列_ = new List<object>();
                            foreach (var 資料_ in Enum.GetValues(列舉類型))
                            {
                                int Value_ = (int)資料_;
                                if (Value_ == 常數.不篩選列舉編碼)
                                    continue;

                                資料列_.Add(資料_);
                            }
                            this.下拉選單.DataSource = 資料列_.OrderBy(Value => (int)Value).ToList();
                        }
                        break;
                    case 選取元件類型.篩選:
                        {
                            List<Object> 資料列_ = new List<object>();
                            foreach (var 資料_ in Enum.GetValues(列舉類型))
                            {
                                資料列_.Add(資料_);
                            }
                            this.下拉選單.DataSource = 資料列_.OrderBy(Value => (int)Value).ToList();
                        }
                        break;
                    default:
                        訊息管理器.獨體.錯誤(this.GetType().Name + "不支援元件類型:" + 元件類型);
                        break;
                }
            }
        }
    }
}
