﻿using WokyTool.物品;
using WokyTool.通用;
namespace WokyTool.寄庫
{
    partial class 寄庫新增匯入篩選視窗
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.最小處理時間 = new WokyTool.通用.MyDateTimePicker();
            this.公司 = new WokyTool.公司.公司選取元件();
            this.客戶 = new WokyTool.客戶.客戶選取元件();
            this.label4 = new System.Windows.Forms.Label();
            this.商品 = new WokyTool.商品.商品選取元件();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.入庫單號 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.最大處理時間 = new WokyTool.通用.MyDateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "客戶";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "公司";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "處理時間";
            // 
            // 最小處理時間
            // 
            this.最小處理時間.CustomFormat = " ";
            this.最小處理時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.最小處理時間.Location = new System.Drawing.Point(79, 94);
            this.最小處理時間.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.最小處理時間.Name = "最小處理時間";
            this.最小處理時間.Size = new System.Drawing.Size(221, 25);
            this.最小處理時間.TabIndex = 58;
            this.最小處理時間.Value = new System.DateTime(((long)(0)));
            // 
            // 公司
            // 
            this.公司.Location = new System.Drawing.Point(79, 11);
            this.公司.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.公司.Name = "公司";
            this.公司.ReadOnly = false;
            this.公司.SelectedItem = null;
            this.公司.Size = new System.Drawing.Size(231, 31);
            this.公司.TabIndex = 60;
            this.公司.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 客戶
            // 
            this.客戶.Location = new System.Drawing.Point(401, 10);
            this.客戶.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.客戶.Name = "客戶";
            this.客戶.ReadOnly = false;
            this.客戶.SelectedItem = null;
            this.客戶.Size = new System.Drawing.Size(248, 31);
            this.客戶.TabIndex = 61;
            this.客戶.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "商品";
            // 
            // 商品
            // 
            this.商品.Location = new System.Drawing.Point(79, 45);
            this.商品.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.商品.Name = "商品";
            this.商品.ReadOnly = false;
            this.商品.SelectedItem = null;
            this.商品.Size = new System.Drawing.Size(568, 31);
            this.商品.TabIndex = 63;
            this.商品.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(79, 165);
            this.備註.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(547, 25);
            this.備註.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 170);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 15);
            this.label17.TabIndex = 77;
            this.label17.Text = "備註";
            // 
            // 入庫單號
            // 
            this.入庫單號.Location = new System.Drawing.Point(401, 95);
            this.入庫單號.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.入庫單號.Name = "入庫單號";
            this.入庫單號.Size = new System.Drawing.Size(223, 25);
            this.入庫單號.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 80;
            this.label9.Text = "入庫單號";
            // 
            // 最大處理時間
            // 
            this.最大處理時間.CustomFormat = " ";
            this.最大處理時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.最大處理時間.Location = new System.Drawing.Point(79, 129);
            this.最大處理時間.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.最大處理時間.Name = "最大處理時間";
            this.最大處理時間.Size = new System.Drawing.Size(221, 25);
            this.最大處理時間.TabIndex = 119;
            this.最大處理時間.Value = new System.DateTime(((long)(0)));
            // 
            // 寄庫新增匯入篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(652, 200);
            this.Controls.Add(this.最大處理時間);
            this.Controls.Add(this.入庫單號);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.商品);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.客戶);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.最小處理時間);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "寄庫新增匯入篩選視窗";
            this.Text = "寄庫新增匯入篩選視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private MyDateTimePicker 最小處理時間;
        private 公司.公司選取元件 公司;
        private 客戶.客戶選取元件 客戶;
        private System.Windows.Forms.Label label4;
        private 商品.商品選取元件 商品;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox 入庫單號;
        private System.Windows.Forms.Label label9;
        private MyDateTimePicker 最大處理時間;
    }
}