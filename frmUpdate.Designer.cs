namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    partial class frmUpdate
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
            this.UpdateUserPanel = new System.Windows.Forms.Panel();
            this.updateStatus = new System.Windows.Forms.Label();
            this.UpdateUserStatus = new System.Windows.Forms.ComboBox();
            this.updateusercheckbox = new System.Windows.Forms.CheckBox();
            this.updateuserdropdown = new System.Windows.Forms.Label();
            this.cmbupdateusertype = new System.Windows.Forms.ComboBox();
            this.updateusercancelbtn = new FontAwesome.Sharp.IconButton();
            this.updateuseraddbtn = new FontAwesome.Sharp.IconButton();
            this.updateuserpassword = new System.Windows.Forms.Label();
            this.updateuserusername = new System.Windows.Forms.Label();
            this.txtpasswordupdateuser = new System.Windows.Forms.TextBox();
            this.textboxupdateuser = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpdateUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateUserPanel
            // 
            this.UpdateUserPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.UpdateUserPanel.Controls.Add(this.updateStatus);
            this.UpdateUserPanel.Controls.Add(this.UpdateUserStatus);
            this.UpdateUserPanel.Controls.Add(this.updateusercheckbox);
            this.UpdateUserPanel.Controls.Add(this.updateuserdropdown);
            this.UpdateUserPanel.Controls.Add(this.cmbupdateusertype);
            this.UpdateUserPanel.Controls.Add(this.updateusercancelbtn);
            this.UpdateUserPanel.Controls.Add(this.updateuseraddbtn);
            this.UpdateUserPanel.Controls.Add(this.updateuserpassword);
            this.UpdateUserPanel.Controls.Add(this.updateuserusername);
            this.UpdateUserPanel.Controls.Add(this.txtpasswordupdateuser);
            this.UpdateUserPanel.Controls.Add(this.textboxupdateuser);
            this.UpdateUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateUserPanel.Location = new System.Drawing.Point(0, 0);
            this.UpdateUserPanel.Name = "UpdateUserPanel";
            this.UpdateUserPanel.Size = new System.Drawing.Size(503, 360);
            this.UpdateUserPanel.TabIndex = 1;
            this.UpdateUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateUserPanel_Paint);
            this.UpdateUserPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateUserPanel_MouseDown);
            // 
            // updateStatus
            // 
            this.updateStatus.AutoSize = true;
            this.updateStatus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStatus.ForeColor = System.Drawing.Color.Black;
            this.updateStatus.Location = new System.Drawing.Point(105, 226);
            this.updateStatus.Name = "updateStatus";
            this.updateStatus.Size = new System.Drawing.Size(63, 23);
            this.updateStatus.TabIndex = 10;
            this.updateStatus.Text = "Status:";
            // 
            // UpdateUserStatus
            // 
            this.UpdateUserStatus.FormattingEnabled = true;
            this.UpdateUserStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.UpdateUserStatus.Location = new System.Drawing.Point(202, 226);
            this.UpdateUserStatus.Name = "UpdateUserStatus";
            this.UpdateUserStatus.Size = new System.Drawing.Size(155, 21);
            this.UpdateUserStatus.TabIndex = 9;
            // 
            // updateusercheckbox
            // 
            this.updateusercheckbox.AutoSize = true;
            this.updateusercheckbox.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateusercheckbox.ForeColor = System.Drawing.Color.Black;
            this.updateusercheckbox.Location = new System.Drawing.Point(299, 146);
            this.updateusercheckbox.Name = "updateusercheckbox";
            this.updateusercheckbox.Size = new System.Drawing.Size(95, 19);
            this.updateusercheckbox.TabIndex = 8;
            this.updateusercheckbox.Text = "Show Password";
            this.updateusercheckbox.UseVisualStyleBackColor = true;
            this.updateusercheckbox.CheckedChanged += new System.EventHandler(this.updateusercheckbox_CheckedChanged);
            // 
            // updateuserdropdown
            // 
            this.updateuserdropdown.AutoSize = true;
            this.updateuserdropdown.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateuserdropdown.ForeColor = System.Drawing.Color.Black;
            this.updateuserdropdown.Location = new System.Drawing.Point(88, 187);
            this.updateuserdropdown.Name = "updateuserdropdown";
            this.updateuserdropdown.Size = new System.Drawing.Size(83, 23);
            this.updateuserdropdown.TabIndex = 7;
            this.updateuserdropdown.Text = "Usertype:";
            // 
            // cmbupdateusertype
            // 
            this.cmbupdateusertype.FormattingEnabled = true;
            this.cmbupdateusertype.Items.AddRange(new object[] {
            "Administrator",
            "Technical",
            "User"});
            this.cmbupdateusertype.Location = new System.Drawing.Point(202, 187);
            this.cmbupdateusertype.Name = "cmbupdateusertype";
            this.cmbupdateusertype.Size = new System.Drawing.Size(155, 21);
            this.cmbupdateusertype.TabIndex = 6;
            // 
            // updateusercancelbtn
            // 
            this.updateusercancelbtn.BackColor = System.Drawing.Color.Red;
            this.updateusercancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateusercancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateusercancelbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateusercancelbtn.ForeColor = System.Drawing.Color.Black;
            this.updateusercancelbtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.updateusercancelbtn.IconColor = System.Drawing.Color.Black;
            this.updateusercancelbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateusercancelbtn.IconSize = 26;
            this.updateusercancelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateusercancelbtn.Location = new System.Drawing.Point(306, 276);
            this.updateusercancelbtn.Name = "updateusercancelbtn";
            this.updateusercancelbtn.Size = new System.Drawing.Size(88, 51);
            this.updateusercancelbtn.TabIndex = 5;
            this.updateusercancelbtn.Text = "Cancel";
            this.updateusercancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateusercancelbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateusercancelbtn.UseVisualStyleBackColor = false;
            this.updateusercancelbtn.Click += new System.EventHandler(this.updateusercancelbtn_Click);
            // 
            // updateuseraddbtn
            // 
            this.updateuseraddbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateuseraddbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateuseraddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateuseraddbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateuseraddbtn.ForeColor = System.Drawing.Color.Black;
            this.updateuseraddbtn.IconChar = FontAwesome.Sharp.IconChar.PlugCircleCheck;
            this.updateuseraddbtn.IconColor = System.Drawing.Color.Black;
            this.updateuseraddbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateuseraddbtn.IconSize = 26;
            this.updateuseraddbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateuseraddbtn.Location = new System.Drawing.Point(202, 276);
            this.updateuseraddbtn.Name = "updateuseraddbtn";
            this.updateuseraddbtn.Size = new System.Drawing.Size(88, 51);
            this.updateuseraddbtn.TabIndex = 4;
            this.updateuseraddbtn.Text = "Saved";
            this.updateuseraddbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateuseraddbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateuseraddbtn.UseVisualStyleBackColor = false;
            this.updateuseraddbtn.Click += new System.EventHandler(this.updateuseraddbtn_Click);
            // 
            // updateuserpassword
            // 
            this.updateuserpassword.AutoSize = true;
            this.updateuserpassword.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateuserpassword.ForeColor = System.Drawing.Color.Black;
            this.updateuserpassword.Location = new System.Drawing.Point(88, 104);
            this.updateuserpassword.Name = "updateuserpassword";
            this.updateuserpassword.Size = new System.Drawing.Size(90, 23);
            this.updateuserpassword.TabIndex = 3;
            this.updateuserpassword.Text = "Password:";
            // 
            // updateuserusername
            // 
            this.updateuserusername.AutoSize = true;
            this.updateuserusername.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateuserusername.ForeColor = System.Drawing.Color.Black;
            this.updateuserusername.Location = new System.Drawing.Point(88, 67);
            this.updateuserusername.Name = "updateuserusername";
            this.updateuserusername.Size = new System.Drawing.Size(92, 23);
            this.updateuserusername.TabIndex = 2;
            this.updateuserusername.Text = "Username:";
            // 
            // txtpasswordupdateuser
            // 
            this.txtpasswordupdateuser.Location = new System.Drawing.Point(203, 109);
            this.txtpasswordupdateuser.Name = "txtpasswordupdateuser";
            this.txtpasswordupdateuser.Size = new System.Drawing.Size(191, 20);
            this.txtpasswordupdateuser.TabIndex = 1;
            this.txtpasswordupdateuser.UseSystemPasswordChar = true;
            // 
            // textboxupdateuser
            // 
            this.textboxupdateuser.Location = new System.Drawing.Point(202, 67);
            this.textboxupdateuser.Name = "textboxupdateuser";
            this.textboxupdateuser.Size = new System.Drawing.Size(192, 20);
            this.textboxupdateuser.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 360);
            this.Controls.Add(this.UpdateUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdate";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            this.UpdateUserPanel.ResumeLayout(false);
            this.UpdateUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpdateUserPanel;
        private System.Windows.Forms.CheckBox updateusercheckbox;
        private System.Windows.Forms.Label updateuserdropdown;
        private System.Windows.Forms.ComboBox cmbupdateusertype;
        private FontAwesome.Sharp.IconButton updateusercancelbtn;
        private FontAwesome.Sharp.IconButton updateuseraddbtn;
        private System.Windows.Forms.Label updateuserpassword;
        private System.Windows.Forms.Label updateuserusername;
        private System.Windows.Forms.TextBox txtpasswordupdateuser;
        private System.Windows.Forms.TextBox textboxupdateuser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label updateStatus;
        private System.Windows.Forms.ComboBox UpdateUserStatus;
    }
}