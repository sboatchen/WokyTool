namespace WokyTool
{
    partial class 編碼總覽視窗
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
            this.類型DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.下個值DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.編碼資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.編碼資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.類型DataGridViewTextBoxColumn,
            this.下個值DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.編碼資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(241, 313);
            this.dataGridView1.TabIndex = 1;
            // 
            // 類型DataGridViewTextBoxColumn
            // 
            this.類型DataGridViewTextBoxColumn.DataPropertyName = "類型";
            this.類型DataGridViewTextBoxColumn.HeaderText = "類型";
            this.類型DataGridViewTextBoxColumn.Name = "類型DataGridViewTextBoxColumn";
            this.類型DataGridViewTextBoxColumn.Width = 99;
            // 
            // 下個值DataGridViewTextBoxColumn
            // 
            this.下個值DataGridViewTextBoxColumn.DataPropertyName = "下個值";
            this.下個值DataGridViewTextBoxColumn.HeaderText = "下個值";
            this.下個值DataGridViewTextBoxColumn.Name = "下個值DataGridViewTextBoxColumn";
            this.下個值DataGridViewTextBoxColumn.Width = 98;
            // 
            // 編碼資料BindingSource
            // 
            this.編碼資料BindingSource.DataSource = typeof(WokyTool.Data.編碼資料);
            // 
            // 編碼總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 313);
            this.Controls.Add(this.dataGridView1);
            this.Name = "編碼總覽視窗";
            this.Text = "編碼總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.編碼資料BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 類型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 下個值DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 編碼資料BindingSource;
    }
}