using LinqToExcel;
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
    public abstract class MyUpdateData: MyData
    {
        virtual public void 初始化(){;}

        abstract public void 更新();

        static public BindingList<T> 匯入Excel<T>() where T : MyUpdateData
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return null;

            try
            {
                var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                var Source_ = Excel_.Worksheet<T>();
                BindingList<T> BList_ = new BindingList<T>();

                foreach (var Item_ in Source_)
                {
                    Item_.初始化();
                    BList_.Add(Item_);
                }

                return BList_;
            }
            catch (Exception Error_)
            {
                MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }
    }
}
