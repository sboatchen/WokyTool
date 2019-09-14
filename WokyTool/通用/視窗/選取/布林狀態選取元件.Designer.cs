namespace WokyTool.通用
{
    partial class 布林狀態選取元件
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
            this.components = new System.ComponentModel.Container();
            this.標頭 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.布林狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.布林狀態BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 標頭
            // 
            this.標頭.AutoSize = true;
            this.標頭.Location = new System.Drawing.Point(0, 3);
            this.標頭.Name = "標頭";
            this.標頭.Size = new System.Drawing.Size(53, 12);
            this.標頭.TabIndex = 109;
            this.標頭.Text = "布林狀態";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.布林狀態BindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 20);
            this.comboBox1.TabIndex = 112;
            // 
            // 布林狀態BindingSource
            // 
            this.布林狀態BindingSource.DataSource = typeof(WokyTool.通用.列舉.布林狀態);
            // 
            // 布林狀態選取元件
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.標頭);
            this.Name = "布林狀態選取元件";
            this.Size = new System.Drawing.Size(230, 22);
            ((System.ComponentModel.ISupportInitialize)(this.布林狀態BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 標頭;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource 布林狀態BindingSource;
    }
}
