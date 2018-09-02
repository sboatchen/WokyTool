namespace WokyTool.使用者
{
    partial class 密碼修改視窗
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
            this.label2 = new System.Windows.Forms.Label();
            this.新密碼 = new System.Windows.Forms.TextBox();
            this.再次確認 = new System.Windows.Forms.TextBox();
            this.確認 = new System.Windows.Forms.Button();
            this.取消 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "新密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "再次確認";
            // 
            // 新密碼
            // 
            this.新密碼.Location = new System.Drawing.Point(82, 10);
            this.新密碼.Name = "新密碼";
            this.新密碼.PasswordChar = '*';
            this.新密碼.Size = new System.Drawing.Size(150, 22);
            this.新密碼.TabIndex = 2;
            // 
            // 再次確認
            // 
            this.再次確認.Location = new System.Drawing.Point(82, 38);
            this.再次確認.Name = "再次確認";
            this.再次確認.PasswordChar = '*';
            this.再次確認.Size = new System.Drawing.Size(150, 22);
            this.再次確認.TabIndex = 3;
            // 
            // 確認
            // 
            this.確認.Location = new System.Drawing.Point(49, 72);
            this.確認.Name = "確認";
            this.確認.Size = new System.Drawing.Size(75, 23);
            this.確認.TabIndex = 4;
            this.確認.Text = "確認";
            this.確認.UseVisualStyleBackColor = true;
            this.確認.Click += new System.EventHandler(this.確認_Click);
            // 
            // 取消
            // 
            this.取消.Location = new System.Drawing.Point(130, 72);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(75, 23);
            this.取消.TabIndex = 5;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // 密碼修改視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 107);
            this.ControlBox = false;
            this.Controls.Add(this.取消);
            this.Controls.Add(this.確認);
            this.Controls.Add(this.再次確認);
            this.Controls.Add(this.新密碼);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "密碼修改視窗";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密碼修改視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 新密碼;
        private System.Windows.Forms.TextBox 再次確認;
        private System.Windows.Forms.Button 確認;
        private System.Windows.Forms.Button 取消;
    }
}