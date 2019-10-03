using log4net;
using System;
using System.Text;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.使用者;
using WokyTool.參數;

namespace WokyTool.通用
{
    public class 訊息管理器
    {
        private ILog logger = null;

        private StringBuilder _SB = new StringBuilder();

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
            if (使用者資料管理器.獨體 == null)
            {
                MessageBox.Show("訊息管理器初始化失敗", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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

            var 參數初始化 = 參數資料管理器.獨體;

            // 設定 log4net 參數
            Environment.SetEnvironmentVariable("WokyLogPath", 系統參數.訊息路徑);
            Environment.SetEnvironmentVariable("WokyLog", Name_);

            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            使用者資料管理器.獨體.登入事件管理器 -= on登入;
        }

        public void 錯誤(object 內容_)
        {
            if (logger != null)
            {
                logger.Error(內容_);
                logger.Error(Environment.StackTrace);
            }

            _SB.Clear();
            _SB.AppendLine(內容_.ToString());
            _SB.AppendLine(Environment.StackTrace);

            MessageBox.Show(_SB.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void 錯誤(Exception Ex_)
        {
            if (logger != null)
            {
                logger.Error(Ex_.Message, Ex_);
                logger.Error(Environment.StackTrace);
            }

            _SB.Clear();
            _SB.AppendLine(Ex_.Message);
            _SB.AppendLine(Environment.StackTrace);

            MessageBox.Show(_SB.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void 錯誤(object 內容_, Exception Ex_)
        {
            if (logger != null)
            {
                logger.Error(內容_, Ex_);
                logger.Error(Environment.StackTrace);
            }

            _SB.Clear();
            _SB.AppendLine(內容_.ToString());
            _SB.AppendLine(Ex_.Message);
            _SB.AppendLine(Environment.StackTrace);

            MessageBox.Show(_SB.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void 警告(object 內容_)
        {
            if (logger != null)
            {
                logger.Warn(內容_);
                logger.Warn(Environment.StackTrace);
            }

            _SB.Clear();
            _SB.AppendLine(內容_.ToString());
            _SB.AppendLine(Environment.StackTrace);

            MessageBox.Show(_SB.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void 警告(Exception Ex_)
        {
            if (logger != null)
            {
                logger.Warn(Ex_.Message, Ex_);
                logger.Warn(Environment.StackTrace);
            }

            _SB.Clear();
            _SB.AppendLine(Ex_.Message);
            _SB.AppendLine(Environment.StackTrace);

            MessageBox.Show(_SB.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void 警告(object 內容_, Exception Ex_)
        {
            if (logger != null)
            {
                logger.Warn(內容_, Ex_);
                logger.Warn(Environment.StackTrace);
            }

            _SB.Clear();
            _SB.AppendLine(內容_.ToString());
            _SB.AppendLine(Ex_.Message);
            _SB.AppendLine(Environment.StackTrace);

            MessageBox.Show(_SB.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void 追蹤(object 內容_, bool 是否記錄堆疊_ = false)
        {
            if (logger != null)
            {
                logger.Debug(內容_);

                if (是否記錄堆疊_)
                    logger.Debug(Environment.StackTrace);
            }

            Console.WriteLine(內容_);
        }

        public void 訊息(object 內容_, bool 是否記錄堆疊_ = false)
        {
            if (logger != null)
            {
                logger.Info(內容_);

                if (是否記錄堆疊_)
                    logger.Info(Environment.StackTrace);
            }

            Console.WriteLine(內容_);
        }

        public void 通知(object 內容_)
        {
            MessageBox.Show(內容_.ToString(), 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (logger != null)
                logger.Info(內容_);
        }

        public void 通知(String 標題_, object 內容_)
        {
            MessageBox.Show(內容_.ToString(), 標題_, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool 確認(String 標題_, object 內容_)
        {
            var result = MessageBox.Show(內容_.ToString(), 標題_, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
    }
}
