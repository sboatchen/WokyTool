namespace WokyTool.月結帳
{
    partial class 月結帳匯入視窗
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
            this.訂單編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.含稅單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.總金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.錯誤訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月結帳匯入資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式 = new System.Windows.Forms.ToolStripComboBox();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.月結帳匯入資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.訂單編號DataGridViewTextBoxColumn,
            this.商品識別DataGridViewTextBoxColumn,
            this.商品DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.單價DataGridViewTextBoxColumn,
            this.含稅單價DataGridViewTextBoxColumn,
            this.總金額DataGridViewTextBoxColumn,
            this.錯誤訊息DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.月結帳匯入資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 469);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // 訂單編號DataGridViewTextBoxColumn
            // 
            this.訂單編號DataGridViewTextBoxColumn.DataPropertyName = "訂單編號";
            this.訂單編號DataGridViewTextBoxColumn.HeaderText = "訂單編號";
            this.訂單編號DataGridViewTextBoxColumn.Name = "訂單編號DataGridViewTextBoxColumn";
            // 
            // 商品識別DataGridViewTextBoxColumn
            // 
            this.商品識別DataGridViewTextBoxColumn.DataPropertyName = "商品識別";
            this.商品識別DataGridViewTextBoxColumn.HeaderText = "商品識別";
            this.商品識別DataGridViewTextBoxColumn.Name = "商品識別DataGridViewTextBoxColumn";
            this.商品識別DataGridViewTextBoxColumn.Width = 250;
            // 
            // 商品DataGridViewTextBoxColumn
            // 
            this.商品DataGridViewTextBoxColumn.DataPropertyName = "商品";
            this.商品DataGridViewTextBoxColumn.DataSource = this.商品資料BindingSource;
            this.商品DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.商品DataGridViewTextBoxColumn.HeaderText = "商品";
            this.商品DataGridViewTextBoxColumn.Name = "商品DataGridViewTextBoxColumn";
            this.商品DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.商品DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.商品DataGridViewTextBoxColumn.ValueMember = "Self";
            this.商品DataGridViewTextBoxColumn.Width = 250;
            // 
            // 商品資料BindingSource
            // 
            this.商品資料BindingSource.DataSource = typeof(WokyTool.商品.商品資料);
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
            // 含稅單價DataGridViewTextBoxColumn
            // 
            this.含稅單價DataGridViewTextBoxColumn.DataPropertyName = "含稅單價";
            this.含稅單價DataGridViewTextBoxColumn.HeaderText = "含稅單價";
            this.含稅單價DataGridViewTextBoxColumn.Name = "含稅單價DataGridViewTextBoxColumn";
            // 
            // 總金額DataGridViewTextBoxColumn
            // 
            this.總金額DataGridViewTextBoxColumn.DataPropertyName = "總金額";
            this.總金額DataGridViewTextBoxColumn.HeaderText = "總金額";
            this.總金額DataGridViewTextBoxColumn.Name = "總金額DataGridViewTextBoxColumn";
            this.總金額DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 錯誤訊息DataGridViewTextBoxColumn
            // 
            this.錯誤訊息DataGridViewTextBoxColumn.DataPropertyName = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.HeaderText = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.Name = "錯誤訊息DataGridViewTextBoxColumn";
            this.錯誤訊息DataGridViewTextBoxColumn.Width = 150;
            // 
            // 月結帳匯入資料BindingSource
            // 
            this.月結帳匯入資料BindingSource.DataSource = typeof(WokyTool.月結帳.月結帳匯入資料);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.匯入ToolStripMenuItem,
            this.檢查ToolStripMenuItem,
            this.匯出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 匯入ToolStripMenuItem
            // 
            this.匯入ToolStripMenuItem.AutoSize = false;
            this.匯入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.格式});
            this.匯入ToolStripMenuItem.Name = "匯入ToolStripMenuItem";
            this.匯入ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯入ToolStripMenuItem.Text = "匯入";
            // 
            // 格式
            // 
            this.格式.Name = "格式";
            this.格式.Size = new System.Drawing.Size(200, 23);
            this.格式.SelectedIndexChanged += new System.EventHandler(this.設定_SelectedIndexChanged);
            // 
            // 檢查ToolStripMenuItem
            // 
            this.檢查ToolStripMenuItem.Name = "檢查ToolStripMenuItem";
            this.檢查ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檢查ToolStripMenuItem.Text = "檢查";
            this.檢查ToolStripMenuItem.Click += new System.EventHandler(this.檢查ToolStripMenuItem_Click);
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            this.匯出ToolStripMenuItem.Click += new System.EventHandler(this.匯出ToolStripMenuItem_Click);
            // 
            // 月結帳匯入視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "月結帳匯入視窗";
            this.Text = "月結帳匯入視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.月結帳匯入資料BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox 格式;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 月結帳匯入資料BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 商品資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訂單編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 商品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 含稅單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 總金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 錯誤訊息DataGridViewTextBoxColumn;
    }
}