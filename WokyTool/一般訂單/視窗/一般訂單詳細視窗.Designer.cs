using WokyTool.物品;
using WokyTool.通用;
namespace WokyTool.一般訂單
{
    partial class 一般訂單詳細視窗
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
            this.成本 = new System.Windows.Forms.NumericUpDown();
            this.利潤 = new System.Windows.Forms.NumericUpDown();
            this.新版頁索引元件1 = new WokyTool.通用.新版頁索引元件();
            this.處理時間 = new WokyTool.通用.MyDateTimePicker();
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
            this.處理狀態 = new WokyTool.通用.訂單處理狀態選取元件();
            this.處理者 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.單價 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.總利潤 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.客戶名稱 = new System.Windows.Forms.TextBox();
            this.公司名稱 = new System.Windows.Forms.TextBox();
            this.商品名稱 = new System.Windows.Forms.TextBox();
            this.子客戶名稱 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.利潤)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收金額)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.單價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.總利潤)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客戶";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "公司";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "處理時間";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "成本";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Location = new System.Drawing.Point(249, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 17;
            this.label18.Text = "利潤";
            // 
            // 成本
            // 
            this.成本.DecimalPlaces = 3;
            this.成本.Location = new System.Drawing.Point(294, 166);
            this.成本.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.成本.Name = "成本";
            this.成本.ReadOnly = true;
            this.成本.Size = new System.Drawing.Size(165, 22);
            this.成本.TabIndex = 47;
            // 
            // 利潤
            // 
            this.利潤.DecimalPlaces = 3;
            this.利潤.Location = new System.Drawing.Point(294, 194);
            this.利潤.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.利潤.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.利潤.Name = "利潤";
            this.利潤.ReadOnly = true;
            this.利潤.Size = new System.Drawing.Size(165, 22);
            this.利潤.TabIndex = 48;
            // 
            // 新版頁索引元件1
            // 
            this.新版頁索引元件1.Location = new System.Drawing.Point(127, 509);
            this.新版頁索引元件1.Name = "新版頁索引元件1";
            this.新版頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.新版頁索引元件1.TabIndex = 57;
            // 
            // 處理時間
            // 
            this.處理時間.CustomFormat = "yyyy-MM-dd HH:mm";
            this.處理時間.Enabled = false;
            this.處理時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.處理時間.Location = new System.Drawing.Point(60, 12);
            this.處理時間.Name = "處理時間";
            this.處理時間.Size = new System.Drawing.Size(165, 22);
            this.處理時間.TabIndex = 58;
            this.處理時間.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 752);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "商品";
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(60, 166);
            this.數量.Name = "數量";
            this.數量.ReadOnly = true;
            this.數量.Size = new System.Drawing.Size(165, 22);
            this.數量.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 64;
            this.label5.Text = "數量";
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(59, 267);
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            this.姓名.Size = new System.Drawing.Size(165, 22);
            this.姓名.TabIndex = 66;
            // 
            // 地址
            // 
            this.地址.Location = new System.Drawing.Point(59, 295);
            this.地址.Name = "地址";
            this.地址.ReadOnly = true;
            this.地址.Size = new System.Drawing.Size(165, 22);
            this.地址.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 67;
            this.label6.Text = "地址";
            // 
            // 手機
            // 
            this.手機.Location = new System.Drawing.Point(293, 295);
            this.手機.Name = "手機";
            this.手機.ReadOnly = true;
            this.手機.Size = new System.Drawing.Size(165, 22);
            this.手機.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 71;
            this.label8.Text = "手機";
            // 
            // 電話
            // 
            this.電話.Location = new System.Drawing.Point(293, 267);
            this.電話.Name = "電話";
            this.電話.ReadOnly = true;
            this.電話.Size = new System.Drawing.Size(165, 22);
            this.電話.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 69;
            this.label10.Text = "電話";
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(59, 323);
            this.備註.Name = "備註";
            this.備註.ReadOnly = true;
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 328);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 77;
            this.label17.Text = "備註";
            // 
            // 配送公司
            // 
            this.配送公司.Location = new System.Drawing.Point(5, 371);
            this.配送公司.Name = "配送公司";
            this.配送公司.ReadOnly = true;
            this.配送公司.SelectedItem = WokyTool.通用.列舉.配送公司.錯誤;
            this.配送公司.Size = new System.Drawing.Size(222, 28);
            this.配送公司.TabIndex = 79;
            this.配送公司.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 配送單號
            // 
            this.配送單號.Location = new System.Drawing.Point(60, 400);
            this.配送單號.Name = "配送單號";
            this.配送單號.ReadOnly = true;
            this.配送單號.Size = new System.Drawing.Size(165, 22);
            this.配送單號.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 80;
            this.label9.Text = "配送單號";
            // 
            // 指配日期
            // 
            this.指配日期.CustomFormat = "yyyy-MM-dd";
            this.指配日期.Enabled = false;
            this.指配日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.指配日期.Location = new System.Drawing.Point(292, 371);
            this.指配日期.Name = "指配日期";
            this.指配日期.Size = new System.Drawing.Size(165, 22);
            this.指配日期.TabIndex = 83;
            this.指配日期.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 697);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 82;
            this.label11.Text = "指配日期";
            // 
            // 指配時段
            // 
            this.指配時段.Location = new System.Drawing.Point(237, 399);
            this.指配時段.Name = "指配時段";
            this.指配時段.ReadOnly = true;
            this.指配時段.SelectedItem = WokyTool.通用.列舉.指配時段.錯誤;
            this.指配時段.Size = new System.Drawing.Size(222, 28);
            this.指配時段.TabIndex = 84;
            this.指配時段.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 代收方式
            // 
            this.代收方式.Location = new System.Drawing.Point(3, 443);
            this.代收方式.Name = "代收方式";
            this.代收方式.ReadOnly = true;
            this.代收方式.SelectedItem = WokyTool.通用.列舉.代收方式.錯誤;
            this.代收方式.Size = new System.Drawing.Size(222, 28);
            this.代收方式.TabIndex = 85;
            this.代收方式.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 代收金額
            // 
            this.代收金額.Location = new System.Drawing.Point(58, 471);
            this.代收金額.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.代收金額.Name = "代收金額";
            this.代收金額.ReadOnly = true;
            this.代收金額.Size = new System.Drawing.Size(165, 22);
            this.代收金額.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(4, 474);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 87;
            this.label14.Text = "代收金額";
            // 
            // 處理狀態
            // 
            this.處理狀態.Location = new System.Drawing.Point(5, 40);
            this.處理狀態.Name = "處理狀態";
            this.處理狀態.ReadOnly = true;
            this.處理狀態.SelectedItem = WokyTool.通用.列舉.訂單處理狀態.錯誤;
            this.處理狀態.Size = new System.Drawing.Size(230, 22);
            this.處理狀態.TabIndex = 120;
            this.處理狀態.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 處理者
            // 
            this.處理者.Location = new System.Drawing.Point(292, 12);
            this.處理者.Name = "處理者";
            this.處理者.ReadOnly = true;
            this.處理者.Size = new System.Drawing.Size(165, 22);
            this.處理者.TabIndex = 122;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(248, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 121;
            this.label15.Text = "處理者";
            // 
            // 單價
            // 
            this.單價.DecimalPlaces = 3;
            this.單價.Location = new System.Drawing.Point(60, 194);
            this.單價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.單價.Name = "單價";
            this.單價.ReadOnly = true;
            this.單價.Size = new System.Drawing.Size(165, 22);
            this.單價.TabIndex = 125;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 199);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 123;
            this.label20.Text = "單價";
            this.label20.Visible = false;
            // 
            // 總利潤
            // 
            this.總利潤.DecimalPlaces = 3;
            this.總利潤.Location = new System.Drawing.Point(294, 222);
            this.總利潤.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.總利潤.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.總利潤.Name = "總利潤";
            this.總利潤.ReadOnly = true;
            this.總利潤.Size = new System.Drawing.Size(165, 22);
            this.總利潤.TabIndex = 128;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Location = new System.Drawing.Point(243, 226);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 127;
            this.label21.Text = "總利潤";
            // 
            // 客戶名稱
            // 
            this.客戶名稱.Location = new System.Drawing.Point(292, 81);
            this.客戶名稱.Name = "客戶名稱";
            this.客戶名稱.ReadOnly = true;
            this.客戶名稱.Size = new System.Drawing.Size(165, 22);
            this.客戶名稱.TabIndex = 129;
            // 
            // 公司名稱
            // 
            this.公司名稱.Location = new System.Drawing.Point(60, 81);
            this.公司名稱.Name = "公司名稱";
            this.公司名稱.ReadOnly = true;
            this.公司名稱.Size = new System.Drawing.Size(165, 22);
            this.公司名稱.TabIndex = 130;
            // 
            // 商品名稱
            // 
            this.商品名稱.Location = new System.Drawing.Point(59, 137);
            this.商品名稱.Name = "商品名稱";
            this.商品名稱.ReadOnly = true;
            this.商品名稱.Size = new System.Drawing.Size(400, 22);
            this.商品名稱.TabIndex = 131;
            // 
            // 子客戶名稱
            // 
            this.子客戶名稱.Location = new System.Drawing.Point(292, 109);
            this.子客戶名稱.Name = "子客戶名稱";
            this.子客戶名稱.ReadOnly = true;
            this.子客戶名稱.Size = new System.Drawing.Size(165, 22);
            this.子客戶名稱.TabIndex = 133;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 132;
            this.label12.Text = "子客戶";
            // 
            // 一般訂單詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 552);
            this.Controls.Add(this.子客戶名稱);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.商品名稱);
            this.Controls.Add(this.公司名稱);
            this.Controls.Add(this.客戶名稱);
            this.Controls.Add(this.總利潤);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.單價);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.處理者);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.處理狀態);
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
            this.Controls.Add(this.處理時間);
            this.Controls.Add(this.新版頁索引元件1);
            this.Controls.Add(this.利潤);
            this.Controls.Add(this.成本);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "一般訂單詳細視窗";
            this.Text = "一般訂單詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.成本)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.利潤)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.代收金額)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.單價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.總利潤)).EndInit();
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
        private System.Windows.Forms.NumericUpDown 成本;
        private System.Windows.Forms.NumericUpDown 利潤;
        private 通用.新版頁索引元件 新版頁索引元件1;
        private MyDateTimePicker 處理時間;
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
        private 訂單處理狀態選取元件 處理狀態;
        private System.Windows.Forms.TextBox 處理者;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown 單價;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown 總利潤;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox 客戶名稱;
        private System.Windows.Forms.TextBox 公司名稱;
        private System.Windows.Forms.TextBox 商品名稱;
        private System.Windows.Forms.TextBox 子客戶名稱;
        private System.Windows.Forms.Label label12;
    }
}