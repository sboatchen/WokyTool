namespace WokyTool.月結帳
{
    partial class 月結帳匯入詳細視窗
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
            this.利潤 = new System.Windows.Forms.NumericUpDown();
            this.成本 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.含稅單價 = new System.Windows.Forms.NumericUpDown();
            this.單價 = new System.Windows.Forms.NumericUpDown();
            this.客戶選取元件1 = new WokyTool.客戶.客戶選取元件();
            this.公司選取元件1 = new WokyTool.公司.公司選取元件();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.商品識別 = new System.Windows.Forms.TextBox();
            this.頁索引元件1 = new WokyTool.通用.頁索引元件();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.商品選取元件1 = new WokyTool.商品.商品選取元件();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.總利潤 = new System.Windows.Forms.NumericUpDown();
            this.總金額 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.利潤)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.含稅單價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.單價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.總利潤)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.總金額)).BeginInit();
            this.SuspendLayout();
            // 
            // 利潤
            // 
            this.利潤.DecimalPlaces = 3;
            this.利潤.Location = new System.Drawing.Point(297, 181);
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
            this.利潤.Size = new System.Drawing.Size(167, 22);
            this.利潤.TabIndex = 109;
            // 
            // 成本
            // 
            this.成本.DecimalPlaces = 3;
            this.成本.Location = new System.Drawing.Point(64, 180);
            this.成本.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.成本.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.成本.Name = "成本";
            this.成本.ReadOnly = true;
            this.成本.Size = new System.Drawing.Size(167, 22);
            this.成本.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 103;
            this.label6.Text = "單價";
            // 
            // 含稅單價
            // 
            this.含稅單價.DecimalPlaces = 3;
            this.含稅單價.Location = new System.Drawing.Point(297, 152);
            this.含稅單價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.含稅單價.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.含稅單價.Name = "含稅單價";
            this.含稅單價.Size = new System.Drawing.Size(167, 22);
            this.含稅單價.TabIndex = 97;
            // 
            // 單價
            // 
            this.單價.DecimalPlaces = 3;
            this.單價.Location = new System.Drawing.Point(64, 152);
            this.單價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.單價.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.單價.Name = "單價";
            this.單價.Size = new System.Drawing.Size(167, 22);
            this.單價.TabIndex = 96;
            // 
            // 客戶選取元件1
            // 
            this.客戶選取元件1.Location = new System.Drawing.Point(64, 110);
            this.客戶選取元件1.Name = "客戶選取元件1";
            this.客戶選取元件1.ReadOnly = true;
            this.客戶選取元件1.SelectedItem = null;
            this.客戶選取元件1.Size = new System.Drawing.Size(190, 25);
            this.客戶選取元件1.TabIndex = 90;
            // 
            // 公司選取元件1
            // 
            this.公司選取元件1.Location = new System.Drawing.Point(64, 85);
            this.公司選取元件1.Name = "公司選取元件1";
            this.公司選取元件1.ReadOnly = true;
            this.公司選取元件1.SelectedItem = null;
            this.公司選取元件1.Size = new System.Drawing.Size(172, 25);
            this.公司選取元件1.TabIndex = 89;
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(64, 208);
            this.數量.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.數量.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.數量.Name = "數量";
            this.數量.Size = new System.Drawing.Size(167, 22);
            this.數量.TabIndex = 87;
            // 
            // 商品識別
            // 
            this.商品識別.Location = new System.Drawing.Point(64, 12);
            this.商品識別.Name = "商品識別";
            this.商品識別.ReadOnly = true;
            this.商品識別.Size = new System.Drawing.Size(400, 22);
            this.商品識別.TabIndex = 86;
            // 
            // 頁索引元件1
            // 
            this.頁索引元件1.Location = new System.Drawing.Point(130, 284);
            this.頁索引元件1.Name = "頁索引元件1";
            this.頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.頁索引元件1.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 83;
            this.label11.Text = "數量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 81;
            this.label8.Text = "含稅";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 80;
            this.label7.Text = "商品";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 79;
            this.label5.Text = "客戶";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 78;
            this.label4.Text = "公司";
            // 
            // 商品選取元件1
            // 
            this.商品選取元件1.Location = new System.Drawing.Point(64, 40);
            this.商品選取元件1.Name = "商品選取元件1";
            this.商品選取元件1.ReadOnly = false;
            this.商品選取元件1.SelectedItem = null;
            this.商品選取元件1.Size = new System.Drawing.Size(426, 27);
            this.商品選取元件1.TabIndex = 111;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 115;
            this.label14.Text = "成本";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(246, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 112;
            this.label15.Text = "利潤";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 119;
            this.label16.Text = "總金額";
            // 
            // 總利潤
            // 
            this.總利潤.DecimalPlaces = 3;
            this.總利潤.Location = new System.Drawing.Point(297, 240);
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
            this.總利潤.Size = new System.Drawing.Size(167, 22);
            this.總利潤.TabIndex = 118;
            // 
            // 總金額
            // 
            this.總金額.DecimalPlaces = 3;
            this.總金額.Location = new System.Drawing.Point(64, 240);
            this.總金額.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.總金額.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.總金額.Name = "總金額";
            this.總金額.ReadOnly = true;
            this.總金額.Size = new System.Drawing.Size(167, 22);
            this.總金額.TabIndex = 117;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(246, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 116;
            this.label17.Text = "總利潤";
            // 
            // 月結帳匯入詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 330);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.總利潤);
            this.Controls.Add(this.總金額);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.商品選取元件1);
            this.Controls.Add(this.利潤);
            this.Controls.Add(this.成本);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.含稅單價);
            this.Controls.Add(this.單價);
            this.Controls.Add(this.客戶選取元件1);
            this.Controls.Add(this.公司選取元件1);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.商品識別);
            this.Controls.Add(this.頁索引元件1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "月結帳匯入詳細視窗";
            this.Text = "月結帳匯入詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.利潤)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.含稅單價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.單價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.總利潤)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.總金額)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown 利潤;
        private System.Windows.Forms.NumericUpDown 成本;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown 含稅單價;
        private System.Windows.Forms.NumericUpDown 單價;
        private 客戶.客戶選取元件 客戶選取元件1;
        private 公司.公司選取元件 公司選取元件1;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.TextBox 商品識別;
        private 通用.頁索引元件 頁索引元件1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private 商品.商品選取元件 商品選取元件1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown 總利潤;
        private System.Windows.Forms.NumericUpDown 總金額;
        private System.Windows.Forms.Label label17;
    }
}