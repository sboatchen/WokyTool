using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokyTool.通用
{
    public class 資料列選取插件<T> where T : MyKeepableData<T>
    {
        private 資料管理器<T> _資料管理器;
        private System.Windows.Forms.DataGridView _DataGridView;
        private int _欄位;

        private List<int> _編號列;
        public List<int> 編號列
        {
            get
            {
                Update();
                return _編號列;
            }
        }

        private bool _是否修改資料;
        private List<T> _資料列;

        private System.Windows.Forms.BindingSource _資料BindingSource;
        private BindingList<T> _綁定資料;

        public 資料列選取插件(資料管理器<T> 資料管理器_, System.Windows.Forms.BindingSource 資料BindingSource_, System.Windows.Forms.DataGridView DataGridView_, int 欄位_)
        {
            _資料管理器 = 資料管理器_;
            _資料BindingSource = 資料BindingSource_;
            _DataGridView = DataGridView_;
            _欄位 = 欄位_;

            _是否修改資料 = false;
            _編號列 = null;
            _資料列 = new List<T>();

            _綁定資料 = new BindingList<T>(_資料列);
            _資料BindingSource.DataSource = _綁定資料;

            _DataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            //_DataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
        }

        public void 綁定(List<int> 編號列_)
        {
            _是否修改資料 = false;
            _編號列 = 編號列_;

            刷新();
        }

        public void 刷新()
        {
            _資料列.Clear();
            if (_編號列 != null)
            {
                foreach (int value_ in _編號列)
                {
                    T 資料_ = _資料管理器.Get(value_);
                    _資料列.Add(資料_);
                }
            }

            _綁定資料.ResetBindings();
        }

        public bool ReadOnly
        {
            get
            {
                return _綁定資料.AllowNew == false;
            }

            set
            {
                _綁定資料.AllowNew = !value;
                _綁定資料.AllowEdit = !value;
                _綁定資料.AllowRemove = !value;
            }
        }

        /********************************/

        private void Update()
        {
            // 檢查刪除
            int 原本數量_ = 0;
            if (_編號列 != null)
                原本數量_ = _編號列.Count;

            if (_是否修改資料 == false && 原本數量_ == _資料列.Count)
                return;
            _是否修改資料 = false;
            
            if (_資料列.Count == 0)
            {
                _編號列 = null;
                return;
            }

            if (_編號列 != null)
                _編號列.Clear();
            else
                _編號列 = new List<int>();

            foreach (T Item_ in _資料列)
            {
                _編號列.Add(Item_.編號);
            }
        }

        //private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{
        //    _是否修改資料 = true;
        //}

        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (_DataGridView.CurrentCell.ColumnIndex == _欄位 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged -= LastColumnComboSelectionChanged;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }
        }

        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            T 資料_ = (T)((ComboBox)sender).SelectedItem;
            if (資料_ == null)
                return;

            //@@ combobox 目前會預設選之前的那一個
            int index = _DataGridView.CurrentCell.RowIndex;
            //if( _資料列[index] == 資料_)
            //    return;

            _資料列[index] = 資料_;

            _是否修改資料 = true;
            _DataGridView.Invalidate();
        }
    }
}
