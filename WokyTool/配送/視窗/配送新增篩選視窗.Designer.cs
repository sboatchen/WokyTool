using WokyTool.物品;
using WokyTool.通用;
namespace WokyTool.配送
{
    partial class 配送新增篩選視窗
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
            this.label2 = new System.Windows.Forms.Label();
            this.新版頁索引元件1 = new WokyTool.通用.新版頁索引元件();
            this.姓名 = new System.Windows.Forms.TextBox();
            this.地址 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.手機 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.電話 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.配送公司 = new WokyTool.通用.配送公司選取元件();
            this.配送單號 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.指配日期 = new WokyTool.通用.MyDateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.指配時段 = new WokyTool.通用.指配時段選取元件();
            this.代收方式 = new WokyTool.通用.代收方式選取元件();
            this.最小代收金額 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.最大代收金額 = new System.Windows.Forms.NumericUpDown();
            this.內容 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.最小件數 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.最大件數 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.最小代收金額)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.最大代收金額)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.最小件數)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.最大件數)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // 新版頁索引元件1
            // 
            this.新版頁索引元件1.Location = new System.Drawing.Point(129, 316);
            this.新版頁索引元件1.Name = "新版頁索引元件1";
            this.新版頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.新版頁索引元件1.TabIndex = 57;
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(58, 52);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(165, 22);
            this.姓名.TabIndex = 66;
            // 
            // 地址
            // 
            this.地址.Location = new System.Drawing.Point(58, 78);
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(165, 22);
            this.地址.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "地址";
            // 
            // 手機
            // 
            this.手機.Location = new System.Drawing.Point(293, 78);
            this.手機.Name = "手機";
            this.手機.Size = new System.Drawing.Size(165, 22);
            this.手機.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 71;
            this.label8.Text = "手機";
            // 
            // 電話
            // 
            this.電話.Location = new System.Drawing.Point(293, 50);
            this.電話.Name = "電話";
            this.電話.Size = new System.Drawing.Size(165, 22);
            this.電話.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 69;
            this.label10.Text = "電話";
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(58, 108);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 77;
            this.label17.Text = "備註";
            // 
            // 配送公司
            // 
            this.配送公司.Location = new System.Drawing.Point(2, 7);
            this.配送公司.Name = "配送公司";
            this.配送公司.ReadOnly = false;
            this.配送公司.SelectedItem = WokyTool.通用.列舉.配送公司.不篩選;
            this.配送公司.Size = new System.Drawing.Size(222, 28);
            this.配送公司.TabIndex = 79;
            this.配送公司.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 配送單號
            // 
            this.配送單號.Location = new System.Drawing.Point(293, 7);
            this.配送單號.Name = "配送單號";
            this.配送單號.Size = new System.Drawing.Size(165, 22);
            this.配送單號.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 80;
            this.label9.Text = "配送單號";
            // 
            // 指配日期
            // 
            this.指配日期.CustomFormat = " ";
            this.指配日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.指配日期.Location = new System.Drawing.Point(59, 147);
            this.指配日期.Name = "指配日期";
            this.指配日期.Size = new System.Drawing.Size(165, 22);
            this.指配日期.TabIndex = 83;
            this.指配日期.Value = new System.DateTime(((long)(0)));
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 82;
            this.label11.Text = "指配日期";
            // 
            // 指配時段
            // 
            this.指配時段.Location = new System.Drawing.Point(5, 181);
            this.指配時段.Name = "指配時段";
            this.指配時段.ReadOnly = false;
            this.指配時段.SelectedItem = WokyTool.通用.列舉.指配時段.不篩選;
            this.指配時段.Size = new System.Drawing.Size(222, 28);
            this.指配時段.TabIndex = 84;
            this.指配時段.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 代收方式
            // 
            this.代收方式.Location = new System.Drawing.Point(238, 151);
            this.代收方式.Name = "代收方式";
            this.代收方式.ReadOnly = false;
            this.代收方式.SelectedItem = WokyTool.通用.列舉.代收方式.不篩選;
            this.代收方式.Size = new System.Drawing.Size(222, 28);
            this.代收方式.TabIndex = 85;
            this.代收方式.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 最小代收金額
            // 
            this.最小代收金額.Location = new System.Drawing.Point(293, 177);
            this.最小代收金額.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.最小代收金額.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.最小代收金額.Name = "最小代收金額";
            this.最小代收金額.Size = new System.Drawing.Size(165, 22);
            this.最小代收金額.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(237, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 87;
            this.label14.Text = "代收金額";
            // 
            // 最大代收金額
            // 
            this.最大代收金額.Location = new System.Drawing.Point(293, 205);
            this.最大代收金額.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.最大代收金額.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.最大代收金額.Name = "最大代收金額";
            this.最大代收金額.Size = new System.Drawing.Size(165, 22);
            this.最大代收金額.TabIndex = 120;
            // 
            // 內容
            // 
            this.內容.Location = new System.Drawing.Point(58, 283);
            this.內容.Name = "內容";
            this.內容.Size = new System.Drawing.Size(400, 22);
            this.內容.TabIndex = 124;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 123;
            this.label15.Text = "內容";
            // 
            // 最小件數
            // 
            this.最小件數.Location = new System.Drawing.Point(58, 255);
            this.最小件數.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.最小件數.Name = "最小件數";
            this.最小件數.Size = new System.Drawing.Size(80, 22);
            this.最小件數.TabIndex = 122;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 121;
            this.label5.Text = "件數";
            // 
            // 最大件數
            // 
            this.最大件數.Location = new System.Drawing.Point(143, 255);
            this.最大件數.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.最大件數.Name = "最大件數";
            this.最大件數.Size = new System.Drawing.Size(80, 22);
            this.最大件數.TabIndex = 125;
            // 
            // 配送新增篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(475, 354);
            this.Controls.Add(this.最大件數);
            this.Controls.Add(this.內容);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.最小件數);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.最大代收金額);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.最小代收金額);
            this.Controls.Add(this.代收方式);
            this.Controls.Add(this.指配時段);
            this.Controls.Add(this.指配日期);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.配送單號);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.配送公司);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.手機);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.電話);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.地址);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.新版頁索引元件1);
            this.Controls.Add(this.label2);
            this.Name = "配送新增篩選視窗";
            this.Text = "配送新增篩選視窗";
            ((System.ComponentModel.ISupportInitialize)(this.最小代收金額)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.最大代收金額)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.最小件數)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.最大件數)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private 通用.新版頁索引元件 新版頁索引元件1;
        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.TextBox 地址;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 手機;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox 電話;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private 通用.配送公司選取元件 配送公司;
        private System.Windows.Forms.TextBox 配送單號;
        private System.Windows.Forms.Label label9;
        private MyDateTimePicker 指配日期;
        private System.Windows.Forms.Label label11;
        private 通用.指配時段選取元件 指配時段;
        private 通用.代收方式選取元件 代收方式;
        private System.Windows.Forms.NumericUpDown 最小代收金額;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown 最大代收金額;
        private System.Windows.Forms.TextBox 內容;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown 最小件數;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown 最大件數;
    }
}