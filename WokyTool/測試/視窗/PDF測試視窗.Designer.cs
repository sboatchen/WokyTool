namespace WokyTool.測試
{
    partial class PDF測試視窗
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
            this.定位 = new System.Windows.Forms.Button();
            this.位移 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 定位
            // 
            this.定位.Location = new System.Drawing.Point(23, 29);
            this.定位.Name = "定位";
            this.定位.Size = new System.Drawing.Size(75, 23);
            this.定位.TabIndex = 0;
            this.定位.Text = "定位";
            this.定位.UseVisualStyleBackColor = true;
            this.定位.Click += new System.EventHandler(this.定位_Click);
            // 
            // 位移
            // 
            this.位移.Location = new System.Drawing.Point(23, 70);
            this.位移.Name = "位移";
            this.位移.Size = new System.Drawing.Size(75, 23);
            this.位移.TabIndex = 1;
            this.位移.Text = "位移";
            this.位移.UseVisualStyleBackColor = true;
            this.位移.Click += new System.EventHandler(this.位移_Click);
            // 
            // PDF測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.位移);
            this.Controls.Add(this.定位);
            this.Name = "PDF測試視窗";
            this.Text = "PDF測試視窗";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 定位;
        private System.Windows.Forms.Button 位移;
    }
}