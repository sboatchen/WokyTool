﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.通用;

namespace WokyTool.物品
{
    public class 物品小類資料篩選 : 通用可篩選介面<物品小類資料>
    {
        private string _名稱 = null;
        public string 名稱
        {
            get { return _名稱; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    value = null;

                if (_名稱 != value)
                {
                    _名稱 = value;
                    篩選版本++;
                }
            }
        }

        public override bool 是否篩選
        {
            get
            {
                return
                    null != 名稱;
            }
        }

        public override IEnumerable<物品小類資料> 篩選(IEnumerable<物品小類資料> 資料列舉_)
        {
            IEnumerable<物品小類資料> 目前列舉_ = 資料列舉_;

            if (null != 名稱)
                目前列舉_ = 目前列舉_.Where(Value => Value.名稱.Contains(名稱));

            return 目前列舉_;
        }
    }
}
