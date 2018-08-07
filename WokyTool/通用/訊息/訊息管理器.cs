using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public class 訊息管理器
    {
        private ILog logger = null;

        public String _使用者 = null;
        public String 使用者
        {
            get
            {
                return _使用者;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                    value = "共用";

                if(value.CompareTo(_使用者) == 0)
                    return;

                _使用者 = value;

                // 設定 log4net 參數
                Environment.SetEnvironmentVariable("WokyLog", _使用者);

                logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            }
        }

        // 獨體
        private static readonly 訊息管理器 _獨體 = new 訊息管理器();
        public static 訊息管理器 獨體
        {
            get
            {
                return _獨體;
            }
        }

        private 訊息管理器()
        {
            if(String.IsNullOrEmpty(使用者))
                使用者 = "共用";
        }

        public void Error(object message)
        {
            logger.Error(message);
            logger.Error(Environment.StackTrace);

            MessageBox.Show(message.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Error(Exception exception)
        {
            logger.Error(exception.Message, exception);

            MessageBox.Show(exception.Message, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Error(object message, Exception exception)
        {
            logger.Error(message, exception);

            MessageBox.Show(message.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warn(object message)
        {
            logger.Warn(message);
            logger.Error(Environment.StackTrace);

            MessageBox.Show(message.ToString(), 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warn(Exception exception)
        {
            logger.Warn(exception.Message, exception);

            MessageBox.Show(exception.Message.ToString(), 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warn(object message, Exception exception)
        {
            logger.Warn(message, exception);

            MessageBox.Show(message.ToString(), 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Debug(object message, bool trace = false)
        {
            logger.Debug(message);

            if(trace)
                logger.Debug(Environment.StackTrace);

            Console.WriteLine(message);
        }

        public void Info(object message, bool trace = false)
        {
            logger.Info(message);

            if (trace)
                logger.Info(Environment.StackTrace);

            Console.WriteLine(message);
        }

        public void Notify(object message)
        {
            MessageBox.Show(message.ToString(), 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool Check(String title, object message)
        {
            var result = MessageBox.Show(message.ToString(), title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
    }
}
