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
using WokyTool.進貨;
using WokyTool.通用;
using WokyTool.廠商;
using WokyTool.物品;
using WokyTool.幣值;

namespace WokyTool.進貨
{
    public partial class 進貨新增匯入視窗 : 匯入視窗
    {
        protected 進貨新增匯入管理器 _進貨新增匯入管理器 = new 進貨新增匯入管理器();
        //protected 進貨新增匯入詳細視窗 _進貨新增匯入詳細視窗 = null;

        private 可清單列舉資料管理介面 _物品清單管理器 = 物品資料管理器.獨體.清單管理器;
        private int _物品資料版本 = -1;

        private int _廠商資料版本 = -1;
        private int _幣值資料版本 = -1;

        public 進貨新增匯入視窗()
        {
            InitializeComponent();

            this.初始化(進貨新增匯入資料BindingSource, _進貨新增匯入管理器);

            this.進貨BindingSource.DataSource = Enum.GetValues(typeof(列舉.進貨));
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            舊函式.GetFile("進貨新增匯入範本", "樣板/進貨/進貨新增匯入範本.xlsx");
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _進貨新增匯入管理器.新增(進貨新增匯入資料.匯入Excel<進貨新增匯入資料>());
            if (_進貨新增匯入管理器.是否正在編輯() == false)
                return;

            this.匯入ToolStripMenuItem.Enabled = false;

            this.OnActivated(null);
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            更新資料合法性();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 進貨新增錯誤匯出轉換(_進貨新增匯入管理器.可編輯BList.Where(Value => Value.錯誤訊息 != null));

            string 標題_ = String.Format("進貨新增錯誤匯出_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//
        {
            /*if (_進貨新增匯入詳細視窗 == null)
                _進貨新增匯入詳細視窗 = new 進貨新增匯入詳細視窗(_進貨新增匯入管理器);

            _進貨新增匯入詳細視窗.顯現(this.進貨新增匯入資料BindingSource.Position);*/
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_廠商資料版本 != 廠商資料管理器.獨體.可選取資料列版本)
            {
                _廠商資料版本 = 廠商資料管理器.獨體.可選取資料列版本;
                this.廠商資料BindingSource.DataSource = 廠商資料管理器.獨體.唯讀BList;
            }

            if (_物品資料版本 != _物品清單管理器.資料版本)
            {
                _物品資料版本 = _物品清單管理器.資料版本;
                this.物品資料BindingSource.DataSource = _物品清單管理器.資料列舉;
            }

            if (_幣值資料版本 != 幣值資料管理器.獨體.可選取資料列版本)
            {
                _幣值資料版本 = 幣值資料管理器.獨體.可選取資料列版本;
                this.幣值資料BindingSource.DataSource = 幣值資料管理器.獨體.唯讀BList;
            }
        }

        /*protected override void 視窗關閉()
        {
            if (_進貨新增匯入詳細視窗 != null)
                _進貨新增匯入詳細視窗.關閉();
        }*/
    }
}
