namespace WokyTool.物品
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
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.總表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.庫存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.盤點ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.條碼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物品大類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品品牌資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品小類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品牌DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.大類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.小類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.條碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.原廠編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代理編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.縮寫DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.體積DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顏色DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.內庫數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.外庫數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.庫存總量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最後進貨成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.物品大類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品品牌資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品小類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.匯出ToolStripMenuItem,
            this.更新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1642, 24);
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
            this.庫存ToolStripMenuItem,
            this.盤點ToolStripMenuItem,
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
            // 庫存ToolStripMenuItem
            // 
            this.庫存ToolStripMenuItem.Name = "庫存ToolStripMenuItem";
            this.庫存ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.庫存ToolStripMenuItem.Text = "庫存";
            this.庫存ToolStripMenuItem.Click += new System.EventHandler(this.庫存ToolStripMenuItem_Click);
            // 
            // 盤點ToolStripMenuItem
            // 
            this.盤點ToolStripMenuItem.Name = "盤點ToolStripMenuItem";
            this.盤點ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.盤點ToolStripMenuItem.Text = "盤點";
            this.盤點ToolStripMenuItem.Click += new System.EventHandler(this.盤點ToolStripMenuItem_Click);
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
            this.物品ToolStripMenuItem,
            this.條碼ToolStripMenuItem});
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // 物品ToolStripMenuItem
            // 
            this.物品ToolStripMenuItem.Name = "物品ToolStripMenuItem";
            this.物品ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.物品ToolStripMenuItem.Text = "新增";
            this.物品ToolStripMenuItem.Click += new System.EventHandler(this.物品ToolStripMenuItem_Click);
            // 
            // 條碼ToolStripMenuItem
            // 
            this.條碼ToolStripMenuItem.Name = "條碼ToolStripMenuItem";
            this.條碼ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.條碼ToolStripMenuItem.Text = "條碼";
            this.條碼ToolStripMenuItem.Click += new System.EventHandler(this.條碼ToolStripMenuItem_Click);
            // 
            // 物品大類資料BindingSource
            // 
            this.物品大類資料BindingSource.DataSource = typeof(WokyTool.物品.物品大類資料);
            // 
            // 物品品牌資料BindingSource
            // 
            this.物品品牌資料BindingSource.DataSource = typeof(WokyTool.物品.物品品牌資料);
            // 
            // 物品小類資料BindingSource
            // 
            this.物品小類資料BindingSource.DataSource = typeof(WokyTool.物品.物品小類資料);
            // 
            // 物品資料BindingSource
            // 
            this.物品資料BindingSource.DataSource = typeof(WokyTool.物品.物品資料);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.品牌DataGridViewTextBoxColumn,
            this.大類DataGridViewTextBoxColumn,
            this.小類DataGridViewTextBoxColumn,
            this.條碼DataGridViewTextBoxColumn,
            this.原廠編號DataGridViewTextBoxColumn,
            this.代理編號DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.縮寫DataGridViewTextBoxColumn,
            this.體積DataGridViewTextBoxColumn,
            this.顏色DataGridViewTextBoxColumn,
            this.內庫數量DataGridViewTextBoxColumn,
            this.外庫數量DataGridViewTextBoxColumn,
            this.庫存總量DataGridViewTextBoxColumn,
            this.最後進貨成本DataGridViewTextBoxColumn,
            this.成本備註DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.物品資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1642, 487);
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
            // 品牌DataGridViewTextBoxColumn
            // 
            this.品牌DataGridViewTextBoxColumn.DataPropertyName = "品牌";
            this.品牌DataGridViewTextBoxColumn.DataSource = this.物品品牌資料BindingSource;
            this.品牌DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.品牌DataGridViewTextBoxColumn.HeaderText = "品牌";
            this.品牌DataGridViewTextBoxColumn.Name = "品牌DataGridViewTextBoxColumn";
            this.品牌DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.品牌DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.品牌DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 大類DataGridViewTextBoxColumn
            // 
            this.大類DataGridViewTextBoxColumn.DataPropertyName = "大類";
            this.大類DataGridViewTextBoxColumn.DataSource = this.物品大類資料BindingSource;
            this.大類DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.大類DataGridViewTextBoxColumn.HeaderText = "大類";
            this.大類DataGridViewTextBoxColumn.Name = "大類DataGridViewTextBoxColumn";
            this.大類DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.大類DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.大類DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 小類DataGridViewTextBoxColumn
            // 
            this.小類DataGridViewTextBoxColumn.DataPropertyName = "小類";
            this.小類DataGridViewTextBoxColumn.DataSource = this.物品小類資料BindingSource;
            this.小類DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.小類DataGridViewTextBoxColumn.HeaderText = "小類";
            this.小類DataGridViewTextBoxColumn.Name = "小類DataGridViewTextBoxColumn";
            this.小類DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.小類DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.小類DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 條碼DataGridViewTextBoxColumn
            // 
            this.條碼DataGridViewTextBoxColumn.DataPropertyName = "條碼";
            this.條碼DataGridViewTextBoxColumn.HeaderText = "條碼";
            this.條碼DataGridViewTextBoxColumn.Name = "條碼DataGridViewTextBoxColumn";
            // 
            // 原廠編號DataGridViewTextBoxColumn
            // 
            this.原廠編號DataGridViewTextBoxColumn.DataPropertyName = "原廠編號";
            this.原廠編號DataGridViewTextBoxColumn.HeaderText = "原廠編號";
            this.原廠編號DataGridViewTextBoxColumn.Name = "原廠編號DataGridViewTextBoxColumn";
            // 
            // 代理編號DataGridViewTextBoxColumn
            // 
            this.代理編號DataGridViewTextBoxColumn.DataPropertyName = "代理編號";
            this.代理編號DataGridViewTextBoxColumn.HeaderText = "代理編號";
            this.代理編號DataGridViewTextBoxColumn.Name = "代理編號DataGridViewTextBoxColumn";
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
            // 顏色DataGridViewTextBoxColumn
            // 
            this.顏色DataGridViewTextBoxColumn.DataPropertyName = "顏色";
            this.顏色DataGridViewTextBoxColumn.HeaderText = "顏色";
            this.顏色DataGridViewTextBoxColumn.Name = "顏色DataGridViewTextBoxColumn";
            // 
            // 內庫數量DataGridViewTextBoxColumn
            // 
            this.內庫數量DataGridViewTextBoxColumn.DataPropertyName = "內庫數量";
            this.內庫數量DataGridViewTextBoxColumn.HeaderText = "內庫數量";
            this.內庫數量DataGridViewTextBoxColumn.Name = "內庫數量DataGridViewTextBoxColumn";
            // 
            // 外庫數量DataGridViewTextBoxColumn
            // 
            this.外庫數量DataGridViewTextBoxColumn.DataPropertyName = "外庫數量";
            this.外庫數量DataGridViewTextBoxColumn.HeaderText = "外庫數量";
            this.外庫數量DataGridViewTextBoxColumn.Name = "外庫數量DataGridViewTextBoxColumn";
            // 
            // 庫存總量DataGridViewTextBoxColumn
            // 
            this.庫存總量DataGridViewTextBoxColumn.DataPropertyName = "庫存總量";
            this.庫存總量DataGridViewTextBoxColumn.HeaderText = "庫存總量";
            this.庫存總量DataGridViewTextBoxColumn.Name = "庫存總量DataGridViewTextBoxColumn";
            this.庫存總量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 最後進貨成本DataGridViewTextBoxColumn
            // 
            this.最後進貨成本DataGridViewTextBoxColumn.DataPropertyName = "最後進貨成本";
            this.最後進貨成本DataGridViewTextBoxColumn.HeaderText = "最後進貨成本";
            this.最後進貨成本DataGridViewTextBoxColumn.Name = "最後進貨成本DataGridViewTextBoxColumn";
            // 
            // 成本備註DataGridViewTextBoxColumn
            // 
            this.成本備註DataGridViewTextBoxColumn.DataPropertyName = "成本備註";
            this.成本備註DataGridViewTextBoxColumn.HeaderText = "成本備註";
            this.成本備註DataGridViewTextBoxColumn.Name = "成本備註DataGridViewTextBoxColumn";
            // 
            // 物品總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "物品總覽視窗";
            this.Text = "物品總覽視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.物品大類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品品牌資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品小類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 總表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 庫存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 盤點ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 物品大類資料BindingSource;
        private System.Windows.Forms.BindingSource 物品資料BindingSource;
        private System.Windows.Forms.BindingSource 物品小類資料BindingSource;
        private System.Windows.Forms.BindingSource 物品品牌資料BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 條碼ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 品牌DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 大類DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 小類DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 條碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原廠編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代理編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 縮寫DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 體積DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顏色DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 內庫數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 外庫數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 庫存總量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最後進貨成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本備註DataGridViewTextBoxColumn;
    }
}