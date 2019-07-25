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
            this.SuspendLayout();
            // 
            // 路徑測試
            // 
            this.路徑測試.Location = new System.Drawing.Point(16, 26);
            this.路徑測試.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.路徑測試.Name = "路徑測試";
            this.路徑測試.Size = new System.Drawing.Size(100, 29);
            this.路徑測試.TabIndex = 0;
            this.路徑測試.Text = "路徑測試";
            this.路徑測試.UseVisualStyleBackColor = true;
            this.路徑測試.Click += new System.EventHandler(this.路徑測試_Click);
            // 
            // 檔案測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 326);
            this.Controls.Add(this.路徑測試);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "檔案測試視窗";
            this.Text = "檔案";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 路徑測試;
    }
}