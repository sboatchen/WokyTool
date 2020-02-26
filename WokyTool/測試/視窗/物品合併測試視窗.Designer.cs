namespace WokyTool.測試
{
    partial class 單品合併測試視窗
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
            this.button1 = new System.Windows.Forms.Button();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.結果 = new System.Windows.Forms.TextBox();
            this.解構 = new System.Windows.Forms.Button();
            this.單品 = new WokyTool.單品.單品選取元件();
            this.dataGridView1 = new WokyTool.通用.MyDataGridView();
            this.單品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品組成資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品組成資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(669, 40);
            this.數量.Margin = new System.Windows.Forms.Padding(4);
            this.數量.Name = "數量";
            this.數量.Size = new System.Drawing.Size(93, 25);
            this.數量.TabIndex = 2;
            // 
            // 結果
            // 
            this.結果.Location = new System.Drawing.Point(17, 87);
            this.結果.Margin = new System.Windows.Forms.Padding(4);
            this.結果.Name = "結果";
            this.結果.Size = new System.Drawing.Size(745, 25);
            this.結果.TabIndex = 3;
            // 
            // 解構
            // 
            this.解構.Location = new System.Drawing.Point(17, 137);
            this.解構.Margin = new System.Windows.Forms.Padding(4);
            this.解構.Name = "解構";
            this.解構.Size = new System.Drawing.Size(65, 29);
            this.解構.TabIndex = 4;
            this.解構.Text = "解構";
            this.解構.UseVisualStyleBackColor = true;
            this.解構.Click += new System.EventHandler(this.解構_Click);
            // 
            // 單品
            // 
            this.單品.Location = new System.Drawing.Point(91, 40);
            this.單品.Margin = new System.Windows.Forms.Padding(5);
            this.單品.Name = "單品";
            this.單品.ReadOnly = false;
            this.單品.SelectedItem = null;
            this.單品.Size = new System.Drawing.Size(569, 29);
            this.單品.TabIndex = 0;
            this.單品.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.單品名稱DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.商品組成資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 197);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 310);
            this.dataGridView1.TabIndex = 100;
            // 
            // 單品名稱DataGridViewTextBoxColumn
            // 
            this.單品名稱DataGridViewTextBoxColumn.DataPropertyName = "單品名稱";
            this.單品名稱DataGridViewTextBoxColumn.HeaderText = "單品";
            this.單品名稱DataGridViewTextBoxColumn.Name = "單品名稱DataGridViewTextBoxColumn";
            this.單品名稱DataGridViewTextBoxColumn.ReadOnly = true;
            this.單品名稱DataGridViewTextBoxColumn.Width = 500;
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 商品組成資料BindingSource
            // 
            this.商品組成資料BindingSource.DataSource = typeof(WokyTool.商品.商品組成資料);
            // 
            // 單品合併測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.解構);
            this.Controls.Add(this.結果);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.單品);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "單品合併測試視窗";
            this.Text = "單品合併測試視窗";
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品組成資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 單品.單品選取元件 單品;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.TextBox 結果;
        private System.Windows.Forms.Button 解構;
        private 通用.MyDataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 商品組成資料BindingSource;
    }
}