using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.商品{

    public partial class 商品更新詳細視窗 : 更新詳細視窗
    {
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

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
            大類.初始化();
            小類.初始化();
            品牌.初始化();
            參考大類.初始化();
            參考小類.初始化();
            參考品牌.初始化();

            base.初始化();

            資料綁定(this.更新狀態, "更新狀態");
            資料綁定(this.錯誤訊息, "錯誤訊息");

            資料綁定(this.名稱, "名稱");
            資料綁定(this.縮寫, "縮寫");
            資料綁定(this.類別, "類別");
            資料綁定(this.顏色, "顏色");

            資料綁定(this.條碼, "條碼");
            資料綁定(this.原廠編號, "原廠編號");
            資料綁定(this.代理編號, "代理編號");

            資料綁定(this.大類, "大類");
            資料綁定(this.小類, "小類");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.體積, "體積");
            資料綁定(this.庫存, "庫存");
            資料綁定(this.庫存總成本, "庫存總成本");
            資料綁定(this.最後進貨成本, "最後進貨成本");
            資料綁定(this.成本, "成本");

            資料綁定(this.成本備註, "成本備註");


            資料綁定(this.參考名稱, "參考名稱");
            資料綁定(this.參考縮寫, "參考縮寫");
            資料綁定(this.參考類別, "參考類別");
            資料綁定(this.參考顏色, "參考顏色");

            資料綁定(this.參考條碼, "參考條碼");
            資料綁定(this.參考原廠編號, "參考原廠編號");
            資料綁定(this.參考代理編號, "參考代理編號");

            資料綁定(this.參考大類, "參考大類");
            資料綁定(this.參考小類, "參考小類");
            資料綁定(this.參考品牌, "參考品牌");

            資料綁定(this.參考體積, "參考體積");
            資料綁定(this.參考庫存, "參考庫存");
            資料綁定(this.參考庫存總成本, "參考庫存總成本");
            資料綁定(this.參考最後進貨成本, "參考最後進貨成本");
            資料綁定(this.參考成本, "參考成本");

            資料綁定(this.參考成本備註, "參考成本備註");

            資料異動顯示綁定(this.名稱, this.參考名稱);
            資料異動顯示綁定(this.縮寫, this.參考縮寫);
            資料異動顯示綁定(this.類別, this.參考類別);
            資料異動顯示綁定(this.顏色, this.參考顏色);

            資料異動顯示綁定(this.條碼, this.參考條碼);
            資料異動顯示綁定(this.原廠編號, this.參考原廠編號);
            資料異動顯示綁定(this.代理編號, this.參考代理編號);

            資料異動顯示綁定(this.大類, this.參考大類);
            資料異動顯示綁定(this.小類, this.參考小類);
            資料異動顯示綁定(this.品牌, this.參考品牌);

            資料異動顯示綁定(this.體積, this.參考體積);
            資料異動顯示綁定(this.庫存, this.參考庫存);
            資料異動顯示綁定(this.庫存總成本, this.參考庫存總成本);
            資料異動顯示綁定(this.最後進貨成本, this.參考最後進貨成本);

            資料異動顯示綁定(this.成本備註, this.參考成本備註);
        }
    }
}


/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.公司;
using WokyTool.物品;
using WokyTool.客戶;
using WokyTool.通用;

namespace WokyTool.商品{

    public partial class 商品新增匯入詳細視窗 : 匯入詳細視窗
    {
        private 可清單列舉資料管理介面 _物品清單管理器 = 物品資料管理器.獨體.清單管理器;
        private int _物品資料版本 = -1;

        private BindingList<商品組成匯入資料> _組成BList = new BindingList<商品組成匯入資料>();

        public 商品新增匯入詳細視窗(可編輯資料列管理介面 資料管理器_)
        {
            InitializeComponent();

            this.初始化(this.頁索引元件1, 資料管理器_);
            this.商品組成匯入資料BindingSource.DataSource = _組成BList;
        }

        // 匯入詳細視窗

        protected override void 視窗激活()
        {
            if (_物品資料版本 != _物品清單管理器.資料版本)
            {
                _物品資料版本 = _物品清單管理器.資料版本;
                this.物品資料BindingSource.DataSource = _物品清單管理器.資料列舉;
            }
        }

        // 頁索引上層介面

        public override void 索引切換_異動儲存()
        {
            商品新增匯入資料 目前資料_ = (商品新增匯入資料)(this.頁索引元件1.目前資料);

            目前資料_.名稱 = this.名稱.Text;
            目前資料_.品號 = this.品號.Text;

            目前資料_.大類 = (商品大類資料)(this.商品大類選取元件1.SelectedItem);
            目前資料_.小類 = (商品小類資料)(this.商品小類選取元件1.SelectedItem);

            目前資料_.公司 = (公司資料)(this.公司選取元件1.SelectedItem);
            目前資料_.客戶 = (客戶資料)(this.客戶選取元件1.SelectedItem);

            if (_組成BList.Count == 0)
                目前資料_.組成 = null;
            else
            {
                目前資料_.組成 = new List<商品組成匯入資料>();
                foreach (var Item_ in _組成BList)
                    目前資料_.組成.Add(Item_);
            }

            目前資料_.進價 = this.進價.Value;
            目前資料_.售價 = this.售價.Value;

            目前資料_.寄庫數量 = (int)(this.寄庫數量.Value);
        }

        public override void 索引切換_更新呈現()
        {
            商品新增匯入資料 目前資料_ = (商品新增匯入資料)(this.頁索引元件1.目前資料);

            this.名稱.Text = 目前資料_.名稱;
            this.品號.Text = 目前資料_.品號;

            this.大類識別.Text = 目前資料_.大類識別;
            this.商品大類選取元件1.SelectedItem = 目前資料_.大類;

            this.小類識別.Text = 目前資料_.小類識別;
            this.商品小類選取元件1.SelectedItem = 目前資料_.小類;

            this.公司識別.Text = 目前資料_.公司識別;
            this.公司選取元件1.SelectedItem = 目前資料_.公司;

            this.客戶識別.Text = 目前資料_.客戶識別;
            this.客戶選取元件1.SelectedItem = 目前資料_.客戶;

            _組成BList.RaiseListChangedEvents = false;

            _組成BList.Clear();
            if (目前資料_.組成 != null)
            {
                foreach (var Item_ in 目前資料_.組成)
                    _組成BList.Add(Item_);
            }

            _組成BList.RaiseListChangedEvents = true;
            _組成BList.ResetBindings();

            this.成本.Value = 目前資料_.成本;
            this.利潤.Value = 目前資料_.利潤;
            this.體積.Value = 目前資料_.體積;

            this.進價.Value = 目前資料_.進價;
            this.售價.Value = 目前資料_.售價;

            this.寄庫數量.Value = 目前資料_.寄庫數量;
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            物品資料 物品_ = (物品資料)(this.物品選取元件.SelectedItem);
            if (物品_ == null || 物品_.編號是否有值() == false)
            {
                訊息管理器.獨體.通知("物品不合法");
                return;
            }

            商品組成匯入資料 newItem_ = new 商品組成匯入資料();
            newItem_.物品 = 物品_;
            newItem_.數量 = (int)this.數量.Value;

            _組成BList.Add(newItem_);
        }
    }
}

*/