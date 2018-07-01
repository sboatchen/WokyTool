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

namespace WokyTool.物品
{
    public partial class 物品詳細視窗 : 物品詳細視窗樣板
    {
        private int _物品品牌資料版本 = -1;
        private int _物品大類資料版本 = -1;
        private int _物品小類資料版本 = -1;
        
        public 物品詳細視窗()
        {
            InitializeComponent();

            this.初始化(this.頁索引元件1, 物品資料管理器.獨體);
        }

        /********************************/
        // 物品詳細視窗樣板

        protected override void 視窗激活()
        {
            if (_物品品牌資料版本 != 物品品牌資料管理器.獨體.BindingVersion)
            {
                _物品品牌資料版本 = 物品品牌資料管理器.獨體.BindingVersion;
                this.物品品牌資料BindingSource.DataSource = 物品品牌資料管理器.獨體.唯讀BList;
            }

            if (_物品大類資料版本 != 物品大類資料管理器.獨體.BindingVersion)
            {
                _物品大類資料版本 = 物品大類資料管理器.獨體.BindingVersion;
                this.物品大類資料BindingSource.DataSource = 物品大類資料管理器.獨體.唯讀BList;
            }

            if (_物品小類資料版本 != 物品小類資料管理器.獨體.BindingVersion)
            {
                _物品小類資料版本 = 物品小類資料管理器.獨體.BindingVersion;
                this.物品小類資料BindingSource.DataSource = 物品小類資料管理器.獨體.唯讀BList;
            }
        }

        /********************************/
        // 頁索引上層介面

        public override void 索引切換_異動儲存()
        {
            物品資料 目前資料_ = (物品資料)(this.頁索引元件1.目前資料);

            目前資料_.名稱 = this.名稱.Text;
            目前資料_.縮寫 = this.縮寫.Text;

            目前資料_.大類 = (物品大類資料)(this.大類.SelectedValue);
            目前資料_.小類 = (物品小類資料)(this.小類.SelectedValue);
            目前資料_.品牌 = (物品品牌資料)(this.品牌.SelectedValue);

            目前資料_.條碼 = this.條碼.Text;
            目前資料_.原廠編號 = this.原廠編號.Text;
            目前資料_.代理編號 = this.代理編號.Text;

            目前資料_.體積 = (int)(this.體積.Value);
            目前資料_.顏色 = this.顏色.Text;

            目前資料_.內庫數量 = (int)(this.內庫數量.Value);
            目前資料_.外庫數量 = (int)(this.外庫數量.Value);

            目前資料_.庫存總成本 = this.庫存總成本.Value;
            目前資料_.最後進貨成本 = this.最後進貨成本.Value;
            目前資料_.成本備註 = this.成本備註.Text;
        }

        public override void 索引切換_更新呈現()
        {
            物品資料 目前資料_ = (物品資料)(this.頁索引元件1.目前資料);

            this.名稱.Text = 目前資料_.名稱;
            this.縮寫.Text = 目前資料_.縮寫;

            this.大類.SelectedValue = 目前資料_.大類;
            this.小類.SelectedValue = 目前資料_.小類;
            this.品牌.SelectedValue = 目前資料_.品牌;

            this.條碼.Text = 目前資料_.條碼;
            this.原廠編號.Text = 目前資料_.原廠編號;
            this.代理編號.Text = 目前資料_.代理編號;

            this.體積.Value = 目前資料_.體積;
            this.顏色.Text = 目前資料_.顏色;

            this.內庫數量.Value = 目前資料_.內庫數量;
            this.外庫數量.Value = 目前資料_.外庫數量;
            this.庫存總量.Value = 目前資料_.庫存總量;

            this.庫存總成本.Value = 目前資料_.庫存總成本;
            this.最後進貨成本.Value = 目前資料_.最後進貨成本;
            this.成本.Value = 目前資料_.成本;
            this.成本備註.Text = 目前資料_.成本備註;
        }
    }
}
