namespace WokyTool.通用
{
    partial class 通用匯出視窗
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.屬性 = new System.Windows.Forms.ComboBox();
            this.標頭 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.切檔方式 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.分頁方式 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.檔案格式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.檔案格式BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 屬性
            // 
            this.屬性.FormattingEnabled = true;
            this.屬性.Location = new System.Drawing.Point(194, 123);
            this.屬性.Name = "屬性";
            this.屬性.Size = new System.Drawing.Size(157, 20);
            this.屬性.TabIndex = 1;
            // 
            // 標頭
            // 
            this.標頭.Location = new System.Drawing.Point(66, 123);
            this.標頭.Name = "標頭";
            this.標頭.Size = new System.Drawing.Size(122, 22);
            this.標頭.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸出格式";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.檔案格式BindingSource;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(66, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 5;
            // 
            // 切檔方式
            // 
            this.切檔方式.FormattingEnabled = true;
            this.切檔方式.Location = new System.Drawing.Point(66, 36);
            this.切檔方式.Name = "切檔方式";
            this.切檔方式.Size = new System.Drawing.Size(121, 20);
            this.切檔方式.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "切檔方式";
            // 
            // 分頁方式
            // 
            this.分頁方式.FormattingEnabled = true;
            this.分頁方式.Location = new System.Drawing.Point(66, 62);
            this.分頁方式.Name = "分頁方式";
            this.分頁方式.Size = new System.Drawing.Size(121, 20);
            this.分頁方式.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "分頁方式";
            // 
            // 檔案格式BindingSource
            // 
            this.檔案格式BindingSource.DataSource = typeof(WokyTool.通用.列舉.檔案格式);
            // 
            // 通用匯出視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 662);
            this.Controls.Add(this.分頁方式);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.切檔方式);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.標頭);
            this.Controls.Add(this.屬性);
            this.Controls.Add(this.button1);
            this.Name = "通用匯出視窗";
            this.Text = "通用匯出視窗";
            ((System.ComponentModel.ISupportInitialize)(this.檔案格式BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox 屬性;
        private System.Windows.Forms.TextBox 標頭;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource 檔案格式BindingSource;
        private System.Windows.Forms.ComboBox 切檔方式;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox 分頁方式;
        private System.Windows.Forms.Label label3;
    }
}