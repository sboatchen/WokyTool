namespace WokyTool.月結帳
{
    partial class 月結帳匯入視窗
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
            this.清單 = new System.Windows.Forms.ComboBox();
            this.檔案匯入設定資料月結帳BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.匯入 = new System.Windows.Forms.Button();
            this.資料呈現 = new System.Windows.Forms.DataGridView();
            this.商品識別 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.含稅單價 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月結帳資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.儲存 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.檔案匯入設定資料月結帳BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.資料呈現)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.月結帳資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 清單
            // 
            this.清單.DataSource = this.檔案匯入設定資料月結帳BindingSource;
            this.清單.DisplayMember = "名稱";
            this.清單.FormattingEnabled = true;
            this.清單.Location = new System.Drawing.Point(13, 13);
            this.清單.Name = "清單";
            this.清單.Size = new System.Drawing.Size(163, 20);
            this.清單.TabIndex = 0;
            this.清單.SelectedIndexChanged += new System.EventHandler(this.清單_SelectedIndexChanged);
            // 
            // 檔案匯入設定資料月結帳BindingSource
            // 
            this.檔案匯入設定資料月結帳BindingSource.DataSource = typeof(WokyTool.月結帳.月結帳匯入設定資料);
            // 
            // 匯入
            // 
            this.匯入.Location = new System.Drawing.Point(182, 10);
            this.匯入.Name = "匯入";
            this.匯入.Size = new System.Drawing.Size(75, 23);
            this.匯入.TabIndex = 1;
            this.匯入.Text = "匯入";
            this.匯入.UseVisualStyleBackColor = true;
            this.匯入.Click += new System.EventHandler(this.匯入_Click);
            // 
            // 資料呈現
            // 
            this.資料呈現.AutoGenerateColumns = false;
            this.資料呈現.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.資料呈現.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.商品識別,
            this.商品DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.單價DataGridViewTextBoxColumn,
            this.含稅單價});
            this.資料呈現.DataSource = this.月結帳資料BindingSource;
            this.資料呈現.Location = new System.Drawing.Point(13, 60);
            this.資料呈現.Name = "資料呈現";
            this.資料呈現.RowTemplate.Height = 24;
            this.資料呈現.Size = new System.Drawing.Size(748, 386);
            this.資料呈現.TabIndex = 2;
            // 
            // 商品識別
            // 
            this.商品識別.DataPropertyName = "商品識別";
            this.商品識別.HeaderText = "商品識別";
            this.商品識別.Name = "商品識別";
            // 
            // 商品DataGridViewTextBoxColumn
            // 
            this.商品DataGridViewTextBoxColumn.DataPropertyName = "商品編號";
            this.商品DataGridViewTextBoxColumn.DataSource = this.商品資料BindingSource;
            this.商品DataGridViewTextBoxColumn.DisplayMember = "名稱";
            this.商品DataGridViewTextBoxColumn.HeaderText = "商品";
            this.商品DataGridViewTextBoxColumn.Name = "商品DataGridViewTextBoxColumn";
            this.商品DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.商品DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.商品DataGridViewTextBoxColumn.ValueMember = "編號";
            this.商品DataGridViewTextBoxColumn.Width = 300;
            // 
            // 商品資料BindingSource
            // 
            this.商品資料BindingSource.DataSource = typeof(WokyTool.Data.商品資料);
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 單價DataGridViewTextBoxColumn
            // 
            this.單價DataGridViewTextBoxColumn.DataPropertyName = "單價";
            this.單價DataGridViewTextBoxColumn.HeaderText = "單價";
            this.單價DataGridViewTextBoxColumn.Name = "單價DataGridViewTextBoxColumn";
            // 
            // 含稅單價
            // 
            this.含稅單價.DataPropertyName = "含稅單價";
            this.含稅單價.HeaderText = "含稅單價";
            this.含稅單價.Name = "含稅單價";
            // 
            // 月結帳資料BindingSource
            // 
            this.月結帳資料BindingSource.DataSource = typeof(WokyTool.月結帳.月結帳資料);
            // 
            // 儲存
            // 
            this.儲存.Location = new System.Drawing.Point(328, 458);
            this.儲存.Name = "儲存";
            this.儲存.Size = new System.Drawing.Size(75, 23);
            this.儲存.TabIndex = 3;
            this.儲存.Text = "儲存";
            this.儲存.UseVisualStyleBackColor = true;
            this.儲存.Click += new System.EventHandler(this.儲存_Click);
            // 
            // 月結帳匯入視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 493);
            this.Controls.Add(this.儲存);
            this.Controls.Add(this.資料呈現);
            this.Controls.Add(this.匯入);
            this.Controls.Add(this.清單);
            this.Name = "月結帳匯入視窗";
            this.Text = "月結帳匯入視窗";
            ((System.ComponentModel.ISupportInitialize)(this.檔案匯入設定資料月結帳BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.資料呈現)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.月結帳資料BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox 清單;
        private System.Windows.Forms.BindingSource 檔案匯入設定資料月結帳BindingSource;
        private System.Windows.Forms.Button 匯入;
        private System.Windows.Forms.DataGridView 資料呈現;
        private System.Windows.Forms.BindingSource 月結帳資料BindingSource;
        private System.Windows.Forms.BindingSource 商品資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品識別;
        private System.Windows.Forms.DataGridViewComboBoxColumn 商品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 含稅單價;
        private System.Windows.Forms.Button 儲存;
    }
}