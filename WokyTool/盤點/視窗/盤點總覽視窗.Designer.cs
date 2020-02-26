namespace WokyTool.盤點
{
    partial class 盤點總覽視窗
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
            this.myDataGridView1 = new WokyTool.通用.MyDataGridView();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.目前庫存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.大料架庫存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小料架庫存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.萬通庫存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.更新庫存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否一致 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.盤點資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.盤點資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AllowUserToAddRows = false;
            this.myDataGridView1.AutoGenerateColumns = false;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.單品名稱DataGridViewTextBoxColumn,
            this.目前庫存DataGridViewTextBoxColumn,
            this.大料架庫存DataGridViewTextBoxColumn,
            this.小料架庫存DataGridViewTextBoxColumn,
            this.萬通庫存DataGridViewTextBoxColumn,
            this.更新庫存DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn,
            this.是否一致});
            this.myDataGridView1.DataSource = this.盤點資料BindingSource;
            this.myDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView1.Location = new System.Drawing.Point(0, 24);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.RowTemplate.Height = 24;
            this.myDataGridView1.Size = new System.Drawing.Size(1252, 432);
            this.myDataGridView1.TabIndex = 3;
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 單品名稱DataGridViewTextBoxColumn
            // 
            this.單品名稱DataGridViewTextBoxColumn.DataPropertyName = "單品名稱";
            this.單品名稱DataGridViewTextBoxColumn.HeaderText = "單品名稱";
            this.單品名稱DataGridViewTextBoxColumn.Name = "單品名稱DataGridViewTextBoxColumn";
            this.單品名稱DataGridViewTextBoxColumn.ReadOnly = true;
            this.單品名稱DataGridViewTextBoxColumn.Width = 400;
            // 
            // 目前庫存DataGridViewTextBoxColumn
            // 
            this.目前庫存DataGridViewTextBoxColumn.DataPropertyName = "目前庫存";
            this.目前庫存DataGridViewTextBoxColumn.HeaderText = "目前庫存";
            this.目前庫存DataGridViewTextBoxColumn.Name = "目前庫存DataGridViewTextBoxColumn";
            // 
            // 大料架庫存DataGridViewTextBoxColumn
            // 
            this.大料架庫存DataGridViewTextBoxColumn.DataPropertyName = "大料架庫存";
            this.大料架庫存DataGridViewTextBoxColumn.HeaderText = "大料架庫存";
            this.大料架庫存DataGridViewTextBoxColumn.Name = "大料架庫存DataGridViewTextBoxColumn";
            // 
            // 小料架庫存DataGridViewTextBoxColumn
            // 
            this.小料架庫存DataGridViewTextBoxColumn.DataPropertyName = "小料架庫存";
            this.小料架庫存DataGridViewTextBoxColumn.HeaderText = "小料架庫存";
            this.小料架庫存DataGridViewTextBoxColumn.Name = "小料架庫存DataGridViewTextBoxColumn";
            // 
            // 萬通庫存DataGridViewTextBoxColumn
            // 
            this.萬通庫存DataGridViewTextBoxColumn.DataPropertyName = "萬通庫存";
            this.萬通庫存DataGridViewTextBoxColumn.HeaderText = "萬通庫存";
            this.萬通庫存DataGridViewTextBoxColumn.Name = "萬通庫存DataGridViewTextBoxColumn";
            // 
            // 更新庫存DataGridViewTextBoxColumn
            // 
            this.更新庫存DataGridViewTextBoxColumn.DataPropertyName = "更新庫存";
            this.更新庫存DataGridViewTextBoxColumn.HeaderText = "更新庫存";
            this.更新庫存DataGridViewTextBoxColumn.Name = "更新庫存DataGridViewTextBoxColumn";
            this.更新庫存DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            // 
            // 是否一致
            // 
            this.是否一致.DataPropertyName = "是否一致";
            this.是否一致.HeaderText = "是否一致";
            this.是否一致.Name = "是否一致";
            this.是否一致.ReadOnly = true;
            // 
            // 盤點資料BindingSource
            // 
            this.盤點資料BindingSource.DataSource = typeof(WokyTool.盤點.盤點資料);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.檢查ToolStripMenuItem,
            this.匯出ToolStripMenuItem,
            this.更新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 篩選ToolStripMenuItem
            // 
            this.篩選ToolStripMenuItem.Name = "篩選ToolStripMenuItem";
            this.篩選ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.篩選ToolStripMenuItem.Text = "篩選";
            // 
            // 檢查ToolStripMenuItem
            // 
            this.檢查ToolStripMenuItem.Name = "檢查ToolStripMenuItem";
            this.檢查ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檢查ToolStripMenuItem.Text = "檢查";
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂ToolStripMenuItem});
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            // 
            // 自訂ToolStripMenuItem
            // 
            this.自訂ToolStripMenuItem.Name = "自訂ToolStripMenuItem";
            this.自訂ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.自訂ToolStripMenuItem.Text = "自訂";
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通用ToolStripMenuItem});
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // 通用ToolStripMenuItem
            // 
            this.通用ToolStripMenuItem.Name = "通用ToolStripMenuItem";
            this.通用ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.通用ToolStripMenuItem.Text = "通用";
            this.通用ToolStripMenuItem.Click += new System.EventHandler(this.通用ToolStripMenuItem_Click);
            // 
            // 盤點總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 456);
            this.Controls.Add(this.myDataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "盤點總覽視窗";
            this.Text = "盤點總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.盤點資料BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通用ToolStripMenuItem;
        private 通用.MyDataGridView myDataGridView1;
        private System.Windows.Forms.BindingSource 盤點資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 目前庫存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 大料架庫存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小料架庫存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 萬通庫存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 更新庫存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 是否一致;
    }
}