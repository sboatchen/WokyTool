﻿using LINQtoCSV;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataImport;
using WokyTool.DataMgr;

namespace WokyTool
{
    public partial class 商品匯入視窗 : Form
    {
        private List<商品匯入結構> _Source;
        private BindingSource _Binding;

        protected 監測綁定更新<商品大類資料> _商品大類資料Listener;
        protected 監測綁定更新<商品小類資料> _商品小類資料Listener;
        protected 監測綁定更新<公司資料> _公司資料Listener;
        protected 監測綁定更新<廠商資料> _廠商資料Listener;
        protected 監測綁定更新<物品資料> _物品資料Listener;

        public 商品匯入視窗(ExcelQueryFactory Data)
        {
            InitializeComponent();

            _Source = Data.Worksheet<商品匯入結構>()
                            .ToList();

            foreach (var Item_ in _Source)
                Item_.Init();

            _Binding = new BindingSource();
            _Binding.DataSource = _Source;
            this.dataGridView1.DataSource = _Binding;

            _商品大類資料Listener = new 監測綁定更新<商品大類資料>(商品大類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 商品大類資料更新);
            _商品大類資料Listener.Refresh(true);

            _商品小類資料Listener = new 監測綁定更新<商品小類資料>(商品小類管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 商品小類資料更新);
            _商品小類資料Listener.Refresh(true);

            _公司資料Listener = new 監測綁定更新<公司資料>(公司管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 公司資料更新);
            _公司資料Listener.Refresh(true);

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);

            _物品資料Listener = new 監測綁定更新<物品資料>(物品管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品資料更新);
            _物品資料Listener.Refresh(true);

            //@@ 測試 看是匯入的視窗 還是總覽視窗 那些需要隱藏combobox
            this.大類編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.小類編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.公司編號.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.廠商編號DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.需求編號1DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.需求編號2DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.需求編號3DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.需求編號4DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.需求編號5DataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
        }

        public void 商品大類資料更新(IEnumerable<商品大類資料> Data_)
        {
            this.大類編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 商品小類資料更新(IEnumerable<商品小類資料> Data_)
        {
            this.小類編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 公司資料更新(IEnumerable<公司資料> Data_)
        {
            this.公司編號.DataSource = Data_;
        }

        public void 廠商資料更新(IEnumerable<廠商資料> Data_)
        {
            this.廠商編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 物品資料更新(IEnumerable<物品資料> Data_)
        {
            this.需求編號1DataGridViewTextBoxColumn.DataSource = Data_;
            this.需求編號2DataGridViewTextBoxColumn.DataSource = Data_;
            this.需求編號3DataGridViewTextBoxColumn.DataSource = Data_;
            this.需求編號4DataGridViewTextBoxColumn.DataSource = Data_;
            this.需求編號5DataGridViewTextBoxColumn.DataSource = Data_;
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _商品大類資料Listener.Refresh();
            _商品小類資料Listener.Refresh();
            _公司資料Listener.Refresh();
            _廠商資料Listener.Refresh();
            _物品資料Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Source.Add(商品匯入結構.New());
            _Binding.ResetBindings(true);
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((商品匯入結構)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }
        }

        private void 列錯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "錯誤商品";              // Default file name
            dlg.DefaultExt = ".csv";                // Default file extension
            dlg.Filter = "csv files (.csv)|*.csv";  // Filter files by extension

            if (dlg.ShowDialog() == DialogResult.OK) 
            {
                StreamWriter sw = new StreamWriter(dlg.FileName, false, Encoding.Default);

                var Error_ = _Source.Where(Value => Value.IsLegal() == false)
                                    .Select(Value => Value.ToError());

                CsvContext cc = new CsvContext();
                cc.Write(Error_, sw, 共用.OutputDefine);

                sw.Close();
            }
        }

        private void 商品匯入視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 檢查匯入資料的正確性
            foreach (var Data in _Source)
            {
                // 資料有錯誤
                if (Data.IsLegal() == false)
                {
                    var result = MessageBox.Show(字串.匯入錯誤, 字串.匯入確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }

                    return;
                }
            }

            var result2 = MessageBox.Show(字串.匯入內容, 字串.匯入確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result2 == DialogResult.Yes)
            {
                foreach (var Item_ in _Source)
                {
                    商品管理器.Instance.Add(Item_.ToData());
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            bool IsCheck_ =
                this.dataGridView1.Columns[e.ColumnIndex].Name == "大類編號DataGridViewTextBoxColumn" ||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "小類編號DataGridViewTextBoxColumn" ||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "公司編號" ||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "廠商編號DataGridViewTextBoxColumn" ||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "需求編號1DataGridViewTextBoxColumn" ||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "需求編號2DataGridViewTextBoxColumn" ||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "需求編號3DataGridViewTextBoxColumn" ||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "需求編號4DataGridViewTextBoxColumn" ||
                this.dataGridView1.Columns[e.ColumnIndex].Name == "需求編號5DataGridViewTextBoxColumn";

            if (IsCheck_)
            {
                if ((string)e.Value == 字串.錯誤)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}