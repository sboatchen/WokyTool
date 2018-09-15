namespace WokyTool.平台訂單
{
    partial class 平台訂單新增總覽視窗
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
            this.訂單處理狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.配送公司BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.指配時段BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.代收方式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系統分組ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.處理狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.配送分組DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.訂單編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.公司資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客戶DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.客戶資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.含稅單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手機DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配送公司DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.配送單號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.指配日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.指配時段DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.代收方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.代收金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.平台訂單新增資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.配送ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.訂單處理狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.配送公司BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.指配時段BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收方式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.平台訂單新增資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 訂單處理狀態BindingSource
            // 
            this.訂單處理狀態BindingSource.DataSource = typeof(WokyTool.通用.列舉.訂單處理狀態);
            // 
            // 配送公司BindingSource
            // 
            this.配送公司BindingSource.DataSource = typeof(WokyTool.通用.列舉.配送公司);
            // 
            // 指配時段BindingSource
            // 
            this.指配時段BindingSource.DataSource = typeof(WokyTool.通用.列舉.指配時段);
            // 
            // 代收方式BindingSource
            // 
            this.代收方式BindingSource.DataSource = typeof(WokyTool.通用.列舉.代收方式);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.處理狀態DataGridViewTextBoxColumn,
            this.配送分組DataGridViewTextBoxColumn,
            this.訂單編號DataGridViewTextBoxColumn,
            this.公司DataGridViewTextBoxColumn,
            this.客戶DataGridViewTextBoxColumn,
            this.商品DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.單價DataGridViewTextBoxColumn,
            this.含稅單價DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.地址DataGridViewTextBoxColumn,
            this.電話DataGridViewTextBoxColumn,
            this.手機DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn,
            this.配送公司DataGridViewTextBoxColumn,
            this.配送單號DataGridViewTextBoxColumn,
            this.指配日期DataGridViewTextBoxColumn,
            this.指配時段DataGridViewTextBoxColumn,
            this.代收方式DataGridViewTextBoxColumn,
            this.代收金額DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.平台訂單新增資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1447, 629);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.系統分組ToolStripMenuItem,
            this.配送ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1447, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 篩選ToolStripMenuItem
            // 
            this.篩選ToolStripMenuItem.Name = "篩選ToolStripMenuItem";
            this.篩選ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.篩選ToolStripMenuItem.Text = "篩選";
            this.篩選ToolStripMenuItem.Click += new System.EventHandler(this.篩選ToolStripMenuItem_Click);
            // 
            // 系統分組ToolStripMenuItem
            // 
            this.系統分組ToolStripMenuItem.Name = "系統分組ToolStripMenuItem";
            this.系統分組ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.系統分組ToolStripMenuItem.Text = "系統分組";
            this.系統分組ToolStripMenuItem.Click += new System.EventHandler(this.系統分組ToolStripMenuItem_Click);
            // 
            // 處理狀態DataGridViewTextBoxColumn
            // 
            this.處理狀態DataGridViewTextBoxColumn.DataPropertyName = "處理狀態";
            this.處理狀態DataGridViewTextBoxColumn.DataSource = this.訂單處理狀態BindingSource;
            this.處理狀態DataGridViewTextBoxColumn.HeaderText = "處理狀態";
            this.處理狀態DataGridViewTextBoxColumn.Name = "處理狀態DataGridViewTextBoxColumn";
            this.處理狀態DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.處理狀態DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 配送分組DataGridViewTextBoxColumn
            // 
            this.配送分組DataGridViewTextBoxColumn.DataPropertyName = "配送分組";
            this.配送分組DataGridViewTextBoxColumn.HeaderText = "配送分組";
            this.配送分組DataGridViewTextBoxColumn.Name = "配送分組DataGridViewTextBoxColumn";
            // 
            // 訂單編號DataGridViewTextBoxColumn
            // 
            this.訂單編號DataGridViewTextBoxColumn.DataPropertyName = "訂單編號";
            this.訂單編號DataGridViewTextBoxColumn.HeaderText = "訂單編號";
            this.訂單編號DataGridViewTextBoxColumn.Name = "訂單編號DataGridViewTextBoxColumn";
            this.訂單編號DataGridViewTextBoxColumn.ReadOnly = true;
            this.訂單編號DataGridViewTextBoxColumn.Width = 150;
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
            // 商品DataGridViewTextBoxColumn
            // 
            this.商品DataGridViewTextBoxColumn.DataPropertyName = "商品名稱";
            this.商品DataGridViewTextBoxColumn.HeaderText = "商品";
            this.商品DataGridViewTextBoxColumn.Name = "商品DataGridViewTextBoxColumn";
            this.商品DataGridViewTextBoxColumn.ReadOnly = true;
            this.商品DataGridViewTextBoxColumn.Width = 250;
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 單價DataGridViewTextBoxColumn
            // 
            this.單價DataGridViewTextBoxColumn.DataPropertyName = "單價";
            this.單價DataGridViewTextBoxColumn.HeaderText = "單價";
            this.單價DataGridViewTextBoxColumn.Name = "單價DataGridViewTextBoxColumn";
            // 
            // 含稅單價DataGridViewTextBoxColumn
            // 
            this.含稅單價DataGridViewTextBoxColumn.DataPropertyName = "含稅單價";
            this.含稅單價DataGridViewTextBoxColumn.HeaderText = "含稅單價";
            this.含稅單價DataGridViewTextBoxColumn.Name = "含稅單價DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 地址DataGridViewTextBoxColumn
            // 
            this.地址DataGridViewTextBoxColumn.DataPropertyName = "地址";
            this.地址DataGridViewTextBoxColumn.HeaderText = "地址";
            this.地址DataGridViewTextBoxColumn.Name = "地址DataGridViewTextBoxColumn";
            // 
            // 電話DataGridViewTextBoxColumn
            // 
            this.電話DataGridViewTextBoxColumn.DataPropertyName = "電話";
            this.電話DataGridViewTextBoxColumn.HeaderText = "電話";
            this.電話DataGridViewTextBoxColumn.Name = "電話DataGridViewTextBoxColumn";
            // 
            // 手機DataGridViewTextBoxColumn
            // 
            this.手機DataGridViewTextBoxColumn.DataPropertyName = "手機";
            this.手機DataGridViewTextBoxColumn.HeaderText = "手機";
            this.手機DataGridViewTextBoxColumn.Name = "手機DataGridViewTextBoxColumn";
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            // 
            // 配送公司DataGridViewTextBoxColumn
            // 
            this.配送公司DataGridViewTextBoxColumn.DataPropertyName = "配送公司";
            this.配送公司DataGridViewTextBoxColumn.DataSource = this.配送公司BindingSource;
            this.配送公司DataGridViewTextBoxColumn.HeaderText = "配送公司";
            this.配送公司DataGridViewTextBoxColumn.Name = "配送公司DataGridViewTextBoxColumn";
            this.配送公司DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.配送公司DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 配送單號DataGridViewTextBoxColumn
            // 
            this.配送單號DataGridViewTextBoxColumn.DataPropertyName = "配送單號";
            this.配送單號DataGridViewTextBoxColumn.HeaderText = "配送單號";
            this.配送單號DataGridViewTextBoxColumn.Name = "配送單號DataGridViewTextBoxColumn";
            // 
            // 指配日期DataGridViewTextBoxColumn
            // 
            this.指配日期DataGridViewTextBoxColumn.DataPropertyName = "指配日期";
            this.指配日期DataGridViewTextBoxColumn.HeaderText = "指配日期";
            this.指配日期DataGridViewTextBoxColumn.Name = "指配日期DataGridViewTextBoxColumn";
            // 
            // 指配時段DataGridViewTextBoxColumn
            // 
            this.指配時段DataGridViewTextBoxColumn.DataPropertyName = "指配時段";
            this.指配時段DataGridViewTextBoxColumn.DataSource = this.指配時段BindingSource;
            this.指配時段DataGridViewTextBoxColumn.HeaderText = "指配時段";
            this.指配時段DataGridViewTextBoxColumn.Name = "指配時段DataGridViewTextBoxColumn";
            this.指配時段DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.指配時段DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 代收方式DataGridViewTextBoxColumn
            // 
            this.代收方式DataGridViewTextBoxColumn.DataPropertyName = "代收方式";
            this.代收方式DataGridViewTextBoxColumn.DataSource = this.代收方式BindingSource;
            this.代收方式DataGridViewTextBoxColumn.HeaderText = "代收方式";
            this.代收方式DataGridViewTextBoxColumn.Name = "代收方式DataGridViewTextBoxColumn";
            this.代收方式DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.代收方式DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 代收金額DataGridViewTextBoxColumn
            // 
            this.代收金額DataGridViewTextBoxColumn.DataPropertyName = "代收金額";
            this.代收金額DataGridViewTextBoxColumn.HeaderText = "代收金額";
            this.代收金額DataGridViewTextBoxColumn.Name = "代收金額DataGridViewTextBoxColumn";
            // 
            // 平台訂單新增資料BindingSource
            // 
            this.平台訂單新增資料BindingSource.DataSource = typeof(WokyTool.平台訂單.平台訂單新增資料);
            // 
            // 配送ToolStripMenuItem
            // 
            this.配送ToolStripMenuItem.Name = "配送ToolStripMenuItem";
            this.配送ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.配送ToolStripMenuItem.Text = "配送";
            this.配送ToolStripMenuItem.Click += new System.EventHandler(this.配送ToolStripMenuItem_Click);
            // 
            // 平台訂單新增總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "平台訂單新增總覽視窗";
            this.Text = "平台訂單新增總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.訂單處理狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.配送公司BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.指配時段BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收方式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.平台訂單新增資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 平台訂單新增資料BindingSource;
        private System.Windows.Forms.BindingSource 訂單處理狀態BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 系統分組ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 公司資料BindingSource;
        private System.Windows.Forms.BindingSource 客戶資料BindingSource;
        private System.Windows.Forms.BindingSource 配送公司BindingSource;
        private System.Windows.Forms.BindingSource 指配時段BindingSource;
        private System.Windows.Forms.BindingSource 代收方式BindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn 處理狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配送分組DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訂單編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 公司DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 客戶DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 含稅單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手機DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 配送公司DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配送單號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 指配日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 指配時段DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 代收方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代收金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 配送ToolStripMenuItem;
    }
}