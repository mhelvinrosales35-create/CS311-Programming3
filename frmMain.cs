using FontAwesome.Sharp;
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
    public partial class frmMain : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private string username, usertype;
        private Form currentChildForm;

        public frmMain(string username, string usertype)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.username = username;
            this.usertype = usertype;

            this.Load += frmMain_Load;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UsernameShow.Text = username;
            UsernameType.Text = usertype;
            CenterLabel();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0, 128, 0);     // Green
            public static Color color2 = Color.FromArgb(101, 67, 33);   // Yellow
            public static Color color3 = Color.FromArgb(173, 216, 230); // Light Blue
            public static Color color4 = Color.FromArgb(255, 0, 0);     // Red
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.SkyBlue; // Sky Blue background
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                currentChildformIcon.IconChar = currentBtn.IconChar;
                currentChildformIcon.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.SkyBlue; // Reset background
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleChildForm.Text = childForm.Text;
        }

        private void accntbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmaccounts(username));
        }

        private void eqpmentbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new frmequipments(username));
        }

        private void logsbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new frmlogs(username, usertype));
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                ActivateButton(sender, RGBColors.color3);
                this.Hide();
                frmlogin loginform = new frmlogin();
                loginform.Show();
                this.Dispose();
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentChildformIcon.IconChar = IconChar.House;
            currentChildformIcon.IconColor = Color.MediumPurple;
            TitleChildForm.Text = "Home";
        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CenterLabel()
        {
            int x = (panelMenu.Width - UsernameType.Width) / 2;
            int x2 = (panelMenu.Width - UsernameShow.Width) / 2;
            UsernameShow.Location = new Point(Math.Max(0, x2), UsernameShow.Location.Y);
            UsernameType.Location = new Point(Math.Max(0, x), UsernameType.Location.Y);
        }

        // Empty events
        private void panelDesktop_Paint(object sender, PaintEventArgs e) { }
        private void UsernameShow_Click(object sender, EventArgs e) { }
        private void panelMenu_Paint(object sender, PaintEventArgs e) { }
        private void UsernameType_Click(object sender, EventArgs e) { }
        private void iconPictureBox1_Click(object sender, EventArgs e) { }
        private void panelTitleBar_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void TitleChildForm_Click(object sender, EventArgs e) { }
        private void currentChildformIcon_Click(object sender, EventArgs e) { }
        private void panelShadow_Paint(object sender, PaintEventArgs e) { }
        private void HomeLogo_Click(object sender, EventArgs e) { }
        private void frmMain_Load_1(object sender, EventArgs e) { }
    }
}
