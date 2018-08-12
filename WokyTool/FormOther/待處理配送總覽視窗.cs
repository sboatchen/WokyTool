using LINQtoCSV;
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
using WokyTool.DataExport;
using WokyTool.DataImport;
using WokyTool.DataMgr;
using WokyTool.通用;
using Excel = Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace WokyTool.OtherForm
{
    public partial class 待處理配送總覽視窗 : Form
    {
        private List<可配送> _Source = new List<可配送>();
        private BindingSource _Binding = new BindingSource();

        // 匯出暫存
        private List<全速配匯出結構> _Export1 = new List<全速配匯出結構>();
        private List<宅配通匯出結構> _Export2 = new List<宅配通匯出結構>();

        public 待處理配送總覽視窗()
        {
            InitializeComponent();

            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));

            // 初始化目前顯示資料
            InitData();

            // 預設關掉匯入
            this.全速配ToolStripMenuItem.Enabled = false;
            this.宅配通ToolStripMenuItem.Enabled = false;
        }

        // 初始化目前顯示資料
        private void InitData()
        {
            _Source = 配送管理器.Instance.List
                            .OrderBy(x => x.配送公司)
                            .ThenBy(x => x.配送商品)
                            .ToList();

            _Binding.DataSource = _Source;
            this.dataGridView1.DataSource = _Binding;
        }

        private void 略過ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((可配送)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }
        }

        private void 全速配ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int x = 1;
            _Export1 = _Source.Where(Value => Value.配送公司 == 列舉.配送公司.全速配)
                               .Select(Value => new 全速配匯出結構(x++, Value))
                               .ToList();

            string Title_ = String.Format("全速配匯出_{0}", 時間.目前日期);
            函式.ExportCSV<全速配匯出結構>(Title_, _Export1);

            // 如果有資料匯出，則鎖定不再允許匯出，並開放匯入
            if (_Export1.Count > 0)
            {
                this.全速配ToolStripMenuItem1.Enabled = false;
                this.全速配ToolStripMenuItem.Enabled = true;
            }

        }

        private void 宅配通ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _Export2 = _Source.Where(Value => Value.配送公司 == 列舉.配送公司.宅配通)
                                .Select(Value => new 宅配通匯出結構(Value))
                                .ToList();

            string Title_ = String.Format("宅配通匯出_{0}", 時間.目前日期);
            函式.ExportExcel<宅配通匯出結構>(Title_, _Export2);

            // 如果有資料匯出，則鎖定不再允許匯出，並開放匯入
            if (_Export2.Count > 0)
            {
                this.宅配通ToolStripMenuItem1.Enabled = false;
                this.宅配通ToolStripMenuItem.Enabled = true;
            }
        }

        private void 全速配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel files|*.*";

            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            try
            {
                var Excel_ = new ExcelQueryFactory(dlg.FileName);
                var Data_ = Excel_.Worksheet<全速配匯入結構>().ToList();

                // 檢查資料數是否一致
                if (Data_.Count != _Export1.Count)
                {
                    MessageBox.Show("資料筆數不符合", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool IsRight_ = true;
                for (int i = 0; i < _Export1.Count; i++)
                {
                    if (_Export1[i].SetDeliveryNO(Data_[i]) == false)
                    {
                        IsRight_ = false;
                        break;
                    }
                }
                if (IsRight_ == false)
                {
                    foreach (var Item_ in _Export1)
                    {
                        Item_.CleanDeliveryNO();
                    }

                    MessageBox.Show("資料內容不符合", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 清除暫存，並關閉匯入
                _Export1.Clear();
                this.全速配ToolStripMenuItem.Enabled = false;
                配送管理器.Instance.RemoveDeliverd();

                // 更新UI
                this.dataGridView1.Refresh();
            }
            catch (Exception Error_)
            {
                MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 宅配通ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel files|*.*";

            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            try
            {
                var Excel_ = new ExcelQueryFactory(dlg.FileName);
                var Data_ = Excel_.Worksheet<宅配通匯入結構>().ToList();

                // 檢查資料數是否一致
                if (Data_.Count != _Export2.Count)
                {
                    MessageBox.Show("資料筆數不符合", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool IsRight_ = true;
                for (int i = 0; i < _Export2.Count; i++)
                {
                    if (_Export2[i].SetDeliveryNO(Data_[i]) == false)
                    {
                        IsRight_ = false;
                        break;
                    }
                }
                if (IsRight_ == false)
                {
                    foreach (var Item_ in _Export2)
                    {
                        Item_.CleanDeliveryNO();
                    }

                    MessageBox.Show("資料內容不符合", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 清除暫存，並關閉匯入
                _Export2.Clear();
                this.宅配通ToolStripMenuItem.Enabled = false;
                配送管理器.Instance.RemoveDeliverd();

                // 更新UI
                this.dataGridView1.Refresh();

            }
            catch (Exception Error_)
            {
                MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 測試用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach(var Item_ in _Source)
            {
                Item_.完成配送(String.Format("宅配回單測試{0}", i++));
            }
        }

        private void 統計ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<String, 撿貨統計結構> sum = new Dictionary<String, 撿貨統計結構>();
            撿貨統計結構 Temp_ = null;
            foreach(可配送 Data_ in _Source)
            {
                foreach (var ItemPair_ in Data_.配送物品清單)
                {
                    if (sum.TryGetValue(ItemPair_.Key, out Temp_))
                    {
                        Temp_.數量 += ItemPair_.Value;
                    }
                    else
                    {
                        Temp_ = new 撿貨統計結構(ItemPair_.Key, ItemPair_.Value);
                        sum.Add(ItemPair_.Key, Temp_);
                    }
                }
            }

            List<撿貨統計結構> Result_ = sum.Values.OrderBy(Value => Value.物品名稱).ToList();

            string Title_ = String.Format("撿貨統計匯出_{0}", 時間.目前日期);
            函式.ExportExcel<撿貨統計結構>(Title_, Result_);
        }
    }
}
