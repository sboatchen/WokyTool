using WokyTool.物品;
namespace WokyTool.商品
{
    partial class 商品更新詳細視窗
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
            this.錯誤訊息 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.商品組成資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.更新狀態 = new WokyTool.通用.更新狀態選取元件();
            this.新版頁索引元件1 = new WokyTool.通用.新版頁索引元件();
            this.label11 = new System.Windows.Forms.Label();
            this.組成 = new System.Windows.Forms.TextBox();
            this.新增群組 = new System.Windows.Forms.NumericUpDown();
            this.子客戶 = new WokyTool.客戶.子客戶選取元件();
            this.新增售價 = new System.Windows.Forms.NumericUpDown();
            this.新增2 = new System.Windows.Forms.Button();
            this.新增規格 = new System.Windows.Forms.TextBox();
            this.自訂售價GV = new WokyTool.通用.MyDataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.品牌 = new WokyTool.物品.品牌選取元件();
            this.label9 = new System.Windows.Forms.Label();
            this.進價 = new System.Windows.Forms.NumericUpDown();
            this.新增物品 = new WokyTool.物品.物品選取元件();
            this.dataGridView1 = new WokyTool.通用.MyDataGridView();
            this.新增 = new System.Windows.Forms.Button();
            this.新增數量 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.利潤 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.體積 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.成本 = new System.Windows.Forms.NumericUpDown();
            this.小類 = new WokyTool.物品.供應商選取元件();
            this.label6 = new System.Windows.Forms.Label();
            this.售價 = new System.Windows.Forms.NumericUpDown();
            this.寄庫數量 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.客戶 = new WokyTool.客戶.客戶選取元件();
            this.公司 = new WokyTool.公司.公司選取元件();
            this.大類 = new WokyTool.物品.品類選取元件();
            this.品號 = new System.Windows.Forms.TextBox();
            this.名稱 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.群組DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.規格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.商品組成資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.新增群組)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.新增售價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.自訂售價GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.進價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.新增數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.利潤)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.體積)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.售價)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.寄庫數量)).BeginInit();
            this.SuspendLayout();
            // 
            // 錯誤訊息
            // 
            this.錯誤訊息.Location = new System.Drawing.Point(298, 12);
            this.錯誤訊息.Name = "錯誤訊息";
            this.錯誤訊息.ReadOnly = true;
            this.錯誤訊息.Size = new System.Drawing.Size(728, 22);
            this.錯誤訊息.TabIndex = 116;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(237, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 114;
            this.label17.Text = "錯誤訊息";
            // 
            // 商品組成資料BindingSource
            // 
            this.商品組成資料BindingSource.DataSource = typeof(WokyTool.商品.商品組成資料);
            // 
            // 更新狀態
            // 
            this.更新狀態.Location = new System.Drawing.Point(5, 11);
            this.更新狀態.Margin = new System.Windows.Forms.Padding(4);
            this.更新狀態.Name = "更新狀態";
            this.更新狀態.ReadOnly = true;
            this.更新狀態.SelectedItem = WokyTool.通用.列舉.更新狀態.錯誤;
            this.更新狀態.Size = new System.Drawing.Size(225, 28);
            this.更新狀態.TabIndex = 117;
            this.更新狀態.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 新版頁索引元件1
            // 
            this.新版頁索引元件1.Location = new System.Drawing.Point(458, 621);
            this.新版頁索引元件1.Name = "新版頁索引元件1";
            this.新版頁索引元件1.Size = new System.Drawing.Size(234, 34);
            this.新版頁索引元件1.TabIndex = 216;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 255;
            this.label11.Text = "組成";
            // 
            // 組成
            // 
            this.組成.Location = new System.Drawing.Point(406, 418);
            this.組成.Name = "組成";
            this.組成.ReadOnly = true;
            this.組成.Size = new System.Drawing.Size(390, 22);
            this.組成.TabIndex = 254;
            // 
            // 新增群組
            // 
            this.新增群組.Location = new System.Drawing.Point(65, 154);
            this.新增群組.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.新增群組.Name = "新增群組";
            this.新增群組.Size = new System.Drawing.Size(95, 22);
            this.新增群組.TabIndex = 253;
            // 
            // 子客戶
            // 
            this.子客戶.Location = new System.Drawing.Point(65, 419);
            this.子客戶.Name = "子客戶";
            this.子客戶.ReadOnly = false;
            this.子客戶.SelectedItem = null;
            this.子客戶.Size = new System.Drawing.Size(185, 22);
            this.子客戶.TabIndex = 252;
            this.子客戶.元件類型 = WokyTool.通用.選取元件類型.篩選;
            // 
            // 新增售價
            // 
            this.新增售價.DecimalPlaces = 3;
            this.新增售價.Location = new System.Drawing.Point(254, 419);
            this.新增售價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.新增售價.Name = "新增售價";
            this.新增售價.Size = new System.Drawing.Size(86, 22);
            this.新增售價.TabIndex = 251;
            // 
            // 新增2
            // 
            this.新增2.Location = new System.Drawing.Point(18, 417);
            this.新增2.Name = "新增2";
            this.新增2.Size = new System.Drawing.Size(40, 23);
            this.新增2.TabIndex = 250;
            this.新增2.Text = "新增";
            this.新增2.UseVisualStyleBackColor = true;
            // 
            // 新增規格
            // 
            this.新增規格.Location = new System.Drawing.Point(162, 154);
            this.新增規格.Name = "新增規格";
            this.新增規格.Size = new System.Drawing.Size(95, 22);
            this.新增規格.TabIndex = 249;
            // 
            // 自訂售價GV
            // 
            this.自訂售價GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.自訂售價GV.Location = new System.Drawing.Point(18, 446);
            this.自訂售價GV.Name = "自訂售價GV";
            this.自訂售價GV.RowTemplate.Height = 24;
            this.自訂售價GV.Size = new System.Drawing.Size(336, 150);
            this.自訂售價GV.TabIndex = 248;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(483, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 247;
            this.label15.Text = "品牌";
            // 
            // 品牌
            // 
            this.品牌.Location = new System.Drawing.Point(526, 78);
            this.品牌.Margin = new System.Windows.Forms.Padding(4);
            this.品牌.Name = "品牌";
            this.品牌.ReadOnly = true;
            this.品牌.SelectedItem = null;
            this.品牌.Size = new System.Drawing.Size(172, 25);
            this.品牌.TabIndex = 246;
            this.品牌.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(587, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 244;
            this.label9.Text = "進價";
            // 
            // 進價
            // 
            this.進價.DecimalPlaces = 3;
            this.進價.Location = new System.Drawing.Point(631, 449);
            this.進價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.進價.Name = "進價";
            this.進價.Size = new System.Drawing.Size(165, 22);
            this.進價.TabIndex = 243;
            // 
            // 新增物品
            // 
            this.新增物品.Location = new System.Drawing.Point(260, 155);
            this.新增物品.Margin = new System.Windows.Forms.Padding(4);
            this.新增物品.Name = "新增物品";
            this.新增物品.ReadOnly = false;
            this.新增物品.SelectedItem = null;
            this.新增物品.Size = new System.Drawing.Size(423, 24);
            this.新增物品.TabIndex = 242;
            this.新增物品.元件類型 = WokyTool.通用.選取元件類型.指定;
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
            this.數量DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.商品組成資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 229);
            this.dataGridView1.TabIndex = 241;
            // 
            // 新增
            // 
            this.新增.Location = new System.Drawing.Point(18, 153);
            this.新增.Name = "新增";
            this.新增.Size = new System.Drawing.Size(40, 23);
            this.新增.TabIndex = 240;
            this.新增.Text = "新增";
            this.新增.UseVisualStyleBackColor = true;
            // 
            // 新增數量
            // 
            this.新增數量.Location = new System.Drawing.Point(684, 154);
            this.新增數量.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.新增數量.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.新增數量.Name = "新增數量";
            this.新增數量.Size = new System.Drawing.Size(75, 22);
            this.新增數量.TabIndex = 239;
            this.新增數量.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 482);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 238;
            this.label12.Text = "利潤";
            // 
            // 利潤
            // 
            this.利潤.DecimalPlaces = 3;
            this.利潤.Location = new System.Drawing.Point(406, 478);
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
            this.利潤.TabIndex = 237;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(363, 514);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 236;
            this.label13.Text = "體積";
            // 
            // 體積
            // 
            this.體積.Location = new System.Drawing.Point(406, 511);
            this.體積.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.體積.Name = "體積";
            this.體積.ReadOnly = true;
            this.體積.Size = new System.Drawing.Size(165, 22);
            this.體積.TabIndex = 235;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 234;
            this.label10.Text = "成本";
            // 
            // 成本
            // 
            this.成本.DecimalPlaces = 3;
            this.成本.Location = new System.Drawing.Point(406, 446);
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
            this.成本.TabIndex = 233;
            // 
            // 小類
            // 
            this.小類.Location = new System.Drawing.Point(296, 78);
            this.小類.Margin = new System.Windows.Forms.Padding(4);
            this.小類.Name = "小類";
            this.小類.ReadOnly = false;
            this.小類.SelectedItem = null;
            this.小類.Size = new System.Drawing.Size(172, 25);
            this.小類.TabIndex = 232;
            this.小類.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 231;
            this.label6.Text = "售價";
            // 
            // 售價
            // 
            this.售價.DecimalPlaces = 3;
            this.售價.Location = new System.Drawing.Point(631, 480);
            this.售價.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.售價.Name = "售價";
            this.售價.Size = new System.Drawing.Size(165, 22);
            this.售價.TabIndex = 230;
            // 
            // 寄庫數量
            // 
            this.寄庫數量.Location = new System.Drawing.Point(632, 511);
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
            this.寄庫數量.TabIndex = 229;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 228;
            this.label3.Text = "寄庫數量";
            // 
            // 客戶
            // 
            this.客戶.Location = new System.Drawing.Point(296, 109);
            this.客戶.Margin = new System.Windows.Forms.Padding(4);
            this.客戶.Name = "客戶";
            this.客戶.ReadOnly = false;
            this.客戶.SelectedItem = null;
            this.客戶.Size = new System.Drawing.Size(190, 25);
            this.客戶.TabIndex = 227;
            this.客戶.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 公司
            // 
            this.公司.Location = new System.Drawing.Point(61, 109);
            this.公司.Margin = new System.Windows.Forms.Padding(4);
            this.公司.Name = "公司";
            this.公司.ReadOnly = false;
            this.公司.SelectedItem = null;
            this.公司.Size = new System.Drawing.Size(172, 25);
            this.公司.TabIndex = 226;
            this.公司.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 大類
            // 
            this.大類.Location = new System.Drawing.Point(61, 78);
            this.大類.Margin = new System.Windows.Forms.Padding(4);
            this.大類.Name = "大類";
            this.大類.ReadOnly = false;
            this.大類.SelectedItem = null;
            this.大類.Size = new System.Drawing.Size(172, 25);
            this.大類.TabIndex = 225;
            this.大類.元件類型 = WokyTool.通用.選取元件類型.指定;
            // 
            // 品號
            // 
            this.品號.Location = new System.Drawing.Point(526, 46);
            this.品號.Name = "品號";
            this.品號.Size = new System.Drawing.Size(165, 22);
            this.品號.TabIndex = 224;
            // 
            // 名稱
            // 
            this.名稱.Location = new System.Drawing.Point(61, 46);
            this.名稱.Name = "名稱";
            this.名稱.Size = new System.Drawing.Size(400, 22);
            this.名稱.TabIndex = 223;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 222;
            this.label8.Text = "品號";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 221;
            this.label7.Text = "名稱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 220;
            this.label5.Text = "客戶";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 219;
            this.label4.Text = "公司";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 218;
            this.label2.Text = "小類";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 217;
            this.label1.Text = "大類";
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
            // 商品更新詳細視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1746, 665);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.組成);
            this.Controls.Add(this.新增群組);
            this.Controls.Add(this.子客戶);
            this.Controls.Add(this.新增售價);
            this.Controls.Add(this.新增2);
            this.Controls.Add(this.新增規格);
            this.Controls.Add(this.自訂售價GV);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.品牌);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.進價);
            this.Controls.Add(this.新增物品);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.新增);
            this.Controls.Add(this.新增數量);
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
            this.Controls.Add(this.新版頁索引元件1);
            this.Controls.Add(this.更新狀態);
            this.Controls.Add(this.錯誤訊息);
            this.Controls.Add(this.label17);
            this.Name = "商品更新詳細視窗";
            this.Text = "商品更新詳細視窗";
            ((System.ComponentModel.ISupportInitialize)(this.商品組成資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.新增群組)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.新增售價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.自訂售價GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.進價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.新增數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.利潤)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.體積)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.成本)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.售價)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.寄庫數量)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 通用.更新狀態選取元件 更新狀態;
        private System.Windows.Forms.TextBox 錯誤訊息;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource 商品組成資料BindingSource;
        private 通用.新版頁索引元件 新版頁索引元件1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox 組成;
        private System.Windows.Forms.NumericUpDown 新增群組;
        private 客戶.子客戶選取元件 子客戶;
        private System.Windows.Forms.NumericUpDown 新增售價;
        private System.Windows.Forms.Button 新增2;
        private System.Windows.Forms.TextBox 新增規格;
        private 通用.MyDataGridView 自訂售價GV;
        private System.Windows.Forms.Label label15;
        private 品牌選取元件 品牌;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown 進價;
        private 物品選取元件 新增物品;
        private 通用.MyDataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 群組DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 規格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button 新增;
        private System.Windows.Forms.NumericUpDown 新增數量;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown 利潤;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown 體積;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown 成本;
        private 供應商選取元件 小類;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown 售價;
        private System.Windows.Forms.NumericUpDown 寄庫數量;
        private System.Windows.Forms.Label label3;
        private 客戶.客戶選取元件 客戶;
        private 公司.公司選取元件 公司;
        private 品類選取元件 大類;
        private System.Windows.Forms.TextBox 品號;
        private System.Windows.Forms.TextBox 名稱;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}