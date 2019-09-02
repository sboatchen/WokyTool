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

    public partial class 商品篩選視窗 : 新版篩選視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.商品; } }

        public override 視窗可篩選介面 視窗篩選器 { get { return 商品資料管理器.獨體.編輯管理器.視窗篩選器; } }

        public 商品篩選視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            base.初始化();

            資料綁定(this.名稱, "文字");
            資料綁定(this.品號, "品號");

            資料綁定(this.大類, "大類");
            資料綁定(this.小類, "小類");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.公司, "公司");
            資料綁定(this.客戶, "客戶");


            資料綁定(this.最小寄庫數量, "最小寄庫數量");
            資料綁定(this.最大寄庫數量, "最大寄庫數量");

            資料綁定(this.最小利潤, "最小利潤");
            資料綁定(this.最大利潤, "最大利潤");
        }
    }
}

