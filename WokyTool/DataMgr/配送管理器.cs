using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.DataMgr
{
    class 配送管理器
    {
        // 資料Map
        public List<可配送> List { get; private set; }

        // 獨體
        private static readonly 配送管理器 _Instance = new 配送管理器();
        public static 配送管理器 Instance
        {
            get
            {
                return _Instance;
            }
        }

         // 建構子
        private 配送管理器()
        {
            List = new List<可配送>();
        }

        // 新增資料
        public void Add(可配送 Item_)
        {
            List.Add(Item_);
        }

        // 移除已配送完成的資料
        public void RemoveDeliverd()
        {
            List = List.Where(Value => Value.是否已配送() == false).ToList();
        }

    }
}
