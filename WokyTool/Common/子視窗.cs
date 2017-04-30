using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 子視窗
    {
        void SetParentForm(父視窗 Parent_);

        void Show();
        void BringToFront();
        void Close();
    }
}
