using WokyTool.單品;
using WokyTool.通用;
namespace WokyTool.寄庫
{
    partial class 寄庫詳細視窗
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
            this.商品 = new System.Windows.Forms.TextBox();
            this.公司 = new System.Windows.Forms.TextBox();
            this.客戶 = new System.Windows.Forms.TextBox();
            this.處理者 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.入庫單號 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.處理時間 = new WokyTool.通用.MyDateTimePicker();
            this.頁索引元件 = new WokyTool.通用.新版頁索引元件();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.成本 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.入庫時間 = new WokyTool.通用.MyDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).BeginInit();
            this.SuspendLayout();
            // 
            // 商品
            // 
            this.商品.Location = new System.Drawing.Point(58, 80);
            this.商品.Name = "商品";
            this.商品.ReadOnly = true;
            this.商品.Size = new System.Drawing.Size(400, 22);
            this.商品.TabIndex = 86;
            // 
            // 公司
            // 
            this.公司.Location = new System.Drawing.Point(58, 53);
            this.公司.Name = "公司";
            this.公司.ReadOnly = true;
            this.公司.Size = new System.Drawing.Size(165, 22);
            this.公司.TabIndex = 85;
            // 
            // 客戶
            // 
            this.客戶.Location = new System.Drawing.Point(293, 53);
            this.客戶.Name = "客戶";
            this.客戶.ReadOnly = true;
            this.客戶.Size = new System.Drawing.Size(165, 22);
            this.客戶.TabIndex = 84;
            // 
            // 處理者
            // 
            this.處理者.Location = new System.Drawing.Point(293, 12);
            this.處理者.Name = "處理者";
            this.處理者.ReadOnly = true;
            this.處理者.Size = new System.Drawing.Size(165, 22);
            this.處理者.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 82;
            this.label2.Text = "處理者";
            // 
            // 入庫單號
            // 
            this.入庫單號.Location = new System.Drawing.Point(58, 150);
            this.入庫單號.Name = "入庫單號";
            this.入庫單號.ReadOnly = true;
            this.入庫單號.Size = new System.Drawing.Size(165, 22);
            this.入庫單號.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 80;
            this.label9.Text = "入庫單號";
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(58, 178);
            this.備註.Name = "備註";
            this.備註.ReadOnly = true;
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 77;
            this.label17.Text = "備註";
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(58, 108);
            this.數量.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.數量.Name = "數量";
            this.數量.ReadOnly = true;
            this.數量.Size = new System.Drawing.Size(165, 22);
            this.數量.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 64;
            this.label5.Text = "數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "商品";
            // 
            // 處理時間
            // 
            this.處理時間.CustomFormat = "yyyy-MM-dd HH:mm";
            this.處理時間.Enabled = false;
            this.處理時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.處理時間.Location = new System.Drawing.Point(58, 12);
            this.處理時間.Name = "處理時間";
            this.處理時間.Size = new System.Drawing.Size(165, 22);
            this.處理時間.TabIndex = 58;
            this.處理時間.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 752);
            // 
            // 頁索引元件
            // 
            this.頁索引元件.Location = new System.Drawing.Point(128, 213);
            this.頁索引元件.Name = "頁索引元件";
            this.頁索引元件.Size = new System.Drawing.Size(234, 34);
            this.頁索引元件.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "處理時間";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "公司";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客戶";
            // 
            // 成本
            // 
            this.成本.DecimalPlaces = 3;
            this.成本.Location = new System.Drawing.Point(293, 109);
            this.成本.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.成本.Name = "成本";
            this.成本.ReadOnly = true;
            this.成本.Size = new System.Drawing.Size(165, 22);
            this.成本.TabIndex = 88;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(248, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 87;
            this.label13.Text = "成本";
            // 
            // 入庫時間
            // 
            this.入庫時間.CustomFormat = "yyyy-MM-dd HH:mm";
            this.入庫時間.Enabled = false;
            this.入庫時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.入庫時間.Location = new System.Drawing.Point(293, 150);
            this.入庫時間.Name = "入庫時間";
            this.入庫時間.Size = new System.Drawing.Size(165, 22);
            this.入庫時間.TabIndex = 90;
            this.入庫時間.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 752);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 89;
            this.label6.Text = "入庫時間";
            // 
            // 寄庫詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 254);
            this.Controls.Add(this.入庫時間);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.成本);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.商品);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.客戶);
            this.Controls.Add(this.處理者);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.入庫單號);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.處理時間);
            this.Controls.Add(this.頁索引元件);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "寄庫詳細視窗";
            this.Text = "寄庫詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private 通用.新版頁索引元件 頁索引元件;
        private MyDateTimePicker 處理時間;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox 入庫單號;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox 處理者;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 客戶;
        private System.Windows.Forms.TextBox 公司;
        private System.Windows.Forms.TextBox 商品;
        private System.Windows.Forms.NumericUpDown 成本;
        private System.Windows.Forms.Label label13;
        private MyDateTimePicker 入庫時間;
        private System.Windows.Forms.Label label6;
    }
}