using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 可讀出_CSV<T>
    {
        List<T> 讀出(String 內容_);
    }
}
