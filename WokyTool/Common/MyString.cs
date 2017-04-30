using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public class MyString
    {
        public string data{get; set;}

        public MyString(string data) { this.data = data; }

        public bool Contains(char item){ return data.Contains(item); }
        
        public override string ToString(){ return data;}
    }
}
