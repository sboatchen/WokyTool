namespace WokyTool.商品
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.大類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.商品大類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.小類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.商品小類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.公司DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.公司資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客戶DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.客戶資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.品號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.需求1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.物品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.需求2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.需求3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.需求4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.需求5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.數量1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.體積DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.寄庫數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.售價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.利潤DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.總表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品大類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品小類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.大類DataGridViewTextBoxColumn,
            this.小類DataGridViewTextBoxColumn,
            this.公司DataGridViewTextBoxColumn,
            this.客戶DataGridViewTextBoxColumn,
            this.品號DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.需求1DataGridViewTextBoxColumn,
            this.需求2DataGridViewTextBoxColumn,
            this.需求3DataGridViewTextBoxColumn,
            this.需求4DataGridViewTextBoxColumn,
            this.需求5DataGridViewTextBoxColumn,
            this.數量1DataGridViewTextBoxColumn,
            this.數量2DataGridViewTextBoxColumn,
            this.數量3DataGridViewTextBoxColumn,
            this.數量4DataGridViewTextBoxColumn,
            this.數量5DataGridViewTextBoxColumn,
            this.體積DataGridViewTextBoxColumn,
            this.寄庫數量DataGridViewTextBoxColumn,
            this.售價DataGridViewTextBoxColumn,
            this.成本DataGridViewTextBoxColumn,
            this.利潤DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.商品資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1266, 429);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 大類DataGridViewTextBoxColumn
            // 
            this.大類DataGridViewTextBoxColumn.DataPropertyName = "大類";
            this.大類DataGridViewTextBoxColumn.DataSource = this.商品大類資料BindingSource;
            this.大類DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.大類DataGridViewTextBoxColumn.HeaderText = "大類";
            this.大類DataGridViewTextBoxColumn.Name = "大類DataGridViewTextBoxColumn";
            this.大類DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.大類DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.大類DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 商品大類資料BindingSource
            // 
            this.商品大類資料BindingSource.DataSource = typeof(WokyTool.商品.商品大類資料);
            // 
            // 小類DataGridViewTextBoxColumn
            // 
            this.小類DataGridViewTextBoxColumn.DataPropertyName = "小類";
            this.小類DataGridViewTextBoxColumn.DataSource = this.商品小類資料BindingSource;
            this.小類DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.小類DataGridViewTextBoxColumn.HeaderText = "小類";
            this.小類DataGridViewTextBoxColumn.Name = "小類DataGridViewTextBoxColumn";
            this.小類DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.小類DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.小類DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 商品小類資料BindingSource
            // 
            this.商品小類資料BindingSource.DataSource = typeof(WokyTool.商品.商品小類資料);
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
            // 需求1DataGridViewTextBoxColumn
            // 
            this.需求1DataGridViewTextBoxColumn.DataPropertyName = "需求1";
            this.需求1DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.需求1DataGridViewTextBoxColumn.DisplayMember = "縮寫";
            this.需求1DataGridViewTextBoxColumn.HeaderText = "需求1";
            this.需求1DataGridViewTextBoxColumn.Name = "需求1DataGridViewTextBoxColumn";
            this.需求1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.需求1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.需求1DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 物品資料BindingSource
            // 
            this.物品資料BindingSource.DataSource = typeof(WokyTool.物品.物品資料);
            // 
            // 需求2DataGridViewTextBoxColumn
            // 
            this.需求2DataGridViewTextBoxColumn.DataPropertyName = "需求2";
            this.需求2DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.需求2DataGridViewTextBoxColumn.DisplayMember = "縮寫";
            this.需求2DataGridViewTextBoxColumn.HeaderText = "需求2";
            this.需求2DataGridViewTextBoxColumn.Name = "需求2DataGridViewTextBoxColumn";
            this.需求2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.需求2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.需求2DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 需求3DataGridViewTextBoxColumn
            // 
            this.需求3DataGridViewTextBoxColumn.DataPropertyName = "需求3";
            this.需求3DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.需求3DataGridViewTextBoxColumn.DisplayMember = "縮寫";
            this.需求3DataGridViewTextBoxColumn.HeaderText = "需求3";
            this.需求3DataGridViewTextBoxColumn.Name = "需求3DataGridViewTextBoxColumn";
            this.需求3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.需求3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.需求3DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 需求4DataGridViewTextBoxColumn
            // 
            this.需求4DataGridViewTextBoxColumn.DataPropertyName = "需求4";
            this.需求4DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.需求4DataGridViewTextBoxColumn.DisplayMember = "縮寫";
            this.需求4DataGridViewTextBoxColumn.HeaderText = "需求4";
            this.需求4DataGridViewTextBoxColumn.Name = "需求4DataGridViewTextBoxColumn";
            this.需求4DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.需求4DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.需求4DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 需求5DataGridViewTextBoxColumn
            // 
            this.需求5DataGridViewTextBoxColumn.DataPropertyName = "需求5";
            this.需求5DataGridViewTextBoxColumn.DataSource = this.物品資料BindingSource;
            this.需求5DataGridViewTextBoxColumn.DisplayMember = "縮寫";
            this.需求5DataGridViewTextBoxColumn.HeaderText = "需求5";
            this.需求5DataGridViewTextBoxColumn.Name = "需求5DataGridViewTextBoxColumn";
            this.需求5DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.需求5DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.需求5DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 數量1DataGridViewTextBoxColumn
            // 
            this.數量1DataGridViewTextBoxColumn.DataPropertyName = "數量1";
            this.數量1DataGridViewTextBoxColumn.HeaderText = "數量1";
            this.數量1DataGridViewTextBoxColumn.Name = "數量1DataGridViewTextBoxColumn";
            // 
            // 數量2DataGridViewTextBoxColumn
            // 
            this.數量2DataGridViewTextBoxColumn.DataPropertyName = "數量2";
            this.數量2DataGridViewTextBoxColumn.HeaderText = "數量2";
            this.數量2DataGridViewTextBoxColumn.Name = "數量2DataGridViewTextBoxColumn";
            // 
            // 數量3DataGridViewTextBoxColumn
            // 
            this.數量3DataGridViewTextBoxColumn.DataPropertyName = "數量3";
            this.數量3DataGridViewTextBoxColumn.HeaderText = "數量3";
            this.數量3DataGridViewTextBoxColumn.Name = "數量3DataGridViewTextBoxColumn";
            // 
            // 數量4DataGridViewTextBoxColumn
            // 
            this.數量4DataGridViewTextBoxColumn.DataPropertyName = "數量4";
            this.數量4DataGridViewTextBoxColumn.HeaderText = "數量4";
            this.數量4DataGridViewTextBoxColumn.Name = "數量4DataGridViewTextBoxColumn";
            // 
            // 數量5DataGridViewTextBoxColumn
            // 
            this.數量5DataGridViewTextBoxColumn.DataPropertyName = "數量5";
            this.數量5DataGridViewTextBoxColumn.HeaderText = "數量5";
            this.數量5DataGridViewTextBoxColumn.Name = "數量5DataGridViewTextBoxColumn";
            // 
            // 體積DataGridViewTextBoxColumn
            // 
            this.體積DataGridViewTextBoxColumn.DataPropertyName = "體積";
            this.體積DataGridViewTextBoxColumn.HeaderText = "體積";
            this.體積DataGridViewTextBoxColumn.Name = "體積DataGridViewTextBoxColumn";
            this.體積DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 寄庫數量DataGridViewTextBoxColumn
            // 
            this.寄庫數量DataGridViewTextBoxColumn.DataPropertyName = "寄庫數量";
            this.寄庫數量DataGridViewTextBoxColumn.HeaderText = "寄庫數量";
            this.寄庫數量DataGridViewTextBoxColumn.Name = "寄庫數量DataGridViewTextBoxColumn";
            // 
            // 售價DataGridViewTextBoxColumn
            // 
            this.售價DataGridViewTextBoxColumn.DataPropertyName = "售價";
            this.售價DataGridViewTextBoxColumn.HeaderText = "售價";
            this.售價DataGridViewTextBoxColumn.Name = "售價DataGridViewTextBoxColumn";
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
            // 商品資料BindingSource
            // 
            this.商品資料BindingSource.DataSource = typeof(WokyTool.商品.商品資料);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.匯出ToolStripMenuItem,
            this.更新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.總表ToolStripMenuItem,
            this.自訂ToolStripMenuItem});
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            // 
            // 總表ToolStripMenuItem
            // 
            this.總表ToolStripMenuItem.Name = "總表ToolStripMenuItem";
            this.總表ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.總表ToolStripMenuItem.Text = "總覽";
            this.總表ToolStripMenuItem.Click += new System.EventHandler(this.總表ToolStripMenuItem_Click);
            // 
            // 自訂ToolStripMenuItem
            // 
            this.自訂ToolStripMenuItem.Name = "自訂ToolStripMenuItem";
            this.自訂ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.自訂ToolStripMenuItem.Text = "自訂";
            this.自訂ToolStripMenuItem.Click += new System.EventHandler(this.自訂ToolStripMenuItem_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品ToolStripMenuItem});
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // 商品ToolStripMenuItem
            // 
            this.商品ToolStripMenuItem.Name = "商品ToolStripMenuItem";
            this.商品ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.商品ToolStripMenuItem.Text = "新增";
            this.商品ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 商品總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "商品總覽視窗";
            this.Text = "商品總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品大類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品小類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 總表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 大類DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 商品大類資料BindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn 小類DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 商品小類資料BindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn 公司DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 公司資料BindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn 客戶DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 客戶資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 需求1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 物品資料BindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn 需求2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 需求3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 需求4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 需求5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 體積DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 寄庫數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 售價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 利潤DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 商品資料BindingSource;
    }
}