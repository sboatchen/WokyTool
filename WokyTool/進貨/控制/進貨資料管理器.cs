using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.進貨
{
    public class 進貨資料管理器 : 資料統合管理器<進貨資料, 進貨新增資料>
    {
        public override string 檔案路徑 
        {
            get 
            {
                return "進度/進貨.json"; 
            } 
        }

        public override string 讀取路徑
        {
            get
            {
                return "進度/進貨";
            }
        }

        public override 進貨資料 空白資料
        {
            get
            {
                return 進貨資料.NULL;
            }
        }

        public override 進貨資料 錯誤資料
        {
            get 
            {
                return 進貨資料.ERROR; 
            } 
        }

        public override 列舉.編號 編號類型
        { 
            get 
            { 
                return 列舉.編號.進貨; 
            } 
        }

        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.修改設定資料;
            }
        }

        // 獨體
        private static readonly 進貨資料管理器 _獨體 = new 進貨資料管理器();
        public static 進貨資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 進貨資料管理器()
        {
        }

        protected override 進貨資料 轉化讀取資料(進貨新增資料 新增資料_)
        {
            return new 進貨資料
            {
                狀態 = 列舉.進貨處理狀態.新增,
                時間 = 新增資料_.時間,

                類型 = 新增資料_.類型,

                廠商 = 新增資料_.廠商,

                物品 = 新增資料_.物品,

                數量 = 新增資料_.數量,
                單價 = 新增資料_.單價,

                幣值 = 新增資料_.幣值,

                成本 = 0,
                成本備註 = 新增資料_.物品.成本備註,

                備註 = 新增資料_.備註,
            };
        }
    }
}
