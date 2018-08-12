using WokyTool.通用;
namespace WokyTool.物品
{
    partial class 物品條碼更新匯入視窗
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
            this.匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.樣板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.縮寫DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.目標物品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.條碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.更新狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.更新訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品條碼更新資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.更新狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品條碼更新資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.匯入ToolStripMenuItem,
            this.樣板ToolStripMenuItem,
            this.匯出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 匯入ToolStripMenuItem
            // 
            this.匯入ToolStripMenuItem.Name = "匯入ToolStripMenuItem";
            this.匯入ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯入ToolStripMenuItem.Text = "匯入";
            this.匯入ToolStripMenuItem.Click += new System.EventHandler(this.匯入ToolStripMenuItem_Click);
            // 
            // 樣板ToolStripMenuItem
            // 
            this.樣板ToolStripMenuItem.Name = "樣板ToolStripMenuItem";
            this.樣板ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.樣板ToolStripMenuItem.Text = "樣板";
            this.樣板ToolStripMenuItem.Click += new System.EventHandler(this.樣板ToolStripMenuItem_Click);
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            this.匯出ToolStripMenuItem.Click += new System.EventHandler(this.匯出ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.縮寫DataGridViewTextBoxColumn,
            this.目標物品DataGridViewTextBoxColumn,
            this.條碼DataGridViewTextBoxColumn,
            this.狀態DataGridViewTextBoxColumn,
            this.更新訊息DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.物品條碼更新資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 432);
            this.dataGridView1.TabIndex = 1;
            // 
            // 縮寫DataGridViewTextBoxColumn
            // 
            this.縮寫DataGridViewTextBoxColumn.DataPropertyName = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.HeaderText = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.Name = "縮寫DataGridViewTextBoxColumn";
            this.縮寫DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 目標物品DataGridViewTextBoxColumn
            // 
            this.目標物品DataGridViewTextBoxColumn.DataPropertyName = "目標物品";
            this.目標物品DataGridViewTextBoxColumn.HeaderText = "目標物品";
            this.目標物品DataGridViewTextBoxColumn.Name = "目標物品DataGridViewTextBoxColumn";
            this.目標物品DataGridViewTextBoxColumn.Width = 300;
            // 
            // 條碼DataGridViewTextBoxColumn
            // 
            this.條碼DataGridViewTextBoxColumn.DataPropertyName = "條碼";
            this.條碼DataGridViewTextBoxColumn.HeaderText = "條碼";
            this.條碼DataGridViewTextBoxColumn.Name = "條碼DataGridViewTextBoxColumn";
            // 
            // 狀態DataGridViewTextBoxColumn
            // 
            this.狀態DataGridViewTextBoxColumn.DataPropertyName = "狀態";
            this.狀態DataGridViewTextBoxColumn.DataSource = this.更新狀態BindingSource;
            this.狀態DataGridViewTextBoxColumn.HeaderText = "狀態";
            this.狀態DataGridViewTextBoxColumn.Name = "狀態DataGridViewTextBoxColumn";
            this.狀態DataGridViewTextBoxColumn.ReadOnly = true;
            this.狀態DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.狀態DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 更新狀態BindingSource
            // 
            this.更新狀態BindingSource.DataSource = typeof(列舉.更新狀態);
            // 
            // 更新訊息DataGridViewTextBoxColumn
            // 
            this.更新訊息DataGridViewTextBoxColumn.DataPropertyName = "更新訊息";
            this.更新訊息DataGridViewTextBoxColumn.HeaderText = "更新訊息";
            this.更新訊息DataGridViewTextBoxColumn.Name = "更新訊息DataGridViewTextBoxColumn";
            this.更新訊息DataGridViewTextBoxColumn.Width = 200;
            // 
            // 物品條碼更新資料BindingSource
            // 
            this.物品條碼更新資料BindingSource.DataSource = typeof(WokyTool.物品.物品條碼更新資料);
            // 
            // 物品條碼更新匯入視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 456);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "物品條碼更新匯入視窗";
            this.Text = "物品條碼更新匯入視窗";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.物品條碼更新匯入視窗_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.更新狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品條碼更新資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 樣板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 縮寫DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 目標物品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 條碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 更新狀態BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 更新訊息DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 物品條碼更新資料BindingSource;
    }
}