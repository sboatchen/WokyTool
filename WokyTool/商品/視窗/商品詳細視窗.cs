using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WokyTool.單品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.商品{

    public partial class 商品詳細視窗: 獨體詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.商品; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 商品資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        private BindingSource _組合BS = new BindingSource();
        private BindingSource _自訂售價BS = new BindingSource();

        private static 可檢查介面 _新增檢查 = new 通知檢查器();

        public 商品詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            公司.初始化();
            客戶.初始化();
            子客戶.初始化();

            品類.初始化();
            供應商.初始化();
            品牌.初始化();

            新增單品.初始化();

            base.初始化();

            資料綁定(this.名稱, "名稱");
            資料綁定(this.品號, "品號");

            資料綁定(this.品類, "品類");
            資料綁定(this.供應商, "供應商");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");

            資料綁定(this.進價, "進價");
            資料綁定(this.售價, "售價");
            資料綁定(this.寄庫數量, "寄庫數量");

            資料綁定(this.成本, "成本");
            資料綁定(this.利潤, "利潤");

            資料綁定(this.組成, "組成字串");
            
            this.dataGridView1.DataSource = _組合BS;
            this.自訂售價GV.DataSource = _自訂售價BS;

            this._組合BS.CurrentItemChanged += _組合異動;
            this.客戶.下拉選單.SelectedIndexChanged += _on客戶改變;
        }

        private void _on客戶改變(object sender, EventArgs e)
        {
            客戶資料 客戶_ = (客戶資料)(this.客戶.SelectedItem);
            if (客戶_ == null || 客戶_ == 客戶資料.空白)
                客戶_ = 客戶資料.不篩選;

            this.子客戶.SelectedItem = 子客戶資料.空白;

            this.子客戶.篩選器.客戶 = 客戶_;
        }

        private void _組合異動(object sender, EventArgs e)
        {
            //Console.WriteLine("組合異動");

            _目前資料.更新組成();
            this.組成.Text = _目前資料.組成字串;
            this.品牌.SelectedItem = _目前資料.品牌;
            this.成本.Value = _目前資料.成本;
            this.利潤.Value = _目前資料.利潤;
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            商品組成資料 商品組成資料_ = new 商品組成資料();
            商品組成資料_.群組 = (int)this.新增群組.Value;
            商品組成資料_.規格 = this.新增規格.Text;
            商品組成資料_.單品 = (單品資料)(this.新增單品.SelectedItem);
            商品組成資料_.數量 = (int)this.新增數量.Value;

            _新增檢查.重置();
            商品組成資料_.檢查合法(_新增檢查);

            if (_新增檢查.是否合法 == false)
                return;

            _組合BS.Add(商品組成資料_);

            _組合異動(null, null);
        }

        private 商品資料 _目前資料 = null;
        protected override void 選擇改變()
        {
            _目前資料 = (商品資料)(this.資料BS.Current);

            if (_目前資料.組成 == null)
                _目前資料.組成 = new List<商品組成資料>();

            _組合BS.DataSource = _目前資料.組成;

            if (_目前資料.自訂售價列 == null)
                _目前資料.自訂售價列 = new List<自訂售價資料>();

            _自訂售價BS.DataSource = _目前資料.自訂售價列;
        }

        private void 新增2_Click(object sender, EventArgs e)
        {
            自訂售價資料 自訂售價資料_ = new 自訂售價資料();
            自訂售價資料_.索引 = ((子客戶資料)(this.子客戶.SelectedItem)).名稱;
            自訂售價資料_.售價 = (decimal)this.新增售價.Value;

            _新增檢查.重置();
            自訂售價資料_.檢查合法(_新增檢查);

            if (_新增檢查.是否合法 == false)
                return;

            _自訂售價BS.Add(自訂售價資料_);
        }
    }
}
