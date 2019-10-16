namespace WokyTool.一般訂單
{
    partial class 一般訂單新增總覽視窗
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
            this.訂單處理狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.公司資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客戶資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.子客戶資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.配送公司BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.指配時段BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.代收方式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.列印單價 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.一般訂單新增資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配送ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂單處理狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.子客戶資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.配送公司BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.指配時段BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收方式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.一般訂單新增資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.列印單價});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1845, 534);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // 訂單處理狀態BindingSource
            // 
            this.訂單處理狀態BindingSource.DataSource = typeof(WokyTool.通用.列舉.訂單處理狀態);
            // 
            // 公司資料BindingSource
            // 
            this.公司資料BindingSource.DataSource = typeof(WokyTool.公司.公司資料);
            // 
            // 客戶資料BindingSource
            // 
            this.客戶資料BindingSource.DataSource = typeof(WokyTool.客戶.客戶資料);
            // 
            // 子客戶資料BindingSource
            // 
            this.子客戶資料BindingSource.DataSource = typeof(WokyTool.客戶.子客戶資料);
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
            // 列印單價
            // 
            this.列印單價.DataPropertyName = "列印單價";
            this.列印單價.HeaderText = "列印單價";
            this.列印單價.Name = "列印單價";
            // 
            // 一般訂單新增資料BindingSource
            // 
            this.一般訂單新增資料BindingSource.DataSource = typeof(WokyTool.一般訂單.一般訂單新增資料);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.配送ToolStripMenuItem,
            this.匯出ToolStripMenuItem,
            this.完成ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1845, 24);
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
            // 配送ToolStripMenuItem
            // 
            this.配送ToolStripMenuItem.Name = "配送ToolStripMenuItem";
            this.配送ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.配送ToolStripMenuItem.Text = "配送";
            this.配送ToolStripMenuItem.Click += new System.EventHandler(this.配送ToolStripMenuItem_Click);
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            this.匯出ToolStripMenuItem.Click += new System.EventHandler(this.匯出ToolStripMenuItem_Click);
            // 
            // 完成ToolStripMenuItem
            // 
            this.完成ToolStripMenuItem.Name = "完成ToolStripMenuItem";
            this.完成ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.完成ToolStripMenuItem.Text = "完成";
            this.完成ToolStripMenuItem.Click += new System.EventHandler(this.完成ToolStripMenuItem_Click);
            // 
            // 一般訂單新增總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1845, 558);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "一般訂單新增總覽視窗";
            this.Text = "一般訂單新增總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.訂單處理狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.子客戶資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.配送公司BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.指配時段BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收方式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.一般訂單新增資料BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 公司資料BindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配送ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 一般訂單新增資料BindingSource;
        private System.Windows.Forms.BindingSource 訂單處理狀態BindingSource;
        private System.Windows.Forms.BindingSource 客戶資料BindingSource;
        private System.Windows.Forms.BindingSource 子客戶資料BindingSource;
        private System.Windows.Forms.BindingSource 配送公司BindingSource;
        private System.Windows.Forms.BindingSource 指配時段BindingSource;
        private System.Windows.Forms.BindingSource 代收方式BindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 列印單價;
    }
}