namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    partial class frmEqpUpdate
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
            this.departmentboxUpdate = new System.Windows.Forms.TextBox();
            this.branchcomboboxupdate = new System.Windows.Forms.ComboBox();
            this.BranchUpdate = new System.Windows.Forms.Label();
            this.DescriptionUpdate = new System.Windows.Forms.Label();
            this.DescriptionBoxTxtUpdate = new System.Windows.Forms.RichTextBox();
            this.yearModelUpdate = new System.Windows.Forms.Label();
            this.yearmodeltxtboxUpdate = new System.Windows.Forms.TextBox();
            this.ManufacturerUpdate = new System.Windows.Forms.Label();
            this.manufacturertxtboxupdate = new System.Windows.Forms.TextBox();
            this.errorEqpProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DepartmentUpdate = new System.Windows.Forms.Label();
            this.eqptypedropdownupdate = new System.Windows.Forms.Label();
            this.cmbupdateeqptype = new System.Windows.Forms.ComboBox();
            this.UpdateSerialNumber = new System.Windows.Forms.Label();
            this.UpdateAssetNumber = new System.Windows.Forms.Label();
            this.txtserialnumberupdateeqp = new System.Windows.Forms.TextBox();
            this.textassetnumberupdate = new System.Windows.Forms.TextBox();
            this.addUserPanel = new System.Windows.Forms.Panel();
            this.updateusercancelbtn = new FontAwesome.Sharp.IconButton();
            this.updateuseraddbtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusUpdate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorEqpProvider1)).BeginInit();
            this.addUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentboxUpdate
            // 
            this.departmentboxUpdate.Location = new System.Drawing.Point(119, 377);
            this.departmentboxUpdate.Name = "departmentboxUpdate";
            this.departmentboxUpdate.Size = new System.Drawing.Size(197, 20);
            this.departmentboxUpdate.TabIndex = 18;
            // 
            // branchcomboboxupdate
            // 
            this.branchcomboboxupdate.FormattingEnabled = true;
            this.branchcomboboxupdate.Items.AddRange(new object[] {
            "AU Main Campus",
            "AU Pasay",
            "AU Mandaluyong",
            "AU Malabon",
            "AU Pasig"});
            this.branchcomboboxupdate.Location = new System.Drawing.Point(119, 333);
            this.branchcomboboxupdate.Name = "branchcomboboxupdate";
            this.branchcomboboxupdate.Size = new System.Drawing.Size(197, 21);
            this.branchcomboboxupdate.TabIndex = 16;
            // 
            // BranchUpdate
            // 
            this.BranchUpdate.AutoSize = true;
            this.BranchUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.BranchUpdate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchUpdate.ForeColor = System.Drawing.Color.Black;
            this.BranchUpdate.Location = new System.Drawing.Point(51, 331);
            this.BranchUpdate.Name = "BranchUpdate";
            this.BranchUpdate.Size = new System.Drawing.Size(53, 20);
            this.BranchUpdate.TabIndex = 15;
            this.BranchUpdate.Text = "Branch";
            // 
            // DescriptionUpdate
            // 
            this.DescriptionUpdate.AutoSize = true;
            this.DescriptionUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.DescriptionUpdate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionUpdate.ForeColor = System.Drawing.Color.Black;
            this.DescriptionUpdate.Location = new System.Drawing.Point(17, 243);
            this.DescriptionUpdate.Name = "DescriptionUpdate";
            this.DescriptionUpdate.Size = new System.Drawing.Size(87, 20);
            this.DescriptionUpdate.TabIndex = 13;
            this.DescriptionUpdate.Text = "Descriptions";
            // 
            // DescriptionBoxTxtUpdate
            // 
            this.DescriptionBoxTxtUpdate.Location = new System.Drawing.Point(119, 243);
            this.DescriptionBoxTxtUpdate.Name = "DescriptionBoxTxtUpdate";
            this.DescriptionBoxTxtUpdate.Size = new System.Drawing.Size(197, 82);
            this.DescriptionBoxTxtUpdate.TabIndex = 12;
            this.DescriptionBoxTxtUpdate.Text = "";
            // 
            // yearModelUpdate
            // 
            this.yearModelUpdate.AutoSize = true;
            this.yearModelUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.yearModelUpdate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearModelUpdate.ForeColor = System.Drawing.Color.Black;
            this.yearModelUpdate.Location = new System.Drawing.Point(33, 200);
            this.yearModelUpdate.Name = "yearModelUpdate";
            this.yearModelUpdate.Size = new System.Drawing.Size(78, 20);
            this.yearModelUpdate.TabIndex = 11;
            this.yearModelUpdate.Text = "Year Model";
            // 
            // yearmodeltxtboxUpdate
            // 
            this.yearmodeltxtboxUpdate.Location = new System.Drawing.Point(119, 200);
            this.yearmodeltxtboxUpdate.Name = "yearmodeltxtboxUpdate";
            this.yearmodeltxtboxUpdate.Size = new System.Drawing.Size(197, 20);
            this.yearmodeltxtboxUpdate.TabIndex = 10;
            // 
            // ManufacturerUpdate
            // 
            this.ManufacturerUpdate.AutoSize = true;
            this.ManufacturerUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.ManufacturerUpdate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerUpdate.ForeColor = System.Drawing.Color.Black;
            this.ManufacturerUpdate.Location = new System.Drawing.Point(21, 153);
            this.ManufacturerUpdate.Name = "ManufacturerUpdate";
            this.ManufacturerUpdate.Size = new System.Drawing.Size(90, 20);
            this.ManufacturerUpdate.TabIndex = 9;
            this.ManufacturerUpdate.Text = "Manufacturer";
            // 
            // manufacturertxtboxupdate
            // 
            this.manufacturertxtboxupdate.Location = new System.Drawing.Point(119, 155);
            this.manufacturertxtboxupdate.Name = "manufacturertxtboxupdate";
            this.manufacturertxtboxupdate.Size = new System.Drawing.Size(197, 20);
            this.manufacturertxtboxupdate.TabIndex = 8;
            // 
            // errorEqpProvider1
            // 
            this.errorEqpProvider1.ContainerControl = this;
            // 
            // DepartmentUpdate
            // 
            this.DepartmentUpdate.AutoSize = true;
            this.DepartmentUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.DepartmentUpdate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentUpdate.ForeColor = System.Drawing.Color.Black;
            this.DepartmentUpdate.Location = new System.Drawing.Point(24, 377);
            this.DepartmentUpdate.Name = "DepartmentUpdate";
            this.DepartmentUpdate.Size = new System.Drawing.Size(80, 20);
            this.DepartmentUpdate.TabIndex = 17;
            this.DepartmentUpdate.Text = "Department";
            // 
            // eqptypedropdownupdate
            // 
            this.eqptypedropdownupdate.AutoSize = true;
            this.eqptypedropdownupdate.BackColor = System.Drawing.Color.SkyBlue;
            this.eqptypedropdownupdate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqptypedropdownupdate.ForeColor = System.Drawing.Color.Black;
            this.eqptypedropdownupdate.Location = new System.Drawing.Point(72, 116);
            this.eqptypedropdownupdate.Name = "eqptypedropdownupdate";
            this.eqptypedropdownupdate.Size = new System.Drawing.Size(39, 20);
            this.eqptypedropdownupdate.TabIndex = 7;
            this.eqptypedropdownupdate.Text = "Type";
            // 
            // cmbupdateeqptype
            // 
            this.cmbupdateeqptype.FormattingEnabled = true;
            this.cmbupdateeqptype.Items.AddRange(new object[] {
            "Monitor",
            "CPU",
            "Keyboard",
            "Mouse",
            "AVR",
            "MAC",
            "Printer",
            "Projector"});
            this.cmbupdateeqptype.Location = new System.Drawing.Point(119, 118);
            this.cmbupdateeqptype.Name = "cmbupdateeqptype";
            this.cmbupdateeqptype.Size = new System.Drawing.Size(157, 21);
            this.cmbupdateeqptype.TabIndex = 6;
            // 
            // UpdateSerialNumber
            // 
            this.UpdateSerialNumber.AutoSize = true;
            this.UpdateSerialNumber.BackColor = System.Drawing.Color.SkyBlue;
            this.UpdateSerialNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSerialNumber.ForeColor = System.Drawing.Color.Black;
            this.UpdateSerialNumber.Location = new System.Drawing.Point(17, 80);
            this.UpdateSerialNumber.Name = "UpdateSerialNumber";
            this.UpdateSerialNumber.Size = new System.Drawing.Size(98, 20);
            this.UpdateSerialNumber.TabIndex = 3;
            this.UpdateSerialNumber.Text = "Serial Number";
            // 
            // UpdateAssetNumber
            // 
            this.UpdateAssetNumber.AutoSize = true;
            this.UpdateAssetNumber.BackColor = System.Drawing.Color.SkyBlue;
            this.UpdateAssetNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAssetNumber.ForeColor = System.Drawing.Color.Black;
            this.UpdateAssetNumber.Location = new System.Drawing.Point(17, 40);
            this.UpdateAssetNumber.Name = "UpdateAssetNumber";
            this.UpdateAssetNumber.Size = new System.Drawing.Size(96, 20);
            this.UpdateAssetNumber.TabIndex = 2;
            this.UpdateAssetNumber.Text = "Asset Number";
            // 
            // txtserialnumberupdateeqp
            // 
            this.txtserialnumberupdateeqp.Location = new System.Drawing.Point(119, 82);
            this.txtserialnumberupdateeqp.Name = "txtserialnumberupdateeqp";
            this.txtserialnumberupdateeqp.Size = new System.Drawing.Size(197, 20);
            this.txtserialnumberupdateeqp.TabIndex = 1;
            // 
            // textassetnumberupdate
            // 
            this.textassetnumberupdate.Location = new System.Drawing.Point(119, 42);
            this.textassetnumberupdate.Name = "textassetnumberupdate";
            this.textassetnumberupdate.Size = new System.Drawing.Size(197, 20);
            this.textassetnumberupdate.TabIndex = 0;
            // 
            // addUserPanel
            // 
            this.addUserPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.addUserPanel.Controls.Add(this.updateusercancelbtn);
            this.addUserPanel.Controls.Add(this.updateuseraddbtn);
            this.addUserPanel.Controls.Add(this.label1);
            this.addUserPanel.Controls.Add(this.StatusUpdate);
            this.addUserPanel.Controls.Add(this.departmentboxUpdate);
            this.addUserPanel.Controls.Add(this.DepartmentUpdate);
            this.addUserPanel.Controls.Add(this.branchcomboboxupdate);
            this.addUserPanel.Controls.Add(this.BranchUpdate);
            this.addUserPanel.Controls.Add(this.DescriptionUpdate);
            this.addUserPanel.Controls.Add(this.DescriptionBoxTxtUpdate);
            this.addUserPanel.Controls.Add(this.yearModelUpdate);
            this.addUserPanel.Controls.Add(this.yearmodeltxtboxUpdate);
            this.addUserPanel.Controls.Add(this.ManufacturerUpdate);
            this.addUserPanel.Controls.Add(this.manufacturertxtboxupdate);
            this.addUserPanel.Controls.Add(this.eqptypedropdownupdate);
            this.addUserPanel.Controls.Add(this.cmbupdateeqptype);
            this.addUserPanel.Controls.Add(this.UpdateSerialNumber);
            this.addUserPanel.Controls.Add(this.UpdateAssetNumber);
            this.addUserPanel.Controls.Add(this.txtserialnumberupdateeqp);
            this.addUserPanel.Controls.Add(this.textassetnumberupdate);
            this.addUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserPanel.Location = new System.Drawing.Point(0, 0);
            this.addUserPanel.Name = "addUserPanel";
            this.addUserPanel.Size = new System.Drawing.Size(447, 555);
            this.addUserPanel.TabIndex = 2;
            this.addUserPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addUserPanel_MouseDown);
            // 
            // updateusercancelbtn
            // 
            this.updateusercancelbtn.BackColor = System.Drawing.Color.Red;
            this.updateusercancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateusercancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateusercancelbtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateusercancelbtn.ForeColor = System.Drawing.Color.Black;
            this.updateusercancelbtn.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.updateusercancelbtn.IconColor = System.Drawing.Color.Black;
            this.updateusercancelbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateusercancelbtn.IconSize = 26;
            this.updateusercancelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateusercancelbtn.Location = new System.Drawing.Point(175, 481);
            this.updateusercancelbtn.Name = "updateusercancelbtn";
            this.updateusercancelbtn.Size = new System.Drawing.Size(141, 46);
            this.updateusercancelbtn.TabIndex = 22;
            this.updateusercancelbtn.Text = "Cancel";
            this.updateusercancelbtn.UseVisualStyleBackColor = false;
            this.updateusercancelbtn.Click += new System.EventHandler(this.updateusercancelbtn_Click);
            // 
            // updateuseraddbtn
            // 
            this.updateuseraddbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateuseraddbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateuseraddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateuseraddbtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateuseraddbtn.ForeColor = System.Drawing.Color.Black;
            this.updateuseraddbtn.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.updateuseraddbtn.IconColor = System.Drawing.Color.Black;
            this.updateuseraddbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateuseraddbtn.IconSize = 26;
            this.updateuseraddbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateuseraddbtn.Location = new System.Drawing.Point(21, 481);
            this.updateuseraddbtn.Name = "updateuseraddbtn";
            this.updateuseraddbtn.Size = new System.Drawing.Size(138, 46);
            this.updateuseraddbtn.TabIndex = 21;
            this.updateuseraddbtn.Text = "Saved";
            this.updateuseraddbtn.UseVisualStyleBackColor = false;
            this.updateuseraddbtn.Click += new System.EventHandler(this.updateuseraddbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Status";
            // 
            // StatusUpdate
            // 
            this.StatusUpdate.FormattingEnabled = true;
            this.StatusUpdate.Items.AddRange(new object[] {
            "Working",
            "On-Repair",
            "Retired"});
            this.StatusUpdate.Location = new System.Drawing.Point(119, 417);
            this.StatusUpdate.Name = "StatusUpdate";
            this.StatusUpdate.Size = new System.Drawing.Size(157, 21);
            this.StatusUpdate.TabIndex = 19;
            // 
            // frmEqpUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 555);
            this.Controls.Add(this.addUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEqpUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEqpUpdate";
            this.Load += new System.EventHandler(this.frmEqpUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorEqpProvider1)).EndInit();
            this.addUserPanel.ResumeLayout(false);
            this.addUserPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox departmentboxUpdate;
        private System.Windows.Forms.ComboBox branchcomboboxupdate;
        private System.Windows.Forms.Label BranchUpdate;
        private System.Windows.Forms.Label DescriptionUpdate;
        private System.Windows.Forms.RichTextBox DescriptionBoxTxtUpdate;
        private System.Windows.Forms.Label yearModelUpdate;
        private System.Windows.Forms.TextBox yearmodeltxtboxUpdate;
        private System.Windows.Forms.Label ManufacturerUpdate;
        private System.Windows.Forms.TextBox manufacturertxtboxupdate;
        private System.Windows.Forms.ErrorProvider errorEqpProvider1;
        private System.Windows.Forms.Panel addUserPanel;
        private System.Windows.Forms.Label DepartmentUpdate;
        private System.Windows.Forms.Label eqptypedropdownupdate;
        private System.Windows.Forms.ComboBox cmbupdateeqptype;
        private System.Windows.Forms.Label UpdateSerialNumber;
        private System.Windows.Forms.Label UpdateAssetNumber;
        private System.Windows.Forms.TextBox txtserialnumberupdateeqp;
        private System.Windows.Forms.TextBox textassetnumberupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StatusUpdate;
        private FontAwesome.Sharp.IconButton updateusercancelbtn;
        private FontAwesome.Sharp.IconButton updateuseraddbtn;
    }
}