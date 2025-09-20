namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    partial class frmequipments
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Searcheqp = new System.Windows.Forms.Label();
            this.eqpsearchbox = new System.Windows.Forms.TextBox();
            this.RefreshEqpBtn = new FontAwesome.Sharp.IconButton();
            this.editeqpbtn = new FontAwesome.Sharp.IconButton();
            this.deleteeqpbtn = new FontAwesome.Sharp.IconButton();
            this.addeqpbtn = new FontAwesome.Sharp.IconButton();
            this.EqpList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EqpList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.Searcheqp);
            this.panel1.Controls.Add(this.eqpsearchbox);
            this.panel1.Controls.Add(this.RefreshEqpBtn);
            this.panel1.Controls.Add(this.editeqpbtn);
            this.panel1.Controls.Add(this.deleteeqpbtn);
            this.panel1.Controls.Add(this.addeqpbtn);
            this.panel1.Controls.Add(this.EqpList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 845);
            this.panel1.TabIndex = 1;
            // 
            // Searcheqp
            // 
            this.Searcheqp.AutoSize = true;
            this.Searcheqp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searcheqp.ForeColor = System.Drawing.Color.Black;
            this.Searcheqp.Location = new System.Drawing.Point(262, 105);
            this.Searcheqp.Name = "Searcheqp";
            this.Searcheqp.Size = new System.Drawing.Size(64, 23);
            this.Searcheqp.TabIndex = 7;
            this.Searcheqp.Text = "Search:";
            // 
            // eqpsearchbox
            // 
            this.eqpsearchbox.Location = new System.Drawing.Point(343, 109);
            this.eqpsearchbox.Name = "eqpsearchbox";
            this.eqpsearchbox.Size = new System.Drawing.Size(407, 20);
            this.eqpsearchbox.TabIndex = 6;
            // 
            // RefreshEqpBtn
            // 
            this.RefreshEqpBtn.BackColor = System.Drawing.Color.IndianRed;
            this.RefreshEqpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshEqpBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshEqpBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshEqpBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.RefreshEqpBtn.IconColor = System.Drawing.Color.Black;
            this.RefreshEqpBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefreshEqpBtn.IconSize = 32;
            this.RefreshEqpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshEqpBtn.Location = new System.Drawing.Point(21, 390);
            this.RefreshEqpBtn.Name = "RefreshEqpBtn";
            this.RefreshEqpBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.RefreshEqpBtn.Size = new System.Drawing.Size(145, 45);
            this.RefreshEqpBtn.TabIndex = 5;
            this.RefreshEqpBtn.Text = "Refresh";
            this.RefreshEqpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshEqpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshEqpBtn.UseVisualStyleBackColor = false;
            this.RefreshEqpBtn.Click += new System.EventHandler(this.RefreshEqpBtn_Click);
            // 
            // editeqpbtn
            // 
            this.editeqpbtn.BackColor = System.Drawing.Color.Yellow;
            this.editeqpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editeqpbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editeqpbtn.ForeColor = System.Drawing.Color.Black;
            this.editeqpbtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.editeqpbtn.IconColor = System.Drawing.Color.Black;
            this.editeqpbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editeqpbtn.IconSize = 32;
            this.editeqpbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editeqpbtn.Location = new System.Drawing.Point(21, 314);
            this.editeqpbtn.Name = "editeqpbtn";
            this.editeqpbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.editeqpbtn.Size = new System.Drawing.Size(145, 45);
            this.editeqpbtn.TabIndex = 4;
            this.editeqpbtn.Text = "Edit";
            this.editeqpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editeqpbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editeqpbtn.UseVisualStyleBackColor = false;
            this.editeqpbtn.Click += new System.EventHandler(this.editeqpbtn_Click);
            // 
            // deleteeqpbtn
            // 
            this.deleteeqpbtn.BackColor = System.Drawing.Color.Red;
            this.deleteeqpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteeqpbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteeqpbtn.ForeColor = System.Drawing.Color.Black;
            this.deleteeqpbtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.deleteeqpbtn.IconColor = System.Drawing.Color.Black;
            this.deleteeqpbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteeqpbtn.IconSize = 32;
            this.deleteeqpbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteeqpbtn.Location = new System.Drawing.Point(21, 228);
            this.deleteeqpbtn.Name = "deleteeqpbtn";
            this.deleteeqpbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.deleteeqpbtn.Size = new System.Drawing.Size(145, 45);
            this.deleteeqpbtn.TabIndex = 3;
            this.deleteeqpbtn.Text = "Delete";
            this.deleteeqpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteeqpbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteeqpbtn.UseVisualStyleBackColor = false;
            this.deleteeqpbtn.Click += new System.EventHandler(this.deleteeqpbtn_Click);
            // 
            // addeqpbtn
            // 
            this.addeqpbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addeqpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addeqpbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addeqpbtn.ForeColor = System.Drawing.Color.Black;
            this.addeqpbtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addeqpbtn.IconColor = System.Drawing.Color.Black;
            this.addeqpbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addeqpbtn.IconSize = 32;
            this.addeqpbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addeqpbtn.Location = new System.Drawing.Point(21, 148);
            this.addeqpbtn.Name = "addeqpbtn";
            this.addeqpbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.addeqpbtn.Size = new System.Drawing.Size(145, 45);
            this.addeqpbtn.TabIndex = 1;
            this.addeqpbtn.Text = "Add";
            this.addeqpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addeqpbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addeqpbtn.UseVisualStyleBackColor = false;
            this.addeqpbtn.Click += new System.EventHandler(this.addeqpbtn_Click);
            // 
            // EqpList
            // 
            this.EqpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EqpList.Location = new System.Drawing.Point(184, 148);
            this.EqpList.Name = "EqpList";
            this.EqpList.Size = new System.Drawing.Size(710, 287);
            this.EqpList.TabIndex = 0;
            this.EqpList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EqpList_CellContentClick);
            // 
            // frmequipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 845);
            this.Controls.Add(this.panel1);
            this.Name = "frmequipments";
            this.Text = "Equipments List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EqpList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Searcheqp;
        private System.Windows.Forms.TextBox eqpsearchbox;
        private FontAwesome.Sharp.IconButton RefreshEqpBtn;
        private FontAwesome.Sharp.IconButton editeqpbtn;
        private FontAwesome.Sharp.IconButton deleteeqpbtn;
        private FontAwesome.Sharp.IconButton addeqpbtn;
        private System.Windows.Forms.DataGridView EqpList;
    }
}