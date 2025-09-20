namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.UsernameType = new System.Windows.Forms.Label();
            this.UsernameShow = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.logoutbtn = new FontAwesome.Sharp.IconButton();
            this.logsbtn = new FontAwesome.Sharp.IconButton();
            this.eqpmentbtn = new FontAwesome.Sharp.IconButton();
            this.accntbtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.TitleChildForm = new System.Windows.Forms.Label();
            this.currentChildformIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.HomeLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildformIcon)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.logoutbtn);
            this.panelMenu.Controls.Add(this.logsbtn);
            this.panelMenu.Controls.Add(this.eqpmentbtn);
            this.panelMenu.Controls.Add(this.accntbtn);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 674);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // UsernameType
            // 
            this.UsernameType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameType.AutoSize = true;
            this.UsernameType.BackColor = System.Drawing.Color.White;
            this.UsernameType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameType.ForeColor = System.Drawing.Color.Transparent;
            this.UsernameType.Location = new System.Drawing.Point(-15, 675);
            this.UsernameType.Name = "UsernameType";
            this.UsernameType.Size = new System.Drawing.Size(132, 24);
            this.UsernameType.TabIndex = 8;
            this.UsernameType.Text = "Administrator";
            this.UsernameType.Click += new System.EventHandler(this.UsernameType_Click);
            // 
            // UsernameShow
            // 
            this.UsernameShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameShow.AutoSize = true;
            this.UsernameShow.BackColor = System.Drawing.Color.White;
            this.UsernameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameShow.ForeColor = System.Drawing.Color.Transparent;
            this.UsernameShow.Location = new System.Drawing.Point(12, 664);
            this.UsernameShow.Name = "UsernameShow";
            this.UsernameShow.Size = new System.Drawing.Size(105, 24);
            this.UsernameShow.TabIndex = 7;
            this.UsernameShow.Text = "Username";
            this.UsernameShow.Click += new System.EventHandler(this.UsernameShow_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 10;
            this.iconPictureBox1.Location = new System.Drawing.Point(16, 675);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(16, 10);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.White;
            this.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.ForeColor = System.Drawing.Color.Black;
            this.logoutbtn.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.logoutbtn.IconColor = System.Drawing.Color.Black;
            this.logoutbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutbtn.IconSize = 32;
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.Location = new System.Drawing.Point(0, 162);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logoutbtn.Size = new System.Drawing.Size(220, 59);
            this.logoutbtn.TabIndex = 5;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // logsbtn
            // 
            this.logsbtn.BackColor = System.Drawing.Color.White;
            this.logsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logsbtn.FlatAppearance.BorderSize = 0;
            this.logsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logsbtn.ForeColor = System.Drawing.Color.Black;
            this.logsbtn.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.logsbtn.IconColor = System.Drawing.Color.Black;
            this.logsbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logsbtn.IconSize = 32;
            this.logsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logsbtn.Location = new System.Drawing.Point(0, 108);
            this.logsbtn.Name = "logsbtn";
            this.logsbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logsbtn.Size = new System.Drawing.Size(220, 54);
            this.logsbtn.TabIndex = 4;
            this.logsbtn.Text = "Logs";
            this.logsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logsbtn.UseVisualStyleBackColor = false;
            this.logsbtn.Click += new System.EventHandler(this.logsbtn_Click);
            // 
            // eqpmentbtn
            // 
            this.eqpmentbtn.BackColor = System.Drawing.Color.White;
            this.eqpmentbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eqpmentbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.eqpmentbtn.FlatAppearance.BorderSize = 0;
            this.eqpmentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eqpmentbtn.ForeColor = System.Drawing.Color.Black;
            this.eqpmentbtn.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.eqpmentbtn.IconColor = System.Drawing.Color.Black;
            this.eqpmentbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eqpmentbtn.IconSize = 32;
            this.eqpmentbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eqpmentbtn.Location = new System.Drawing.Point(0, 54);
            this.eqpmentbtn.Name = "eqpmentbtn";
            this.eqpmentbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.eqpmentbtn.Size = new System.Drawing.Size(220, 54);
            this.eqpmentbtn.TabIndex = 2;
            this.eqpmentbtn.Text = "Equipments";
            this.eqpmentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eqpmentbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eqpmentbtn.UseVisualStyleBackColor = false;
            this.eqpmentbtn.Click += new System.EventHandler(this.eqpmentbtn_Click);
            // 
            // accntbtn
            // 
            this.accntbtn.BackColor = System.Drawing.Color.White;
            this.accntbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accntbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.accntbtn.FlatAppearance.BorderSize = 0;
            this.accntbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accntbtn.ForeColor = System.Drawing.Color.Black;
            this.accntbtn.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.accntbtn.IconColor = System.Drawing.Color.Black;
            this.accntbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accntbtn.IconSize = 32;
            this.accntbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accntbtn.Location = new System.Drawing.Point(0, 0);
            this.accntbtn.Name = "accntbtn";
            this.accntbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.accntbtn.Size = new System.Drawing.Size(220, 54);
            this.accntbtn.TabIndex = 1;
            this.accntbtn.Text = "Accounts";
            this.accntbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accntbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accntbtn.UseVisualStyleBackColor = false;
            this.accntbtn.Click += new System.EventHandler(this.accntbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 674);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.White;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(37, 779);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(17, 10);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.TitleChildForm);
            this.panelTitleBar.Controls.Add(this.currentChildformIcon);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(941, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 22;
            this.btnClose.Location = new System.Drawing.Point(909, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 22;
            this.btnMinimize.Location = new System.Drawing.Point(853, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 25);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.ForeColor = System.Drawing.Color.Black;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 22;
            this.btnMaximize.Location = new System.Drawing.Point(881, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(22, 25);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // TitleChildForm
            // 
            this.TitleChildForm.AutoSize = true;
            this.TitleChildForm.BackColor = System.Drawing.Color.White;
            this.TitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TitleChildForm.ForeColor = System.Drawing.Color.Black;
            this.TitleChildForm.Location = new System.Drawing.Point(69, 30);
            this.TitleChildForm.Name = "TitleChildForm";
            this.TitleChildForm.Size = new System.Drawing.Size(62, 24);
            this.TitleChildForm.TabIndex = 1;
            this.TitleChildForm.Text = "Home";
            this.TitleChildForm.Click += new System.EventHandler(this.TitleChildForm_Click);
            // 
            // currentChildformIcon
            // 
            this.currentChildformIcon.BackColor = System.Drawing.Color.White;
            this.currentChildformIcon.ForeColor = System.Drawing.Color.Black;
            this.currentChildformIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            this.currentChildformIcon.IconColor = System.Drawing.Color.Black;
            this.currentChildformIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentChildformIcon.IconSize = 65;
            this.currentChildformIcon.Location = new System.Drawing.Point(6, 9);
            this.currentChildformIcon.Name = "currentChildformIcon";
            this.currentChildformIcon.Size = new System.Drawing.Size(171, 65);
            this.currentChildformIcon.TabIndex = 0;
            this.currentChildformIcon.TabStop = false;
            this.currentChildformIcon.Click += new System.EventHandler(this.currentChildformIcon_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.White;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(941, 9);
            this.panelShadow.TabIndex = 2;
            this.panelShadow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShadow_Paint);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.UsernameType);
            this.panelDesktop.Controls.Add(this.Logo);
            this.panelDesktop.Controls.Add(this.UsernameShow);
            this.panelDesktop.Controls.Add(this.HomeLogo);
            this.panelDesktop.Controls.Add(this.iconPictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(941, 585);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // HomeLogo
            // 
            this.HomeLogo.BackColor = System.Drawing.Color.White;
            this.HomeLogo.Image = ((System.Drawing.Image)(resources.GetObject("HomeLogo.Image")));
            this.HomeLogo.Location = new System.Drawing.Point(51, 779);
            this.HomeLogo.Name = "HomeLogo";
            this.HomeLogo.Size = new System.Drawing.Size(46, 10);
            this.HomeLogo.TabIndex = 0;
            this.HomeLogo.TabStop = false;
            this.HomeLogo.Click += new System.EventHandler(this.HomeLogo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 674);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fromMain";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildformIcon)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton accntbtn;
        private FontAwesome.Sharp.IconButton eqpmentbtn;
        private FontAwesome.Sharp.IconButton logoutbtn;
        private FontAwesome.Sharp.IconButton logsbtn;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox Logo;
        private FontAwesome.Sharp.IconPictureBox currentChildformIcon;
        private System.Windows.Forms.Label TitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.PictureBox HomeLogo;
        private System.Windows.Forms.Label UsernameShow;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label UsernameType;
    }
}