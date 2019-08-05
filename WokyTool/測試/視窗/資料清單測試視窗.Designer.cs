namespace WokyTool.測試
{
    partial class 資料清單測試視窗
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.讀寫測試資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.字串 = new System.Windows.Forms.TextBox();
            this.排序 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.排序LB = new System.Windows.Forms.Label();
            this.整數1 = new System.Windows.Forms.NumericUpDown();
            this.整數2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.讀寫測試資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.整數1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.整數2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.讀寫測試資料BindingSource;
            this.comboBox1.DisplayMember = "字串";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Self";
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // 讀寫測試資料BindingSource
            // 
            this.讀寫測試資料BindingSource.DataSource = typeof(WokyTool.測試.讀寫測試資料);
            // 
            // 字串
            // 
            this.字串.Location = new System.Drawing.Point(261, 47);
            this.字串.Name = "字串";
            this.字串.Size = new System.Drawing.Size(121, 25);
            this.字串.TabIndex = 1;
            this.字串.TextChanged += new System.EventHandler(this.字串_TextChanged);
            // 
            // 排序
            // 
            this.排序.FormattingEnabled = true;
            this.排序.Location = new System.Drawing.Point(261, 134);
            this.排序.Name = "排序";
            this.排序.Size = new System.Drawing.Size(121, 23);
            this.排序.TabIndex = 3;
            this.排序.TextChanged += new System.EventHandler(this.排序_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "字串";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "整數";
            // 
            // 排序LB
            // 
            this.排序LB.AutoSize = true;
            this.排序LB.Location = new System.Drawing.Point(214, 137);
            this.排序LB.Name = "排序LB";
            this.排序LB.Size = new System.Drawing.Size(37, 15);
            this.排序LB.TabIndex = 7;
            this.排序LB.Text = "排序";
            // 
            // 整數1
            // 
            this.整數1.Location = new System.Drawing.Point(261, 91);
            this.整數1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.整數1.Name = "整數1";
            this.整數1.Size = new System.Drawing.Size(120, 25);
            this.整數1.TabIndex = 8;
            this.整數1.ValueChanged += new System.EventHandler(this.整數1_ValueChanged);
            // 
            // 整數2
            // 
            this.整數2.Location = new System.Drawing.Point(399, 91);
            this.整數2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.整數2.Name = "整數2";
            this.整數2.Size = new System.Drawing.Size(120, 25);
            this.整數2.TabIndex = 9;
            this.整數2.ValueChanged += new System.EventHandler(this.整數2_ValueChanged);
            // 
            // 資料選擇測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 455);
            this.Controls.Add(this.整數2);
            this.Controls.Add(this.整數1);
            this.Controls.Add(this.排序LB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.排序);
            this.Controls.Add(this.字串);
            this.Controls.Add(this.comboBox1);
            this.Name = "資料選擇測試視窗";
            this.Text = "資料選擇測試視窗";
            ((System.ComponentModel.ISupportInitialize)(this.讀寫測試資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.整數1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.整數2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource 讀寫測試資料BindingSource;
        private System.Windows.Forms.TextBox 字串;
        private System.Windows.Forms.ComboBox 排序;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 排序LB;
        private System.Windows.Forms.NumericUpDown 整數1;
        private System.Windows.Forms.NumericUpDown 整數2;
    }
}