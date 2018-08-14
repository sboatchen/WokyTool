using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.使用者;

namespace WokyTool.通用
{
    public class 訊息管理器
    {
        private ILog logger = null;

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
            if (使用者資料管理器.獨體.使用者.編號是否合法())
                on登入(使用者資料管理器.獨體.使用者);
            else
                使用者資料管理器.獨體.登入事件管理器 += on登入;
        }

        protected void on登入(使用者資料 使用者_)
        {
            String Name_ = 使用者_.名稱;
            if(String.IsNullOrEmpty(Name_))
                Name_ = System.Environment.MachineName;

            // 設定 log4net 參數
            Environment.SetEnvironmentVariable("WokyLog", Name_);

            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            使用者資料管理器.獨體.登入事件管理器 -= on登入;
        }

        public void Error(object message)
        {
            if (logger != null)
            {
                logger.Error(message);
                logger.Error(Environment.StackTrace);
            }

            MessageBox.Show(message.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Error(Exception exception)
        {
            if (logger != null)
            {
                logger.Error(exception.Message, exception);
            }

            MessageBox.Show(exception.Message, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Error(object message, Exception exception)
        {
            if (logger != null)
            {
                logger.Error(message, exception);
            }

            MessageBox.Show(message.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warn(object message)
        {
            if (logger != null)
            {
                logger.Warn(message);
                logger.Error(Environment.StackTrace);
            }

            MessageBox.Show(message.ToString(), 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warn(Exception exception)
        {
            if (logger != null)
            {
                logger.Warn(exception.Message, exception);
            }

            MessageBox.Show(exception.Message.ToString(), 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warn(object message, Exception exception)
        {
            if (logger != null)
            {
                logger.Warn(message, exception);
            }

            MessageBox.Show(message.ToString(), 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Debug(object message, bool trace = false)
        {
            if (logger != null)
            {
                logger.Debug(message);

                if (trace)
                    logger.Debug(Environment.StackTrace);
            }

            Console.WriteLine(message);
        }

        public void Info(object message, bool trace = false)
        {
            if (logger != null)
            {
                logger.Info(message);

                if (trace)
                    logger.Info(Environment.StackTrace);
            }

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
