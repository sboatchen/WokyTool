namespace WokyTool.ImportForm
{
    partial class 雜支匯入視窗
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
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列錯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.廠商名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.廠商編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.廠商資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.幣值DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.幣值編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.幣值資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.雜支匯入結構BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.幣值資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.雜支匯入結構BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.刪除ToolStripMenuItem,
            this.列錯ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.時間DataGridViewTextBoxColumn,
            this.廠商名稱DataGridViewTextBoxColumn,
            this.廠商編號DataGridViewTextBoxColumn,
            this.物品名稱DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.單價DataGridViewTextBoxColumn,
            this.幣值DataGridViewTextBoxColumn,
            this.幣值編號DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.雜支匯入結構BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 422);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // 時間DataGridViewTextBoxColumn
            // 
            this.時間DataGridViewTextBoxColumn.DataPropertyName = "時間";
            this.時間DataGridViewTextBoxColumn.HeaderText = "時間";
            this.時間DataGridViewTextBoxColumn.Name = "時間DataGridViewTextBoxColumn";
            // 
            // 廠商名稱DataGridViewTextBoxColumn
            // 
            this.廠商名稱DataGridViewTextBoxColumn.DataPropertyName = "廠商名稱";
            this.廠商名稱DataGridViewTextBoxColumn.HeaderText = "廠商名稱";
            this.廠商名稱DataGridViewTextBoxColumn.Name = "廠商名稱DataGridViewTextBoxColumn";
            // 
            // 廠商編號DataGridViewTextBoxColumn
            // 
            this.廠商編號DataGridViewTextBoxColumn.DataPropertyName = "廠商編號";
            this.廠商編號DataGridViewTextBoxColumn.DataSource = this.廠商資料BindingSource;
            this.廠商編號DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.廠商編號DataGridViewTextBoxColumn.HeaderText = "廠商編號";
            this.廠商編號DataGridViewTextBoxColumn.Name = "廠商編號DataGridViewTextBoxColumn";
            this.廠商編號DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.廠商編號DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.廠商編號DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 廠商資料BindingSource
            // 
            this.廠商資料BindingSource.DataSource = typeof(WokyTool.Data.廠商資料);
            // 
            // 物品名稱DataGridViewTextBoxColumn
            // 
            this.物品名稱DataGridViewTextBoxColumn.DataPropertyName = "物品名稱";
            this.物品名稱DataGridViewTextBoxColumn.HeaderText = "物品名稱";
            this.物品名稱DataGridViewTextBoxColumn.Name = "物品名稱DataGridViewTextBoxColumn";
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
            // 幣值DataGridViewTextBoxColumn
            // 
            this.幣值DataGridViewTextBoxColumn.DataPropertyName = "幣值";
            this.幣值DataGridViewTextBoxColumn.HeaderText = "幣值";
            this.幣值DataGridViewTextBoxColumn.Name = "幣值DataGridViewTextBoxColumn";
            // 
            // 幣值編號DataGridViewTextBoxColumn
            // 
            this.幣值編號DataGridViewTextBoxColumn.DataPropertyName = "幣值編號";
            this.幣值編號DataGridViewTextBoxColumn.DataSource = this.幣值資料BindingSource;
            this.幣值編號DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.幣值編號DataGridViewTextBoxColumn.HeaderText = "幣值編號";
            this.幣值編號DataGridViewTextBoxColumn.Name = "幣值編號DataGridViewTextBoxColumn";
            this.幣值編號DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.幣值編號DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.幣值編號DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 幣值資料BindingSource
            // 
            this.幣值資料BindingSource.DataSource = typeof(WokyTool.Data.幣值資料);
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            // 
            // 雜支匯入結構BindingSource
            // 
            this.雜支匯入結構BindingSource.DataSource = typeof(WokyTool.DataImport.雜支匯入結構);
            // 
            // 雜支匯入視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "雜支匯入視窗";
            this.Text = "雜支匯入視窗";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.雜支匯入視窗_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.幣值資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.雜支匯入結構BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列錯ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 雜支匯入結構BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 廠商名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 廠商編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 廠商資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 幣值DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 幣值編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 幣值資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
    }
}