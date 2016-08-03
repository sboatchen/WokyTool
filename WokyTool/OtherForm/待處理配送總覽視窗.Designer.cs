namespace WokyTool.OtherForm
{
    partial class 待處理配送總覽視窗
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
            this.匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全速配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宅配通ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.可配送BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手機DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地址DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.貨運商品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配送公司DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配送單號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.指配日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.指配時段DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代收方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代收金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.可配送BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.略過ToolStripMenuItem,
            this.匯出ToolStripMenuItem,
            this.匯入ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 24);
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
            this.宅配通ToolStripMenuItem1});
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.姓名DataGridViewTextBoxColumn,
            this.電話DataGridViewTextBoxColumn,
            this.手機DataGridViewTextBoxColumn,
            this.地址DataGridViewTextBoxColumn,
            this.貨運商品DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn,
            this.配送公司DataGridViewTextBoxColumn,
            this.配送單號,
            this.指配日期DataGridViewTextBoxColumn,
            this.指配時段DataGridViewTextBoxColumn,
            this.代收方式DataGridViewTextBoxColumn,
            this.代收金額DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.可配送BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 435);
            this.dataGridView1.TabIndex = 1;
            // 
            // 可配送BindingSource
            // 
            this.可配送BindingSource.DataSource = typeof(WokyTool.Common.可配送);
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "配送姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            this.姓名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 電話DataGridViewTextBoxColumn
            // 
            this.電話DataGridViewTextBoxColumn.DataPropertyName = "配送電話";
            this.電話DataGridViewTextBoxColumn.HeaderText = "電話";
            this.電話DataGridViewTextBoxColumn.Name = "電話DataGridViewTextBoxColumn";
            this.電話DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 手機DataGridViewTextBoxColumn
            // 
            this.手機DataGridViewTextBoxColumn.DataPropertyName = "配送手機";
            this.手機DataGridViewTextBoxColumn.HeaderText = "手機";
            this.手機DataGridViewTextBoxColumn.Name = "手機DataGridViewTextBoxColumn";
            this.手機DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 地址DataGridViewTextBoxColumn
            // 
            this.地址DataGridViewTextBoxColumn.DataPropertyName = "配送地址";
            this.地址DataGridViewTextBoxColumn.HeaderText = "地址";
            this.地址DataGridViewTextBoxColumn.Name = "地址DataGridViewTextBoxColumn";
            this.地址DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 貨運商品DataGridViewTextBoxColumn
            // 
            this.貨運商品DataGridViewTextBoxColumn.DataPropertyName = "配送商品";
            this.貨運商品DataGridViewTextBoxColumn.HeaderText = "商品";
            this.貨運商品DataGridViewTextBoxColumn.Name = "貨運商品DataGridViewTextBoxColumn";
            this.貨運商品DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "配送備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            this.備註DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 配送公司DataGridViewTextBoxColumn
            // 
            this.配送公司DataGridViewTextBoxColumn.DataPropertyName = "配送公司";
            this.配送公司DataGridViewTextBoxColumn.HeaderText = "配送公司";
            this.配送公司DataGridViewTextBoxColumn.Name = "配送公司DataGridViewTextBoxColumn";
            this.配送公司DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 配送單號
            // 
            this.配送單號.DataPropertyName = "配送單號";
            this.配送單號.HeaderText = "配送單號";
            this.配送單號.Name = "配送單號";
            this.配送單號.ReadOnly = true;
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
            this.指配時段DataGridViewTextBoxColumn.HeaderText = "指配時段";
            this.指配時段DataGridViewTextBoxColumn.Name = "指配時段DataGridViewTextBoxColumn";
            this.指配時段DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 代收方式DataGridViewTextBoxColumn
            // 
            this.代收方式DataGridViewTextBoxColumn.DataPropertyName = "代收方式";
            this.代收方式DataGridViewTextBoxColumn.HeaderText = "代收方式";
            this.代收方式DataGridViewTextBoxColumn.Name = "代收方式DataGridViewTextBoxColumn";
            this.代收方式DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 代收金額DataGridViewTextBoxColumn
            // 
            this.代收金額DataGridViewTextBoxColumn.DataPropertyName = "代收金額";
            this.代收金額DataGridViewTextBoxColumn.HeaderText = "代收金額";
            this.代收金額DataGridViewTextBoxColumn.Name = "代收金額DataGridViewTextBoxColumn";
            this.代收金額DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 待處理配送總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "待處理配送總覽視窗";
            this.Text = "待處理配送總覽";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.可配送BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 略過ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 可配送BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全速配ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宅配通ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全速配ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 宅配通ToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手機DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地址DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 貨運商品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配送公司DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配送單號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 指配日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 指配時段DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代收方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代收金額DataGridViewTextBoxColumn;
    }
}