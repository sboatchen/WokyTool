using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品總覽更新匯入管理器 : 匯入資料管理器<物品總覽更新匯入資料>
    {
        public override bool 是否可編輯
        {
            get
            {
                return 系統參數.修改設定資料;
            }
        }

        protected override void 匯入()
        {
            物品資料管理器.獨體.Map.Clear();

            int 下個編號_ = 物品資料管理器.獨體.下個編號;

            物品總覽更新匯入資料 錯誤快取_ = null;
            try
            {
                foreach (物品總覽更新匯入資料 Data_ in 可編輯BList)
                {
                    錯誤快取_ = Data_;

                    switch (Data_.更新狀態)
                    {
                        case 列舉.更新狀態.新增:
                            Data_.物品.編號 = 下個編號_;
                            下個編號_++;
                            物品資料管理器.獨體.Map.Add(Data_.物品.編號, Data_.物品);
                            break;
                        case 列舉.更新狀態.更新:
                        case 列舉.更新狀態.相同:
                            物品資料管理器.獨體.Map.Add(Data_.物品.編號, Data_.物品);
                            break;
                        case 列舉.更新狀態.刪除:
                            break;
                        default:
                            訊息管理器.獨體.錯誤("無法辨識物品總覽更新資料 " + Data_.ToString());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.錯誤(ex);
                訊息管理器.獨體.錯誤(錯誤快取_.物品名稱);
                throw ex;
            }

            物品資料管理器.獨體.資料搬移();
        }
    }
}
