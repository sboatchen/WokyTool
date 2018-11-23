using System;
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
        public static void 備份資料檔案(string 原始檔案路徑_, bool 是否忽略缺少原始檔案_)
        {
            if (File.Exists(原始檔案路徑_) == false)
            {
                if (是否忽略缺少原始檔案_)
                    return;
                throw new Exception("備份失敗,找不到原始檔案:" + 原始檔案路徑_);
            }

            string 原始路徑_ = Path.GetDirectoryName(原始檔案路徑_);
            string 原始檔案名稱_ = Path.GetFileNameWithoutExtension(原始檔案路徑_);
            string 原始檔案副檔名_ = Path.GetExtension(原始檔案路徑_);

            //@@ 加入使用者名稱
            string 備份檔案_ = String.Format("{0}_{1}{2}", 原始檔案名稱_, 時間.目前時間, 原始檔案副檔名_);
            string 備份路徑_ = System.IO.Path.Combine("備份", 時間.目前日期, 原始路徑_);
            string 備份檔案路徑_ = System.IO.Path.Combine(備份路徑_, 備份檔案_);

            // 檢查備份路徑是否存在
            if (Directory.Exists(備份路徑_) == false)
            {
                Directory.CreateDirectory(備份路徑_);
            }

            // 檢查備份檔案是否存在
            if (File.Exists(備份檔案路徑_))
            {
                throw new Exception("備份失敗,檔案已存在:" + 備份檔案路徑_);
            }

            File.Copy(原始檔案路徑_, 備份檔案路徑_);
        }

        public static void 備份資料檔案(string 原始檔案路徑_)
        {
            備份資料檔案(原始檔案路徑_, false);
        }

        public static void 備份匯入檔案(string 原始檔案路徑_, string 備份資料夾名_, string 備份檔名_)
        {
            if (File.Exists(原始檔案路徑_) == false)
                throw new Exception("備份失敗,找不到原始檔案:" + 原始檔案路徑_);

            string 原始檔案名稱_ = Path.GetFileNameWithoutExtension(原始檔案路徑_);
            string 原始檔案副檔名_ = Path.GetExtension(原始檔案路徑_);

            //@@ 加入使用者名稱
            string 備份檔案_ = String.Format("{0}_{1}{2}", Path.GetFileNameWithoutExtension(備份檔名_), 時間.目前時間, 原始檔案副檔名_);
            string 備份路徑_ = System.IO.Path.Combine("備份", 時間.目前日期, "匯入", 備份資料夾名_);
            string 備份檔案路徑_ = System.IO.Path.Combine(備份路徑_, 備份檔案_);

            // 檢查備份路徑是否存在
            if (Directory.Exists(備份路徑_) == false)
            {
                Directory.CreateDirectory(備份路徑_);
            }

            // 檢查備份檔案是否存在
            if (File.Exists(備份檔案路徑_))
            {
                throw new Exception("備份失敗,檔案已存在:" + 備份檔案路徑_);
            }

            File.Copy(原始檔案路徑_, 備份檔案路徑_);
        }

        public static void 備份匯入檔案(string 原始檔案路徑_, string 備份檔名_)
        {
            string 備份資料夾名_ = Path.GetFileNameWithoutExtension(備份檔名_);

            備份匯入檔案(原始檔案路徑_, 備份資料夾名_, 備份檔名_);
        }

        public static void 寫入加密檔案(string 目標檔案路徑_, string 資料_)
        {
            string password = @"ApTx4869";
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);

            using (FileStream fsCrypt = new FileStream(目標檔案路徑_, FileMode.OpenOrCreate, FileAccess.Write))
            {
                RijndaelManaged RMCrypto = new RijndaelManaged();

                using (CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write))
                {

                    // convert string to stream
                    byte[] byteArray = Encoding.UTF8.GetBytes(資料_);

                    cs.Write(byteArray, 0, byteArray.Length);
                }
            }
        }

        public static void 寫入檔案(string 目標檔案路徑_, string 資料_, bool 是否加密)
        {
            String Path_ = Path.GetDirectoryName(目標檔案路徑_);

            // 檢查備份路徑是否存在
            if (Directory.Exists(Path_) == false)
            {
                Directory.CreateDirectory(Path_);
            }

            if (是否加密)
                寫入加密檔案(目標檔案路徑_, 資料_);
            else
                File.WriteAllText(目標檔案路徑_, 資料_);
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
