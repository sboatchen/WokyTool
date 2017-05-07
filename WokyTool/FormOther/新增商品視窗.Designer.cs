namespace WokyTool.OtherForm
{
    partial class 新增商品視窗
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
            this.成本 = new System.Windows.Forms.Label();
            this.品號 = new System.Windows.Forms.TextBox();
            this.廠商 = new System.Windows.Forms.ComboBox();
            this.廠商資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.名稱 = new System.Windows.Forms.TextBox();
            this.體積 = new System.Windows.Forms.Label();
            this.小類 = new System.Windows.Forms.ComboBox();
            this.商品小類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.大類 = new System.Windows.Forms.ComboBox();
            this.商品大類資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.需求1 = new System.Windows.Forms.ComboBox();
            this.物品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.需求2 = new System.Windows.Forms.ComboBox();
            this.需求3 = new System.Windows.Forms.ComboBox();
            this.需求4 = new System.Windows.Forms.ComboBox();
            this.需求5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.數量1 = new System.Windows.Forms.NumericUpDown();
            this.數量5 = new System.Windows.Forms.NumericUpDown();
            this.數量4 = new System.Windows.Forms.NumericUpDown();
            this.數量3 = new System.Windows.Forms.NumericUpDown();
            this.數量2 = new System.Windows.Forms.NumericUpDown();
            this.參考 = new System.Windows.Forms.ComboBox();
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.公司 = new System.Windows.Forms.ComboBox();
            this.公司資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品小類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品大類資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // 成本
            // 
            this.成本.AutoSize = true;
            this.成本.Location = new System.Drawing.Point(58, 340);
            this.成本.Name = "成本";
            this.成本.Size = new System.Drawing.Size(11, 12);
            this.成本.TabIndex = 0;
            this.成本.Text = "0";
            // 
            // 品號
            // 
            this.品號.Location = new System.Drawing.Point(47, 41);
            this.品號.Name = "品號";
            this.品號.Size = new System.Drawing.Size(288, 22);
            this.品號.TabIndex = 1;
            this.品號.TextChanged += new System.EventHandler(this.品號_TextChanged);
            // 
            // 廠商
            // 
            this.廠商.DataSource = this.廠商資料BindingSource;
            this.廠商.DisplayMember = "名稱";
            this.廠商.FormattingEnabled = true;
            this.廠商.Location = new System.Drawing.Point(214, 97);
            this.廠商.Name = "廠商";
            this.廠商.Size = new System.Drawing.Size(121, 20);
            this.廠商.TabIndex = 2;
            this.廠商.ValueMember = "編號";
            this.廠商.SelectionChangeCommitted += new System.EventHandler(this.廠商_SelectionChangeCommitted);
            // 
            // 廠商資料BindingSource
            // 
            this.廠商資料BindingSource.DataSource = typeof(WokyTool.Data.廠商資料);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "成本";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "名稱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "小類";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "大類";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "體積";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "數量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "需求";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "品號";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "廠商";
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(47, 69);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(288, 22);
            this.名稱.TabIndex = 16;
            this.名稱.TextChanged += new System.EventHandler(this.名稱_TextChanged);
            // 
            // 體積
            // 
            this.體積.AutoSize = true;
            this.體積.Location = new System.Drawing.Point(158, 340);
            this.體積.Name = "體積";
            this.體積.Size = new System.Drawing.Size(11, 12);
            this.體積.TabIndex = 17;
            this.體積.Text = "0";
            // 
            // 小類
            // 
            this.小類.DataSource = this.商品小類資料BindingSource;
            this.小類.DisplayMember = "名稱";
            this.小類.FormattingEnabled = true;
            this.小類.Location = new System.Drawing.Point(47, 152);
            this.小類.Name = "小類";
            this.小類.Size = new System.Drawing.Size(121, 20);
            this.小類.TabIndex = 18;
            this.小類.ValueMember = "編號";
            this.小類.SelectionChangeCommitted += new System.EventHandler(this.小類_SelectionChangeCommitted);
            // 
            // 商品小類資料BindingSource
            // 
            this.商品小類資料BindingSource.DataSource = typeof(WokyTool.Data.商品小類資料);
            // 
            // 大類
            // 
            this.大類.DataSource = this.商品大類資料BindingSource;
            this.大類.DisplayMember = "名稱";
            this.大類.FormattingEnabled = true;
            this.大類.Location = new System.Drawing.Point(47, 127);
            this.大類.Name = "大類";
            this.大類.Size = new System.Drawing.Size(121, 20);
            this.大類.TabIndex = 19;
            this.大類.ValueMember = "編號";
            this.大類.SelectionChangeCommitted += new System.EventHandler(this.大類_SelectionChangeCommitted);
            // 
            // 商品大類資料BindingSource
            // 
            this.商品大類資料BindingSource.DataSource = typeof(WokyTool.Data.商品大類資料);
            // 
            // 需求1
            // 
            this.需求1.DataSource = this.物品資料BindingSource;
            this.需求1.DisplayMember = "名稱";
            this.需求1.FormattingEnabled = true;
            this.需求1.Location = new System.Drawing.Point(47, 194);
            this.需求1.Name = "需求1";
            this.需求1.Size = new System.Drawing.Size(288, 20);
            this.需求1.TabIndex = 24;
            this.需求1.ValueMember = "編號";
            this.需求1.DropDown += new System.EventHandler(this.需求1_DropDown);
            this.需求1.SelectionChangeCommitted += new System.EventHandler(this.需求1_SelectionChangeCommitted);
            // 
            // 物品資料BindingSource
            // 
            this.物品資料BindingSource.DataSource = typeof(WokyTool.Data.物品資料);
            // 
            // 需求2
            // 
            this.需求2.DataSource = this.物品資料BindingSource;
            this.需求2.DisplayMember = "名稱";
            this.需求2.FormattingEnabled = true;
            this.需求2.Location = new System.Drawing.Point(47, 223);
            this.需求2.Name = "需求2";
            this.需求2.Size = new System.Drawing.Size(288, 20);
            this.需求2.TabIndex = 26;
            this.需求2.ValueMember = "編號";
            this.需求2.DropDown += new System.EventHandler(this.需求2_DropDown);
            this.需求2.SelectionChangeCommitted += new System.EventHandler(this.需求2_SelectionChangeCommitted);
            // 
            // 需求3
            // 
            this.需求3.DataSource = this.物品資料BindingSource;
            this.需求3.DisplayMember = "名稱";
            this.需求3.FormattingEnabled = true;
            this.需求3.Location = new System.Drawing.Point(47, 251);
            this.需求3.Name = "需求3";
            this.需求3.Size = new System.Drawing.Size(288, 20);
            this.需求3.TabIndex = 28;
            this.需求3.ValueMember = "編號";
            this.需求3.DropDown += new System.EventHandler(this.需求3_DropDown);
            this.需求3.SelectionChangeCommitted += new System.EventHandler(this.需求3_SelectionChangeCommitted);
            // 
            // 需求4
            // 
            this.需求4.DataSource = this.物品資料BindingSource;
            this.需求4.DisplayMember = "名稱";
            this.需求4.FormattingEnabled = true;
            this.需求4.Location = new System.Drawing.Point(47, 278);
            this.需求4.Name = "需求4";
            this.需求4.Size = new System.Drawing.Size(288, 20);
            this.需求4.TabIndex = 30;
            this.需求4.ValueMember = "編號";
            this.需求4.DropDown += new System.EventHandler(this.需求4_DropDown);
            this.需求4.SelectionChangeCommitted += new System.EventHandler(this.需求4_SelectionChangeCommitted);
            // 
            // 需求5
            // 
            this.需求5.DataSource = this.物品資料BindingSource;
            this.需求5.DisplayMember = "名稱";
            this.需求5.FormattingEnabled = true;
            this.需求5.Location = new System.Drawing.Point(47, 307);
            this.需求5.Name = "需求5";
            this.需求5.Size = new System.Drawing.Size(288, 20);
            this.需求5.TabIndex = 32;
            this.需求5.ValueMember = "編號";
            this.需求5.DropDown += new System.EventHandler(this.需求5_DropDown);
            this.需求5.SelectionChangeCommitted += new System.EventHandler(this.需求5_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 數量1
            // 
            this.數量1.Location = new System.Drawing.Point(374, 195);
            this.數量1.Name = "數量1";
            this.數量1.Size = new System.Drawing.Size(62, 22);
            this.數量1.TabIndex = 34;
            this.數量1.ValueChanged += new System.EventHandler(this.數量1_ValueChanged);
            // 
            // 數量5
            // 
            this.數量5.Location = new System.Drawing.Point(374, 307);
            this.數量5.Name = "數量5";
            this.數量5.Size = new System.Drawing.Size(62, 22);
            this.數量5.TabIndex = 35;
            this.數量5.ValueChanged += new System.EventHandler(this.數量5_ValueChanged);
            // 
            // 數量4
            // 
            this.數量4.Location = new System.Drawing.Point(374, 279);
            this.數量4.Name = "數量4";
            this.數量4.Size = new System.Drawing.Size(62, 22);
            this.數量4.TabIndex = 36;
            this.數量4.ValueChanged += new System.EventHandler(this.數量4_ValueChanged);
            // 
            // 數量3
            // 
            this.數量3.Location = new System.Drawing.Point(374, 251);
            this.數量3.Name = "數量3";
            this.數量3.Size = new System.Drawing.Size(62, 22);
            this.數量3.TabIndex = 37;
            this.數量3.ValueChanged += new System.EventHandler(this.數量3_ValueChanged);
            // 
            // 數量2
            // 
            this.數量2.Location = new System.Drawing.Point(374, 223);
            this.數量2.Name = "數量2";
            this.數量2.Size = new System.Drawing.Size(62, 22);
            this.數量2.TabIndex = 38;
            this.數量2.ValueChanged += new System.EventHandler(this.數量2_ValueChanged);
            // 
            // 參考
            // 
            this.參考.DataSource = this.商品資料BindingSource;
            this.參考.DisplayMember = "名稱";
            this.參考.FormattingEnabled = true;
            this.參考.Location = new System.Drawing.Point(47, 4);
            this.參考.Name = "參考";
            this.參考.Size = new System.Drawing.Size(288, 20);
            this.參考.TabIndex = 39;
            this.參考.ValueMember = "編號";
            this.參考.DropDown += new System.EventHandler(this.參考_DropDown);
            this.參考.SelectionChangeCommitted += new System.EventHandler(this.參考_SelectionChangeCommitted);
            // 
            // 商品資料BindingSource
            // 
            this.商品資料BindingSource.DataSource = typeof(WokyTool.Data.商品資料);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "參考";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "公司";
            // 
            // 公司
            // 
            this.公司.DataSource = this.公司資料BindingSource;
            this.公司.DisplayMember = "名稱";
            this.公司.FormattingEnabled = true;
            this.公司.Location = new System.Drawing.Point(48, 97);
            this.公司.Name = "公司";
            this.公司.Size = new System.Drawing.Size(121, 20);
            this.公司.TabIndex = 41;
            this.公司.ValueMember = "編號";
            this.公司.SelectionChangeCommitted += new System.EventHandler(this.公司_SelectionChangeCommitted);
            // 
            // 公司資料BindingSource
            // 
            this.公司資料BindingSource.DataSource = typeof(WokyTool.Data.公司資料);
            // 
            // 新增商品視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 431);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.參考);
            this.Controls.Add(this.數量2);
            this.Controls.Add(this.數量3);
            this.Controls.Add(this.數量4);
            this.Controls.Add(this.數量5);
            this.Controls.Add(this.數量1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.需求5);
            this.Controls.Add(this.需求4);
            this.Controls.Add(this.需求3);
            this.Controls.Add(this.需求2);
            this.Controls.Add(this.需求1);
            this.Controls.Add(this.大類);
            this.Controls.Add(this.小類);
            this.Controls.Add(this.體積);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.廠商);
            this.Controls.Add(this.品號);
            this.Controls.Add(this.成本);
            this.Name = "新增商品視窗";
            this.Text = "新增商品視窗";
            this.Activated += new System.EventHandler(this.新增商品視窗_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品小類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品大類資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.公司資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 成本;
        private System.Windows.Forms.TextBox 品號;
        private System.Windows.Forms.ComboBox 廠商;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.Label 體積;
        private System.Windows.Forms.ComboBox 小類;
        private System.Windows.Forms.ComboBox 大類;
        private System.Windows.Forms.ComboBox 需求1;
        private System.Windows.Forms.ComboBox 需求2;
        private System.Windows.Forms.ComboBox 需求3;
        private System.Windows.Forms.ComboBox 需求4;
        private System.Windows.Forms.ComboBox 需求5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown 數量1;
        private System.Windows.Forms.NumericUpDown 數量5;
        private System.Windows.Forms.NumericUpDown 數量4;
        private System.Windows.Forms.NumericUpDown 數量3;
        private System.Windows.Forms.NumericUpDown 數量2;
        private System.Windows.Forms.BindingSource 廠商資料BindingSource;
        private System.Windows.Forms.BindingSource 商品小類資料BindingSource;
        private System.Windows.Forms.BindingSource 商品大類資料BindingSource;
        private System.Windows.Forms.ComboBox 參考;
        private System.Windows.Forms.BindingSource 商品資料BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource 物品資料BindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox 公司;
        private System.Windows.Forms.BindingSource 公司資料BindingSource;
    }
}