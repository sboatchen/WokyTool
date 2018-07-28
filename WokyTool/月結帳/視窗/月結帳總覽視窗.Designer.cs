namespace WokyTool.月結帳
{
    partial class 月結帳總覽視窗
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
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.總覽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.公司資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客戶DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.客戶資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.含稅單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.總金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.利潤DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.總利潤DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月結帳資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.月結帳資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.匯出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1296, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.匯出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.總覽ToolStripMenuItem});
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            // 
            // 總覽ToolStripMenuItem
            // 
            this.總覽ToolStripMenuItem.Name = "總覽ToolStripMenuItem";
            this.總覽ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.總覽ToolStripMenuItem.Text = "總覽";
            this.總覽ToolStripMenuItem.Click += new System.EventHandler(this.總覽ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.公司DataGridViewTextBoxColumn,
            this.客戶DataGridViewTextBoxColumn,
            this.商品DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.單價DataGridViewTextBoxColumn,
            this.含稅單價DataGridViewTextBoxColumn,
            this.總金額DataGridViewTextBoxColumn,
            this.成本DataGridViewTextBoxColumn,
            this.利潤DataGridViewTextBoxColumn,
            this.總利潤DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.月結帳資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1296, 501);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 公司DataGridViewTextBoxColumn
            // 
            this.公司DataGridViewTextBoxColumn.DataPropertyName = "公司";
            this.公司DataGridViewTextBoxColumn.DataSource = this.公司資料BindingSource;
            this.公司DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.公司DataGridViewTextBoxColumn.HeaderText = "公司";
            this.公司DataGridViewTextBoxColumn.Name = "公司DataGridViewTextBoxColumn";
            this.公司DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.公司DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.公司DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 公司資料BindingSource
            // 
            this.公司資料BindingSource.DataSource = typeof(WokyTool.公司.公司資料);
            // 
            // 客戶DataGridViewTextBoxColumn
            // 
            this.客戶DataGridViewTextBoxColumn.DataPropertyName = "客戶";
            this.客戶DataGridViewTextBoxColumn.DataSource = this.客戶資料BindingSource;
            this.客戶DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.客戶DataGridViewTextBoxColumn.HeaderText = "客戶";
            this.客戶DataGridViewTextBoxColumn.Name = "客戶DataGridViewTextBoxColumn";
            this.客戶DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.客戶DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.客戶DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 客戶資料BindingSource
            // 
            this.客戶資料BindingSource.DataSource = typeof(WokyTool.客戶.客戶資料);
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
            // 成本DataGridViewTextBoxColumn
            // 
            this.成本DataGridViewTextBoxColumn.DataPropertyName = "成本";
            this.成本DataGridViewTextBoxColumn.HeaderText = "成本";
            this.成本DataGridViewTextBoxColumn.Name = "成本DataGridViewTextBoxColumn";
            this.成本DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 利潤DataGridViewTextBoxColumn
            // 
            this.利潤DataGridViewTextBoxColumn.DataPropertyName = "利潤";
            this.利潤DataGridViewTextBoxColumn.HeaderText = "利潤";
            this.利潤DataGridViewTextBoxColumn.Name = "利潤DataGridViewTextBoxColumn";
            this.利潤DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 總利潤DataGridViewTextBoxColumn
            // 
            this.總利潤DataGridViewTextBoxColumn.DataPropertyName = "總利潤";
            this.總利潤DataGridViewTextBoxColumn.HeaderText = "總利潤";
            this.總利潤DataGridViewTextBoxColumn.Name = "總利潤DataGridViewTextBoxColumn";
            this.總利潤DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 月結帳資料BindingSource
            // 
            this.月結帳資料BindingSource.DataSource = typeof(WokyTool.月結帳.月結帳資料);
            // 
            // 月結帳總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 525);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "月結帳總覽視窗";
            this.Text = "月結帳總覽視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.月結帳資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 總覽ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 公司資料BindingSource;
        private System.Windows.Forms.BindingSource 客戶資料BindingSource;
        private System.Windows.Forms.BindingSource 商品資料BindingSource;
        private System.Windows.Forms.BindingSource 月結帳資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 公司DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 客戶DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 商品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 含稅單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 總金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 利潤DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 總利潤DataGridViewTextBoxColumn;
    }
}