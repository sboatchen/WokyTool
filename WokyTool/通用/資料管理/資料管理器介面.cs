using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 資料管理器介面
    {
         // 資料BindingList
        object 物件_可編輯BList { get; }

        Boolean IsEditing();

        void UpdateEdit(bool IsSave_);
    }
}
