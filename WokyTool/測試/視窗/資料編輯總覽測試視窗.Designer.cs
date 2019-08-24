using WokyTool.通用;
namespace WokyTool.測試
{
    partial class 資料編輯總覽測試視窗
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
            this.button1 = new System.Windows.Forms.Button();
            this.列舉 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.時間 = new System.Windows.Forms.DateTimePicker();
            this.倍精準浮點數 = new System.Windows.Forms.NumericUpDown();
            this.浮點數 = new System.Windows.Forms.NumericUpDown();
            this.整數 = new System.Windows.Forms.NumericUpDown();
            this.字串 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.倍精準 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new MyDataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.列印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.過濾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最小整數 = new System.Windows.Forms.ToolStripTextBox();
            this.字串DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.整數DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.浮點數DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.倍精準浮點數DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.列舉DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.讀寫測試資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.倍精準浮點數)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.浮點數)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.整數)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.讀寫測試資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 列舉
            // 
            this.列舉.FormattingEnabled = true;
            this.列舉.Location = new System.Drawing.Point(741, 191);
            this.列舉.Name = "列舉";
            this.列舉.Size = new System.Drawing.Size(121, 20);
            this.列舉.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "列舉";
            // 
            // 時間
            // 
            this.時間.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.時間.Location = new System.Drawing.Point(741, 160);
            this.時間.Name = "時間";
            this.時間.Size = new System.Drawing.Size(200, 22);
            this.時間.TabIndex = 22;
            // 
            // 倍精準浮點數
            // 
            this.倍精準浮點數.DecimalPlaces = 10;
            this.倍精準浮點數.Location = new System.Drawing.Point(741, 132);
            this.倍精準浮點數.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.倍精準浮點數.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.倍精準浮點數.Name = "倍精準浮點數";
            this.倍精準浮點數.Size = new System.Drawing.Size(120, 22);
            this.倍精準浮點數.TabIndex = 21;
            // 
            // 浮點數
            // 
            this.浮點數.DecimalPlaces = 10;
            this.浮點數.Location = new System.Drawing.Point(741, 104);
            this.浮點數.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.浮點數.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.浮點數.Name = "浮點數";
            this.浮點數.Size = new System.Drawing.Size(120, 22);
            this.浮點數.TabIndex = 20;
            // 
            // 整數
            // 
            this.整數.Location = new System.Drawing.Point(741, 76);
            this.整數.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.整數.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.整數.Name = "整數";
            this.整數.Size = new System.Drawing.Size(120, 22);
            this.整數.TabIndex = 19;
            // 
            // 字串
            // 
            this.字串.Location = new System.Drawing.Point(741, 45);
            this.字串.Name = "字串";
            this.字串.Size = new System.Drawing.Size(120, 22);
            this.字串.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "時間";
            // 
            // 倍精準
            // 
            this.倍精準.AutoSize = true;
            this.倍精準.Location = new System.Drawing.Point(688, 134);
            this.倍精準.Name = "倍精準";
            this.倍精準.Size = new System.Drawing.Size(41, 12);
            this.倍精準.TabIndex = 16;
            this.倍精準.Text = "倍精準";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "浮點數";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "整數";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "字串";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.字串DataGridViewTextBoxColumn,
            this.整數DataGridViewTextBoxColumn,
            this.浮點數DataGridViewTextBoxColumn,
            this.倍精準浮點數DataGridViewTextBoxColumn,
            this.時間DataGridViewTextBoxColumn,
            this.列舉DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.讀寫測試資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(657, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.列印ToolStripMenuItem,
            this.過濾ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 列印ToolStripMenuItem
            // 
            this.列印ToolStripMenuItem.Name = "列印ToolStripMenuItem";
            this.列印ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.列印ToolStripMenuItem.Text = "列印";
            this.列印ToolStripMenuItem.Click += new System.EventHandler(this.列印ToolStripMenuItem_Click);
            // 
            // 過濾ToolStripMenuItem
            // 
            this.過濾ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.最小整數});
            this.過濾ToolStripMenuItem.Name = "過濾ToolStripMenuItem";
            this.過濾ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.過濾ToolStripMenuItem.Text = "過濾";
            // 
            // 最小整數
            // 
            this.最小整數.Name = "最小整數";
            this.最小整數.Size = new System.Drawing.Size(100, 23);
            this.最小整數.TextChanged += new System.EventHandler(this.最小整數_TextChanged);
            // 
            // 字串DataGridViewTextBoxColumn
            // 
            this.字串DataGridViewTextBoxColumn.DataPropertyName = "字串";
            this.字串DataGridViewTextBoxColumn.HeaderText = "字串";
            this.字串DataGridViewTextBoxColumn.Name = "字串DataGridViewTextBoxColumn";
            // 
            // 整數DataGridViewTextBoxColumn
            // 
            this.整數DataGridViewTextBoxColumn.DataPropertyName = "整數";
            this.整數DataGridViewTextBoxColumn.HeaderText = "整數";
            this.整數DataGridViewTextBoxColumn.Name = "整數DataGridViewTextBoxColumn";
            // 
            // 浮點數DataGridViewTextBoxColumn
            // 
            this.浮點數DataGridViewTextBoxColumn.DataPropertyName = "浮點數";
            this.浮點數DataGridViewTextBoxColumn.HeaderText = "浮點數";
            this.浮點數DataGridViewTextBoxColumn.Name = "浮點數DataGridViewTextBoxColumn";
            // 
            // 倍精準浮點數DataGridViewTextBoxColumn
            // 
            this.倍精準浮點數DataGridViewTextBoxColumn.DataPropertyName = "倍精準浮點數";
            this.倍精準浮點數DataGridViewTextBoxColumn.HeaderText = "倍精準浮點數";
            this.倍精準浮點數DataGridViewTextBoxColumn.Name = "倍精準浮點數DataGridViewTextBoxColumn";
            // 
            // 時間DataGridViewTextBoxColumn
            // 
            this.時間DataGridViewTextBoxColumn.DataPropertyName = "時間";
            this.時間DataGridViewTextBoxColumn.HeaderText = "時間";
            this.時間DataGridViewTextBoxColumn.Name = "時間DataGridViewTextBoxColumn";
            // 
            // 列舉DataGridViewTextBoxColumn
            // 
            this.列舉DataGridViewTextBoxColumn.DataPropertyName = "列舉";
            this.列舉DataGridViewTextBoxColumn.HeaderText = "列舉";
            this.列舉DataGridViewTextBoxColumn.Name = "列舉DataGridViewTextBoxColumn";
            // 
            // 讀寫測試資料BindingSource
            // 
            this.讀寫測試資料BindingSource.DataSource = typeof(WokyTool.測試.讀寫測試資料);
            // 
            // 資料綁定測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.列舉);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.時間);
            this.Controls.Add(this.倍精準浮點數);
            this.Controls.Add(this.浮點數);
            this.Controls.Add(this.整數);
            this.Controls.Add(this.字串);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.倍精準);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "資料綁定測試視窗";
            this.Text = "資料綁定測試視窗";
            ((System.ComponentModel.ISupportInitialize)(this.倍精準浮點數)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.浮點數)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.整數)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.讀寫測試資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private MyDataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 讀寫測試資料BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 列印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 過濾ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox 最小整數;
        private System.Windows.Forms.DataGridViewTextBoxColumn 字串DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 整數DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 浮點數DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 倍精準浮點數DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 列舉DataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox 列舉;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker 時間;
        private System.Windows.Forms.NumericUpDown 倍精準浮點數;
        private System.Windows.Forms.NumericUpDown 浮點數;
        private System.Windows.Forms.NumericUpDown 整數;
        private System.Windows.Forms.TextBox 字串;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label 倍精準;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}