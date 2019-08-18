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

namespace WokyTool.商品{

    public partial class 商品篩選視窗 : 篩選視窗
    {
        protected 商品資料篩選設定 _商品資料篩選設定 = new 商品資料篩選設定();

        public 商品篩選視窗()
        {
            InitializeComponent();

            this.初始化();
        }

        protected override void 視窗激活()
        {
            this.商品大類選取元件1.視窗激活();
            this.商品小類選取元件1.視窗激活();
            //@@@this.客戶選取元件1.視窗激活();
            this.物品選取元件1.視窗激活();

            //@@ 目前無法解決資料更新時 會預設選第一個當值
            this.商品大類選取元件1.SelectedItem = _商品資料篩選設定.大類;
            this.商品小類選取元件1.SelectedItem = _商品資料篩選設定.小類;
            this.公司選取元件1.SelectedItem = _商品資料篩選設定.公司;
            this.客戶選取元件1.SelectedItem = _商品資料篩選設定.客戶;
            this.物品選取元件1.SelectedItem = _商品資料篩選設定.物品;
        }

        private void 篩選_Click(object sender, EventArgs e)
        {
            _商品資料篩選設定.名稱 = this.名稱.Text;
            _商品資料篩選設定.品號 = this.品號.Text;

            _商品資料篩選設定.大類 = (商品大類資料)(this.商品大類選取元件1.SelectedItem);
            _商品資料篩選設定.小類 = (商品小類資料)(this.商品小類選取元件1.SelectedItem);

            _商品資料篩選設定.公司 = (公司資料)(this.公司選取元件1.SelectedItem);
            _商品資料篩選設定.客戶 = (客戶資料)(this.客戶選取元件1.SelectedItem);

            _商品資料篩選設定.物品 = (物品資料)(this.物品選取元件1.SelectedItem);

            Console.WriteLine("無意義，單純為了避免combobox咬死");

            if (_商品資料篩選設定.是否需篩選() == true)
                商品資料管理器.獨體.篩選介面 = _商品資料篩選設定;
            else
                商品資料管理器.獨體.篩選介面 = null;
        }
    }
}
