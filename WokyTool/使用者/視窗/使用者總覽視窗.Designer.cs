namespace WokyTool.使用者
{
    partial class 使用者總覽視窗
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
            this.使用者資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.帳號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顯示密碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改基本資料DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.修改設定資料DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.匯入訂單DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.匯入進貨DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.匯入月結帳DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.使用者資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.帳號DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.顯示密碼DataGridViewTextBoxColumn,
            this.修改基本資料DataGridViewCheckBoxColumn,
            this.修改設定資料DataGridViewCheckBoxColumn,
            this.匯入訂單DataGridViewCheckBoxColumn,
            this.匯入進貨DataGridViewCheckBoxColumn,
            this.匯入月結帳DataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.使用者資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(945, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // 使用者資料BindingSource
            // 
            this.使用者資料BindingSource.DataSource = typeof(WokyTool.使用者.使用者資料);
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 帳號DataGridViewTextBoxColumn
            // 
            this.帳號DataGridViewTextBoxColumn.DataPropertyName = "帳號";
            this.帳號DataGridViewTextBoxColumn.HeaderText = "帳號";
            this.帳號DataGridViewTextBoxColumn.Name = "帳號DataGridViewTextBoxColumn";
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            // 
            // 顯示密碼DataGridViewTextBoxColumn
            // 
            this.顯示密碼DataGridViewTextBoxColumn.DataPropertyName = "顯示密碼";
            this.顯示密碼DataGridViewTextBoxColumn.HeaderText = "密碼";
            this.顯示密碼DataGridViewTextBoxColumn.Name = "顯示密碼DataGridViewTextBoxColumn";
            this.顯示密碼DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 修改基本資料DataGridViewCheckBoxColumn
            // 
            this.修改基本資料DataGridViewCheckBoxColumn.DataPropertyName = "修改基本資料";
            this.修改基本資料DataGridViewCheckBoxColumn.HeaderText = "修改基本資料";
            this.修改基本資料DataGridViewCheckBoxColumn.Name = "修改基本資料DataGridViewCheckBoxColumn";
            // 
            // 修改設定資料DataGridViewCheckBoxColumn
            // 
            this.修改設定資料DataGridViewCheckBoxColumn.DataPropertyName = "修改設定資料";
            this.修改設定資料DataGridViewCheckBoxColumn.HeaderText = "修改設定資料";
            this.修改設定資料DataGridViewCheckBoxColumn.Name = "修改設定資料DataGridViewCheckBoxColumn";
            // 
            // 匯入訂單DataGridViewCheckBoxColumn
            // 
            this.匯入訂單DataGridViewCheckBoxColumn.DataPropertyName = "匯入訂單";
            this.匯入訂單DataGridViewCheckBoxColumn.HeaderText = "匯入訂單";
            this.匯入訂單DataGridViewCheckBoxColumn.Name = "匯入訂單DataGridViewCheckBoxColumn";
            // 
            // 匯入進貨DataGridViewCheckBoxColumn
            // 
            this.匯入進貨DataGridViewCheckBoxColumn.DataPropertyName = "匯入進貨";
            this.匯入進貨DataGridViewCheckBoxColumn.HeaderText = "匯入進貨";
            this.匯入進貨DataGridViewCheckBoxColumn.Name = "匯入進貨DataGridViewCheckBoxColumn";
            // 
            // 匯入月結帳DataGridViewCheckBoxColumn
            // 
            this.匯入月結帳DataGridViewCheckBoxColumn.DataPropertyName = "匯入月結帳";
            this.匯入月結帳DataGridViewCheckBoxColumn.HeaderText = "匯入月結帳";
            this.匯入月結帳DataGridViewCheckBoxColumn.Name = "匯入月結帳DataGridViewCheckBoxColumn";
            // 
            // 使用者總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 326);
            this.Controls.Add(this.dataGridView1);
            this.Name = "使用者總覽視窗";
            this.Text = "使用者總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.使用者資料BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 使用者資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 帳號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顯示密碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 修改基本資料DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 修改設定資料DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 匯入訂單DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 匯入進貨DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 匯入月結帳DataGridViewCheckBoxColumn;
    }
}