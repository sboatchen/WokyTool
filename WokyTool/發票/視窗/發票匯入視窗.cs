using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.客戶;
using WokyTool.發票;
using WokyTool.通用;

namespace WokyTool.發票
{
    public partial class 發票匯入視窗 : 匯入視窗
    {
        protected 發票匯入管理器 _發票匯入管理器 = new 發票匯入管理器();

        public 發票匯入視窗()
        {
            InitializeComponent();

            this.初始化(發票匯入資料BindingSource, _發票匯入管理器);
        }

        private void 樣板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            函式.GetFile("發票匯入範本", "樣板/發票/樣板.xlsx");
        }

        private void 匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _發票匯入管理器.新增(發票匯入設定資料.獨體.匯入Excel<發票匯入資料>(new 發票匯入轉換(), true));
            if (_發票匯入管理器.是否正在編輯() == false)
                return;

            this.匯入ToolStripMenuItem.Enabled = false;

            this.OnActivated(null);
        }

        private void 檢查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            更新資料合法性();
        }

        private void 匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _資料管理器.檢查合法();
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.Notify(ex.Message);
                return;
            }

            var Groups_ = _發票匯入管理器.可編輯BList
                                .OrderBy(Value => Value.發票號碼)
                                .GroupBy(Value => Value.發票字軌);  // 若原始檔中有兩種字軌 字軌需分開存檔

            int 最小數值_ = -1;
            int 目標數值_ = -1;
            int 最大數值_ = -1;
            發票匯出轉換 輸出_ = new 發票匯出轉換();
            String 字軌_ = null;
            foreach (var Group_ in Groups_)
            {
                字軌_ = Group_.Key;
                最小數值_ = -1;
                目標數值_ = -1;
                最大數值_ = -1;
                輸出_.清除();

                foreach(var Item_ in Group_)
                {
                    // 取得每群的第一個
                    if(目標數值_ == -1)
                    {
                        最小數值_ = Item_.發票數值 / 100 * 100; //移除後面兩位 補00
                        最大數值_ = 最小數值_ + 49; // 發票號碼每50個號碼分成一個檔案
                        目標數值_ = 最小數值_;
                    }

                    // 發票號碼需順號 → 如有跳號(B欄寫上”空白”) A欄需補上號碼
                    // 目標發票號碼小於預定數值
                    while(目標數值_ < Item_.發票數值 && 目標數值_ <= 最大數值_)
                    {
                        輸出_.新增(發票匯入資料.空白(字軌_ + 目標數值_));
                        目標數值_++;
                    }

                    // 找到對應的發票
                    if(目標數值_ == Item_.發票數值 && 目標數值_ <= 最大數值_)
                    {
                        輸出_.新增(Item_);
                        目標數值_++;
                    }

                    // 已達最大數值,進行結算
                    if(目標數值_ > 最大數值_)
                    {
                        string Title_ = String.Format("{0}{1}_{0}{2}", 字軌_, 最小數值_, 最大數值_);  // 檔名為a欄第一個號碼-a欄最後一個號碼, 範例: FX40239300-FX40239349

                        檔案.寫入Excel(Title_, 輸出_);

                        最小數值_ = 最大數值_ + 1;
                        最大數值_ = 最小數值_ + 49;
                        目標數值_ = 最小數值_;
                        輸出_.清除();
                    }
                }

                // 尾數資料
                if(輸出_.資料數量 != 0)
                {
                    string Title_ = String.Format("{0}{1}_{0}{2}", 字軌_, 最小數值_, 目標數值_ - 1);  // 最後一個檔案尾數為檔案裡的最後一個號碼不一定為49或99
                    檔案.寫入Excel(Title_, 輸出_);
                }
            }

            訊息管理器.獨體.Notify("處理完畢");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /********************************/

        protected override void 視窗激活()
        {
        }

        protected override void 視窗關閉()
        {
        }
    }
}
