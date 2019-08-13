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
using WokyTool.商品;
using WokyTool.客戶;
using WokyTool.通用;
using WokyTool.物品;

namespace WokyTool.月結帳{

    public partial class 月結帳篩選視窗 : 篩選視窗
    {
        protected 月結帳資料篩選設定 _篩選設定 = new 月結帳資料篩選設定();

        public 月結帳篩選視窗()
        {
            InitializeComponent();

            this.初始化();
        }

        protected override void 視窗激活()
        {
            this.客戶選取元件1.視窗激活();

            //@@ 目前無法解決資料更新時 會預設選第一個當值
            this.公司選取元件1.SelectedItem = _篩選設定.公司;
            this.客戶選取元件1.SelectedItem = _篩選設定.客戶;
        }

        private void 篩選_Click(object sender, EventArgs e)
        {
            _篩選設定.公司 = (公司資料)(this.公司選取元件1.SelectedItem);
            _篩選設定.客戶 = (客戶資料)(this.客戶選取元件1.SelectedItem);

            if (_篩選設定.是否需篩選() == true)
                月結帳資料管理器.獨體.篩選介面 = _篩選設定;
            else
                月結帳資料管理器.獨體.篩選介面 = null;
        }
    }
}
