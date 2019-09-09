using WokyTool.通用;

namespace WokyTool.配送
{
    partial class 配送新增總覽視窗
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
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全速配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全速配匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全速配匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全速配撿貨ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全速配明細ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宅配通ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宅配通匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宅配通匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宅配通撿貨ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宅配通明細ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.測試用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myDataGridView1 = new WokyTool.通用.MyDataGridView();
            this.配送公司DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配送單號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手機DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.指配日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.指配時段DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代收方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代收金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.件數DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.內容DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配送轉換資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.配送轉換資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檢查ToolStripMenuItem,
            this.篩選ToolStripMenuItem,
            this.全速配ToolStripMenuItem,
            this.宅配通ToolStripMenuItem,
            this.測試用ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2063, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檢查ToolStripMenuItem
            // 
            this.檢查ToolStripMenuItem.Name = "檢查ToolStripMenuItem";
            this.檢查ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.檢查ToolStripMenuItem.Text = "檢查";
            // 
            // 篩選ToolStripMenuItem
            // 
            this.篩選ToolStripMenuItem.Name = "篩選ToolStripMenuItem";
            this.篩選ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.篩選ToolStripMenuItem.Text = "篩選";
            // 
            // 全速配ToolStripMenuItem
            // 
            this.全速配ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全速配匯出ToolStripMenuItem,
            this.全速配匯入ToolStripMenuItem,
            this.全速配撿貨ToolStripMenuItem,
            this.全速配明細ToolStripMenuItem});
            this.全速配ToolStripMenuItem.Name = "全速配ToolStripMenuItem";
            this.全速配ToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.全速配ToolStripMenuItem.Text = "全速配";
            // 
            // 全速配匯出ToolStripMenuItem
            // 
            this.全速配匯出ToolStripMenuItem.Name = "全速配匯出ToolStripMenuItem";
            this.全速配匯出ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.全速配匯出ToolStripMenuItem.Text = "匯出";
            this.全速配匯出ToolStripMenuItem.Click += new System.EventHandler(this.全速配匯出ToolStripMenuItem_Click);
            // 
            // 全速配匯入ToolStripMenuItem
            // 
            this.全速配匯入ToolStripMenuItem.Name = "全速配匯入ToolStripMenuItem";
            this.全速配匯入ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.全速配匯入ToolStripMenuItem.Text = "匯入";
            this.全速配匯入ToolStripMenuItem.Click += new System.EventHandler(this.全速配匯入ToolStripMenuItem_Click);
            // 
            // 全速配撿貨ToolStripMenuItem
            // 
            this.全速配撿貨ToolStripMenuItem.Name = "全速配撿貨ToolStripMenuItem";
            this.全速配撿貨ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.全速配撿貨ToolStripMenuItem.Text = "撿貨";
            this.全速配撿貨ToolStripMenuItem.Click += new System.EventHandler(this.全速配撿貨ToolStripMenuItem_Click);
            // 
            // 全速配明細ToolStripMenuItem
            // 
            this.全速配明細ToolStripMenuItem.Name = "全速配明細ToolStripMenuItem";
            this.全速配明細ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.全速配明細ToolStripMenuItem.Text = "明細";
            this.全速配明細ToolStripMenuItem.Click += new System.EventHandler(this.全速配明細ToolStripMenuItem_Click);
            // 
            // 宅配通ToolStripMenuItem
            // 
            this.宅配通ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.宅配通匯出ToolStripMenuItem,
            this.宅配通匯入ToolStripMenuItem,
            this.宅配通撿貨ToolStripMenuItem,
            this.宅配通明細ToolStripMenuItem});
            this.宅配通ToolStripMenuItem.Name = "宅配通ToolStripMenuItem";
            this.宅配通ToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.宅配通ToolStripMenuItem.Text = "宅配通";
            // 
            // 宅配通匯出ToolStripMenuItem
            // 
            this.宅配通匯出ToolStripMenuItem.Name = "宅配通匯出ToolStripMenuItem";
            this.宅配通匯出ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.宅配通匯出ToolStripMenuItem.Text = "匯出";
            this.宅配通匯出ToolStripMenuItem.Click += new System.EventHandler(this.宅配通匯出ToolStripMenuItem_Click);
            // 
            // 宅配通匯入ToolStripMenuItem
            // 
            this.宅配通匯入ToolStripMenuItem.Name = "宅配通匯入ToolStripMenuItem";
            this.宅配通匯入ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.宅配通匯入ToolStripMenuItem.Text = "匯入";
            this.宅配通匯入ToolStripMenuItem.Click += new System.EventHandler(this.宅配通匯入ToolStripMenuItem_Click);
            // 
            // 宅配通撿貨ToolStripMenuItem
            // 
            this.宅配通撿貨ToolStripMenuItem.Name = "宅配通撿貨ToolStripMenuItem";
            this.宅配通撿貨ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.宅配通撿貨ToolStripMenuItem.Text = "撿貨";
            this.宅配通撿貨ToolStripMenuItem.Click += new System.EventHandler(this.宅配通撿貨ToolStripMenuItem_Click);
            // 
            // 宅配通明細ToolStripMenuItem
            // 
            this.宅配通明細ToolStripMenuItem.Name = "宅配通明細ToolStripMenuItem";
            this.宅配通明細ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.宅配通明細ToolStripMenuItem.Text = "明細";
            this.宅配通明細ToolStripMenuItem.Click += new System.EventHandler(this.宅配通明細ToolStripMenuItem_Click);
            // 
            // 測試用ToolStripMenuItem
            // 
            this.測試用ToolStripMenuItem.Name = "測試用ToolStripMenuItem";
            this.測試用ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.測試用ToolStripMenuItem.Text = "測試";
            this.測試用ToolStripMenuItem.Click += new System.EventHandler(this.測試ToolStripMenuItem_Click);
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AutoGenerateColumns = false;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.配送公司DataGridViewTextBoxColumn,
            this.配送單號DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.地址DataGridViewTextBoxColumn,
            this.電話DataGridViewTextBoxColumn,
            this.手機DataGridViewTextBoxColumn,
            this.指配日期DataGridViewTextBoxColumn,
            this.指配時段DataGridViewTextBoxColumn,
            this.代收方式DataGridViewTextBoxColumn,
            this.代收金額DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn,
            this.件數DataGridViewTextBoxColumn,
            this.內容DataGridViewTextBoxColumn});
            this.myDataGridView1.DataSource = this.配送轉換資料BindingSource;
            this.myDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView1.Location = new System.Drawing.Point(0, 27);
            this.myDataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.RowTemplate.Height = 24;
            this.myDataGridView1.Size = new System.Drawing.Size(2063, 559);
            this.myDataGridView1.TabIndex = 1;
            // 
            // 配送公司DataGridViewTextBoxColumn
            // 
            this.配送公司DataGridViewTextBoxColumn.DataPropertyName = "配送公司";
            this.配送公司DataGridViewTextBoxColumn.HeaderText = "配送公司";
            this.配送公司DataGridViewTextBoxColumn.Name = "配送公司DataGridViewTextBoxColumn";
            // 
            // 配送單號DataGridViewTextBoxColumn
            // 
            this.配送單號DataGridViewTextBoxColumn.DataPropertyName = "配送單號";
            this.配送單號DataGridViewTextBoxColumn.HeaderText = "配送單號";
            this.配送單號DataGridViewTextBoxColumn.Name = "配送單號DataGridViewTextBoxColumn";
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
            // 指配日期DataGridViewTextBoxColumn
            // 
            this.指配日期DataGridViewTextBoxColumn.DataPropertyName = "指配日期";
            this.指配日期DataGridViewTextBoxColumn.HeaderText = "指配日期";
            this.指配日期DataGridViewTextBoxColumn.Name = "指配日期DataGridViewTextBoxColumn";
            // 
            // 指配時段DataGridViewTextBoxColumn
            // 
            this.指配時段DataGridViewTextBoxColumn.DataPropertyName = "指配時段";
            this.指配時段DataGridViewTextBoxColumn.HeaderText = "指配時段";
            this.指配時段DataGridViewTextBoxColumn.Name = "指配時段DataGridViewTextBoxColumn";
            // 
            // 代收方式DataGridViewTextBoxColumn
            // 
            this.代收方式DataGridViewTextBoxColumn.DataPropertyName = "代收方式";
            this.代收方式DataGridViewTextBoxColumn.HeaderText = "代收方式";
            this.代收方式DataGridViewTextBoxColumn.Name = "代收方式DataGridViewTextBoxColumn";
            // 
            // 代收金額DataGridViewTextBoxColumn
            // 
            this.代收金額DataGridViewTextBoxColumn.DataPropertyName = "代收金額";
            this.代收金額DataGridViewTextBoxColumn.HeaderText = "代收金額";
            this.代收金額DataGridViewTextBoxColumn.Name = "代收金額DataGridViewTextBoxColumn";
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            // 
            // 件數DataGridViewTextBoxColumn
            // 
            this.件數DataGridViewTextBoxColumn.DataPropertyName = "件數";
            this.件數DataGridViewTextBoxColumn.HeaderText = "件數";
            this.件數DataGridViewTextBoxColumn.Name = "件數DataGridViewTextBoxColumn";
            // 
            // 內容DataGridViewTextBoxColumn
            // 
            this.內容DataGridViewTextBoxColumn.DataPropertyName = "內容";
            this.內容DataGridViewTextBoxColumn.HeaderText = "內容";
            this.內容DataGridViewTextBoxColumn.Name = "內容DataGridViewTextBoxColumn";
            this.內容DataGridViewTextBoxColumn.Width = 300;
            // 
            // 配送轉換資料BindingSource
            // 
            this.配送轉換資料BindingSource.DataSource = typeof(WokyTool.配送.配送轉換資料);
            // 
            // 配送新增總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2063, 586);
            this.Controls.Add(this.myDataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "配送新增總覽視窗";
            this.Text = "配送新增總覽視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.配送轉換資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 測試用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private MyDataGridView myDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配送公司DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配送單號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手機DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 指配日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 指配時段DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代收方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代收金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 件數DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 內容DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 配送轉換資料BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 全速配ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全速配匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全速配匯入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全速配撿貨ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全速配明細ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宅配通ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宅配通匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宅配通匯入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宅配通撿貨ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宅配通明細ToolStripMenuItem;
    }
}