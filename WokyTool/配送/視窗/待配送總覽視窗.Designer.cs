using WokyTool.通用;

namespace WokyTool.配送
{
    partial class 待配送總覽視窗
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
            this.略過ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全速配ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.宅配通ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.統計ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全速配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宅配通ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.測試用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.指配時段類型BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.代收類型BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.配送公司類型BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.可配送資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手機DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.內容DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.件數 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.指配日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.指配時段DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.代收方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.代收金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.體積 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配送公司DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.配送單號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.指配時段類型BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收類型BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.配送公司類型BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.可配送資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.略過ToolStripMenuItem,
            this.匯出ToolStripMenuItem,
            this.匯入ToolStripMenuItem,
            this.測試用ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1445, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 略過ToolStripMenuItem
            // 
            this.略過ToolStripMenuItem.Name = "略過ToolStripMenuItem";
            this.略過ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.略過ToolStripMenuItem.Text = "略過";
            this.略過ToolStripMenuItem.Click += new System.EventHandler(this.略過ToolStripMenuItem_Click);
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全速配ToolStripMenuItem1,
            this.宅配通ToolStripMenuItem1,
            this.統計ToolStripMenuItem});
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            // 
            // 全速配ToolStripMenuItem1
            // 
            this.全速配ToolStripMenuItem1.Name = "全速配ToolStripMenuItem1";
            this.全速配ToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.全速配ToolStripMenuItem1.Text = "全速配";
            this.全速配ToolStripMenuItem1.Click += new System.EventHandler(this.全速配ToolStripMenuItem1_Click);
            // 
            // 宅配通ToolStripMenuItem1
            // 
            this.宅配通ToolStripMenuItem1.Name = "宅配通ToolStripMenuItem1";
            this.宅配通ToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.宅配通ToolStripMenuItem1.Text = "宅配通";
            this.宅配通ToolStripMenuItem1.Click += new System.EventHandler(this.宅配通ToolStripMenuItem1_Click);
            // 
            // 統計ToolStripMenuItem
            // 
            this.統計ToolStripMenuItem.Name = "統計ToolStripMenuItem";
            this.統計ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.統計ToolStripMenuItem.Text = "統計";
            this.統計ToolStripMenuItem.Click += new System.EventHandler(this.統計ToolStripMenuItem_Click);
            // 
            // 匯入ToolStripMenuItem
            // 
            this.匯入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全速配ToolStripMenuItem,
            this.宅配通ToolStripMenuItem});
            this.匯入ToolStripMenuItem.Name = "匯入ToolStripMenuItem";
            this.匯入ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯入ToolStripMenuItem.Text = "匯入";
            // 
            // 全速配ToolStripMenuItem
            // 
            this.全速配ToolStripMenuItem.Name = "全速配ToolStripMenuItem";
            this.全速配ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.全速配ToolStripMenuItem.Text = "全速配";
            this.全速配ToolStripMenuItem.Click += new System.EventHandler(this.全速配ToolStripMenuItem_Click);
            // 
            // 宅配通ToolStripMenuItem
            // 
            this.宅配通ToolStripMenuItem.Name = "宅配通ToolStripMenuItem";
            this.宅配通ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.宅配通ToolStripMenuItem.Text = "宅配通";
            this.宅配通ToolStripMenuItem.Click += new System.EventHandler(this.宅配通ToolStripMenuItem_Click);
            // 
            // 測試用ToolStripMenuItem
            // 
            this.測試用ToolStripMenuItem.Name = "測試用ToolStripMenuItem";
            this.測試用ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.測試用ToolStripMenuItem.Text = "測試";
            this.測試用ToolStripMenuItem.Click += new System.EventHandler(this.測試用ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.姓名DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn,
            this.電話DataGridViewTextBoxColumn,
            this.手機DataGridViewTextBoxColumn,
            this.地址DataGridViewTextBoxColumn,
            this.內容DataGridViewTextBoxColumn,
            this.件數,
            this.指配日期DataGridViewTextBoxColumn,
            this.指配時段DataGridViewTextBoxColumn,
            this.代收方式DataGridViewTextBoxColumn,
            this.代收金額DataGridViewTextBoxColumn,
            this.體積,
            this.配送公司DataGridViewTextBoxColumn,
            this.配送單號});
            this.dataGridView1.DataSource = this.可配送資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1445, 445);
            this.dataGridView1.TabIndex = 1;
            // 
            // 指配時段類型BindingSource
            // 
            this.指配時段類型BindingSource.DataSource = typeof(WokyTool.通用.列舉.指配時段);
            // 
            // 代收類型BindingSource
            // 
            this.代收類型BindingSource.DataSource = typeof(WokyTool.通用.列舉.代收方式);
            // 
            // 配送公司類型BindingSource
            // 
            this.配送公司類型BindingSource.DataSource = typeof(WokyTool.通用.列舉.配送公司);
            // 
            // 可配送資料BindingSource
            // 
            this.可配送資料BindingSource.DataSource = typeof(WokyTool.配送.可配送資料);
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            // 
            // 電話DataGridViewTextBoxColumn
            // 
            this.電話DataGridViewTextBoxColumn.DataPropertyName = "電話";
            this.電話DataGridViewTextBoxColumn.HeaderText = "電話";
            this.電話DataGridViewTextBoxColumn.Name = "電話DataGridViewTextBoxColumn";
            this.電話DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 手機DataGridViewTextBoxColumn
            // 
            this.手機DataGridViewTextBoxColumn.DataPropertyName = "手機";
            this.手機DataGridViewTextBoxColumn.HeaderText = "手機";
            this.手機DataGridViewTextBoxColumn.Name = "手機DataGridViewTextBoxColumn";
            this.手機DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 地址DataGridViewTextBoxColumn
            // 
            this.地址DataGridViewTextBoxColumn.DataPropertyName = "地址";
            this.地址DataGridViewTextBoxColumn.HeaderText = "地址";
            this.地址DataGridViewTextBoxColumn.Name = "地址DataGridViewTextBoxColumn";
            this.地址DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 內容DataGridViewTextBoxColumn
            // 
            this.內容DataGridViewTextBoxColumn.DataPropertyName = "內容";
            this.內容DataGridViewTextBoxColumn.HeaderText = "內容";
            this.內容DataGridViewTextBoxColumn.Name = "內容DataGridViewTextBoxColumn";
            this.內容DataGridViewTextBoxColumn.ReadOnly = true;
            this.內容DataGridViewTextBoxColumn.Width = 200;
            // 
            // 件數
            // 
            this.件數.DataPropertyName = "件數";
            this.件數.HeaderText = "件數";
            this.件數.Name = "件數";
            // 
            // 指配日期DataGridViewTextBoxColumn
            // 
            this.指配日期DataGridViewTextBoxColumn.DataPropertyName = "指配日期";
            this.指配日期DataGridViewTextBoxColumn.HeaderText = "指配日期";
            this.指配日期DataGridViewTextBoxColumn.Name = "指配日期DataGridViewTextBoxColumn";
            this.指配日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 指配時段DataGridViewTextBoxColumn
            // 
            this.指配時段DataGridViewTextBoxColumn.DataPropertyName = "指配時段";
            this.指配時段DataGridViewTextBoxColumn.DataSource = this.指配時段類型BindingSource;
            this.指配時段DataGridViewTextBoxColumn.HeaderText = "指配時段";
            this.指配時段DataGridViewTextBoxColumn.Name = "指配時段DataGridViewTextBoxColumn";
            this.指配時段DataGridViewTextBoxColumn.ReadOnly = true;
            this.指配時段DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.指配時段DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 代收方式DataGridViewTextBoxColumn
            // 
            this.代收方式DataGridViewTextBoxColumn.DataPropertyName = "代收方式";
            this.代收方式DataGridViewTextBoxColumn.DataSource = this.代收類型BindingSource;
            this.代收方式DataGridViewTextBoxColumn.HeaderText = "代收方式";
            this.代收方式DataGridViewTextBoxColumn.Name = "代收方式DataGridViewTextBoxColumn";
            this.代收方式DataGridViewTextBoxColumn.ReadOnly = true;
            this.代收方式DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.代收方式DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 代收金額DataGridViewTextBoxColumn
            // 
            this.代收金額DataGridViewTextBoxColumn.DataPropertyName = "代收金額";
            this.代收金額DataGridViewTextBoxColumn.HeaderText = "代收金額";
            this.代收金額DataGridViewTextBoxColumn.Name = "代收金額DataGridViewTextBoxColumn";
            this.代收金額DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 體積
            // 
            this.體積.DataPropertyName = "體積";
            this.體積.HeaderText = "體積";
            this.體積.Name = "體積";
            this.體積.ReadOnly = true;
            // 
            // 配送公司DataGridViewTextBoxColumn
            // 
            this.配送公司DataGridViewTextBoxColumn.DataPropertyName = "配送公司";
            this.配送公司DataGridViewTextBoxColumn.DataSource = this.配送公司類型BindingSource;
            this.配送公司DataGridViewTextBoxColumn.HeaderText = "配送公司";
            this.配送公司DataGridViewTextBoxColumn.Name = "配送公司DataGridViewTextBoxColumn";
            this.配送公司DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.配送公司DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 配送單號
            // 
            this.配送單號.DataPropertyName = "配送單號";
            this.配送單號.HeaderText = "配送單號";
            this.配送單號.Name = "配送單號";
            // 
            // 待配送總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "待配送總覽視窗";
            this.Text = "待配送總覽";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.指配時段類型BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收類型BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.配送公司類型BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.可配送資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 略過ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全速配ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宅配通ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全速配ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 宅配通ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 測試用ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 配送公司類型BindingSource;
        private System.Windows.Forms.BindingSource 指配時段類型BindingSource;
        private System.Windows.Forms.BindingSource 代收類型BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 統計ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 可配送資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手機DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 內容DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 件數;
        private System.Windows.Forms.DataGridViewTextBoxColumn 指配日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 指配時段DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 代收方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代收金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 體積;
        private System.Windows.Forms.DataGridViewComboBoxColumn 配送公司DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配送單號;
    }
}