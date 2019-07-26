namespace WokyTool.測試
{
    partial class 檔案測試視窗
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
            this.路徑測試 = new System.Windows.Forms.Button();
            this.CSV = new System.Windows.Forms.Button();
            this.CSV讀出 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 路徑測試
            // 
            this.路徑測試.Location = new System.Drawing.Point(12, 21);
            this.路徑測試.Name = "路徑測試";
            this.路徑測試.Size = new System.Drawing.Size(75, 23);
            this.路徑測試.TabIndex = 0;
            this.路徑測試.Text = "路徑測試";
            this.路徑測試.UseVisualStyleBackColor = true;
            this.路徑測試.Click += new System.EventHandler(this.路徑測試_Click);
            // 
            // CSV
            // 
            this.CSV.Location = new System.Drawing.Point(12, 63);
            this.CSV.Name = "CSV";
            this.CSV.Size = new System.Drawing.Size(75, 23);
            this.CSV.TabIndex = 1;
            this.CSV.Text = "CSV";
            this.CSV.UseVisualStyleBackColor = true;
            this.CSV.Click += new System.EventHandler(this.CSV_Click);
            // 
            // CSV讀出
            // 
            this.CSV讀出.Location = new System.Drawing.Point(93, 63);
            this.CSV讀出.Name = "CSV讀出";
            this.CSV讀出.Size = new System.Drawing.Size(75, 23);
            this.CSV讀出.TabIndex = 2;
            this.CSV讀出.Text = "CSV 讀出";
            this.CSV讀出.UseVisualStyleBackColor = true;
            this.CSV讀出.Click += new System.EventHandler(this.CSV讀出_Click);
            // 
            // 檔案測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CSV讀出);
            this.Controls.Add(this.CSV);
            this.Controls.Add(this.路徑測試);
            this.Name = "檔案測試視窗";
            this.Text = "檔案";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 路徑測試;
        private System.Windows.Forms.Button CSV;
        private System.Windows.Forms.Button CSV讀出;
    }
}