﻿namespace WokyTool.客戶
{
    partial class 客戶總覽視窗
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
            this.客戶資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.子客戶數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.聯絡人數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 客戶資料BindingSource
            // 
            this.客戶資料BindingSource.DataSource = typeof(WokyTool.客戶.客戶資料);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.檢查ToolStripMenuItem,
            this.匯出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 篩選ToolStripMenuItem
            // 
            this.篩選ToolStripMenuItem.Name = "篩選ToolStripMenuItem";
            this.篩選ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.篩選ToolStripMenuItem.Text = "篩選";
            this.篩選ToolStripMenuItem.Click += new System.EventHandler(this.篩選ToolStripMenuItem_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.子客戶數量DataGridViewTextBoxColumn,
            this.聯絡人數量DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.客戶資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 345);
            this.dataGridView1.TabIndex = 4;
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            // 
            // 子客戶數量DataGridViewTextBoxColumn
            // 
            this.子客戶數量DataGridViewTextBoxColumn.DataPropertyName = "子客戶數量";
            this.子客戶數量DataGridViewTextBoxColumn.HeaderText = "子客戶數量";
            this.子客戶數量DataGridViewTextBoxColumn.Name = "子客戶數量DataGridViewTextBoxColumn";
            this.子客戶數量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 聯絡人數量DataGridViewTextBoxColumn
            // 
            this.聯絡人數量DataGridViewTextBoxColumn.DataPropertyName = "聯絡人數量";
            this.聯絡人數量DataGridViewTextBoxColumn.HeaderText = "聯絡人數量";
            this.聯絡人數量DataGridViewTextBoxColumn.Name = "聯絡人數量DataGridViewTextBoxColumn";
            this.聯絡人數量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 客戶總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 369);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "客戶總覽視窗";
            this.Text = "客戶總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource 客戶資料BindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 子客戶數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 聯絡人數量DataGridViewTextBoxColumn;
    }
}