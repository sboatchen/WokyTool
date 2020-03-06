using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WokyTool.單品;
using WokyTool.通用;

namespace WokyTool.商品{

    public partial class 商品更新詳細視窗 : 新增詳細視窗
    {
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        private BindingSource _組合BS = new BindingSource();
        private BindingSource _組合BS2 = new BindingSource();

        private static 可檢查介面 _新增檢查 = new 通知檢查器();

        // 介面編輯呈現用
        public 商品更新詳細視窗() : base()
        {
            InitializeComponent();
        }

        public 商品更新詳細視窗(可編輯列舉資料管理介面 更新管理器_) : base(更新管理器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            品類.初始化();
            供應商.初始化();
            品牌.初始化();
            公司.初始化();
            客戶.初始化();
            新增單品.初始化();

            參考品類.初始化();
            參考供應商.初始化();
            參考品牌.初始化();
            參考公司.初始化();
            參考客戶.初始化();

            base.初始化();

            資料綁定(this.更新狀態, "更新狀態");
            資料綁定(this.錯誤訊息, "錯誤訊息");

            資料綁定(this.名稱, "名稱");
            資料綁定(this.品號, "品號");

            資料綁定(this.品類, "品類");
            資料綁定(this.供應商, "供應商");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");

            資料綁定(this.寄庫數量, "寄庫數量");
            資料綁定(this.成本, "成本");
            資料綁定(this.利潤, "利潤");

            資料綁定(this.組成字串, "組成字串");

            資料綁定(this.參考名稱, "參考名稱");
            資料綁定(this.參考品號, "參考品號");

            資料綁定(this.參考品類, "參考品類");
            資料綁定(this.參考供應商, "參考供應商");
            資料綁定(this.參考品牌, "參考品牌");

            資料綁定(this.參考公司, "參考公司");
            資料綁定(this.參考客戶, "參考客戶");

            資料綁定(this.參考寄庫數量, "參考寄庫數量");
            資料綁定(this.參考成本, "參考成本");
            資料綁定(this.參考利潤, "參考利潤");

            資料綁定(this.參考組成字串, "參考組成字串");

            資料異動顯示綁定(this.名稱, this.參考名稱);
            資料異動顯示綁定(this.品號, this.品號);

            資料異動顯示綁定(this.品類, this.參考品類);
            資料異動顯示綁定(this.供應商, this.參考供應商);
            資料異動顯示綁定(this.品牌, this.參考品牌);

            資料異動顯示綁定(this.公司, this.參考公司);
            資料異動顯示綁定(this.客戶, this.參考客戶);

            資料異動顯示綁定(this.寄庫數量, this.參考寄庫數量);
            資料異動顯示綁定(this.成本, this.參考成本);
            資料異動顯示綁定(this.利潤, this.參考利潤);

            資料異動顯示綁定(this.組成字串, this.參考組成字串);

            this.dataGridView1.DataSource = _組合BS;
            this.dataGridView2.DataSource = _組合BS2;

            this._組合BS.CurrentItemChanged += _組合異動;
        }

        private void _組合異動(object sender, EventArgs e)
        {
            Console.WriteLine("組合異動");

            _目前資料.更新組成();
            this.組成字串.Text = _目前資料.組成字串;
            this.品類.SelectedItem = _目前資料.品類;
            this.供應商.SelectedItem = _目前資料.供應商;
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

        private 商品更新資料 _目前資料 = null;
        protected override void 選擇改變()
        {
            _目前資料 = (商品更新資料)(this.資料BS.Current);

            if (_目前資料.組成 == null)
                _目前資料.組成 = new List<商品組成資料>();

            _組合BS.DataSource = _目前資料.組成;
            _組合BS2.DataSource = _目前資料.參考組成;
        }
    }
}
