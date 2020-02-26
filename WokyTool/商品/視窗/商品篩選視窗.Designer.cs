namespace WokyTool.商品
{
    partial class 商品篩選視窗
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
            this.最大利潤 = new System.Windows.Forms.NumericUpDown();
            this.最大寄庫數量 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.最小利潤 = new System.Windows.Forms.NumericUpDown();
            this.最小寄庫數量 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.品號 = new System.Windows.Forms.TextBox();
            this.名稱 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.品牌 = new WokyTool.物品.品牌選取元件();
            this.小類 = new WokyTool.商品.商品小類選取元件();
            this.物品 = new WokyTool.物品.物品選取元件();
            this.客戶 = new WokyTool.客戶.客戶選取元件();
            this.公司 = new WokyTool.公司.公司選取元件();
            this.大類 = new WokyTool.商品.商品大類選取元件();
            ((System.ComponentModel.ISupportInitialize)(this.最大利潤)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.最大寄庫數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.最小利潤)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.最小寄庫數量)).BeginInit();
            this.SuspendLayout();
            // 
            // 最大利潤
            // 
            this.最大利潤.DecimalPlaces = 3;
            this.最大利潤.Location = new System.Drawing.Point(378, 208);
            this.最大利潤.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.最大利潤.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.最大利潤.Name = "最大利潤";
            this.最大利潤.Size = new System.Drawing.Size(80, 22);
            this.最大利潤.TabIndex = 96;
            this.最大利潤.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // 最大寄庫數量
            // 
            this.最大寄庫數量.Location = new System.Drawing.Point(143, 207);
            this.最大寄庫數量.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.最大寄庫數量.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.最大寄庫數量.Name = "最大寄庫數量";
            this.最大寄庫數量.Size = new System.Drawing.Size(80, 22);
            this.最大寄庫數量.TabIndex = 95;
            this.最大寄庫數量.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 94;
            this.label15.Text = "品牌";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 75;
            this.label12.Text = "利潤";
            // 
            // 最小利潤
            // 
            this.最小利潤.DecimalPlaces = 3;
            this.最小利潤.Location = new System.Drawing.Point(293, 209);
            this.最小利潤.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.最小利潤.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.最小利潤.Name = "最小利潤";
            this.最小利潤.Size = new System.Drawing.Size(80, 22);
            this.最小利潤.TabIndex = 74;
            this.最小利潤.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // 最小寄庫數量
            // 
            this.最小寄庫數量.Location = new System.Drawing.Point(58, 207);
            this.最小寄庫數量.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.最小寄庫數量.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.最小寄庫數量.Name = "最小寄庫數量";
            this.最小寄庫數量.Size = new System.Drawing.Size(80, 22);
            this.最小寄庫數量.TabIndex = 66;
            this.最小寄庫數量.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 65;
            this.label3.Text = "寄庫數量";
            // 
            // 品號
            // 
            this.品號.Location = new System.Drawing.Point(58, 38);
            this.品號.Name = "品號";
            this.品號.Size = new System.Drawing.Size(165, 22);
            this.品號.TabIndex = 35;
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(58, 10);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(400, 22);
            this.名稱.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "需求";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "品號";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "名稱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "客戶";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "公司";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "小類";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "大類";
            // 
            // 品牌
            // 
            this.品牌.Location = new System.Drawing.Point(58, 128);
            this.品牌.Margin = new System.Windows.Forms.Padding(4);
            this.品牌.Name = "品牌";
            this.品牌.ReadOnly = false;
            this.品牌.SelectedItem = null;
            this.品牌.Size = new System.Drawing.Size(172, 25);
            this.品牌.TabIndex = 93;
            this.品牌.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 小類
            // 
            this.小類.Location = new System.Drawing.Point(58, 101);
            this.小類.Margin = new System.Windows.Forms.Padding(4);
            this.小類.Name = "小類";
            this.小類.ReadOnly = false;
            this.小類.SelectedItem = null;
            this.小類.Size = new System.Drawing.Size(172, 25);
            this.小類.TabIndex = 69;
            this.小類.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 物品
            // 
            this.物品.Location = new System.Drawing.Point(58, 176);
            this.物品.Margin = new System.Windows.Forms.Padding(4);
            this.物品.Name = "物品";
            this.物品.ReadOnly = false;
            this.物品.SelectedItem = null;
            this.物品.Size = new System.Drawing.Size(420, 25);
            this.物品.TabIndex = 56;
            this.物品.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 客戶
            // 
            this.客戶.Location = new System.Drawing.Point(293, 101);
            this.客戶.Margin = new System.Windows.Forms.Padding(4);
            this.客戶.Name = "客戶";
            this.客戶.ReadOnly = false;
            this.客戶.SelectedItem = null;
            this.客戶.Size = new System.Drawing.Size(182, 25);
            this.客戶.TabIndex = 55;
            this.客戶.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 公司
            // 
            this.公司.Location = new System.Drawing.Point(293, 74);
            this.公司.Margin = new System.Windows.Forms.Padding(4);
            this.公司.Name = "公司";
            this.公司.ReadOnly = false;
            this.公司.SelectedItem = null;
            this.公司.Size = new System.Drawing.Size(172, 25);
            this.公司.TabIndex = 54;
            this.公司.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 大類
            // 
            this.大類.Location = new System.Drawing.Point(58, 74);
            this.大類.Margin = new System.Windows.Forms.Padding(4);
            this.大類.Name = "大類";
            this.大類.ReadOnly = false;
            this.大類.SelectedItem = null;
            this.大類.Size = new System.Drawing.Size(172, 25);
            this.大類.TabIndex = 52;
            this.大類.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 商品篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 244);
            this.Controls.Add(this.最大利潤);
            this.Controls.Add(this.最大寄庫數量);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.品牌);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.最小利潤);
            this.Controls.Add(this.小類);
            this.Controls.Add(this.最小寄庫數量);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.物品);
            this.Controls.Add(this.客戶);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.大類);
            this.Controls.Add(this.品號);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "商品篩選視窗";
            this.Text = "商品篩選視窗";
            ((System.ComponentModel.ISupportInitialize)(this.最大利潤)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.最大寄庫數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.最小利潤)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.最小寄庫數量)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.TextBox 品號;
        private 商品大類選取元件 大類;
        private 公司.公司選取元件 公司;
        private 客戶.客戶選取元件 客戶;
        private 物品.物品選取元件 物品;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown 最小寄庫數量;
        private 商品小類選取元件 小類;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown 最小利潤;
        private 物品.品牌選取元件 品牌;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown 最大寄庫數量;
        private System.Windows.Forms.NumericUpDown 最大利潤;
    }
}