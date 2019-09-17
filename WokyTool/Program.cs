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
         * 物品
         * 商品
         * 配送
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
         * 各資料通用匯出處理        [可匯出匯入(匯出 = true, 匯入 = false)]
         * 配送撿貨統計輸出
         * 
         * 商品編號 + 子序號 -> 改用 類別 + 顏色 處理
         * 訊息管理氣.錯誤  使處理 直接結束
         * 
         * 
重購 儲存管理器 like 更新管理器

可編輯列舉資料管理介面 -> 可編輯資料管理介面
可清單列舉資料管理介面 -> 可選取資料管理介面
刪除 可管理資料管理器, 可列舉資料來源管理介面, 可列舉資料管理介面

         * 
         * 一般視窗/匯入視窗 隱藏/關閉 close 邏輯是否合理 測試
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
         * 
         * 
         * 
         * 
         * 
         * 視窗管理器
         * public override 通用視窗介面 取得篩選視窗實體
        {
            get
            {
                var 視窗_ = new 商品更新篩選視窗(資料管理器.視窗篩選器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public override 通用視窗介面 取得詳細視窗實體 
        {
            get
            {
                var 視窗_ = new 商品更新詳細視窗(資料管理器);
                視窗_.初始化();
                return 視窗_;
            } 
        }
		
		            var 視窗_ = new 聯絡人更新視窗();
            視窗_.初始化();
            視窗_.Show();
            視窗_.BringToFront();
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 平台訂單匯入處理_Momo第三方
				
				平台訂單匯入處理_生活市集
				平台訂單匯入處理_生活市集_超商
				平台訂單匯入處理_松果
				平台訂單匯入處理_松果_超商
				
			
			寄庫商品成本
			
			扣庫存時間點
         * 
         * 
         * 
         * 生活市集 還是 松果 有一個 廠配 + 回單 未處理

        */

    }
}
