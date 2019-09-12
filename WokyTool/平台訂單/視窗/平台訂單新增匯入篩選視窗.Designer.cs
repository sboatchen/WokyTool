using WokyTool.物品;
using WokyTool.通用;
namespace WokyTool.平台訂單
{
    partial class 平台訂單新增匯入篩選視窗
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
            this.最小處理時間 = new WokyTool.通用.MyDateTimePicker();
            this.處理狀態 = new WokyTool.通用.訂單處理狀態選取元件();
            this.公司 = new WokyTool.公司.公司選取元件();
            this.客戶 = new WokyTool.客戶.客戶選取元件();
            this.label4 = new System.Windows.Forms.Label();
            this.商品 = new WokyTool.商品.商品選取元件();
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
            this.最小代收金額 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.最大處理時間 = new WokyTool.通用.MyDateTimePicker();
            this.最大代收金額 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.最小代收金額)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.最大代收金額)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "客戶";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "公司";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 289);
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
            this.最小處理時間.Location = new System.Drawing.Point(79, 284);
            this.最小處理時間.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.最小處理時間.Name = "最小處理時間";
            this.最小處理時間.Size = new System.Drawing.Size(221, 25);
            this.最小處理時間.TabIndex = 58;
            this.最小處理時間.Value = new System.DateTime(((long)(0)));
            // 
            // 處理狀態
            // 
            this.處理狀態.Location = new System.Drawing.Point(11, 351);
            this.處理狀態.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.處理狀態.Name = "處理狀態";
            this.處理狀態.ReadOnly = false;
            this.處理狀態.SelectedItem = WokyTool.通用.列舉.訂單處理狀態.不篩選;
            this.處理狀態.Size = new System.Drawing.Size(296, 35);
            this.處理狀態.TabIndex = 59;
            this.處理狀態.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 公司
            // 
            this.公司.Location = new System.Drawing.Point(79, 71);
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
            this.客戶.Location = new System.Drawing.Point(401, 70);
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
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "商品";
            // 
            // 商品
            // 
            this.商品.Location = new System.Drawing.Point(79, 106);
            this.商品.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.商品.Name = "商品";
            this.商品.ReadOnly = false;
            this.商品.SelectedItem = null;
            this.商品.Size = new System.Drawing.Size(568, 31);
            this.商品.TabIndex = 63;
            this.商品.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(79, 161);
            this.姓名.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(223, 25);
            this.姓名.TabIndex = 66;
            // 
            // 地址
            // 
            this.地址.Location = new System.Drawing.Point(79, 196);
            this.地址.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(223, 25);
            this.地址.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 67;
            this.label6.Text = "地址";
            // 
            // 手機
            // 
            this.手機.Location = new System.Drawing.Point(403, 194);
            this.手機.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.手機.Name = "手機";
            this.手機.Size = new System.Drawing.Size(223, 25);
            this.手機.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 71;
            this.label8.Text = "手機";
            // 
            // 電話
            // 
            this.電話.Location = new System.Drawing.Point(403, 159);
            this.電話.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.電話.Name = "電話";
            this.電話.Size = new System.Drawing.Size(223, 25);
            this.電話.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 69;
            this.label10.Text = "電話";
            // 
            // 發票號碼
            // 
            this.發票號碼.Location = new System.Drawing.Point(400, 10);
            this.發票號碼.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.發票號碼.Name = "發票號碼";
            this.發票號碼.Size = new System.Drawing.Size(223, 25);
            this.發票號碼.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 75;
            this.label12.Text = "發票號碼";
            // 
            // 訂單編號
            // 
            this.訂單編號.Location = new System.Drawing.Point(76, 12);
            this.訂單編號.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.訂單編號.Name = "訂單編號";
            this.訂單編號.Size = new System.Drawing.Size(223, 25);
            this.訂單編號.TabIndex = 74;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 19);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 73;
            this.label16.Text = "訂單編號";
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(79, 231);
            this.備註.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(547, 25);
            this.備註.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 238);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 15);
            this.label17.TabIndex = 77;
            this.label17.Text = "備註";
            // 
            // 配送公司
            // 
            this.配送公司.Location = new System.Drawing.Point(333, 284);
            this.配送公司.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.配送公司.Name = "配送公司";
            this.配送公司.ReadOnly = false;
            this.配送公司.SelectedItem = WokyTool.通用.列舉.配送公司.不篩選;
            this.配送公司.Size = new System.Drawing.Size(296, 35);
            this.配送公司.TabIndex = 79;
            this.配送公司.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 配送單號
            // 
            this.配送單號.Location = new System.Drawing.Point(404, 322);
            this.配送單號.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.配送單號.Name = "配送單號";
            this.配送單號.Size = new System.Drawing.Size(223, 25);
            this.配送單號.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 328);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 80;
            this.label9.Text = "配送單號";
            // 
            // 指配日期
            // 
            this.指配日期.CustomFormat = " ";
            this.指配日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.指配日期.Location = new System.Drawing.Point(80, 404);
            this.指配日期.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.指配日期.Name = "指配日期";
            this.指配日期.Size = new System.Drawing.Size(221, 25);
            this.指配日期.TabIndex = 83;
            this.指配日期.Value = new System.DateTime(((long)(0)));
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 409);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 82;
            this.label11.Text = "指配日期";
            // 
            // 指配時段
            // 
            this.指配時段.Location = new System.Drawing.Point(9, 439);
            this.指配時段.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.指配時段.Name = "指配時段";
            this.指配時段.ReadOnly = false;
            this.指配時段.SelectedItem = WokyTool.通用.列舉.指配時段.不篩選;
            this.指配時段.Size = new System.Drawing.Size(296, 35);
            this.指配時段.TabIndex = 84;
            this.指配時段.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 代收方式
            // 
            this.代收方式.Location = new System.Drawing.Point(332, 401);
            this.代收方式.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.代收方式.Name = "代收方式";
            this.代收方式.ReadOnly = false;
            this.代收方式.SelectedItem = WokyTool.通用.列舉.代收方式.不篩選;
            this.代收方式.Size = new System.Drawing.Size(296, 35);
            this.代收方式.TabIndex = 85;
            this.代收方式.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 最小代收金額
            // 
            this.最小代收金額.Location = new System.Drawing.Point(403, 439);
            this.最小代收金額.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.最小代收金額.Size = new System.Drawing.Size(223, 25);
            this.最小代收金額.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(327, 444);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 87;
            this.label14.Text = "代收金額";
            // 
            // 最大處理時間
            // 
            this.最大處理時間.CustomFormat = " ";
            this.最大處理時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.最大處理時間.Location = new System.Drawing.Point(79, 319);
            this.最大處理時間.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.最大處理時間.Name = "最大處理時間";
            this.最大處理時間.Size = new System.Drawing.Size(221, 25);
            this.最大處理時間.TabIndex = 119;
            this.最大處理時間.Value = new System.DateTime(((long)(0)));
            // 
            // 最大代收金額
            // 
            this.最大代收金額.Location = new System.Drawing.Point(403, 474);
            this.最大代收金額.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.最大代收金額.Size = new System.Drawing.Size(223, 25);
            this.最大代收金額.TabIndex = 120;
            // 
            // 平台訂單新增匯入篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(652, 508);
            this.Controls.Add(this.最大代收金額);
            this.Controls.Add(this.最大處理時間);
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
            this.Controls.Add(this.商品);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.客戶);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.處理狀態);
            this.Controls.Add(this.最小處理時間);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "平台訂單新增匯入篩選視窗";
            this.Text = "平台訂單新增匯入篩選視窗";
            ((System.ComponentModel.ISupportInitialize)(this.最小代收金額)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.最大代收金額)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private MyDateTimePicker 最小處理時間;
        private 通用.訂單處理狀態選取元件 處理狀態;
        private 公司.公司選取元件 公司;
        private 客戶.客戶選取元件 客戶;
        private System.Windows.Forms.Label label4;
        private 商品.商品選取元件 商品;
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
        private System.Windows.Forms.NumericUpDown 最小代收金額;
        private System.Windows.Forms.Label label14;
        private MyDateTimePicker 最大處理時間;
        private System.Windows.Forms.NumericUpDown 最大代收金額;
    }
}