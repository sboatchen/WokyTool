using WokyTool.商品;
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
            this.單價 = new System.Windows.Forms.NumericUpDown();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.姓名 = new System.Windows.Forms.TextBox();
            this.頁索引元件1 = new WokyTool.通用.頁索引元件();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.客戶選取元件 = new WokyTool.客戶.客戶選取元件();
            this.公司選取元件 = new WokyTool.公司.公司選取元件();
            this.子客戶選取元件 = new WokyTool.客戶.子客戶選取元件();
            this.label14 = new System.Windows.Forms.Label();
            this.手機 = new System.Windows.Forms.TextBox();
            this.電話 = new System.Windows.Forms.TextBox();
            this.地址 = new System.Windows.Forms.TextBox();
            this.新增 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.聯絡人選取元件 = new WokyTool.聯絡人.聯絡人選取元件();
            this.備註 = new System.Windows.Forms.TextBox();
            this.列印單價 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.商品選取元件 = new WokyTool.商品.商品選取元件();
            this.一般訂單新增商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.單價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.一般訂單新增商品資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 單價
            // 
            this.單價.DecimalPlaces = 3;
            this.單價.Location = new System.Drawing.Point(576, 164);
            this.單價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.單價.Name = "單價";
            this.單價.Size = new System.Drawing.Size(93, 22);
            this.單價.TabIndex = 67;
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(470, 164);
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
            this.數量.Size = new System.Drawing.Size(100, 22);
            this.數量.TabIndex = 51;
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(351, 16);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(230, 22);
            this.姓名.TabIndex = 35;
            // 
            // 頁索引元件1
            // 
            this.頁索引元件1.Location = new System.Drawing.Point(284, 447);
            this.頁索引元件1.Name = "頁索引元件1";
            this.頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.頁索引元件1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "姓名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "公司";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "電話";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "子客戶";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客戶";
            // 
            // 客戶選取元件
            // 
            this.客戶選取元件.Location = new System.Drawing.Point(71, 51);
            this.客戶選取元件.Name = "客戶選取元件";
            this.客戶選取元件.ReadOnly = false;
            this.客戶選取元件.SelectedItem = null;
            this.客戶選取元件.Size = new System.Drawing.Size(186, 25);
            this.客戶選取元件.TabIndex = 77;
            // 
            // 公司選取元件
            // 
            this.公司選取元件.Location = new System.Drawing.Point(71, 19);
            this.公司選取元件.Name = "公司選取元件";
            this.公司選取元件.ReadOnly = false;
            this.公司選取元件.SelectedItem = null;
            this.公司選取元件.Size = new System.Drawing.Size(173, 25);
            this.公司選取元件.TabIndex = 78;
            // 
            // 子客戶選取元件
            // 
            this.子客戶選取元件.Location = new System.Drawing.Point(71, 82);
            this.子客戶選取元件.Name = "子客戶選取元件";
            this.子客戶選取元件.ReadOnly = false;
            this.子客戶選取元件.SelectedItem = null;
            this.子客戶選取元件.Size = new System.Drawing.Size(186, 25);
            this.子客戶選取元件.TabIndex = 79;
            this.子客戶選取元件.綁定客戶 = null;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(304, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 80;
            this.label14.Text = "手機";
            // 
            // 手機
            // 
            this.手機.Location = new System.Drawing.Point(351, 114);
            this.手機.Name = "手機";
            this.手機.Size = new System.Drawing.Size(230, 22);
            this.手機.TabIndex = 82;
            // 
            // 電話
            // 
            this.電話.Location = new System.Drawing.Point(351, 79);
            this.電話.Name = "電話";
            this.電話.Size = new System.Drawing.Size(230, 22);
            this.電話.TabIndex = 83;
            // 
            // 地址
            // 
            this.地址.Location = new System.Drawing.Point(351, 48);
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(230, 22);
            this.地址.TabIndex = 84;
            // 
            // 新增
            // 
            this.新增.Location = new System.Drawing.Point(7, 163);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(42, 23);
            this.新增.TabIndex = 85;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = true;
            this.新增.Click += new System.EventHandler(this.新增_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 88;
            this.label3.Text = "聯絡人";
            // 
            // 聯絡人選取元件
            // 
            this.聯絡人選取元件.Location = new System.Drawing.Point(71, 113);
            this.聯絡人選取元件.Name = "聯絡人選取元件";
            this.聯絡人選取元件.ReadOnly = false;
            this.聯絡人選取元件.SelectedItem = null;
            this.聯絡人選取元件.Size = new System.Drawing.Size(172, 25);
            this.聯絡人選取元件.TabIndex = 89;
            this.聯絡人選取元件.綁定子客戶 = null;
            this.聯絡人選取元件.綁定客戶 = null;
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(675, 163);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(141, 22);
            this.備註.TabIndex = 90;
            // 
            // 列印單價
            // 
            this.列印單價.AutoSize = true;
            this.列印單價.Location = new System.Drawing.Point(684, 18);
            this.列印單價.Name = "列印單價";
            this.列印單價.Size = new System.Drawing.Size(72, 16);
            this.列印單價.TabIndex = 92;
            this.列印單價.Text = "列印單價";
            this.列印單價.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品名稱DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.單價DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.一般訂單新增商品資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 248);
            this.dataGridView1.TabIndex = 93;
            // 
            // 商品選取元件
            // 
            this.商品選取元件.Location = new System.Drawing.Point(50, 164);
            this.商品選取元件.Name = "商品選取元件";
            this.商品選取元件.ReadOnly = false;
            this.商品選取元件.SelectedItem = null;
            this.商品選取元件.Size = new System.Drawing.Size(419, 27);
            this.商品選取元件.TabIndex = 94;
            this.商品選取元件.綁定客戶 = null;
            // 
            // 一般訂單新增商品資料BindingSource
            // 
            this.一般訂單新增商品資料BindingSource.DataSource = typeof(WokyTool.一般訂單.一般訂單新增商品資料);
            // 
            // 商品名稱DataGridViewTextBoxColumn
            // 
            this.商品名稱DataGridViewTextBoxColumn.DataPropertyName = "商品名稱";
            this.商品名稱DataGridViewTextBoxColumn.HeaderText = "商品名稱";
            this.商品名稱DataGridViewTextBoxColumn.Name = "商品名稱DataGridViewTextBoxColumn";
            this.商品名稱DataGridViewTextBoxColumn.ReadOnly = true;
            this.商品名稱DataGridViewTextBoxColumn.Width = 420;
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 單價DataGridViewTextBoxColumn
            // 
            this.單價DataGridViewTextBoxColumn.DataPropertyName = "單價";
            this.單價DataGridViewTextBoxColumn.HeaderText = "單價";
            this.單價DataGridViewTextBoxColumn.Name = "單價DataGridViewTextBoxColumn";
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            this.備註DataGridViewTextBoxColumn.Width = 140;
            // 
            // 一般訂單新增詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 493);
            this.Controls.Add(this.商品選取元件);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.列印單價);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.聯絡人選取元件);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.新增);
            this.Controls.Add(this.地址);
            this.Controls.Add(this.電話);
            this.Controls.Add(this.手機);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.子客戶選取元件);
            this.Controls.Add(this.公司選取元件);
            this.Controls.Add(this.客戶選取元件);
            this.Controls.Add(this.單價);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.頁索引元件1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "一般訂單新增詳細視窗";
            this.Text = "一般訂單新增詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.單價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.一般訂單新增商品資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private 通用.頁索引元件 頁索引元件1;
        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.NumericUpDown 單價;
        private 客戶.客戶選取元件 客戶選取元件;
        private 公司.公司選取元件 公司選取元件;
        private 客戶.子客戶選取元件 子客戶選取元件;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox 手機;
        private System.Windows.Forms.TextBox 電話;
        private System.Windows.Forms.TextBox 地址;
        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.Label label3;
        private 聯絡人.聯絡人選取元件 聯絡人選取元件;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.CheckBox 列印單價;
        private System.Windows.Forms.DataGridView dataGridView1;
        private 商品選取元件 商品選取元件;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 一般訂單新增商品資料BindingSource;
    }
}