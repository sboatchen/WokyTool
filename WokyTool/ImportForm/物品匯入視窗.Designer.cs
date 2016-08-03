namespace WokyTool
{
    partial class 物品匯入視窗
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
            this.物品匯入結構BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品大類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品小類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品品牌資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.大類名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.大類編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.小類名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小類編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.品牌名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品牌編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.縮寫DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.條碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.體積DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.庫存總成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最後進貨成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品匯入結構BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品大類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品小類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品品牌資料BindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
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
            this.名稱DataGridViewTextBoxColumn,
            this.大類名稱DataGridViewTextBoxColumn,
            this.大類編號DataGridViewTextBoxColumn,
            this.小類名稱DataGridViewTextBoxColumn,
            this.小類編號DataGridViewTextBoxColumn,
            this.品牌名稱DataGridViewTextBoxColumn,
            this.品牌編號DataGridViewTextBoxColumn,
            this.縮寫DataGridViewTextBoxColumn,
            this.條碼DataGridViewTextBoxColumn,
            this.體積DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.庫存總成本DataGridViewTextBoxColumn,
            this.最後進貨成本DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.物品匯入結構BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 457);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // 物品匯入結構BindingSource
            // 
            this.物品匯入結構BindingSource.DataSource = typeof(WokyTool.DataImport.物品匯入結構);
            // 
            // 物品大類資料BindingSource
            // 
            this.物品大類資料BindingSource.DataSource = typeof(WokyTool.Data.物品大類資料);
            // 
            // 物品小類資料BindingSource
            // 
            this.物品小類資料BindingSource.DataSource = typeof(WokyTool.Data.物品小類資料);
            // 
            // 物品品牌資料BindingSource
            // 
            this.物品品牌資料BindingSource.DataSource = typeof(WokyTool.Data.物品品牌資料);
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            // 
            // 大類名稱DataGridViewTextBoxColumn
            // 
            this.大類名稱DataGridViewTextBoxColumn.DataPropertyName = "大類名稱";
            this.大類名稱DataGridViewTextBoxColumn.HeaderText = "大類名稱";
            this.大類名稱DataGridViewTextBoxColumn.Name = "大類名稱DataGridViewTextBoxColumn";
            // 
            // 大類編號DataGridViewTextBoxColumn
            // 
            this.大類編號DataGridViewTextBoxColumn.DataPropertyName = "大類編號";
            this.大類編號DataGridViewTextBoxColumn.DataSource = this.物品大類資料BindingSource;
            this.大類編號DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.大類編號DataGridViewTextBoxColumn.HeaderText = "大類編號";
            this.大類編號DataGridViewTextBoxColumn.Name = "大類編號DataGridViewTextBoxColumn";
            this.大類編號DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.大類編號DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.大類編號DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 小類名稱DataGridViewTextBoxColumn
            // 
            this.小類名稱DataGridViewTextBoxColumn.DataPropertyName = "小類名稱";
            this.小類名稱DataGridViewTextBoxColumn.HeaderText = "小類名稱";
            this.小類名稱DataGridViewTextBoxColumn.Name = "小類名稱DataGridViewTextBoxColumn";
            // 
            // 小類編號DataGridViewTextBoxColumn
            // 
            this.小類編號DataGridViewTextBoxColumn.DataPropertyName = "小類編號";
            this.小類編號DataGridViewTextBoxColumn.DataSource = this.物品小類資料BindingSource;
            this.小類編號DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.小類編號DataGridViewTextBoxColumn.HeaderText = "小類編號";
            this.小類編號DataGridViewTextBoxColumn.Name = "小類編號DataGridViewTextBoxColumn";
            this.小類編號DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.小類編號DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.小類編號DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 品牌名稱DataGridViewTextBoxColumn
            // 
            this.品牌名稱DataGridViewTextBoxColumn.DataPropertyName = "品牌名稱";
            this.品牌名稱DataGridViewTextBoxColumn.HeaderText = "品牌名稱";
            this.品牌名稱DataGridViewTextBoxColumn.Name = "品牌名稱DataGridViewTextBoxColumn";
            // 
            // 品牌編號DataGridViewTextBoxColumn
            // 
            this.品牌編號DataGridViewTextBoxColumn.DataPropertyName = "品牌編號";
            this.品牌編號DataGridViewTextBoxColumn.DataSource = this.物品品牌資料BindingSource;
            this.品牌編號DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.品牌編號DataGridViewTextBoxColumn.HeaderText = "品牌編號";
            this.品牌編號DataGridViewTextBoxColumn.Name = "品牌編號DataGridViewTextBoxColumn";
            this.品牌編號DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.品牌編號DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.品牌編號DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 縮寫DataGridViewTextBoxColumn
            // 
            this.縮寫DataGridViewTextBoxColumn.DataPropertyName = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.HeaderText = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.Name = "縮寫DataGridViewTextBoxColumn";
            // 
            // 條碼DataGridViewTextBoxColumn
            // 
            this.條碼DataGridViewTextBoxColumn.DataPropertyName = "條碼";
            this.條碼DataGridViewTextBoxColumn.HeaderText = "條碼";
            this.條碼DataGridViewTextBoxColumn.Name = "條碼DataGridViewTextBoxColumn";
            // 
            // 體積DataGridViewTextBoxColumn
            // 
            this.體積DataGridViewTextBoxColumn.DataPropertyName = "體積";
            this.體積DataGridViewTextBoxColumn.HeaderText = "體積";
            this.體積DataGridViewTextBoxColumn.Name = "體積DataGridViewTextBoxColumn";
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
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
            // 物品匯入視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "物品匯入視窗";
            this.Text = "物品匯入視窗";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.物品匯入視窗_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品匯入結構BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品大類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品小類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品品牌資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列錯ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 大類名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 大類編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 物品大類資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小類名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 小類編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 物品小類資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 品牌編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 物品品牌資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 縮寫DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 條碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 體積DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 庫存總成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最後進貨成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 物品匯入結構BindingSource;
    }
}