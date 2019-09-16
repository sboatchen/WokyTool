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

    public partial class 商品詳細視窗: 獨體詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.商品; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 商品資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }

        private BindingSource _組合BS = new BindingSource();

        public 商品詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            客戶.初始化();
            公司.初始化();

            大類.初始化();
            小類.初始化();
            品牌.初始化();

            物品.初始化();

            base.初始化();

            資料綁定(this.名稱, "名稱");
            資料綁定(this.品號, "品號");

            資料綁定(this.大類, "大類");
            資料綁定(this.小類, "小類");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");

            資料綁定(this.進價, "進價");
            資料綁定(this.售價, "售價");
            資料綁定(this.寄庫數量, "寄庫數量");

            資料綁定(this.體積, "體積");
            資料綁定(this.成本, "成本");
            資料綁定(this.利潤, "利潤");

            this.dataGridView1.DataSource = _組合BS;
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            物品資料 物品_ = (物品資料)(this.物品.SelectedItem);
            if (物品_ == null || 物品_.編號是否有值() == false)
            {
                訊息管理器.獨體.通知("物品不合法");
                return;
            }

            商品組成資料 商品組成資料_ = new 商品組成資料();
            商品組成資料_.物品 = 物品_;
            商品組成資料_.數量 = (int)this.數量.Value;

            _組合BS.Add(商品組成資料_);
        }

        private 商品資料 _目前資料 = null;
        protected override void 選擇改變()
        {
            if (_目前資料 != null)
                _目前資料.更新組成();

            _目前資料 = (商品資料)(this.資料BS.Current);
            if (_目前資料.組成 == null)
                _目前資料.組成 = new List<商品組成資料>();

            _組合BS.DataSource = _目前資料.組成;
        }

        protected override void 視窗關閉()
        {
            if (_目前資料 != null)
                _目前資料.更新組成();
        }
    }
}
