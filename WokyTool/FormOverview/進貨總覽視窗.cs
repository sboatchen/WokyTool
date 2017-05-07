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

namespace WokyTool.DataForm
{
    public partial class 進貨總覽視窗 : Form
    {
        protected 監測綁定更新<廠商資料> _廠商資料Listener;
        protected 監測綁定更新<物品資料> _物品資料Listener;
        protected 監測綁定更新<幣值資料> _幣值資料Listener;
        protected 監測綁定更新<進貨資料> _進貨資料Listener;

        protected List<進貨資料> _NewList = new List<進貨資料>();

        public 進貨總覽視窗()
        {
            InitializeComponent();

            this.類型.DataSource = Enum.GetValues(typeof(列舉.進貨類型));

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);

            _物品資料Listener = new 監測綁定更新<物品資料>(物品管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品資料更新);
            _物品資料Listener.Refresh(true);

            _幣值資料Listener = new 監測綁定更新<幣值資料>(幣值管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 幣值資料更新);
            _幣值資料Listener.Refresh(true);

            _進貨資料Listener = new 監測綁定更新<進貨資料>(進貨管理器.Instance.Binding, 列舉.監測類型.被動通知_公式, 進貨資料更新);
            _進貨資料Listener.Refresh(true);

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        public void 廠商資料更新(IEnumerable<廠商資料> Data_)
        {
            this.廠商編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 物品資料更新(IEnumerable<物品資料> Data_)
        {
            this.物品編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 幣值資料更新(IEnumerable<幣值資料> Data_)
        {
            this.幣值編號DataGridViewTextBoxColumn.DataSource = Data_;
        }

        public void 進貨資料更新(IEnumerable<進貨資料> Data_)
        {
            this.dataGridView1.DataSource = Data_.Union(_NewList).ToList();
            this.dataGridView1.Refresh();
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            進貨管理器.Instance.SetDirty();
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _廠商資料Listener.Refresh();
            _物品資料Listener.Refresh();
            _幣值資料Listener.Refresh();
            _進貨資料Listener.Refresh();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_NewList
            進貨資料_暫時 Item_ = 進貨資料_暫時.New();
            _NewList.Add(Item_);

            _進貨資料Listener.Refresh(true);
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count != 0)
            {
                進貨資料 Target_ = (進貨資料)this.dataGridView1.SelectedRows[0].DataBoundItem;
                if (_NewList.Contains(Target_))
                    _NewList.Remove(Target_);
                else
                    進貨管理器.Instance.Delete(Target_);

                _進貨資料Listener.Refresh(true);
            }
        }

        private void 進貨總覽視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_NewList.Count() == 0)
                return;

            foreach (var Item in _NewList)
            {
                進貨資料 New_ = Item.Save();
                if (New_.IsSave() == false)
                    continue;

                進貨管理器.Instance.Add(New_);
            }

            _NewList.Clear();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var _Export = _進貨資料Listener.Query
                                .Where(Value => Value.廠商.編號 > 0)  
                                .Select(Value => new 進貨匯出結構(Value))
                                .ToList();

            string Title_ = String.Format("進貨匯出_{0}", 共用.NowYMDDec);
            函式.ExportExcel<進貨匯出結構>(Title_, _Export);

        }
    }
}
