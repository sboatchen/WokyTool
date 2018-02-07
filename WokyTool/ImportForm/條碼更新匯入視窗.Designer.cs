namespace WokyTool.ImportForm
{
    partial class 條碼更新匯入視窗
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
            this.縮寫DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.舊條碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.條碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.更新訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.條碼更新匯入結構BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列錯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.樣板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.條碼更新匯入結構BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.縮寫DataGridViewTextBoxColumn,
            this.舊條碼DataGridViewTextBoxColumn,
            this.條碼DataGridViewTextBoxColumn,
            this.狀態DataGridViewTextBoxColumn,
            this.更新訊息DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.條碼更新匯入結構BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // 縮寫DataGridViewTextBoxColumn
            // 
            this.縮寫DataGridViewTextBoxColumn.DataPropertyName = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.HeaderText = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.Name = "縮寫DataGridViewTextBoxColumn";
            // 
            // 舊條碼DataGridViewTextBoxColumn
            // 
            this.舊條碼DataGridViewTextBoxColumn.DataPropertyName = "舊條碼";
            this.舊條碼DataGridViewTextBoxColumn.HeaderText = "舊條碼";
            this.舊條碼DataGridViewTextBoxColumn.Name = "舊條碼DataGridViewTextBoxColumn";
            this.舊條碼DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 條碼DataGridViewTextBoxColumn
            // 
            this.條碼DataGridViewTextBoxColumn.DataPropertyName = "條碼";
            this.條碼DataGridViewTextBoxColumn.HeaderText = "條碼";
            this.條碼DataGridViewTextBoxColumn.Name = "條碼DataGridViewTextBoxColumn";
            // 
            // 狀態DataGridViewTextBoxColumn
            // 
            this.狀態DataGridViewTextBoxColumn.DataPropertyName = "狀態";
            this.狀態DataGridViewTextBoxColumn.HeaderText = "狀態";
            this.狀態DataGridViewTextBoxColumn.Name = "狀態DataGridViewTextBoxColumn";
            // 
            // 更新訊息DataGridViewTextBoxColumn
            // 
            this.更新訊息DataGridViewTextBoxColumn.DataPropertyName = "更新訊息";
            this.更新訊息DataGridViewTextBoxColumn.HeaderText = "更新訊息";
            this.更新訊息DataGridViewTextBoxColumn.Name = "更新訊息DataGridViewTextBoxColumn";
            // 
            // 條碼更新匯入結構BindingSource
            // 
            this.條碼更新匯入結構BindingSource.DataSource = typeof(WokyTool.DataImport.條碼更新匯入結構);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.匯入ToolStripMenuItem,
            this.新增ToolStripMenuItem,
            this.刪除ToolStripMenuItem,
            this.列錯ToolStripMenuItem,
            this.樣板ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 匯入ToolStripMenuItem
            // 
            this.匯入ToolStripMenuItem.Name = "匯入ToolStripMenuItem";
            this.匯入ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯入ToolStripMenuItem.Text = "匯入";
            this.匯入ToolStripMenuItem.Click += new System.EventHandler(this.匯入ToolStripMenuItem_Click);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.刪除ToolStripMenuItem.Text = "刪除";
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // 列錯ToolStripMenuItem
            // 
            this.列錯ToolStripMenuItem.Name = "列錯ToolStripMenuItem";
            this.列錯ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.列錯ToolStripMenuItem.Text = "列錯";
            this.列錯ToolStripMenuItem.Click += new System.EventHandler(this.列錯ToolStripMenuItem_Click);
            // 
            // 樣板ToolStripMenuItem
            // 
            this.樣板ToolStripMenuItem.Name = "樣板ToolStripMenuItem";
            this.樣板ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.樣板ToolStripMenuItem.Text = "樣板";
            this.樣板ToolStripMenuItem.Click += new System.EventHandler(this.樣板ToolStripMenuItem_Click);
            // 
            // 條碼更新匯入視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 368);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "條碼更新匯入視窗";
            this.Text = "條碼更新匯入視窗";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.條碼更新匯入視窗_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.條碼更新匯入結構BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 縮寫DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 舊條碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 條碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 更新訊息DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 條碼更新匯入結構BindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列錯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 樣板ToolStripMenuItem;
    }
}