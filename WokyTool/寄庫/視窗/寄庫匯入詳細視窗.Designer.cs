using WokyTool.物品;
using WokyTool.通用;
namespace WokyTool.寄庫
{
    partial class 寄庫匯入詳細視窗
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
            this.錯誤訊息 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.入庫單號 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.商品 = new WokyTool.商品.商品選取元件();
            this.label4 = new System.Windows.Forms.Label();
            this.客戶 = new WokyTool.客戶.客戶選取元件();
            this.公司 = new WokyTool.公司.公司選取元件();
            this.新版頁索引元件1 = new WokyTool.通用.新版頁索引元件();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.入庫時間 = new WokyTool.通用.MyDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            this.SuspendLayout();
            // 
            // 錯誤訊息
            // 
            this.錯誤訊息.Location = new System.Drawing.Point(58, 179);
            this.錯誤訊息.Name = "錯誤訊息";
            this.錯誤訊息.ReadOnly = true;
            this.錯誤訊息.Size = new System.Drawing.Size(400, 22);
            this.錯誤訊息.TabIndex = 118;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 117;
            this.label15.Text = "錯誤訊息";
            // 
            // 入庫單號
            // 
            this.入庫單號.Location = new System.Drawing.Point(58, 107);
            this.入庫單號.Name = "入庫單號";
            this.入庫單號.Size = new System.Drawing.Size(165, 22);
            this.入庫單號.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 80;
            this.label9.Text = "入庫單號";
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(58, 135);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 77;
            this.label17.Text = "備註";
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(58, 64);
            this.數量.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.數量.Name = "數量";
            this.數量.Size = new System.Drawing.Size(165, 22);
            this.數量.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 64;
            this.label5.Text = "數量";
            // 
            // 商品
            // 
            this.商品.Location = new System.Drawing.Point(58, 35);
            this.商品.Name = "商品";
            this.商品.ReadOnly = false;
            this.商品.SelectedItem = null;
            this.商品.Size = new System.Drawing.Size(426, 25);
            this.商品.TabIndex = 63;
            this.商品.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "商品";
            // 
            // 客戶
            // 
            this.客戶.Location = new System.Drawing.Point(293, 9);
            this.客戶.Name = "客戶";
            this.客戶.ReadOnly = true;
            this.客戶.SelectedItem = null;
            this.客戶.Size = new System.Drawing.Size(186, 25);
            this.客戶.TabIndex = 61;
            this.客戶.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 公司
            // 
            this.公司.Location = new System.Drawing.Point(58, 9);
            this.公司.Name = "公司";
            this.公司.ReadOnly = true;
            this.公司.SelectedItem = null;
            this.公司.Size = new System.Drawing.Size(173, 25);
            this.公司.TabIndex = 60;
            this.公司.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 新版頁索引元件1
            // 
            this.新版頁索引元件1.Location = new System.Drawing.Point(128, 208);
            this.新版頁索引元件1.Name = "新版頁索引元件1";
            this.新版頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.新版頁索引元件1.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "公司";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客戶";
            // 
            // 入庫時間
            // 
            this.入庫時間.CustomFormat = "yyyy-MM-dd HH:mm";
            this.入庫時間.Enabled = false;
            this.入庫時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.入庫時間.Location = new System.Drawing.Point(293, 107);
            this.入庫時間.Name = "入庫時間";
            this.入庫時間.Size = new System.Drawing.Size(165, 22);
            this.入庫時間.TabIndex = 120;
            this.入庫時間.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 752);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 119;
            this.label6.Text = "入庫時間";
            // 
            // 寄庫匯入詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 252);
            this.Controls.Add(this.入庫時間);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.錯誤訊息);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.入庫單號);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.商品);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.客戶);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.新版頁索引元件1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "寄庫匯入詳細視窗";
            this.Text = "寄庫匯入詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private 通用.新版頁索引元件 新版頁索引元件1;
        private 公司.公司選取元件 公司;
        private 客戶.客戶選取元件 客戶;
        private System.Windows.Forms.Label label4;
        private 商品.商品選取元件 商品;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox 入庫單號;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox 錯誤訊息;
        private System.Windows.Forms.Label label15;
        private MyDateTimePicker 入庫時間;
        private System.Windows.Forms.Label label6;
    }
}