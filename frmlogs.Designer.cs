namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    partial class frmlogs
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
            this.AccntLogsList = new System.Windows.Forms.DataGridView();
            this.deletebtn = new FontAwesome.Sharp.IconButton();
            this.deleteeqplogs = new FontAwesome.Sharp.IconButton();
            this.EqpLogList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccntLogsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EqpLogList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.AccntLogsList);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.deleteeqplogs);
            this.panel1.Controls.Add(this.EqpLogList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 663);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AccntLogsList
            // 
            this.AccntLogsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccntLogsList.Location = new System.Drawing.Point(169, 274);
            this.AccntLogsList.Name = "AccntLogsList";
            this.AccntLogsList.Size = new System.Drawing.Size(636, 256);
            this.AccntLogsList.TabIndex = 4;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Red;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.Black;
            this.deletebtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deletebtn.IconColor = System.Drawing.Color.Black;
            this.deletebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deletebtn.IconSize = 32;
            this.deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.Location = new System.Drawing.Point(811, 367);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.deletebtn.Size = new System.Drawing.Size(189, 59);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete Account Logs";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // deleteeqplogs
            // 
            this.deleteeqplogs.BackColor = System.Drawing.Color.Red;
            this.deleteeqplogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteeqplogs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteeqplogs.ForeColor = System.Drawing.Color.Black;
            this.deleteeqplogs.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteeqplogs.IconColor = System.Drawing.Color.Black;
            this.deleteeqplogs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteeqplogs.IconSize = 32;
            this.deleteeqplogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteeqplogs.Location = new System.Drawing.Point(811, 88);
            this.deleteeqplogs.Name = "deleteeqplogs";
            this.deleteeqplogs.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.deleteeqplogs.Size = new System.Drawing.Size(189, 53);
            this.deleteeqplogs.TabIndex = 1;
            this.deleteeqplogs.Text = "Delete Equipment Logs";
            this.deleteeqplogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteeqplogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteeqplogs.UseVisualStyleBackColor = false;
            this.deleteeqplogs.Click += new System.EventHandler(this.deleteeqplogs_Click);
            // 
            // EqpLogList
            // 
            this.EqpLogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EqpLogList.Location = new System.Drawing.Point(169, 12);
            this.EqpLogList.Name = "EqpLogList";
            this.EqpLogList.Size = new System.Drawing.Size(636, 256);
            this.EqpLogList.TabIndex = 0;
            // 
            // frmlogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 663);
            this.Controls.Add(this.panel1);
            this.Name = "frmlogs";
            this.Text = "Logs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccntLogsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EqpLogList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton deletebtn;
        private FontAwesome.Sharp.IconButton deleteeqplogs;
        private System.Windows.Forms.DataGridView EqpLogList;
        private System.Windows.Forms.DataGridView AccntLogsList;
    }
}