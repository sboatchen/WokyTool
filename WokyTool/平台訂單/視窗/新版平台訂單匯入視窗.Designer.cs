namespace WokyTool.平台訂單
{
    partial class 新版平台訂單匯入視窗
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
            this.配送公司BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.指配時段BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.代收方式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.訂單編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.處理狀態 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.訂單處理狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.含稅單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手機DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配送公司DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.指配日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.指配時段DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.代收方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.代收金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.錯誤訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.平台訂單匯入資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.公司ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公司 = new System.Windows.Forms.ToolStripComboBox();
            this.匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中華電信 = new System.Windows.Forms.ToolStripMenuItem();
            this.東森 = new System.Windows.Forms.ToolStripMenuItem();
            this.friday = new System.Windows.Forms.ToolStripMenuItem();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Momo第三方 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.配送公司BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.指配時段BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收方式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂單處理狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.平台訂單匯入資料BindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
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
            this.訂單編號DataGridViewTextBoxColumn,
            this.處理狀態,
            this.商品識別DataGridViewTextBoxColumn,
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
            this.指配日期DataGridViewTextBoxColumn,
            this.指配時段DataGridViewTextBoxColumn,
            this.代收方式DataGridViewTextBoxColumn,
            this.代收金額DataGridViewTextBoxColumn,
            this.錯誤訊息DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.平台訂單匯入資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1369, 529);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // 訂單編號DataGridViewTextBoxColumn
            // 
            this.訂單編號DataGridViewTextBoxColumn.DataPropertyName = "訂單編號";
            this.訂單編號DataGridViewTextBoxColumn.HeaderText = "訂單編號";
            this.訂單編號DataGridViewTextBoxColumn.Name = "訂單編號DataGridViewTextBoxColumn";
            this.訂單編號DataGridViewTextBoxColumn.Width = 150;
            // 
            // 處理狀態
            // 
            this.處理狀態.DataPropertyName = "處理狀態";
            this.處理狀態.DataSource = this.訂單處理狀態BindingSource;
            this.處理狀態.HeaderText = "處理狀態";
            this.處理狀態.Name = "處理狀態";
            // 
            // 訂單處理狀態BindingSource
            // 
            this.訂單處理狀態BindingSource.DataSource = typeof(WokyTool.通用.列舉.訂單處理狀態);
            // 
            // 商品識別DataGridViewTextBoxColumn
            // 
            this.商品識別DataGridViewTextBoxColumn.DataPropertyName = "商品識別";
            this.商品識別DataGridViewTextBoxColumn.HeaderText = "商品識別";
            this.商品識別DataGridViewTextBoxColumn.Name = "商品識別DataGridViewTextBoxColumn";
            this.商品識別DataGridViewTextBoxColumn.Width = 200;
            // 
            // 商品DataGridViewTextBoxColumn
            // 
            this.商品DataGridViewTextBoxColumn.DataPropertyName = "商品";
            this.商品DataGridViewTextBoxColumn.DataSource = this.商品資料BindingSource;
            this.商品DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.商品DataGridViewTextBoxColumn.HeaderText = "商品";
            this.商品DataGridViewTextBoxColumn.Name = "商品DataGridViewTextBoxColumn";
            this.商品DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.商品DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.商品DataGridViewTextBoxColumn.ValueMember = "Self";
            this.商品DataGridViewTextBoxColumn.Width = 200;
            // 
            // 商品資料BindingSource
            // 
            this.商品資料BindingSource.DataSource = typeof(WokyTool.商品.商品資料);
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
            // 錯誤訊息DataGridViewTextBoxColumn
            // 
            this.錯誤訊息DataGridViewTextBoxColumn.DataPropertyName = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.HeaderText = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.Name = "錯誤訊息DataGridViewTextBoxColumn";
            this.錯誤訊息DataGridViewTextBoxColumn.Width = 300;
            // 
            // 平台訂單匯入資料BindingSource
            // 
            this.平台訂單匯入資料BindingSource.DataSource = typeof(WokyTool.平台訂單.平台訂單匯入資料);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.公司ToolStripMenuItem,
            this.匯入ToolStripMenuItem,
            this.檢查ToolStripMenuItem,
            this.匯出ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1369, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 公司ToolStripMenuItem
            // 
            this.公司ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.公司});
            this.公司ToolStripMenuItem.Name = "公司ToolStripMenuItem";
            this.公司ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.公司ToolStripMenuItem.Text = "公司";
            // 
            // 公司
            // 
            this.公司.Name = "公司";
            this.公司.Size = new System.Drawing.Size(121, 23);
            this.公司.SelectedIndexChanged += new System.EventHandler(this.公司_SelectedIndexChanged);
            // 
            // 匯入ToolStripMenuItem
            // 
            this.匯入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中華電信,
            this.東森,
            this.friday,
            this.Momo第三方});
            this.匯入ToolStripMenuItem.Name = "匯入ToolStripMenuItem";
            this.匯入ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯入ToolStripMenuItem.Text = "客戶";
            // 
            // 中華電信
            // 
            this.中華電信.Name = "中華電信";
            this.中華電信.Size = new System.Drawing.Size(152, 22);
            this.中華電信.Text = "中華電信";
            this.中華電信.Click += new System.EventHandler(this.中華電信_Click);
            // 
            // 東森
            // 
            this.東森.Name = "東森";
            this.東森.Size = new System.Drawing.Size(152, 22);
            this.東森.Text = "東森";
            this.東森.Click += new System.EventHandler(this.東森_Click);
            // 
            // friday
            // 
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(152, 22);
            this.friday.Text = "Friday";
            this.friday.Click += new System.EventHandler(this.friday_Click);
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
            // Momo第三方
            // 
            this.Momo第三方.Name = "Momo第三方";
            this.Momo第三方.Size = new System.Drawing.Size(152, 22);
            this.Momo第三方.Text = "Momo第三方";
            this.Momo第三方.Click += new System.EventHandler(this.Momo第三方_Click);
            // 
            // 新版平台訂單匯入視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "新版平台訂單匯入視窗";
            this.Text = "平台訂單匯入視窗";
            ((System.ComponentModel.ISupportInitialize)(this.配送公司BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.指配時段BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收方式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂單處理狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.平台訂單匯入資料BindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 商品資料BindingSource;
        private System.Windows.Forms.BindingSource 配送公司BindingSource;
        private System.Windows.Forms.BindingSource 指配時段BindingSource;
        private System.Windows.Forms.BindingSource 代收方式BindingSource;
        private System.Windows.Forms.BindingSource 平台訂單匯入資料BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訂單編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 處理狀態;
        private System.Windows.Forms.BindingSource 訂單處理狀態BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 商品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 含稅單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手機DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 配送公司DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 指配日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 指配時段DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 代收方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代收金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 錯誤訊息DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 中華電信;
        private System.Windows.Forms.ToolStripMenuItem 東森;
        private System.Windows.Forms.ToolStripMenuItem friday;
        private System.Windows.Forms.ToolStripMenuItem 公司ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox 公司;
        private System.Windows.Forms.ToolStripMenuItem Momo第三方;
    }
}