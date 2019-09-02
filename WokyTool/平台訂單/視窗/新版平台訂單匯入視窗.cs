using Newtonsoft.Json;
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
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.客製;
using WokyTool.商品;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public partial class 新版平台訂單匯入視窗 : 匯入視窗
    {
        protected BindingSource 平台訂單匯入設定資料BindingSource = new BindingSource();
        protected 平台訂單匯入管理器 _平台訂單匯入管理器 = new 平台訂單匯入管理器();

        protected 公司資料 _公司 = null;
        protected 客戶資料 _客戶 = null;

        private 可清單列舉資料管理介面 _商品清單管理器 = 商品資料管理器.獨體.清單管理器;
        private 商品資料篩選 _商品清單篩選;
        private int _商品資料版本 = -1;

        //protected 平台訂單匯入詳細視窗 _平台訂單匯入詳細視窗 = null;

        public 新版平台訂單匯入視窗()
        {
            InitializeComponent();

            this.初始化(this.平台訂單匯入資料BindingSource, _平台訂單匯入管理器);

            this.處理狀態.DataSource = Enum.GetValues(typeof(列舉.訂單處理狀態));
            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));

            this.檢查ToolStripMenuItem.Enabled = false;
            this.匯出ToolStripMenuItem.Enabled = false;
            this.dataGridView1.Enabled = false;

            this.dataGridView1.DataError += new DataGridViewDataErrorEventHandler(this._DataGridView錯誤);

            _商品清單篩選 = (商品資料篩選)_商品清單管理器.視窗篩選器;
        }

        private void _DataGridView錯誤(object sender, DataGridViewDataErrorEventArgs e)
        {
            訊息管理器.獨體.訊息("資料錯誤:" + e.RowIndex + "," + e.ColumnIndex);
            e.ThrowException = false;

            if (e.ColumnIndex == 3)
                _平台訂單匯入管理器.可編輯BList[e.RowIndex].商品 = 商品資料.錯誤;
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            更新資料合法性();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 平台訂單新增錯誤匯出轉換(_平台訂單匯入管理器.可編輯BList.Where(Value => Value.錯誤訊息 != null));

            string 標題_ = String.Format("平台訂單新增錯誤匯出_{0}_{1}_{2}", this._公司.名稱, this._客戶.名稱, 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //訊息管理器.獨體.通知("功能尚未實作");
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_商品資料版本 != _商品清單管理器.資料版本 && _客戶 != null && _公司 != null)    // 有資料後才處理
            {
                _商品資料版本 = _商品清單管理器.資料版本;
                this.商品資料BindingSource.DataSource = _商品清單管理器.資料列舉;
            }
        }

        protected override void 視窗關閉()
        {
            //if (_平台訂單匯入詳細視窗 != null)
            //    _平台訂單匯入詳細視窗.關閉();
        }

        private void 匯入完成(平台訂單自定義介面 轉換_, IEnumerable<平台訂單匯入資料> 資料列舉_, bool momo第三方_ = false)
        {
            List<平台訂單匯入資料> 資料列_ = 資料列舉_.ToList();

            if (資料列_.Count == 0)
            {
                訊息管理器.獨體.通知("沒有資料");
                return;
            }

            // 取得公司
            var Queue_ = 資料列_.Select(Value => Value.商品.公司).Where(Value => Value.編號是否有值()).Distinct();
            if (Queue_.Count() == 0)
            {
                訊息管理器.獨體.警告("資料中沒有公司資訊");
                return;
            }
            if (Queue_.Count() > 1)
            {
                訊息管理器.獨體.警告("資料中包含複數個公司");
                return;
            }

            _客戶 = 轉換_.客戶;
            _公司 = Queue_.First();
            _商品清單篩選.公司 = _公司;
            _商品清單篩選.客戶 = _客戶;

            轉換_.公司 = _公司;
            foreach (平台訂單匯入資料 資料_ in 資料列_)
            {
                資料_.公司 = _公司;
            }

            視窗激活();

            _平台訂單匯入管理器.新增(資料列_);

            if (momo第三方_)
                _平台訂單匯入管理器.平台訂單管理器 = Momo第三方平台訂單新增資料管理器.獨體;
            else
                _平台訂單匯入管理器.平台訂單管理器 = 平台訂單新增資料管理器.獨體;

            this.匯入ToolStripMenuItem.Enabled = false;
            this.檢查ToolStripMenuItem.Enabled = true;
            this.匯出ToolStripMenuItem.Enabled = true;
            this.dataGridView1.Enabled = true;

            訊息管理器.獨體.通知("匯入完成");
            //this.OnActivated(null);
        }

        private void 中華電信_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_中華電信 轉換_ = new 平台訂單匯入轉換_中華電信();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void 東森_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_東森 轉換_ = new 平台訂單匯入轉換_東森();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void friday_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_Friday 轉換_ = new 平台訂單匯入轉換_Friday();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void Momo第三方_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_Momo第三方 轉換_ = new 平台訂單匯入轉換_Momo第三方();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_, true);
        }

        private void uDNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_UDN 轉換_ = new 平台訂單匯入轉換_UDN();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void ibonMartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_ibonMart 轉換_ = new 平台訂單匯入轉換_ibonMart();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void 金石堂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_金石堂 轉換_ = new 平台訂單匯入轉換_金石堂();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void 百利市ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_百利市 轉換_ = new 平台訂單匯入轉換_百利市();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void vivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_viva 轉換_ = new 平台訂單匯入轉換_viva();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void 特力屋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_特力屋 轉換_ = new 平台訂單匯入轉換_特力屋();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void 松果一般ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_松果 轉換_ = new 平台訂單匯入轉換_松果();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void 松果sevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_松果_超商 轉換_ = new 平台訂單匯入轉換_松果_超商();
            轉換_.配送公司 = 列舉.配送公司.SEVEN;

            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void 松果全家ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_松果_超商 轉換_ = new 平台訂單匯入轉換_松果_超商();
            轉換_.配送公司 = 列舉.配送公司.全家;

            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void 生活市集一般ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_生活市集 轉換_ = new 平台訂單匯入轉換_生活市集();
            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void 生活市集SEVENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_生活市集_超商 轉換_ = new 平台訂單匯入轉換_生活市集_超商();
            轉換_.配送公司 = 列舉.配送公司.SEVEN;

            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }

        private void 生活市集全家ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入轉換_生活市集_超商 轉換_ = new 平台訂單匯入轉換_生活市集_超商();
            轉換_.配送公司 = 列舉.配送公司.全家;

            IEnumerable<平台訂單匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換_);
            匯入完成(轉換_, 資料列舉_);
        }
    }
}
