using WokyTool.通用;
namespace WokyTool.商品
{
    partial class 商品更新視窗
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
            this.商品更新資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.更新狀態DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客戶識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品類識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.供應商識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品牌名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.進價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.售價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.寄庫數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.利潤DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.體積DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.組成字串識別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.錯誤訊息DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品更新資料BindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1818, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 樣板ToolStripMenuItem
            // 
            this.樣板ToolStripMenuItem.Name = "樣板ToolStripMenuItem";
            this.樣板ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.樣板ToolStripMenuItem.Text = "樣板";
            // 
            // 匯入ToolStripMenuItem
            // 
            this.匯入ToolStripMenuItem.Name = "匯入ToolStripMenuItem";
            this.匯入ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯入ToolStripMenuItem.Text = "匯入";
            this.匯入ToolStripMenuItem.Click += new System.EventHandler(this.匯入ToolStripMenuItem_Click);
            // 
            // 篩選ToolStripMenuItem
            // 
            this.篩選ToolStripMenuItem.Name = "篩選ToolStripMenuItem";
            this.篩選ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.篩選ToolStripMenuItem.Text = "篩選";
            // 
            // 檢查ToolStripMenuItem
            // 
            this.檢查ToolStripMenuItem.Name = "檢查ToolStripMenuItem";
            this.檢查ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檢查ToolStripMenuItem.Text = "檢查";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.更新狀態DataGridViewTextBoxColumn,
            this.公司識別DataGridViewTextBoxColumn,
            this.客戶識別DataGridViewTextBoxColumn,
            this.品類識別DataGridViewTextBoxColumn,
            this.供應商識別DataGridViewTextBoxColumn,
            this.品牌名稱DataGridViewTextBoxColumn,
            this.品號DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.進價DataGridViewTextBoxColumn,
            this.售價DataGridViewTextBoxColumn,
            this.寄庫數量DataGridViewTextBoxColumn,
            this.成本DataGridViewTextBoxColumn,
            this.利潤DataGridViewTextBoxColumn,
            this.體積DataGridViewTextBoxColumn,
            this.組成字串識別DataGridViewTextBoxColumn,
            this.錯誤訊息DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.商品更新資料BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1818, 400);
            this.dataGridView1.TabIndex = 2;
            // 
            // 商品更新資料BindingSource
            // 
            this.商品更新資料BindingSource.DataSource = typeof(WokyTool.商品.商品更新資料);
            // 
            // 更新狀態DataGridViewTextBoxColumn
            // 
            this.更新狀態DataGridViewTextBoxColumn.DataPropertyName = "更新狀態";
            this.更新狀態DataGridViewTextBoxColumn.HeaderText = "更新狀態";
            this.更新狀態DataGridViewTextBoxColumn.Name = "更新狀態DataGridViewTextBoxColumn";
            this.更新狀態DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 公司識別DataGridViewTextBoxColumn
            // 
            this.公司識別DataGridViewTextBoxColumn.DataPropertyName = "公司識別";
            this.公司識別DataGridViewTextBoxColumn.HeaderText = "公司";
            this.公司識別DataGridViewTextBoxColumn.Name = "公司識別DataGridViewTextBoxColumn";
            // 
            // 客戶識別DataGridViewTextBoxColumn
            // 
            this.客戶識別DataGridViewTextBoxColumn.DataPropertyName = "客戶識別";
            this.客戶識別DataGridViewTextBoxColumn.HeaderText = "客戶";
            this.客戶識別DataGridViewTextBoxColumn.Name = "客戶識別DataGridViewTextBoxColumn";
            // 
            // 品類識別DataGridViewTextBoxColumn
            // 
            this.品類識別DataGridViewTextBoxColumn.DataPropertyName = "品類識別";
            this.品類識別DataGridViewTextBoxColumn.HeaderText = "品類";
            this.品類識別DataGridViewTextBoxColumn.Name = "品類識別DataGridViewTextBoxColumn";
            // 
            // 供應商識別DataGridViewTextBoxColumn
            // 
            this.供應商識別DataGridViewTextBoxColumn.DataPropertyName = "供應商識別";
            this.供應商識別DataGridViewTextBoxColumn.HeaderText = "供應商";
            this.供應商識別DataGridViewTextBoxColumn.Name = "供應商識別DataGridViewTextBoxColumn";
            // 
            // 品牌名稱DataGridViewTextBoxColumn
            // 
            this.品牌名稱DataGridViewTextBoxColumn.DataPropertyName = "品牌名稱";
            this.品牌名稱DataGridViewTextBoxColumn.HeaderText = "品牌";
            this.品牌名稱DataGridViewTextBoxColumn.Name = "品牌名稱DataGridViewTextBoxColumn";
            this.品牌名稱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 品號DataGridViewTextBoxColumn
            // 
            this.品號DataGridViewTextBoxColumn.DataPropertyName = "品號";
            this.品號DataGridViewTextBoxColumn.HeaderText = "品號";
            this.品號DataGridViewTextBoxColumn.Name = "品號DataGridViewTextBoxColumn";
            // 
            // 名稱DataGridViewTextBoxColumn
            // 
            this.名稱DataGridViewTextBoxColumn.DataPropertyName = "名稱";
            this.名稱DataGridViewTextBoxColumn.HeaderText = "名稱";
            this.名稱DataGridViewTextBoxColumn.Name = "名稱DataGridViewTextBoxColumn";
            this.名稱DataGridViewTextBoxColumn.Width = 200;
            // 
            // 進價DataGridViewTextBoxColumn
            // 
            this.進價DataGridViewTextBoxColumn.DataPropertyName = "進價";
            this.進價DataGridViewTextBoxColumn.HeaderText = "進價";
            this.進價DataGridViewTextBoxColumn.Name = "進價DataGridViewTextBoxColumn";
            // 
            // 售價DataGridViewTextBoxColumn
            // 
            this.售價DataGridViewTextBoxColumn.DataPropertyName = "售價";
            this.售價DataGridViewTextBoxColumn.HeaderText = "售價";
            this.售價DataGridViewTextBoxColumn.Name = "售價DataGridViewTextBoxColumn";
            // 
            // 寄庫數量DataGridViewTextBoxColumn
            // 
            this.寄庫數量DataGridViewTextBoxColumn.DataPropertyName = "寄庫數量";
            this.寄庫數量DataGridViewTextBoxColumn.HeaderText = "寄庫數量";
            this.寄庫數量DataGridViewTextBoxColumn.Name = "寄庫數量DataGridViewTextBoxColumn";
            // 
            // 成本DataGridViewTextBoxColumn
            // 
            this.成本DataGridViewTextBoxColumn.DataPropertyName = "成本";
            this.成本DataGridViewTextBoxColumn.HeaderText = "成本";
            this.成本DataGridViewTextBoxColumn.Name = "成本DataGridViewTextBoxColumn";
            this.成本DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 利潤DataGridViewTextBoxColumn
            // 
            this.利潤DataGridViewTextBoxColumn.DataPropertyName = "利潤";
            this.利潤DataGridViewTextBoxColumn.HeaderText = "利潤";
            this.利潤DataGridViewTextBoxColumn.Name = "利潤DataGridViewTextBoxColumn";
            this.利潤DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 體積DataGridViewTextBoxColumn
            // 
            this.體積DataGridViewTextBoxColumn.DataPropertyName = "體積";
            this.體積DataGridViewTextBoxColumn.HeaderText = "體積";
            this.體積DataGridViewTextBoxColumn.Name = "體積DataGridViewTextBoxColumn";
            this.體積DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 組成字串識別DataGridViewTextBoxColumn
            // 
            this.組成字串識別DataGridViewTextBoxColumn.DataPropertyName = "組成字串識別";
            this.組成字串識別DataGridViewTextBoxColumn.HeaderText = "組成";
            this.組成字串識別DataGridViewTextBoxColumn.Name = "組成字串識別DataGridViewTextBoxColumn";
            this.組成字串識別DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 錯誤訊息DataGridViewTextBoxColumn
            // 
            this.錯誤訊息DataGridViewTextBoxColumn.DataPropertyName = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.HeaderText = "錯誤訊息";
            this.錯誤訊息DataGridViewTextBoxColumn.Name = "錯誤訊息DataGridViewTextBoxColumn";
            this.錯誤訊息DataGridViewTextBoxColumn.Width = 200;
            // 
            // 商品更新視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1818, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "商品更新視窗";
            this.Text = "商品更新視窗";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品更新資料BindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource 商品更新資料BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 更新狀態DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客戶識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品類識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 供應商識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 進價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 售價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 寄庫數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 利潤DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 體積DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 組成字串識別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 錯誤訊息DataGridViewTextBoxColumn;
    }
}