namespace WokyTool
{
    partial class 物品總覽視窗
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
            this.輸出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.庫存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.總覽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.盤點ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.物品品牌資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品大類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品小類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品資料BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.物品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.開啟DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.品牌編號 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.大類編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.小類編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.條碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.原廠編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代理編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.縮寫DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.體積DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上層 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.顏色 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.內庫數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.外庫數量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.庫存總成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最後進貨成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本備註 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品品牌資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品大類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品小類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.刪除ToolStripMenuItem,
            this.輸出ToolStripMenuItem,
            this.篩選ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1221, 24);
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
            // 輸出ToolStripMenuItem
            // 
            this.輸出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.庫存ToolStripMenuItem,
            this.總覽ToolStripMenuItem,
            this.盤點ToolStripMenuItem});
            this.輸出ToolStripMenuItem.Name = "輸出ToolStripMenuItem";
            this.輸出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.輸出ToolStripMenuItem.Text = "輸出";
            // 
            // 庫存ToolStripMenuItem
            // 
            this.庫存ToolStripMenuItem.Name = "庫存ToolStripMenuItem";
            this.庫存ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.庫存ToolStripMenuItem.Text = "庫存";
            this.庫存ToolStripMenuItem.Click += new System.EventHandler(this.庫存ToolStripMenuItem_Click);
            // 
            // 總覽ToolStripMenuItem
            // 
            this.總覽ToolStripMenuItem.Name = "總覽ToolStripMenuItem";
            this.總覽ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.總覽ToolStripMenuItem.Text = "總覽";
            this.總覽ToolStripMenuItem.Click += new System.EventHandler(this.總覽ToolStripMenuItem_Click);
            // 
            // 盤點ToolStripMenuItem
            // 
            this.盤點ToolStripMenuItem.Name = "盤點ToolStripMenuItem";
            this.盤點ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.盤點ToolStripMenuItem.Text = "盤點";
            this.盤點ToolStripMenuItem.Click += new System.EventHandler(this.盤點ToolStripMenuItem_Click);
            // 
            // 篩選ToolStripMenuItem
            // 
            this.篩選ToolStripMenuItem.Name = "篩選ToolStripMenuItem";
            this.篩選ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.篩選ToolStripMenuItem.Text = "篩選";
            this.篩選ToolStripMenuItem.Click += new System.EventHandler(this.篩選ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.開啟DataGridViewCheckBoxColumn,
            this.品牌編號,
            this.大類編號DataGridViewTextBoxColumn,
            this.小類編號DataGridViewTextBoxColumn,
            this.條碼DataGridViewTextBoxColumn,
            this.原廠編號,
            this.代理編號,
            this.名稱DataGridViewTextBoxColumn,
            this.縮寫DataGridViewTextBoxColumn,
            this.體積DataGridViewTextBoxColumn,
            this.上層,
            this.顏色,
            this.內庫數量DataGridViewTextBoxColumn,
            this.外庫數量,
            this.庫存總成本DataGridViewTextBoxColumn,
            this.最後進貨成本DataGridViewTextBoxColumn,
            this.成本DataGridViewTextBoxColumn,
            this.成本備註});
            this.dataGridView1.DataSource = this.物品資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 429);
            this.dataGridView1.TabIndex = 1;
            // 
            // 物品品牌資料BindingSource
            // 
            this.物品品牌資料BindingSource.DataSource = typeof(WokyTool.Data.物品品牌資料);
            // 
            // 物品大類資料BindingSource
            // 
            this.物品大類資料BindingSource.DataSource = typeof(WokyTool.Data.物品大類資料);
            // 
            // 物品小類資料BindingSource
            // 
            this.物品小類資料BindingSource.DataSource = typeof(WokyTool.Data.物品小類資料);
            // 
            // 物品資料BindingSource1
            // 
            this.物品資料BindingSource1.DataSource = typeof(WokyTool.Data.物品資料);
            // 
            // 物品資料BindingSource
            // 
            this.物品資料BindingSource.DataSource = typeof(WokyTool.Data.物品資料);
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            // 
            // 開啟DataGridViewCheckBoxColumn
            // 
            this.開啟DataGridViewCheckBoxColumn.DataPropertyName = "開啟";
            this.開啟DataGridViewCheckBoxColumn.HeaderText = "開啟";
            this.開啟DataGridViewCheckBoxColumn.Name = "開啟DataGridViewCheckBoxColumn";
            // 
            // 品牌編號
            // 
            this.品牌編號.DataPropertyName = "品牌編號";
            this.品牌編號.DataSource = this.物品品牌資料BindingSource;
            this.品牌編號.DisplayMember = "名稱";
            this.品牌編號.HeaderText = "品牌";
            this.品牌編號.Name = "品牌編號";
            this.品牌編號.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.品牌編號.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.品牌編號.ValueMember = "編號";
            // 
            // 大類編號DataGridViewTextBoxColumn
            // 
            this.大類編號DataGridViewTextBoxColumn.DataPropertyName = "大類編號";
            this.大類編號DataGridViewTextBoxColumn.DataSource = this.物品大類資料BindingSource;
            this.大類編號DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.大類編號DataGridViewTextBoxColumn.HeaderText = "大類";
            this.大類編號DataGridViewTextBoxColumn.Name = "大類編號DataGridViewTextBoxColumn";
            this.大類編號DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.大類編號DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.大類編號DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 小類編號DataGridViewTextBoxColumn
            // 
            this.小類編號DataGridViewTextBoxColumn.DataPropertyName = "小類編號";
            this.小類編號DataGridViewTextBoxColumn.DataSource = this.物品小類資料BindingSource;
            this.小類編號DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.小類編號DataGridViewTextBoxColumn.HeaderText = "小類";
            this.小類編號DataGridViewTextBoxColumn.Name = "小類編號DataGridViewTextBoxColumn";
            this.小類編號DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.小類編號DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.小類編號DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 條碼DataGridViewTextBoxColumn
            // 
            this.條碼DataGridViewTextBoxColumn.DataPropertyName = "條碼";
            this.條碼DataGridViewTextBoxColumn.HeaderText = "條碼";
            this.條碼DataGridViewTextBoxColumn.Name = "條碼DataGridViewTextBoxColumn";
            // 
            // 原廠編號
            // 
            this.原廠編號.DataPropertyName = "原廠編號";
            this.原廠編號.HeaderText = "原廠編號";
            this.原廠編號.Name = "原廠編號";
            // 
            // 代理編號
            // 
            this.代理編號.DataPropertyName = "代理編號";
            this.代理編號.HeaderText = "代理編號";
            this.代理編號.Name = "代理編號";
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            // 
            // 縮寫DataGridViewTextBoxColumn
            // 
            this.縮寫DataGridViewTextBoxColumn.DataPropertyName = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.HeaderText = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.Name = "縮寫DataGridViewTextBoxColumn";
            // 
            // 體積DataGridViewTextBoxColumn
            // 
            this.體積DataGridViewTextBoxColumn.DataPropertyName = "體積";
            this.體積DataGridViewTextBoxColumn.HeaderText = "體積";
            this.體積DataGridViewTextBoxColumn.Name = "體積DataGridViewTextBoxColumn";
            // 
            // 上層
            // 
            this.上層.DataPropertyName = "上層編號";
            this.上層.DataSource = this.物品資料BindingSource1;
            this.上層.DisplayMember = "名稱";
            this.上層.HeaderText = "上層";
            this.上層.Name = "上層";
            this.上層.ValueMember = "編號";
            // 
            // 顏色
            // 
            this.顏色.DataPropertyName = "顏色";
            this.顏色.HeaderText = "顏色";
            this.顏色.Name = "顏色";
            // 
            // 內庫數量DataGridViewTextBoxColumn
            // 
            this.內庫數量DataGridViewTextBoxColumn.DataPropertyName = "內庫數量";
            this.內庫數量DataGridViewTextBoxColumn.HeaderText = "內庫數量";
            this.內庫數量DataGridViewTextBoxColumn.Name = "內庫數量DataGridViewTextBoxColumn";
            this.內庫數量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 外庫數量
            // 
            this.外庫數量.DataPropertyName = "外庫數量";
            this.外庫數量.HeaderText = "外庫數量";
            this.外庫數量.Name = "外庫數量";
            this.外庫數量.ReadOnly = true;
            // 
            // 庫存總成本DataGridViewTextBoxColumn
            // 
            this.庫存總成本DataGridViewTextBoxColumn.DataPropertyName = "庫存總成本";
            this.庫存總成本DataGridViewTextBoxColumn.HeaderText = "庫存總成本";
            this.庫存總成本DataGridViewTextBoxColumn.Name = "庫存總成本DataGridViewTextBoxColumn";
            // 
            // 最後進貨成本DataGridViewTextBoxColumn
            // 
            this.最後進貨成本DataGridViewTextBoxColumn.DataPropertyName = "最後進貨成本";
            this.最後進貨成本DataGridViewTextBoxColumn.HeaderText = "最後進貨成本";
            this.最後進貨成本DataGridViewTextBoxColumn.Name = "最後進貨成本DataGridViewTextBoxColumn";
            // 
            // 成本DataGridViewTextBoxColumn
            // 
            this.成本DataGridViewTextBoxColumn.DataPropertyName = "成本";
            this.成本DataGridViewTextBoxColumn.HeaderText = "成本";
            this.成本DataGridViewTextBoxColumn.Name = "成本DataGridViewTextBoxColumn";
            this.成本DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 成本備註
            // 
            this.成本備註.DataPropertyName = "成本備註";
            this.成本備註.HeaderText = "成本備註";
            this.成本備註.Name = "成本備註";
            // 
            // 物品總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "物品總覽視窗";
            this.Text = "物品總覽視窗";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.物品總覽視窗_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品品牌資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品大類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品小類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 物品大類資料BindingSource;
        private System.Windows.Forms.BindingSource 物品小類資料BindingSource;
        private System.Windows.Forms.BindingSource 物品資料BindingSource;
        private System.Windows.Forms.BindingSource 物品品牌資料BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 輸出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 庫存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 總覽ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 盤點ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 物品資料BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 開啟DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 品牌編號;
        private System.Windows.Forms.DataGridViewComboBoxColumn 大類編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 小類編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 條碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原廠編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代理編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 縮寫DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 體積DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 上層;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顏色;
        private System.Windows.Forms.DataGridViewTextBoxColumn 內庫數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 外庫數量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 庫存總成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最後進貨成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本備註;
    }
}