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
using WokyTool.通用;

namespace WokyTool.FormOther
{
    public partial class 工廠出貨視窗 : Form, 可選擇父視窗<物品資料>
    {
        protected 可選擇子視窗<物品資料> _子視窗 = null;
        protected List<物品訂單資料> _Source;

        protected DataGridViewCell _NowCell;

        protected 監測綁定更新<廠商資料> _廠商資料Listener;

        public 工廠出貨視窗()
        {
            InitializeComponent();

            _Source = new List<物品訂單資料>();
            BindingSource Binding_ = new BindingSource();
            Binding_.DataSource = _Source;
            this.dataGridView1.DataSource = Binding_;

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);
        }

        public void 廠商資料更新(IEnumerable<廠商資料> Data_)
        {
            this.廠商comboBox.DataSource = Data_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            廠商資料 廠商_ = (廠商資料)this.廠商comboBox.SelectedItem;
            if(廠商_ == null)
                廠商_ = 廠商資料.NULL;

            String Name_ = this.姓名.Text;
            if (Name_.Length == 0)
            {
                MessageBox.Show("未填寫姓名", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String Address_ = this.地址.Text;
            if (Address_.Length == 0)
            {
                MessageBox.Show("未填寫地址", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String HomePhone_ = this.電話.Text;
            String CellPhone_ = this.手機.Text;
            if (HomePhone_.Length == 0 && CellPhone_.Length == 0)
            {
                MessageBox.Show("電話/手機請至少填寫一個", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (HomePhone_.Length == 0)
            {
                HomePhone_ = CellPhone_;
            }

            foreach(物品訂單資料 Item_ in _Source)
            {
                Item_.姓名 = Name_;
                Item_.地址 = Address_;
                Item_.電話 = HomePhone_;
                Item_.手機 = CellPhone_;
                Item_.廠商 = 廠商_;

                if (Item_.IsLegal() == false)
                {
                    MessageBox.Show("物品資料不合法:" + Item_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Console.WriteLine(Item_.ToString());
            }

            // 組合訂單
            非平台訂單資料 CombineItem_ = new 非平台訂單資料();
            foreach (物品訂單資料 Item_ in _Source)
            {
                if (Item_.getType() != 列舉.銷售狀態類型.出貨)    //@@ 目前只有先不處理 後續要思考怎麼處理
                    continue;

                if (CombineItem_.Add(Item_) == false)
                    return;
            }
            CombineItem_.PrepareDiliver();

            非平台訂單資料管理器.Instance.Add(CombineItem_);

            bool 是否列印單價_ = this.列印單價.Checked;

            // 匯出銷售單
            工廠出貨匯出結構 ExportFormat_ = new 工廠出貨匯出結構(_Source, 是否列印單價_);
            string Title_ = String.Format("工廠出貨_{0}_{1}", Name_, 時間.目前日期);
            函式.ExportExcel<工廠出貨匯出結構>(Title_, ExportFormat_);

            // 轉至出貨系統
            配送管理器.Instance.Add(CombineItem_);

            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1)
                return;

            _NowCell = this.dataGridView1.Rows[e.RowIndex].Cells[0];
            int ID_ = (int)_NowCell.Value;
            物品資料 Item_ = 物品管理器.Instance.Get(ID_);

            if (_子視窗 == null)
            {
                _子視窗 = new WokyTool.FormOther.物品選擇視窗(this);
            }

            _子視窗.Show();
            _子視窗.BringToFront();
            _子視窗.SetDefaultSelect(Item_);
        }

        public void onChildClosing(子視窗<物品資料> Child_)
        {
            // do nothing
        }

        public void onClickFilter(子視窗<物品資料> Child_)
        {
            // remove
        }

        private void 工廠出貨視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_子視窗 != null)
            {
                _子視窗.Close();
                _子視窗 = null;
            }
        }

        public void onSelect(物品資料 Item_) 
        {
            if (_NowCell != null)
                _NowCell.Value = Item_.編號;
        }

        private void 廠商comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            廠商資料 Data_ = (廠商資料)this.廠商comboBox.SelectedItem;
            if (Data_ == null || Data_.編號 <= 常數.空白資料編碼)
                return;

            this.姓名.Text = Data_.聯絡人;
            this.地址.Text = Data_.出貨地址;
            this.電話.Text = Data_.電話;
            this.手機.Text = Data_.手機;
        }
    }
}
