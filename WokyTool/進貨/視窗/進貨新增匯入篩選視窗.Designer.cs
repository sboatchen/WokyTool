using WokyTool.物品;
using WokyTool.通用;
namespace WokyTool.進貨
{
    partial class 進貨新增匯入篩選視窗
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
            this.物品 = new WokyTool.物品.物品選取元件();
            this.廠商 = new WokyTool.廠商.廠商選取元件();
            this.類型 = new WokyTool.通用.進貨類型選取元件();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 物品
            // 
            this.物品.Location = new System.Drawing.Point(59, 65);
            this.物品.Name = "物品";
            this.物品.ReadOnly = false;
            this.物品.SelectedItem = null;
            this.物品.Size = new System.Drawing.Size(420, 22);
            this.物品.TabIndex = 135;
            this.物品.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 廠商
            // 
            this.廠商.Location = new System.Drawing.Point(59, 37);
            this.廠商.Name = "廠商";
            this.廠商.ReadOnly = false;
            this.廠商.SelectedItem = null;
            this.廠商.Size = new System.Drawing.Size(172, 22);
            this.廠商.TabIndex = 134;
            this.廠商.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 類型
            // 
            this.類型.Location = new System.Drawing.Point(4, 10);
            this.類型.Name = "類型";
            this.類型.ReadOnly = false;
            this.類型.SelectedItem = WokyTool.通用.列舉.進貨類型.不篩選;
            this.類型.Size = new System.Drawing.Size(230, 22);
            this.類型.TabIndex = 133;
            this.類型.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(59, 94);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 129;
            this.label2.Text = "備註";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 126;
            this.label6.Text = "物品";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 125;
            this.label7.Text = "廠商";
            // 
            // 進貨新增匯入篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(483, 126);
            this.Controls.Add(this.物品);
            this.Controls.Add(this.廠商);
            this.Controls.Add(this.類型);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "進貨新增匯入篩選視窗";
            this.Text = "寄庫匯入篩選視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 物品選取元件 物品;
        private 廠商.廠商選取元件 廠商;
        private 進貨類型選取元件 類型;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

    }
}