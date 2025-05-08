namespace SMManagerDemo.Product
{
    partial class FrmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProduct));
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinCount = new System.Windows.Forms.TextBox();
            this.txtMaxCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtUnitPrice);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.txtProductName);
            this.gbInfo.Controls.Add(this.txtProductId);
            this.gbInfo.Controls.Add(this.cboUnit);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.btnLock);
            this.gbInfo.Controls.Add(this.cboCategory);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Location = new System.Drawing.Point(21, 27);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(547, 155);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "[商品信息]";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(350, 111);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 21);
            this.txtUnitPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "销售单价：";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(87, 114);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(168, 21);
            this.txtProductName.TabIndex = 8;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(87, 71);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(168, 21);
            this.txtProductId.TabIndex = 7;
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(350, 29);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(100, 20);
            this.cboUnit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "计量单位：";
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(214, 27);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(41, 23);
            this.btnLock.TabIndex = 4;
            this.btnLock.Text = "锁定";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(87, 29);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 20);
            this.cboCategory.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品编码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品分类：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMinCount);
            this.groupBox2.Controls.Add(this.txtMaxCount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(21, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[库存预设]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "最小库存：";
            // 
            // txtMinCount
            // 
            this.txtMinCount.Location = new System.Drawing.Point(350, 41);
            this.txtMinCount.Name = "txtMinCount";
            this.txtMinCount.Size = new System.Drawing.Size(174, 21);
            this.txtMinCount.TabIndex = 2;
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.Location = new System.Drawing.Point(87, 41);
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.Size = new System.Drawing.Size(168, 21);
            this.txtMaxCount.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "最大库存：";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(359, 308);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 35);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "添加商品";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(486, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 355);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddProduct";
            this.Text = "[添加新商品]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddProduct_FormClosing);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinCount;
        private System.Windows.Forms.TextBox txtMaxCount;
        private System.Windows.Forms.Label label6;
    }
}