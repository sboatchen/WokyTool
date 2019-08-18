using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public interface 通用視窗介面
    {
        void 顯現();
        void 顯現(int 編號_);   //@@ remove

        void 隱藏();
        void 關閉();

        bool 是否顯現 { get; }
    }
}
