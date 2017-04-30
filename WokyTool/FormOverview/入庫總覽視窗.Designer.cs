namespace WokyTool.FormOverview
{
    partial class 入庫總覽視窗
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
            this.入庫資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.運作 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.商品 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.公司 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.廠商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.入庫資料BindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
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
            this.編號,
            this.時間,
            this.運作,
            this.商品,
            this.公司,
            this.廠商,
            this.數量});
            this.dataGridView1.DataSource = this.入庫資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(945, 324);
            this.dataGridView1.TabIndex = 1;
            // 
            // 入庫資料BindingSource
            // 
            this.入庫資料BindingSource.DataSource = typeof(WokyTool.Data.入庫資料);
            // 
            // 商品資料BindingSource
            // 
            this.商品資料BindingSource.DataSource = typeof(WokyTool.Data.商品資料);
            // 
            // 編號
            // 
            this.編號.DataPropertyName = "編號";
            this.編號.HeaderText = "編號";
            this.編號.Name = "編號";
            // 
            // 時間
            // 
            this.時間.DataPropertyName = "時間";
            this.時間.HeaderText = "時間";
            this.時間.Name = "時間";
            // 
            // 運作
            // 
            this.運作.DataPropertyName = "運作";
            this.運作.HeaderText = "運作";
            this.運作.Name = "運作";
            // 
            // 商品
            // 
            this.商品.DataPropertyName = "商品編號";
            this.商品.DataSource = this.商品資料BindingSource;
            this.商品.DisplayMember = "名稱";
            this.商品.HeaderText = "商品";
            this.商品.Name = "商品";
            this.商品.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.商品.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.商品.ValueMember = "編號";
            this.商品.Width = 300;
            // 
            // 公司
            // 
            this.公司.DataPropertyName = "公司名稱";
            this.公司.HeaderText = "公司";
            this.公司.Name = "公司";
            this.公司.ReadOnly = true;
            // 
            // 廠商
            // 
            this.廠商.DataPropertyName = "廠商名稱";
            this.廠商.HeaderText = "廠商";
            this.廠商.Name = "廠商";
            this.廠商.ReadOnly = true;
            // 
            // 數量
            // 
            this.數量.DataPropertyName = "數量";
            this.數量.HeaderText = "數量";
            this.數量.Name = "數量";
            // 
            // 入庫總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 348);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "入庫總覽視窗";
            this.Text = "入庫總覽視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.入庫資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 時間;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 運作;
        private System.Windows.Forms.DataGridViewComboBoxColumn 商品;
        private System.Windows.Forms.BindingSource 商品資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司;
        private System.Windows.Forms.DataGridViewTextBoxColumn 廠商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量;
        private System.Windows.Forms.BindingSource 入庫資料BindingSource;
    }
}