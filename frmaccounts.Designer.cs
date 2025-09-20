namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    partial class frmaccounts
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
            this.AccntList = new System.Windows.Forms.DataGridView();
            this.addbtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new FontAwesome.Sharp.IconButton();
            this.editbtn = new FontAwesome.Sharp.IconButton();
            this.deletebtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.AccntList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccntList
            // 
            this.AccntList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccntList.Location = new System.Drawing.Point(184, 148);
            this.AccntList.Name = "AccntList";
            this.AccntList.Size = new System.Drawing.Size(710, 287);
            this.AccntList.TabIndex = 0;
            this.AccntList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccntList_CellContentClick);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Black;
            this.addbtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.addbtn.IconColor = System.Drawing.Color.Black;
            this.addbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addbtn.IconSize = 32;
            this.addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbtn.Location = new System.Drawing.Point(21, 148);
            this.addbtn.Name = "addbtn";
            this.addbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.addbtn.Size = new System.Drawing.Size(145, 45);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Add";
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.Searchlabel);
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.editbtn);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.AccntList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 844);
            this.panel1.TabIndex = 0;
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.ForeColor = System.Drawing.Color.Black;
            this.Searchlabel.Location = new System.Drawing.Point(262, 105);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(68, 23);
            this.Searchlabel.TabIndex = 7;
            this.Searchlabel.Text = "Search:";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(343, 109);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(407, 20);
            this.searchbox.TabIndex = 6;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.IndianRed;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.RefreshBtn.IconColor = System.Drawing.Color.Black;
            this.RefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefreshBtn.IconSize = 32;
            this.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshBtn.Location = new System.Drawing.Point(21, 390);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.RefreshBtn.Size = new System.Drawing.Size(145, 45);
            this.RefreshBtn.TabIndex = 5;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Yellow;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.Black;
            this.editbtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.editbtn.IconColor = System.Drawing.Color.Black;
            this.editbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editbtn.IconSize = 32;
            this.editbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editbtn.Location = new System.Drawing.Point(21, 314);
            this.editbtn.Name = "editbtn";
            this.editbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.editbtn.Size = new System.Drawing.Size(145, 45);
            this.editbtn.TabIndex = 4;
            this.editbtn.Text = "Edit";
            this.editbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Red;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.Black;
            this.deletebtn.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.deletebtn.IconColor = System.Drawing.Color.Black;
            this.deletebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deletebtn.IconSize = 32;
            this.deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.Location = new System.Drawing.Point(21, 228);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.deletebtn.Size = new System.Drawing.Size(145, 45);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // frmaccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 844);
            this.Controls.Add(this.panel1);
            this.Name = "frmaccounts";
            this.Text = "User Accounts List";
            ((System.ComponentModel.ISupportInitialize)(this.AccntList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AccntList;
        private FontAwesome.Sharp.IconButton addbtn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton RefreshBtn;
        private FontAwesome.Sharp.IconButton editbtn;
        private FontAwesome.Sharp.IconButton deletebtn;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.TextBox searchbox;
    }
}