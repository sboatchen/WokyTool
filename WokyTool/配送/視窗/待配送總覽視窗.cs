using LINQtoCSV;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.平台訂單;
using WokyTool.物品;
using WokyTool.配送;
using WokyTool.通用;

namespace WokyTool.配送
{
    public partial class 待配送總覽視窗 : 總覽視窗
    {
        // 匯出暫存
        private List<全速配匯出結構> _Export1 = new List<全速配匯出結構>();
        private List<宅配通匯出結構> _Export2 = new List<宅配通匯出結構>();

        public 待配送總覽視窗()
        {
            InitializeComponent();

            this.初始化(this.可配送資料BindingSource, 配送管理器.獨體);

            this.指配時段DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.指配時段));
            this.代收方式DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.代收方式));
            this.配送公司DataGridViewTextBoxColumn.DataSource = Enum.GetValues(typeof(列舉.配送公司));

            // 預設關掉匯入
            this.全速配ToolStripMenuItem.Enabled = false;
            this.宅配通ToolStripMenuItem.Enabled = false;
        }

        private void 略過ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (this.dataGridView1.SelectedRows.Count != 0)
            {
                _Source.Remove((可配送)this.dataGridView1.SelectedRows[0].DataBoundItem);
                _Binding.ResetBindings(true);
            }*/

            訊息管理器.獨體.Notify("功能目前不支援");
        }

        private void 全速配ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int x = 1;
            _Export1 = 配送管理器.獨體.可編輯BList
                                .Where(Value => Value.配送公司 == 列舉.配送公司.全速配)
                                .Select(Value => new 全速配匯出結構(x++, Value))
                                .ToList();

            string Title_ = String.Format("全速配匯出_{0}", 時間.目前日期);
            函式.ExportCSV<全速配匯出結構>(Title_, _Export1);

            // 如果有資料匯出，則鎖定不再允許匯出，並開放匯入
            if (_Export1.Count > 0)
            {
                this.全速配ToolStripMenuItem1.Enabled = false;
                this.全速配ToolStripMenuItem.Enabled = true;
            }

        }

        private void 宅配通ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _Export2 = 配送管理器.獨體.可編輯BList
                                .Where(Value => Value.配送公司 == 列舉.配送公司.宅配通)
                                .Select(Value => new 宅配通匯出結構(Value))
                                .ToList();

            string Title_ = String.Format("宅配通匯出_{0}", 時間.目前日期);
            函式.ExportExcel<宅配通匯出結構>(Title_, _Export2);

            // 如果有資料匯出，則鎖定不再允許匯出，並開放匯入
            if (_Export2.Count > 0)
            {
                this.宅配通ToolStripMenuItem1.Enabled = false;
                this.宅配通ToolStripMenuItem.Enabled = true;
            }
        }

        private void 全速配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var List_ = 全速配匯入資料.匯入Excel<全速配匯入資料>().ToList();
            if (List_ == null || List_.Count == 0)
                return;

            // 檢查資料數是否一致
            if (List_.Count() != _Export1.Count)
            {
                訊息管理器.獨體.Notify("資料筆數不符合");
                return;
            }

            bool IsRight_ = true;
            for (int i = 0; i < _Export1.Count; i++)
            {
                if (_Export1[i].設定配送單號(List_[i]) == false)
                {
                    訊息管理器.獨體.Notify("資料內容不符合, 筆數: " + i);
                    IsRight_ = false;
                    break;
                }
            }
            if (IsRight_ == false)
            {
                foreach (var Item_ in _Export1)
                {
                    Item_.清除配送單號();
                }
                return;
            }

            // 清除暫存，並關閉匯入
            _Export1.Clear();
            this.全速配ToolStripMenuItem.Enabled = false;

            配送管理器.獨體.完成編輯(true);

            平台訂單新增資料管理器.獨體.資料異動();  //@@ 目前沒想到好方法 通知更新

            this.OnActivated(null);
        }

        private void 宅配通ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var List_ = 宅配通匯入資料.匯入Excel<宅配通匯入資料>().ToList();
            if (List_ == null || List_.Count == 0)
                return;

            // 檢查資料數是否一致
            if (List_.Count() != _Export2.Count)
            {
                訊息管理器.獨體.Notify("資料筆數不符合");
                return;
            }

            bool IsRight_ = true;
            for (int i = 0; i < _Export2.Count; i++)
            {
                if (_Export2[i].設定配送單號(List_[i]) == false)
                {
                    訊息管理器.獨體.Notify("資料內容不符合, 筆數: " + i);
                    IsRight_ = false;
                    break;
                }
            }
            if (IsRight_ == false)
            {
                foreach (var Item_ in _Export1)
                {
                    Item_.清除配送單號();
                }
                return;
            }

            // 清除暫存，並關閉匯入
            _Export1.Clear();
            this.全速配ToolStripMenuItem.Enabled = false;

            配送管理器.獨體.完成編輯(true);

            平台訂單新增資料管理器.獨體.資料異動();  //@@ 目前沒想到好方法 通知更新

            this.OnActivated(null);
        }

        private void 測試用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (var Item_ in 配送管理器.獨體.可編輯BList)
            {
                Item_.配送單號 = String.Format("宅配回單測試{0}", i++);
            }

            配送管理器.獨體.完成編輯(true);

            平台訂單新增資料管理器.獨體.資料異動();  //@@ 目前沒想到好方法 通知更新

            this.OnActivated(null);
        }

        private void 統計ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 撿貨匯出轉換
            Dictionary<物品資料, 撿貨資料> Map_ = new Dictionary<物品資料, 撿貨資料>();

            撿貨資料 Temp_ = null;
            foreach (var Item_ in 配送管理器.獨體.可編輯BList)
            {
                foreach (var ItemPair_ in Item_.合併.Map)
                {
                    if (Map_.TryGetValue(ItemPair_.Key, out Temp_))
                    {
                        Temp_.數量 += ItemPair_.Value;
                    }
                    else
                    {
                        Temp_ = new 撿貨資料(ItemPair_.Key.縮寫, ItemPair_.Value);
                        Map_.Add(ItemPair_.Key, Temp_);
                    }
                }
            }

            撿貨匯出轉換 Result_ = new 撿貨匯出轉換(Map_.Values.OrderBy(Value => Value.物品名稱));

            string Title_ = String.Format("撿貨統計匯出_{0}", 時間.目前日期);
            檔案.寫入Excel(Title_, Result_);
        }
    }
}
