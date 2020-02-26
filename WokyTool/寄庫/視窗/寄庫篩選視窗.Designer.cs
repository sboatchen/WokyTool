using WokyTool.單品;
using WokyTool.通用;
namespace WokyTool.寄庫
{
    partial class 寄庫篩選視窗
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
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.最小處理時間 = new WokyTool.通用.MyDateTimePicker();
            this.公司 = new WokyTool.公司.公司選取元件();
            this.客戶 = new WokyTool.客戶.客戶選取元件();
            this.label4 = new System.Windows.Forms.Label();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.入庫單號 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.最大處理時間 = new WokyTool.通用.MyDateTimePicker();
            this.商品 = new WokyTool.商品.商品選取元件();
            this.處理者 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客戶";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "公司";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "處理時間";
            // 
            // 最小處理時間
            // 
            this.最小處理時間.CustomFormat = " ";
            this.最小處理時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.最小處理時間.Location = new System.Drawing.Point(58, 12);
            this.最小處理時間.Name = "最小處理時間";
            this.最小處理時間.Size = new System.Drawing.Size(165, 22);
            this.最小處理時間.TabIndex = 58;
            this.最小處理時間.Value = new System.DateTime(((long)(0)));
            this.最小處理時間.類型 = WokyTool.通用.MyDateTimePicker.時間類型.最小值;
            // 
            // 公司
            // 
            this.公司.Location = new System.Drawing.Point(58, 78);
            this.公司.Margin = new System.Windows.Forms.Padding(4);
            this.公司.Name = "公司";
            this.公司.ReadOnly = false;
            this.公司.SelectedItem = null;
            this.公司.Size = new System.Drawing.Size(173, 25);
            this.公司.TabIndex = 60;
            this.公司.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 客戶
            // 
            this.客戶.Location = new System.Drawing.Point(293, 78);
            this.客戶.Margin = new System.Windows.Forms.Padding(4);
            this.客戶.Name = "客戶";
            this.客戶.ReadOnly = false;
            this.客戶.SelectedItem = null;
            this.客戶.Size = new System.Drawing.Size(186, 25);
            this.客戶.TabIndex = 61;
            this.客戶.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "商品";
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(58, 172);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 77;
            this.label17.Text = "備註";
            // 
            // 入庫單號
            // 
            this.入庫單號.Location = new System.Drawing.Point(58, 144);
            this.入庫單號.Name = "入庫單號";
            this.入庫單號.Size = new System.Drawing.Size(165, 22);
            this.入庫單號.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 80;
            this.label9.Text = "入庫單號";
            // 
            // 最大處理時間
            // 
            this.最大處理時間.CustomFormat = " ";
            this.最大處理時間.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.最大處理時間.Location = new System.Drawing.Point(58, 40);
            this.最大處理時間.Name = "最大處理時間";
            this.最大處理時間.Size = new System.Drawing.Size(165, 22);
            this.最大處理時間.TabIndex = 119;
            this.最大處理時間.Value = new System.DateTime(((long)(0)));
            this.最大處理時間.類型 = WokyTool.通用.MyDateTimePicker.時間類型.最大值;
            // 
            // 商品
            // 
            this.商品.Location = new System.Drawing.Point(58, 105);
            this.商品.Name = "商品";
            this.商品.ReadOnly = false;
            this.商品.SelectedItem = null;
            this.商品.Size = new System.Drawing.Size(420, 22);
            this.商品.TabIndex = 124;
            this.商品.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 處理者
            // 
            this.處理者.Location = new System.Drawing.Point(293, 12);
            this.處理者.Name = "處理者";
            this.處理者.Size = new System.Drawing.Size(165, 22);
            this.處理者.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 125;
            this.label2.Text = "處理者";
            // 
            // 寄庫篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 205);
            this.Controls.Add(this.處理者);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.商品);
            this.Controls.Add(this.最大處理時間);
            this.Controls.Add(this.入庫單號);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.客戶);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.最小處理時間);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "寄庫篩選視窗";
            this.Text = "寄庫篩選視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private MyDateTimePicker 最小處理時間;
        private 公司.公司選取元件 公司;
        private 客戶.客戶選取元件 客戶;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox 入庫單號;
        private System.Windows.Forms.Label label9;
        private MyDateTimePicker 最大處理時間;
        private 商品.商品選取元件 商品;
        private System.Windows.Forms.TextBox 處理者;
        private System.Windows.Forms.Label label2;
    }
}