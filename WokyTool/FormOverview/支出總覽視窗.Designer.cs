namespace WokyTool
{
    partial class 支出總覽視窗
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.略過ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.支出資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.建立時間DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.類型DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.廠商DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.總價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.幣值DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.匯率DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.總金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.支出資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.略過ToolStripMenuItem,
            this.結算ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 略過ToolStripMenuItem
            // 
            this.略過ToolStripMenuItem.Name = "略過ToolStripMenuItem";
            this.略過ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.略過ToolStripMenuItem.Text = "略過";
            this.略過ToolStripMenuItem.Click += new System.EventHandler(this.略過ToolStripMenuItem_Click);
            // 
            // 結算ToolStripMenuItem
            // 
            this.結算ToolStripMenuItem.Name = "結算ToolStripMenuItem";
            this.結算ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.結算ToolStripMenuItem.Text = "結算";
            this.結算ToolStripMenuItem.Click += new System.EventHandler(this.結算ToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(428, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(404, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // 支出資料BindingSource
            // 
            this.支出資料BindingSource.DataSource = typeof(WokyTool.Data.支出資料);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.建立時間DataGridViewTextBoxColumn,
            this.編號DataGridViewTextBoxColumn,
            this.類型DataGridViewTextBoxColumn,
            this.廠商DataGridViewTextBoxColumn,
            this.物品DataGridViewTextBoxColumn,
            this.數量DataGridViewTextBoxColumn,
            this.單價DataGridViewTextBoxColumn,
            this.總價DataGridViewTextBoxColumn,
            this.幣值DataGridViewTextBoxColumn,
            this.匯率DataGridViewTextBoxColumn,
            this.總金額DataGridViewTextBoxColumn,
            this.備註DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.支出資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 463);
            this.dataGridView1.TabIndex = 4;
            // 
            // 建立時間DataGridViewTextBoxColumn
            // 
            this.建立時間DataGridViewTextBoxColumn.DataPropertyName = "建立時間";
            this.建立時間DataGridViewTextBoxColumn.HeaderText = "建立時間";
            this.建立時間DataGridViewTextBoxColumn.Name = "建立時間DataGridViewTextBoxColumn";
            this.建立時間DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 類型DataGridViewTextBoxColumn
            // 
            this.類型DataGridViewTextBoxColumn.DataPropertyName = "類型";
            this.類型DataGridViewTextBoxColumn.HeaderText = "類型";
            this.類型DataGridViewTextBoxColumn.Name = "類型DataGridViewTextBoxColumn";
            this.類型DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 廠商DataGridViewTextBoxColumn
            // 
            this.廠商DataGridViewTextBoxColumn.DataPropertyName = "廠商";
            this.廠商DataGridViewTextBoxColumn.HeaderText = "廠商";
            this.廠商DataGridViewTextBoxColumn.Name = "廠商DataGridViewTextBoxColumn";
            this.廠商DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 物品DataGridViewTextBoxColumn
            // 
            this.物品DataGridViewTextBoxColumn.DataPropertyName = "物品";
            this.物品DataGridViewTextBoxColumn.HeaderText = "物品";
            this.物品DataGridViewTextBoxColumn.Name = "物品DataGridViewTextBoxColumn";
            this.物品DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 數量DataGridViewTextBoxColumn
            // 
            this.數量DataGridViewTextBoxColumn.DataPropertyName = "數量";
            this.數量DataGridViewTextBoxColumn.HeaderText = "數量";
            this.數量DataGridViewTextBoxColumn.Name = "數量DataGridViewTextBoxColumn";
            this.數量DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 單價DataGridViewTextBoxColumn
            // 
            this.單價DataGridViewTextBoxColumn.DataPropertyName = "單價";
            this.單價DataGridViewTextBoxColumn.HeaderText = "單價";
            this.單價DataGridViewTextBoxColumn.Name = "單價DataGridViewTextBoxColumn";
            this.單價DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 總價DataGridViewTextBoxColumn
            // 
            this.總價DataGridViewTextBoxColumn.DataPropertyName = "總價";
            this.總價DataGridViewTextBoxColumn.HeaderText = "總價";
            this.總價DataGridViewTextBoxColumn.Name = "總價DataGridViewTextBoxColumn";
            this.總價DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 幣值DataGridViewTextBoxColumn
            // 
            this.幣值DataGridViewTextBoxColumn.DataPropertyName = "幣值";
            this.幣值DataGridViewTextBoxColumn.HeaderText = "幣值";
            this.幣值DataGridViewTextBoxColumn.Name = "幣值DataGridViewTextBoxColumn";
            this.幣值DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 匯率DataGridViewTextBoxColumn
            // 
            this.匯率DataGridViewTextBoxColumn.DataPropertyName = "匯率";
            this.匯率DataGridViewTextBoxColumn.HeaderText = "匯率";
            this.匯率DataGridViewTextBoxColumn.Name = "匯率DataGridViewTextBoxColumn";
            this.匯率DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 總金額DataGridViewTextBoxColumn
            // 
            this.總金額DataGridViewTextBoxColumn.DataPropertyName = "總金額";
            this.總金額DataGridViewTextBoxColumn.HeaderText = "總金額";
            this.總金額DataGridViewTextBoxColumn.Name = "總金額DataGridViewTextBoxColumn";
            this.總金額DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 備註DataGridViewTextBoxColumn
            // 
            this.備註DataGridViewTextBoxColumn.DataPropertyName = "備註";
            this.備註DataGridViewTextBoxColumn.HeaderText = "備註";
            this.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn";
            this.備註DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 支出總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "支出總覽視窗";
            this.Text = "支出總覽視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.支出資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource 支出資料BindingSource;
        private System.Windows.Forms.ToolStripMenuItem 略過ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結算ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建立時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 類型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 廠商DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 總價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 幣值DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 匯率DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 總金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註DataGridViewTextBoxColumn;
    }
}