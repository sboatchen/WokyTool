namespace WokyTool.發票
{
    partial class 發票匯入視窗
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.樣板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.發票匯入資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.發票號碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.註記DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.格式代號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.發票狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.發票日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.買方統一編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.買方名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.賣方統一編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.賣方名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.寄送日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.銷售額合計DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.營業稅DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.總計DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.課稅別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.匯率DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.載具號碼1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.載具號碼2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.總備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.錯誤訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.發票匯入資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.發票號碼DataGridViewTextBoxColumn,
            this.註記DataGridViewTextBoxColumn,
            this.格式代號DataGridViewTextBoxColumn,
            this.發票狀態DataGridViewTextBoxColumn,
            this.發票日期DataGridViewTextBoxColumn,
            this.買方統一編號DataGridViewTextBoxColumn,
            this.買方名稱DataGridViewTextBoxColumn,
            this.賣方統一編號DataGridViewTextBoxColumn,
            this.賣方名稱DataGridViewTextBoxColumn,
            this.寄送日期DataGridViewTextBoxColumn,
            this.銷售額合計DataGridViewTextBoxColumn,
            this.營業稅DataGridViewTextBoxColumn,
            this.總計DataGridViewTextBoxColumn,
            this.課稅別DataGridViewTextBoxColumn,
            this.匯率DataGridViewTextBoxColumn,
            this.載具號碼1DataGridViewTextBoxColumn,
            this.載具號碼2DataGridViewTextBoxColumn,
            this.總備註DataGridViewTextBoxColumn,
            this.錯誤訊息DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.發票匯入資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1514, 686);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.樣板ToolStripMenuItem,
            this.匯入ToolStripMenuItem,
            this.檢查ToolStripMenuItem,
            this.匯出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1514, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 樣板ToolStripMenuItem
            // 
            this.樣板ToolStripMenuItem.Name = "樣板ToolStripMenuItem";
            this.樣板ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.樣板ToolStripMenuItem.Text = "樣板";
            this.樣板ToolStripMenuItem.Click += new System.EventHandler(this.樣板ToolStripMenuItem_Click);
            // 
            // 匯入ToolStripMenuItem
            // 
            this.匯入ToolStripMenuItem.Name = "匯入ToolStripMenuItem";
            this.匯入ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯入ToolStripMenuItem.Text = "匯入";
            this.匯入ToolStripMenuItem.Click += new System.EventHandler(this.匯入ToolStripMenuItem_Click);
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
            // 發票匯入資料BindingSource
            // 
            this.發票匯入資料BindingSource.DataSource = typeof(WokyTool.發票.發票匯入資料);
            // 
            // 發票號碼DataGridViewTextBoxColumn
            // 
            this.發票號碼DataGridViewTextBoxColumn.DataPropertyName = "發票號碼";
            this.發票號碼DataGridViewTextBoxColumn.HeaderText = "發票號碼";
            this.發票號碼DataGridViewTextBoxColumn.Name = "發票號碼DataGridViewTextBoxColumn";
            // 
            // 註記DataGridViewTextBoxColumn
            // 
            this.註記DataGridViewTextBoxColumn.DataPropertyName = "註記";
            this.註記DataGridViewTextBoxColumn.HeaderText = "註記";
            this.註記DataGridViewTextBoxColumn.Name = "註記DataGridViewTextBoxColumn";
            // 
            // 格式代號DataGridViewTextBoxColumn
            // 
            this.格式代號DataGridViewTextBoxColumn.DataPropertyName = "格式代號";
            this.格式代號DataGridViewTextBoxColumn.HeaderText = "格式代號";
            this.格式代號DataGridViewTextBoxColumn.Name = "格式代號DataGridViewTextBoxColumn";
            // 
            // 發票狀態DataGridViewTextBoxColumn
            // 
            this.發票狀態DataGridViewTextBoxColumn.DataPropertyName = "發票狀態";
            this.發票狀態DataGridViewTextBoxColumn.HeaderText = "發票狀態";
            this.發票狀態DataGridViewTextBoxColumn.Name = "發票狀態DataGridViewTextBoxColumn";
            // 
            // 發票日期DataGridViewTextBoxColumn
            // 
            this.發票日期DataGridViewTextBoxColumn.DataPropertyName = "發票日期";
            this.發票日期DataGridViewTextBoxColumn.HeaderText = "發票日期";
            this.發票日期DataGridViewTextBoxColumn.Name = "發票日期DataGridViewTextBoxColumn";
            // 
            // 買方統一編號DataGridViewTextBoxColumn
            // 
            this.買方統一編號DataGridViewTextBoxColumn.DataPropertyName = "買方統一編號";
            this.買方統一編號DataGridViewTextBoxColumn.HeaderText = "買方統一編號";
            this.買方統一編號DataGridViewTextBoxColumn.Name = "買方統一編號DataGridViewTextBoxColumn";
            // 
            // 買方名稱DataGridViewTextBoxColumn
            // 
            this.買方名稱DataGridViewTextBoxColumn.DataPropertyName = "買方名稱";
            this.買方名稱DataGridViewTextBoxColumn.HeaderText = "買方名稱";
            this.買方名稱DataGridViewTextBoxColumn.Name = "買方名稱DataGridViewTextBoxColumn";
            // 
            // 賣方統一編號DataGridViewTextBoxColumn
            // 
            this.賣方統一編號DataGridViewTextBoxColumn.DataPropertyName = "賣方統一編號";
            this.賣方統一編號DataGridViewTextBoxColumn.HeaderText = "賣方統一編號";
            this.賣方統一編號DataGridViewTextBoxColumn.Name = "賣方統一編號DataGridViewTextBoxColumn";
            // 
            // 賣方名稱DataGridViewTextBoxColumn
            // 
            this.賣方名稱DataGridViewTextBoxColumn.DataPropertyName = "賣方名稱";
            this.賣方名稱DataGridViewTextBoxColumn.HeaderText = "賣方名稱";
            this.賣方名稱DataGridViewTextBoxColumn.Name = "賣方名稱DataGridViewTextBoxColumn";
            // 
            // 寄送日期DataGridViewTextBoxColumn
            // 
            this.寄送日期DataGridViewTextBoxColumn.DataPropertyName = "寄送日期";
            this.寄送日期DataGridViewTextBoxColumn.HeaderText = "寄送日期";
            this.寄送日期DataGridViewTextBoxColumn.Name = "寄送日期DataGridViewTextBoxColumn";
            // 
            // 銷售額合計DataGridViewTextBoxColumn
            // 
            this.銷售額合計DataGridViewTextBoxColumn.DataPropertyName = "銷售額合計";
            this.銷售額合計DataGridViewTextBoxColumn.HeaderText = "銷售額合計";
            this.銷售額合計DataGridViewTextBoxColumn.Name = "銷售額合計DataGridViewTextBoxColumn";
            // 
            // 營業稅DataGridViewTextBoxColumn
            // 
            this.營業稅DataGridViewTextBoxColumn.DataPropertyName = "營業稅";
            this.營業稅DataGridViewTextBoxColumn.HeaderText = "營業稅";
            this.營業稅DataGridViewTextBoxColumn.Name = "營業稅DataGridViewTextBoxColumn";
            // 
            // 總計DataGridViewTextBoxColumn
            // 
            this.總計DataGridViewTextBoxColumn.DataPropertyName = "總計";
            this.總計DataGridViewTextBoxColumn.HeaderText = "總計";
            this.總計DataGridViewTextBoxColumn.Name = "總計DataGridViewTextBoxColumn";
            // 
            // 課稅別DataGridViewTextBoxColumn
            // 
            this.課稅別DataGridViewTextBoxColumn.DataPropertyName = "課稅別";
            this.課稅別DataGridViewTextBoxColumn.HeaderText = "課稅別";
            this.課稅別DataGridViewTextBoxColumn.Name = "課稅別DataGridViewTextBoxColumn";
            // 
            // 匯率DataGridViewTextBoxColumn
            // 
            this.匯率DataGridViewTextBoxColumn.DataPropertyName = "匯率";
            this.匯率DataGridViewTextBoxColumn.HeaderText = "匯率";
            this.匯率DataGridViewTextBoxColumn.Name = "匯率DataGridViewTextBoxColumn";
            // 
            // 載具號碼1DataGridViewTextBoxColumn
            // 
            this.載具號碼1DataGridViewTextBoxColumn.DataPropertyName = "載具號碼1";
            this.載具號碼1DataGridViewTextBoxColumn.HeaderText = "載具號碼1";
            this.載具號碼1DataGridViewTextBoxColumn.Name = "載具號碼1DataGridViewTextBoxColumn";
            // 
            // 載具號碼2DataGridViewTextBoxColumn
            // 
            this.載具號碼2DataGridViewTextBoxColumn.DataPropertyName = "載具號碼2";
            this.載具號碼2DataGridViewTextBoxColumn.HeaderText = "載具號碼2";
            this.載具號碼2DataGridViewTextBoxColumn.Name = "載具號碼2DataGridViewTextBoxColumn";
            // 
            // 總備註DataGridViewTextBoxColumn
            // 
            this.總備註DataGridViewTextBoxColumn.DataPropertyName = "總備註";
            this.總備註DataGridViewTextBoxColumn.HeaderText = "總備註";
            this.總備註DataGridViewTextBoxColumn.Name = "總備註DataGridViewTextBoxColumn";
            // 
            // 錯誤訊息DataGridViewTextBoxColumn
            // 
            this.錯誤訊息DataGridViewTextBoxColumn.DataPropertyName = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.HeaderText = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.Name = "錯誤訊息DataGridViewTextBoxColumn";
            // 
            // 發票匯入視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 710);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "發票匯入視窗";
            this.Text = "發票匯入視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.發票匯入資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 樣板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 發票號碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 註記DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 格式代號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 發票狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 發票日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 買方統一編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 買方名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 賣方統一編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 賣方名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 寄送日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 銷售額合計DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 營業稅DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 總計DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 課稅別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 匯率DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 載具號碼1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 載具號碼2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 總備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 錯誤訊息DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 發票匯入資料BindingSource;
    }
}