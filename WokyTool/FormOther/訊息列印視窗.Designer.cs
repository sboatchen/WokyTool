namespace WokyTool.FormOther
{
    partial class 訊息列印視窗
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.訊息資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.標題DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.訊息資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.標題DataGridViewTextBoxColumn,
            this.訊息DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.訊息資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.匯出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            this.匯出ToolStripMenuItem.Click += new System.EventHandler(this.匯出ToolStripMenuItem_Click);
            // 
            // 訊息資料BindingSource
            // 
            this.訊息資料BindingSource.DataSource = typeof(WokyTool.Data.訊息資料);
            // 
            // 標題DataGridViewTextBoxColumn
            // 
            this.標題DataGridViewTextBoxColumn.DataPropertyName = "標題";
            this.標題DataGridViewTextBoxColumn.HeaderText = "標題";
            this.標題DataGridViewTextBoxColumn.Name = "標題DataGridViewTextBoxColumn";
            this.標題DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 訊息DataGridViewTextBoxColumn
            // 
            this.訊息DataGridViewTextBoxColumn.DataPropertyName = "訊息";
            this.訊息DataGridViewTextBoxColumn.HeaderText = "訊息";
            this.訊息DataGridViewTextBoxColumn.Name = "訊息DataGridViewTextBoxColumn";
            this.訊息DataGridViewTextBoxColumn.ReadOnly = true;
            this.訊息DataGridViewTextBoxColumn.Width = 800;
            // 
            // 訊息列印視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 326);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "訊息列印視窗";
            this.Text = "錯誤警告列印視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.訊息資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 訊息資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 標題DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訊息DataGridViewTextBoxColumn;

    }
}