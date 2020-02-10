using System;
using System.Collections.Generic;
using System.Drawing;

namespace WokyTool.通用
{
    public class 顏色
    {
        protected static List<Color> _RandomColorList = null;

        public static Color GetRandomColor(int Value_)
        {
            if (_RandomColorList == null)
            {
                _RandomColorList = new List<Color>();
                _RandomColorList.Add(Color.FromArgb(170,170,255));
                _RandomColorList.Add(Color.FromArgb(204,255,128));
                _RandomColorList.Add(Color.FromArgb(196,136,136));
                _RandomColorList.Add(Color.FromArgb(255,81,81));
                _RandomColorList.Add(Color.FromArgb(132,193,255));
                _RandomColorList.Add(Color.FromArgb(255,255,147));
                _RandomColorList.Add(Color.FromArgb(185,185,115));
                _RandomColorList.Add(Color.FromArgb(255,149,202));
                _RandomColorList.Add(Color.FromArgb(166,255,255));
                _RandomColorList.Add(Color.FromArgb(255,230,111));
                _RandomColorList.Add(Color.FromArgb(129,192,192));
                _RandomColorList.Add(Color.FromArgb(255,142,255));
                _RandomColorList.Add(Color.FromArgb(150,254,209));
                _RandomColorList.Add(Color.FromArgb(255,199,142));
                _RandomColorList.Add(Color.FromArgb(166,166,210));
                _RandomColorList.Add(Color.FromArgb(202,142,255));
                _RandomColorList.Add(Color.FromArgb(147,255,147));
                _RandomColorList.Add(Color.FromArgb(255,173,134));
                _RandomColorList.Add(Color.FromArgb(192,122,184));
            }

            if (Value_ == 0)
                return Color.White;
            return _RandomColorList[Math.Abs(Value_) % _RandomColorList.Count];
        }
    }
}
