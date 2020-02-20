using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;
using WokyTool.聯絡人;

namespace WokyTool.一般訂單
{
    public partial class 一般訂單新增詳細視窗 : 獨體詳細視窗
    {
        protected static 可檢查介面 物件檢查器 = new 例外檢查器();

        public override 列舉.編號 編號類型 { get { return 列舉.編號.一般訂單新增; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 一般訂單新增資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        private BindingSource _組合BS = new BindingSource();

        private 一般訂單新增資料 _目前資料 = null;

        public 一般訂單新增詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            公司.初始化();
            客戶.初始化();
            子客戶.初始化();
            聯絡人.初始化();
            商品.初始化();

            base.初始化();

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");
            資料綁定(this.子客戶, "子客戶");

            資料綁定(this.姓名, "姓名");
            資料綁定(this.地址, "地址");
            資料綁定(this.電話, "電話");
            資料綁定(this.手機, "手機");

            資料綁定(this.指配日期, "指配日期");
            資料綁定(this.指配時段, "指配時段");

            資料綁定(this.代收方式, "代收方式");
            資料綁定(this.代收金額, "代收金額");

            資料綁定(this.列印單價, "列印單價");

            this.myDataGridView1.DataSource = _組合BS;

            this.公司.下拉選單.SelectedValueChanged += _on公司改變;
            this.客戶.下拉選單.SelectedIndexChanged += _on客戶改變;
            this.子客戶.下拉選單.SelectedIndexChanged += _on子客戶改變;
            this.聯絡人.下拉選單.SelectedIndexChanged += _on聯絡人改變;
        }

        private void _on公司改變(object sender, EventArgs e)
        {
            this.商品.篩選器.公司 = (公司資料)this.公司.SelectedItem;
        }

        private void _on客戶改變(object sender, EventArgs e)
        {
            客戶資料 客戶_ = (客戶資料)(this.客戶.SelectedItem);
            if (客戶_ == null || 客戶_ == 客戶資料.空白)
                客戶_ = 客戶資料.不篩選;

            this.子客戶.SelectedItem = 子客戶資料.空白;
            this.聯絡人.SelectedItem = 聯絡人資料.空白;

            this.子客戶.篩選器.客戶 = 客戶_;
            this.聯絡人.篩選器.客戶 = 客戶_;
            this.商品.篩選器.客戶 = 客戶_;
        }

        private void _on子客戶改變(object sender, EventArgs e)
        {
            子客戶資料 子客戶_ = (子客戶資料)(this.子客戶.SelectedItem);
            if (子客戶_ == null || 子客戶_ == 子客戶資料.空白)
                子客戶_ = 子客戶資料.不篩選;

            this.聯絡人.SelectedItem = 聯絡人資料.空白;

            this.聯絡人.篩選器.子客戶 = 子客戶_;
        }

        private void _on聯絡人改變(object sender, EventArgs e)
        {
            聯絡人資料 聯絡人_ = (聯絡人資料)(this.聯絡人.SelectedItem);
            if (聯絡人_ == null || 聯絡人_.編號是否有值() == false)
                return;

            if (_目前資料 != null)
            {
                this.姓名.Text = 聯絡人_.姓名;
                this.地址.Text = 聯絡人_.地址;
                this.電話.Text = 聯絡人_.電話;
                this.手機.Text = 聯絡人_.手機;

                _目前資料.姓名 = 聯絡人_.姓名;
                _目前資料.地址 = 聯絡人_.地址;
                _目前資料.電話 = 聯絡人_.電話;
                _目前資料.手機 = 聯絡人_.手機;
            }
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            商品資料 商品_ = (商品資料)(this.商品.SelectedItem);
            if (商品_ == null || 商品_.編號是否有值() == false)
            {
                訊息管理器.獨體.通知("商品不合法");
                return;
            }

            一般訂單新增組成資料 組成資料_ = new 一般訂單新增組成資料();
            組成資料_.商品 = 商品_;
            組成資料_.數量 = (int)this.數量.Value;
            組成資料_.備註 = this.備註.Text;

            _組合BS.Add(組成資料_);
        }

        protected override void 選擇改變()
        {
            if (_目前資料 != null)
                _目前資料.合法檢查(物件檢查器);

            _目前資料 = (一般訂單新增資料)(this.資料BS.Current);
            if (_目前資料.組成 == null)
                _目前資料.組成 = new List<一般訂單新增組成資料>();

            _組合BS.DataSource = _目前資料.組成;
        }
    }
}