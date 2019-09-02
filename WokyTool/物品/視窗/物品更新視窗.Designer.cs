using WokyTool.通用;
namespace WokyTool.物品
{
    partial class 物品更新視窗
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
            this.樣板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new WokyTool.通用.MyDataGridView();
            this.更新狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.縮寫DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.大類識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小類識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品牌識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.條碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.原廠編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.代理編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.類別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顏色DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.體積DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.庫存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.庫存總成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最後進貨成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本備註DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.錯誤訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品更新資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品更新資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.樣板ToolStripMenuItem,
            this.匯入ToolStripMenuItem,
            this.篩選ToolStripMenuItem,
            this.檢查ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2424, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 樣板ToolStripMenuItem
            // 
            this.樣板ToolStripMenuItem.Name = "樣板ToolStripMenuItem";
            this.樣板ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.樣板ToolStripMenuItem.Text = "樣板";
            // 
            // 匯入ToolStripMenuItem
            // 
            this.匯入ToolStripMenuItem.Name = "匯入ToolStripMenuItem";
            this.匯入ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.匯入ToolStripMenuItem.Text = "匯入";
            this.匯入ToolStripMenuItem.Click += new System.EventHandler(this.匯入ToolStripMenuItem_Click);
            // 
            // 篩選ToolStripMenuItem
            // 
            this.篩選ToolStripMenuItem.Name = "篩選ToolStripMenuItem";
            this.篩選ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.篩選ToolStripMenuItem.Text = "篩選";
            // 
            // 檢查ToolStripMenuItem
            // 
            this.檢查ToolStripMenuItem.Name = "檢查ToolStripMenuItem";
            this.檢查ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.檢查ToolStripMenuItem.Text = "檢查";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.更新狀態DataGridViewTextBoxColumn,
            this.編號DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.縮寫DataGridViewTextBoxColumn,
            this.大類識別DataGridViewTextBoxColumn,
            this.小類識別DataGridViewTextBoxColumn,
            this.品牌識別DataGridViewTextBoxColumn,
            this.條碼DataGridViewTextBoxColumn,
            this.原廠編號DataGridViewTextBoxColumn,
            this.代理編號DataGridViewTextBoxColumn,
            this.類別DataGridViewTextBoxColumn,
            this.顏色DataGridViewTextBoxColumn,
            this.體積DataGridViewTextBoxColumn,
            this.庫存DataGridViewTextBoxColumn,
            this.庫存總成本DataGridViewTextBoxColumn,
            this.最後進貨成本DataGridViewTextBoxColumn,
            this.成本DataGridViewTextBoxColumn,
            this.成本備註DataGridViewTextBoxColumn,
            this.錯誤訊息DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.物品更新資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(2424, 503);
            this.dataGridView1.TabIndex = 2;
            // 
            // 更新狀態DataGridViewTextBoxColumn
            // 
            this.更新狀態DataGridViewTextBoxColumn.DataPropertyName = "更新狀態";
            this.更新狀態DataGridViewTextBoxColumn.HeaderText = "更新狀態";
            this.更新狀態DataGridViewTextBoxColumn.Name = "更新狀態DataGridViewTextBoxColumn";
            this.更新狀態DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            this.名稱DataGridViewTextBoxColumn.Width = 200;
            // 
            // 縮寫DataGridViewTextBoxColumn
            // 
            this.縮寫DataGridViewTextBoxColumn.DataPropertyName = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.HeaderText = "縮寫";
            this.縮寫DataGridViewTextBoxColumn.Name = "縮寫DataGridViewTextBoxColumn";
            // 
            // 大類識別DataGridViewTextBoxColumn
            // 
            this.大類識別DataGridViewTextBoxColumn.DataPropertyName = "大類識別";
            this.大類識別DataGridViewTextBoxColumn.HeaderText = "大類";
            this.大類識別DataGridViewTextBoxColumn.Name = "大類識別DataGridViewTextBoxColumn";
            // 
            // 小類識別DataGridViewTextBoxColumn
            // 
            this.小類識別DataGridViewTextBoxColumn.DataPropertyName = "小類識別";
            this.小類識別DataGridViewTextBoxColumn.HeaderText = "小類";
            this.小類識別DataGridViewTextBoxColumn.Name = "小類識別DataGridViewTextBoxColumn";
            // 
            // 品牌識別DataGridViewTextBoxColumn
            // 
            this.品牌識別DataGridViewTextBoxColumn.DataPropertyName = "品牌識別";
            this.品牌識別DataGridViewTextBoxColumn.HeaderText = "品牌";
            this.品牌識別DataGridViewTextBoxColumn.Name = "品牌識別DataGridViewTextBoxColumn";
            // 
            // 條碼DataGridViewTextBoxColumn
            // 
            this.條碼DataGridViewTextBoxColumn.DataPropertyName = "條碼";
            this.條碼DataGridViewTextBoxColumn.HeaderText = "條碼";
            this.條碼DataGridViewTextBoxColumn.Name = "條碼DataGridViewTextBoxColumn";
            // 
            // 原廠編號DataGridViewTextBoxColumn
            // 
            this.原廠編號DataGridViewTextBoxColumn.DataPropertyName = "原廠編號";
            this.原廠編號DataGridViewTextBoxColumn.HeaderText = "原廠編號";
            this.原廠編號DataGridViewTextBoxColumn.Name = "原廠編號DataGridViewTextBoxColumn";
            // 
            // 代理編號DataGridViewTextBoxColumn
            // 
            this.代理編號DataGridViewTextBoxColumn.DataPropertyName = "代理編號";
            this.代理編號DataGridViewTextBoxColumn.HeaderText = "代理編號";
            this.代理編號DataGridViewTextBoxColumn.Name = "代理編號DataGridViewTextBoxColumn";
            // 
            // 類別DataGridViewTextBoxColumn
            // 
            this.類別DataGridViewTextBoxColumn.DataPropertyName = "類別";
            this.類別DataGridViewTextBoxColumn.HeaderText = "類別";
            this.類別DataGridViewTextBoxColumn.Name = "類別DataGridViewTextBoxColumn";
            // 
            // 顏色DataGridViewTextBoxColumn
            // 
            this.顏色DataGridViewTextBoxColumn.DataPropertyName = "顏色";
            this.顏色DataGridViewTextBoxColumn.HeaderText = "顏色";
            this.顏色DataGridViewTextBoxColumn.Name = "顏色DataGridViewTextBoxColumn";
            // 
            // 體積DataGridViewTextBoxColumn
            // 
            this.體積DataGridViewTextBoxColumn.DataPropertyName = "體積";
            this.體積DataGridViewTextBoxColumn.HeaderText = "體積";
            this.體積DataGridViewTextBoxColumn.Name = "體積DataGridViewTextBoxColumn";
            // 
            // 庫存DataGridViewTextBoxColumn
            // 
            this.庫存DataGridViewTextBoxColumn.DataPropertyName = "庫存";
            this.庫存DataGridViewTextBoxColumn.HeaderText = "庫存";
            this.庫存DataGridViewTextBoxColumn.Name = "庫存DataGridViewTextBoxColumn";
            // 
            // 庫存總成本DataGridViewTextBoxColumn
            // 
            this.庫存總成本DataGridViewTextBoxColumn.DataPropertyName = "庫存總成本";
            this.庫存總成本DataGridViewTextBoxColumn.HeaderText = "庫存總成本";
            this.庫存總成本DataGridViewTextBoxColumn.Name = "庫存總成本DataGridViewTextBoxColumn";
            // 
            // 最後進貨成本DataGridViewTextBoxColumn
            // 
            this.最後進貨成本DataGridViewTextBoxColumn.DataPropertyName = "最後進貨成本";
            this.最後進貨成本DataGridViewTextBoxColumn.HeaderText = "最後進貨成本";
            this.最後進貨成本DataGridViewTextBoxColumn.Name = "最後進貨成本DataGridViewTextBoxColumn";
            // 
            // 成本DataGridViewTextBoxColumn
            // 
            this.成本DataGridViewTextBoxColumn.DataPropertyName = "成本";
            this.成本DataGridViewTextBoxColumn.HeaderText = "成本";
            this.成本DataGridViewTextBoxColumn.Name = "成本DataGridViewTextBoxColumn";
            this.成本DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 成本備註DataGridViewTextBoxColumn
            // 
            this.成本備註DataGridViewTextBoxColumn.DataPropertyName = "成本備註";
            this.成本備註DataGridViewTextBoxColumn.HeaderText = "成本備註";
            this.成本備註DataGridViewTextBoxColumn.Name = "成本備註DataGridViewTextBoxColumn";
            // 
            // 錯誤訊息DataGridViewTextBoxColumn
            // 
            this.錯誤訊息DataGridViewTextBoxColumn.DataPropertyName = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.HeaderText = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.Name = "錯誤訊息DataGridViewTextBoxColumn";
            this.錯誤訊息DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 物品更新資料BindingSource
            // 
            this.物品更新資料BindingSource.DataSource = typeof(WokyTool.物品.物品更新資料);
            // 
            // 物品更新視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2424, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "物品更新視窗";
            this.Text = "物品更新視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物品更新資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 樣板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯入ToolStripMenuItem;
        private MyDataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 物品更新資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 更新狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 縮寫DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 大類識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小類識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 條碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 原廠編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 代理編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 類別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顏色DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 體積DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 庫存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 庫存總成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最後進貨成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本備註DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 錯誤訊息DataGridViewTextBoxColumn;
    }
}