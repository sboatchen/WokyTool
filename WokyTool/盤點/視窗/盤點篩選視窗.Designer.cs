using WokyTool.單品;
using WokyTool.通用;
namespace WokyTool.盤點
{
    partial class 盤點篩選視窗
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
            this.label3 = new System.Windows.Forms.Label();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.單品 = new WokyTool.單品.單品選取元件();
            this.是否一致 = new WokyTool.通用.布林狀態選取元件();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "單品";
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(58, 41);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 77;
            this.label17.Text = "備註";
            // 
            // 單品
            // 
            this.單品.Location = new System.Drawing.Point(58, 10);
            this.單品.Name = "單品";
            this.單品.ReadOnly = false;
            this.單品.SelectedItem = null;
            this.單品.Size = new System.Drawing.Size(427, 30);
            this.單品.TabIndex = 79;
            this.單品.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 是否一致
            // 
            this.是否一致.Location = new System.Drawing.Point(3, 74);
            this.是否一致.Name = "是否一致";
            this.是否一致.ReadOnly = false;
            this.是否一致.SelectedItem = WokyTool.通用.列舉.布林狀態.不篩選;
            this.是否一致.Size = new System.Drawing.Size(230, 22);
            this.是否一致.TabIndex = 80;
            this.是否一致.元件類型 = WokyTool.通用.選取元件類型.篩選;
            this.是否一致.名稱 = "是否一致";
            // 
            // 盤點篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(480, 103);
            this.Controls.Add(this.是否一致);
            this.Controls.Add(this.單品);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Name = "盤點篩選視窗";
            this.Text = "盤點篩選視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private 單品選取元件 單品;
        private 布林狀態選取元件 是否一致;
    }
}