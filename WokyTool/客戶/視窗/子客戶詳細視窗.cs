using WokyTool.通用;

namespace WokyTool.客戶
{
    public partial class 子客戶詳細視窗 : 獨體詳細視窗
    {
        public override 列舉.編號 編號類型 { get { return 列舉.編號.子客戶; } }

        public override 可編輯列舉資料管理介面 編輯管理器 { get { return 子客戶資料管理器.獨體.編輯管理器; } }
        public override 新版頁索引元件 頁索引 { get { return this.新版頁索引元件1; } }


        public 子客戶詳細視窗()
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            客戶.初始化();

            base.初始化();

            資料綁定(this.名稱, "名稱");
            資料綁定(this.客戶, "客戶");
        }

        protected override void 選擇改變()
        {
            this.聯絡人資料BindingSource.DataSource = ((子客戶資料)(this.資料BS.Current)).聯絡人列舉;
        }
    }
}
