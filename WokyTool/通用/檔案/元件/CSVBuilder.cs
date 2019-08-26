using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace WokyTool.通用
{
    public class CSVBuilder
    {
        private string _分格號;
        private StringBuilder _SB;

        public StringBuilder SB { get { return _SB; } }

        public CSVBuilder(string 分格號_ = ",")
        {
            this._分格號 = 分格號_;
            this._SB = new StringBuilder();
        }


        public void 重置(string 分格號_)
        {
            this._分格號 = 分格號_;
            this._SB.Clear();
        }

        public override string ToString()
        {
            return _SB.ToString();
        }

        public CSVBuilder 加入標頭(string 標頭_, bool 是否換行_ = false)
        {
            if (是否換行_)
                _SB.Append(標頭_).AppendLine();
            else
                _SB.Append(標頭_).Append(_分格號);

            return this;
        }

        public void 加入標頭(params string[] 標頭列_)
        {
            bool 是否非第一個 = false;
            foreach (string 標頭_ in 標頭列_)
            {
                if(是否非第一個)
                    _SB.Append(_分格號);

                _SB.Append(標頭_);

                是否非第一個 = true;
            }

            _SB.AppendLine();
        }

        public CSVBuilder 加入(string 內容_, bool 是否換行_ = false)
        {
            if (是否換行_)
                _SB.Append("\"").Append(內容_).Append("\"").AppendLine();
            else
                _SB.Append("\"").Append(內容_).Append("\"").Append(_分格號);

            return this;
        }

        public CSVBuilder 加入(object 內容_, bool 是否換行_ = false)
        {
            if (是否換行_)
                _SB.Append(內容_).AppendLine();
            else
                _SB.Append(內容_).Append(_分格號);

            return this;
        }

        public void 加入(params object[] 內容列_)
        {
            bool 是否非第一個 = false;
            foreach (object 內容_ in 內容列_)
            {
                if (是否非第一個)
                    _SB.Append(_分格號);

                if (內容_ is string)
                    _SB.Append("\"").Append(內容_).Append("\"");
                else
                     _SB.Append(內容_);

                是否非第一個 = true;
            }

            _SB.AppendLine();
        }
    }
}
