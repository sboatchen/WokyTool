﻿using Newtonsoft.Json;

namespace WokyTool.通用
{
    public abstract class 基本資料
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public string ToString(bool 是否縮排_)
        {
            if (是否縮排_)
                return JsonConvert.SerializeObject(this, Formatting.Indented);
            else
                return JsonConvert.SerializeObject(this, Formatting.None);
        }

        public virtual void 檢查合法()  //@@@ remove
        {
        }

        public object 淺複製()
        {
            return this.MemberwiseClone();
        }
    }
}
