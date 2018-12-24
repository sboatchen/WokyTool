using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.月結帳
{
    public class 月結帳會計資料管理器 : 資料管理器<月結帳會計資料>
    {
        public override string 檔案路徑
        {
            get
            {
                return "進度/月結帳會計.json";
            }
        }

        public override 月結帳會計資料 空白資料
        {
            get
            {
                return 月結帳會計資料.NULL;
            }
        }

        public override 月結帳會計資料 錯誤資料
        {
            get
            {
                return 月結帳會計資料.ERROR;
            }
        }

        public override 列舉.編號 編號類型
        {
            get
            {
                return 列舉.編號.月結帳會計;
            }
        }

        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.匯入月結帳;
            }
        }

        // 獨體
        private static readonly 月結帳會計資料管理器 _獨體 = new 月結帳會計資料管理器();
        public static 月結帳會計資料管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        // 建構子
        private 月結帳會計資料管理器()
        {
        }

        public void 更新(IGrouping<月結帳匯入設定資料, 月結帳資料> x)
        {
            月結帳匯入設定資料 設定_ = x.Key;
            if (設定_ == null)
                訊息管理器.獨體.Error("找不到月結帳設定資料");

            月結帳會計資料 Item_ = Map.Values
                                    .Where(Value => Value.設定 == 設定_)
                                    .FirstOrDefault();

            if (Item_ != null)
            {
                Item_.資料列 = x.Select(Value => Value);

                資料異動();
            } 
            else
            {
                Item_ = new 月結帳會計資料();
                Item_.設定 = 設定_;
                Item_.資料列 = x.Select(Value => Value);

                新增(Item_);
            }
        }
    }
}
