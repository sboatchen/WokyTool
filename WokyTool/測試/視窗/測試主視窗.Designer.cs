namespace WokyTool.測試
{
    partial class 測試主視窗
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.通用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.時間ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通用ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 通用ToolStripMenuItem
            // 
            this.通用ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.時間ToolStripMenuItem,
            this.檔案ToolStripMenuItem});
            this.通用ToolStripMenuItem.Name = "通用ToolStripMenuItem";
            this.通用ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.通用ToolStripMenuItem.Text = "通用";
            // 
            // 時間ToolStripMenuItem
            // 
            this.時間ToolStripMenuItem.Name = "時間ToolStripMenuItem";
            this.時間ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.時間ToolStripMenuItem.Text = "時間";
            this.時間ToolStripMenuItem.Click += new System.EventHandler(this.時間ToolStripMenuItem_Click);
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.檔案ToolStripMenuItem.Text = "檔案";
            this.檔案ToolStripMenuItem.Click += new System.EventHandler(this.檔案ToolStripMenuItem_Click);
            // 
            // 測試主視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "測試主視窗";
            this.Text = "測試主視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 通用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 時間ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
    }
}