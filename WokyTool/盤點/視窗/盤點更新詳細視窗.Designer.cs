using WokyTool.物品;
using WokyTool.通用;
namespace WokyTool.盤點
{
    partial class 盤點更新詳細視窗
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
            this.備註 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.物品 = new WokyTool.物品.物品選取元件();
            this.更新狀態 = new WokyTool.通用.更新狀態選取元件();
            this.錯誤訊息 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.大料架庫存 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.萬通庫存 = new System.Windows.Forms.NumericUpDown();
            this.小料架庫存 = new System.Windows.Forms.NumericUpDown();
            this.參考小料架庫存 = new System.Windows.Forms.NumericUpDown();
            this.參考萬通庫存 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.參考大料架庫存 = new System.Windows.Forms.NumericUpDown();
            this.參考物品 = new WokyTool.物品.物品選取元件();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.參考備註 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.大料架庫存)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.萬通庫存)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.小料架庫存)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.參考小料架庫存)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.參考萬通庫存)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.參考大料架庫存)).BeginInit();
            this.SuspendLayout();
            // 
            // 新版頁索引元件1
            // 
            this.新版頁索引元件1.Location = new System.Drawing.Point(371, 226);
            this.新版頁索引元件1.Margin = new System.Windows.Forms.Padding(4);
            this.新版頁索引元件1.Name = "新版頁索引元件1";
            this.新版頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.新版頁索引元件1.TabIndex = 57;
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(58, 181);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "萬通";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 82;
            this.label2.Text = "大料架";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 83;
            this.label3.Text = "小料架";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 85;
            this.label5.Text = "物品";
            // 
            // 物品
            // 
            this.物品.Location = new System.Drawing.Point(58, 43);
            this.物品.Name = "物品";
            this.物品.ReadOnly = false;
            this.物品.SelectedItem = null;
            this.物品.Size = new System.Drawing.Size(420, 22);
            this.物品.TabIndex = 86;
            this.物品.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 更新狀態
            // 
            this.更新狀態.Location = new System.Drawing.Point(3, 9);
            this.更新狀態.Margin = new System.Windows.Forms.Padding(4);
            this.更新狀態.Name = "更新狀態";
            this.更新狀態.ReadOnly = true;
            this.更新狀態.SelectedItem = WokyTool.通用.列舉.更新狀態.錯誤;
            this.更新狀態.Size = new System.Drawing.Size(225, 28);
            this.更新狀態.TabIndex = 120;
            this.更新狀態.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 錯誤訊息
            // 
            this.錯誤訊息.Location = new System.Drawing.Point(293, 9);
            this.錯誤訊息.Name = "錯誤訊息";
            this.錯誤訊息.ReadOnly = true;
            this.錯誤訊息.Size = new System.Drawing.Size(669, 22);
            this.錯誤訊息.TabIndex = 119;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(237, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 118;
            this.label17.Text = "錯誤訊息";
            // 
            // 大料架庫存
            // 
            this.大料架庫存.Location = new System.Drawing.Point(58, 81);
            this.大料架庫存.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.大料架庫存.Name = "大料架庫存";
            this.大料架庫存.Size = new System.Drawing.Size(165, 22);
            this.大料架庫存.TabIndex = 121;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 123;
            this.label6.Text = "備註";
            // 
            // 萬通庫存
            // 
            this.萬通庫存.Location = new System.Drawing.Point(58, 139);
            this.萬通庫存.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.萬通庫存.Name = "萬通庫存";
            this.萬通庫存.Size = new System.Drawing.Size(165, 22);
            this.萬通庫存.TabIndex = 125;
            // 
            // 小料架庫存
            // 
            this.小料架庫存.Location = new System.Drawing.Point(58, 110);
            this.小料架庫存.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.小料架庫存.Name = "小料架庫存";
            this.小料架庫存.Size = new System.Drawing.Size(165, 22);
            this.小料架庫存.TabIndex = 126;
            // 
            // 參考小料架庫存
            // 
            this.參考小料架庫存.Location = new System.Drawing.Point(562, 110);
            this.參考小料架庫存.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.參考小料架庫存.Name = "參考小料架庫存";
            this.參考小料架庫存.ReadOnly = true;
            this.參考小料架庫存.Size = new System.Drawing.Size(165, 22);
            this.參考小料架庫存.TabIndex = 136;
            // 
            // 參考萬通庫存
            // 
            this.參考萬通庫存.Location = new System.Drawing.Point(562, 139);
            this.參考萬通庫存.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.參考萬通庫存.Name = "參考萬通庫存";
            this.參考萬通庫存.ReadOnly = true;
            this.參考萬通庫存.Size = new System.Drawing.Size(165, 22);
            this.參考萬通庫存.TabIndex = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 134;
            this.label4.Text = "備註";
            // 
            // 參考大料架庫存
            // 
            this.參考大料架庫存.Location = new System.Drawing.Point(562, 81);
            this.參考大料架庫存.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.參考大料架庫存.Name = "參考大料架庫存";
            this.參考大料架庫存.ReadOnly = true;
            this.參考大料架庫存.Size = new System.Drawing.Size(165, 22);
            this.參考大料架庫存.TabIndex = 133;
            // 
            // 參考物品
            // 
            this.參考物品.Location = new System.Drawing.Point(562, 43);
            this.參考物品.Name = "參考物品";
            this.參考物品.ReadOnly = true;
            this.參考物品.SelectedItem = null;
            this.參考物品.Size = new System.Drawing.Size(420, 22);
            this.參考物品.TabIndex = 132;
            this.參考物品.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 131;
            this.label7.Text = "物品";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 130;
            this.label8.Text = "小料架";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 129;
            this.label9.Text = "大料架";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(520, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 128;
            this.label10.Text = "萬通";
            // 
            // 參考備註
            // 
            this.參考備註.Location = new System.Drawing.Point(562, 181);
            this.參考備註.Name = "參考備註";
            this.參考備註.ReadOnly = true;
            this.參考備註.Size = new System.Drawing.Size(400, 22);
            this.參考備註.TabIndex = 127;
            // 
            // 盤點更新詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 271);
            this.Controls.Add(this.參考小料架庫存);
            this.Controls.Add(this.參考萬通庫存);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.參考大料架庫存);
            this.Controls.Add(this.參考物品);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.參考備註);
            this.Controls.Add(this.小料架庫存);
            this.Controls.Add(this.萬通庫存);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.大料架庫存);
            this.Controls.Add(this.更新狀態);
            this.Controls.Add(this.錯誤訊息);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.物品);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.新版頁索引元件1);
            this.Name = "盤點更新詳細視窗";
            this.Text = "盤點更新詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.大料架庫存)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.萬通庫存)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.小料架庫存)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.參考小料架庫存)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.參考萬通庫存)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.參考大料架庫存)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 通用.新版頁索引元件 新版頁索引元件1;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private 物品選取元件 物品;
        private 更新狀態選取元件 更新狀態;
        private System.Windows.Forms.TextBox 錯誤訊息;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown 大料架庫存;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown 萬通庫存;
        private System.Windows.Forms.NumericUpDown 小料架庫存;
        private System.Windows.Forms.NumericUpDown 參考小料架庫存;
        private System.Windows.Forms.NumericUpDown 參考萬通庫存;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown 參考大料架庫存;
        private 物品選取元件 參考物品;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox 參考備註;
    }
}