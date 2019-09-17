using LINQtoCSV;
using LinqToExcel;
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
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.配送
{
    public partial class 配送新增總覽視窗 : 新增總覽視窗
    {
        public override Type 資料類型 { get { return typeof(配送轉換資料); } }

        public override 可編輯列舉資料管理介面 更新管理器 { get { return 資料管理器; } }

        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 樣板MI { get { return null; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }

        public override 通用視窗介面 取得篩選視窗實體
        {
            get
            {
                var 視窗_ = new 配送新增篩選視窗(資料管理器.視窗篩選器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public override 通用視窗介面 取得詳細視窗實體
        {
            get
            {
                var 視窗_ = new 配送新增詳細視窗(資料管理器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public 配送轉換資料管理器 資料管理器 = new 配送轉換資料管理器();

        public 配送新增總覽視窗()
        {
            InitializeComponent();
        }

        public 配送新增總覽視窗(List<配送轉換資料> 資料列_)
        {
            InitializeComponent();

            資料管理器.新增(資料列_);
        }

        private void 全速配匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<配送轉換資料> 資料列舉_ = 資料管理器.資料列.Where(Value => Value.配送公司 == 列舉.配送公司.全速配 && Value.已配送 == false);

            全速配匯出轉換 轉換_ = new 全速配匯出轉換(資料列舉_);
            string 標題_ = String.Format("全速配匯出_{0}", 時間.目前日期);
            if (檔案.詢問並寫入(標題_, 轉換_))
                訊息管理器.獨體.通知("匯出完成");
        }

        private void 全速配匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<配送轉換資料> 資料列舉_ = 資料管理器.資料列.Where(Value => Value.配送公司 == 列舉.配送公司.全速配);

            全速配匯入轉換 轉換器_ = new 全速配匯入轉換(資料列舉_);

            IEnumerable<配送轉換資料> 處理列舉_ = 檔案.詢問並讀出(轉換器_);
            if (處理列舉_ != null) 
            {
                處理列舉_.Count();  // 強制處理
                訊息管理器.獨體.通知("匯入完成");
            }
        }

        private void 全速配撿貨ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<配送轉換資料> 資料列舉_ = 資料管理器.資料列.Where(Value => Value.配送公司 == 列舉.配送公司.全速配 && Value.已配送);
            
            配送撿貨轉換 轉換_ = new 配送撿貨轉換(資料列舉_);
            string 標題_ = String.Format("全速配撿貨_{0}", 時間.目前日期);
            if (檔案.詢問並寫入(標題_, 轉換_))
                訊息管理器.獨體.通知("匯出完成");
        }

        private void 全速配明細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<配送轉換資料> 資料列舉_ = 資料管理器.資料列.Where(Value => Value.配送公司 == 列舉.配送公司.全速配 && Value.已配送);

            配送明細轉換 轉換_ = new 配送明細轉換(資料列舉_);
            string 標題_ = String.Format("全速配明細_{0}", 時間.目前日期);
            if (檔案.詢問並寫入(標題_, 轉換_))
                訊息管理器.獨體.通知("匯出完成");
        }

        private void 宅配通匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<配送轉換資料> 資料列舉_ = 資料管理器.資料列.Where(Value => Value.配送公司 == 列舉.配送公司.宅配通 && Value.已配送 == false);


            宅配通匯出轉換 轉換_ = new 宅配通匯出轉換(資料列舉_);
            string 標題_ = String.Format("宅配通匯出_{0}", 時間.目前日期);
            if (檔案.詢問並寫入(標題_, 轉換_))
                訊息管理器.獨體.通知("匯出完成");
        }

        private void 宅配通匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<配送轉換資料> 資料列舉_ = 資料管理器.資料列.Where(Value => Value.配送公司 == 列舉.配送公司.宅配通);

            宅配通匯入轉換 轉換器_ = new 宅配通匯入轉換(資料列舉_);

            IEnumerable<配送轉換資料> 處理列舉_ = 檔案.詢問並讀出(轉換器_);
            if (處理列舉_ != null)
            {
                處理列舉_.Count();  // 強制處理
                訊息管理器.獨體.通知("匯入完成");
            }
        }

        private void 宅配通撿貨ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<配送轉換資料> 資料列舉_ = 資料管理器.資料列.Where(Value => Value.配送公司 == 列舉.配送公司.宅配通 && Value.已配送);

            配送撿貨轉換 轉換_ = new 配送撿貨轉換(資料列舉_);
            string 標題_ = String.Format("宅配通撿貨_{0}", 時間.目前日期);
            if (檔案.詢問並寫入(標題_, 轉換_))
                訊息管理器.獨體.通知("匯出完成");
        }

        private void 宅配通明細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<配送轉換資料> 資料列舉_ = 資料管理器.資料列.Where(Value => Value.配送公司 == 列舉.配送公司.宅配通 && Value.已配送);

            配送明細轉換 轉換_ = new 配送明細轉換(資料列舉_);
            string 標題_ = String.Format("宅配通明細_{0}", 時間.目前日期);
            if (檔案.詢問並寫入(標題_, 轉換_))
                訊息管理器.獨體.通知("匯出完成");
        }

        private void 測試ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (var 資料_ in 資料管理器.資料列.Where(Value => Value.已配送 == false))
            {
                資料_.配送單號 = String.Format("宅配回單測試{0}", i++);
            }

            訊息管理器.獨體.通知("測試完成");
        }

        private void SEVEN轉換ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<可寫入介面_PDF> 資料列舉_ = 資料管理器.資料列.Where(Value => Value.配送公司 == 列舉.配送公司.SEVEN).Select(Value => (可寫入介面_PDF)Value);

            foreach (可寫入介面_PDF 資料_ in 資料列舉_)
            {
                檔案.詢問並修改(資料_);
            }
        }

        private void SEVEN撿貨ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<配送轉換資料> 資料列舉_ = 資料管理器.資料列.Where(Value => Value.配送公司 == 列舉.配送公司.SEVEN);

            foreach (配送轉換資料 資料_ in 資料列舉_)
            {
                配送撿貨轉換 轉換_ = new 配送撿貨轉換(資料列舉_);
                string 標題_ = String.Format("宅配通撿貨_{0}", 時間.目前日期);
                if (檔案.詢問並寫入(標題_, 轉換_))
                    訊息管理器.獨體.通知("匯出完成");
            }
        }

        private void SEVEN明細ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
