﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public partial class 檔案
    {
        public static string 增加檔名後綴(string 路徑_, params string[] 後綴s_)
        {
            string 副檔名_ = Path.GetExtension(路徑_);
            int 長度_ = 路徑_.Length - 副檔名_.Length;

            StringBuilder SB_ = new StringBuilder(路徑_.Substring(0, 長度_));
            foreach (String 後綴_ in 後綴s_)
            {
                if (String.IsNullOrEmpty(後綴_) == false)
                    SB_.Append("_").Append(後綴_);
            }

            SB_.Append(副檔名_);

            return SB_.ToString();
        }

        public static string 取得備份檔名(string 路徑_)
        {
            string 檔名_ = Path.GetFileNameWithoutExtension(路徑_);
            string 副檔名_ = Path.GetExtension(路徑_);

            return String.Format("{0}_{1}_{2}{3}", 時間.目前時間, 系統參數.使用者, 檔名_, 副檔名_);
        }

        public static string 取得備份檔名(string 路徑_, string 指定檔名_)
        {
            string 副檔名_ = Path.GetExtension(路徑_);

            return String.Format("{0}_{1}_{2}{3}", 時間.目前時間, 系統參數.使用者, 指定檔名_, 副檔名_);
        }

        public static string 取得備份資料夾(string 路徑_, string[] 額外資料夾_ = null)
        {
            List<string> list_ = new List<string>();
            list_.Add("備份");
            list_.Add(時間.目前日期);

            string 資料夾_ = Path.GetDirectoryName(路徑_);
            Boolean 是否為相對路徑_ = 資料夾_.Contains(':') == false;
            if (是否為相對路徑_)
                list_.Add(資料夾_);

            if (null != 額外資料夾_ && 額外資料夾_.Length > 0)
                list_.AddRange(額外資料夾_);

            return System.IO.Path.Combine(list_.ToArray());
        }

        public static bool 刪除(string 路徑_)
        {
            try
            {
                File.Delete(路徑_);
                return true;
            }
            catch (IOException e)
            {
                訊息管理器.獨體.Warn("刪除檔案失敗: " + 路徑_, e);
                return false;
            }
        }

        public static bool 搬移(string 原始路徑_, string 目標路徑_)
        {
            try
            {
                // 檢查原始檔案是否存在
                if (File.Exists(原始路徑_) == false)
                    throw new Exception("找不到原始檔案");

                // 檢查目標檔案是否存在
                if (File.Exists(目標路徑_))
                    throw new Exception("目標檔案已存在:" + 目標路徑_);

                File.Move(原始路徑_, 目標路徑_);

                return true;
            }
            catch (IOException e)
            {
                訊息管理器.獨體.Warn("搬移檔案失敗: " + 原始路徑_, e);
                return false;
            }
        }

        public static bool 搬移(string 原始路徑_)
        {
            try
            {
                // 檢查原始檔案是否存在
                if (File.Exists(原始路徑_) == false)
                    throw new Exception("找不到原始檔案");

                string 目標檔名_ = 取得備份檔名(原始路徑_);
                string 目標資料夾_ = 取得備份資料夾(原始路徑_);
                string 目標路徑_ = System.IO.Path.Combine(目標資料夾_, 目標檔名_);

                // 檢查目標資料夾是否存在
                if (Directory.Exists(目標資料夾_) == false)
                    Directory.CreateDirectory(目標資料夾_);
                // 檢查目標檔案是否存在
                else if (File.Exists(目標路徑_))
                    throw new Exception("檔案已存在:" + 目標路徑_);

                File.Move(原始路徑_, 目標路徑_);

                return true;
            }
            catch (IOException e)
            {
                訊息管理器.獨體.Warn("搬移檔案失敗: " + 原始路徑_, e);
                return false;
            }
        }

        public static bool 備份(string 原始路徑_, bool 忽略缺少原始檔案錯誤_ = false)
        {
            try
            {
                // 檢查原始檔案是否存在
                if (File.Exists(原始路徑_) == false)
                {
                    if (忽略缺少原始檔案錯誤_)
                        return true;
                    throw new Exception("找不到原始檔案");
                }

                string 目標檔名_ = 取得備份檔名(原始路徑_);
                string 目標資料夾_ = 取得備份資料夾(原始路徑_);
                string 目標路徑_ = System.IO.Path.Combine(目標資料夾_, 目標檔名_);

                // 檢查目標資料夾是否存在
                if (Directory.Exists(目標資料夾_) == false)
                    Directory.CreateDirectory(目標資料夾_);
                // 檢查目標檔案是否存在
                else if (File.Exists(目標路徑_))
                    throw new Exception("檔案已存在:" + 目標路徑_);

                File.Copy(原始路徑_, 目標路徑_);

                return true;
            }
            catch (IOException e)
            {
                訊息管理器.獨體.Warn("備份檔案失敗: " + 原始路徑_, e);
                return false;
            }
        }

        public static bool 備份(string 原始路徑_, string 指定檔名_, params string[] 指定資料夾_)
        {
            try
            {
                // 檢查原始檔案是否存在
                if (File.Exists(原始路徑_) == false)
                    throw new Exception("找不到原始檔案");

                string 目標檔名_ = 取得備份檔名(原始路徑_, 指定檔名_);
                string 目標資料夾_ = 取得備份資料夾(原始路徑_, 指定資料夾_);
                string 目標路徑_ = System.IO.Path.Combine(目標資料夾_, 目標檔名_);

                // 檢查目標資料夾是否存在
                if (Directory.Exists(目標資料夾_) == false)
                    Directory.CreateDirectory(目標資料夾_);
                // 檢查目標檔案是否存在
                else if (File.Exists(目標路徑_))
                    throw new Exception("檔案已存在:" + 目標路徑_);

                File.Copy(原始路徑_, 目標路徑_);

                return true;
            }
            catch (IOException e)
            {
                訊息管理器.獨體.Warn("備份檔案失敗: " + 原始路徑_, e);
                return false;
            }
        }

        public static bool 存檔(string 路徑_, string 資料_)
        {
            String 資料夾_ = Path.GetDirectoryName(路徑_);

            // 檢查資料夾是否存在
            if (Directory.Exists(資料夾_) == false)
                Directory.CreateDirectory(資料夾_);

            File.WriteAllText(路徑_, 資料_);

            return true;
        }

        public static bool 存檔(string 路徑_, string 資料_, string 密碼_)
        {
            if (String.IsNullOrEmpty(密碼_))
                return 存檔(路徑_, 資料_);

            String 資料夾_ = Path.GetDirectoryName(路徑_);

            // 檢查資料夾是否存在
            if (Directory.Exists(資料夾_) == false)
                Directory.CreateDirectory(資料夾_);

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(密碼_);

            using (FileStream fsCrypt = new FileStream(路徑_, FileMode.OpenOrCreate, FileAccess.Write))
            {
                // clean file
                fsCrypt.SetLength(0);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                using (CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write))
                {
                    // convert string to stream
                    byte[] byteArray = Encoding.UTF8.GetBytes(資料_);

                    cs.Write(byteArray, 0, byteArray.Length);
                }
            }
        }



        public static string 讀出加密檔案(string 目標檔案路徑_)
        {
            string password = @"ApTx4869";
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);

            using (FileStream fsCrypt = new FileStream(目標檔案路徑_, FileMode.Open, FileAccess.Read))
            {
                RijndaelManaged RMCrypto = new RijndaelManaged();

                using( CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, key), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
        }

        public static string 讀出檔案(string 目標檔案路徑_, bool 是否加密)
        {
            if (是否加密)
                return 讀出加密檔案(目標檔案路徑_);
            else
                return File.ReadAllText(目標檔案路徑_);
        }
    }
}
