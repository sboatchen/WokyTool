namespace WokyTool.測試
{
    partial class 訊息測試視窗
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
            this.內容 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.錯誤 = new System.Windows.Forms.Button();
            this.通知 = new System.Windows.Forms.Button();
            this.訊息 = new System.Windows.Forms.Button();
            this.追蹤 = new System.Windows.Forms.Button();
            this.警告 = new System.Windows.Forms.Button();
            this.確認 = new System.Windows.Forms.Button();
            this.是否為例外 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // 內容
            // 
            this.內容.Location = new System.Drawing.Point(66, 23);
            this.內容.Name = "內容";
            this.內容.Size = new System.Drawing.Size(270, 25);
            this.內容.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "訊息";
            // 
            // 錯誤
            // 
            this.錯誤.Location = new System.Drawing.Point(26, 115);
            this.錯誤.Name = "錯誤";
            this.錯誤.Size = new System.Drawing.Size(72, 23);
            this.錯誤.TabIndex = 3;
            this.錯誤.Text = "錯誤";
            this.錯誤.UseVisualStyleBackColor = true;
            this.錯誤.Click += new System.EventHandler(this.錯誤_Click);
            // 
            // 通知
            // 
            this.通知.Location = new System.Drawing.Point(116, 162);
            this.通知.Name = "通知";
            this.通知.Size = new System.Drawing.Size(72, 23);
            this.通知.TabIndex = 4;
            this.通知.Text = "通知";
            this.通知.UseVisualStyleBackColor = true;
            this.通知.Click += new System.EventHandler(this.通知_Click);
            // 
            // 訊息
            // 
            this.訊息.Location = new System.Drawing.Point(26, 162);
            this.訊息.Name = "訊息";
            this.訊息.Size = new System.Drawing.Size(72, 23);
            this.訊息.TabIndex = 5;
            this.訊息.Text = "訊息";
            this.訊息.UseVisualStyleBackColor = true;
            this.訊息.Click += new System.EventHandler(this.訊息_Click);
            // 
            // 追蹤
            // 
            this.追蹤.Location = new System.Drawing.Point(206, 115);
            this.追蹤.Name = "追蹤";
            this.追蹤.Size = new System.Drawing.Size(72, 23);
            this.追蹤.TabIndex = 6;
            this.追蹤.Text = "追蹤";
            this.追蹤.UseVisualStyleBackColor = true;
            this.追蹤.Click += new System.EventHandler(this.追蹤_Click);
            // 
            // 警告
            // 
            this.警告.Location = new System.Drawing.Point(116, 115);
            this.警告.Name = "警告";
            this.警告.Size = new System.Drawing.Size(72, 23);
            this.警告.TabIndex = 7;
            this.警告.Text = "警告";
            this.警告.UseVisualStyleBackColor = true;
            this.警告.Click += new System.EventHandler(this.警告_Click);
            // 
            // 確認
            // 
            this.確認.Location = new System.Drawing.Point(206, 162);
            this.確認.Name = "確認";
            this.確認.Size = new System.Drawing.Size(72, 23);
            this.確認.TabIndex = 8;
            this.確認.Text = "確認";
            this.確認.UseVisualStyleBackColor = true;
            this.確認.Click += new System.EventHandler(this.確認_Click);
            // 
            // 是否為例外
            // 
            this.是否為例外.AutoSize = true;
            this.是否為例外.Location = new System.Drawing.Point(22, 66);
            this.是否為例外.Name = "是否為例外";
            this.是否為例外.Size = new System.Drawing.Size(104, 19);
            this.是否為例外.TabIndex = 9;
            this.是否為例外.Text = "是否為例外";
            this.是否為例外.UseVisualStyleBackColor = true;
            // 
            // 訊息測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 347);
            this.Controls.Add(this.是否為例外);
            this.Controls.Add(this.確認);
            this.Controls.Add(this.警告);
            this.Controls.Add(this.追蹤);
            this.Controls.Add(this.訊息);
            this.Controls.Add(this.通知);
            this.Controls.Add(this.錯誤);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.內容);
            this.Name = "訊息測試視窗";
            this.Text = "訊息測試視窗";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 內容;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 錯誤;
        private System.Windows.Forms.Button 通知;
        private System.Windows.Forms.Button 訊息;
        private System.Windows.Forms.Button 追蹤;
        private System.Windows.Forms.Button 警告;
        private System.Windows.Forms.Button 確認;
        private System.Windows.Forms.CheckBox 是否為例外;
    }
}