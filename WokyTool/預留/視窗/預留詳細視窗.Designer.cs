using WokyTool.物品;
using WokyTool.通用;
namespace WokyTool.預留
{
    partial class 預留詳細視窗
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
            this.新版頁索引元件1 = new WokyTool.通用.新版頁索引元件();
            this.姓名 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.名稱 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.結束日期 = new WokyTool.通用.MyDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.開始日期 = new WokyTool.通用.MyDateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.物品 = new WokyTool.物品.物品選取元件();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            this.SuspendLayout();
            // 
            // 新版頁索引元件1
            // 
            this.新版頁索引元件1.Location = new System.Drawing.Point(123, 164);
            this.新版頁索引元件1.Name = "新版頁索引元件1";
            this.新版頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.新版頁索引元件1.TabIndex = 123;
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(294, 49);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(165, 22);
            this.姓名.TabIndex = 170;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 169;
            this.label8.Text = "姓名";
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(59, 49);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(165, 22);
            this.名稱.TabIndex = 168;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 167;
            this.label6.Text = "名稱";
            // 
            // 結束日期
            // 
            this.結束日期.CustomFormat = "yyyy-MM-dd";
            this.結束日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.結束日期.Location = new System.Drawing.Point(294, 10);
            this.結束日期.Name = "結束日期";
            this.結束日期.Size = new System.Drawing.Size(165, 22);
            this.結束日期.TabIndex = 166;
            this.結束日期.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 752);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 165;
            this.label2.Text = "結束日期";
            // 
            // 開始日期
            // 
            this.開始日期.CustomFormat = "yyyy-MM-dd";
            this.開始日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.開始日期.Location = new System.Drawing.Point(59, 10);
            this.開始日期.Name = "開始日期";
            this.開始日期.Size = new System.Drawing.Size(165, 22);
            this.開始日期.TabIndex = 164;
            this.開始日期.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 752);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 163;
            this.label7.Text = "開始日期";
            // 
            // 物品
            // 
            this.物品.Location = new System.Drawing.Point(59, 78);
            this.物品.Name = "物品";
            this.物品.ReadOnly = false;
            this.物品.SelectedItem = null;
            this.物品.Size = new System.Drawing.Size(420, 22);
            this.物品.TabIndex = 162;
            this.物品.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(59, 105);
            this.數量.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.數量.Name = "數量";
            this.數量.Size = new System.Drawing.Size(165, 22);
            this.數量.TabIndex = 161;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 160;
            this.label9.Text = "數量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 159;
            this.label10.Text = "物品";
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(59, 133);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 172;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 138);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 171;
            this.label17.Text = "備註";
            // 
            // 預留詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 201);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.結束日期);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.開始日期);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.物品);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.新版頁索引元件1);
            this.Name = "預留詳細視窗";
            this.Text = "預留詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 新版頁索引元件 新版頁索引元件1;
        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.Label label6;
        private MyDateTimePicker 結束日期;
        private System.Windows.Forms.Label label2;
        private MyDateTimePicker 開始日期;
        private System.Windows.Forms.Label label7;
        private 物品選取元件 物品;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;

    }
}