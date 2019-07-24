namespace WokyTool.商品
{
    partial class 商品新增匯入詳細視窗
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
            this.label12 = new System.Windows.Forms.Label();
            this.利潤 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.體積 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.成本 = new System.Windows.Forms.NumericUpDown();
            this.商品小類選取元件1 = new WokyTool.商品.商品小類選取元件();
            this.label6 = new System.Windows.Forms.Label();
            this.售價 = new System.Windows.Forms.NumericUpDown();
            this.寄庫數量 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.客戶選取元件1 = new WokyTool.客戶.客戶選取元件();
            this.公司選取元件1 = new WokyTool.公司.公司選取元件();
            this.商品大類選取元件1 = new WokyTool.商品.商品大類選取元件();
            this.品號 = new System.Windows.Forms.TextBox();
            this.名稱 = new System.Windows.Forms.TextBox();
            this.頁索引元件1 = new WokyTool.通用.頁索引元件();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.大類識別 = new System.Windows.Forms.TextBox();
            this.小類識別 = new System.Windows.Forms.TextBox();
            this.公司識別 = new System.Windows.Forms.TextBox();
            this.客戶識別 = new System.Windows.Forms.TextBox();
            this.物品選取元件 = new WokyTool.物品.物品選取元件();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.物品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.物品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.識別名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品組成匯入資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.新增 = new System.Windows.Forms.Button();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.進價 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.利潤)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.體積)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.售價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.寄庫數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品組成匯入資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.進價)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 75;
            this.label12.Text = "利潤";
            // 
            // 利潤
            // 
            this.利潤.DecimalPlaces = 3;
            this.利潤.Location = new System.Drawing.Point(64, 506);
            this.利潤.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.利潤.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.利潤.Name = "利潤";
            this.利潤.ReadOnly = true;
            this.利潤.Size = new System.Drawing.Size(167, 22);
            this.利潤.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 542);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 73;
            this.label13.Text = "體積";
            // 
            // 體積
            // 
            this.體積.Location = new System.Drawing.Point(64, 537);
            this.體積.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.體積.Name = "體積";
            this.體積.ReadOnly = true;
            this.體積.Size = new System.Drawing.Size(167, 22);
            this.體積.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 71;
            this.label10.Text = "成本";
            // 
            // 成本
            // 
            this.成本.DecimalPlaces = 3;
            this.成本.Location = new System.Drawing.Point(64, 475);
            this.成本.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.成本.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.成本.Name = "成本";
            this.成本.ReadOnly = true;
            this.成本.Size = new System.Drawing.Size(167, 22);
            this.成本.TabIndex = 70;
            // 
            // 商品小類選取元件1
            // 
            this.商品小類選取元件1.Location = new System.Drawing.Point(64, 137);
            this.商品小類選取元件1.Name = "商品小類選取元件1";
            this.商品小類選取元件1.ReadOnly = false;
            this.商品小類選取元件1.SelectedItem = null;
            this.商品小類選取元件1.Size = new System.Drawing.Size(172, 25);
            this.商品小類選取元件1.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 68;
            this.label6.Text = "售價";
            // 
            // 售價
            // 
            this.售價.DecimalPlaces = 3;
            this.售價.Location = new System.Drawing.Point(569, 506);
            this.售價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.售價.Name = "售價";
            this.售價.Size = new System.Drawing.Size(167, 22);
            this.售價.TabIndex = 67;
            // 
            // 寄庫數量
            // 
            this.寄庫數量.Location = new System.Drawing.Point(569, 534);
            this.寄庫數量.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.寄庫數量.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.寄庫數量.Name = "寄庫數量";
            this.寄庫數量.Size = new System.Drawing.Size(167, 22);
            this.寄庫數量.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 65;
            this.label3.Text = "寄庫數量";
            // 
            // 客戶選取元件1
            // 
            this.客戶選取元件1.Location = new System.Drawing.Point(569, 135);
            this.客戶選取元件1.Name = "客戶選取元件1";
            this.客戶選取元件1.ReadOnly = false;
            this.客戶選取元件1.SelectedItem = null;
            this.客戶選取元件1.Size = new System.Drawing.Size(190, 25);
            this.客戶選取元件1.TabIndex = 55;
            // 
            // 公司選取元件1
            // 
            this.公司選取元件1.Location = new System.Drawing.Point(569, 78);
            this.公司選取元件1.Name = "公司選取元件1";
            this.公司選取元件1.ReadOnly = false;
            this.公司選取元件1.SelectedItem = null;
            this.公司選取元件1.Size = new System.Drawing.Size(172, 25);
            this.公司選取元件1.TabIndex = 54;
            // 
            // 商品大類選取元件1
            // 
            this.商品大類選取元件1.Location = new System.Drawing.Point(64, 78);
            this.商品大類選取元件1.Name = "商品大類選取元件1";
            this.商品大類選取元件1.ReadOnly = false;
            this.商品大類選取元件1.SelectedItem = null;
            this.商品大類選取元件1.Size = new System.Drawing.Size(172, 25);
            this.商品大類選取元件1.TabIndex = 52;
            // 
            // 品號
            // 
            this.品號.Location = new System.Drawing.Point(569, 10);
            this.品號.Name = "品號";
            this.品號.Size = new System.Drawing.Size(167, 22);
            this.品號.TabIndex = 35;
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(64, 10);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(400, 22);
            this.名稱.TabIndex = 23;
            // 
            // 頁索引元件1
            // 
            this.頁索引元件1.Location = new System.Drawing.Point(237, 586);
            this.頁索引元件1.Name = "頁索引元件1";
            this.頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.頁索引元件1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "品號";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "名稱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "客戶";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "公司";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "小類";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "大類";
            // 
            // 大類識別
            // 
            this.大類識別.Location = new System.Drawing.Point(64, 49);
            this.大類識別.Name = "大類識別";
            this.大類識別.ReadOnly = true;
            this.大類識別.Size = new System.Drawing.Size(167, 22);
            this.大類識別.TabIndex = 76;
            // 
            // 小類識別
            // 
            this.小類識別.Location = new System.Drawing.Point(64, 107);
            this.小類識別.Name = "小類識別";
            this.小類識別.ReadOnly = true;
            this.小類識別.Size = new System.Drawing.Size(167, 22);
            this.小類識別.TabIndex = 77;
            // 
            // 公司識別
            // 
            this.公司識別.Location = new System.Drawing.Point(569, 49);
            this.公司識別.Name = "公司識別";
            this.公司識別.ReadOnly = true;
            this.公司識別.Size = new System.Drawing.Size(167, 22);
            this.公司識別.TabIndex = 78;
            // 
            // 客戶識別
            // 
            this.客戶識別.Location = new System.Drawing.Point(569, 107);
            this.客戶識別.Name = "客戶識別";
            this.客戶識別.ReadOnly = true;
            this.客戶識別.Size = new System.Drawing.Size(167, 22);
            this.客戶識別.TabIndex = 79;
            // 
            // 物品選取元件
            // 
            this.物品選取元件.Location = new System.Drawing.Point(57, 181);
            this.物品選取元件.Name = "物品選取元件";
            this.物品選取元件.ReadOnly = false;
            this.物品選取元件.SelectedItem = null;
            this.物品選取元件.Size = new System.Drawing.Size(404, 24);
            this.物品選取元件.TabIndex = 104;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.物品DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.識別名稱DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.商品組成匯入資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 248);
            this.dataGridView1.TabIndex = 103;
            // 
            // 物品DataGridViewTextBoxColumn
            // 
            this.物品DataGridViewTextBoxColumn.DataPropertyName = "物品";
            this.物品DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.物品DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.物品DataGridViewTextBoxColumn.HeaderText = "物品";
            this.物品DataGridViewTextBoxColumn.Name = "物品DataGridViewTextBoxColumn";
            this.物品DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.物品DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.物品DataGridViewTextBoxColumn.ValueMember = "Self";
            this.物品DataGridViewTextBoxColumn.Width = 400;
            // 
            // 物品資料BindingSource
            // 
            this.物品資料BindingSource.DataSource = typeof(WokyTool.物品.物品資料);
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 識別名稱DataGridViewTextBoxColumn
            // 
            this.識別名稱DataGridViewTextBoxColumn.DataPropertyName = "識別名稱";
            this.識別名稱DataGridViewTextBoxColumn.HeaderText = "識別名稱";
            this.識別名稱DataGridViewTextBoxColumn.Name = "識別名稱DataGridViewTextBoxColumn";
            this.識別名稱DataGridViewTextBoxColumn.Width = 200;
            // 
            // 商品組成匯入資料BindingSource
            // 
            this.商品組成匯入資料BindingSource.DataSource = typeof(WokyTool.商品.商品組成匯入資料);
            // 
            // 新增
            // 
            this.新增.Location = new System.Drawing.Point(14, 179);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(42, 23);
            this.新增.TabIndex = 102;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = true;
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(463, 180);
            this.數量.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.數量.Name = "數量";
            this.數量.Size = new System.Drawing.Size(100, 22);
            this.數量.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 106;
            this.label9.Text = "進價";
            // 
            // 進價
            // 
            this.進價.DecimalPlaces = 3;
            this.進價.Location = new System.Drawing.Point(569, 475);
            this.進價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.進價.Name = "進價";
            this.進價.Size = new System.Drawing.Size(167, 22);
            this.進價.TabIndex = 105;
            // 
            // 商品新增匯入詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 641);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.進價);
            this.Controls.Add(this.物品選取元件);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.新增);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.客戶識別);
            this.Controls.Add(this.公司識別);
            this.Controls.Add(this.小類識別);
            this.Controls.Add(this.大類識別);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.利潤);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.體積);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.成本);
            this.Controls.Add(this.商品小類選取元件1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.售價);
            this.Controls.Add(this.寄庫數量);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.客戶選取元件1);
            this.Controls.Add(this.公司選取元件1);
            this.Controls.Add(this.商品大類選取元件1);
            this.Controls.Add(this.品號);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.頁索引元件1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "商品新增匯入詳細視窗";
            this.Text = "商品新增匯入詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.利潤)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.體積)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.售價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.寄庫數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品組成匯入資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.進價)).EndInit();
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
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.TextBox 品號;
        private 商品大類選取元件 商品大類選取元件1;
        private 公司.公司選取元件 公司選取元件1;
        private 客戶.客戶選取元件 客戶選取元件1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown 寄庫數量;
        private System.Windows.Forms.NumericUpDown 售價;
        private System.Windows.Forms.Label label6;
        private 商品小類選取元件 商品小類選取元件1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown 成本;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown 利潤;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown 體積;
        private System.Windows.Forms.TextBox 大類識別;
        private System.Windows.Forms.TextBox 小類識別;
        private System.Windows.Forms.TextBox 公司識別;
        private System.Windows.Forms.TextBox 客戶識別;
        private 物品.物品選取元件 物品選取元件;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.BindingSource 物品資料BindingSource;
        private System.Windows.Forms.BindingSource 商品組成匯入資料BindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn 物品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 識別名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown 進價;
    }
}