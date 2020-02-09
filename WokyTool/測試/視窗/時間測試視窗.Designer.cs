namespace WokyTool.測試
{
    partial class 時間測試視窗
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
            this.button2 = new System.Windows.Forms.Button();
            this.myDateTimePicker1 = new WokyTool.通用.MyDateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // myDateTimePicker1
            // 
            this.myDateTimePicker1.CustomFormat = " ";
            this.myDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.myDateTimePicker1.Location = new System.Drawing.Point(44, 134);
            this.myDateTimePicker1.Name = "myDateTimePicker1";
            this.myDateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.myDateTimePicker1.TabIndex = 1;
            this.myDateTimePicker1.Value = new System.DateTime(((long)(0)));
            this.myDateTimePicker1.類型 = WokyTool.通用.MyDateTimePicker.時間類型.最大值;
            // 
            // 時間測試視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.myDateTimePicker1);
            this.Controls.Add(this.button1);
            this.Name = "時間測試視窗";
            this.Text = "時間";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private 通用.MyDateTimePicker myDateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}