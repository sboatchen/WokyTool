using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public interface 父視窗
    {
        void onChildClosing(子視窗 Child_);

        void onUpdateDataSource(Object DataSource_);
    }
}
