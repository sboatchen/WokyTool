namespace WokyTool.月結帳
{
    partial class 月結帳支出總覽視窗
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.傳票號碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.供應商DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.供應商資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.費用DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月結帳支出資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.供應商資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.月結帳支出資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.匯入ToolStripMenuItem,
            this.匯出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.傳票號碼DataGridViewTextBoxColumn,
            this.供應商DataGridViewTextBoxColumn,
            this.費用DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.月結帳支出資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 472);
            this.dataGridView1.TabIndex = 1;
            // 
            // 匯入ToolStripMenuItem
            // 
            this.匯入ToolStripMenuItem.Name = "匯入ToolStripMenuItem";
            this.匯入ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯入ToolStripMenuItem.Text = "匯入";
            this.匯入ToolStripMenuItem.Click += new System.EventHandler(this.匯入ToolStripMenuItem_Click);
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            // 
            // 傳票號碼DataGridViewTextBoxColumn
            // 
            this.傳票號碼DataGridViewTextBoxColumn.DataPropertyName = "傳票號碼";
            this.傳票號碼DataGridViewTextBoxColumn.HeaderText = "傳票號碼";
            this.傳票號碼DataGridViewTextBoxColumn.Name = "傳票號碼DataGridViewTextBoxColumn";
            // 
            // 供應商DataGridViewTextBoxColumn
            // 
            this.供應商DataGridViewTextBoxColumn.DataPropertyName = "供應商";
            this.供應商DataGridViewTextBoxColumn.DataSource = this.供應商資料BindingSource;
            this.供應商DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.供應商DataGridViewTextBoxColumn.HeaderText = "供應商";
            this.供應商DataGridViewTextBoxColumn.Name = "供應商DataGridViewTextBoxColumn";
            this.供應商DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.供應商DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.供應商DataGridViewTextBoxColumn.ValueMember = "Self";
            this.供應商DataGridViewTextBoxColumn.Width = 200;
            // 
            // 供應商資料BindingSource
            // 
            this.供應商資料BindingSource.DataSource = typeof(WokyTool.單品.供應商資料);
            // 
            // 費用DataGridViewTextBoxColumn
            // 
            this.費用DataGridViewTextBoxColumn.DataPropertyName = "費用";
            this.費用DataGridViewTextBoxColumn.HeaderText = "費用";
            this.費用DataGridViewTextBoxColumn.Name = "費用DataGridViewTextBoxColumn";
            // 
            // 月結帳支出資料BindingSource
            // 
            this.月結帳支出資料BindingSource.DataSource = typeof(WokyTool.月結帳.月結帳支出資料);
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            this.匯出ToolStripMenuItem.Click += new System.EventHandler(this.匯出ToolStripMenuItem_Click);
            // 
            // 月結帳支出總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "月結帳支出總覽視窗";
            this.Text = "月結帳支出總覽視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.供應商資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.月結帳支出資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 傳票號碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 供應商DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 供應商資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 費用DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 月結帳支出資料BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
    }
}