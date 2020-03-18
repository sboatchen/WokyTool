using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.一般訂單
{
    public partial class 一般訂單新增總覽視窗 : 獨體總覽視窗
    {
        protected static 可檢查介面 物件檢查器 = new 例外檢查器();

        public override 列舉.編號 編號類型 { get { return 列舉.編號.一般訂單新增; } }
        public override Type 資料類型 { get { return typeof(一般訂單新增資料); } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 一般訂單新增資料管理器.獨體.編輯管理器; } }
        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }
        public override ToolStripMenuItem 自訂MI { get { return this.自訂ToolStripMenuItem; } }
        public override ToolStripMenuItem 新增MI { get { return this.新增ToolStripMenuItem; } }

        public 一般訂單新增總覽視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            this.更新ToolStripMenuItem.Enabled = 編輯管理器.是否可編輯;
        }

        private void 配送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            編輯管理器.合法檢查(物件檢查器);

            IEnumerable<一般訂單新增資料> 資料列舉_ = (IEnumerable<一般訂單新增資料>)編輯管理器.資料列舉;

            資料列舉_.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.新增 && Value.是否退貨).執行(Value => Value.處理狀態 = 列舉.訂單處理狀態.退貨).Count();

            List<配送轉換資料> 資料列_ = 資料列舉_.Where(Value => Value.處理狀態 == 列舉.訂單處理狀態.新增 || Value.處理狀態 == 列舉.訂單處理狀態.配送).Select(Value => (配送轉換資料)new 一般訂單配送轉換資料(Value)).ToList();

            var 視窗_ = new 配送新增總覽視窗(資料列_);
            視窗_.初始化();
            視窗_.Show();
            視窗_.BringToFront();

            訊息管理器.獨體.通知("已轉入配送系統");
        }

        private void 封存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            一般訂單新增資料管理器.獨體.完成();

            this.OnActivated(null);

            訊息管理器.獨體.通知("已完成");
        }

        private void 銷售單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            IEnumerable<一般訂單銷售匯出結構> 資料列舉_ = ((IEnumerable<一般訂單新增資料>)編輯管理器.資料列舉).Select(Value => new 一般訂單銷售匯出結構(Value, i++));

            foreach (一般訂單銷售匯出結構 轉換_ in 資料列舉_)
            {
                String 標題_ = (轉換_.資料.子客戶編號 > 0) ? 
                    String.Format("{0}_工廠出貨_{1}_{2}_{3}_{4}", 轉換_.編號, 轉換_.資料.客戶名稱, 轉換_.資料.子客戶名稱, 時間.目前日期, 轉換_.資料.配送單號) :
                    String.Format("{0}_工廠出貨_{1}_{2}_{3}", 轉換_.編號, 轉換_.資料.客戶名稱, 時間.目前日期, 轉換_.資料.配送單號);
                
                檔案.詢問並寫入(標題_, 轉換_);
            }
        }
    }
}
