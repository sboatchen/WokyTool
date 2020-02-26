using WokyTool.單品;
using WokyTool.通用;
namespace WokyTool.盤點
{
    partial class 盤點更新篩選視窗
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
            this.更新狀態 = new WokyTool.通用.更新狀態選取元件();
            this.單品 = new WokyTool.單品.單品選取元件();
            this.備註 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 更新狀態
            // 
            this.更新狀態.Location = new System.Drawing.Point(3, 9);
            this.更新狀態.Name = "更新狀態";
            this.更新狀態.ReadOnly = false;
            this.更新狀態.SelectedItem = WokyTool.通用.列舉.更新狀態.不篩選;
            this.更新狀態.Size = new System.Drawing.Size(230, 22);
            this.更新狀態.TabIndex = 80;
            this.更新狀態.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 單品
            // 
            this.單品.Location = new System.Drawing.Point(58, 39);
            this.單品.Name = "單品";
            this.單品.ReadOnly = false;
            this.單品.SelectedItem = null;
            this.單品.Size = new System.Drawing.Size(427, 30);
            this.單品.TabIndex = 79;
            this.單品.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 備註
            // 
            this.備註.Location = new System.Drawing.Point(58, 70);
            this.備註.Name = "備註";
            this.備註.Size = new System.Drawing.Size(400, 22);
            this.備註.TabIndex = 78;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 77;
            this.label17.Text = "備註";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "單品";
            // 
            // 盤點更新篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(480, 107);
            this.Controls.Add(this.更新狀態);
            this.Controls.Add(this.單品);
            this.Controls.Add(this.備註);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Name = "盤點更新篩選視窗";
            this.Text = "盤點更新篩選視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 備註;
        private System.Windows.Forms.Label label17;
        private 單品選取元件 單品;
        private 更新狀態選取元件 更新狀態;
    }
}