using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WokyTool.公司;
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public partial class 平台訂單新增匯入視窗 : 新增總覽視窗
    {
        public override Type 資料類型 { get { return typeof(平台訂單新增匯入資料); } }

        public override 可編輯列舉資料管理介面 更新管理器 { get { return 資料管理器; } }

        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 樣板MI { get { return null; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }

        public override 通用視窗介面 取得篩選視窗實體
        {
            get
            {
                var 視窗_ = new 平台訂單新增匯入篩選視窗(資料管理器.視窗篩選器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public override 通用視窗介面 取得詳細視窗實體
        {
            get
            {
                var 視窗_ = new 平台訂單新增匯入詳細視窗(資料管理器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public 平台訂單新增匯入資料管理器 資料管理器 = new 平台訂單新增匯入資料管理器();

        public 平台訂單新增匯入視窗()
        {
            InitializeComponent();
        }

        private void 匯入完成(平台訂單匯入處理介面 處理器_, IEnumerable<平台訂單新增匯入資料> 資料列舉_)
        {
            if(資料列舉_ == null)
                return;

            List<平台訂單新增匯入資料> 資料列_ = 資料列舉_.ToList(); // 先將資料確實轉換出來

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

            公司資料 公司_ = Queue_.First();

            處理器_.公司 = 公司_;
            foreach (平台訂單新增匯入資料 資料_ in 資料列_)
            {
                資料_.公司 = 公司_;
            }

            資料管理器.新增(資料列_);

            更新資料();

            //foreach (var x in 資料列_)
            //    Console.WriteLine(x.ToString());

            訊息管理器.獨體.通知("匯入完成");
        }

        private void 中華電信_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_中華電信 轉換器_ = new 平台訂單匯入處理_中華電信();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 東森_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_東森 轉換器_ = new 平台訂單匯入處理_東森();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void friday_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_Friday 轉換器_ = new 平台訂單匯入處理_Friday();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void uDNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_UDN 轉換器_ = new 平台訂單匯入處理_UDN();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void ibonMartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_ibonMart 轉換器_ = new 平台訂單匯入處理_ibonMart();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 金石堂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_金石堂 轉換器_ = new 平台訂單匯入處理_金石堂();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 百利市ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_百利市 轉換器_ = new 平台訂單匯入處理_百利市();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void vivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_viva 轉換器_ = new 平台訂單匯入處理_viva();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 特力屋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_特力屋 轉換器_ = new 平台訂單匯入處理_特力屋();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 松果一般ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_松果 轉換器_ = new 平台訂單匯入處理_松果();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 松果sevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_松果_超商 轉換器_ = new 平台訂單匯入處理_松果_超商();
            轉換器_.配送公司 = 列舉.配送公司.SEVEN;

            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 松果全家ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_松果_超商 轉換器_ = new 平台訂單匯入處理_松果_超商();
            轉換器_.配送公司 = 列舉.配送公司.全家;

            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 生活市集一般ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_生活市集 轉換器_ = new 平台訂單匯入處理_生活市集();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 生活市集SEVENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_生活市集_超商 轉換器_ = new 平台訂單匯入處理_生活市集_超商();
            轉換器_.配送公司 = 列舉.配送公司.SEVEN;

            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 生活市集全家ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_生活市集_超商 轉換器_ = new 平台訂單匯入處理_生活市集_超商();
            轉換器_.配送公司 = 列舉.配送公司.全家;

            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void Momo第三方ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_Momo第三方 轉換器_ = new 平台訂單匯入處理_Momo第三方();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 博客來ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_博客來 轉換器_ = new 平台訂單匯入處理_博客來();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void 神坊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_神坊 轉換器_ = new 平台訂單匯入處理_神坊();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void uDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_uDesign 轉換器_ = new 平台訂單匯入處理_uDesign();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }

        private void payEasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_PayEasy 轉換器_ = new 平台訂單匯入處理_PayEasy();
            IEnumerable<平台訂單新增匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列舉_);
        }
    }
}