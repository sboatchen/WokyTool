namespace WokyTool.預留
{
    partial class 預留新增總覽視窗
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.預留資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.開始日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.結束日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否保留中DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.預留資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AutoGenerateColumns = false;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.開始日期DataGridViewTextBoxColumn,
            this.結束日期DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.單品名稱DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn,
            this.是否保留中DataGridViewCheckBoxColumn});
            this.myDataGridView1.DataSource = this.預留資料BindingSource;
            this.myDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView1.Location = new System.Drawing.Point(0, 24);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.RowTemplate.Height = 24;
            this.myDataGridView1.Size = new System.Drawing.Size(1246, 432);
            this.myDataGridView1.TabIndex = 3;
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
            this.menuStrip1.Size = new System.Drawing.Size(1246, 24);
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
            this.更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.通用ToolStripMenuItem});
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            // 
            // 通用ToolStripMenuItem
            // 
            this.通用ToolStripMenuItem.Name = "通用ToolStripMenuItem";
            this.通用ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.通用ToolStripMenuItem.Text = "通用";
            this.通用ToolStripMenuItem.Click += new System.EventHandler(this.通用ToolStripMenuItem_Click);
            // 
            // 預留資料BindingSource
            // 
            this.預留資料BindingSource.DataSource = typeof(WokyTool.預留.預留資料);
            // 
            // 開始日期DataGridViewTextBoxColumn
            // 
            this.開始日期DataGridViewTextBoxColumn.DataPropertyName = "開始日期";
            this.開始日期DataGridViewTextBoxColumn.HeaderText = "開始日期";
            this.開始日期DataGridViewTextBoxColumn.Name = "開始日期DataGridViewTextBoxColumn";
            // 
            // 結束日期DataGridViewTextBoxColumn
            // 
            this.結束日期DataGridViewTextBoxColumn.DataPropertyName = "結束日期";
            this.結束日期DataGridViewTextBoxColumn.HeaderText = "結束日期";
            this.結束日期DataGridViewTextBoxColumn.Name = "結束日期DataGridViewTextBoxColumn";
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            this.名稱DataGridViewTextBoxColumn.Width = 200;
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 單品名稱DataGridViewTextBoxColumn
            // 
            this.單品名稱DataGridViewTextBoxColumn.DataPropertyName = "單品名稱";
            this.單品名稱DataGridViewTextBoxColumn.HeaderText = "單品";
            this.單品名稱DataGridViewTextBoxColumn.Name = "單品名稱DataGridViewTextBoxColumn";
            this.單品名稱DataGridViewTextBoxColumn.ReadOnly = true;
            this.單品名稱DataGridViewTextBoxColumn.Width = 400;
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
            // 是否保留中DataGridViewCheckBoxColumn
            // 
            this.是否保留中DataGridViewCheckBoxColumn.DataPropertyName = "是否保留中";
            this.是否保留中DataGridViewCheckBoxColumn.HeaderText = "是否保留中";
            this.是否保留中DataGridViewCheckBoxColumn.Name = "是否保留中DataGridViewCheckBoxColumn";
            this.是否保留中DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // 預留新增總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 456);
            this.Controls.Add(this.myDataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "預留新增總覽視窗";
            this.Text = "預留新增總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.預留資料BindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem 通用ToolStripMenuItem;
        private 通用.MyDataGridView myDataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 開始日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 結束日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 是否保留中DataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource 預留資料BindingSource;
    }
}