using System.Windows.Forms;

namespace WokyTool.通用
{
    public class MyDataGridView : DataGridView
    {
        public void 凍結()
        {
            this.ProcessTabKey(Keys.Tab);
            this.ProcessTabKey(Keys.Tab | Keys.Shift);
        }
    }
}
