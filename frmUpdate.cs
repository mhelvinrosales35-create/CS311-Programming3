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

namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    public partial class frmUpdate : Form
    {
        private string editusername, editpassword, editusertype, editstatus, username;
        private frmaccounts accountListForm;

        private void updateusercancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateusercheckbox_CheckedChanged(object sender, EventArgs e)
        {
            txtpasswordupdateuser.UseSystemPasswordChar = !updateusercheckbox.Checked;
        }

        public frmUpdate(string editusername, string editpassword, string editusertype,
            string editstatus, string username, frmaccounts accountListForm)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.editusername = editusername;
            this.editpassword = editpassword;
            this.editusertype = editusertype;
            this.editstatus = editstatus;
            this.username = username;
            this.accountListForm = accountListForm;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            textboxupdateuser.Text = editusername;
            txtpasswordupdateuser.Text = editpassword;
            if (editusertype == "Administrator")
            {
                cmbupdateusertype.SelectedIndex = 0;
            }
            else if (editusertype == "Technical")
            {
                cmbupdateusertype.SelectedIndex = 1;
            }
            else if (editusertype == "User")
            {
                cmbupdateusertype.SelectedIndex = 2;
            }
            else
            {
                cmbupdateusertype.SelectedIndex = -1;
            }
            if (editstatus == "Active")
            {
                UpdateUserStatus.SelectedIndex = 0;
            }
            else if (editstatus == "Inactive")
            {
                UpdateUserStatus.SelectedIndex = 1;
            }
            else
            {
                UpdateUserStatus.SelectedIndex = -1;
            }
        }

        private void UpdateUserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateuseraddbtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int errorcount = 0;

            // Validation
            if (string.IsNullOrEmpty(textboxupdateuser.Text))
            {
                errorProvider1.SetError(textboxupdateuser, "Username is empty.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(txtpasswordupdateuser.Text))
            {
                errorProvider1.SetError(txtpasswordupdateuser, "Password is empty.");
                errorcount++;
            }

            if (cmbupdateusertype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbupdateusertype, "Select a usertype.");
                errorcount++;
            }

            if (UpdateUserStatus.SelectedIndex < 0)
            {
                errorProvider1.SetError(UpdateUserStatus, "Select a status.");
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
                    string updateQuery = $"UPDATE tblaccounts SET password = '{txtpasswordupdateuser.Text}', " +
                                            $"usertype = '{cmbupdateusertype.Text.ToUpper()}', " +
                                            $"status = '{UpdateUserStatus.Text.ToUpper()}' " +
                                            $"WHERE username = '{textboxupdateuser.Text}'";

                    Class1 updater = new Class1("127.0.0.1", "itc127-batch2-2025", "Melvin", "Rosales"); 
                    updater.executeSQL(updateQuery);

                    if (updater.rowAffected > 0)
                    {
                        string logQuery = $"INSERT INTO tblaccountslogs(datelog, timelog, action, module, performedto, performedby) " +
                                          $"VALUES ('{DateTime.Now:dd/MM/yyyy}', '{DateTime.Now:hh:mm tt}', 'UPDATE ACCOUNT', 'ACCOUNTS MANAGEMENT', '{textboxupdateuser.Text}', '{username}')";
                        updater.executeSQL(logQuery);

                        MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        accountListForm.LoadAccountData();
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void UpdateUserPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
