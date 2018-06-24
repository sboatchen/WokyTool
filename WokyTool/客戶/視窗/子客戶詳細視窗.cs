using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.聯絡人;

namespace WokyTool.客戶
{
    public partial class 子客戶詳細視窗 : Form
    {
        private System.Windows.Forms.BindingSource 子客戶資料BindingSource;

        private int _聯絡人資料版本;

        private 子客戶資料 _目前資料;
        private List<聯絡人資料> _目前聯絡人資料;
        private BindingList<聯絡人資料> _目前聯絡人綁定資料;
        private bool _是否修改聯絡人資料;

        public 子客戶詳細視窗()
        {
            InitializeComponent();

            this.子客戶資料BindingSource = new System.Windows.Forms.BindingSource();
            this.子客戶資料BindingSource.DataSource = 子客戶資料管理器.獨體.BList;

            this.姓名DataGridViewTextBoxColumn.DataSource = 聯絡人資料管理器.獨體.BList;
            _聯絡人資料版本 = 聯絡人資料管理器.獨體.BindingVersion;

            _目前資料 = null;
            _目前聯絡人資料 = new List<聯絡人資料>();
            _是否修改聯絡人資料 = false;

            _目前聯絡人綁定資料 = new BindingList<聯絡人資料>(_目前聯絡人資料);
            this.dataGridView1.DataSource = _目前聯絡人綁定資料;
        }

        private void 下一個_Click(object sender, EventArgs e)
        {
            if (子客戶資料BindingSource.Position+1 >= 子客戶資料BindingSource.Count)
                子客戶資料BindingSource.MoveFirst();
            else
                子客戶資料BindingSource.MoveNext();

            this.Invalidate();
        }

        private void 上一個_Click(object sender, EventArgs e)
        {
            if (子客戶資料BindingSource.Position == 0)
                子客戶資料BindingSource.MoveLast();
            else
                子客戶資料BindingSource.MovePrevious();

            this.Invalidate();
        }

        private void 子客戶詳細視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            儲存修改();

            this.Hide();
            e.Cancel = true;
        }

        private void 子客戶詳細視窗_Activated(object sender, EventArgs e)
        {
            if (_聯絡人資料版本 != 聯絡人資料管理器.獨體.BindingVersion)
            {
                _聯絡人資料版本 = 聯絡人資料管理器.獨體.BindingVersion;
                this.姓名DataGridViewTextBoxColumn.DataSource = 聯絡人資料管理器.獨體.BList;
                更新聯絡人列表();
            }
        }

        int i = 0;
        private void 子客戶詳細視窗_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine(++i);
            子客戶資料 Now_ = (子客戶資料)(子客戶資料BindingSource.Current);
            if (Now_ == _目前資料)
                return;

            Console.WriteLine(i + "-go");

            儲存修改();

            _目前資料 = Now_;

            更新聯絡人列表();

            this.名稱.Text = _目前資料.名稱;
            this.索引.Text = String.Format("{0} of {1}", 子客戶資料BindingSource.Position + 1, 子客戶資料BindingSource.Count);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                _是否修改聯絡人資料 = true;

                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged -= LastColumnComboSelectionChanged;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            _是否修改聯絡人資料 = true;
        }

        /********************************/

        private void 儲存修改()
        {
            if (_目前資料 != null && (_是否修改聯絡人資料 == true))
            {
                _目前資料.名稱 = this.名稱.Text;
                _目前資料.更新聯絡人資料(_目前聯絡人資料);
                _是否修改聯絡人資料 = false;
            }
        }

        private void 更新聯絡人列表()
        {
            _目前聯絡人資料.Clear();
            if (_目前資料.聯絡人編號列 != null)
            {
                foreach (int value_ in _目前資料.聯絡人編號列)
                {
                    聯絡人資料 聯絡人資料_ = 聯絡人資料管理器.獨體.Get(value_);
                    _目前聯絡人資料.Add(聯絡人資料_);
                }
            }
            _目前聯絡人綁定資料.ResetBindings();
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            聯絡人資料 聯絡人資料_ = (聯絡人資料)((ComboBox)sender).SelectedItem;
            if (聯絡人資料_ == null)
                return;

            int index = dataGridView1.CurrentCell.RowIndex;
            //_目前聯絡人資料[index].覆蓋(聯絡人資料_);
            _目前聯絡人資料[index] = 聯絡人資料_;

            //_目前聯絡人綁定資料.ResetBindings();

            dataGridView1.Invalidate();
        }

        public void 設定索引(int 位置_)
        {
            this.子客戶資料BindingSource.Position = 位置_;
            this.Invalidate();
        }
    }
}
