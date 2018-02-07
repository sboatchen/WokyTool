namespace WokyTool.FormOther
{
    partial class 工廠出貨視窗
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
            this.button1 = new System.Windows.Forms.Button();
            this.姓名 = new System.Windows.Forms.TextBox();
            this.手機 = new System.Windows.Forms.TextBox();
            this.電話 = new System.Windows.Forms.TextBox();
            this.地址 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.物品編號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品顯示名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品訂單資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.廠商comboBox = new System.Windows.Forms.ComboBox();
            this.廠商資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品訂單資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "電話";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "手機";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 姓名
            // 
            this.姓名.Location = new System.Drawing.Point(57, 33);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(207, 22);
            this.姓名.TabIndex = 6;
            // 
            // 手機
            // 
            this.手機.Location = new System.Drawing.Point(357, 59);
            this.手機.Name = "手機";
            this.手機.Size = new System.Drawing.Size(207, 22);
            this.手機.TabIndex = 7;
            // 
            // 電話
            // 
            this.電話.Location = new System.Drawing.Point(357, 30);
            this.電話.Name = "電話";
            this.電話.Size = new System.Drawing.Size(207, 22);
            this.電話.TabIndex = 8;
            // 
            // 地址
            // 
            this.地址.Location = new System.Drawing.Point(57, 61);
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(207, 22);
            this.地址.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.物品編號,
            this.物品顯示名稱DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.單價DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.物品訂單資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 375);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // 物品編號
            // 
            this.物品編號.DataPropertyName = "物品編號";
            this.物品編號.HeaderText = "物品編號";
            this.物品編號.Name = "物品編號";
            // 
            // 物品顯示名稱DataGridViewTextBoxColumn
            // 
            this.物品顯示名稱DataGridViewTextBoxColumn.DataPropertyName = "物品顯示名稱";
            this.物品顯示名稱DataGridViewTextBoxColumn.HeaderText = "物品";
            this.物品顯示名稱DataGridViewTextBoxColumn.Name = "物品顯示名稱DataGridViewTextBoxColumn";
            this.物品顯示名稱DataGridViewTextBoxColumn.ReadOnly = true;
            this.物品顯示名稱DataGridViewTextBoxColumn.Width = 250;
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            // 
            // 單價DataGridViewTextBoxColumn
            // 
            this.單價DataGridViewTextBoxColumn.DataPropertyName = "單價";
            this.單價DataGridViewTextBoxColumn.HeaderText = "單價";
            this.單價DataGridViewTextBoxColumn.Name = "單價DataGridViewTextBoxColumn";
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            // 
            // 物品訂單資料BindingSource
            // 
            this.物品訂單資料BindingSource.DataSource = typeof(WokyTool.Data.物品訂單資料);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "廠商";
            // 
            // 廠商comboBox
            // 
            this.廠商comboBox.DataSource = this.廠商資料BindingSource;
            this.廠商comboBox.DisplayMember = "名稱";
            this.廠商comboBox.FormattingEnabled = true;
            this.廠商comboBox.Location = new System.Drawing.Point(57, 8);
            this.廠商comboBox.Name = "廠商comboBox";
            this.廠商comboBox.Size = new System.Drawing.Size(207, 20);
            this.廠商comboBox.TabIndex = 12;
            this.廠商comboBox.SelectionChangeCommitted += new System.EventHandler(this.廠商comboBox_SelectionChangeCommitted);
            // 
            // 廠商資料BindingSource
            // 
            this.廠商資料BindingSource.DataSource = typeof(WokyTool.Data.廠商資料);
            // 
            // 工廠出貨視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 521);
            this.Controls.Add(this.廠商comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.地址);
            this.Controls.Add(this.電話);
            this.Controls.Add(this.手機);
            this.Controls.Add(this.姓名);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "工廠出貨視窗";
            this.Text = "工廠出貨視窗";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.工廠出貨視窗_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品訂單資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.廠商資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox 姓名;
        private System.Windows.Forms.TextBox 手機;
        private System.Windows.Forms.TextBox 電話;
        private System.Windows.Forms.TextBox 地址;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 物品訂單資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品編號;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品顯示名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox 廠商comboBox;
        private System.Windows.Forms.BindingSource 廠商資料BindingSource;
    }
}