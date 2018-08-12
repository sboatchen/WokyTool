﻿using System;
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
using WokyTool.DataMgr;

namespace WokyTool.FormOther
{
    public partial class 銷售篩選視窗 : Form, 子視窗<銷售資料_編輯>
    {
        protected 父視窗<銷售資料_編輯> _父視窗 = null;

        protected 監測綁定更新<廠商資料> _廠商資料Listener;

        public 銷售篩選視窗(父視窗<銷售資料_編輯> Parent_)
        {
            InitializeComponent();

            this._父視窗 = Parent_;
            this.button1.Enabled = (Parent_ != null);

            _廠商資料Listener = new 監測綁定更新<廠商資料>(廠商管理器.Instance.Binding, 舊列舉.監測類型.被動通知_值, 廠商資料更新);
            _廠商資料Listener.Refresh(true);
        }

        private void 廠商資料更新(IEnumerable<廠商資料> Data_)
        {
            this.comboBox1.DataSource = Data_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._父視窗.onClickFilter(this);
        }
        
        public bool IsVisible()
        {
            return this.Visible;
        }

        private void 銷售篩選視窗_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            if (this._父視窗 != null)
                this._父視窗.onChildClosing(this);
        }

        public IEnumerable<銷售資料_編輯> Filt(IEnumerable<銷售資料_編輯> Query_)
        {
            IEnumerable<銷售資料_編輯> Source_ = Query_;

            DateTime StartTime_ = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0, 0, 0, 0);
            DateTime EndTime_ = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 23, 59, 59, 0);

            Source_ = Source_.Where(Value => (Value.建立日期 >= StartTime_ && Value.建立日期 <= EndTime_));

            if(this.comboBox1.SelectedIndex > 0){
                string value = (string)this.comboBox1.SelectedValue;
                Source_ = Source_.Where(Value => (Value.廠商.CompareTo(value) == 0));
            }

            return Source_;
        }
    }
}
