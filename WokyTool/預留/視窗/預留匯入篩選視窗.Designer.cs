using WokyTool.單品;
using WokyTool.通用;
namespace WokyTool.預留
{
    partial class 預留匯入篩選視窗
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
            this.姓名 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.名稱 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.最大預留日期 = new WokyTool.通用.MyDateTimePicker();
            this.最小預留日期 = new WokyTool.通用.MyDateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.單品 = new WokyTool.單品.單品選取元件();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(294, 74);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(165, 22);
            this.姓名.TabIndex = 172;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 171;
            this.label8.Text = "姓名";
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(59, 74);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(165, 22);
            this.名稱.TabIndex = 170;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 169;
            this.label6.Text = "名稱";
            // 
            // 最大預留日期
            // 
            this.最大預留日期.CustomFormat = " ";
            this.最大預留日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.最大預留日期.Location = new System.Drawing.Point(59, 39);
            this.最大預留日期.Name = "最大預留日期";
            this.最大預留日期.Size = new System.Drawing.Size(165, 22);
            this.最大預留日期.TabIndex = 168;
            this.最大預留日期.Value = new System.DateTime(((long)(0)));
            this.最大預留日期.類型 = WokyTool.通用.MyDateTimePicker.時間類型.最大值;
            // 
            // 最小預留日期
            // 
            this.最小預留日期.CustomFormat = " ";
            this.最小預留日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.最小預留日期.Location = new System.Drawing.Point(59, 11);
            this.最小預留日期.Name = "最小預留日期";
            this.最小預留日期.Size = new System.Drawing.Size(165, 22);
            this.最小預留日期.TabIndex = 166;
            this.最小預留日期.Value = new System.DateTime(((long)(0)));
            this.最小預留日期.類型 = WokyTool.通用.MyDateTimePicker.時間類型.最小值;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 165;
            this.label7.Text = "預留日期";
            // 
            // 單品
            // 
            this.單品.Location = new System.Drawing.Point(59, 103);
            this.單品.Name = "單品";
            this.單品.ReadOnly = false;
            this.單品.SelectedItem = null;
            this.單品.Size = new System.Drawing.Size(420, 22);
            this.單品.TabIndex = 164;
            this.單品.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(59, 130);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 163;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 162;
            this.label17.Text = "備註";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 159;
            this.label4.Text = "單品";
            // 
            // 預留匯入篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 159);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.最大預留日期);
            this.Controls.Add(this.最小預留日期);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.單品);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Name = "預留匯入篩選視窗";
            this.Text = "預留匯入篩選視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.Label label6;
        private MyDateTimePicker 最大預留日期;
        private MyDateTimePicker 最小預留日期;
        private System.Windows.Forms.Label label7;
        private 單品選取元件 單品;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;


    }
}