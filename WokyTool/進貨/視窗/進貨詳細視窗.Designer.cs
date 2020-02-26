using WokyTool.單品;
using WokyTool.通用;
namespace WokyTool.進貨
{
    partial class 進貨詳細視窗
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
            this.頁索引元件 = new WokyTool.通用.新版頁索引元件();
            this.單價 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.類型 = new WokyTool.通用.進貨類型選取元件();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.單品 = new System.Windows.Forms.TextBox();
            this.廠商 = new System.Windows.Forms.TextBox();
            this.處理者 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.處理時間 = new WokyTool.通用.MyDateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.單價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            this.SuspendLayout();
            // 
            // 頁索引元件
            // 
            this.頁索引元件.Location = new System.Drawing.Point(128, 187);
            this.頁索引元件.Name = "頁索引元件";
            this.頁索引元件.Size = new System.Drawing.Size(234, 34);
            this.頁索引元件.TabIndex = 57;
            // 
            // 單價
            // 
            this.單價.DecimalPlaces = 3;
            this.單價.Location = new System.Drawing.Point(294, 121);
            this.單價.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.單價.Name = "單價";
            this.單價.ReadOnly = true;
            this.單價.Size = new System.Drawing.Size(165, 22);
            this.單價.TabIndex = 146;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 145;
            this.label6.Text = "單價";
            // 
            // 類型
            // 
            this.類型.Location = new System.Drawing.Point(4, 38);
            this.類型.Name = "類型";
            this.類型.ReadOnly = true;
            this.類型.SelectedItem = WokyTool.通用.列舉.進貨類型.錯誤;
            this.類型.Size = new System.Drawing.Size(230, 22);
            this.類型.TabIndex = 142;
            this.類型.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(59, 151);
            this.備註.Name = "備註";
            this.備註.ReadOnly = true;
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 141;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 140;
            this.label8.Text = "備註";
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(59, 121);
            this.數量.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.數量.Name = "數量";
            this.數量.ReadOnly = true;
            this.數量.Size = new System.Drawing.Size(165, 22);
            this.數量.TabIndex = 139;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 138;
            this.label10.Text = "數量";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 137;
            this.label11.Text = "單品";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 136;
            this.label12.Text = "廠商";
            // 
            // 單品
            // 
            this.單品.Location = new System.Drawing.Point(59, 93);
            this.單品.Name = "單品";
            this.單品.ReadOnly = true;
            this.單品.Size = new System.Drawing.Size(400, 22);
            this.單品.TabIndex = 147;
            // 
            // 廠商
            // 
            this.廠商.Location = new System.Drawing.Point(59, 64);
            this.廠商.Name = "廠商";
            this.廠商.ReadOnly = true;
            this.廠商.Size = new System.Drawing.Size(165, 22);
            this.廠商.TabIndex = 148;
            // 
            // 處理者
            // 
            this.處理者.Location = new System.Drawing.Point(294, 8);
            this.處理者.Name = "處理者";
            this.處理者.ReadOnly = true;
            this.處理者.Size = new System.Drawing.Size(165, 22);
            this.處理者.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 151;
            this.label2.Text = "處理者";
            // 
            // 處理時間
            // 
            this.處理時間.CustomFormat = "yyyy-MM-dd HH:mm";
            this.處理時間.Enabled = false;
            this.處理時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.處理時間.Location = new System.Drawing.Point(59, 8);
            this.處理時間.Name = "處理時間";
            this.處理時間.Size = new System.Drawing.Size(165, 22);
            this.處理時間.TabIndex = 150;
            this.處理時間.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 752);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 149;
            this.label7.Text = "處理時間";
            // 
            // 進貨詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 224);
            this.Controls.Add(this.處理者);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.處理時間);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.廠商);
            this.Controls.Add(this.單品);
            this.Controls.Add(this.單價);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.類型);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.頁索引元件);
            this.Name = "進貨詳細視窗";
            this.Text = "進貨詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.單價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 通用.新版頁索引元件 頁索引元件;
        private System.Windows.Forms.NumericUpDown 單價;
        private System.Windows.Forms.Label label6;
        private 進貨類型選取元件 類型;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox 單品;
        private System.Windows.Forms.TextBox 廠商;
        private System.Windows.Forms.TextBox 處理者;
        private System.Windows.Forms.Label label2;
        private MyDateTimePicker 處理時間;
        private System.Windows.Forms.Label label7;
    }
}