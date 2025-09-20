using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    public partial class frmaddequipment : Form
    {
        private string username;
        private frmequipments EquipmentListForm;
        public frmaddequipment(string username, frmequipments EquipmentListForm)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.username = username;
            this.EquipmentListForm = EquipmentListForm;
        }
        private int errorcount;
        Class1 newequipment = new Class1("127.0.0.1", "itc127-batch2-2025", "Melvin", "Rosales");
        private void addeqpaddbtn_Click(object sender, EventArgs e)
        {
            errorEqpProvider1.Clear();
            errorcount = 0;

            if (string.IsNullOrEmpty(textassetnumber.Text))
            {
                errorEqpProvider1.SetError(textassetnumber, "Asset Number is empty.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(txtserialnumberaddeqp.Text))
            {
                errorEqpProvider1.SetError(txtserialnumberaddeqp, "Serial Number is empty.");
                errorcount++;
            }


            if (cmbeqptype.SelectedIndex < 0)
            {
                errorEqpProvider1.SetError(cmbeqptype, "Select a usertype.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(manufacturertxtbox.Text))
            {
                errorEqpProvider1.SetError(manufacturertxtbox, "Manufacturer is empty.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(yearmodeltxtbox.Text))
            {
                errorEqpProvider1.SetError(yearmodeltxtbox, "Year Model is empty.");
                errorcount++;
            }

            if (branchcombobox.SelectedIndex < 0)
            {
                errorEqpProvider1.SetError(branchcombobox, "Select a Type.");
                errorcount++;
            }

            if (string.IsNullOrEmpty(departmentbox.Text))
            {
                errorEqpProvider1.SetError(departmentbox, "Department is empty.");
                errorcount++;
            }

            try
            {
                DataTable dt = newequipment.GetData("SELECT * FROM tblequipments WHERE assetnumber = '" + textassetnumber.Text + "' OR serialnumber = '" + txtserialnumberaddeqp.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    errorEqpProvider1.SetError(textassetnumber, "Asset Number or Serial Number is already in use.");
                    errorcount++;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error on validating AssetNumber or Serial Number: " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (errorcount == 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to add this equipment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    newequipment.executeSQL("INSERT INTO tblequipments (assetnumber, serialnumber, type, manufacturer, yearmodel, description, branch, department, createdby, datecreated) VALUES ('" +
                        textassetnumber.Text + "', '" + txtserialnumberaddeqp.Text + "', '" +
                        cmbeqptype.Text + "', '" + manufacturertxtbox.Text + "', '" + 
                        yearmodeltxtbox.Text + "', '" + DescriptionBoxTxt.Text + "', '" + 
                        branchcombobox.Text + "', '" + departmentbox.Text + "', '" +
                        username + "', '" + DateTime.Now.ToString("dd/MM/yyyy") + "')");

                    if (newequipment.rowAffected > 0)
                    {
                        MessageBox.Show("New Equipment added.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EquipmentListForm.LoadEquipmentData();
                        this.Close();
                    }
                }
            }
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

        private void addusercancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
