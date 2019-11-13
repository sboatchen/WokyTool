using WokyTool.通用;
namespace WokyTool.商品
{
    partial class 商品詳細視窗
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
            this.label12 = new System.Windows.Forms.Label();
            this.利潤 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.體積 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.成本 = new System.Windows.Forms.NumericUpDown();
            this.小類 = new WokyTool.商品.商品小類選取元件();
            this.label6 = new System.Windows.Forms.Label();
            this.售價 = new System.Windows.Forms.NumericUpDown();
            this.寄庫數量 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.客戶 = new WokyTool.客戶.客戶選取元件();
            this.公司 = new WokyTool.公司.公司選取元件();
            this.大類 = new WokyTool.商品.商品大類選取元件();
            this.品號 = new System.Windows.Forms.TextBox();
            this.名稱 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.物品 = new WokyTool.物品.物品選取元件();
            this.dataGridView1 = new WokyTool.通用.MyDataGridView();
            this.商品組成資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.新增 = new System.Windows.Forms.Button();
            this.數量 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.進價 = new System.Windows.Forms.NumericUpDown();
            this.新版頁索引元件1 = new WokyTool.通用.新版頁索引元件();
            this.label15 = new System.Windows.Forms.Label();
            this.品牌 = new WokyTool.物品.物品品牌選取元件();
            this.群組DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.規格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.體積DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.利潤)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.體積)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.售價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.寄庫數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品組成資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.進價)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 482);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 75;
            this.label12.Text = "利潤";
            // 
            // 利潤
            // 
            this.利潤.DecimalPlaces = 3;
            this.利潤.Location = new System.Drawing.Point(58, 478);
            this.利潤.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.利潤.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.利潤.Name = "利潤";
            this.利潤.ReadOnly = true;
            this.利潤.Size = new System.Drawing.Size(165, 22);
            this.利潤.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 73;
            this.label13.Text = "體積";
            // 
            // 體積
            // 
            this.體積.Location = new System.Drawing.Point(58, 506);
            this.體積.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.體積.Name = "體積";
            this.體積.ReadOnly = true;
            this.體積.Size = new System.Drawing.Size(165, 22);
            this.體積.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 71;
            this.label10.Text = "成本";
            // 
            // 成本
            // 
            this.成本.DecimalPlaces = 3;
            this.成本.Location = new System.Drawing.Point(58, 447);
            this.成本.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.成本.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.成本.Name = "成本";
            this.成本.ReadOnly = true;
            this.成本.Size = new System.Drawing.Size(165, 22);
            this.成本.TabIndex = 70;
            // 
            // 小類
            // 
            this.小類.Location = new System.Drawing.Point(58, 100);
            this.小類.Margin = new System.Windows.Forms.Padding(4);
            this.小類.Name = "小類";
            this.小類.ReadOnly = false;
            this.小類.SelectedItem = null;
            this.小類.Size = new System.Drawing.Size(172, 25);
            this.小類.TabIndex = 69;
            this.小類.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 68;
            this.label6.Text = "售價";
            // 
            // 售價
            // 
            this.售價.DecimalPlaces = 3;
            this.售價.Location = new System.Drawing.Point(293, 478);
            this.售價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.售價.Name = "售價";
            this.售價.Size = new System.Drawing.Size(165, 22);
            this.售價.TabIndex = 67;
            // 
            // 寄庫數量
            // 
            this.寄庫數量.Location = new System.Drawing.Point(293, 506);
            this.寄庫數量.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.寄庫數量.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.寄庫數量.Name = "寄庫數量";
            this.寄庫數量.Size = new System.Drawing.Size(165, 22);
            this.寄庫數量.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 65;
            this.label3.Text = "寄庫數量";
            // 
            // 客戶
            // 
            this.客戶.Location = new System.Drawing.Point(293, 99);
            this.客戶.Margin = new System.Windows.Forms.Padding(4);
            this.客戶.Name = "客戶";
            this.客戶.ReadOnly = false;
            this.客戶.SelectedItem = null;
            this.客戶.Size = new System.Drawing.Size(190, 25);
            this.客戶.TabIndex = 55;
            this.客戶.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 公司
            // 
            this.公司.Location = new System.Drawing.Point(293, 73);
            this.公司.Margin = new System.Windows.Forms.Padding(4);
            this.公司.Name = "公司";
            this.公司.ReadOnly = false;
            this.公司.SelectedItem = null;
            this.公司.Size = new System.Drawing.Size(172, 25);
            this.公司.TabIndex = 54;
            this.公司.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 大類
            // 
            this.大類.Location = new System.Drawing.Point(58, 73);
            this.大類.Margin = new System.Windows.Forms.Padding(4);
            this.大類.Name = "大類";
            this.大類.ReadOnly = false;
            this.大類.SelectedItem = null;
            this.大類.Size = new System.Drawing.Size(172, 25);
            this.大類.TabIndex = 52;
            this.大類.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 品號
            // 
            this.品號.Location = new System.Drawing.Point(58, 39);
            this.品號.Name = "品號";
            this.品號.Size = new System.Drawing.Size(165, 22);
            this.品號.TabIndex = 35;
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(58, 10);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(400, 22);
            this.名稱.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "品號";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "名稱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "客戶";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "公司";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "小類";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "大類";
            // 
            // 物品
            // 
            this.物品.Location = new System.Drawing.Point(58, 154);
            this.物品.Margin = new System.Windows.Forms.Padding(4);
            this.物品.Name = "物品";
            this.物品.ReadOnly = false;
            this.物品.SelectedItem = null;
            this.物品.Size = new System.Drawing.Size(423, 24);
            this.物品.TabIndex = 100;
            this.物品.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.群組DataGridViewTextBoxColumn,
            this.規格DataGridViewTextBoxColumn,
            this.物品名稱DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.成本DataGridViewTextBoxColumn,
            this.體積DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.商品組成資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(945, 248);
            this.dataGridView1.TabIndex = 99;
            // 
            // 商品組成資料BindingSource
            // 
            this.商品組成資料BindingSource.DataSource = typeof(WokyTool.商品.商品組成資料);
            // 
            // 物品資料BindingSource
            // 
            this.物品資料BindingSource.DataSource = typeof(WokyTool.物品.物品資料);
            // 
            // 新增
            // 
            this.新增.Location = new System.Drawing.Point(7, 154);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(42, 23);
            this.新增.TabIndex = 97;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = true;
            this.新增.Click += new System.EventHandler(this.新增_Click);
            // 
            // 數量
            // 
            this.數量.Location = new System.Drawing.Point(481, 155);
            this.數量.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.數量.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.數量.Name = "數量";
            this.數量.Size = new System.Drawing.Size(74, 22);
            this.數量.TabIndex = 95;
            this.數量.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 102;
            this.label9.Text = "進價";
            // 
            // 進價
            // 
            this.進價.DecimalPlaces = 3;
            this.進價.Location = new System.Drawing.Point(293, 447);
            this.進價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.進價.Name = "進價";
            this.進價.Size = new System.Drawing.Size(165, 22);
            this.進價.TabIndex = 101;
            // 
            // 新版頁索引元件1
            // 
            this.新版頁索引元件1.Location = new System.Drawing.Point(167, 541);
            this.新版頁索引元件1.Name = "新版頁索引元件1";
            this.新版頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.新版頁索引元件1.TabIndex = 103;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 105;
            this.label15.Text = "品牌";
            // 
            // 品牌
            // 
            this.品牌.Location = new System.Drawing.Point(58, 127);
            this.品牌.Margin = new System.Windows.Forms.Padding(4);
            this.品牌.Name = "品牌";
            this.品牌.ReadOnly = true;
            this.品牌.SelectedItem = null;
            this.品牌.Size = new System.Drawing.Size(172, 25);
            this.品牌.TabIndex = 104;
            this.品牌.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 群組DataGridViewTextBoxColumn
            // 
            this.群組DataGridViewTextBoxColumn.DataPropertyName = "群組";
            this.群組DataGridViewTextBoxColumn.HeaderText = "群組";
            this.群組DataGridViewTextBoxColumn.Name = "群組DataGridViewTextBoxColumn";
            // 
            // 規格DataGridViewTextBoxColumn
            // 
            this.規格DataGridViewTextBoxColumn.DataPropertyName = "規格";
            this.規格DataGridViewTextBoxColumn.HeaderText = "規格";
            this.規格DataGridViewTextBoxColumn.Name = "規格DataGridViewTextBoxColumn";
            // 
            // 物品名稱DataGridViewTextBoxColumn
            // 
            this.物品名稱DataGridViewTextBoxColumn.DataPropertyName = "物品名稱";
            this.物品名稱DataGridViewTextBoxColumn.HeaderText = "物品";
            this.物品名稱DataGridViewTextBoxColumn.Name = "物品名稱DataGridViewTextBoxColumn";
            this.物品名稱DataGridViewTextBoxColumn.ReadOnly = true;
            this.物品名稱DataGridViewTextBoxColumn.Width = 400;
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 成本DataGridViewTextBoxColumn
            // 
            this.成本DataGridViewTextBoxColumn.DataPropertyName = "成本";
            this.成本DataGridViewTextBoxColumn.HeaderText = "成本";
            this.成本DataGridViewTextBoxColumn.Name = "成本DataGridViewTextBoxColumn";
            this.成本DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 體積DataGridViewTextBoxColumn
            // 
            this.體積DataGridViewTextBoxColumn.DataPropertyName = "體積";
            this.體積DataGridViewTextBoxColumn.HeaderText = "體積";
            this.體積DataGridViewTextBoxColumn.Name = "體積DataGridViewTextBoxColumn";
            this.體積DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 商品詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 583);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.品牌);
            this.Controls.Add(this.新版頁索引元件1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.進價);
            this.Controls.Add(this.物品);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.新增);
            this.Controls.Add(this.數量);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.利潤);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.體積);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.成本);
            this.Controls.Add(this.小類);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.售價);
            this.Controls.Add(this.寄庫數量);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.客戶);
            this.Controls.Add(this.公司);
            this.Controls.Add(this.大類);
            this.Controls.Add(this.品號);
            this.Controls.Add(this.名稱);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "商品詳細視窗";
            this.Text = "商品詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.利潤)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.體積)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.售價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.寄庫數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品組成資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.進價)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.TextBox 品號;
        private 商品大類選取元件 大類;
        private 公司.公司選取元件 公司;
        private 客戶.客戶選取元件 客戶;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown 寄庫數量;
        private System.Windows.Forms.NumericUpDown 售價;
        private System.Windows.Forms.Label label6;
        private 商品小類選取元件 小類;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown 成本;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown 利潤;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown 體積;
        private 物品.物品選取元件 物品;
        private MyDataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 商品組成資料BindingSource;
        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.NumericUpDown 數量;
        private System.Windows.Forms.BindingSource 物品資料BindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown 進價;
        private 新版頁索引元件 新版頁索引元件1;
        private System.Windows.Forms.Label label15;
        private 物品.物品品牌選取元件 品牌;
        private System.Windows.Forms.DataGridViewTextBoxColumn 群組DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 規格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 體積DataGridViewTextBoxColumn;
    }
}