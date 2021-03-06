﻿using WokyTool.通用;
namespace WokyTool.單品
{
    partial class 單品總覽視窗
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
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.盤點ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.單品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new WokyTool.通用.MyDataGridView();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品類名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.供應商名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品牌名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.縮寫DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.國際條碼 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.類別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顏色DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.庫存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.庫存總成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最後進貨成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.保留 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.儲位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.單品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1749, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.自訂ToolStripMenuItem,
            this.盤點ToolStripMenuItem});
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
            // 盤點ToolStripMenuItem
            // 
            this.盤點ToolStripMenuItem.Name = "盤點ToolStripMenuItem";
            this.盤點ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.盤點ToolStripMenuItem.Text = "盤點";
            this.盤點ToolStripMenuItem.Click += new System.EventHandler(this.盤點ToolStripMenuItem_Click);
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
            // 單品資料BindingSource
            // 
            this.單品資料BindingSource.DataSource = typeof(WokyTool.單品.單品資料);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.品類名稱DataGridViewTextBoxColumn,
            this.供應商名稱DataGridViewTextBoxColumn,
            this.品牌名稱DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.縮寫DataGridViewTextBoxColumn,
            this.國際條碼,
            this.類別DataGridViewTextBoxColumn,
            this.顏色DataGridViewTextBoxColumn,
            this.庫存DataGridViewTextBoxColumn,
            this.庫存總成本DataGridViewTextBoxColumn,
            this.最後進貨成本DataGridViewTextBoxColumn,
            this.成本DataGridViewTextBoxColumn,
            this.成本備註DataGridViewTextBoxColumn,
            this.保留,
            this.儲位});
            this.dataGridView1.DataSource = this.單品資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1749, 487);
            this.dataGridView1.TabIndex = 2;
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 品類名稱DataGridViewTextBoxColumn
            // 
            this.品類名稱DataGridViewTextBoxColumn.DataPropertyName = "品類名稱";
            this.品類名稱DataGridViewTextBoxColumn.HeaderText = "品類";
            this.品類名稱DataGridViewTextBoxColumn.Name = "品類名稱DataGridViewTextBoxColumn";
            this.品類名稱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 供應商名稱DataGridViewTextBoxColumn
            // 
            this.供應商名稱DataGridViewTextBoxColumn.DataPropertyName = "供應商名稱";
            this.供應商名稱DataGridViewTextBoxColumn.HeaderText = "供應商";
            this.供應商名稱DataGridViewTextBoxColumn.Name = "供應商名稱DataGridViewTextBoxColumn";
            this.供應商名稱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 品牌名稱DataGridViewTextBoxColumn
            // 
            this.品牌名稱DataGridViewTextBoxColumn.DataPropertyName = "品牌名稱";
            this.品牌名稱DataGridViewTextBoxColumn.HeaderText = "品牌";
            this.品牌名稱DataGridViewTextBoxColumn.Name = "品牌名稱DataGridViewTextBoxColumn";
            this.品牌名稱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            this.名稱DataGridViewTextBoxColumn.Width = 200;
            // 
            // 縮寫DataGridViewTextBoxColumn
            // 
            this.縮寫DataGridViewTextBoxColumn.DataPropertyName = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.HeaderText = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.Name = "縮寫DataGridViewTextBoxColumn";
            // 
            // 國際條碼
            // 
            this.國際條碼.DataPropertyName = "國際條碼";
            this.國際條碼.HeaderText = "國際條碼";
            this.國際條碼.Name = "國際條碼";
            // 
            // 類別DataGridViewTextBoxColumn
            // 
            this.類別DataGridViewTextBoxColumn.DataPropertyName = "類別";
            this.類別DataGridViewTextBoxColumn.HeaderText = "類別";
            this.類別DataGridViewTextBoxColumn.Name = "類別DataGridViewTextBoxColumn";
            // 
            // 顏色DataGridViewTextBoxColumn
            // 
            this.顏色DataGridViewTextBoxColumn.DataPropertyName = "顏色";
            this.顏色DataGridViewTextBoxColumn.HeaderText = "顏色";
            this.顏色DataGridViewTextBoxColumn.Name = "顏色DataGridViewTextBoxColumn";
            // 
            // 庫存DataGridViewTextBoxColumn
            // 
            this.庫存DataGridViewTextBoxColumn.DataPropertyName = "庫存";
            this.庫存DataGridViewTextBoxColumn.HeaderText = "庫存";
            this.庫存DataGridViewTextBoxColumn.Name = "庫存DataGridViewTextBoxColumn";
            this.庫存DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 庫存總成本DataGridViewTextBoxColumn
            // 
            this.庫存總成本DataGridViewTextBoxColumn.DataPropertyName = "庫存總成本";
            this.庫存總成本DataGridViewTextBoxColumn.HeaderText = "庫存總成本";
            this.庫存總成本DataGridViewTextBoxColumn.Name = "庫存總成本DataGridViewTextBoxColumn";
            this.庫存總成本DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 最後進貨成本DataGridViewTextBoxColumn
            // 
            this.最後進貨成本DataGridViewTextBoxColumn.DataPropertyName = "最後進貨成本";
            this.最後進貨成本DataGridViewTextBoxColumn.HeaderText = "最後進貨成本";
            this.最後進貨成本DataGridViewTextBoxColumn.Name = "最後進貨成本DataGridViewTextBoxColumn";
            this.最後進貨成本DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 成本DataGridViewTextBoxColumn
            // 
            this.成本DataGridViewTextBoxColumn.DataPropertyName = "成本";
            this.成本DataGridViewTextBoxColumn.HeaderText = "成本";
            this.成本DataGridViewTextBoxColumn.Name = "成本DataGridViewTextBoxColumn";
            this.成本DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 成本備註DataGridViewTextBoxColumn
            // 
            this.成本備註DataGridViewTextBoxColumn.DataPropertyName = "成本備註";
            this.成本備註DataGridViewTextBoxColumn.HeaderText = "成本備註";
            this.成本備註DataGridViewTextBoxColumn.Name = "成本備註DataGridViewTextBoxColumn";
            // 
            // 保留
            // 
            this.保留.DataPropertyName = "保留";
            this.保留.HeaderText = "保留";
            this.保留.Name = "保留";
            this.保留.ReadOnly = true;
            // 
            // 儲位
            // 
            this.儲位.DataPropertyName = "儲位";
            this.儲位.HeaderText = "儲位";
            this.儲位.Name = "儲位";
            // 
            // 單品總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "單品總覽視窗";
            this.Text = "單品總覽視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.單品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 盤點ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 單品資料BindingSource;
        private MyDataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品類名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 供應商名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 縮寫DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 國際條碼;
        private System.Windows.Forms.DataGridViewTextBoxColumn 類別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顏色DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 庫存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 庫存總成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最後進貨成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 保留;
        private System.Windows.Forms.DataGridViewTextBoxColumn 儲位;
    }
}