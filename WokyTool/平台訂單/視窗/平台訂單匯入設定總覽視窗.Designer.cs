using WokyTool.通用;
namespace WokyTool.平台訂單
{
    partial class 平台訂單匯入設定總覽視窗
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
            this.檔案格式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.公司資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客戶資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.平台訂單匯入設定資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.複製ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.格式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.公司DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.客戶DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.開始位置DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.結束位置DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.標頭位置DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.檔案格式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.平台訂單匯入設定資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.格式DataGridViewTextBoxColumn,
            this.公司DataGridViewTextBoxColumn,
            this.客戶DataGridViewTextBoxColumn,
            this.開始位置DataGridViewTextBoxColumn,
            this.結束位置DataGridViewTextBoxColumn,
            this.標頭位置DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.平台訂單匯入設定資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // 檔案格式BindingSource
            // 
            this.檔案格式BindingSource.DataSource = typeof(WokyTool.通用.列舉.檔案格式);
            // 
            // 公司資料BindingSource
            // 
            this.公司資料BindingSource.DataSource = typeof(WokyTool.公司.公司資料);
            // 
            // 客戶資料BindingSource
            // 
            this.客戶資料BindingSource.DataSource = typeof(WokyTool.客戶.客戶資料);
            // 
            // 平台訂單匯入設定資料BindingSource
            // 
            this.平台訂單匯入設定資料BindingSource.DataSource = typeof(WokyTool.平台訂單.平台訂單匯入設定資料);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.複製ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 複製ToolStripMenuItem
            // 
            this.複製ToolStripMenuItem.Name = "複製ToolStripMenuItem";
            this.複製ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.複製ToolStripMenuItem.Text = "複製";
            this.複製ToolStripMenuItem.Click += new System.EventHandler(this.複製ToolStripMenuItem_Click);
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            this.名稱DataGridViewTextBoxColumn.Width = 150;
            // 
            // 格式DataGridViewTextBoxColumn
            // 
            this.格式DataGridViewTextBoxColumn.DataPropertyName = "格式";
            this.格式DataGridViewTextBoxColumn.DataSource = this.檔案格式BindingSource;
            this.格式DataGridViewTextBoxColumn.HeaderText = "格式";
            this.格式DataGridViewTextBoxColumn.Name = "格式DataGridViewTextBoxColumn";
            this.格式DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.格式DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 公司DataGridViewTextBoxColumn
            // 
            this.公司DataGridViewTextBoxColumn.DataPropertyName = "公司";
            this.公司DataGridViewTextBoxColumn.DataSource = this.公司資料BindingSource;
            this.公司DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.公司DataGridViewTextBoxColumn.HeaderText = "公司";
            this.公司DataGridViewTextBoxColumn.Name = "公司DataGridViewTextBoxColumn";
            this.公司DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.公司DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.公司DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 客戶DataGridViewTextBoxColumn
            // 
            this.客戶DataGridViewTextBoxColumn.DataPropertyName = "客戶";
            this.客戶DataGridViewTextBoxColumn.DataSource = this.客戶資料BindingSource;
            this.客戶DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.客戶DataGridViewTextBoxColumn.HeaderText = "客戶";
            this.客戶DataGridViewTextBoxColumn.Name = "客戶DataGridViewTextBoxColumn";
            this.客戶DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.客戶DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.客戶DataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // 開始位置DataGridViewTextBoxColumn
            // 
            this.開始位置DataGridViewTextBoxColumn.DataPropertyName = "開始位置";
            this.開始位置DataGridViewTextBoxColumn.HeaderText = "開始位置";
            this.開始位置DataGridViewTextBoxColumn.Name = "開始位置DataGridViewTextBoxColumn";
            // 
            // 結束位置DataGridViewTextBoxColumn
            // 
            this.結束位置DataGridViewTextBoxColumn.DataPropertyName = "結束位置";
            this.結束位置DataGridViewTextBoxColumn.HeaderText = "結束位置";
            this.結束位置DataGridViewTextBoxColumn.Name = "結束位置DataGridViewTextBoxColumn";
            // 
            // 標頭位置DataGridViewTextBoxColumn
            // 
            this.標頭位置DataGridViewTextBoxColumn.DataPropertyName = "標頭位置";
            this.標頭位置DataGridViewTextBoxColumn.HeaderText = "標頭位置";
            this.標頭位置DataGridViewTextBoxColumn.Name = "標頭位置DataGridViewTextBoxColumn";
            this.標頭位置DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 平台訂單匯入設定總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "平台訂單匯入設定總覽視窗";
            this.Text = "平台訂單匯入設定總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.檔案格式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.平台訂單匯入設定資料BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 平台訂單匯入設定資料BindingSource;
        private System.Windows.Forms.BindingSource 公司資料BindingSource;
        private System.Windows.Forms.BindingSource 客戶資料BindingSource;
        private System.Windows.Forms.BindingSource 檔案格式BindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 複製ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 格式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 公司DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 客戶DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 開始位置DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 結束位置DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 標頭位置DataGridViewTextBoxColumn;
    }
}