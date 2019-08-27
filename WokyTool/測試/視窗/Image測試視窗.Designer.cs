namespace WokyTool.測試
{
    partial class Image測試視窗
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
            this.字串 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 字串
            // 
            this.字串.Location = new System.Drawing.Point(13, 26);
            this.字串.Name = "字串";
            this.字串.Size = new System.Drawing.Size(75, 23);
            this.字串.TabIndex = 0;
            this.字串.Text = "字串";
            this.字串.UseVisualStyleBackColor = true;
            this.字串.Click += new System.EventHandler(this.字串_Click);
            // 
            // Image測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.字串);
            this.Name = "Image測試視窗";
            this.Text = "Image測試視窗";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 字串;
    }
}