using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataExport;
using WokyTool.DataMgr;
using WokyTool.FormOther;

namespace WokyTool.FormOverview
{
    public partial class 銷售總覽視窗 : Form, 父視窗<銷售資料_編輯>
    {
        protected 子視窗<銷售資料_編輯> _子視窗 = null;
        protected 監測綁定更新<銷售資料_編輯> _Listener;

        protected List<銷售資料_編輯> _Source;
        
        protected 銷售篩選視窗 _時段選擇視窗 = null;
        protected DateTime _StartTime = DateTime.Now;
        protected DateTime _EndTime = DateTime.Now;

        public 銷售總覽視窗()
        {
            InitializeComponent();

            _Listener = new 監測綁定更新<銷售資料_編輯>(銷售管理器.Instance.Binding, 列舉.監測類型.被動通知_公式, 銷售資料更新);
            _Listener.Refresh(true);

            this.狀態DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.銷售狀態類型));

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        public void 銷售資料更新(IEnumerable<銷售資料_編輯> Data_)
        {
            List<銷售資料_編輯> xxx = Data_.ToList();
            if (_子視窗 != null && _子視窗.IsVisible() == true)
                _Source = _子視窗.Filt(Data_).ToList();
            else
                _Source = Data_.ToList();

            this.dataGridView1.DataSource = _Source;

            this.dataGridView1.Refresh();
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            銷售管理器.Instance.SetDirty();
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尚未實作", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尚未實作", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_子視窗 == null)
            {
                _子視窗 = new 銷售篩選視窗(this);
            }

            _子視窗.Show();
            _子視窗.BringToFront();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = _Source
                                .GroupBy(
                                    Value => Value.廠商,
                                    Value => new 銷售匯出結構(Value));

            string Title_ = String.Format("銷售匯出_{0}", 共用.NowYMDDec);
            函式.ExportExcel<銷售匯出結構>(Title_, ItemGroup_);
        }

        private void 結算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = _Source
                                .GroupBy(
                                    Value => Value.廠商,
                                    Value => new 銷售匯出結構(Value));

           /* 通用匯出結構 總結_ = new 通用匯出結構("總結");

            int 總庫存成本_ = _物品資料Listener.Query.Select(Value => Value.庫存總成本).Sum();
            總結_.Add("總庫存成本", 總庫存成本_.ToString());

            string Title_ = String.Format("物品庫存_{0}", 共用.NowYMDDec);
            函式.ExportExcel<物品庫存匯出結構>(Title_, ItemGroup_, 總結_);*/

            string Title_ = String.Format("銷售結算_{0}", 共用.NowYMDDec);
            函式.ExportExcel<銷售匯出結構>(Title_, ItemGroup_);
        }

        public void onChildClosing(子視窗<銷售資料_編輯> Child_)
        {
        }

        public void onClickFilter(子視窗<銷售資料_編輯> Child_)
        {
            _Listener.Refresh(true);
        }

        private void 銷售總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_子視窗 != null)
            {
                _子視窗.Close();
                _子視窗 = null;
            }
        }
    }
}
