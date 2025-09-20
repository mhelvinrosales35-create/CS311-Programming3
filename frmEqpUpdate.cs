using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    public partial class frmEqpUpdate : Form
    {
        private string editassetnumber, editserialnumber, edittype, editmanufacturer, edityearmodel, editdescription, editbranch, editdepartment, editstatus, username;

        private frmequipments FormEqpList;
        public frmEqpUpdate(string editassetnumber, string editserialnumber, string edittype, string editmanufacturer, 
            string edityearmodel, string editdescription, string editbranch, string editdepartment, string editstatus, string username, frmequipments FormEqpList)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.editassetnumber = editassetnumber;
            this.editserialnumber = editserialnumber;
            this.edittype = edittype;
            this.editmanufacturer = editmanufacturer;
            this.edityearmodel = edityearmodel;
            this.editdescription = editdescription;
            this.editbranch = editbranch;
            this.editdepartment = editdepartment;
            this.editstatus = editstatus;
            this.username = username;
            this.FormEqpList = FormEqpList;
        }

        private void frmEqpUpdate_Load(object sender, EventArgs e)
        {
            textassetnumberupdate.Text = editassetnumber;
            textassetnumberupdate.ReadOnly = true;
            txtserialnumberupdateeqp.Text = editserialnumber;
            if (edittype == "Monitor")
            {
                cmbupdateeqptype.SelectedIndex = 0;
            }
            else if (edittype == "CPU")
            {
                cmbupdateeqptype.SelectedIndex = 1;
            }
            else if (edittype == "Keyboard")
            {
                cmbupdateeqptype.SelectedIndex = 2;
            }
            else if (edittype == "Mouse")
            {
                cmbupdateeqptype.SelectedIndex = 3;
            }
            else if (edittype == "AVR")
            {
                cmbupdateeqptype.SelectedIndex = 4;
            }
            else if (edittype == "MAC")
            {
                cmbupdateeqptype.SelectedIndex = 5;
            }
            else if (edittype == "Printer")
            {
                cmbupdateeqptype.SelectedIndex = 6;
            }
            else if (edittype == "Projector")
            {
                cmbupdateeqptype.SelectedIndex = 7;
            }
            else
            {
                cmbupdateeqptype.SelectedIndex = -1;
            }

            manufacturertxtboxupdate.Text = editmanufacturer;
            yearmodeltxtboxUpdate.Text = edityearmodel;
            DescriptionBoxTxtUpdate.Text = editdescription;

            if (editbranch == "AU Main Campus")
            {
                branchcomboboxupdate.SelectedIndex = 0;
            }
            else if (editbranch == "AU Pasay")
            {
                branchcomboboxupdate.SelectedIndex = 1;
            }
            else if (editbranch == "AU Mandaluyong")
            {
                branchcomboboxupdate.SelectedIndex = 2;
            }
            else if (editbranch == "AU Malabon")
            {
                branchcomboboxupdate.SelectedIndex = 3;
            }
            else if (editbranch == "AU Pasig")
            {
                branchcomboboxupdate.SelectedIndex = 4;
            }
            else
            {
                branchcomboboxupdate.SelectedIndex = -1;
            }

            departmentboxUpdate.Text = editdepartment;

            if(editstatus == "Working")
            {
                StatusUpdate.SelectedIndex = 0;
            }
            else if(editstatus == "On-Repair")
            {
                StatusUpdate.SelectedIndex = 1;
            }
            else if(editstatus == "Retired")
            {
                StatusUpdate.SelectedIndex = 2;
            }
            else
            {
                StatusUpdate.SelectedIndex = -1;
            }
        }

        private void updateuseraddbtn_Click(object sender, EventArgs e)
        {
            errorEqpProvider1.Clear();
            int errorcount = 0;

            if (string.IsNullOrEmpty(textassetnumberupdate.Text))
            {
                errorEqpProvider1.SetError(textassetnumberupdate, "Asset Number is empty.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(txtserialnumberupdateeqp.Text))
            {
                errorEqpProvider1.SetError(txtserialnumberupdateeqp, "Serial Number is empty.");
                errorcount++;
            }

            if (cmbupdateeqptype.SelectedIndex < 0)
            {
                errorEqpProvider1.SetError(cmbupdateeqptype, "Select a Type.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(manufacturertxtboxupdate.Text))
            {
                errorEqpProvider1.SetError(manufacturertxtboxupdate, "Manufacturer is empty.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(yearmodeltxtboxUpdate.Text))
            {
                errorEqpProvider1.SetError(yearmodeltxtboxUpdate, "Year Model is empty.");
                errorcount++;
            }

            if (branchcomboboxupdate.SelectedIndex < 0)
            {
                errorEqpProvider1.SetError(branchcomboboxupdate, "Select a Branch.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(departmentboxUpdate.Text))
            {
                errorEqpProvider1.SetError(departmentboxUpdate, "Department is empty.");
                errorcount++;
            }

            if (StatusUpdate.SelectedIndex < 0)
            {
                errorEqpProvider1.SetError(StatusUpdate, "Select a status of the equipment.");
                errorcount++;
            }

            if (errorcount > 0)
            {
                MessageBox.Show("Please correct the highlighted errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to save the changes?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string updateQuery = $"UPDATE tblequipments SET serialnumber = '{txtserialnumberupdateeqp.Text}', " +
                                            $"type = '{cmbupdateeqptype.Text}', " +
                                            $"manufacturer = '{manufacturertxtboxupdate.Text}', " +
                                            $"yearmodel = '{yearmodeltxtboxUpdate.Text}', " +
                                            $"branch = '{branchcomboboxupdate.Text}', " +
                                            $"department = '{departmentboxUpdate.Text}', " +
                                            $"status = '{StatusUpdate.Text}' " +
                                            $"WHERE assetnumber = '{textassetnumberupdate.Text}'";

                    Class1 updater = new Class1("127.0.0.1", "itc127-batch2-2025", "Melvin", "Rosales");
                    updater.executeSQL(updateQuery);

                    if (updater.rowAffected > 0)
                    {
                        string logQuery = $"INSERT INTO tblequipmentslog (datelog, timelog, assetnumber, performedby, action, module) " +
                                          $"VALUES ('{DateTime.Now:dd/MM/yyyy}', '{DateTime.Now:hh:mm tt}', '{textassetnumberupdate.Text}', '{username}', 'UPDATE EQUIPMENT', 'EQUIPMENT MANAGEMENT')";
                        updater.executeSQL(logQuery);

                        MessageBox.Show("Equipment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormEqpList.LoadEquipmentData();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error during update: " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void updateusercancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void addUserPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
