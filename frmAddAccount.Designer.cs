namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    partial class frmAddAccount
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
            this.addUserPanel = new System.Windows.Forms.Panel();
            this.addusercheckbox = new System.Windows.Forms.CheckBox();
            this.userdropdown = new System.Windows.Forms.Label();
            this.cmbusertype = new System.Windows.Forms.ComboBox();
            this.addusercancelbtn = new FontAwesome.Sharp.IconButton();
            this.adduseraddbtn = new FontAwesome.Sharp.IconButton();
            this.adduserpassword = new System.Windows.Forms.Label();
            this.adduserusername = new System.Windows.Forms.Label();
            this.txtpasswordadduser = new System.Windows.Forms.TextBox();
            this.textboxadduser = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.addUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // addUserPanel
            // 
            this.addUserPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.addUserPanel.Controls.Add(this.addusercheckbox);
            this.addUserPanel.Controls.Add(this.userdropdown);
            this.addUserPanel.Controls.Add(this.cmbusertype);
            this.addUserPanel.Controls.Add(this.addusercancelbtn);
            this.addUserPanel.Controls.Add(this.adduseraddbtn);
            this.addUserPanel.Controls.Add(this.adduserpassword);
            this.addUserPanel.Controls.Add(this.adduserusername);
            this.addUserPanel.Controls.Add(this.txtpasswordadduser);
            this.addUserPanel.Controls.Add(this.textboxadduser);
            this.addUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserPanel.Location = new System.Drawing.Point(0, 0);
            this.addUserPanel.Name = "addUserPanel";
            this.addUserPanel.Size = new System.Drawing.Size(443, 327);
            this.addUserPanel.TabIndex = 0;
            this.addUserPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addUserPanel_MouseDown);
            // 
            // addusercheckbox
            // 
            this.addusercheckbox.AutoSize = true;
            this.addusercheckbox.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addusercheckbox.ForeColor = System.Drawing.Color.Black;
            this.addusercheckbox.Location = new System.Drawing.Point(257, 113);
            this.addusercheckbox.Name = "addusercheckbox";
            this.addusercheckbox.Size = new System.Drawing.Size(95, 19);
            this.addusercheckbox.TabIndex = 8;
            this.addusercheckbox.Text = "Show Password";
            this.addusercheckbox.UseVisualStyleBackColor = true;
            this.addusercheckbox.CheckedChanged += new System.EventHandler(this.addusercheckbox_CheckedChanged);
            // 
            // userdropdown
            // 
            this.userdropdown.AutoSize = true;
            this.userdropdown.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userdropdown.ForeColor = System.Drawing.Color.Black;
            this.userdropdown.Location = new System.Drawing.Point(84, 149);
            this.userdropdown.Name = "userdropdown";
            this.userdropdown.Size = new System.Drawing.Size(63, 20);
            this.userdropdown.TabIndex = 7;
            this.userdropdown.Text = "Usertype";
            // 
            // cmbusertype
            // 
            this.cmbusertype.FormattingEnabled = true;
            this.cmbusertype.Items.AddRange(new object[] {
            "Administrator",
            "Technical",
            "User"});
            this.cmbusertype.Location = new System.Drawing.Point(160, 148);
            this.cmbusertype.Name = "cmbusertype";
            this.cmbusertype.Size = new System.Drawing.Size(155, 21);
            this.cmbusertype.TabIndex = 6;
            // 
            // addusercancelbtn
            // 
            this.addusercancelbtn.BackColor = System.Drawing.Color.Red;
            this.addusercancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addusercancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addusercancelbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addusercancelbtn.ForeColor = System.Drawing.Color.Black;
            this.addusercancelbtn.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.addusercancelbtn.IconColor = System.Drawing.Color.Black;
            this.addusercancelbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addusercancelbtn.IconSize = 26;
            this.addusercancelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addusercancelbtn.Location = new System.Drawing.Point(264, 211);
            this.addusercancelbtn.Name = "addusercancelbtn";
            this.addusercancelbtn.Size = new System.Drawing.Size(88, 51);
            this.addusercancelbtn.TabIndex = 5;
            this.addusercancelbtn.Text = "Cancel";
            this.addusercancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addusercancelbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addusercancelbtn.UseVisualStyleBackColor = false;
            this.addusercancelbtn.Click += new System.EventHandler(this.addusercancelbtn_Click);
            // 
            // adduseraddbtn
            // 
            this.adduseraddbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.adduseraddbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adduseraddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adduseraddbtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduseraddbtn.ForeColor = System.Drawing.Color.Black;
            this.adduseraddbtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.adduseraddbtn.IconColor = System.Drawing.Color.Black;
            this.adduseraddbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adduseraddbtn.IconSize = 26;
            this.adduseraddbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adduseraddbtn.Location = new System.Drawing.Point(160, 211);
            this.adduseraddbtn.Name = "adduseraddbtn";
            this.adduseraddbtn.Size = new System.Drawing.Size(88, 51);
            this.adduseraddbtn.TabIndex = 4;
            this.adduseraddbtn.Text = "Add";
            this.adduseraddbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adduseraddbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adduseraddbtn.UseVisualStyleBackColor = false;
            this.adduseraddbtn.Click += new System.EventHandler(this.adduseraddbtn_Click);
            // 
            // adduserpassword
            // 
            this.adduserpassword.AutoSize = true;
            this.adduserpassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserpassword.ForeColor = System.Drawing.Color.Black;
            this.adduserpassword.Location = new System.Drawing.Point(84, 85);
            this.adduserpassword.Name = "adduserpassword";
            this.adduserpassword.Size = new System.Drawing.Size(69, 20);
            this.adduserpassword.TabIndex = 3;
            this.adduserpassword.Text = "Password";
            // 
            // adduserusername
            // 
            this.adduserusername.AutoSize = true;
            this.adduserusername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserusername.ForeColor = System.Drawing.Color.Black;
            this.adduserusername.Location = new System.Drawing.Point(82, 52);
            this.adduserusername.Name = "adduserusername";
            this.adduserusername.Size = new System.Drawing.Size(71, 20);
            this.adduserusername.TabIndex = 2;
            this.adduserusername.Text = "Username";
            // 
            // txtpasswordadduser
            // 
            this.txtpasswordadduser.Location = new System.Drawing.Point(161, 87);
            this.txtpasswordadduser.Name = "txtpasswordadduser";
            this.txtpasswordadduser.Size = new System.Drawing.Size(191, 20);
            this.txtpasswordadduser.TabIndex = 1;
            this.txtpasswordadduser.UseSystemPasswordChar = true;
            // 
            // textboxadduser
            // 
            this.textboxadduser.Location = new System.Drawing.Point(160, 52);
            this.textboxadduser.Name = "textboxadduser";
            this.textboxadduser.Size = new System.Drawing.Size(192, 20);
            this.textboxadduser.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 327);
            this.Controls.Add(this.addUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAccount";
            this.addUserPanel.ResumeLayout(false);
            this.addUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addUserPanel;
        private System.Windows.Forms.TextBox txtpasswordadduser;
        private System.Windows.Forms.TextBox textboxadduser;
        private System.Windows.Forms.Label adduserpassword;
        private System.Windows.Forms.Label adduserusername;
        private System.Windows.Forms.ComboBox cmbusertype;
        private FontAwesome.Sharp.IconButton addusercancelbtn;
        private FontAwesome.Sharp.IconButton adduseraddbtn;
        private System.Windows.Forms.Label userdropdown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox addusercheckbox;
    }
}