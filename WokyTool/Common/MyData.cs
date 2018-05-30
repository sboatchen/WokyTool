using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.Common
{
    public class MyData
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public virtual object 拷貝()
        {
            throw new Exception("Not support copy");
        }

        public virtual void 檢查合法()
        {
        }
    }
}
