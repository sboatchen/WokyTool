namespace WokyTool.測試
{
    partial class 合法性測試視窗
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
            this.例外 = new System.Windows.Forms.Button();
            this.列表 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 例外
            // 
            this.例外.Location = new System.Drawing.Point(27, 23);
            this.例外.Name = "例外";
            this.例外.Size = new System.Drawing.Size(75, 23);
            this.例外.TabIndex = 0;
            this.例外.Text = "例外";
            this.例外.UseVisualStyleBackColor = true;
            this.例外.Click += new System.EventHandler(this.例外_Click);
            // 
            // 列表
            // 
            this.列表.Location = new System.Drawing.Point(27, 64);
            this.列表.Name = "列表";
            this.列表.Size = new System.Drawing.Size(75, 23);
            this.列表.TabIndex = 1;
            this.列表.Text = "列表";
            this.列表.UseVisualStyleBackColor = true;
            this.列表.Click += new System.EventHandler(this.列表_Click);
            // 
            // 合法性測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.列表);
            this.Controls.Add(this.例外);
            this.Name = "合法性測試視窗";
            this.Text = "合法性測試視窗";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 例外;
        private System.Windows.Forms.Button 列表;
    }
}