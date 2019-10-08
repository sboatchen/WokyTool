using WokyTool.通用;

namespace WokyTool.物品
{
    public partial class 物品更新篩選視窗 : 新增篩選視窗
    {
        // 介面編輯呈現用
        public 物品更新篩選視窗() : base()
        {
            InitializeComponent();
        }

        public 物品更新篩選視窗(視窗可篩選介面 視窗篩選器_) : base(視窗篩選器_)
        {
            InitializeComponent();
        }

        public override void 初始化()
        {
            大類.初始化();
            小類.初始化();
            品牌.初始化();

            base.初始化();

            資料綁定(this.更新狀態, "更新狀態");

            資料綁定(this.名稱, "文字");
            資料綁定(this.類別, "類別");
            資料綁定(this.顏色, "顏色");

            資料綁定(this.國際條碼, "國際條碼");

            資料綁定(this.大類, "大類");
            資料綁定(this.小類, "小類");
            資料綁定(this.品牌, "品牌");

            資料綁定(this.最小庫存, "最小庫存");
            資料綁定(this.最大庫存, "最大庫存");

            資料綁定(this.儲位, "儲位");
        }
    }
}
