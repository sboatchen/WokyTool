using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可列舉資料管理介面
    {
        object 資料列舉 { get; }

        int 資料版本 { get; }
    }
}
