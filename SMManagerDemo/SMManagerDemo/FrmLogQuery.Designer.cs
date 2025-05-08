namespace SMManagerDemo
{
    partial class FrmLogQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogQuery));
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.LoginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGoTo = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbPageSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogs
            // 
            this.dgvLogs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginId,
            this.SPName,
            this.ServerName,
            this.LoginTime,
            this.ExitTime});
            this.dgvLogs.Location = new System.Drawing.Point(26, 13);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowTemplate.Height = 23;
            this.dgvLogs.Size = new System.Drawing.Size(804, 309);
            this.dgvLogs.TabIndex = 0;
            this.dgvLogs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvLogs_RowPostPaint);
            // 
            // LoginId
            // 
            this.LoginId.DataPropertyName = "LoginId";
            this.LoginId.HeaderText = "登录账号";
            this.LoginId.Name = "LoginId";
            // 
            // SPName
            // 
            this.SPName.DataPropertyName = "SPName";
            this.SPName.HeaderText = "用户名称";
            this.SPName.Name = "SPName";
            this.SPName.Width = 174;
            // 
            // ServerName
            // 
            this.ServerName.DataPropertyName = "ServerName";
            this.ServerName.HeaderText = "登录服务器";
            this.ServerName.Name = "ServerName";
            this.ServerName.Width = 180;
            // 
            // LoginTime
            // 
            this.LoginTime.DataPropertyName = "LoginTime";
            this.LoginTime.HeaderText = "登录时间";
            this.LoginTime.Name = "LoginTime";
            this.LoginTime.Width = 150;
            // 
            // ExitTime
            // 
            this.ExitTime.DataPropertyName = "ExitTime";
            this.ExitTime.HeaderText = "退出时间";
            this.ExitTime.Name = "ExitTime";
            this.ExitTime.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查询时间：";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(84, 343);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(93, 21);
            this.dtpStart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "至";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(206, 343);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(93, 21);
            this.dtpEnd.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(322, 342);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(84, 33);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "开始查询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(732, 342);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 33);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGoTo);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblPageCount);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnGoTo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblCurrentPage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbPageSize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblRecordCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(26, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[数据分页展示]";
            // 
            // txtGoTo
            // 
            this.txtGoTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoTo.Location = new System.Drawing.Point(681, 19);
            this.txtGoTo.Name = "txtGoTo";
            this.txtGoTo.Size = new System.Drawing.Size(35, 21);
            this.txtGoTo.TabIndex = 20;
            this.txtGoTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGoTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoTo_KeyDown);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.Maroon;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(110, 54);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(74, 31);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.Text = "上一页";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Maroon;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(199, 54);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 31);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "下一页";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.Maroon;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLast.Location = new System.Drawing.Point(296, 54);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(74, 31);
            this.btnLast.TabIndex = 17;
            this.btnLast.Text = "最后页";
            this.btnLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.Maroon;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirst.Location = new System.Drawing.Point(9, 54);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(74, 31);
            this.btnFirst.TabIndex = 16;
            this.btnFirst.Text = "第一页";
            this.btnFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(427, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "页";
            // 
            // lblPageCount
            // 
            this.lblPageCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPageCount.Location = new System.Drawing.Point(369, 18);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(51, 18);
            this.lblPageCount.TabIndex = 14;
            this.lblPageCount.Text = "0";
            this.lblPageCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "共";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(722, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "页";
            // 
            // btnGoTo
            // 
            this.btnGoTo.BackColor = System.Drawing.Color.White;
            this.btnGoTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTo.Image = ((System.Drawing.Image)(resources.GetObject("btnGoTo.Image")));
            this.btnGoTo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoTo.Location = new System.Drawing.Point(593, 16);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(75, 23);
            this.btnGoTo.TabIndex = 10;
            this.btnGoTo.Text = "跳转到";
            this.btnGoTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoTo.UseVisualStyleBackColor = false;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "页";
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurrentPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentPage.Location = new System.Drawing.Point(512, 16);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(50, 23);
            this.lblCurrentPage.TabIndex = 8;
            this.lblCurrentPage.Text = "0";
            this.lblCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "当前第";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "条";
            // 
            // cbbPageSize
            // 
            this.cbbPageSize.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPageSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPageSize.FormattingEnabled = true;
            this.cbbPageSize.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "50",
            "100"});
            this.cbbPageSize.Location = new System.Drawing.Point(239, 17);
            this.cbbPageSize.Name = "cbbPageSize";
            this.cbbPageSize.Size = new System.Drawing.Size(70, 20);
            this.cbbPageSize.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "每页显示";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "条";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.BackColor = System.Drawing.SystemColors.Control;
            this.lblRecordCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecordCount.Location = new System.Drawing.Point(77, 16);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(50, 23);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "0";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "记录总条数";
            // 
            // FrmLogQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogQuery";
            this.Text = "[登录日志查询]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogQuery_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbPageSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtGoTo;
    }
}