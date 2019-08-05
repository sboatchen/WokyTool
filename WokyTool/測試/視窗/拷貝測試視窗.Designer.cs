namespace WokyTool.測試
{
    partial class 拷貝測試視窗
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
            this.拷貝 = new System.Windows.Forms.Button();
            this.屬性 = new System.Windows.Forms.Button();
            this.位元組 = new System.Windows.Forms.Button();
            this.完全拷貝 = new System.Windows.Forms.Button();
            this.編輯測試 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 拷貝
            // 
            this.拷貝.Location = new System.Drawing.Point(16, 21);
            this.拷貝.Margin = new System.Windows.Forms.Padding(2);
            this.拷貝.Name = "拷貝";
            this.拷貝.Size = new System.Drawing.Size(56, 26);
            this.拷貝.TabIndex = 0;
            this.拷貝.Text = "拷貝";
            this.拷貝.UseVisualStyleBackColor = true;
            this.拷貝.Click += new System.EventHandler(this.拷貝_Click);
            // 
            // 屬性
            // 
            this.屬性.Location = new System.Drawing.Point(16, 51);
            this.屬性.Margin = new System.Windows.Forms.Padding(2);
            this.屬性.Name = "屬性";
            this.屬性.Size = new System.Drawing.Size(56, 25);
            this.屬性.TabIndex = 1;
            this.屬性.Text = "屬性";
            this.屬性.UseVisualStyleBackColor = true;
            this.屬性.Click += new System.EventHandler(this.屬性_Click);
            // 
            // 位元組
            // 
            this.位元組.Location = new System.Drawing.Point(16, 80);
            this.位元組.Margin = new System.Windows.Forms.Padding(2);
            this.位元組.Name = "位元組";
            this.位元組.Size = new System.Drawing.Size(56, 26);
            this.位元組.TabIndex = 2;
            this.位元組.Text = "位元組";
            this.位元組.UseVisualStyleBackColor = true;
            this.位元組.Click += new System.EventHandler(this.位元組_Click);
            // 
            // 完全拷貝
            // 
            this.完全拷貝.Location = new System.Drawing.Point(16, 110);
            this.完全拷貝.Margin = new System.Windows.Forms.Padding(2);
            this.完全拷貝.Name = "完全拷貝";
            this.完全拷貝.Size = new System.Drawing.Size(68, 26);
            this.完全拷貝.TabIndex = 3;
            this.完全拷貝.Text = "完全拷貝";
            this.完全拷貝.UseVisualStyleBackColor = true;
            this.完全拷貝.Click += new System.EventHandler(this.完全拷貝_Click);
            // 
            // 編輯測試
            // 
            this.編輯測試.Location = new System.Drawing.Point(117, 21);
            this.編輯測試.Margin = new System.Windows.Forms.Padding(2);
            this.編輯測試.Name = "編輯測試";
            this.編輯測試.Size = new System.Drawing.Size(68, 26);
            this.編輯測試.TabIndex = 4;
            this.編輯測試.Text = "編輯測試";
            this.編輯測試.UseVisualStyleBackColor = true;
            this.編輯測試.Click += new System.EventHandler(this.編輯測試_Click);
            // 
            // 拷貝測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 202);
            this.Controls.Add(this.編輯測試);
            this.Controls.Add(this.完全拷貝);
            this.Controls.Add(this.位元組);
            this.Controls.Add(this.屬性);
            this.Controls.Add(this.拷貝);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "拷貝測試視窗";
            this.Text = "拷貝測試視窗";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 拷貝;
        private System.Windows.Forms.Button 屬性;
        private System.Windows.Forms.Button 位元組;
        private System.Windows.Forms.Button 完全拷貝;
        private System.Windows.Forms.Button 編輯測試;
    }
}