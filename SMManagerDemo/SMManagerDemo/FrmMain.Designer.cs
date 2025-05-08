namespace SMManagerDemo
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.商品管理PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInventoryManage = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaleStat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogQuery = new System.Windows.Forms.Button();
            this.btnSalAnalasys = new System.Windows.Forms.Button();
            this.btnProductManage = new System.Windows.Forms.Button();
            this.btnInventoryManage = new System.Windows.Forms.Button();
            this.btnProductInventor = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.商品管理PToolStripMenuItem,
            this.销售管理XToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1218, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserManage,
            this.tsmiModifyPwd,
            this.tsmiLogs,
            this.tsmiExit});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.系统SToolStripMenuItem.Text = "系统（S）";
            // 
            // tsmiUserManage
            // 
            this.tsmiUserManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUserManage.Image")));
            this.tsmiUserManage.Name = "tsmiUserManage";
            this.tsmiUserManage.Size = new System.Drawing.Size(157, 22);
            this.tsmiUserManage.Text = "用户管理（U）";
            this.tsmiUserManage.Click += new System.EventHandler(this.tsmiUserManage_Click);
            // 
            // tsmiModifyPwd
            // 
            this.tsmiModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiModifyPwd.Image")));
            this.tsmiModifyPwd.Name = "tsmiModifyPwd";
            this.tsmiModifyPwd.Size = new System.Drawing.Size(157, 22);
            this.tsmiModifyPwd.Text = "修改密码（P）";
            this.tsmiModifyPwd.Click += new System.EventHandler(this.tsmiModifyPwd_Click);
            // 
            // tsmiLogs
            // 
            this.tsmiLogs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLogs.Image")));
            this.tsmiLogs.Name = "tsmiLogs";
            this.tsmiLogs.Size = new System.Drawing.Size(157, 22);
            this.tsmiLogs.Text = "日志查询（L）";
            this.tsmiLogs.Click += new System.EventHandler(this.btnLogQuery_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExit.Image")));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(157, 22);
            this.tsmiExit.Text = "退出系统（E）";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // 商品管理PToolStripMenuItem
            // 
            this.商品管理PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddProduct,
            this.tsmiProductStorage,
            this.tsmiProductManage,
            this.tsmiInventoryManage});
            this.商品管理PToolStripMenuItem.Name = "商品管理PToolStripMenuItem";
            this.商品管理PToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.商品管理PToolStripMenuItem.Text = "商品管理（P）";
            // 
            // tsmiAddProduct
            // 
            this.tsmiAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddProduct.Image")));
            this.tsmiAddProduct.Name = "tsmiAddProduct";
            this.tsmiAddProduct.Size = new System.Drawing.Size(160, 22);
            this.tsmiAddProduct.Text = "添加商品（A）";
            this.tsmiAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tsmiProductStorage
            // 
            this.tsmiProductStorage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiProductStorage.Image")));
            this.tsmiProductStorage.Name = "tsmiProductStorage";
            this.tsmiProductStorage.Size = new System.Drawing.Size(160, 22);
            this.tsmiProductStorage.Text = "商品入库（I）";
            this.tsmiProductStorage.Click += new System.EventHandler(this.btnProductInventor_Click);
            // 
            // tsmiProductManage
            // 
            this.tsmiProductManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiProductManage.Image")));
            this.tsmiProductManage.Name = "tsmiProductManage";
            this.tsmiProductManage.Size = new System.Drawing.Size(160, 22);
            this.tsmiProductManage.Text = "商品维护（M）";
            this.tsmiProductManage.Click += new System.EventHandler(this.btnProductManage_Click);
            // 
            // tsmiInventoryManage
            // 
            this.tsmiInventoryManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInventoryManage.Image")));
            this.tsmiInventoryManage.Name = "tsmiInventoryManage";
            this.tsmiInventoryManage.Size = new System.Drawing.Size(160, 22);
            this.tsmiInventoryManage.Text = "库存管理（K）";
            this.tsmiInventoryManage.Click += new System.EventHandler(this.btnInventoryManage_Click);
            // 
            // 销售管理XToolStripMenuItem
            // 
            this.销售管理XToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaleStat});
            this.销售管理XToolStripMenuItem.Name = "销售管理XToolStripMenuItem";
            this.销售管理XToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.销售管理XToolStripMenuItem.Text = "销售管理（X）";
            // 
            // tsmiSaleStat
            // 
            this.tsmiSaleStat.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaleStat.Image")));
            this.tsmiSaleStat.Name = "tsmiSaleStat";
            this.tsmiSaleStat.Size = new System.Drawing.Size(155, 22);
            this.tsmiSaleStat.Text = "销售统计（S）";
            this.tsmiSaleStat.Click += new System.EventHandler(this.btnSalAnalasys_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnModifyPwd);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogQuery);
            this.panel1.Controls.Add(this.btnSalAnalasys);
            this.panel1.Controls.Add(this.btnProductManage);
            this.panel1.Controls.Add(this.btnInventoryManage);
            this.panel1.Controls.Add(this.btnProductInventor);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(8, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 563);
            this.panel1.TabIndex = 2;
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyPwd.Image")));
            this.btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPwd.Location = new System.Drawing.Point(24, 480);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(84, 38);
            this.btnModifyPwd.TabIndex = 8;
            this.btnModifyPwd.Text = "修改密码";
            this.btnModifyPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyPwd.UseVisualStyleBackColor = true;
            this.btnModifyPwd.Click += new System.EventHandler(this.btnModifyPwd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(132, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "退出系统";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogQuery
            // 
            this.btnLogQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnLogQuery.Image")));
            this.btnLogQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogQuery.Location = new System.Drawing.Point(144, 366);
            this.btnLogQuery.Name = "btnLogQuery";
            this.btnLogQuery.Size = new System.Drawing.Size(84, 38);
            this.btnLogQuery.TabIndex = 6;
            this.btnLogQuery.Text = "日志查询";
            this.btnLogQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogQuery.UseVisualStyleBackColor = true;
            this.btnLogQuery.Click += new System.EventHandler(this.btnLogQuery_Click);
            // 
            // btnSalAnalasys
            // 
            this.btnSalAnalasys.Image = ((System.Drawing.Image)(resources.GetObject("btnSalAnalasys.Image")));
            this.btnSalAnalasys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalAnalasys.Location = new System.Drawing.Point(24, 366);
            this.btnSalAnalasys.Name = "btnSalAnalasys";
            this.btnSalAnalasys.Size = new System.Drawing.Size(84, 38);
            this.btnSalAnalasys.TabIndex = 5;
            this.btnSalAnalasys.Text = "销售统计";
            this.btnSalAnalasys.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalAnalasys.UseVisualStyleBackColor = true;
            this.btnSalAnalasys.Click += new System.EventHandler(this.btnSalAnalasys_Click);
            // 
            // btnProductManage
            // 
            this.btnProductManage.Image = ((System.Drawing.Image)(resources.GetObject("btnProductManage.Image")));
            this.btnProductManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductManage.Location = new System.Drawing.Point(144, 301);
            this.btnProductManage.Name = "btnProductManage";
            this.btnProductManage.Size = new System.Drawing.Size(84, 38);
            this.btnProductManage.TabIndex = 4;
            this.btnProductManage.Text = "商品维护";
            this.btnProductManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductManage.UseVisualStyleBackColor = true;
            this.btnProductManage.Click += new System.EventHandler(this.btnProductManage_Click);
            // 
            // btnInventoryManage
            // 
            this.btnInventoryManage.Image = ((System.Drawing.Image)(resources.GetObject("btnInventoryManage.Image")));
            this.btnInventoryManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryManage.Location = new System.Drawing.Point(24, 301);
            this.btnInventoryManage.Name = "btnInventoryManage";
            this.btnInventoryManage.Size = new System.Drawing.Size(84, 38);
            this.btnInventoryManage.TabIndex = 3;
            this.btnInventoryManage.Text = "库存管理";
            this.btnInventoryManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventoryManage.UseVisualStyleBackColor = true;
            this.btnInventoryManage.Click += new System.EventHandler(this.btnInventoryManage_Click);
            // 
            // btnProductInventor
            // 
            this.btnProductInventor.Image = ((System.Drawing.Image)(resources.GetObject("btnProductInventor.Image")));
            this.btnProductInventor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductInventor.Location = new System.Drawing.Point(144, 237);
            this.btnProductInventor.Name = "btnProductInventor";
            this.btnProductInventor.Size = new System.Drawing.Size(84, 38);
            this.btnProductInventor.TabIndex = 2;
            this.btnProductInventor.Text = "商品入库";
            this.btnProductInventor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductInventor.UseVisualStyleBackColor = true;
            this.btnProductInventor.Click += new System.EventHandler(this.btnProductInventor_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(24, 237);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(84, 38);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "新增产品";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(10, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(275, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 563);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(12, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "[超市管理系统]  V2.0 ";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.lblAdminName.Location = new System.Drawing.Point(144, 612);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(80, 17);
            this.lblAdminName.TabIndex = 5;
            this.lblAdminName.Text = "【管理员】：";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 638);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品管理PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyPwd;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogs;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductStorage;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiInventoryManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaleStat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogQuery;
        private System.Windows.Forms.Button btnSalAnalasys;
        private System.Windows.Forms.Button btnProductManage;
        private System.Windows.Forms.Button btnInventoryManage;
        private System.Windows.Forms.Button btnProductInventor;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminName;
    }
}