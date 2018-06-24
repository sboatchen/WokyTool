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

namespace WokyTool.月結帳
{
    public partial class 月結帳匯入設定視窗 : Form
    {
        protected 監測綁定更新<月結帳匯入設定資料> _月結帳匯入設定資料Listener;
        protected 監測綁定更新<公司資料> _公司資料Listener;
        protected 監測綁定更新<廠商資料> _廠商資料Listener;

        protected 月結帳匯入設定資料 _目前資料;
        protected 月結帳匯入設定資料 _修改中資料;
        protected BindingSource _設定Binding = new BindingSource();

        private bool _isAfterSave = false;

        public 月結帳匯入設定視窗()
        {
            InitializeComponent();

            //_月結帳匯入設定資料Listener = new 監測綁定更新<月結帳匯入設定資料>(月結帳匯入設定資料管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 設定資料更新);
            _月結帳匯入設定資料Listener.Refresh(true);

            _公司資料Listener = new 監測綁定更新<公司資料>(公司管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 公司資料更新);
            _公司資料Listener.Refresh(true);

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);

            格式.DataSource = Enum.GetValues(typeof(列舉.檔案格式類型));
            欄位格式.DataSource = Enum.GetValues(typeof(列舉.資料格式類型));
            名稱範例.DataSource = Enum.GetValues(typeof(月結帳匯入設定資料.動態匯入需求欄位_月結帳));
            商品識別.DataSource = Enum.GetValues(typeof(列舉.商品識別類型));
            this.設定.DataSource = _設定Binding;

            updateSetting();
        }

        private void 設定資料更新(IEnumerable<月結帳匯入設定資料> Data_)
        {
            清單.DataSource = Data_;
        }

        public void 公司資料更新(IEnumerable<公司資料> Data_)
        {
            公司.DataSource = Data_;
        }

        public void 廠商資料更新(IEnumerable<廠商資料> Data_)
        {
            廠商.DataSource = Data_;
        }

        private void 儲存_Click(object sender, EventArgs e)
        {
            _修改中資料.名稱 = this.名稱.Text;
            _修改中資料.格式 = (列舉.檔案格式類型)this.格式.SelectedItem;
            _修改中資料.開始位置 = (int)this.開始位置.Value;
            _修改中資料.結束位置 = (int)this.結束位置.Value;
            _修改中資料.標頭位置 = (int)this.標頭位置.Value;
            _修改中資料.公司 = (公司資料)this.公司.SelectedItem;
            _修改中資料.廠商 = (廠商資料)this.廠商.SelectedItem;
            _修改中資料.商品識別 = (列舉.商品識別類型)this.商品識別.SelectedItem;

            try
            {
                _修改中資料.檢查合法();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (_目前資料 != null)
            //    月結帳匯入設定資料管理器.Instance.Delete(_目前資料);

           // 月結帳匯入設定資料管理器.Instance.Add(_修改中資料);

            _目前資料 = _修改中資料;
            _修改中資料 = (月結帳匯入設定資料)_目前資料.拷貝();

            _isAfterSave = true;
            _月結帳匯入設定資料Listener.Refresh(true);

            MessageBox.Show(字串.設定成功, 字串.確認, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            _目前資料 = null;
           // _修改中資料 = 月結帳匯入設定資料.New();

            updateSetting();
        }

        private void 刪除_Click(object sender, EventArgs e)
        {
            if (_目前資料 != null)
            {
                //月結帳匯入設定資料管理器.Instance.Delete(_目前資料);
                _月結帳匯入設定資料Listener.Refresh(true);
            }

            _目前資料 = null;
            _修改中資料 = null;

            updateSetting();
        }

        private void 清單_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isAfterSave) 
            {
                _isAfterSave = false;
                this.清單.SelectedItem = _目前資料;
                return;
            }

            _目前資料 = (月結帳匯入設定資料)this.清單.SelectedItem;
            _修改中資料 = (月結帳匯入設定資料)_目前資料.拷貝();

            updateSetting();
        }

        private void updateSetting()
        {
            if (_修改中資料 != null)
            {
                this.名稱.Enabled = true;
                this.格式.Enabled = true;
                this.開始位置.Enabled = true;
                this.結束位置.Enabled = true;
                this.標頭位置.Enabled = true;
                this.公司.Enabled = true;
                this.廠商.Enabled = true;
                this.設定.Enabled = true;

                this.名稱.Text = _修改中資料.名稱;
                this.格式.SelectedItem = _修改中資料.格式;
                this.開始位置.Value = _修改中資料.開始位置;
                this.結束位置.Value = _修改中資料.結束位置;
                this.標頭位置.Value = _修改中資料.標頭位置;
                this.公司.SelectedItem = _修改中資料.公司;
                this.廠商.SelectedItem = _修改中資料.廠商;
                this.商品識別.SelectedItem = _修改中資料.商品識別;
                this._設定Binding.DataSource = _修改中資料.資料List;
            }
            else 
            {
                this.名稱.Enabled = false;
                this.格式.Enabled = false;
                this.開始位置.Enabled = false;
                this.結束位置.Enabled = false;
                this.標頭位置.Enabled = false;
                this.公司.Enabled = false;
                this.廠商.Enabled = false;
                this.設定.Enabled = false;

                this.名稱.Text = 字串.空;
                this.格式.SelectedItem = null;
                this.開始位置.Value = 0;
                this.結束位置.Value = 0;
                this.標頭位置.Value = 0;
                this.公司.SelectedItem = null;
                this.廠商.SelectedItem = null;
                this.商品識別.SelectedItem = null;
                this._設定Binding.DataSource = null;
            }
        }
    }
}
