﻿
namespace WokyTool.通用
{
    public interface 通用視窗介面 : 可初始化介面
    {
        void 顯現();
        void 顯現(int 編號_);

        void 隱藏();
        void 關閉();

        bool 是否顯現 { get; }
    }
}
