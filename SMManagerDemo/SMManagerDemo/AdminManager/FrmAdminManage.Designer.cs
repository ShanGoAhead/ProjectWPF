namespace SMManagerDemo.AdminManager
{
    partial class FrmAdminManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminManage));
            this.dgvAdminList = new System.Windows.Forms.DataGridView();
            this.LoginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminList
            // 
            this.dgvAdminList.AllowUserToAddRows = false;
            this.dgvAdminList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAdminList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdminList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdminList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdminList.ColumnHeadersHeight = 28;
            this.dgvAdminList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginId,
            this.AdminName,
            this.RoleName,
            this.StatusName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdminList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdminList.EnableHeadersVisualStyles = false;
            this.dgvAdminList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvAdminList.Location = new System.Drawing.Point(12, 12);
            this.dgvAdminList.Name = "dgvAdminList";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            this.dgvAdminList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdminList.RowTemplate.Height = 23;
            this.dgvAdminList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminList.Size = new System.Drawing.Size(496, 235);
            this.dgvAdminList.TabIndex = 0;
            // 
            // LoginId
            // 
            this.LoginId.DataPropertyName = "LoginId";
            this.LoginId.HeaderText = "登录账号";
            this.LoginId.Name = "LoginId";
            // 
            // AdminName
            // 
            this.AdminName.DataPropertyName = "AdminName";
            this.AdminName.HeaderText = "用户名称";
            this.AdminName.Name = "AdminName";
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "用户类型";
            this.RoleName.Name = "RoleName";
            this.RoleName.Width = 121;
            // 
            // StatusName
            // 
            this.StatusName.DataPropertyName = "StatusName";
            this.StatusName.HeaderText = "当前状态";
            this.StatusName.Name = "StatusName";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(32, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添  加";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(127, 295);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 30);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修  改";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.ForeColor = System.Drawing.Color.Red;
            this.btnDisable.Image = ((System.Drawing.Image)(resources.GetObject("btnDisable.Image")));
            this.btnDisable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisable.Location = new System.Drawing.Point(221, 295);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(75, 30);
            this.btnDisable.TabIndex = 3;
            this.btnDisable.Text = "禁  用";
            this.btnDisable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Image = ((System.Drawing.Image)(resources.GetObject("btnEnable.Image")));
            this.btnEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnable.Location = new System.Drawing.Point(319, 295);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(75, 30);
            this.btnEnable.TabIndex = 4;
            this.btnEnable.Text = "启  用";
            this.btnEnable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(420, 295);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAdminManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 351);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAdminList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminManage";
            this.Text = "[用户管理]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminManage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminList;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnClose;
    }
}