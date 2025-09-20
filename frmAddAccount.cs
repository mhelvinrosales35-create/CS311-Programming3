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
    public partial class frmAddAccount : Form
    {
        private string username;
        private frmaccounts accountListForm;

        public frmAddAccount(string username, frmaccounts accountListForm)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.username = username;
            this.accountListForm = accountListForm;
        }

        private int errorcount;
        Class1 newaccount = new Class1("127.0.0.1", "itc127-batch2-2025", "Melvin", "Rosales");

        private void adduseraddbtn_Click(object sender, EventArgs e)
        {
            // Validations
            errorProvider1.Clear();
            errorcount = 0;

            if (string.IsNullOrEmpty(textboxadduser.Text))
            {
                errorProvider1.SetError(textboxadduser, "Username is empty.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(txtpasswordadduser.Text))
            {
                errorProvider1.SetError(txtpasswordadduser, "Password is empty.");
                errorcount++;
            }

            if (cmbusertype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbusertype, "Select a usertype.");
                errorcount++;
            }

            try
            {
                DataTable dt = newaccount.GetData("SELECT * FROM tblaccounts WHERE username = '" + textboxadduser.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(textboxadduser, "Username is already in use.");
                    errorcount++;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error on validating username: " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (errorcount == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to add this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    newaccount.executeSQL("INSERT INTO tblaccounts (username, password, usertype, status, createdby, datecreated) VALUES ('" +
                        textboxadduser.Text + "', '" + txtpasswordadduser.Text + "', '" +
                        cmbusertype.Text + "', 'ACTIVE', '" + username + "', '" +
                        DateTime.Now.ToString("dd/MM/yyyy") + "')");

                    if (newaccount.rowAffected > 0)
                    {
                        MessageBox.Show("New account added.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        accountListForm.LoadAccountData();
                        this.Close();
                    }
                }
            }
        }

        private void addusercheckbox_CheckedChanged(object sender, EventArgs e)
        {
            txtpasswordadduser.UseSystemPasswordChar = !addusercheckbox.Checked;
        }

        private void addusercancelbtn_Click(object sender, EventArgs e)
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
