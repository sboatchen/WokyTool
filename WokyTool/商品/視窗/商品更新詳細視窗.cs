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
            /*品類.初始化(); //TODO 暫時停止 商品更新功能
            供應商.初始化();
            品牌.初始化();
            公司.初始化();
            客戶.初始化();
            單品.初始化();

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

            資料綁定(this.進價, "進價");
            資料綁定(this.售價, "售價");
            資料綁定(this.寄庫數量, "寄庫數量");
            資料綁定(this.成本, "成本");
            資料綁定(this.利潤, "利潤");
            資料綁定(this.體積, "體積");

            資料綁定(this.組成字串, "組成字串");

            資料綁定(this.參考名稱, "參考名稱");
            資料綁定(this.參考品號, "參考品號");

            資料綁定(this.參考品類, "參考品類");
            資料綁定(this.參考供應商, "參考供應商");
            資料綁定(this.參考品牌, "參考品牌");

            資料綁定(this.參考公司, "參考公司");
            資料綁定(this.參考客戶, "參考客戶");

            資料綁定(this.參考進價, "參考進價");
            資料綁定(this.參考售價, "參考售價");
            資料綁定(this.參考寄庫數量, "參考寄庫數量");
            資料綁定(this.參考成本, "參考成本");
            資料綁定(this.參考利潤, "參考利潤");
            資料綁定(this.參考體積, "參考體積");

            資料綁定(this.參考組成字串, "參考組成字串");


            資料異動顯示綁定(this.名稱, this.參考名稱);
            資料異動顯示綁定(this.品號, this.品號);

            資料異動顯示綁定(this.品類, this.參考品類);
            資料異動顯示綁定(this.供應商, this.參考供應商);
            資料異動顯示綁定(this.品牌, this.參考品牌);

            資料異動顯示綁定(this.公司, this.參考公司);
            資料異動顯示綁定(this.客戶, this.參考客戶);

            資料異動顯示綁定(this.進價, this.參考進價);
            資料異動顯示綁定(this.售價, this.參考售價);
            資料異動顯示綁定(this.寄庫數量, this.參考寄庫數量);
            資料異動顯示綁定(this.成本, this.參考成本);
            資料異動顯示綁定(this.利潤, this.參考利潤);
            資料異動顯示綁定(this.體積, this.參考體積);

            資料異動顯示綁定(this.組成字串, this.參考組成字串);

            this.dataGridView1.DataSource = _組合BS;
            this.dataGridView2.DataSource = _組合BS2;*/
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            /*單品資料 單品_ = (單品資料)(this.單品.SelectedItem);    //TODO 暫時停止 商品更新功能
            if (單品_ == null || 單品_.編號是否有值() == false)
            {
                訊息管理器.獨體.通知("單品不合法");
                return;
            }

            商品組成資料 商品組成資料_ = new 商品組成資料();
            商品組成資料_.單品 = 單品_;
            商品組成資料_.數量 = (int)this.數量.Value;

            _組合BS.Add(商品組成資料_);*/
        }

        private 商品更新資料 _目前資料 = null;
        protected override void 選擇改變()
        {
            if (_目前資料 != null)
                _目前資料.更新組成();   //@@ 優化更新方式 不要每次更新, 還有商品詳細視窗

            _目前資料 = (商品更新資料)(this.資料BS.Current);
            if (_目前資料.組成 == null)
                _目前資料.組成 = new List<商品組成資料>();

            _組合BS.DataSource = _目前資料.組成;

            if (_目前資料.參考組成 == null)
                _組合BS2.DataSource = new List<商品組成資料>();
            else
                _組合BS2.DataSource = _目前資料.參考組成;
        }

        protected override void 視窗關閉()
        {
            if (_目前資料 != null)
                _目前資料.更新組成();
        }
    }
}
