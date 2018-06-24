namespace WokyTool.客戶
{
    partial class 子客戶詳細視窗
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.名稱 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.聯絡人資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.電話DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手機DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.索引 = new System.Windows.Forms.Label();
            this.下一個 = new System.Windows.Forms.Button();
            this.上一個 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.聯絡人資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "聯絡人";
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(64, 13);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(126, 22);
            this.名稱.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.電話DataGridViewTextBoxColumn,
            this.手機DataGridViewTextBoxColumn,
            this.地址DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.聯絡人資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.DataSource = this.聯絡人資料BindingSource;
            this.姓名DataGridViewTextBoxColumn.DisplayMember = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            this.姓名DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.姓名DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 聯絡人資料BindingSource
            // 
            this.聯絡人資料BindingSource.DataSource = typeof(WokyTool.聯絡人.聯絡人資料);
            // 
            // 電話DataGridViewTextBoxColumn
            // 
            this.電話DataGridViewTextBoxColumn.DataPropertyName = "電話";
            this.電話DataGridViewTextBoxColumn.HeaderText = "電話";
            this.電話DataGridViewTextBoxColumn.Name = "電話DataGridViewTextBoxColumn";
            this.電話DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 手機DataGridViewTextBoxColumn
            // 
            this.手機DataGridViewTextBoxColumn.DataPropertyName = "手機";
            this.手機DataGridViewTextBoxColumn.HeaderText = "手機";
            this.手機DataGridViewTextBoxColumn.Name = "手機DataGridViewTextBoxColumn";
            this.手機DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 地址DataGridViewTextBoxColumn
            // 
            this.地址DataGridViewTextBoxColumn.DataPropertyName = "地址";
            this.地址DataGridViewTextBoxColumn.HeaderText = "地址";
            this.地址DataGridViewTextBoxColumn.Name = "地址DataGridViewTextBoxColumn";
            this.地址DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 索引
            // 
            this.索引.AutoSize = true;
            this.索引.Location = new System.Drawing.Point(264, 236);
            this.索引.Name = "索引";
            this.索引.Size = new System.Drawing.Size(41, 12);
            this.索引.TabIndex = 4;
            this.索引.Text = "?? of ??";
            // 
            // 下一個
            // 
            this.下一個.Location = new System.Drawing.Point(324, 231);
            this.下一個.Name = "下一個";
            this.下一個.Size = new System.Drawing.Size(75, 23);
            this.下一個.TabIndex = 5;
            this.下一個.Text = "Next";
            this.下一個.UseVisualStyleBackColor = true;
            this.下一個.Click += new System.EventHandler(this.下一個_Click);
            // 
            // 上一個
            // 
            this.上一個.Location = new System.Drawing.Point(166, 231);
            this.上一個.Name = "上一個";
            this.上一個.Size = new System.Drawing.Size(75, 23);
            this.上一個.TabIndex = 6;
            this.上一個.Text = "Before";
            this.上一個.UseVisualStyleBackColor = true;
            this.上一個.Click += new System.EventHandler(this.上一個_Click);
            // 
            // 子客戶詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 385);
            this.Controls.Add(this.上一個);
            this.Controls.Add(this.下一個);
            this.Controls.Add(this.索引);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "子客戶詳細視窗";
            this.Text = "子客戶詳細視窗";
            this.Activated += new System.EventHandler(this.子客戶詳細視窗_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.子客戶詳細視窗_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.子客戶詳細視窗_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.聯絡人資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 聯絡人資料BindingSource;
        private System.Windows.Forms.Label 索引;
        private System.Windows.Forms.Button 下一個;
        private System.Windows.Forms.Button 上一個;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手機DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址DataGridViewTextBoxColumn;
    }
}