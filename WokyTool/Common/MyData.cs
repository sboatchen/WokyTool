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

        // 如果不合法 回傳訊息
        public virtual string 檢查合法()
        {
            return null;
        }
    }
}
