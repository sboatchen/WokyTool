namespace WokyTool.寄庫
{
    partial class 寄庫總覽視窗
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
            this.myDataGridView1 = new WokyTool.通用.MyDataGridView();
            this.處理時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.處理者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客戶DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入庫單號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.寄庫資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.寄庫資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AutoGenerateColumns = false;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.處理時間DataGridViewTextBoxColumn,
            this.處理者DataGridViewTextBoxColumn,
            this.公司DataGridViewTextBoxColumn,
            this.客戶DataGridViewTextBoxColumn,
            this.入庫單號DataGridViewTextBoxColumn,
            this.商品DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn});
            this.myDataGridView1.DataSource = this.寄庫資料BindingSource;
            this.myDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView1.Location = new System.Drawing.Point(0, 24);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.RowTemplate.Height = 24;
            this.myDataGridView1.Size = new System.Drawing.Size(1144, 444);
            this.myDataGridView1.TabIndex = 3;
            // 
            // 處理時間DataGridViewTextBoxColumn
            // 
            this.處理時間DataGridViewTextBoxColumn.DataPropertyName = "處理時間";
            this.處理時間DataGridViewTextBoxColumn.HeaderText = "處理時間";
            this.處理時間DataGridViewTextBoxColumn.Name = "處理時間DataGridViewTextBoxColumn";
            // 
            // 處理者DataGridViewTextBoxColumn
            // 
            this.處理者DataGridViewTextBoxColumn.DataPropertyName = "處理者";
            this.處理者DataGridViewTextBoxColumn.HeaderText = "處理者";
            this.處理者DataGridViewTextBoxColumn.Name = "處理者DataGridViewTextBoxColumn";
            // 
            // 公司DataGridViewTextBoxColumn
            // 
            this.公司DataGridViewTextBoxColumn.DataPropertyName = "公司";
            this.公司DataGridViewTextBoxColumn.HeaderText = "公司";
            this.公司DataGridViewTextBoxColumn.Name = "公司DataGridViewTextBoxColumn";
            // 
            // 客戶DataGridViewTextBoxColumn
            // 
            this.客戶DataGridViewTextBoxColumn.DataPropertyName = "客戶";
            this.客戶DataGridViewTextBoxColumn.HeaderText = "客戶";
            this.客戶DataGridViewTextBoxColumn.Name = "客戶DataGridViewTextBoxColumn";
            // 
            // 入庫單號DataGridViewTextBoxColumn
            // 
            this.入庫單號DataGridViewTextBoxColumn.DataPropertyName = "入庫單號";
            this.入庫單號DataGridViewTextBoxColumn.HeaderText = "入庫單號";
            this.入庫單號DataGridViewTextBoxColumn.Name = "入庫單號DataGridViewTextBoxColumn";
            // 
            // 商品DataGridViewTextBoxColumn
            // 
            this.商品DataGridViewTextBoxColumn.DataPropertyName = "商品";
            this.商品DataGridViewTextBoxColumn.HeaderText = "商品";
            this.商品DataGridViewTextBoxColumn.Name = "商品DataGridViewTextBoxColumn";
            this.商品DataGridViewTextBoxColumn.Width = 400;
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            // 
            // 寄庫資料BindingSource
            // 
            this.寄庫資料BindingSource.DataSource = typeof(WokyTool.寄庫.寄庫資料);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.檢查ToolStripMenuItem,
            this.匯出ToolStripMenuItem,
            this.更新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 篩選ToolStripMenuItem
            // 
            this.篩選ToolStripMenuItem.Name = "篩選ToolStripMenuItem";
            this.篩選ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.篩選ToolStripMenuItem.Text = "篩選";
            // 
            // 檢查ToolStripMenuItem
            // 
            this.檢查ToolStripMenuItem.Name = "檢查ToolStripMenuItem";
            this.檢查ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檢查ToolStripMenuItem.Text = "檢查";
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂ToolStripMenuItem});
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            // 
            // 自訂ToolStripMenuItem
            // 
            this.自訂ToolStripMenuItem.Name = "自訂ToolStripMenuItem";
            this.自訂ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.自訂ToolStripMenuItem.Text = "自訂";
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // 寄庫總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 468);
            this.Controls.Add(this.myDataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "寄庫總覽視窗";
            this.Text = "寄庫總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.寄庫資料BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private 通用.MyDataGridView myDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 處理時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 處理者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客戶DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入庫單號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 寄庫資料BindingSource;
    }
}