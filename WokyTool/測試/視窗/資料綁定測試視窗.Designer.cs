namespace WokyTool.測試
{
    partial class 資料綁定測試視窗
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.列印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.過濾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最小整數 = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.字串DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.整數DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.浮點數DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.倍精準浮點數DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.列舉DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.列舉值DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.讀寫測試資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.讀寫測試資料BindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
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
            this.列舉DataGridViewTextBoxColumn,
            this.列舉值DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.讀寫測試資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(896, 359);
            this.dataGridView1.TabIndex = 1;
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
            // 列舉值DataGridViewTextBoxColumn
            // 
            this.列舉值DataGridViewTextBoxColumn.DataPropertyName = "列舉值";
            this.列舉值DataGridViewTextBoxColumn.HeaderText = "列舉值";
            this.列舉值DataGridViewTextBoxColumn.Name = "列舉值DataGridViewTextBoxColumn";
            // 
            // 讀寫測試資料BindingSource
            // 
            this.讀寫測試資料BindingSource.DataSource = typeof(WokyTool.測試.讀寫測試資料);
            // 
            // 資料綁定測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "資料綁定測試視窗";
            this.Text = "資料綁定測試視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.讀寫測試資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 字串DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 整數DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 浮點數DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 倍精準浮點數DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 列舉DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 列舉值DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 讀寫測試資料BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 列印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 過濾ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox 最小整數;
    }
}