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

namespace WokyTool.月結帳
{
    public partial class 月結帳總覽視窗 : Form
    {
        protected List<月結帳資料> _Source;
        protected 監測綁定更新<月結帳資料> _Listener;

        public 月結帳總覽視窗()
        {
            InitializeComponent();

            _Listener = new 監測綁定更新<月結帳資料>(月結帳資料管理器.Instance.Binding, 列舉.監測類型.被動通知_公式, 月結帳資料更新);
            _Listener.Refresh(true);
        }

        private void 月結帳資料更新(IEnumerable<月結帳資料> Data_)
        {
            _Source = Data_.ToList();

            this.dataGridView1.DataSource = _Source;
            this.dataGridView1.Refresh();
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ItemGroup_ = _Source
                                .GroupBy(
                                    Value => Value.廠商名稱,
                                    Value => new 月結帳資料匯出結構(Value));

            string Title_ = String.Format("月結帳匯出_{0}", 共用.NowYMDDec);
            函式.ExportExcel<月結帳資料匯出結構>(Title_, ItemGroup_);
        }
    }
}
