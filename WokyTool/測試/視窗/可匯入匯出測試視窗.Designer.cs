namespace WokyTool.測試
{
    partial class 可匯入匯出測試視窗
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
            this.屬性取得 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 屬性取得
            // 
            this.屬性取得.Location = new System.Drawing.Point(13, 13);
            this.屬性取得.Name = "屬性取得";
            this.屬性取得.Size = new System.Drawing.Size(75, 23);
            this.屬性取得.TabIndex = 0;
            this.屬性取得.Text = "屬性取得";
            this.屬性取得.UseVisualStyleBackColor = true;
            this.屬性取得.Click += new System.EventHandler(this.屬性取得_Click);
            // 
            // 可匯入匯出測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.屬性取得);
            this.Name = "可匯入匯出測試視窗";
            this.Text = "可匯入匯出測試視窗";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 屬性取得;
    }
}