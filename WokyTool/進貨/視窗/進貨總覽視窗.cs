using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.物品;
using WokyTool.通用;
using WokyTool.幣值;
using WokyTool.廠商;

namespace WokyTool.進貨
{
    public partial class 進貨總覽視窗 : 總覽視窗
    {

        private 可清單列舉資料管理介面 _物品清單管理器 = 物品資料管理器.獨體.清單管理器;
        private int _物品資料版本 = -1;

        private int _廠商資料版本 = -1;
        private int _幣值資料版本 = -1;

        public 進貨總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.進貨資料BindingSource, 進貨資料管理器.獨體);

            this.進貨處理狀態BindingSource.DataSource = Enum.GetValues(typeof(列舉.進貨處理狀態));
            this.進貨BindingSource.DataSource = Enum.GetValues(typeof(列舉.進貨));
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.通知("尚未實作");
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var 轉換_ = new 進貨總覽匯出轉換(進貨資料管理器.獨體.可編輯BList);

            string 標題_ = String.Format("進貨總覽_{0}", 時間.目前日期);
            if(檔案.詢問並寫入(標題_, 轉換_))
                訊息管理器.獨體.通知("匯出完成");
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            進貨資料管理器.獨體.讀取();
            this.OnActivated(null);
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
    }
}
