using WokyTool.物品;
using WokyTool.通用;
namespace WokyTool.平台訂單
{
    partial class 平台訂單新增詳細視窗
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.單價 = new System.Windows.Forms.NumericUpDown();
            this.含稅單價 = new System.Windows.Forms.NumericUpDown();
            this.新版頁索引元件1 = new WokyTool.通用.新版頁索引元件();
            this.處理時間 = new WokyTool.通用.MyDateTimePicker();
            this.公司 = new WokyTool.公司.公司選取元件();
            this.客戶 = new WokyTool.客戶.客戶選取元件();
            this.label4 = new System.Windows.Forms.Label();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.姓名 = new System.Windows.Forms.TextBox();
            this.地址 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.手機 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.電話 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.發票號碼 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.訂單編號 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.配送公司 = new WokyTool.通用.配送公司選取元件();
            this.配送單號 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.指配日期 = new WokyTool.通用.MyDateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.指配時段 = new WokyTool.通用.指配時段選取元件();
            this.代收方式 = new WokyTool.通用.代收方式選取元件();
            this.代收金額 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.商品 = new WokyTool.商品.商品選取元件();
            this.處理狀態 = new WokyTool.通用.訂單處理狀態選取元件();
            ((System.ComponentModel.ISupportInitialize)(this.單價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.含稅單價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收金額)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客戶";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "公司";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "處理時間";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "單價";
            this.label13.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Location = new System.Drawing.Point(238, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 17;
            this.label18.Text = "含稅單價";
            // 
            // 單價
            // 
            this.單價.DecimalPlaces = 3;
            this.單價.Location = new System.Drawing.Point(294, 113);
            this.單價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.單價.Name = "單價";
            this.單價.Size = new System.Drawing.Size(165, 22);
            this.單價.TabIndex = 47;
            // 
            // 含稅單價
            // 
            this.含稅單價.DecimalPlaces = 3;
            this.含稅單價.Location = new System.Drawing.Point(294, 141);
            this.含稅單價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.含稅單價.Name = "含稅單價";
            this.含稅單價.Size = new System.Drawing.Size(165, 22);
            this.含稅單價.TabIndex = 48;
            // 
            // 新版頁索引元件1
            // 
            this.新版頁索引元件1.Location = new System.Drawing.Point(127, 424);
            this.新版頁索引元件1.Name = "新版頁索引元件1";
            this.新版頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.新版頁索引元件1.TabIndex = 57;
            // 
            // 處理時間
            // 
            this.處理時間.CustomFormat = "yyyy-MM-dd HH:mm";
            this.處理時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.處理時間.Location = new System.Drawing.Point(59, 287);
            this.處理時間.Name = "處理時間";
            this.處理時間.Size = new System.Drawing.Size(165, 22);
            this.處理時間.TabIndex = 58;
            this.處理時間.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 752);
            // 
            // 公司
            // 
            this.公司.Location = new System.Drawing.Point(59, 57);
            this.公司.Name = "公司";
            this.公司.ReadOnly = true;
            this.公司.SelectedItem = null;
            this.公司.Size = new System.Drawing.Size(173, 25);
            this.公司.TabIndex = 60;
            this.公司.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 客戶
            // 
            this.客戶.Location = new System.Drawing.Point(294, 57);
            this.客戶.Name = "客戶";
            this.客戶.ReadOnly = true;
            this.客戶.SelectedItem = null;
            this.客戶.Size = new System.Drawing.Size(186, 25);
            this.客戶.TabIndex = 61;
            this.客戶.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "商品";
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(60, 113);
            this.數量.Name = "數量";
            this.數量.Size = new System.Drawing.Size(165, 22);
            this.數量.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 64;
            this.label5.Text = "數量";
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(59, 187);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(165, 22);
            this.姓名.TabIndex = 66;
            // 
            // 地址
            // 
            this.地址.Location = new System.Drawing.Point(59, 215);
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(165, 22);
            this.地址.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "地址";
            // 
            // 手機
            // 
            this.手機.Location = new System.Drawing.Point(294, 215);
            this.手機.Name = "手機";
            this.手機.Size = new System.Drawing.Size(165, 22);
            this.手機.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 71;
            this.label8.Text = "手機";
            // 
            // 電話
            // 
            this.電話.Location = new System.Drawing.Point(294, 187);
            this.電話.Name = "電話";
            this.電話.Size = new System.Drawing.Size(165, 22);
            this.電話.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 69;
            this.label10.Text = "電話";
            // 
            // 發票號碼
            // 
            this.發票號碼.Location = new System.Drawing.Point(292, 10);
            this.發票號碼.Name = "發票號碼";
            this.發票號碼.Size = new System.Drawing.Size(165, 22);
            this.發票號碼.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 75;
            this.label12.Text = "發票號碼";
            // 
            // 訂單編號
            // 
            this.訂單編號.Location = new System.Drawing.Point(57, 10);
            this.訂單編號.Name = "訂單編號";
            this.訂單編號.Size = new System.Drawing.Size(165, 22);
            this.訂單編號.TabIndex = 74;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 73;
            this.label16.Text = "訂單編號";
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(59, 243);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 77;
            this.label17.Text = "備註";
            // 
            // 配送公司
            // 
            this.配送公司.Location = new System.Drawing.Point(238, 287);
            this.配送公司.Name = "配送公司";
            this.配送公司.ReadOnly = false;
            this.配送公司.SelectedItem = WokyTool.通用.列舉.配送公司.錯誤;
            this.配送公司.Size = new System.Drawing.Size(222, 28);
            this.配送公司.TabIndex = 79;
            this.配送公司.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 配送單號
            // 
            this.配送單號.Location = new System.Drawing.Point(292, 316);
            this.配送單號.Name = "配送單號";
            this.配送單號.Size = new System.Drawing.Size(165, 22);
            this.配送單號.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 80;
            this.label9.Text = "配送單號";
            // 
            // 指配日期
            // 
            this.指配日期.CustomFormat = "yyyy-MM-dd";
            this.指配日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.指配日期.Location = new System.Drawing.Point(60, 361);
            this.指配日期.Name = "指配日期";
            this.指配日期.Size = new System.Drawing.Size(165, 22);
            this.指配日期.TabIndex = 83;
            this.指配日期.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 697);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 82;
            this.label11.Text = "指配日期";
            // 
            // 指配時段
            // 
            this.指配時段.Location = new System.Drawing.Point(5, 389);
            this.指配時段.Name = "指配時段";
            this.指配時段.ReadOnly = false;
            this.指配時段.SelectedItem = WokyTool.通用.列舉.指配時段.錯誤;
            this.指配時段.Size = new System.Drawing.Size(222, 28);
            this.指配時段.TabIndex = 84;
            this.指配時段.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 代收方式
            // 
            this.代收方式.Location = new System.Drawing.Point(237, 359);
            this.代收方式.Name = "代收方式";
            this.代收方式.ReadOnly = false;
            this.代收方式.SelectedItem = WokyTool.通用.列舉.代收方式.錯誤;
            this.代收方式.Size = new System.Drawing.Size(222, 28);
            this.代收方式.TabIndex = 85;
            this.代收方式.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 代收金額
            // 
            this.代收金額.Location = new System.Drawing.Point(292, 387);
            this.代收金額.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.代收金額.Name = "代收金額";
            this.代收金額.Size = new System.Drawing.Size(165, 22);
            this.代收金額.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(238, 391);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 87;
            this.label14.Text = "代收金額";
            // 
            // 商品
            // 
            this.商品.Location = new System.Drawing.Point(59, 84);
            this.商品.Name = "商品";
            this.商品.ReadOnly = false;
            this.商品.SelectedItem = null;
            this.商品.Size = new System.Drawing.Size(420, 22);
            this.商品.TabIndex = 119;
            this.商品.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 處理狀態
            // 
            this.處理狀態.Location = new System.Drawing.Point(5, 316);
            this.處理狀態.Name = "處理狀態";
            this.處理狀態.ReadOnly = false;
            this.處理狀態.SelectedItem = WokyTool.通用.列舉.訂單處理狀態.錯誤;
            this.處理狀態.Size = new System.Drawing.Size(230, 22);
            this.處理狀態.TabIndex = 120;
            this.處理狀態.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 平台訂單新增詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 465);
            this.Controls.Add(this.處理狀態);
            this.Controls.Add(this.商品);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.代收金額);
            this.Controls.Add(this.代收方式);
            this.Controls.Add(this.指配時段);
            this.Controls.Add(this.指配日期);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.配送單號);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.配送公司);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.發票號碼);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.訂單編號);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.手機);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.電話);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.地址);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.客戶);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.處理時間);
            this.Controls.Add(this.新版頁索引元件1);
            this.Controls.Add(this.含稅單價);
            this.Controls.Add(this.單價);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "平台訂單新增詳細視窗";
            this.Text = "平台訂單新增詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.單價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.含稅單價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收金額)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown 單價;
        private System.Windows.Forms.NumericUpDown 含稅單價;
        private 通用.新版頁索引元件 新版頁索引元件1;
        private MyDateTimePicker 處理時間;
        private 公司.公司選取元件 公司;
        private 客戶.客戶選取元件 客戶;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.TextBox 地址;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 手機;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox 電話;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox 發票號碼;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox 訂單編號;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private 通用.配送公司選取元件 配送公司;
        private System.Windows.Forms.TextBox 配送單號;
        private System.Windows.Forms.Label label9;
        private MyDateTimePicker 指配日期;
        private System.Windows.Forms.Label label11;
        private 通用.指配時段選取元件 指配時段;
        private 通用.代收方式選取元件 代收方式;
        private System.Windows.Forms.NumericUpDown 代收金額;
        private System.Windows.Forms.Label label14;
        private 商品.商品選取元件 商品;
        private 訂單處理狀態選取元件 處理狀態;
    }
}