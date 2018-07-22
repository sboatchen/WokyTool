using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public class 時間
    {
        protected static bool _IsCacheDirty = true;

        public static DateTime NULL = new DateTime(0);

        protected static DateTime _今天;
        public static DateTime 今天
        {
            get 
            {
                更新時間快取();
                return _今天;
            }
        }

        protected static DateTime _明天;
        public static DateTime 明天
        {
            get
            {
                更新時間快取();
                return _明天;
            }
        }

        protected static DateTime _五天後;
        public static DateTime 五天後
        {
            get
            {
                更新時間快取();
                return _五天後;
            }
        }

        //("yyyyMMdd")
        protected static string _目前日期;
        public static string 目前日期
        {
            get
            {
                更新時間快取();
                return _目前日期;
            }
        }

        //("yyyy/MM/dd")
        protected static string _目前日期_斜線;
        public static string 目前日期_斜線
        {
            get
            {
                更新時間快取();
                return _目前日期_斜線;
            }
        }

        public static string 目前時間
        {
            get
            {
                return DateTime.Now.ToString("yyyyMMdd_HHmmss");
            }
        }

        protected static void 更新時間快取()
        {
            if (_IsCacheDirty == false)
                return;
            _IsCacheDirty = false;

            Console.WriteLine("更新時間快取:" + DateTime.Now.ToString());

            _今天 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, 0);
            _目前日期 = _今天.ToString("yyyyMMdd");
            _目前日期_斜線 = _今天.ToString("yyyy/MM/dd");

            _明天 = _今天.AddDays(1);

            _五天後 = _今天.AddDays(5);

            // 計算失效時間
            int 至明天午夜所需時間_ = (int)_明天.Subtract(DateTime.Now).TotalMilliseconds + 10000;  // 避免不精準，取過10秒的點
            int 快取有效時間_ = Math.Min(30000, 至明天午夜所需時間_);

            TimerCallback callback = new TimerCallback(時間快取失效);
            Timer timer = new Timer(callback, null, 快取有效時間_, System.Threading.Timeout.Infinite);
        }

        private static void 時間快取失效(object obj)
        {
            Console.WriteLine("時間快取失效:" + DateTime.Now.ToString());
            _IsCacheDirty = true;
        }
    }
}
