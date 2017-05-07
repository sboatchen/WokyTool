using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 子視窗<T>
    {
        bool IsVisible();

        void Show();
        void BringToFront();
        void Close();

        IEnumerable<T> Filt(IEnumerable<T> Query_);
    }
}
