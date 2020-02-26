namespace WokyTool.單品
{
    partial class 單品篩選視窗
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
            this.類別 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.品牌 = new WokyTool.單品.品牌選取元件();
            this.供應商 = new WokyTool.單品.供應商選取元件();
            this.品類 = new WokyTool.單品.品類選取元件();
            this.最小庫存 = new System.Windows.Forms.NumericUpDown();
            this.國際條碼 = new System.Windows.Forms.TextBox();
            this.顏色 = new System.Windows.Forms.TextBox();
            this.名稱 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.最大庫存 = new System.Windows.Forms.NumericUpDown();
            this.儲位 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.最小庫存)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.最大庫存)).BeginInit();
            this.SuspendLayout();
            // 
            // 類別
            // 
            this.類別.Location = new System.Drawing.Point(293, 82);
            this.類別.Name = "類別";
            this.類別.Size = new System.Drawing.Size(165, 22);
            this.類別.TabIndex = 88;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(247, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 87;
            this.label16.Text = "類別";
            // 
            // 品牌
            // 
            this.品牌.Location = new System.Drawing.Point(58, 137);
            this.品牌.Margin = new System.Windows.Forms.Padding(4);
            this.品牌.Name = "品牌";
            this.品牌.ReadOnly = false;
            this.品牌.SelectedItem = null;
            this.品牌.Size = new System.Drawing.Size(172, 25);
            this.品牌.TabIndex = 86;
            this.品牌.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 供應商
            // 
            this.供應商.Location = new System.Drawing.Point(58, 109);
            this.供應商.Margin = new System.Windows.Forms.Padding(4);
            this.供應商.Name = "供應商";
            this.供應商.ReadOnly = false;
            this.供應商.SelectedItem = null;
            this.供應商.Size = new System.Drawing.Size(172, 25);
            this.供應商.TabIndex = 85;
            this.供應商.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 品類
            // 
            this.品類.Location = new System.Drawing.Point(58, 82);
            this.品類.Margin = new System.Windows.Forms.Padding(4);
            this.品類.Name = "品類";
            this.品類.ReadOnly = false;
            this.品類.SelectedItem = null;
            this.品類.Size = new System.Drawing.Size(172, 25);
            this.品類.TabIndex = 84;
            this.品類.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 最小庫存
            // 
            this.最小庫存.Location = new System.Drawing.Point(58, 180);
            this.最小庫存.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.最小庫存.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.最小庫存.Name = "最小庫存";
            this.最小庫存.Size = new System.Drawing.Size(80, 22);
            this.最小庫存.TabIndex = 83;
            // 
            // 國際條碼
            // 
            this.國際條碼.Location = new System.Drawing.Point(58, 47);
            this.國際條碼.Name = "國際條碼";
            this.國際條碼.Size = new System.Drawing.Size(165, 22);
            this.國際條碼.TabIndex = 76;
            // 
            // 顏色
            // 
            this.顏色.Location = new System.Drawing.Point(293, 110);
            this.顏色.Name = "顏色";
            this.顏色.Size = new System.Drawing.Size(165, 22);
            this.顏色.TabIndex = 74;
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(58, 12);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(400, 22);
            this.名稱.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 67;
            this.label11.Text = "庫存";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 66;
            this.label10.Text = "顏色";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 63;
            this.label7.Text = "名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 60;
            this.label4.Text = "國際條碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 59;
            this.label3.Text = "品牌";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 58;
            this.label2.Text = "供應商";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 57;
            this.label1.Text = "品類";
            // 
            // 最大庫存
            // 
            this.最大庫存.Location = new System.Drawing.Point(143, 180);
            this.最大庫存.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.最大庫存.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.最大庫存.Name = "最大庫存";
            this.最大庫存.Size = new System.Drawing.Size(80, 22);
            this.最大庫存.TabIndex = 89;
            // 
            // 儲位
            // 
            this.儲位.Location = new System.Drawing.Point(58, 208);
            this.儲位.Name = "儲位";
            this.儲位.Size = new System.Drawing.Size(165, 22);
            this.儲位.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 90;
            this.label5.Text = "儲位";
            // 
            // 單品篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 241);
            this.Controls.Add(this.儲位);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.最大庫存);
            this.Controls.Add(this.類別);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.品牌);
            this.Controls.Add(this.供應商);
            this.Controls.Add(this.品類);
            this.Controls.Add(this.最小庫存);
            this.Controls.Add(this.國際條碼);
            this.Controls.Add(this.顏色);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "單品篩選視窗";
            this.Text = "單品篩選視窗";
            ((System.ComponentModel.ISupportInitialize)(this.最小庫存)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.最大庫存)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 類別;
        private System.Windows.Forms.Label label16;
        private 品牌選取元件 品牌;
        private 供應商選取元件 供應商;
        private 品類選取元件 品類;
        private System.Windows.Forms.NumericUpDown 最小庫存;
        private System.Windows.Forms.TextBox 國際條碼;
        private System.Windows.Forms.TextBox 顏色;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown 最大庫存;
        private System.Windows.Forms.TextBox 儲位;
        private System.Windows.Forms.Label label5;

    }
}