using WokyTool.物品;
using WokyTool.通用;
namespace WokyTool.預留
{
    partial class 預留篩選視窗
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
            this.label1 = new System.Windows.Forms.Label();
            this.最大預留日期 = new WokyTool.通用.MyDateTimePicker();
            this.最小預留日期 = new WokyTool.通用.MyDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.物品 = new WokyTool.物品.物品選取元件();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(294, 47);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(165, 22);
            this.姓名.TabIndex = 183;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 182;
            this.label8.Text = "姓名";
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(59, 47);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(165, 22);
            this.名稱.TabIndex = 181;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 180;
            this.label1.Text = "名稱";
            // 
            // 最大預留日期
            // 
            this.最大預留日期.CustomFormat = "yyyy-MM-dd";
            this.最大預留日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.最大預留日期.Location = new System.Drawing.Point(144, 8);
            this.最大預留日期.Name = "最大預留日期";
            this.最大預留日期.Size = new System.Drawing.Size(80, 22);
            this.最大預留日期.TabIndex = 179;
            this.最大預留日期.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 752);
            // 
            // 最小預留日期
            // 
            this.最小預留日期.CustomFormat = "yyyy-MM-dd";
            this.最小預留日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.最小預留日期.Location = new System.Drawing.Point(59, 8);
            this.最小預留日期.Name = "最小預留日期";
            this.最小預留日期.Size = new System.Drawing.Size(80, 22);
            this.最小預留日期.TabIndex = 178;
            this.最小預留日期.Value = new System.DateTime(2019, 9, 9, 11, 55, 19, 752);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 177;
            this.label3.Text = "預留日期";
            // 
            // 物品
            // 
            this.物品.Location = new System.Drawing.Point(59, 76);
            this.物品.Name = "物品";
            this.物品.ReadOnly = false;
            this.物品.SelectedItem = null;
            this.物品.Size = new System.Drawing.Size(420, 22);
            this.物品.TabIndex = 176;
            this.物品.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(59, 103);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 175;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 174;
            this.label17.Text = "備註";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 173;
            this.label4.Text = "物品";
            // 
            // 預留篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 133);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.最大預留日期);
            this.Controls.Add(this.最小預留日期);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.物品);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Name = "預留篩選視窗";
            this.Text = "預留篩選視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.Label label1;
        private MyDateTimePicker 最大預留日期;
        private MyDateTimePicker 最小預留日期;
        private System.Windows.Forms.Label label3;
        private 物品選取元件 物品;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;



    }
}