namespace WokyTool.一般訂單
{
    partial class 一般訂單總覽視窗
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.公司資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客戶資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.子客戶資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.商品名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.一般訂單資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.訂單處理狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.配送公司BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.指配時段BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收方式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.子客戶資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.一般訂單資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(651, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(675, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(445, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品名稱});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1343, 683);
            this.dataGridView1.TabIndex = 0;
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
            // 商品名稱
            // 
            this.商品名稱.DataPropertyName = "商品名稱";
            this.商品名稱.HeaderText = "商品名稱";
            this.商品名稱.Name = "商品名稱";
            this.商品名稱.ReadOnly = true;
            this.商品名稱.Width = 300;
            // 
            // 一般訂單資料BindingSource
            // 
            this.一般訂單資料BindingSource.DataSource = typeof(WokyTool.一般訂單.一般訂單資料);
            // 
            // 物品資料BindingSource
            // 
            this.物品資料BindingSource.DataSource = typeof(WokyTool.物品.物品資料);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.更新ToolStripMenuItem,
            this.匯出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1343, 24);
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
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.更新ToolStripMenuItem.Text = "更新";
            this.更新ToolStripMenuItem.Click += new System.EventHandler(this.更新ToolStripMenuItem_Click);
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            this.匯出ToolStripMenuItem.Click += new System.EventHandler(this.匯出ToolStripMenuItem_Click);
            // 
            // 一般訂單總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "一般訂單總覽視窗";
            this.Text = "一般訂單總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.訂單處理狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.配送公司BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.指配時段BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收方式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.子客戶資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.一般訂單資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.BindingSource 訂單處理狀態BindingSource;
        private System.Windows.Forms.BindingSource 客戶資料BindingSource;
        private System.Windows.Forms.BindingSource 子客戶資料BindingSource;
        private System.Windows.Forms.BindingSource 配送公司BindingSource;
        private System.Windows.Forms.BindingSource 指配時段BindingSource;
        private System.Windows.Forms.BindingSource 代收方式BindingSource;
        private System.Windows.Forms.BindingSource 物品資料BindingSource;
        private System.Windows.Forms.BindingSource 一般訂單資料BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名稱;
    }
}