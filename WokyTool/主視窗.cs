using LINQtoCSV;
using LinqToExcel;
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
using WokyTool.Data;
using WokyTool.DataForm;
using WokyTool.DataImport;
using WokyTool.DataMgr;
using WokyTool.ImportForm;
using WokyTool.OtherForm;

namespace WokyTool
{
    public partial class 主視窗 : Form
    {
        public 主視窗()
        {
            InitializeComponent();
        }

        private void 主視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            編碼管理器.Instance.SaveData();
            幣值管理器.Instance.SaveData();

            廠商管理器.Instance.SaveData();

            物品大類管理器.Instance.SaveData();
            物品小類管理器.Instance.SaveData();
            物品品牌管理器.Instance.SaveData();
            物品管理器.Instance.SaveData();

            商品大類管理器.Instance.SaveData();
            商品小類管理器.Instance.SaveData();
            商品管理器.Instance.SaveData();

            //月結帳管理器.Instance.SaveData();

            進貨管理器.Instance.SaveData();
            雜支管理器.Instance.SaveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var i = new 編碼總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var i = new 廠商總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var i = new 物品大類總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var i = new 物品小類總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //@@ 搬進去
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                    var i = new 物品匯入視窗(Excel_);
                    i.Show();
                    i.BringToFront();

                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var i = new 物品總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var i = new 商品大類總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var i = new 商品小類總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var i = new 商品總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                    var i = new 商品匯入視窗(Excel_);
                    i.Show();
                    i.BringToFront();

                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var i = new 月結帳總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                    var Query_ = Excel_.Worksheet<月結帳匯入結構_Momo>()
                                        .Select(Value => Value.ToData());

                    var i = new 月結帳匯入視窗(Query_);
                    i.Show();
                    i.BringToFront();

                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var i = new 物品品牌總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var i = new 進貨總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                    var i = new 進貨匯入視窗(Excel_);
                    i.Show();
                    i.BringToFront();

                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var i = new 雜支總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                    var i = new 雜支匯入視窗(Excel_);
                    i.Show();
                    i.BringToFront();

                }
                catch (Exception Error_)
                {
                    MessageBox.Show("開啟檔案失敗" + Error_.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var i = new 支出總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var i = new 幣值總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var i = new 待處理配送總覽視窗();
            i.Show();
            i.BringToFront();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var i = new 出貨匯入視窗();
            i.Show();
            i.BringToFront();
        }
    }
}
