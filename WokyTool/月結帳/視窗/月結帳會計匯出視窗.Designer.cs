namespace WokyTool.月結帳
{
    partial class 月結帳會計匯出視窗
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
            this.月結帳會計資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.客戶DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.營業額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.佣金DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作帳應收DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.實收DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.應收款日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.本期欠收DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.前期欠收DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.前期實收DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.利潤DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.進貨成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.毛利率DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.業務DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.錯誤訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.月結帳會計資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.客戶DataGridViewTextBoxColumn,
            this.營業額DataGridViewTextBoxColumn,
            this.佣金DataGridViewTextBoxColumn,
            this.作帳應收DataGridViewTextBoxColumn,
            this.實收DataGridViewTextBoxColumn,
            this.應收款日期DataGridViewTextBoxColumn,
            this.本期欠收DataGridViewTextBoxColumn,
            this.前期欠收DataGridViewTextBoxColumn,
            this.前期實收DataGridViewTextBoxColumn,
            this.利潤DataGridViewTextBoxColumn,
            this.進貨成本DataGridViewTextBoxColumn,
            this.毛利率DataGridViewTextBoxColumn,
            this.業務DataGridViewTextBoxColumn,
            this.錯誤訊息DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.月結帳會計資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1344, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // 月結帳會計資料BindingSource
            // 
            this.月結帳會計資料BindingSource.DataSource = typeof(WokyTool.月結帳.月結帳會計資料);
            // 
            // 客戶DataGridViewTextBoxColumn
            // 
            this.客戶DataGridViewTextBoxColumn.DataPropertyName = "客戶";
            this.客戶DataGridViewTextBoxColumn.HeaderText = "客戶";
            this.客戶DataGridViewTextBoxColumn.Name = "客戶DataGridViewTextBoxColumn";
            // 
            // 營業額DataGridViewTextBoxColumn
            // 
            this.營業額DataGridViewTextBoxColumn.DataPropertyName = "營業額";
            this.營業額DataGridViewTextBoxColumn.HeaderText = "營業額";
            this.營業額DataGridViewTextBoxColumn.Name = "營業額DataGridViewTextBoxColumn";
            // 
            // 佣金DataGridViewTextBoxColumn
            // 
            this.佣金DataGridViewTextBoxColumn.DataPropertyName = "佣金";
            this.佣金DataGridViewTextBoxColumn.HeaderText = "佣金";
            this.佣金DataGridViewTextBoxColumn.Name = "佣金DataGridViewTextBoxColumn";
            // 
            // 作帳應收DataGridViewTextBoxColumn
            // 
            this.作帳應收DataGridViewTextBoxColumn.DataPropertyName = "作帳應收";
            this.作帳應收DataGridViewTextBoxColumn.HeaderText = "作帳應收";
            this.作帳應收DataGridViewTextBoxColumn.Name = "作帳應收DataGridViewTextBoxColumn";
            // 
            // 實收DataGridViewTextBoxColumn
            // 
            this.實收DataGridViewTextBoxColumn.DataPropertyName = "實收";
            this.實收DataGridViewTextBoxColumn.HeaderText = "實收";
            this.實收DataGridViewTextBoxColumn.Name = "實收DataGridViewTextBoxColumn";
            // 
            // 應收款日期DataGridViewTextBoxColumn
            // 
            this.應收款日期DataGridViewTextBoxColumn.DataPropertyName = "應收款日期";
            this.應收款日期DataGridViewTextBoxColumn.HeaderText = "應收款日期";
            this.應收款日期DataGridViewTextBoxColumn.Name = "應收款日期DataGridViewTextBoxColumn";
            // 
            // 本期欠收DataGridViewTextBoxColumn
            // 
            this.本期欠收DataGridViewTextBoxColumn.DataPropertyName = "本期欠收";
            this.本期欠收DataGridViewTextBoxColumn.HeaderText = "本期欠收";
            this.本期欠收DataGridViewTextBoxColumn.Name = "本期欠收DataGridViewTextBoxColumn";
            // 
            // 前期欠收DataGridViewTextBoxColumn
            // 
            this.前期欠收DataGridViewTextBoxColumn.DataPropertyName = "前期欠收";
            this.前期欠收DataGridViewTextBoxColumn.HeaderText = "前期欠收";
            this.前期欠收DataGridViewTextBoxColumn.Name = "前期欠收DataGridViewTextBoxColumn";
            // 
            // 前期實收DataGridViewTextBoxColumn
            // 
            this.前期實收DataGridViewTextBoxColumn.DataPropertyName = "前期實收";
            this.前期實收DataGridViewTextBoxColumn.HeaderText = "前期實收";
            this.前期實收DataGridViewTextBoxColumn.Name = "前期實收DataGridViewTextBoxColumn";
            // 
            // 利潤DataGridViewTextBoxColumn
            // 
            this.利潤DataGridViewTextBoxColumn.DataPropertyName = "利潤";
            this.利潤DataGridViewTextBoxColumn.HeaderText = "利潤";
            this.利潤DataGridViewTextBoxColumn.Name = "利潤DataGridViewTextBoxColumn";
            this.利潤DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 進貨成本DataGridViewTextBoxColumn
            // 
            this.進貨成本DataGridViewTextBoxColumn.DataPropertyName = "進貨成本";
            this.進貨成本DataGridViewTextBoxColumn.HeaderText = "進貨成本";
            this.進貨成本DataGridViewTextBoxColumn.Name = "進貨成本DataGridViewTextBoxColumn";
            // 
            // 毛利率DataGridViewTextBoxColumn
            // 
            this.毛利率DataGridViewTextBoxColumn.DataPropertyName = "毛利率";
            this.毛利率DataGridViewTextBoxColumn.HeaderText = "毛利率";
            this.毛利率DataGridViewTextBoxColumn.Name = "毛利率DataGridViewTextBoxColumn";
            this.毛利率DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 業務DataGridViewTextBoxColumn
            // 
            this.業務DataGridViewTextBoxColumn.DataPropertyName = "業務";
            this.業務DataGridViewTextBoxColumn.HeaderText = "業務";
            this.業務DataGridViewTextBoxColumn.Name = "業務DataGridViewTextBoxColumn";
            // 
            // 錯誤訊息DataGridViewTextBoxColumn
            // 
            this.錯誤訊息DataGridViewTextBoxColumn.DataPropertyName = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.HeaderText = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.Name = "錯誤訊息DataGridViewTextBoxColumn";
            // 
            // 月結帳會計匯出視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 496);
            this.Controls.Add(this.dataGridView1);
            this.Name = "月結帳會計匯出視窗";
            this.Text = "月結帳會計匯出視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.月結帳會計資料BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 雜支DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 月結帳會計資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客戶DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 營業額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 佣金DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作帳應收DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 實收DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 應收款日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 本期欠收DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 前期欠收DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 前期實收DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 利潤DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 進貨成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 毛利率DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 業務DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 錯誤訊息DataGridViewTextBoxColumn;
    }
}