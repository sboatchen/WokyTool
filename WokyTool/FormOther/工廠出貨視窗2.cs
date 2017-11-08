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

namespace WokyTool.FormOther
{
    public partial class 工廠出貨視窗2 : Form
    {
        protected List<物品訂單資料> _Source;

        protected 監測綁定更新<物品資料> _物品資料Listener;

        protected 物品訂單資料 _NowOrder;

        public 工廠出貨視窗2()
        {
            InitializeComponent();

            _物品資料Listener = new 監測綁定更新<物品資料>(物品管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 物品資料更新);
            _物品資料Listener.Refresh(true);

            _Source = new List<物品訂單資料>();
            BindingSource Binding_ = new BindingSource();
            Binding_.DataSource = _Source;
            this.dataGridView1.DataSource = Binding_;

            /*
            MyData myDataObject = new MyData(DateTime.Now);
            Binding myBinding = new Binding("MyDataProperty");
            myBinding.Source = myDataObject;
            myText.SetBinding(TextBlock.TextProperty, myBinding);*/
        }

        private void 物品資料更新(IEnumerable<物品資料> Data_)
        {
            this.物品.DataSource = Data_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                Item_.廠商 = 廠商資料.NULL;

                if (Item_.IsLegal() == false)
                {
                    MessageBox.Show("物品資料不合法:" + Item_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Console.WriteLine(Item_.ToString());
            }

            // 匯出銷售單
            工廠出貨匯出結構 ExportFormat_ = new 工廠出貨匯出結構(_Source);
            string Title_ = String.Format("工廠出貨_{0}_{1}", Name_, 共用.NowYMDDec);
            函式.ExportExcel<工廠出貨匯出結構>(Title_, ExportFormat_);

            // 轉至出貨系統
            合併訂單資料 CombineItem_ = new 合併訂單資料();
            foreach (物品訂單資料 Item_ in _Source)
            {
                if (CombineItem_.Add(Item_) == false)
                    return;
            }
            CombineItem_.PrepareDiliver();
            配送管理器.Instance.Add(CombineItem_);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            Console.WriteLine("1");
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _NowOrder = (物品訂單資料)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            if (_NowOrder == null)
                return;

            this.物品.SelectedValue = _NowOrder.物品編號;
            this.數量.Value = _NowOrder.數量;
            this.單價.Value = _NowOrder.單價;
            this.備註.Text = _NowOrder.備註;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void 數量_ValueChanged(object sender, EventArgs e)
        {
            if (_NowOrder == null)
                return;
            _NowOrder.數量 = (int)this.數量.Value;
        }

        private void 單價_ValueChanged(object sender, EventArgs e)
        {
            if (_NowOrder == null)
                return;
            _NowOrder.單價 = (int)this.單價.Value;
        }

        private void 備註_TextChanged(object sender, EventArgs e)
        {
            if (_NowOrder == null)
                return;
            _NowOrder.備註 = this.備註.Text;
        }

        private void 物品_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_NowOrder == null)
                return;
            _NowOrder.物品編號 = (int)this.物品.SelectedValue;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
            Console.WriteLine("/");
            Console.WriteLine(e.ColumnIndex);
            /*if (e.ColumnIndex == 0)
            {
                Console.WriteLine(e.ColumnIndex)
            }

            _NowOrder = (物品訂單資料)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            if (_NowOrder == null)
                return;

            this.物品.SelectedValue = _NowOrder.物品編號;
            this.數量.Value = _NowOrder.數量;
            this.單價.Value = _NowOrder.單價;
            this.備註.Text = _NowOrder.備註;*/
        }
    }
}
