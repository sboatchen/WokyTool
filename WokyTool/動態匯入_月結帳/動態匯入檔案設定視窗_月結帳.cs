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

namespace WokyTool.動態匯入_月結帳
{
    public partial class 動態匯入檔案設定視窗_月結帳 : Form
    {
        protected 監測綁定更新<動態匯入檔案設定_月結帳> _動態匯入檔案設定_月結帳Listener;
        protected 監測綁定更新<公司資料> _公司資料Listener;
        protected 監測綁定更新<廠商資料> _廠商資料Listener;

        protected 動態匯入檔案設定_月結帳 _目前資料;
        protected 動態匯入檔案設定_月結帳 _修改中資料;
        protected BindingSource _設定Binding = new BindingSource();

        public 動態匯入檔案設定視窗_月結帳()
        {
            InitializeComponent();

            _動態匯入檔案設定_月結帳Listener = new 監測綁定更新<動態匯入檔案設定_月結帳>(動態匯入檔案設定管理器_月結帳.Instance.Binding, 列舉.監測類型.被動通知_值, 設定資料更新);
            _動態匯入檔案設定_月結帳Listener.Refresh(true);

            _公司資料Listener = new 監測綁定更新<公司資料>(公司管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 公司資料更新);
            _公司資料Listener.Refresh(true);

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);

            格式.DataSource = Enum.GetValues(typeof(列舉.檔案格式類型));
            欄位格式.DataSource = Enum.GetValues(typeof(列舉.資料格式類型));
            名稱範例.DataSource = 動態匯入檔案設定_月結帳.需求欄位列表;
            this.設定.DataSource = _設定Binding;
        }

        private void 設定資料更新(IEnumerable<動態匯入檔案設定_月結帳> Data_)
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
            string Error_ = _修改中資料.檢查合法();
            if(String.IsNullOrEmpty(Error_) == false)
            {
                MessageBox.Show(Error_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_目前資料 != null)
                動態匯入檔案設定管理器_月結帳.Instance.Delete(_目前資料);

            動態匯入檔案設定管理器_月結帳.Instance.Add(_修改中資料);

            _目前資料 = _修改中資料;
            _修改中資料 = (動態匯入檔案設定_月結帳)_目前資料.拷貝();

            _動態匯入檔案設定_月結帳Listener.Refresh(true);

            updateSetting();
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            _目前資料 = null;
            _修改中資料 = 動態匯入檔案設定_月結帳.New();

            updateSetting();
        }

        private void 刪除_Click(object sender, EventArgs e)
        {
            if (_目前資料 != null)
            {
                動態匯入檔案設定管理器_月結帳.Instance.Delete(_目前資料);
                _動態匯入檔案設定_月結帳Listener.Refresh(true);
            }

            _目前資料 = null;
            _修改中資料 = null;

            updateSetting();
        }

        private void 清單_SelectedIndexChanged(object sender, EventArgs e)
        {
            _目前資料 = (動態匯入檔案設定_月結帳)this.清單.SelectedItem;
            _修改中資料 = (動態匯入檔案設定_月結帳)_目前資料.拷貝();

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
                this._設定Binding.DataSource = null;
            }
        }
    }
}
