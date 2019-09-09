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
    public partial class 配送新增總覽視窗 : 更新總覽視窗
    {
        public override Type 資料類型 { get { return typeof(配送轉換資料); } }

        public override 可編輯列舉資料管理介面 更新管理器 { get { return 配送轉換資料管理器.獨體; } }

        public override MyDataGridView 資料GV { get { return this.myDataGridView1; } }
        public override ToolStripMenuItem 樣板MI { get { return null; } }
        public override ToolStripMenuItem 篩選MI { get { return this.篩選ToolStripMenuItem; } }
        public override ToolStripMenuItem 檢查MI { get { return this.檢查ToolStripMenuItem; } }

        public override 通用視窗介面 取得篩選視窗實體
        {
            get
            {
                var 視窗_ = new 配送新增篩選視窗(配送轉換資料管理器.獨體.視窗篩選器);
                視窗_.初始化();
                return 視窗_;
            }
        }

        public override 通用視窗介面 取得詳細視窗實體
        {
            get
            {
                var 視窗_ = new 配送新增詳細視窗(配送轉換資料管理器.獨體);
                視窗_.初始化();
                return 視窗_;
            }
        }

        private void 測試用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (var Item_ in 配送管理器.獨體.可編輯BList)
            {
                Item_.配送單號 = String.Format("宅配回單測試{0}", i++);
            }

            配送管理器.獨體.完成編輯(true);

            //@@平台訂單新增資料管理器.獨體.資料異動();  //@@ 目前沒想到好方法 通知更新

            this.OnActivated(null);
        }

        private void 全速配匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 全速配匯出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 全速配撿貨ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 全速配明細ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 宅配通匯出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 宅配通匯入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 宅配通撿貨ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 宅配通明細ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 匯出暫存
        private List<全速配匯出結構> _Export1 = new List<全速配匯出結構>();
        private List<宅配通匯出結構> _Export2 = new List<宅配通匯出結構>();

        public 配送新增總覽視窗()
        {
            InitializeComponent();
        }

        private void 全速配ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int x = 1;
            _Export1 = 配送管理器.獨體.可編輯BList
                                .Where(Value => Value.配送公司 == 列舉.配送公司.全速配)
                                .Select(Value => new 全速配匯出結構(x++, Value))
                                .ToList();

            string Title_ = String.Format("全速配匯出_{0}", 時間.目前日期);
            舊函式.ExportCSV<全速配匯出結構>(Title_, _Export1);

            // 如果有資料匯出，則鎖定不再允許匯出，並開放匯入
            /*@@if (_Export1.Count > 0)
            {
                this.全速配ToolStripMenuItem1.Enabled = false;
                this.全速配ToolStripMenuItem.Enabled = true;
            }*/

            配送明細轉換 轉換_ = new 配送明細轉換("全速配", 配送管理器.獨體.可編輯BList.Where(Value => Value.配送公司 == 列舉.配送公司.全速配));
            string 標題_ = String.Format("全速配明細匯出_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");

        }

        private void 宅配通ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _Export2 = 配送管理器.獨體.可編輯BList
                                .Where(Value => Value.配送公司 == 列舉.配送公司.宅配通)
                                .Select(Value => new 宅配通匯出結構(Value))
                                .ToList();

            string Title_ = String.Format("宅配通匯出_{0}", 時間.目前日期);
            舊函式.ExportExcel<宅配通匯出結構>(Title_, _Export2);

            // 如果有資料匯出，則鎖定不再允許匯出，並開放匯入
            /*@@if (_Export2.Count > 0)
            {
                this.宅配通ToolStripMenuItem1.Enabled = false;
                this.宅配通ToolStripMenuItem.Enabled = true;
            }*/

            配送明細轉換 轉換_ = new 配送明細轉換("宅配通", 配送管理器.獨體.可編輯BList.Where(Value => Value.配送公司 == 列舉.配送公司.宅配通));
            string 標題_ = String.Format("宅配通明細匯出_{0}", 時間.目前日期);
            檔案.詢問並寫入(標題_, 轉換_);

            訊息管理器.獨體.通知("匯出完成");
        }

        private void 全速配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var List_ = 全速配匯入資料.匯入Excel<全速配匯入資料>().ToList();
            if (List_ == null || List_.Count == 0)
                return;

            // 檢查資料數是否一致
            if (List_.Count() != _Export1.Count)
            {
                訊息管理器.獨體.通知("資料筆數不符合");
                return;
            }

            bool IsRight_ = true;
            for (int i = 0; i < _Export1.Count; i++)
            {
                if (_Export1[i].設定配送單號(List_[i]) == false)
                {
                    訊息管理器.獨體.通知("資料內容不符合, 筆數: " + i);
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

            //@@平台訂單新增資料管理器.獨體.資料異動();  //@@ 目前沒想到好方法 通知更新

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
                訊息管理器.獨體.通知("資料筆數不符合");
                return;
            }

            bool IsRight_ = true;
            for (int i = 0; i < _Export2.Count; i++)
            {
                if (_Export2[i].設定配送單號(List_[i]) == false)
                {
                    訊息管理器.獨體.通知("資料內容不符合, 筆數: " + i);
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

            //@@平台訂單新增資料管理器.獨體.資料異動();  //@@ 目前沒想到好方法 通知更新

            this.OnActivated(null);
        }
    }
}
