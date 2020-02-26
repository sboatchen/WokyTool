using WokyTool.單品;
using WokyTool.通用;
namespace WokyTool.進貨
{
    partial class 進貨新增詳細視窗
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
            this.單品 = new WokyTool.單品.單品選取元件();
            this.廠商 = new WokyTool.廠商.廠商選取元件();
            this.類型 = new WokyTool.通用.進貨類型選取元件();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.新版頁索引元件1 = new WokyTool.通用.新版頁索引元件();
            this.label3 = new System.Windows.Forms.Label();
            this.單價 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.單價)).BeginInit();
            this.SuspendLayout();
            // 
            // 單品
            // 
            this.單品.Location = new System.Drawing.Point(59, 66);
            this.單品.Name = "單品";
            this.單品.ReadOnly = false;
            this.單品.SelectedItem = null;
            this.單品.Size = new System.Drawing.Size(420, 22);
            this.單品.TabIndex = 133;
            this.單品.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 廠商
            // 
            this.廠商.Location = new System.Drawing.Point(59, 38);
            this.廠商.Name = "廠商";
            this.廠商.ReadOnly = false;
            this.廠商.SelectedItem = null;
            this.廠商.Size = new System.Drawing.Size(172, 22);
            this.廠商.TabIndex = 132;
            this.廠商.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 類型
            // 
            this.類型.Location = new System.Drawing.Point(4, 11);
            this.類型.Name = "類型";
            this.類型.ReadOnly = false;
            this.類型.SelectedItem = WokyTool.通用.列舉.進貨類型.錯誤;
            this.類型.Size = new System.Drawing.Size(230, 22);
            this.類型.TabIndex = 131;
            this.類型.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(59, 124);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 128;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 127;
            this.label17.Text = "備註";
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(59, 94);
            this.數量.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.數量.Name = "數量";
            this.數量.Size = new System.Drawing.Size(165, 22);
            this.數量.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 125;
            this.label5.Text = "數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 124;
            this.label4.Text = "單品";
            // 
            // 新版頁索引元件1
            // 
            this.新版頁索引元件1.Location = new System.Drawing.Point(129, 163);
            this.新版頁索引元件1.Name = "新版頁索引元件1";
            this.新版頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.新版頁索引元件1.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 122;
            this.label3.Text = "廠商";
            // 
            // 單價
            // 
            this.單價.DecimalPlaces = 3;
            this.單價.Location = new System.Drawing.Point(294, 94);
            this.單價.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.單價.Name = "單價";
            this.單價.Size = new System.Drawing.Size(165, 22);
            this.單價.TabIndex = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 134;
            this.label1.Text = "單價";
            // 
            // 進貨新增詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 203);
            this.Controls.Add(this.單價);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.單品);
            this.Controls.Add(this.廠商);
            this.Controls.Add(this.類型);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.新版頁索引元件1);
            this.Controls.Add(this.label3);
            this.Name = "進貨新增詳細視窗";
            this.Text = "進貨新增詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.單價)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 單品選取元件 單品;
        private 廠商.廠商選取元件 廠商;
        private 進貨類型選取元件 類型;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private 新版頁索引元件 新版頁索引元件1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown 單價;
        private System.Windows.Forms.Label label1;

    }
}