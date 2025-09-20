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
    public partial class frmlogin : Form
    {
        //Fields
        private int borderSize = 2;
        public frmlogin()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(128, 128, 128);//Border color
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        Class1 login = new Class1("127.0.0.1", "itc127-batch2-2025", "Melvin", "Rosales");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = login.GetData("SELECT * FROM tblaccounts WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "' AND status = 'ACTIVE'");
                if (dt.Rows.Count > 0)
                {
                    frmMain mainform = new frmMain(txtusername.Text, dt.Rows[0].Field<string>("usertype"));
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect account details or account is disabled.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error on btnlogin_click:" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Overriden method
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lgnminizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lgnclosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void closetip_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
