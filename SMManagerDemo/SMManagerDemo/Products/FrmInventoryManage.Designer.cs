namespace SMManagerDemo.Product
{
    partial class FrmInventoryManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventoryManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnShowMin = new System.Windows.Forms.Button();
            this.lblMinCount = new System.Windows.Forms.Label();
            this.lblMaxCount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowMax = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinCount = new System.Windows.Forms.TextBox();
            this.txtMaxCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTotalCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProductId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[商品库存查询]";
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(691, 23);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(90, 33);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "提交查询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(453, 29);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 20);
            this.cboCategory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "商品分类：";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(286, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 21);
            this.txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品名称：";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(78, 29);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(144, 21);
            this.txtProductId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品编码：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.btnShowMin);
            this.groupBox2.Controls.Add(this.lblMinCount);
            this.groupBox2.Controls.Add(this.lblMaxCount);
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnShowMax);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(26, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[库存预警信息]";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(109, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 12);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[刷新库存预警信息]";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnShowMin
            // 
            this.btnShowMin.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMin.Image")));
            this.btnShowMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowMin.Location = new System.Drawing.Point(691, 20);
            this.btnShowMin.Name = "btnShowMin";
            this.btnShowMin.Size = new System.Drawing.Size(90, 33);
            this.btnShowMin.TabIndex = 19;
            this.btnShowMin.Text = "显示低库存";
            this.btnShowMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowMin.UseVisualStyleBackColor = true;
            this.btnShowMin.Click += new System.EventHandler(this.btnShowMin_Click);
            // 
            // lblMinCount
            // 
            this.lblMinCount.BackColor = System.Drawing.Color.White;
            this.lblMinCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinCount.ForeColor = System.Drawing.Color.Red;
            this.lblMinCount.Location = new System.Drawing.Point(569, 25);
            this.lblMinCount.Name = "lblMinCount";
            this.lblMinCount.Size = new System.Drawing.Size(82, 23);
            this.lblMinCount.TabIndex = 18;
            this.lblMinCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxCount
            // 
            this.lblMaxCount.BackColor = System.Drawing.Color.White;
            this.lblMaxCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaxCount.Location = new System.Drawing.Point(261, 25);
            this.lblMaxCount.Name = "lblMaxCount";
            this.lblMaxCount.Size = new System.Drawing.Size(82, 23);
            this.lblMaxCount.TabIndex = 17;
            this.lblMaxCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.White;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(78, 25);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(82, 23);
            this.lblCount.TabIndex = 16;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "低于库存下限：";
            // 
            // btnShowMax
            // 
            this.btnShowMax.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMax.Image")));
            this.btnShowMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowMax.Location = new System.Drawing.Point(367, 20);
            this.btnShowMax.Name = "btnShowMax";
            this.btnShowMax.Size = new System.Drawing.Size(90, 33);
            this.btnShowMax.TabIndex = 14;
            this.btnShowMax.Text = "显示超库存";
            this.btnShowMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowMax.UseVisualStyleBackColor = true;
            this.btnShowMax.Click += new System.EventHandler(this.btnShowMax_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "超出库存上限：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "预警总数：";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProduct.ColumnHeadersHeight = 25;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Uint,
            this.MaxCount,
            this.TotalCount,
            this.MinCount,
            this.InventoryStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvProduct.Location = new System.Drawing.Point(26, 195);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.RowTemplate.Height = 23;
            this.dgvProduct.Size = new System.Drawing.Size(801, 291);
            this.dgvProduct.TabIndex = 2;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProduct_RowPostPaint);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "商品编号";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 120;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "商品名称";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 180;
            // 
            // Uint
            // 
            this.Uint.DataPropertyName = "Unit";
            this.Uint.HeaderText = "计量单位";
            this.Uint.Name = "Uint";
            this.Uint.ReadOnly = true;
            this.Uint.Width = 81;
            // 
            // MaxCount
            // 
            this.MaxCount.DataPropertyName = "MaxCount";
            this.MaxCount.HeaderText = "最大库存";
            this.MaxCount.Name = "MaxCount";
            this.MaxCount.ReadOnly = true;
            this.MaxCount.Width = 81;
            // 
            // TotalCount
            // 
            this.TotalCount.DataPropertyName = "TotalCount";
            this.TotalCount.HeaderText = "当前库存";
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.ReadOnly = true;
            this.TotalCount.Width = 81;
            // 
            // MinCount
            // 
            this.MinCount.DataPropertyName = "MinCount";
            this.MinCount.HeaderText = "最小库存";
            this.MinCount.Name = "MinCount";
            this.MinCount.ReadOnly = true;
            // 
            // InventoryStatus
            // 
            this.InventoryStatus.DataPropertyName = "InventoryStatus";
            this.InventoryStatus.HeaderText = "库存状态";
            this.InventoryStatus.Name = "InventoryStatus";
            this.InventoryStatus.ReadOnly = true;
            this.InventoryStatus.Width = 106;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateSet);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtMinCount);
            this.groupBox3.Controls.Add(this.txtMaxCount);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(26, 513);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 83);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[库存预警设置]";
            // 
            // btnUpdateSet
            // 
            this.btnUpdateSet.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSet.Image")));
            this.btnUpdateSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSet.Location = new System.Drawing.Point(328, 25);
            this.btnUpdateSet.Name = "btnUpdateSet";
            this.btnUpdateSet.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateSet.TabIndex = 4;
            this.btnUpdateSet.Text = "更新设置";
            this.btnUpdateSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSet.UseVisualStyleBackColor = true;
            this.btnUpdateSet.Click += new System.EventHandler(this.btnUpdateSet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "最小库存：";
            // 
            // txtMinCount
            // 
            this.txtMinCount.Location = new System.Drawing.Point(240, 34);
            this.txtMinCount.Name = "txtMinCount";
            this.txtMinCount.Size = new System.Drawing.Size(71, 21);
            this.txtMinCount.TabIndex = 2;
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.Location = new System.Drawing.Point(78, 35);
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.Size = new System.Drawing.Size(77, 21);
            this.txtMaxCount.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "最大库存：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotalCount);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnUpdateInventory);
            this.groupBox4.Location = new System.Drawing.Point(459, 513);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 83);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "[调整商品库存]";
            // 
            // txtTotalCount
            // 
            this.txtTotalCount.Location = new System.Drawing.Point(69, 35);
            this.txtTotalCount.Name = "txtTotalCount";
            this.txtTotalCount.Size = new System.Drawing.Size(62, 21);
            this.txtTotalCount.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "当前库存：";
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateInventory.Image")));
            this.btnUpdateInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateInventory.Location = new System.Drawing.Point(163, 27);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(75, 37);
            this.btnUpdateInventory.TabIndex = 5;
            this.btnUpdateInventory.Text = "修改库存";
            this.btnUpdateInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateInventory.UseVisualStyleBackColor = true;
            this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(742, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmInventoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 625);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInventoryManage";
            this.Text = "商品库存管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInventoryManage_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnShowMin;
        private System.Windows.Forms.Label lblMinCount;
        private System.Windows.Forms.Label lblMaxCount;
        private System.Windows.Forms.Button btnUpdateSet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMinCount;
        private System.Windows.Forms.TextBox txtMaxCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uint;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryStatus;
    }
}