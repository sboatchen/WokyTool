namespace WokyTool.通用
{
    partial class 通用匯出視窗
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
            this.新增 = new System.Windows.Forms.Button();
            this.屬性 = new System.Windows.Forms.ComboBox();
            this.通用匯出欄位設定資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.名稱 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.檔案格式 = new System.Windows.Forms.ComboBox();
            this.檔案格式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.切檔方式 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.分頁方式 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.載入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快速儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.測試ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.預設檔名 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.屬性DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.通用匯出欄位設定資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.檔案格式BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 新增
            // 
            this.新增.Location = new System.Drawing.Point(13, 150);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(44, 23);
            this.新增.TabIndex = 0;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = true;
            this.新增.Click += new System.EventHandler(this.新增_Click);
            // 
            // 屬性
            // 
            this.屬性.DataSource = this.通用匯出欄位設定資料BindingSource;
            this.屬性.DisplayMember = "名稱";
            this.屬性.FormattingEnabled = true;
            this.屬性.Location = new System.Drawing.Point(228, 151);
            this.屬性.Name = "屬性";
            this.屬性.Size = new System.Drawing.Size(160, 20);
            this.屬性.TabIndex = 1;
            this.屬性.ValueMember = "Self";
            this.屬性.SelectedIndexChanged += new System.EventHandler(this.屬性_SelectedIndexChanged);
            // 
            // 通用匯出欄位設定資料BindingSource
            // 
            this.通用匯出欄位設定資料BindingSource.DataSource = typeof(WokyTool.通用.通用匯出欄位設定資料);
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(66, 150);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(155, 22);
            this.名稱.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "檔案格式";
            // 
            // 檔案格式
            // 
            this.檔案格式.DataSource = this.檔案格式BindingSource;
            this.檔案格式.FormattingEnabled = true;
            this.檔案格式.Location = new System.Drawing.Point(66, 57);
            this.檔案格式.Name = "檔案格式";
            this.檔案格式.Size = new System.Drawing.Size(160, 20);
            this.檔案格式.TabIndex = 5;
            // 
            // 檔案格式BindingSource
            // 
            this.檔案格式BindingSource.DataSource = typeof(WokyTool.通用.列舉.檔案格式);
            // 
            // 切檔方式
            // 
            this.切檔方式.DataSource = this.通用匯出欄位設定資料BindingSource;
            this.切檔方式.DisplayMember = "名稱";
            this.切檔方式.FormattingEnabled = true;
            this.切檔方式.Location = new System.Drawing.Point(66, 83);
            this.切檔方式.Name = "切檔方式";
            this.切檔方式.Size = new System.Drawing.Size(160, 20);
            this.切檔方式.TabIndex = 7;
            this.切檔方式.ValueMember = "屬性";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "切檔方式";
            // 
            // 分頁方式
            // 
            this.分頁方式.DataSource = this.通用匯出欄位設定資料BindingSource;
            this.分頁方式.DisplayMember = "名稱";
            this.分頁方式.FormattingEnabled = true;
            this.分頁方式.Location = new System.Drawing.Point(66, 110);
            this.分頁方式.Name = "分頁方式";
            this.分頁方式.Size = new System.Drawing.Size(160, 20);
            this.分頁方式.TabIndex = 9;
            this.分頁方式.ValueMember = "屬性";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "分頁方式";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.匯出ToolStripMenuItem,
            this.測試ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.載入ToolStripMenuItem,
            this.快速儲存ToolStripMenuItem,
            this.另存新檔ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 載入ToolStripMenuItem
            // 
            this.載入ToolStripMenuItem.Name = "載入ToolStripMenuItem";
            this.載入ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.載入ToolStripMenuItem.Text = "載入";
            this.載入ToolStripMenuItem.Click += new System.EventHandler(this.載入ToolStripMenuItem_Click);
            // 
            // 快速儲存ToolStripMenuItem
            // 
            this.快速儲存ToolStripMenuItem.Name = "快速儲存ToolStripMenuItem";
            this.快速儲存ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.快速儲存ToolStripMenuItem.Text = "快速儲存";
            this.快速儲存ToolStripMenuItem.Click += new System.EventHandler(this.快速儲存ToolStripMenuItem_Click);
            // 
            // 另存新檔ToolStripMenuItem
            // 
            this.另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            this.另存新檔ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.另存新檔ToolStripMenuItem.Text = "另存新檔";
            this.另存新檔ToolStripMenuItem.Click += new System.EventHandler(this.另存新檔ToolStripMenuItem_Click);
            // 
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            this.匯出ToolStripMenuItem.Click += new System.EventHandler(this.匯出ToolStripMenuItem_Click);
            // 
            // 測試ToolStripMenuItem
            // 
            this.測試ToolStripMenuItem.Name = "測試ToolStripMenuItem";
            this.測試ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.測試ToolStripMenuItem.Text = "測試";
            this.測試ToolStripMenuItem.Click += new System.EventHandler(this.測試ToolStripMenuItem_Click);
            // 
            // 預設檔名
            // 
            this.預設檔名.Location = new System.Drawing.Point(65, 30);
            this.預設檔名.Name = "預設檔名";
            this.預設檔名.Size = new System.Drawing.Size(160, 22);
            this.預設檔名.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "預設檔名";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名稱DataGridViewTextBoxColumn,
            this.屬性DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.通用匯出欄位設定資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(364, 216);
            this.dataGridView1.TabIndex = 13;
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            this.名稱DataGridViewTextBoxColumn.Width = 160;
            // 
            // 屬性DataGridViewTextBoxColumn
            // 
            this.屬性DataGridViewTextBoxColumn.DataPropertyName = "屬性";
            this.屬性DataGridViewTextBoxColumn.HeaderText = "屬性";
            this.屬性DataGridViewTextBoxColumn.Name = "屬性DataGridViewTextBoxColumn";
            this.屬性DataGridViewTextBoxColumn.ReadOnly = true;
            this.屬性DataGridViewTextBoxColumn.Width = 160;
            // 
            // 通用匯出視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 405);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.預設檔名);
            this.Controls.Add(this.分頁方式);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.切檔方式);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.檔案格式);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.屬性);
            this.Controls.Add(this.新增);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "通用匯出視窗";
            this.Text = "通用匯出視窗";
            ((System.ComponentModel.ISupportInitialize)(this.通用匯出欄位設定資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.檔案格式BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.ComboBox 屬性;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 檔案格式;
        private System.Windows.Forms.BindingSource 檔案格式BindingSource;
        private System.Windows.Forms.ComboBox 切檔方式;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox 分頁方式;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 載入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快速儲存ToolStripMenuItem;
        private System.Windows.Forms.TextBox 預設檔名;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource 通用匯出欄位設定資料BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 屬性DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 測試ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
    }
}