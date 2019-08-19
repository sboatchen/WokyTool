using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public partial class 通用匯出視窗 : Form
    {
        public Type 資料類型 { get; protected set; }
        public 通用匯出設定資料 設定 { get; protected set; }

        private List<通用匯出欄位設定資料> _可用欄位選單列 = new List<通用匯出欄位設定資料>();
        private List<Binding> _資料綁定列 = new List<Binding>();

        public 通用匯出視窗(Type 資料類型_)
        {
            InitializeComponent();

            this.Text = 資料類型_.Name + "通用匯出視窗";

            資料類型 = 資料類型_;

            _可用欄位選單列.Add(通用匯出欄位設定資料.空白); 
            foreach (PropertyInfo 欄位_ in 資料類型.GetProperties())
            {
                var 屬性列舉_ = 欄位_.GetCustomAttributes(typeof(可匯出匯入Attribute), true).Cast<可匯出匯入Attribute>();
                if (屬性列舉_.Count() == 0)
                    continue;

                可匯出匯入Attribute 屬性_ = 屬性列舉_.First();
                if (屬性_.匯出 == false)
                    continue;

                string 名稱_ = 欄位_.Name;
                if (false == string.IsNullOrEmpty(屬性_.名稱))
                    名稱_ = 屬性_.名稱;

                通用匯出欄位設定資料 資料_ = new 通用匯出欄位設定資料
                {
                    名稱 = 名稱_,
                    屬性 = 欄位_.Name,
                };

                _可用欄位選單列.Add(資料_);
            }

            this.檔案格式BindingSource.DataSource = Enum.GetValues(typeof(列舉.檔案格式));

            BindingSource 切檔方式BS_ = new BindingSource();
            切檔方式BS_.DataSource = _可用欄位選單列;
            切檔方式.DataSource = 切檔方式BS_;

            BindingSource 分頁方式BS_ = new BindingSource();
            分頁方式BS_.DataSource = _可用欄位選單列;
            分頁方式.DataSource = 分頁方式BS_;

            BindingSource 屬性BS_ = new BindingSource();
            屬性BS_.DataSource = _可用欄位選單列.Skip(1);
            屬性.DataSource = 屬性BS_;

            /********************************/

            設定 = new 通用匯出設定資料();

            _資料綁定列.Add(this.預設檔名.DataBindings.Add("Text", 設定, "預設檔名"));
            _資料綁定列.Add(this.檔案格式.DataBindings.Add("SelectedItem", 設定, "檔案格式"));
            _資料綁定列.Add(this.切檔方式.DataBindings.Add("SelectedValue", 設定, "切檔方式"));
            _資料綁定列.Add(this.分頁方式.DataBindings.Add("SelectedValue", 設定, "分頁方式"));

            初始化資料();
        }

        private void 初始化資料()
        {
            設定.預設檔名 = String.Format("{0}_{1}", 資料類型.Name, 時間.目前日期);
            設定.檔案格式 = 列舉.檔案格式.EXCEL;
            設定.切檔方式 = 字串.無;
            設定.分頁方式 = 字串.無;
            設定.欄位列 = _可用欄位選單列.Skip(1).ToList();
            this.通用匯出欄位設定資料BindingSource.DataSource = 設定.欄位列;
        }

        private void 載入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 開啟讀檔位置
            OpenFileDialog OFD_ = new OpenFileDialog();
            OFD_.Filter = "json files (.json)|*.json";

            string 預設路徑_ = Path.GetFullPath(string.Format(@"匯出入設定/{0}", 資料類型.Name));
            訊息管理器.獨體.訊息("載入預設路徑:" + 預設路徑_);
            OFD_.InitialDirectory = 預設路徑_; 

            if (OFD_.ShowDialog() != DialogResult.OK)
                return;

            string 內容_ = 檔案.讀出(OFD_.FileName);
            通用匯出設定資料 檔案設定_ = 內容_.轉成物件<通用匯出設定資料>();
            設定.完全拷貝(檔案設定_);

            foreach(Binding 資料綁定_ in _資料綁定列)
                資料綁定_.ReadValue();

            this.通用匯出欄位設定資料BindingSource.DataSource = 設定.欄位列;
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 開啟存檔位置
            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.FileName = 設定.預設檔名;
            SFD_.DefaultExt = ".json";
            SFD_.Filter = "json files (.json)|*.json";
            if (SFD_.ShowDialog() != DialogResult.OK)
                return;

            string 資料_ = 設定.ToString();
            檔案.寫入(SFD_.FileName, 資料_);
        }

        private void 快速儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string 路徑_ = string.Format(@"匯出入設定/{0}/{1}.json", 資料類型.Name, 設定.預設檔名);
            訊息管理器.獨體.訊息("快速儲存路徑:" + 路徑_);

            string 資料_ = 設定.ToString();
            檔案.寫入(路徑_, 資料_);
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            if (null == this.屬性.SelectedItem)
                return;

            if (string.IsNullOrEmpty(this.名稱.Text))
                return;

            通用匯出欄位設定資料 資料_ = new 通用匯出欄位設定資料
            {
                名稱 = this.名稱.Text,
                屬性 = ((通用匯出欄位設定資料)this.屬性.SelectedItem).屬性,
            };

            設定.欄位列.Add(資料_);
            this.通用匯出欄位設定資料BindingSource.ResetBindings(false);
        }

        private void 屬性_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(null == this.屬性.SelectedItem)
                return;

            this.名稱.Text = ((通用匯出欄位設定資料)this.屬性.SelectedItem).名稱;

        }

        private void 測試ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            訊息管理器.獨體.通知(設定);
        }
    }
}
