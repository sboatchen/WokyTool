namespace WokyTool
{
    partial class 商品總覽視窗
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.商品大類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品小類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.廠商資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.開啟DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.大類編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.小類編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.品號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.廠商編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.需求編號1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.數量1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.需求編號2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.數量2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.需求編號3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.數量3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.需求編號4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.數量4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.需求編號5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.數量5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.價格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.體積DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.利潤DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品大類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品小類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.刪除ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1210, 24);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.開啟DataGridViewCheckBoxColumn,
            this.大類編號DataGridViewTextBoxColumn,
            this.小類編號DataGridViewTextBoxColumn,
            this.品號DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.廠商編號DataGridViewTextBoxColumn,
            this.需求編號1DataGridViewTextBoxColumn,
            this.數量1DataGridViewTextBoxColumn,
            this.需求編號2DataGridViewTextBoxColumn,
            this.數量2DataGridViewTextBoxColumn,
            this.需求編號3DataGridViewTextBoxColumn,
            this.數量3DataGridViewTextBoxColumn,
            this.需求編號4DataGridViewTextBoxColumn,
            this.數量4DataGridViewTextBoxColumn,
            this.需求編號5DataGridViewTextBoxColumn,
            this.數量5DataGridViewTextBoxColumn,
            this.價格DataGridViewTextBoxColumn,
            this.成本DataGridViewTextBoxColumn,
            this.體積DataGridViewTextBoxColumn,
            this.利潤DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.商品資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 389);
            this.dataGridView1.TabIndex = 1;
            // 
            // 商品大類資料BindingSource
            // 
            this.商品大類資料BindingSource.DataSource = typeof(WokyTool.Data.商品大類資料);
            // 
            // 商品小類資料BindingSource
            // 
            this.商品小類資料BindingSource.DataSource = typeof(WokyTool.Data.商品小類資料);
            // 
            // 廠商資料BindingSource
            // 
            this.廠商資料BindingSource.DataSource = typeof(WokyTool.Data.廠商資料);
            // 
            // 物品資料BindingSource
            // 
            this.物品資料BindingSource.DataSource = typeof(WokyTool.Data.物品資料);
            // 
            // 商品資料BindingSource
            // 
            this.商品資料BindingSource.DataSource = typeof(WokyTool.Data.商品資料);
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
            // 大類編號DataGridViewTextBoxColumn
            // 
            this.大類編號DataGridViewTextBoxColumn.DataPropertyName = "大類編號";
            this.大類編號DataGridViewTextBoxColumn.DataSource = this.商品大類資料BindingSource;
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
            this.小類編號DataGridViewTextBoxColumn.DataSource = this.商品小類資料BindingSource;
            this.小類編號DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.小類編號DataGridViewTextBoxColumn.HeaderText = "小類";
            this.小類編號DataGridViewTextBoxColumn.Name = "小類編號DataGridViewTextBoxColumn";
            this.小類編號DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.小類編號DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.小類編號DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 品號DataGridViewTextBoxColumn
            // 
            this.品號DataGridViewTextBoxColumn.DataPropertyName = "品號";
            this.品號DataGridViewTextBoxColumn.HeaderText = "品號";
            this.品號DataGridViewTextBoxColumn.Name = "品號DataGridViewTextBoxColumn";
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            // 
            // 廠商編號DataGridViewTextBoxColumn
            // 
            this.廠商編號DataGridViewTextBoxColumn.DataPropertyName = "廠商編號";
            this.廠商編號DataGridViewTextBoxColumn.DataSource = this.廠商資料BindingSource;
            this.廠商編號DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.廠商編號DataGridViewTextBoxColumn.HeaderText = "廠商";
            this.廠商編號DataGridViewTextBoxColumn.Name = "廠商編號DataGridViewTextBoxColumn";
            this.廠商編號DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.廠商編號DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.廠商編號DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 需求編號1DataGridViewTextBoxColumn
            // 
            this.需求編號1DataGridViewTextBoxColumn.DataPropertyName = "需求編號1";
            this.需求編號1DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.需求編號1DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.需求編號1DataGridViewTextBoxColumn.HeaderText = "需求1";
            this.需求編號1DataGridViewTextBoxColumn.Name = "需求編號1DataGridViewTextBoxColumn";
            this.需求編號1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.需求編號1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.需求編號1DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 數量1DataGridViewTextBoxColumn
            // 
            this.數量1DataGridViewTextBoxColumn.DataPropertyName = "數量1";
            this.數量1DataGridViewTextBoxColumn.HeaderText = "數量1";
            this.數量1DataGridViewTextBoxColumn.Name = "數量1DataGridViewTextBoxColumn";
            // 
            // 需求編號2DataGridViewTextBoxColumn
            // 
            this.需求編號2DataGridViewTextBoxColumn.DataPropertyName = "需求編號2";
            this.需求編號2DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.需求編號2DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.需求編號2DataGridViewTextBoxColumn.HeaderText = "需求2";
            this.需求編號2DataGridViewTextBoxColumn.Name = "需求編號2DataGridViewTextBoxColumn";
            this.需求編號2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.需求編號2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.需求編號2DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 數量2DataGridViewTextBoxColumn
            // 
            this.數量2DataGridViewTextBoxColumn.DataPropertyName = "數量2";
            this.數量2DataGridViewTextBoxColumn.HeaderText = "數量2";
            this.數量2DataGridViewTextBoxColumn.Name = "數量2DataGridViewTextBoxColumn";
            // 
            // 需求編號3DataGridViewTextBoxColumn
            // 
            this.需求編號3DataGridViewTextBoxColumn.DataPropertyName = "需求編號3";
            this.需求編號3DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.需求編號3DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.需求編號3DataGridViewTextBoxColumn.HeaderText = "需求3";
            this.需求編號3DataGridViewTextBoxColumn.Name = "需求編號3DataGridViewTextBoxColumn";
            this.需求編號3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.需求編號3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.需求編號3DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 數量3DataGridViewTextBoxColumn
            // 
            this.數量3DataGridViewTextBoxColumn.DataPropertyName = "數量3";
            this.數量3DataGridViewTextBoxColumn.HeaderText = "數量3";
            this.數量3DataGridViewTextBoxColumn.Name = "數量3DataGridViewTextBoxColumn";
            // 
            // 需求編號4DataGridViewTextBoxColumn
            // 
            this.需求編號4DataGridViewTextBoxColumn.DataPropertyName = "需求編號4";
            this.需求編號4DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.需求編號4DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.需求編號4DataGridViewTextBoxColumn.HeaderText = "需求4";
            this.需求編號4DataGridViewTextBoxColumn.Name = "需求編號4DataGridViewTextBoxColumn";
            this.需求編號4DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.需求編號4DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.需求編號4DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 數量4DataGridViewTextBoxColumn
            // 
            this.數量4DataGridViewTextBoxColumn.DataPropertyName = "數量4";
            this.數量4DataGridViewTextBoxColumn.HeaderText = "數量4";
            this.數量4DataGridViewTextBoxColumn.Name = "數量4DataGridViewTextBoxColumn";
            // 
            // 需求編號5DataGridViewTextBoxColumn
            // 
            this.需求編號5DataGridViewTextBoxColumn.DataPropertyName = "需求編號5";
            this.需求編號5DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.需求編號5DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.需求編號5DataGridViewTextBoxColumn.HeaderText = "需求5";
            this.需求編號5DataGridViewTextBoxColumn.Name = "需求編號5DataGridViewTextBoxColumn";
            this.需求編號5DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.需求編號5DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.需求編號5DataGridViewTextBoxColumn.ValueMember = "編號";
            // 
            // 數量5DataGridViewTextBoxColumn
            // 
            this.數量5DataGridViewTextBoxColumn.DataPropertyName = "數量5";
            this.數量5DataGridViewTextBoxColumn.HeaderText = "數量5";
            this.數量5DataGridViewTextBoxColumn.Name = "數量5DataGridViewTextBoxColumn";
            // 
            // 價格DataGridViewTextBoxColumn
            // 
            this.價格DataGridViewTextBoxColumn.DataPropertyName = "價格";
            this.價格DataGridViewTextBoxColumn.HeaderText = "價格";
            this.價格DataGridViewTextBoxColumn.Name = "價格DataGridViewTextBoxColumn";
            // 
            // 成本DataGridViewTextBoxColumn
            // 
            this.成本DataGridViewTextBoxColumn.DataPropertyName = "成本";
            this.成本DataGridViewTextBoxColumn.HeaderText = "成本";
            this.成本DataGridViewTextBoxColumn.Name = "成本DataGridViewTextBoxColumn";
            this.成本DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 體積DataGridViewTextBoxColumn
            // 
            this.體積DataGridViewTextBoxColumn.DataPropertyName = "體積";
            this.體積DataGridViewTextBoxColumn.HeaderText = "體積";
            this.體積DataGridViewTextBoxColumn.Name = "體積DataGridViewTextBoxColumn";
            this.體積DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 利潤DataGridViewTextBoxColumn
            // 
            this.利潤DataGridViewTextBoxColumn.DataPropertyName = "利潤";
            this.利潤DataGridViewTextBoxColumn.HeaderText = "利潤";
            this.利潤DataGridViewTextBoxColumn.Name = "利潤DataGridViewTextBoxColumn";
            this.利潤DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 商品總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "商品總覽視窗";
            this.Text = "商品總覽視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品大類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品小類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 商品大類資料BindingSource;
        private System.Windows.Forms.BindingSource 商品小類資料BindingSource;
        private System.Windows.Forms.BindingSource 廠商資料BindingSource;
        private System.Windows.Forms.BindingSource 物品資料BindingSource;
        private System.Windows.Forms.BindingSource 商品資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 開啟DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 大類編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 小類編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 廠商編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 需求編號1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 需求編號2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 需求編號3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 需求編號4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 需求編號5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 價格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 體積DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 利潤DataGridViewTextBoxColumn;
    }
}