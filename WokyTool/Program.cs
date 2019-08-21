using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.使用者;
using WokyTool.通用;

namespace WokyTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] param)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Common.共用.Init();

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            
            /*using (var 登入視窗_ = new 登入視窗())
            {
                if (登入視窗_.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new 主視窗());
                }
            }*/

            使用者資料管理器.獨體.登入("root", "Aptx4869");
            Application.Run(new 主視窗());
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            訊息管理器.獨體.錯誤(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            訊息管理器.獨體.錯誤(e.ExceptionObject as Exception);
        }

        /*
         * 已完成
         * 
         * 使用者
         * 公司
         * 聯絡人
         * 客戶
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 代處理
         * 
         * 訊息管理器.獨體.錯誤 VS EXCEPTION
         * 
         * 
         * bindingsource c# DataBindings DateTimePicker
         * 資料編輯詳細測試視窗
         * 資料編輯總覽測試視窗
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
        */

    }
}
