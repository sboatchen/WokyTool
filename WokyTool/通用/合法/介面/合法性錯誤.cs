using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public class 合法性錯誤 : Exception
    {
        public 合法性錯誤(string message) : base(message)
        {
        }
    }
}
