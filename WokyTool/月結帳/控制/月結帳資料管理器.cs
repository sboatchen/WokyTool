using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳資料管理器 : 資料管理器<月結帳資料>
    {
        public override string 檔案路徑
        {
            get
            {
                return "進度/月結帳.json";
            }
        }

        public override 月結帳資料 空白資料
        {
            get
            {
                return 月結帳資料.NULL;
            }
        }

        public override 月結帳資料 錯誤資料
        {
            get
            {
                return 月結帳資料.ERROR;
            }
        }

        public override 列舉.編號 編號類型
        {
            get
            {
                return 列舉.編號.月結帳;
            }
        }

        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.是否允許修改基本資料;
            }
        }

        // 獨體
        private static readonly 月結帳資料管理器 _獨體 = new 月結帳資料管理器();
        public static 月結帳資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 月結帳資料管理器()
        {
        }
    }
}
