using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public partial class 錯誤總覽視窗: Form
    {
        private 列印檢查器 _檢查器;

        private Type _資料類型;
        private List<通用匯出欄位方法資料> _欄位方法列;
        private int _處理欄位最大索引;

        public 錯誤總覽視窗(列印檢查器 檢查器_, string 標題_ = "錯誤總覽視窗")
        {
            InitializeComponent();

            this.Text = 標題_;

            this._檢查器 = 檢查器_;
            if (檢查器_.資料書.Count == 0)
                return;

            _資料類型 = 檢查器_.資料書.First().Key.GetType();
            List<Type> 繼承結構列_ = 函式.取得繼承結構列(_資料類型);

            List<DataGridViewTextBoxColumn> 呈現欄位列_ = new List<DataGridViewTextBoxColumn>();

            DataGridViewTextBoxColumn 錯誤訊息欄位_ = new DataGridViewTextBoxColumn();
            錯誤訊息欄位_.DataPropertyName = "Value";
            錯誤訊息欄位_.HeaderText = "錯誤訊息";
            錯誤訊息欄位_.Name = "錯誤訊息";
            錯誤訊息欄位_.ReadOnly = true;
            呈現欄位列_.Add(錯誤訊息欄位_);

            _欄位方法列 = new List<通用匯出欄位方法資料>();
            foreach (PropertyInfo 欄位_ in _資料類型.GetProperties().OrderByDescending(Value => 繼承結構列_.IndexOf(Value.DeclaringType)))
            {
                可匯出Attribute 屬性_ = 欄位_.GetCustomAttributes(typeof(可匯出Attribute), true).Cast<可匯出Attribute>().DefaultIfEmpty(null).First();
                if (屬性_ == null)
                    continue;

                string 名稱_ = 欄位_.Name;
                if (false == string.IsNullOrEmpty(屬性_.名稱))
                    名稱_ = 屬性_.名稱;

                通用匯出欄位方法資料 方法資料_ = new 通用匯出欄位方法資料
                {
                    名稱 = 名稱_,
                    方法 = _資料類型.GetProperty(欄位_.Name)
                };

                _欄位方法列.Add(方法資料_);

                DataGridViewTextBoxColumn 呈現欄位_ = new DataGridViewTextBoxColumn();
                呈現欄位_.HeaderText = 名稱_;
                呈現欄位_.Name = 名稱_;
                呈現欄位_.ReadOnly = true;
                呈現欄位列_.Add(呈現欄位_);
            }

            _處理欄位最大索引 = _欄位方法列.Count - 1;

            this.dataGridView1.Columns.AddRange(呈現欄位列_.ToArray());
            this.dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(_CellFormatting);

            this.dataGridView1.DataSource = _檢查器.資料書.Select(Pair => Pair).ToList();
        }

        private void _CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex <= _處理欄位最大索引)
            {
                object 資料_ = ((KeyValuePair<object, string>)dataGridView1.Rows[e.RowIndex].DataBoundItem).Key;
                e.Value = _欄位方法列[e.ColumnIndex].方法.GetValue(資料_);
            }
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 通用錯誤列印匯出轉換(_檢查器.資料書);

            string 標題_ = String.Format("{0}錯誤匯出_{1}", _資料類型.Name, 時間.目前日期);
            if (檔案.詢問並寫入(標題_, (可寫入介面_EXCEL)轉換_))
                訊息管理器.獨體.通知("匯出完成");
        }
    }
}
