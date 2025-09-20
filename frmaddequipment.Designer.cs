namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    partial class frmaddequipment
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
            this.departmentbox = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.Label();
            this.branchcombobox = new System.Windows.Forms.ComboBox();
            this.Branch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionBoxTxt = new System.Windows.Forms.RichTextBox();
            this.yearModel = new System.Windows.Forms.Label();
            this.yearmodeltxtbox = new System.Windows.Forms.TextBox();
            this.Manufacturer = new System.Windows.Forms.Label();
            this.manufacturertxtbox = new System.Windows.Forms.TextBox();
            this.eqptypedropdown = new System.Windows.Forms.Label();
            this.cmbeqptype = new System.Windows.Forms.ComboBox();
            this.addusercancelbtn = new FontAwesome.Sharp.IconButton();
            this.addeqpaddbtn = new FontAwesome.Sharp.IconButton();
            this.SerialNumber = new System.Windows.Forms.Label();
            this.AssetNumber = new System.Windows.Forms.Label();
            this.txtserialnumberaddeqp = new System.Windows.Forms.TextBox();
            this.textassetnumber = new System.Windows.Forms.TextBox();
            this.errorEqpProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.addUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEqpProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // addUserPanel
            // 
            this.addUserPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.addUserPanel.Controls.Add(this.departmentbox);
            this.addUserPanel.Controls.Add(this.Department);
            this.addUserPanel.Controls.Add(this.branchcombobox);
            this.addUserPanel.Controls.Add(this.Branch);
            this.addUserPanel.Controls.Add(this.label1);
            this.addUserPanel.Controls.Add(this.DescriptionBoxTxt);
            this.addUserPanel.Controls.Add(this.yearModel);
            this.addUserPanel.Controls.Add(this.yearmodeltxtbox);
            this.addUserPanel.Controls.Add(this.Manufacturer);
            this.addUserPanel.Controls.Add(this.manufacturertxtbox);
            this.addUserPanel.Controls.Add(this.eqptypedropdown);
            this.addUserPanel.Controls.Add(this.cmbeqptype);
            this.addUserPanel.Controls.Add(this.addusercancelbtn);
            this.addUserPanel.Controls.Add(this.addeqpaddbtn);
            this.addUserPanel.Controls.Add(this.SerialNumber);
            this.addUserPanel.Controls.Add(this.AssetNumber);
            this.addUserPanel.Controls.Add(this.txtserialnumberaddeqp);
            this.addUserPanel.Controls.Add(this.textassetnumber);
            this.addUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserPanel.Location = new System.Drawing.Point(0, 0);
            this.addUserPanel.Name = "addUserPanel";
            this.addUserPanel.Size = new System.Drawing.Size(466, 535);
            this.addUserPanel.TabIndex = 1;
            this.addUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addUserPanel_Paint);
            this.addUserPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addUserPanel_MouseDown);
            // 
            // departmentbox
            // 
            this.departmentbox.Location = new System.Drawing.Point(119, 390);
            this.departmentbox.Name = "departmentbox";
            this.departmentbox.Size = new System.Drawing.Size(197, 20);
            this.departmentbox.TabIndex = 18;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.BackColor = System.Drawing.Color.SkyBlue;
            this.Department.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.Color.Black;
            this.Department.Location = new System.Drawing.Point(24, 388);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(80, 20);
            this.Department.TabIndex = 17;
            this.Department.Text = "Department";
            // 
            // branchcombobox
            // 
            this.branchcombobox.FormattingEnabled = true;
            this.branchcombobox.Items.AddRange(new object[] {
            "AU Main Campus",
            "AU Pasay",
            "AU Mandaluyong",
            "AU Malabon",
            "AU Pasig"});
            this.branchcombobox.Location = new System.Drawing.Point(119, 345);
            this.branchcombobox.Name = "branchcombobox";
            this.branchcombobox.Size = new System.Drawing.Size(197, 21);
            this.branchcombobox.TabIndex = 16;
            // 
            // Branch
            // 
            this.Branch.AutoSize = true;
            this.Branch.BackColor = System.Drawing.Color.SkyBlue;
            this.Branch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Branch.ForeColor = System.Drawing.Color.Black;
            this.Branch.Location = new System.Drawing.Point(51, 343);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(53, 20);
            this.Branch.TabIndex = 15;
            this.Branch.Text = "Branch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descriptions";
            // 
            // DescriptionBoxTxt
            // 
            this.DescriptionBoxTxt.Location = new System.Drawing.Point(119, 240);
            this.DescriptionBoxTxt.Name = "DescriptionBoxTxt";
            this.DescriptionBoxTxt.Size = new System.Drawing.Size(197, 87);
            this.DescriptionBoxTxt.TabIndex = 12;
            this.DescriptionBoxTxt.Text = "";
            // 
            // yearModel
            // 
            this.yearModel.AutoSize = true;
            this.yearModel.BackColor = System.Drawing.Color.SkyBlue;
            this.yearModel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearModel.ForeColor = System.Drawing.Color.Black;
            this.yearModel.Location = new System.Drawing.Point(29, 196);
            this.yearModel.Name = "yearModel";
            this.yearModel.Size = new System.Drawing.Size(78, 20);
            this.yearModel.TabIndex = 11;
            this.yearModel.Text = "Year Model";
            // 
            // yearmodeltxtbox
            // 
            this.yearmodeltxtbox.Location = new System.Drawing.Point(119, 198);
            this.yearmodeltxtbox.Name = "yearmodeltxtbox";
            this.yearmodeltxtbox.Size = new System.Drawing.Size(197, 20);
            this.yearmodeltxtbox.TabIndex = 10;
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.BackColor = System.Drawing.Color.SkyBlue;
            this.Manufacturer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manufacturer.ForeColor = System.Drawing.Color.Black;
            this.Manufacturer.Location = new System.Drawing.Point(17, 156);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(90, 20);
            this.Manufacturer.TabIndex = 9;
            this.Manufacturer.Text = "Manufacturer";
            // 
            // manufacturertxtbox
            // 
            this.manufacturertxtbox.Location = new System.Drawing.Point(119, 158);
            this.manufacturertxtbox.Name = "manufacturertxtbox";
            this.manufacturertxtbox.Size = new System.Drawing.Size(197, 20);
            this.manufacturertxtbox.TabIndex = 8;
            // 
            // eqptypedropdown
            // 
            this.eqptypedropdown.AutoSize = true;
            this.eqptypedropdown.BackColor = System.Drawing.Color.SkyBlue;
            this.eqptypedropdown.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqptypedropdown.ForeColor = System.Drawing.Color.Black;
            this.eqptypedropdown.Location = new System.Drawing.Point(65, 116);
            this.eqptypedropdown.Name = "eqptypedropdown";
            this.eqptypedropdown.Size = new System.Drawing.Size(39, 20);
            this.eqptypedropdown.TabIndex = 7;
            this.eqptypedropdown.Text = "Type";
            // 
            // cmbeqptype
            // 
            this.cmbeqptype.FormattingEnabled = true;
            this.cmbeqptype.Items.AddRange(new object[] {
            "Monitor",
            "CPU",
            "Keyboard",
            "Mouse",
            "AVR",
            "MAC",
            "Printer",
            "Projector"});
            this.cmbeqptype.Location = new System.Drawing.Point(119, 118);
            this.cmbeqptype.Name = "cmbeqptype";
            this.cmbeqptype.Size = new System.Drawing.Size(155, 21);
            this.cmbeqptype.TabIndex = 6;
            // 
            // addusercancelbtn
            // 
            this.addusercancelbtn.BackColor = System.Drawing.Color.Red;
            this.addusercancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addusercancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addusercancelbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addusercancelbtn.ForeColor = System.Drawing.Color.Black;
            this.addusercancelbtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.addusercancelbtn.IconColor = System.Drawing.Color.Black;
            this.addusercancelbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addusercancelbtn.IconSize = 26;
            this.addusercancelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addusercancelbtn.Location = new System.Drawing.Point(190, 440);
            this.addusercancelbtn.Name = "addusercancelbtn";
            this.addusercancelbtn.Size = new System.Drawing.Size(126, 51);
            this.addusercancelbtn.TabIndex = 5;
            this.addusercancelbtn.Text = "Cancel";
            this.addusercancelbtn.UseVisualStyleBackColor = false;
            this.addusercancelbtn.Click += new System.EventHandler(this.addusercancelbtn_Click);
            // 
            // addeqpaddbtn
            // 
            this.addeqpaddbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addeqpaddbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addeqpaddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addeqpaddbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addeqpaddbtn.ForeColor = System.Drawing.Color.Black;
            this.addeqpaddbtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addeqpaddbtn.IconColor = System.Drawing.Color.Black;
            this.addeqpaddbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addeqpaddbtn.IconSize = 26;
            this.addeqpaddbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addeqpaddbtn.Location = new System.Drawing.Point(55, 440);
            this.addeqpaddbtn.Name = "addeqpaddbtn";
            this.addeqpaddbtn.Size = new System.Drawing.Size(119, 51);
            this.addeqpaddbtn.TabIndex = 4;
            this.addeqpaddbtn.Text = "Add";
            this.addeqpaddbtn.UseVisualStyleBackColor = false;
            this.addeqpaddbtn.Click += new System.EventHandler(this.addeqpaddbtn_Click);
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSize = true;
            this.SerialNumber.BackColor = System.Drawing.Color.SkyBlue;
            this.SerialNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumber.ForeColor = System.Drawing.Color.Black;
            this.SerialNumber.Location = new System.Drawing.Point(15, 80);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(98, 20);
            this.SerialNumber.TabIndex = 3;
            this.SerialNumber.Text = "Serial Number";
            // 
            // AssetNumber
            // 
            this.AssetNumber.AutoSize = true;
            this.AssetNumber.BackColor = System.Drawing.Color.SkyBlue;
            this.AssetNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetNumber.ForeColor = System.Drawing.Color.Black;
            this.AssetNumber.Location = new System.Drawing.Point(17, 44);
            this.AssetNumber.Name = "AssetNumber";
            this.AssetNumber.Size = new System.Drawing.Size(96, 20);
            this.AssetNumber.TabIndex = 2;
            this.AssetNumber.Text = "Asset Number";
            // 
            // txtserialnumberaddeqp
            // 
            this.txtserialnumberaddeqp.Location = new System.Drawing.Point(119, 80);
            this.txtserialnumberaddeqp.Name = "txtserialnumberaddeqp";
            this.txtserialnumberaddeqp.Size = new System.Drawing.Size(197, 20);
            this.txtserialnumberaddeqp.TabIndex = 1;
            // 
            // textassetnumber
            // 
            this.textassetnumber.Location = new System.Drawing.Point(119, 46);
            this.textassetnumber.Name = "textassetnumber";
            this.textassetnumber.Size = new System.Drawing.Size(197, 20);
            this.textassetnumber.TabIndex = 0;
            // 
            // errorEqpProvider1
            // 
            this.errorEqpProvider1.ContainerControl = this;
            // 
            // frmaddequipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 535);
            this.Controls.Add(this.addUserPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmaddequipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmaddequipment";
            this.addUserPanel.ResumeLayout(false);
            this.addUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEqpProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addUserPanel;
        private System.Windows.Forms.Label eqptypedropdown;
        private System.Windows.Forms.ComboBox cmbeqptype;
        private FontAwesome.Sharp.IconButton addusercancelbtn;
        private FontAwesome.Sharp.IconButton addeqpaddbtn;
        private System.Windows.Forms.Label SerialNumber;
        private System.Windows.Forms.Label AssetNumber;
        private System.Windows.Forms.TextBox txtserialnumberaddeqp;
        private System.Windows.Forms.TextBox textassetnumber;
        private System.Windows.Forms.ErrorProvider errorEqpProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DescriptionBoxTxt;
        private System.Windows.Forms.Label yearModel;
        private System.Windows.Forms.TextBox yearmodeltxtbox;
        private System.Windows.Forms.Label Manufacturer;
        private System.Windows.Forms.TextBox manufacturertxtbox;
        private System.Windows.Forms.TextBox departmentbox;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.ComboBox branchcombobox;
        private System.Windows.Forms.Label Branch;
    }
}