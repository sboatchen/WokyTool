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
using WokyTool.一般訂單;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    public partial class 一般訂單總覽視窗 : 總覽視窗
    {
        private int _公司資料版本 = -1;
        private int _客戶資料版本 = -1;
        private int _子客戶資料版本 = -1;
        private int _物品資料版本 = -1;

        private 一般訂單資料篩選設定 _一般訂單資料篩選設定;

        public 一般訂單總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.一般訂單資料BindingSource, 一般訂單資料管理器.獨體);

            this.處理狀態DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.訂單處理狀態));
            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));

            _一般訂單資料篩選設定 = new 一般訂單資料篩選設定();

            this.更新ToolStripMenuItem.Enabled = 一般訂單資料管理器.獨體.是否可編輯;
        }

        private void 篩選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.通知("功能尚未實作");
            //視窗管理器.獨體.顯現(列舉.編號.平台訂單新增, 列舉.視窗.篩選);
        }

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.更新ToolStripMenuItem.Enabled = false;

            一般訂單資料管理器.獨體.合併();

            訊息管理器.獨體.通知("合併完成");

            this.更新ToolStripMenuItem.Enabled = true;
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.匯出ToolStripMenuItem.Enabled = false;

            var GroupQueue_ = 一般訂單資料管理器.獨體.可編輯BList.GroupBy(Value => Value.客戶);

            List<可寫入介面_EXCEL> 轉換列_ = new List<可寫入介面_EXCEL>();
            foreach (var Group_ in GroupQueue_)
            {
                轉換列_.Add(new 一般訂單匯出轉換(Group_));
            }

            String 標題_ = String.Format("一般訂單_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換列_);

            訊息管理器.獨體.通知("已完成匯出");

            this.匯出ToolStripMenuItem.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            on更新日期();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            on更新日期();
        }

        private void on更新日期()
        {
            _一般訂單資料篩選設定.開始時間 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0, 0, 0, 0);
            _一般訂單資料篩選設定.結束時間 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 23, 59, 59, 0);
            一般訂單資料管理器.獨體.篩選介面 = _一般訂單資料篩選設定;
            this.OnActivated(null);
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_公司資料版本 != 公司資料管理器.獨體.可選取資料列版本)
            {
                _公司資料版本 = 公司資料管理器.獨體.可選取資料列版本;
                this.公司資料BindingSource.DataSource = 公司資料管理器.獨體.唯讀BList;
            }

            if (_客戶資料版本 != 客戶資料管理器.獨體.可選取資料列版本)
            {
                _客戶資料版本 = 客戶資料管理器.獨體.可選取資料列版本;
                this.客戶資料BindingSource.DataSource = 客戶資料管理器.獨體.唯讀BList;
            }

            if (_子客戶資料版本 != 子客戶資料管理器.獨體.可選取資料列版本)
            {
                _子客戶資料版本 = 子客戶資料管理器.獨體.可選取資料列版本;
                this.子客戶資料BindingSource.DataSource = 子客戶資料管理器.獨體.唯讀BList;
            }

            if (_物品資料版本 != 物品資料管理器.獨體.可選取資料列版本)
            {
                _物品資料版本 = 物品資料管理器.獨體.可選取資料列版本;
                this.物品資料BindingSource.DataSource = 物品資料管理器.獨體.唯讀BList;
            }
        }
    }
}
