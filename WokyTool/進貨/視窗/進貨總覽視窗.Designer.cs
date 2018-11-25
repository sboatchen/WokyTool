namespace WokyTool.進貨
{
    partial class 進貨總覽視窗
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
            this.進貨處理狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.進貨BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.廠商資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.幣值資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.進貨資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.狀態 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.類型DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.廠商DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.物品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.幣值 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.總金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本備註 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.進貨處理狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.進貨BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.幣值資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.進貨資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.狀態,
            this.時間DataGridViewTextBoxColumn,
            this.類型DataGridViewTextBoxColumn,
            this.廠商DataGridViewTextBoxColumn,
            this.物品DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.幣值,
            this.單價DataGridViewTextBoxColumn,
            this.總金額DataGridViewTextBoxColumn,
            this.成本,
            this.成本備註,
            this.備註DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.進貨資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1650, 586);
            this.dataGridView1.TabIndex = 0;
            // 
            // 進貨處理狀態BindingSource
            // 
            this.進貨處理狀態BindingSource.DataSource = typeof(WokyTool.通用.列舉.進貨處理狀態);
            // 
            // 進貨BindingSource
            // 
            this.進貨BindingSource.DataSource = typeof(WokyTool.通用.列舉.進貨);
            // 
            // 廠商資料BindingSource
            // 
            this.廠商資料BindingSource.DataSource = typeof(WokyTool.廠商.廠商資料);
            // 
            // 物品資料BindingSource
            // 
            this.物品資料BindingSource.DataSource = typeof(WokyTool.物品.物品資料);
            // 
            // 幣值資料BindingSource
            // 
            this.幣值資料BindingSource.DataSource = typeof(WokyTool.幣值.幣值資料);
            // 
            // 進貨資料BindingSource
            // 
            this.進貨資料BindingSource.DataSource = typeof(WokyTool.進貨.進貨資料);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.匯出ToolStripMenuItem,
            this.更新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1650, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 篩選ToolStripMenuItem
            // 
            this.篩選ToolStripMenuItem.Name = "篩選ToolStripMenuItem";
            this.篩選ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.篩選ToolStripMenuItem.Text = "篩選";
            this.篩選ToolStripMenuItem.Click += new System.EventHandler(this.篩選ToolStripMenuItem_Click);
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            this.匯出ToolStripMenuItem.Click += new System.EventHandler(this.匯出ToolStripMenuItem_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem});
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.新增ToolStripMenuItem.Text = "讀取";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 狀態
            // 
            this.狀態.DataPropertyName = "狀態控制";
            this.狀態.DataSource = this.進貨處理狀態BindingSource;
            this.狀態.HeaderText = "狀態";
            this.狀態.Name = "狀態";
            // 
            // 時間DataGridViewTextBoxColumn
            // 
            this.時間DataGridViewTextBoxColumn.DataPropertyName = "時間";
            this.時間DataGridViewTextBoxColumn.HeaderText = "時間";
            this.時間DataGridViewTextBoxColumn.Name = "時間DataGridViewTextBoxColumn";
            // 
            // 類型DataGridViewTextBoxColumn
            // 
            this.類型DataGridViewTextBoxColumn.DataPropertyName = "類型";
            this.類型DataGridViewTextBoxColumn.DataSource = this.進貨BindingSource;
            this.類型DataGridViewTextBoxColumn.HeaderText = "類型";
            this.類型DataGridViewTextBoxColumn.Name = "類型DataGridViewTextBoxColumn";
            this.類型DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.類型DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 廠商DataGridViewTextBoxColumn
            // 
            this.廠商DataGridViewTextBoxColumn.DataPropertyName = "廠商";
            this.廠商DataGridViewTextBoxColumn.DataSource = this.廠商資料BindingSource;
            this.廠商DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.廠商DataGridViewTextBoxColumn.HeaderText = "廠商";
            this.廠商DataGridViewTextBoxColumn.Name = "廠商DataGridViewTextBoxColumn";
            this.廠商DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.廠商DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.廠商DataGridViewTextBoxColumn.ValueMember = "Self";
            this.廠商DataGridViewTextBoxColumn.Width = 150;
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
            this.物品DataGridViewTextBoxColumn.Width = 300;
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 幣值
            // 
            this.幣值.DataPropertyName = "幣值";
            this.幣值.DataSource = this.幣值資料BindingSource;
            this.幣值.DisplayMember = "名稱";
            this.幣值.HeaderText = "幣值";
            this.幣值.Name = "幣值";
            this.幣值.ValueMember = "Self";
            // 
            // 單價DataGridViewTextBoxColumn
            // 
            this.單價DataGridViewTextBoxColumn.DataPropertyName = "單價";
            this.單價DataGridViewTextBoxColumn.HeaderText = "單價";
            this.單價DataGridViewTextBoxColumn.Name = "單價DataGridViewTextBoxColumn";
            // 
            // 總金額DataGridViewTextBoxColumn
            // 
            this.總金額DataGridViewTextBoxColumn.DataPropertyName = "總金額";
            this.總金額DataGridViewTextBoxColumn.HeaderText = "總金額";
            this.總金額DataGridViewTextBoxColumn.Name = "總金額DataGridViewTextBoxColumn";
            this.總金額DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 成本
            // 
            this.成本.DataPropertyName = "成本";
            this.成本.HeaderText = "成本";
            this.成本.Name = "成本";
            // 
            // 成本備註
            // 
            this.成本備註.DataPropertyName = "成本備註";
            this.成本備註.HeaderText = "成本備註";
            this.成本備註.Name = "成本備註";
            this.成本備註.Width = 150;
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            // 
            // 進貨總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 610);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "進貨總覽視窗";
            this.Text = "進貨總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.進貨處理狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.進貨BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.幣值資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.進貨資料BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 進貨BindingSource;
        private System.Windows.Forms.BindingSource 廠商資料BindingSource;
        private System.Windows.Forms.BindingSource 物品資料BindingSource;
        private System.Windows.Forms.BindingSource 進貨資料BindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 幣值資料BindingSource;
        private System.Windows.Forms.BindingSource 進貨處理狀態BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 狀態;
        private System.Windows.Forms.DataGridViewTextBoxColumn 時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 類型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 廠商DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 物品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 幣值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 總金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本備註;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
    }
}