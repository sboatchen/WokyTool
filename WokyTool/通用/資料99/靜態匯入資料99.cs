using LinqToExcel;
using LinqToExcel.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    //@@@ 待整理
    public abstract class 靜態匯入資料 : 可匯入資料
    {
        virtual public void 初始化(){;}

        static public IEnumerable<T> 匯入Excel<T>() where T : 靜態匯入資料
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                yield return null;
            else
            {
                ExcelQueryFactory Excel_ = null;
                ExcelQueryable<T> Source_ = null;
                try
                {
                    // 備份
                    檔案.備份(openFileDialog1.FileName, openFileDialog1.FileName, "匯入", typeof(T).Name);

                    Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                    Source_ = Excel_.Worksheet<T>();
                }
                catch (Exception ex)
                {
                    訊息管理器.獨體.錯誤("開啟檔案失敗", ex);

                    if (Excel_ != null)
                        Excel_.Dispose();

                    throw ex;
                }

                foreach (var Item_ in Source_)
                {
                    Item_.初始化();
                    yield return Item_;
                }

                if (Excel_ != null)
                    Excel_.Dispose();
            }
        }
    }
}
