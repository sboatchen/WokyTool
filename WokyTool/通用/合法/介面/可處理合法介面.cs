using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可處理合法介面
    {
        bool 是否合法 { get;  }

        void 錯誤(基本資料 資料_, string 訊息_);
    }
}
