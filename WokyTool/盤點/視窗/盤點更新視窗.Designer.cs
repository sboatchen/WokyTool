namespace WokyTool.盤點
{
    partial class 盤點更新視窗
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大料架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小料架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.萬通ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.盤點更新資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.更新狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.大料架庫存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小料架庫存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.萬通庫存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.錯誤訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.盤點更新資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AllowUserToAddRows = false;
            this.myDataGridView1.AutoGenerateColumns = false;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.更新狀態DataGridViewTextBoxColumn,
            this.物品識別DataGridViewTextBoxColumn,
            this.大料架庫存DataGridViewTextBoxColumn,
            this.小料架庫存DataGridViewTextBoxColumn,
            this.萬通庫存DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn,
            this.錯誤訊息DataGridViewTextBoxColumn});
            this.myDataGridView1.DataSource = this.盤點更新資料BindingSource;
            this.myDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView1.Location = new System.Drawing.Point(0, 24);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.RowTemplate.Height = 24;
            this.myDataGridView1.Size = new System.Drawing.Size(1046, 398);
            this.myDataGridView1.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.匯入ToolStripMenuItem,
            this.篩選ToolStripMenuItem,
            this.檢查ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 匯入ToolStripMenuItem
            // 
            this.匯入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大料架ToolStripMenuItem,
            this.小料架ToolStripMenuItem,
            this.萬通ToolStripMenuItem});
            this.匯入ToolStripMenuItem.Name = "匯入ToolStripMenuItem";
            this.匯入ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯入ToolStripMenuItem.Text = "匯入";
            // 
            // 大料架ToolStripMenuItem
            // 
            this.大料架ToolStripMenuItem.Name = "大料架ToolStripMenuItem";
            this.大料架ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.大料架ToolStripMenuItem.Text = "大料架";
            this.大料架ToolStripMenuItem.Click += new System.EventHandler(this.大料架ToolStripMenuItem_Click);
            // 
            // 小料架ToolStripMenuItem
            // 
            this.小料架ToolStripMenuItem.Name = "小料架ToolStripMenuItem";
            this.小料架ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.小料架ToolStripMenuItem.Text = "小料架";
            this.小料架ToolStripMenuItem.Click += new System.EventHandler(this.小料架ToolStripMenuItem_Click);
            // 
            // 萬通ToolStripMenuItem
            // 
            this.萬通ToolStripMenuItem.Name = "萬通ToolStripMenuItem";
            this.萬通ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.萬通ToolStripMenuItem.Text = "萬通";
            this.萬通ToolStripMenuItem.Click += new System.EventHandler(this.萬通ToolStripMenuItem_Click);
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
            // 盤點更新資料BindingSource
            // 
            this.盤點更新資料BindingSource.DataSource = typeof(WokyTool.盤點.盤點更新資料);
            // 
            // 更新狀態DataGridViewTextBoxColumn
            // 
            this.更新狀態DataGridViewTextBoxColumn.DataPropertyName = "更新狀態";
            this.更新狀態DataGridViewTextBoxColumn.HeaderText = "更新狀態";
            this.更新狀態DataGridViewTextBoxColumn.Name = "更新狀態DataGridViewTextBoxColumn";
            this.更新狀態DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 物品識別DataGridViewTextBoxColumn
            // 
            this.物品識別DataGridViewTextBoxColumn.DataPropertyName = "物品識別";
            this.物品識別DataGridViewTextBoxColumn.HeaderText = "物品識別";
            this.物品識別DataGridViewTextBoxColumn.Name = "物品識別DataGridViewTextBoxColumn";
            this.物品識別DataGridViewTextBoxColumn.Width = 400;
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
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            // 
            // 錯誤訊息DataGridViewTextBoxColumn
            // 
            this.錯誤訊息DataGridViewTextBoxColumn.DataPropertyName = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.HeaderText = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.Name = "錯誤訊息DataGridViewTextBoxColumn";
            // 
            // 盤點更新視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 422);
            this.Controls.Add(this.myDataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "盤點更新視窗";
            this.Text = "盤點更新視窗";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.盤點更新資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private 通用.MyDataGridView myDataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 大料架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小料架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 萬通ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 更新狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 大料架庫存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小料架庫存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 萬通庫存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 錯誤訊息DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 盤點更新資料BindingSource;

    }
}