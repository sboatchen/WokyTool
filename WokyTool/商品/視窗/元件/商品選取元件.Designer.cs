﻿namespace WokyTool.商品
{
    partial class 商品選取元件
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Detail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.商品資料BindingSource;
            this.comboBox1.DisplayMember = "名稱";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(400, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Self";
            // 
            // 商品資料BindingSource
            // 
            this.商品資料BindingSource.DataSource = typeof(WokyTool.商品.商品資料);
            // 
            // Detail
            // 
            this.Detail.AutoSize = true;
            this.Detail.Font = new System.Drawing.Font("PMingLiU", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Detail.Location = new System.Drawing.Point(405, 5);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(10, 11);
            this.Detail.TabIndex = 1;
            this.Detail.Text = "?";
            this.Detail.Click += new System.EventHandler(this.Detail_Click);
            // 
            // 商品選取元件
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.comboBox1);
            this.Name = "商品選取元件";
            this.Size = new System.Drawing.Size(420, 22);
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Detail;
        private System.Windows.Forms.BindingSource 商品資料BindingSource;
    }
}
