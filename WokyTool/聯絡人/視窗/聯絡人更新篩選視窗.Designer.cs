﻿namespace WokyTool.聯絡人
{
    partial class 聯絡人更新篩選視窗
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
            this.label11 = new System.Windows.Forms.Label();
            this.電話 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.手機 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.地址 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.姓名 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.更新狀態 = new WokyTool.通用.更新狀態選取元件();
            this.子客戶 = new WokyTool.客戶.子客戶選取元件();
            this.客戶 = new WokyTool.客戶.客戶選取元件();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(256, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 90;
            this.label11.Text = "子客戶";
            // 
            // 電話
            // 
            this.電話.Location = new System.Drawing.Point(51, 65);
            this.電話.Name = "電話";
            this.電話.Size = new System.Drawing.Size(165, 22);
            this.電話.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 88;
            this.label10.Text = "電話";
            // 
            // 手機
            // 
            this.手機.Location = new System.Drawing.Point(51, 93);
            this.手機.Name = "手機";
            this.手機.Size = new System.Drawing.Size(165, 22);
            this.手機.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 86;
            this.label9.Text = "手機";
            // 
            // 地址
            // 
            this.地址.Location = new System.Drawing.Point(51, 121);
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(421, 22);
            this.地址.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 84;
            this.label6.Text = "地址";
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(51, 33);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(165, 22);
            this.姓名.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 74;
            this.label7.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 73;
            this.label5.Text = "客戶";
            // 
            // 更新狀態
            // 
            this.更新狀態.Location = new System.Drawing.Point(1, 1);
            this.更新狀態.Margin = new System.Windows.Forms.Padding(4);
            this.更新狀態.Name = "更新狀態";
            this.更新狀態.ReadOnly = false;
            this.更新狀態.SelectedItem = WokyTool.通用.列舉.更新狀態.不篩選;
            this.更新狀態.Size = new System.Drawing.Size(225, 28);
            this.更新狀態.TabIndex = 119;
            this.更新狀態.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 子客戶
            // 
            this.子客戶.Location = new System.Drawing.Point(304, 93);
            this.子客戶.Margin = new System.Windows.Forms.Padding(4);
            this.子客戶.Name = "子客戶";
            this.子客戶.ReadOnly = false;
            this.子客戶.SelectedItem = null;
            this.子客戶.Size = new System.Drawing.Size(186, 25);
            this.子客戶.TabIndex = 91;
            this.子客戶.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 客戶
            // 
            this.客戶.Location = new System.Drawing.Point(303, 65);
            this.客戶.Margin = new System.Windows.Forms.Padding(4);
            this.客戶.Name = "客戶";
            this.客戶.ReadOnly = false;
            this.客戶.SelectedItem = null;
            this.客戶.Size = new System.Drawing.Size(190, 25);
            this.客戶.TabIndex = 80;
            this.客戶.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 聯絡人更新篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 151);
            this.Controls.Add(this.更新狀態);
            this.Controls.Add(this.子客戶);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.電話);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.手機);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.地址);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.客戶);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "聯絡人更新篩選視窗";
            this.Text = "聯絡人更新篩選視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 客戶.客戶選取元件 客戶;
        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 地址;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 手機;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox 電話;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private 客戶.子客戶選取元件 子客戶;
        private 通用.更新狀態選取元件 更新狀態;
    }
}