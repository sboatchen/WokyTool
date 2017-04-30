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
        protected 監測綁定更新<進貨資料> _Listener;

        protected List<進貨資料> _NewList = new List<進貨資料>();

        public 進貨總覽視窗()
        {
            InitializeComponent();

            this.類型.DataSource = Enum.GetValues(typeof(列舉.進貨類型));
            this.廠商編號DataGridViewTextBoxColumn.DataSource = 廠商管理器.Instance.Binding;
            this.物品編號DataGridViewTextBoxColumn.DataSource = 物品管理器.Instance.Binding;
            this.幣值編號DataGridViewTextBoxColumn.DataSource = 幣值管理器.Instance.Binding;

            _Listener = new 監測綁定更新<進貨資料>(進貨管理器.Instance.Binding, 進貨資料更新);
            _Listener.Update();

            // 註冊事件
            this.Activated += new System.EventHandler(this.onEventActivated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onEventCellValueChanged);
        }

        public void 進貨資料更新(List<進貨資料> Data_)
        {
            this.dataGridView1.DataSource = Data_.Union(_NewList).ToList();
            this.dataGridView1.Refresh();
        }

        // 註冊事件:資料異動
        private void onEventCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 資料有異動，記錄須進行更新
            進貨管理器.Instance.IsDirty = true;
        }

        // 註冊事件:取得Focus
        private void onEventActivated(object sender, EventArgs e)
        {
            _Listener.Update(true);
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_NewList
            進貨資料_暫時 Item_ = 進貨資料_暫時.New();
            _NewList.Add(Item_);

            _Listener.Update(true);
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

                _Listener.Update(true);
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
            var _Export = _Listener.Query
                                .Select(Value => new 進貨匯出結構(Value))
                                .ToList();

            string Title_ = String.Format("進貨匯出_{0}", 共用.NowYMDDec);
            函式.ExportExcel<進貨匯出結構>(Title_, _Export);

        }
    }
}
