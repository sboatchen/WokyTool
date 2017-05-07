using LINQtoCSV;
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
using WokyTool.DataMgr;

namespace WokyTool
{
    public partial class 支出總覽視窗 : Form
    {
        //@@ binding
        private IEnumerable<支出資料> _A = 雜支管理器.Instance.Map
                                                            .Where(Pair => Pair.Value.編號 > 0)
                                                            .Select(Pair => Pair.Value.ToOutlay());
        private IEnumerable<支出資料> _B = 進貨管理器.Instance.Map
                                                            .Where(Pair => Pair.Value.編號 > 0)
                                                            .Select(Pair => Pair.Value.ToOutlay());

        private List<支出資料> _Source;
        private BindingSource _Binding = new BindingSource();

        private DateTime _StartTime;
        private DateTime _EndTime;
 
        public 支出總覽視窗()
        {
            InitializeComponent();

            // 初始化目前顯示資料
            InitData();
        }

        // 初始化目前顯示資料
        private void InitData()
        {
            _Source = _A.Union(_B).ToList();

            _Binding.DataSource = _Source;
            this.dataGridView1.DataSource = _Binding;

            if (_Source.Count() > 1)
            {
                _StartTime = _Source.OrderBy(Value => Value.建立時間).First().建立時間;
                if (_StartTime < dateTimePicker1.MinDate)
                    _StartTime = dateTimePicker1.MinDate;

                _EndTime = _Source.OrderByDescending(Value => Value.建立時間).First().建立時間;
                if (_EndTime > dateTimePicker1.MaxDate)
                    _EndTime = dateTimePicker1.MaxDate;

                dateTimePicker1.Value = _StartTime;
                dateTimePicker2.Value = _EndTime;
            }

            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
        }

        // 更新目前顯示資料
        private void UpdateData()
        {
            _Source = _A.Union(_B)
                        .Where(Value => ((Value.建立時間 >= _StartTime) && (Value.建立時間 <= _EndTime)))
                        .ToList();

            _Binding.DataSource = _Source;
            this.dataGridView1.DataSource = _Binding;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _StartTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0,0,0,0);
            
            // 更新目前顯示資料
            UpdateData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            _EndTime = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 23, 59, 59, 0);

            // 更新目前顯示資料
            UpdateData();
        }

        private void 略過ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((支出資料)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }
        }

        private void 結算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 結算確認警告
            var Result_ = MessageBox.Show(字串.結算支出內容, 字串.結算確認, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result_ == DialogResult.No)
                return;

            // 開啟存檔位置
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = String.Format("支出_{0}{1:00}{2:00}_{3}{4:00}{5:00}", _StartTime.Year, _StartTime.Month, _StartTime.Day, _EndTime.Year, _EndTime.Month, _EndTime.Day);
            dlg.DefaultExt = ".csv";                // Default file extension
            dlg.Filter = "csv files (.csv)|*.csv";  // Filter files by extension
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;

            // 寫入資料
            StreamWriter sw = new StreamWriter(dlg.FileName, false, Encoding.Default);
            CsvContext cc = new CsvContext();
            cc.Write(_Source, sw, 共用.OutputDefine);
            sw.Close();

            // 寫入歷史
            StreamWriter sw2 = new StreamWriter(常數.支出歷史檔案路徑, true, Encoding.Default);
            CsvContext cc2 = new CsvContext();
            cc2.Write(_Source, sw2, 共用.OutputAppendDefine);
            sw2.Close();

            // 從來源清掉
            List<int> IDList_ = _Source.Select(Value => Value.編號).ToList();
            雜支管理器.Instance.Bill(IDList_);
            進貨管理器.Instance.Bill(IDList_);
        }
    }
}
