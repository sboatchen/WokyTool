using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public interface 可編輯列舉資料管理介面 : 可清單列舉資料管理介面
    {
        bool 是否可編輯 { get; }
        bool 是否編輯中 { get; }

        void 完成編輯(bool 是否紀錄_);

        BindingSource 公用BS { get; }

        void 合法檢查(可檢查介面 檢查器_);
    }
}
