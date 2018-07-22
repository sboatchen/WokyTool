using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokyTool.通用
{
    public class 檔案
    {
        public static void 備份(string 原始檔案路徑_, bool 是否忽略缺少原始檔案_)
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

            string 備份檔案_ = String.Format("{0}_{1}{2}", 原始檔案名稱_, 時間.目前時間, 原始檔案副檔名_);
            string 備份路徑_ = System.IO.Path.Combine("備份", 原始路徑_);
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

        public static void 備份(string 原始檔案路徑_)
        {
            備份(原始檔案路徑_, false);
        }
    }
}
