using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WokyTool.公司;
using WokyTool.通用;

namespace WokyTool.寄庫
{
    public partial class 寄庫匯入視窗 : 新增總覽視窗
    {
        public override Type 資料類型 { get { return typeof(寄庫匯入資料); } }

        public override 可編輯列舉資料管理介面 更新管理器 { get { return 資料管理器; } }

        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 樣板MI { get { return null; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }

        public override 通用視窗介面 取得篩選視窗實體
        {
            get
            {
                var 視窗_ = new 寄庫匯入篩選視窗(資料管理器.視窗篩選器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public override 通用視窗介面 取得詳細視窗實體
        {
            get
            {
                var 視窗_ = new 寄庫匯入詳細視窗(資料管理器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public 寄庫匯入資料管理器 資料管理器 = new 寄庫匯入資料管理器();

        public 寄庫匯入視窗()
        {
            InitializeComponent();
        }

        private void 匯入完成(IEnumerable<寄庫匯入資料> 資料列舉_)
        {
            if(資料列舉_ == null)
                return;

            List<寄庫匯入資料> 資料列_ = 資料列舉_.ToList(); // 先將資料確實轉換出來

            if (資料列_.Count == 0)
            {
                訊息管理器.獨體.通知("沒有資料");
                return;
            }

            // 取得公司
            公司資料 公司_ = 公司資料.錯誤;
            var Queue_ = 資料列_.Select(Value => Value.商品.公司).Where(Value => Value.編號是否有值()).Distinct();
            switch (Queue_.Count())
            {
                case 0:
                    訊息管理器.獨體.通知("資料中沒有公司資訊");
                    break;
                case 1:
                    公司_ = Queue_.First();
                    break;
                default:
                    訊息管理器.獨體.通知("資料中包含複數個公司");
                    break;

            }

            foreach (寄庫匯入資料 資料_ in 資料列_)
            {
                if(資料_.商品.公司.編號是否有值())
                    資料_.公司 = 資料_.商品.公司;
                else
                    資料_.公司 = 公司_;
            }

            資料管理器.新增(資料列_);

            更新資料();

            訊息管理器.獨體.通知("匯入完成");
        }

        private void momoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            寄庫匯入轉換_Momo 轉換器_ = new 寄庫匯入轉換_Momo();
            IEnumerable<寄庫匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(資料列舉_);
        }

        private void pCHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            寄庫匯入轉換_PCHome 轉換器_ = new 寄庫匯入轉換_PCHome();
            IEnumerable<寄庫匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(資料列舉_);
        }

        private void 博客來ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            寄庫匯入轉換_博客來 轉換器_ = new 寄庫匯入轉換_博客來();
            IEnumerable<寄庫匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(資料列舉_);
        }

        private void 蝦皮ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            寄庫匯入轉換_蝦皮 轉換器_ = new 寄庫匯入轉換_蝦皮();
            IEnumerable<寄庫匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(資料列舉_);
        }

        private void 料理123ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            寄庫匯入轉換_料理123 轉換器_ = new 寄庫匯入轉換_料理123();
            IEnumerable<寄庫匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(資料列舉_);
        }

        private void 京站站前店ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            寄庫匯入轉換_京站站前店 轉換器_ = new 寄庫匯入轉換_京站站前店();
            IEnumerable<寄庫匯入資料> 資料列舉_ = 檔案.詢問並讀出(轉換器_);
            匯入完成(資料列舉_);
        }
    }
}