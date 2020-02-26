using WokyTool.單品;
using WokyTool.通用;
namespace WokyTool.一般訂單
{
    partial class 一般訂單新增詳細視窗
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.新版頁索引元件1 = new WokyTool.通用.新版頁索引元件();
            this.label14 = new System.Windows.Forms.Label();
            this.代收金額 = new System.Windows.Forms.NumericUpDown();
            this.代收方式 = new WokyTool.通用.代收方式選取元件();
            this.指配時段 = new WokyTool.通用.指配時段選取元件();
            this.指配日期 = new WokyTool.通用.MyDateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.手機 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.電話 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.地址 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.姓名 = new System.Windows.Forms.TextBox();
            this.客戶 = new WokyTool.客戶.客戶選取元件();
            this.公司 = new WokyTool.公司.公司選取元件();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.子客戶 = new WokyTool.客戶.子客戶選取元件();
            this.label7 = new System.Windows.Forms.Label();
            this.聯絡人 = new WokyTool.聯絡人.聯絡人選取元件();
            this.label12 = new System.Windows.Forms.Label();
            this.myDataGridView1 = new WokyTool.通用.MyDataGridView();
            this.一般訂單新增組成資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.新增 = new System.Windows.Forms.Button();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.備註 = new System.Windows.Forms.TextBox();
            this.列印單價 = new System.Windows.Forms.CheckBox();
            this.單品 = new WokyTool.單品.單品選取元件();
            this.單品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.售價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.售價 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.代收金額)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.一般訂單新增組成資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.售價)).BeginInit();
            this.SuspendLayout();
            // 
            // 新版頁索引元件1
            // 
            this.新版頁索引元件1.Location = new System.Drawing.Point(221, 393);
            this.新版頁索引元件1.Name = "新版頁索引元件1";
            this.新版頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.新版頁索引元件1.TabIndex = 57;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(236, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 158;
            this.label14.Text = "代收金額";
            // 
            // 代收金額
            // 
            this.代收金額.Location = new System.Drawing.Point(290, 359);
            this.代收金額.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.代收金額.Name = "代收金額";
            this.代收金額.Size = new System.Drawing.Size(165, 22);
            this.代收金額.TabIndex = 157;
            // 
            // 代收方式
            // 
            this.代收方式.Location = new System.Drawing.Point(235, 331);
            this.代收方式.Name = "代收方式";
            this.代收方式.ReadOnly = false;
            this.代收方式.SelectedItem = WokyTool.通用.列舉.代收方式.錯誤;
            this.代收方式.Size = new System.Drawing.Size(222, 28);
            this.代收方式.TabIndex = 156;
            this.代收方式.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 指配時段
            // 
            this.指配時段.Location = new System.Drawing.Point(4, 359);
            this.指配時段.Name = "指配時段";
            this.指配時段.ReadOnly = false;
            this.指配時段.SelectedItem = WokyTool.通用.列舉.指配時段.錯誤;
            this.指配時段.Size = new System.Drawing.Size(222, 28);
            this.指配時段.TabIndex = 155;
            this.指配時段.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 指配日期
            // 
            this.指配日期.CustomFormat = " ";
            this.指配日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.指配日期.Location = new System.Drawing.Point(59, 331);
            this.指配日期.Name = "指配日期";
            this.指配日期.Size = new System.Drawing.Size(165, 22);
            this.指配日期.TabIndex = 154;
            this.指配日期.Value = new System.DateTime(((long)(0)));
            this.指配日期.類型 = WokyTool.通用.MyDateTimePicker.時間類型.最小值;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 153;
            this.label11.Text = "指配日期";
            // 
            // 手機
            // 
            this.手機.Location = new System.Drawing.Point(292, 97);
            this.手機.Name = "手機";
            this.手機.Size = new System.Drawing.Size(165, 22);
            this.手機.TabIndex = 143;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 142;
            this.label8.Text = "手機";
            // 
            // 電話
            // 
            this.電話.Location = new System.Drawing.Point(292, 69);
            this.電話.Name = "電話";
            this.電話.Size = new System.Drawing.Size(165, 22);
            this.電話.TabIndex = 141;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 140;
            this.label10.Text = "電話";
            // 
            // 地址
            // 
            this.地址.Location = new System.Drawing.Point(292, 37);
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(165, 22);
            this.地址.TabIndex = 139;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 138;
            this.label6.Text = "地址";
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(292, 9);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(165, 22);
            this.姓名.TabIndex = 137;
            // 
            // 客戶
            // 
            this.客戶.Location = new System.Drawing.Point(59, 38);
            this.客戶.Name = "客戶";
            this.客戶.ReadOnly = false;
            this.客戶.SelectedItem = null;
            this.客戶.Size = new System.Drawing.Size(186, 25);
            this.客戶.TabIndex = 133;
            this.客戶.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 公司
            // 
            this.公司.Location = new System.Drawing.Point(59, 10);
            this.公司.Name = "公司";
            this.公司.ReadOnly = false;
            this.公司.SelectedItem = null;
            this.公司.Size = new System.Drawing.Size(173, 25);
            this.公司.TabIndex = 132;
            this.公司.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 125;
            this.label3.Text = "公司";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 124;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 123;
            this.label1.Text = "客戶";
            // 
            // 子客戶
            // 
            this.子客戶.Location = new System.Drawing.Point(59, 69);
            this.子客戶.Name = "子客戶";
            this.子客戶.ReadOnly = false;
            this.子客戶.SelectedItem = null;
            this.子客戶.Size = new System.Drawing.Size(185, 22);
            this.子客戶.TabIndex = 160;
            this.子客戶.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 165;
            this.label7.Text = "子客戶";
            // 
            // 聯絡人
            // 
            this.聯絡人.Location = new System.Drawing.Point(59, 97);
            this.聯絡人.Name = "聯絡人";
            this.聯絡人.ReadOnly = false;
            this.聯絡人.SelectedItem = null;
            this.聯絡人.Size = new System.Drawing.Size(185, 22);
            this.聯絡人.TabIndex = 166;
            this.聯絡人.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 167;
            this.label12.Text = "聯絡人";
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AllowUserToAddRows = false;
            this.myDataGridView1.AutoGenerateColumns = false;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.單品名稱DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.售價DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn});
            this.myDataGridView1.DataSource = this.一般訂單新增組成資料BindingSource;
            this.myDataGridView1.Location = new System.Drawing.Point(14, 173);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.RowTemplate.Height = 24;
            this.myDataGridView1.Size = new System.Drawing.Size(747, 150);
            this.myDataGridView1.TabIndex = 168;
            // 
            // 一般訂單新增組成資料BindingSource
            // 
            this.一般訂單新增組成資料BindingSource.DataSource = typeof(WokyTool.一般訂單.一般訂單新增組成資料);
            // 
            // 新增
            // 
            this.新增.Location = new System.Drawing.Point(11, 144);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(42, 23);
            this.新增.TabIndex = 170;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = true;
            this.新增.Click += new System.EventHandler(this.新增_Click);
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(461, 146);
            this.數量.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.數量.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.數量.Name = "數量";
            this.數量.Size = new System.Drawing.Size(95, 22);
            this.數量.TabIndex = 169;
            this.數量.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(655, 146);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(106, 22);
            this.備註.TabIndex = 172;
            // 
            // 列印單價
            // 
            this.列印單價.AutoSize = true;
            this.列印單價.Location = new System.Drawing.Point(501, 12);
            this.列印單價.Name = "列印單價";
            this.列印單價.Size = new System.Drawing.Size(72, 16);
            this.列印單價.TabIndex = 173;
            this.列印單價.Text = "列印單價";
            this.列印單價.UseVisualStyleBackColor = true;
            // 
            // 單品
            // 
            this.單品.Location = new System.Drawing.Point(57, 146);
            this.單品.Margin = new System.Windows.Forms.Padding(4);
            this.單品.Name = "單品";
            this.單品.ReadOnly = false;
            this.單品.SelectedItem = null;
            this.單品.Size = new System.Drawing.Size(400, 24);
            this.單品.TabIndex = 174;
            this.單品.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 單品名稱DataGridViewTextBoxColumn
            // 
            this.單品名稱DataGridViewTextBoxColumn.DataPropertyName = "單品名稱";
            this.單品名稱DataGridViewTextBoxColumn.HeaderText = "單品";
            this.單品名稱DataGridViewTextBoxColumn.Name = "單品名稱DataGridViewTextBoxColumn";
            this.單品名稱DataGridViewTextBoxColumn.ReadOnly = true;
            this.單品名稱DataGridViewTextBoxColumn.Width = 400;
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 售價DataGridViewTextBoxColumn
            // 
            this.售價DataGridViewTextBoxColumn.DataPropertyName = "售價";
            this.售價DataGridViewTextBoxColumn.HeaderText = "售價";
            this.售價DataGridViewTextBoxColumn.Name = "售價DataGridViewTextBoxColumn";
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            // 
            // 售價
            // 
            this.售價.Location = new System.Drawing.Point(559, 146);
            this.售價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.售價.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.售價.Name = "售價";
            this.售價.Size = new System.Drawing.Size(95, 22);
            this.售價.TabIndex = 175;
            this.售價.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // 一般訂單新增詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(767, 435);
            this.Controls.Add(this.售價);
            this.Controls.Add(this.單品);
            this.Controls.Add(this.列印單價);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.新增);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.myDataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.聯絡人);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.子客戶);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.代收金額);
            this.Controls.Add(this.代收方式);
            this.Controls.Add(this.指配時段);
            this.Controls.Add(this.指配日期);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.手機);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.電話);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.地址);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.客戶);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.新版頁索引元件1);
            this.Name = "一般訂單新增詳細視窗";
            this.Text = "一般訂單新增詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.代收金額)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.一般訂單新增組成資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.售價)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 通用.新版頁索引元件 新版頁索引元件1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown 代收金額;
        private 代收方式選取元件 代收方式;
        private 指配時段選取元件 指配時段;
        private MyDateTimePicker 指配日期;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox 手機;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox 電話;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox 地址;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 姓名;
        private 客戶.客戶選取元件 客戶;
        private 公司.公司選取元件 公司;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private 客戶.子客戶選取元件 子客戶;
        private System.Windows.Forms.Label label7;
        private 聯絡人.聯絡人選取元件 聯絡人;
        private System.Windows.Forms.Label label12;
        private MyDataGridView myDataGridView1;
        private System.Windows.Forms.BindingSource 一般訂單新增組成資料BindingSource;
        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.CheckBox 列印單價;
        private 單品選取元件 單品;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 售價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown 售價;
    }
}