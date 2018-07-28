using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public class 視窗隱藏事件 : FormClosingEventArgs
    {
        public 視窗隱藏事件() : base(CloseReason.UserClosing, false)
        {
        }
    }
}
