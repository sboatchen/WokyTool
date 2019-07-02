using WokyTool.商品;
namespace WokyTool.月結帳
{
    partial class 月結帳篩選視窗
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.公司選取元件1 = new WokyTool.公司.公司選取元件();
            this.客戶選取元件1 = new WokyTool.客戶.客戶選取元件();
            this.篩選 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "公司";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "客戶";
            // 
            // 公司選取元件1
            // 
            this.公司選取元件1.Location = new System.Drawing.Point(53, 12);
            this.公司選取元件1.Name = "公司選取元件1";
            this.公司選取元件1.ReadOnly = false;
            this.公司選取元件1.SelectedItem = null;
            this.公司選取元件1.Size = new System.Drawing.Size(172, 25);
            this.公司選取元件1.TabIndex = 54;
            // 
            // 客戶選取元件1
            // 
            this.客戶選取元件1.Location = new System.Drawing.Point(53, 43);
            this.客戶選取元件1.Name = "客戶選取元件1";
            this.客戶選取元件1.ReadOnly = false;
            this.客戶選取元件1.SelectedItem = null;
            this.客戶選取元件1.Size = new System.Drawing.Size(182, 25);
            this.客戶選取元件1.TabIndex = 55;
            // 
            // 篩選
            // 
            this.篩選.Location = new System.Drawing.Point(82, 75);
            this.篩選.Name = "篩選";
            this.篩選.Size = new System.Drawing.Size(75, 23);
            this.篩選.TabIndex = 76;
            this.篩選.Text = "篩選";
            this.篩選.UseVisualStyleBackColor = true;
            this.篩選.Click += new System.EventHandler(this.篩選_Click);
            // 
            // 月結帳篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 118);
            this.Controls.Add(this.篩選);
            this.Controls.Add(this.客戶選取元件1);
            this.Controls.Add(this.公司選取元件1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "月結帳篩選視窗";
            this.Text = "商品篩選視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private 公司.公司選取元件 公司選取元件1;
        private 客戶.客戶選取元件 客戶選取元件1;
        private System.Windows.Forms.Button 篩選;
    }
}