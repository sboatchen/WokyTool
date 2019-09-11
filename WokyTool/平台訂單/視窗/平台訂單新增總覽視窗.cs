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
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public partial class 平台訂單新增總覽視窗 : 新版總覽視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.平台訂單新增; } }
        public override Type 資料類型 { get { return typeof(平台訂單新增資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 平台訂單新增資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.dataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }

        public 平台訂單新增總覽視窗()
        {
            InitializeComponent();
        }

        private void 分組ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<平台訂單新增資料> 資料列舉_ = (IEnumerable<平台訂單新增資料>)編輯管理器.資料列舉;

            int StartGroup_ = 1;
            var GroupQueue_ = 資料列舉_.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.新增).執行(Value => Value.重新分組()).GroupBy(Value => Value.分組識別);
            foreach (var Group_ in GroupQueue_)
            {
                if (Group_.Count() == 1)
                    continue;

                foreach (平台訂單新增資料 資料_ in Group_)
                    資料_.配送分組 = StartGroup_;
                
                StartGroup_++;
            }

            this.dataGridView1.Refresh();
            
            訊息管理器.獨體.通知("已完成分組");
        }

        private void 配送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<平台訂單新增資料> 資料列舉_ = (IEnumerable<平台訂單新增資料>)編輯管理器.資料列舉;

            var GroupQueue_ = 資料列舉_.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.新增 || Value.處理狀態 == 列舉.訂單處理狀態.配送).GroupBy(Value => Value.配送分組);
            //@@ 略過已進入配送介面的

            List<配送轉換資料> 資料列_ = new List<配送轉換資料>();
            foreach (var Group_ in GroupQueue_)
            {
                if (Group_.Key == 0)
                {
                    foreach (平台訂單新增資料 資料_ in Group_)
                    {
                        資料列_.Add(new 平台訂單配送轉換資料(資料_));
                    }
                }
                else
                {
                    平台訂單新增資料 第一單_ = Group_.First();

                    if (Group_.Count() == 1)
                        資料列_.Add(new 平台訂單配送轉換資料(第一單_));
                    else
                        資料列_.Add(new 平台訂單合併配送轉換資料(Group_.ToList()));
                }
            }

            var 視窗_ = new 配送新增總覽視窗(資料列_);
            視窗_.初始化();
            視窗_.Show();
            視窗_.BringToFront();

            訊息管理器.獨體.通知("已轉入配送系統");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 設定群組顏色
            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {
                int value = Convert.ToInt32(Myrow.Cells[2].Value);
                Myrow.DefaultCellStyle.BackColor = 顏色處理.GetRandomColor(value);
            }
        }

        private void 回單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<平台訂單新增資料> 資料列舉_ = (IEnumerable<平台訂單新增資料>)編輯管理器.資料列舉;

            var GroupQueue_ = 資料列舉_
                                    .Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.配送 || Value.處理狀態 == 列舉.訂單處理狀態.忽略)
                                    .GroupBy(Value => Value.公司.編號 * 1000 + Value.客戶.編號);

            foreach (var Group_ in GroupQueue_)
            {
                平台訂單匯入處理介面 處理器_ = Group_.First().處理器;

                處理器_.後續處理(Group_);
            }

            訊息管理器.獨體.通知("已完成匯出");
        }

        private void 封存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單新增資料管理器.獨體.完成();

            this.OnActivated(null);

            訊息管理器.獨體.通知("已完成");
        }
    }
}
