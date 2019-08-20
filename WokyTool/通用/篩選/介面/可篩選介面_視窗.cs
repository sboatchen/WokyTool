using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 可篩選介面_視窗
    {
        string 排序欄位 { get; set; }

        bool 是否排序 { get; }
        bool 是否篩選 { get; }

        string 文字 { get; set; }
    }
}
