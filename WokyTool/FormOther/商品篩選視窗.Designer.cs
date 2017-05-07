namespace WokyTool.FormOther
{
    partial class 商品篩選視窗
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.大類 = new System.Windows.Forms.ComboBox();
            this.商品大類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.小類 = new System.Windows.Forms.ComboBox();
            this.商品小類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.公司 = new System.Windows.Forms.ComboBox();
            this.公司資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.廠商 = new System.Windows.Forms.ComboBox();
            this.廠商資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.品名 = new System.Windows.Forms.ComboBox();
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.篩選 = new System.Windows.Forms.Button();
            this.品號 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.商品大類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品小類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "大類";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "小類";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "公司";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "廠商";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "品號";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "品名";
            // 
            // 大類
            // 
            this.大類.DataSource = this.商品大類資料BindingSource;
            this.大類.DisplayMember = "名稱";
            this.大類.FormattingEnabled = true;
            this.大類.Location = new System.Drawing.Point(62, 13);
            this.大類.Name = "大類";
            this.大類.Size = new System.Drawing.Size(146, 20);
            this.大類.TabIndex = 6;
            this.大類.ValueMember = "編號";
            // 
            // 商品大類資料BindingSource
            // 
            this.商品大類資料BindingSource.DataSource = typeof(WokyTool.Data.商品大類資料);
            // 
            // 小類
            // 
            this.小類.DataSource = this.商品小類資料BindingSource;
            this.小類.DisplayMember = "名稱";
            this.小類.FormattingEnabled = true;
            this.小類.Location = new System.Drawing.Point(258, 13);
            this.小類.Name = "小類";
            this.小類.Size = new System.Drawing.Size(146, 20);
            this.小類.TabIndex = 7;
            this.小類.ValueMember = "編號";
            // 
            // 商品小類資料BindingSource
            // 
            this.商品小類資料BindingSource.DataSource = typeof(WokyTool.Data.商品小類資料);
            // 
            // 公司
            // 
            this.公司.DataSource = this.公司資料BindingSource;
            this.公司.DisplayMember = "名稱";
            this.公司.FormattingEnabled = true;
            this.公司.Location = new System.Drawing.Point(62, 40);
            this.公司.Name = "公司";
            this.公司.Size = new System.Drawing.Size(146, 20);
            this.公司.TabIndex = 8;
            this.公司.ValueMember = "編號";
            // 
            // 公司資料BindingSource
            // 
            this.公司資料BindingSource.DataSource = typeof(WokyTool.Data.公司資料);
            // 
            // 廠商
            // 
            this.廠商.DataSource = this.廠商資料BindingSource;
            this.廠商.DisplayMember = "名稱";
            this.廠商.FormattingEnabled = true;
            this.廠商.Location = new System.Drawing.Point(258, 40);
            this.廠商.Name = "廠商";
            this.廠商.Size = new System.Drawing.Size(146, 20);
            this.廠商.TabIndex = 9;
            this.廠商.ValueMember = "編號";
            // 
            // 廠商資料BindingSource
            // 
            this.廠商資料BindingSource.DataSource = typeof(WokyTool.Data.廠商資料);
            // 
            // 品名
            // 
            this.品名.DataSource = this.商品資料BindingSource;
            this.品名.DisplayMember = "名稱";
            this.品名.FormattingEnabled = true;
            this.品名.Location = new System.Drawing.Point(62, 108);
            this.品名.Name = "品名";
            this.品名.Size = new System.Drawing.Size(342, 20);
            this.品名.TabIndex = 11;
            this.品名.ValueMember = "編號";
            this.品名.DropDown += new System.EventHandler(this.品名_DropDown);
            // 
            // 商品資料BindingSource
            // 
            this.商品資料BindingSource.DataSource = typeof(WokyTool.Data.商品資料);
            // 
            // 篩選
            // 
            this.篩選.Location = new System.Drawing.Point(156, 142);
            this.篩選.Name = "篩選";
            this.篩選.Size = new System.Drawing.Size(105, 23);
            this.篩選.TabIndex = 12;
            this.篩選.Text = "篩選";
            this.篩選.UseVisualStyleBackColor = true;
            this.篩選.Click += new System.EventHandler(this.button1_Click);
            // 
            // 品號
            // 
            this.品號.Location = new System.Drawing.Point(62, 75);
            this.品號.Name = "品號";
            this.品號.Size = new System.Drawing.Size(146, 22);
            this.品號.TabIndex = 13;
            // 
            // 商品篩選視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 177);
            this.Controls.Add(this.品號);
            this.Controls.Add(this.篩選);
            this.Controls.Add(this.品名);
            this.Controls.Add(this.廠商);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.小類);
            this.Controls.Add(this.大類);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "商品篩選視窗";
            this.Text = "商品篩選視窗";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.商品篩選視窗_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.商品大類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品小類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox 大類;
        private System.Windows.Forms.ComboBox 小類;
        private System.Windows.Forms.ComboBox 公司;
        private System.Windows.Forms.ComboBox 廠商;
        private System.Windows.Forms.ComboBox 品名;
        private System.Windows.Forms.Button 篩選;
        private System.Windows.Forms.BindingSource 商品大類資料BindingSource;
        private System.Windows.Forms.BindingSource 商品小類資料BindingSource;
        private System.Windows.Forms.BindingSource 廠商資料BindingSource;
        private System.Windows.Forms.TextBox 品號;
        private System.Windows.Forms.BindingSource 公司資料BindingSource;
        private System.Windows.Forms.BindingSource 商品資料BindingSource;
    }
}