namespace WokyTool.通用
{
    partial class 頁索引元件
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.上一頁 = new System.Windows.Forms.Button();
            this.下一頁 = new System.Windows.Forms.Button();
            this.索引 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 上一頁
            // 
            this.上一頁.Location = new System.Drawing.Point(3, 3);
            this.上一頁.Name = "上一頁";
            this.上一頁.Size = new System.Drawing.Size(54, 27);
            this.上一頁.TabIndex = 0;
            this.上一頁.Text = "上一頁";
            this.上一頁.UseVisualStyleBackColor = true;
            this.上一頁.Click += new System.EventHandler(this.上一頁_Click);
            // 
            // 下一頁
            // 
            this.下一頁.Location = new System.Drawing.Point(173, 3);
            this.下一頁.Name = "下一頁";
            this.下一頁.Size = new System.Drawing.Size(53, 27);
            this.下一頁.TabIndex = 1;
            this.下一頁.Text = "下一頁";
            this.下一頁.UseVisualStyleBackColor = true;
            this.下一頁.Click += new System.EventHandler(this.下一頁_Click);
            // 
            // 索引
            // 
            this.索引.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.索引.AutoSize = true;
            this.索引.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.索引.Location = new System.Drawing.Point(72, 10);
            this.索引.Name = "索引";
            this.索引.Size = new System.Drawing.Size(85, 13);
            this.索引.TabIndex = 2;
            this.索引.Text = "索引索引索引";
            this.索引.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.索引);
            this.Controls.Add(this.下一頁);
            this.Controls.Add(this.上一頁);
            this.Name = "PageBar";
            this.Size = new System.Drawing.Size(234, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 上一頁;
        private System.Windows.Forms.Button 下一頁;
        private System.Windows.Forms.Label 索引;
    }
}
