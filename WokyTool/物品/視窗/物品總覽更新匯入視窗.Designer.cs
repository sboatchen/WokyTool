using WokyTool.通用;
namespace WokyTool.物品
{
    partial class 物品總覽更新匯入視窗
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.更新狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.更新狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.錯誤訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品總覽更新匯入資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.更新狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品總覽更新匯入資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.匯入ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.更新狀態DataGridViewTextBoxColumn,
            this.物品名稱DataGridViewTextBoxColumn,
            this.錯誤訊息DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.物品總覽更新匯入資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(594, 445);
            this.dataGridView1.TabIndex = 1;
            // 
            // 更新狀態DataGridViewTextBoxColumn
            // 
            this.更新狀態DataGridViewTextBoxColumn.DataPropertyName = "更新狀態";
            this.更新狀態DataGridViewTextBoxColumn.DataSource = this.更新狀態BindingSource;
            this.更新狀態DataGridViewTextBoxColumn.HeaderText = "更新狀態";
            this.更新狀態DataGridViewTextBoxColumn.Name = "更新狀態DataGridViewTextBoxColumn";
            this.更新狀態DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.更新狀態DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 更新狀態BindingSource
            // 
            this.更新狀態BindingSource.DataSource = typeof(WokyTool.通用.列舉.更新狀態);
            // 
            // 物品名稱DataGridViewTextBoxColumn
            // 
            this.物品名稱DataGridViewTextBoxColumn.DataPropertyName = "物品名稱";
            this.物品名稱DataGridViewTextBoxColumn.HeaderText = "物品名稱";
            this.物品名稱DataGridViewTextBoxColumn.Name = "物品名稱DataGridViewTextBoxColumn";
            this.物品名稱DataGridViewTextBoxColumn.ReadOnly = true;
            this.物品名稱DataGridViewTextBoxColumn.Width = 300;
            // 
            // 錯誤訊息DataGridViewTextBoxColumn
            // 
            this.錯誤訊息DataGridViewTextBoxColumn.DataPropertyName = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.HeaderText = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.Name = "錯誤訊息DataGridViewTextBoxColumn";
            this.錯誤訊息DataGridViewTextBoxColumn.Width = 150;
            // 
            // 物品總覽更新匯入資料BindingSource
            // 
            this.物品總覽更新匯入資料BindingSource.DataSource = typeof(WokyTool.物品.物品總覽更新匯入資料);
            // 
            // 物品總覽更新匯入視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "物品總覽更新匯入視窗";
            this.Text = "物品總覽更新匯入視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.更新狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品總覽更新匯入資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn 更新狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 更新狀態BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 錯誤訊息DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 物品總覽更新匯入資料BindingSource;
    }
}