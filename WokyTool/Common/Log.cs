using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.Common
{
    public class Log
    {

        public static void Trace(String Data_)
        {
 
        }

        public static void Debug(String Data_)
        {

        }

        public static void Info(String Data_)
        {

        }

        public static void Warn(String Data_)
        {
            MessageBox.Show(Data_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Error(String Data_)
        {
            MessageBox.Show(Data_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Fatal(String Data_)
        {
            MessageBox.Show(Data_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Notify(String Data_)
        {
            MessageBox.Show(Data_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
