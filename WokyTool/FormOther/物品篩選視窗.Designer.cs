namespace WokyTool.FormOther
{
    partial class 物品篩選視窗
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
            this.label1 = new System.Windows.Forms.Label();
            this.大類 = new System.Windows.Forms.ComboBox();
            this.小類 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.品牌 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.原廠編號 = new System.Windows.Forms.TextBox();
            this.代理編號 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.名稱 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.縮寫 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.篩選 = new System.Windows.Forms.Button();
            this.物品大類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品小類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品品牌資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.物品大類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品小類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品品牌資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "大類";
            // 
            // 大類
            // 
            this.大類.DataSource = this.物品大類資料BindingSource;
            this.大類.DisplayMember = "名稱";
            this.大類.DropDownWidth = 146;
            this.大類.FormattingEnabled = true;
            this.大類.Location = new System.Drawing.Point(61, 12);
            this.大類.Name = "大類";
            this.大類.Size = new System.Drawing.Size(145, 20);
            this.大類.TabIndex = 1;
            this.大類.ValueMember = "編號";
            // 
            // 小類
            // 
            this.小類.DataSource = this.物品小類資料BindingSource;
            this.小類.DisplayMember = "名稱";
            this.小類.FormattingEnabled = true;
            this.小類.Location = new System.Drawing.Point(244, 12);
            this.小類.Name = "小類";
            this.小類.Size = new System.Drawing.Size(146, 20);
            this.小類.TabIndex = 3;
            this.小類.ValueMember = "編號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "小類";
            // 
            // 品牌
            // 
            this.品牌.DataSource = this.物品品牌資料BindingSource;
            this.品牌.DisplayMember = "名稱";
            this.品牌.FormattingEnabled = true;
            this.品牌.Location = new System.Drawing.Point(60, 45);
            this.品牌.Name = "品牌";
            this.品牌.Size = new System.Drawing.Size(146, 20);
            this.品牌.TabIndex = 5;
            this.品牌.ValueMember = "編號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "品牌";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "原廠編號";
            // 
            // 原廠編號
            // 
            this.原廠編號.Location = new System.Drawing.Point(60, 72);
            this.原廠編號.Name = "原廠編號";
            this.原廠編號.Size = new System.Drawing.Size(328, 22);
            this.原廠編號.TabIndex = 7;
            // 
            // 代理編號
            // 
            this.代理編號.Location = new System.Drawing.Point(60, 105);
            this.代理編號.Name = "代理編號";
            this.代理編號.Size = new System.Drawing.Size(328, 22);
            this.代理編號.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "代理編號";
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(60, 133);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(328, 22);
            this.名稱.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "名稱";
            // 
            // 縮寫
            // 
            this.縮寫.Location = new System.Drawing.Point(60, 161);
            this.縮寫.Name = "縮寫";
            this.縮寫.Size = new System.Drawing.Size(328, 22);
            this.縮寫.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "縮寫";
            // 
            // 篩選
            // 
            this.篩選.Location = new System.Drawing.Point(170, 192);
            this.篩選.Name = "篩選";
            this.篩選.Size = new System.Drawing.Size(75, 23);
            this.篩選.TabIndex = 14;
            this.篩選.Text = "篩選";
            this.篩選.UseVisualStyleBackColor = true;
            this.篩選.Click += new System.EventHandler(this.篩選_Click);
            // 
            // 物品大類資料BindingSource
            // 
            this.物品大類資料BindingSource.DataSource = typeof(WokyTool.Data.物品大類資料);
            // 
            // 物品小類資料BindingSource
            // 
            this.物品小類資料BindingSource.DataSource = typeof(WokyTool.Data.物品小類資料);
            // 
            // 物品品牌資料BindingSource
            // 
            this.物品品牌資料BindingSource.DataSource = typeof(WokyTool.Data.物品品牌資料);
            // 
            // 物品篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 227);
            this.Controls.Add(this.篩選);
            this.Controls.Add(this.縮寫);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.代理編號);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.原廠編號);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.品牌);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.小類);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.大類);
            this.Controls.Add(this.label1);
            this.Name = "物品篩選視窗";
            this.Text = "物品篩選視窗";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.物品篩選視窗_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.物品大類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品小類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品品牌資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox 大類;
        private System.Windows.Forms.ComboBox 小類;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox 品牌;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox 原廠編號;
        private System.Windows.Forms.TextBox 代理編號;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 縮寫;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button 篩選;
        private System.Windows.Forms.BindingSource 物品大類資料BindingSource;
        private System.Windows.Forms.BindingSource 物品小類資料BindingSource;
        private System.Windows.Forms.BindingSource 物品品牌資料BindingSource;
    }
}