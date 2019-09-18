using System;
using WokyTool.客戶;

namespace WokyTool.測試
{
    [Serializable]
    public class 序列化測試資料
    {
        public string 字串 { get; set; }
        public int 整數 { get; set; }

        [NonSerialized]
        private float _浮點數;
        public float 浮點數 { get { return _浮點數; } set { _浮點數 = value; } }

        [NonSerialized]
        private 客戶資料 _客戶;
        public 客戶資料 客戶 { get { return _客戶; } set { _客戶 = value; } }

        public 客戶資料 客戶2 { get; set; }
    }
}
