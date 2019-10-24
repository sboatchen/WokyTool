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

        private void 匯入完成(平台訂單匯入處理介面 處理器_, List<平台訂單新增匯入資料> 資料列_)
        {
            if(資料列_ == null)
                return;

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
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 東森_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_東森 轉換器_ = new 平台訂單匯入處理_東森();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void friday_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_Friday 轉換器_ = new 平台訂單匯入處理_Friday();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void uDNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_UDN 轉換器_ = new 平台訂單匯入處理_UDN();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void ibonMartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_ibonMart 轉換器_ = new 平台訂單匯入處理_ibonMart();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 金石堂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_金石堂 轉換器_ = new 平台訂單匯入處理_金石堂();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 百利市ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_百利市 轉換器_ = new 平台訂單匯入處理_百利市();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void vivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_viva 轉換器_ = new 平台訂單匯入處理_viva();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 特力屋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_特力屋 轉換器_ = new 平台訂單匯入處理_特力屋();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 松果一般ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_松果 轉換器_ = new 平台訂單匯入處理_松果();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 松果sevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_松果_超商 轉換器_ = new 平台訂單匯入處理_松果_超商();
            轉換器_.配送公司 = 列舉.配送公司.SEVEN;

            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 松果全家ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_松果_超商 轉換器_ = new 平台訂單匯入處理_松果_超商();
            轉換器_.配送公司 = 列舉.配送公司.全家;

            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 生活市集一般ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_生活市集 轉換器_ = new 平台訂單匯入處理_生活市集();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 生活市集SEVENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_生活市集_超商 轉換器_ = new 平台訂單匯入處理_生活市集_超商();
            轉換器_.配送公司 = 列舉.配送公司.SEVEN;

            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 生活市集全家ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_生活市集_超商 轉換器_ = new 平台訂單匯入處理_生活市集_超商();
            轉換器_.配送公司 = 列舉.配送公司.全家;

            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void Momo第三方ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_Momo第三方 轉換器_ = new 平台訂單匯入處理_Momo第三方();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 博客來ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_博客來 轉換器_ = new 平台訂單匯入處理_博客來();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 神坊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_神坊 轉換器_ = new 平台訂單匯入處理_神坊();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void uDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_uDesign 轉換器_ = new 平台訂單匯入處理_uDesign();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void payEasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_PayEasy 轉換器_ = new 平台訂單匯入處理_PayEasy();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void citiesocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_citiesocial 轉換器_ = new 平台訂單匯入處理_citiesocial();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void wACAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_WACA 轉換器_ = new 平台訂單匯入處理_WACA();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 摩天ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_摩天 轉換器_ = new 平台訂單匯入處理_摩天();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 奇摩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_奇摩 轉換器_ = new 平台訂單匯入處理_奇摩();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }

        private void 日翊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            平台訂單匯入處理_日翊 轉換器_ = new 平台訂單匯入處理_日翊();
            List<平台訂單新增匯入資料> 資料列_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(轉換器_, 資料列_);
        }
    }
}