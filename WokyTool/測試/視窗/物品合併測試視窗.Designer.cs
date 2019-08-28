namespace WokyTool.測試
{
    partial class 物品合併測試視窗
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
            this.button1 = new System.Windows.Forms.Button();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.物品選取元件1 = new WokyTool.物品.物品選取元件();
            this.結果 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(502, 32);
            this.數量.Name = "數量";
            this.數量.Size = new System.Drawing.Size(70, 22);
            this.數量.TabIndex = 2;
            // 
            // 物品選取元件1
            // 
            this.物品選取元件1.Location = new System.Drawing.Point(68, 32);
            this.物品選取元件1.Name = "物品選取元件1";
            this.物品選取元件1.ReadOnly = false;
            this.物品選取元件1.SelectedItem = null;
            this.物品選取元件1.Size = new System.Drawing.Size(427, 30);
            this.物品選取元件1.TabIndex = 0;
            // 
            // 結果
            // 
            this.結果.Location = new System.Drawing.Point(27, 101);
            this.結果.Name = "結果";
            this.結果.Size = new System.Drawing.Size(545, 22);
            this.結果.TabIndex = 3;
            // 
            // 物品合併測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 189);
            this.Controls.Add(this.結果);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.物品選取元件1);
            this.Name = "物品合併測試視窗";
            this.Text = "物品合併測試視窗";
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 物品.物品選取元件 物品選取元件1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.TextBox 結果;
    }
}