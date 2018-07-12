namespace WokyTool.商品
{
    partial class 商品小類總覽視窗
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
            this.商品小類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品小類資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.商品小類資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(295, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // 商品小類資料BindingSource
            // 
            this.商品小類資料BindingSource.DataSource = typeof(WokyTool.商品.商品小類資料);
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            this.名稱DataGridViewTextBoxColumn.Width = 150;
            // 
            // 商品小類總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 321);
            this.Controls.Add(this.dataGridView1);
            this.Name = "商品小類總覽視窗";
            this.Text = "商品小類總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品小類資料BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 商品小類資料BindingSource;
    }
}