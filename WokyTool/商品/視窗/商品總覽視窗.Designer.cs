namespace WokyTool.商品
{
    partial class 商品總覽視窗
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
            this.myDataGridView1 = new WokyTool.通用.MyDataGridView();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品類名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.供應商名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品牌名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公司名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客戶名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.進價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.售價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.利潤DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.寄庫數量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.組成字串DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.篩選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myDataGridView1
            // 
            this.myDataGridView1.AutoGenerateColumns = false;
            this.myDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.品類名稱DataGridViewTextBoxColumn,
            this.供應商名稱DataGridViewTextBoxColumn,
            this.品牌名稱DataGridViewTextBoxColumn,
            this.公司名稱DataGridViewTextBoxColumn,
            this.客戶名稱DataGridViewTextBoxColumn,
            this.品號DataGridViewTextBoxColumn,
            this.名稱DataGridViewTextBoxColumn,
            this.進價DataGridViewTextBoxColumn,
            this.售價DataGridViewTextBoxColumn,
            this.成本DataGridViewTextBoxColumn,
            this.利潤DataGridViewTextBoxColumn,
            this.寄庫數量DataGridViewTextBoxColumn,
            this.組成字串DataGridViewTextBoxColumn});
            this.myDataGridView1.DataSource = this.商品資料BindingSource;
            this.myDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGridView1.Location = new System.Drawing.Point(0, 24);
            this.myDataGridView1.Name = "myDataGridView1";
            this.myDataGridView1.RowTemplate.Height = 24;
            this.myDataGridView1.Size = new System.Drawing.Size(1684, 432);
            this.myDataGridView1.TabIndex = 3;
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            this.編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 品類名稱DataGridViewTextBoxColumn
            // 
            this.品類名稱DataGridViewTextBoxColumn.DataPropertyName = "品類名稱";
            this.品類名稱DataGridViewTextBoxColumn.HeaderText = "品類";
            this.品類名稱DataGridViewTextBoxColumn.Name = "品類名稱DataGridViewTextBoxColumn";
            this.品類名稱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 供應商名稱DataGridViewTextBoxColumn
            // 
            this.供應商名稱DataGridViewTextBoxColumn.DataPropertyName = "供應商名稱";
            this.供應商名稱DataGridViewTextBoxColumn.HeaderText = "供應商";
            this.供應商名稱DataGridViewTextBoxColumn.Name = "供應商名稱DataGridViewTextBoxColumn";
            this.供應商名稱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 品牌名稱DataGridViewTextBoxColumn
            // 
            this.品牌名稱DataGridViewTextBoxColumn.DataPropertyName = "品牌名稱";
            this.品牌名稱DataGridViewTextBoxColumn.HeaderText = "品牌";
            this.品牌名稱DataGridViewTextBoxColumn.Name = "品牌名稱DataGridViewTextBoxColumn";
            this.品牌名稱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 公司名稱DataGridViewTextBoxColumn
            // 
            this.公司名稱DataGridViewTextBoxColumn.DataPropertyName = "公司名稱";
            this.公司名稱DataGridViewTextBoxColumn.HeaderText = "公司";
            this.公司名稱DataGridViewTextBoxColumn.Name = "公司名稱DataGridViewTextBoxColumn";
            this.公司名稱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 客戶名稱DataGridViewTextBoxColumn
            // 
            this.客戶名稱DataGridViewTextBoxColumn.DataPropertyName = "客戶名稱";
            this.客戶名稱DataGridViewTextBoxColumn.HeaderText = "客戶";
            this.客戶名稱DataGridViewTextBoxColumn.Name = "客戶名稱DataGridViewTextBoxColumn";
            this.客戶名稱DataGridViewTextBoxColumn.ReadOnly = true;
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
            // 寄庫數量DataGridViewTextBoxColumn
            // 
            this.寄庫數量DataGridViewTextBoxColumn.DataPropertyName = "寄庫數量";
            this.寄庫數量DataGridViewTextBoxColumn.HeaderText = "寄庫數量";
            this.寄庫數量DataGridViewTextBoxColumn.Name = "寄庫數量DataGridViewTextBoxColumn";
            // 
            // 組成字串DataGridViewTextBoxColumn
            // 
            this.組成字串DataGridViewTextBoxColumn.DataPropertyName = "組成字串";
            this.組成字串DataGridViewTextBoxColumn.HeaderText = "組成";
            this.組成字串DataGridViewTextBoxColumn.Name = "組成字串DataGridViewTextBoxColumn";
            this.組成字串DataGridViewTextBoxColumn.ReadOnly = true;
            this.組成字串DataGridViewTextBoxColumn.Width = 200;
            // 
            // 商品資料BindingSource
            // 
            this.商品資料BindingSource.DataSource = typeof(WokyTool.商品.商品資料);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.篩選ToolStripMenuItem,
            this.檢查ToolStripMenuItem,
            this.匯出ToolStripMenuItem,
            this.更新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1684, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
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
            // 匯出ToolStripMenuItem
            // 
            this.匯出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂ToolStripMenuItem});
            this.匯出ToolStripMenuItem.Name = "匯出ToolStripMenuItem";
            this.匯出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.匯出ToolStripMenuItem.Text = "匯出";
            // 
            // 自訂ToolStripMenuItem
            // 
            this.自訂ToolStripMenuItem.Name = "自訂ToolStripMenuItem";
            this.自訂ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.自訂ToolStripMenuItem.Text = "自訂";
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.通用ToolStripMenuItem});
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            // 
            // 通用ToolStripMenuItem
            // 
            this.通用ToolStripMenuItem.Name = "通用ToolStripMenuItem";
            this.通用ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.通用ToolStripMenuItem.Text = "通用";
            this.通用ToolStripMenuItem.Click += new System.EventHandler(this.通用ToolStripMenuItem_Click);
            // 
            // 商品總覽視窗
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 456);
            this.Controls.Add(this.myDataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "商品總覽視窗";
            this.Text = "商品總覽視窗";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品資料BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource 商品資料BindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 篩選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通用ToolStripMenuItem;
        private 通用.MyDataGridView myDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品類名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 供應商名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公司名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客戶名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 進價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 售價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成本DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 利潤DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 寄庫數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 組成字串DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
    }
}