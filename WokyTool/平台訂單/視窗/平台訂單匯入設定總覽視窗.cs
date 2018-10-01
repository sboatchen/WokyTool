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
using WokyTool.通用;

namespace WokyTool.平台訂單
{
    public partial class 平台訂單匯入設定總覽視窗 : 總覽視窗
    {
        private int _公司資料版本 = -1;
        private int _客戶資料版本 = -1;

        public 平台訂單匯入設定總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.平台訂單匯入設定資料BindingSource, 平台訂單匯入設定資料管理器.獨體);

            this.檔案格式BindingSource.DataSource = Enum.GetValues(typeof(列舉.檔案格式));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 編號_ = ((平台訂單匯入設定資料)(this.平台訂單匯入設定資料BindingSource.Current)).編號;
            視窗管理器.獨體.顯現(列舉.編號.平台訂單設定, 列舉.視窗.詳細, 編號_);
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.平台訂單匯入設定資料BindingSource.Current == null)
            {
                訊息管理器.獨體.Notify("請先選擇複製的樣板");
                return;
            }

            平台訂單匯入設定資料 Source_ = (平台訂單匯入設定資料)(this.平台訂單匯入設定資料BindingSource.Current);
            
            平台訂單匯入設定資料 New_ = Source_.拷貝();
            New_.編號 = 常數.T新建資料編碼;

            this.平台訂單匯入設定資料BindingSource.Add(New_);
        }

        /********************************/

        protected override void 視窗激活()
        {
            if (_公司資料版本 != 公司資料管理器.獨體.唯讀資料版本)
            {
                _公司資料版本 = 公司資料管理器.獨體.唯讀資料版本;
                this.公司資料BindingSource.DataSource = 公司資料管理器.獨體.唯讀BList;
            }

            if (_客戶資料版本 != 客戶資料管理器.獨體.唯讀資料版本)
            {
                _客戶資料版本 = 客戶資料管理器.獨體.唯讀資料版本;
                this.客戶資料BindingSource.DataSource = 客戶資料管理器.獨體.唯讀BList;
            }
        }
    }
}