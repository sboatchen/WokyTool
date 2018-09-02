namespace WokyTool.使用者
{
    partial class 登入視窗
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
            this.確認 = new System.Windows.Forms.Button();
            this.密碼 = new System.Windows.Forms.TextBox();
            this.使用者 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 確認
            // 
            this.確認.Location = new System.Drawing.Point(105, 71);
            this.確認.Name = "確認";
            this.確認.Size = new System.Drawing.Size(75, 23);
            this.確認.TabIndex = 10;
            this.確認.Text = "確認";
            this.確認.UseVisualStyleBackColor = true;
            this.確認.Click += new System.EventHandler(this.確認_Click);
            // 
            // 密碼
            // 
            this.密碼.Location = new System.Drawing.Point(84, 40);
            this.密碼.Name = "密碼";
            this.密碼.PasswordChar = '*';
            this.密碼.Size = new System.Drawing.Size(150, 22);
            this.密碼.TabIndex = 9;
            // 
            // 使用者
            // 
            this.使用者.Location = new System.Drawing.Point(84, 12);
            this.使用者.Name = "使用者";
            this.使用者.Size = new System.Drawing.Size(150, 22);
            this.使用者.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "密碼";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "使用者";
            // 
            // 登入視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.確認);
            this.Controls.Add(this.密碼);
            this.Controls.Add(this.使用者);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "登入視窗";
            this.Text = "登入視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 確認;
        private System.Windows.Forms.TextBox 密碼;
        private System.Windows.Forms.TextBox 使用者;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}