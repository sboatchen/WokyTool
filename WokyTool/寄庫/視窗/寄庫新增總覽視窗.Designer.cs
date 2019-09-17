﻿namespace WokyTool.寄庫
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
            this.公司名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客戶名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入庫單號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.寄庫資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.寄庫資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AllowUserToAddRows = false;
            this.myDataGridView1.AutoGenerateColumns = false;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.處理時間DataGridViewTextBoxColumn,
            this.公司名稱DataGridViewTextBoxColumn,
            this.客戶名稱DataGridViewTextBoxColumn,
            this.商品名稱DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.入庫單號DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn});
            this.myDataGridView1.DataSource = this.寄庫資料BindingSource;
            this.myDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView1.Location = new System.Drawing.Point(0, 28);
            this.myDataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.RowTemplate.Height = 24;
            this.myDataGridView1.Size = new System.Drawing.Size(1257, 542);
            this.myDataGridView1.TabIndex = 3;
            // 
            // 處理時間DataGridViewTextBoxColumn
            // 
            this.處理時間DataGridViewTextBoxColumn.DataPropertyName = "處理時間";
            this.處理時間DataGridViewTextBoxColumn.HeaderText = "處理時間";
            this.處理時間DataGridViewTextBoxColumn.Name = "處理時間DataGridViewTextBoxColumn";
            // 
            // 公司名稱DataGridViewTextBoxColumn
            // 
            this.公司名稱DataGridViewTextBoxColumn.DataPropertyName = "公司名稱";
            this.公司名稱DataGridViewTextBoxColumn.HeaderText = "公司";
            this.公司名稱DataGridViewTextBoxColumn.Name = "公司名稱DataGridViewTextBoxColumn";
            this.公司名稱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 客戶名稱DataGridViewTextBoxColumn
            // 
            this.客戶名稱DataGridViewTextBoxColumn.DataPropertyName = "客戶名稱";
            this.客戶名稱DataGridViewTextBoxColumn.HeaderText = "客戶";
            this.客戶名稱DataGridViewTextBoxColumn.Name = "客戶名稱DataGridViewTextBoxColumn";
            this.客戶名稱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 商品名稱DataGridViewTextBoxColumn
            // 
            this.商品名稱DataGridViewTextBoxColumn.DataPropertyName = "商品名稱";
            this.商品名稱DataGridViewTextBoxColumn.HeaderText = "商品";
            this.商品名稱DataGridViewTextBoxColumn.Name = "商品名稱DataGridViewTextBoxColumn";
            this.商品名稱DataGridViewTextBoxColumn.ReadOnly = true;
            this.商品名稱DataGridViewTextBoxColumn.Width = 300;
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 入庫單號DataGridViewTextBoxColumn
            // 
            this.入庫單號DataGridViewTextBoxColumn.DataPropertyName = "入庫單號";
            this.入庫單號DataGridViewTextBoxColumn.HeaderText = "入庫單號";
            this.入庫單號DataGridViewTextBoxColumn.Name = "入庫單號DataGridViewTextBoxColumn";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1257, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 篩選ToolStripMenuItem
            // 
            this.篩選ToolStripMenuItem.Name = "篩選ToolStripMenuItem";
            this.篩選ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.篩選ToolStripMenuItem.Text = "篩選";
            // 
            // 檢查ToolStripMenuItem
            // 
            this.檢查ToolStripMenuItem.Name = "檢查ToolStripMenuItem";
            this.檢查ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.檢查ToolStripMenuItem.Text = "檢查";
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂ToolStripMenuItem});
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.匯出ToolStripMenuItem.Text = "匯出";
            // 
            // 自訂ToolStripMenuItem
            // 
            this.自訂ToolStripMenuItem.Name = "自訂ToolStripMenuItem";
            this.自訂ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.自訂ToolStripMenuItem.Text = "自訂";
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通用ToolStripMenuItem});
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // 通用ToolStripMenuItem
            // 
            this.通用ToolStripMenuItem.Name = "通用ToolStripMenuItem";
            this.通用ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.通用ToolStripMenuItem.Text = "通用";
            this.通用ToolStripMenuItem.Click += new System.EventHandler(this.通用ToolStripMenuItem_Click);
            // 
            // 寄庫總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 570);
            this.Controls.Add(this.myDataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ToolStripMenuItem 通用ToolStripMenuItem;
        private 通用.MyDataGridView myDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 處理時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客戶名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入庫單號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 寄庫資料BindingSource;
    }
}