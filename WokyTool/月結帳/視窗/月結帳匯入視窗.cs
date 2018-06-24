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
using WokyTool.DataMgr;
using WokyTool.動態匯入;

namespace WokyTool.月結帳
{
    public partial class 月結帳匯入視窗 : Form
    {
        protected 監測綁定更新<月結帳匯入檔案設定> _月結帳匯入檔案設定Listener;
        protected 監測綁定更新<商品資料> _商品資料Listener;

        protected 月結帳匯入檔案設定 _目前設定 = null;
        private bool _是否允許匯入 = true;
        protected List<月結帳資料> _資料;
        protected BindingSource _資料Binding = new BindingSource();

        public 月結帳匯入視窗()
        {
            InitializeComponent();

            _月結帳匯入檔案設定Listener = new 監測綁定更新<月結帳匯入檔案設定>(月結帳匯入檔案設定管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 設定資料更新);
            _月結帳匯入檔案設定Listener.Refresh(true);

            _商品資料Listener = new 監測綁定更新<商品資料>(商品管理器.Instance.Binding, 列舉.監測類型.被動通知_公式, 商品資料更新);
            _商品資料Listener.Refresh(true);

            this.資料呈現.DataSource = _資料Binding;

            this.儲存.Enabled = false;
        }

        private void 商品資料更新(IEnumerable<商品資料> Data_)
        {
            this.商品DataGridViewTextBoxColumn.DataSource = Data_.Where(Value => Value.廠商 == _目前設定.廠商 || Value.編號 == 常數.錯誤資料編碼).ToList(); ;
        }

        private void 設定資料更新(IEnumerable<月結帳匯入檔案設定> Data_)
        {
            清單.DataSource = Data_;
        }

        private void 清單_SelectedIndexChanged(object sender, EventArgs e)
        {
            _目前設定 = (月結帳匯入檔案設定)this.清單.SelectedItem;

            this.匯入.Enabled = _是否允許匯入;
        }

        private void 匯入_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            _是否允許匯入 = false;
            this.匯入.Enabled = false;

            // 更新商品列表
            _商品資料Listener.Refresh(true);

            動態匯入檔案結構 xx = new 動態匯入檔案結構(_目前設定);
            xx.ReadExcel(openFileDialog1.FileName);

            月結帳資料產生器 產生器_ = new 月結帳資料產生器(_目前設定);
            _資料 = 產生器_.Create(xx);
            if (_資料 == null)
                return;

            _資料Binding.DataSource = _資料;

            this.儲存.Enabled = true;
        }

        private void 儲存_Click(object sender, EventArgs e)
        {
            if (檢查資料是否合法() == false)
                return;

            this.儲存.Enabled = false;

            foreach (月結帳資料 月結帳資料_ in _資料)
            {
                月結帳資料管理器.Instance.Add(月結帳資料_);
            }
        }

        private bool 檢查資料是否合法()
        {
            try
            {
                foreach (月結帳資料 月結帳資料_ in _資料)
                {
                    月結帳資料_.檢查合法();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
