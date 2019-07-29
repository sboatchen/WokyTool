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
        private int _物品資料版本 = -1;
        private BindingList<商品組成匯入資料> _組成BList = new BindingList<商品組成匯入資料>();

        public 商品新增匯入詳細視窗(可編輯資料列管理介面 資料管理器_)
        {
            InitializeComponent();

            this.初始化(this.頁索引元件1, 資料管理器_);
            this.商品組成匯入資料BindingSource.DataSource = _組成BList;
        }

        /********************************/
        // 匯入詳細視窗

        protected override void 視窗激活()
        {
            this.商品大類選取元件1.視窗激活();
            this.商品小類選取元件1.視窗激活();

            this.公司選取元件1.視窗激活();
            this.客戶選取元件1.視窗激活();

            this.物品選取元件.視窗激活();

            if (_物品資料版本 != 物品資料管理器.獨體.可選取資料列版本)
            {
                _物品資料版本 = 物品資料管理器.獨體.可選取資料列版本;
                this.物品資料BindingSource.DataSource = 物品資料管理器.獨體.唯讀BList;
            }
        }

        /********************************/
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
    }
}
