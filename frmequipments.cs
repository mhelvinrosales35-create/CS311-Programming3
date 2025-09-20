using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    public partial class frmequipments : Form
    {
        private string username;
        private DataTable originalData;
        Class1 equipments = new Class1("127.0.0.1", "itc127-batch2-2025", "Melvin", "Rosales");
        public frmequipments(string username)
        {
            InitializeComponent();
            this.eqpsearchbox.TextChanged += new System.EventHandler(this.eqpsearchbox_TextChanged);
            this.username = username;

            eqpsearchbox.ForeColor = Color.Gray;
            eqpsearchbox.Text = "Search by AssetNumber, SerialNumber, Type, Manufacturer, YearModel, Branch, or Department";

            eqpsearchbox.Enter += eqpsearchbox_Enter;
            eqpsearchbox.Leave += eqpsearchbox_Leave;

            LoadEquipmentData();
        }

        public void LoadEquipmentData()
        {
            CustomizeDataGridView();

            string query = "SELECT * FROM tblequipments";
            originalData = equipments.GetData(query);

            EqpList.Columns.Clear();
            EqpList.Columns.Add("assetnumber", "Asset Number");
            EqpList.Columns.Add("serialnumber", "Serial Number");
            EqpList.Columns.Add("type", "Type");
            EqpList.Columns.Add("manufacturer", "Manufacturer");
            EqpList.Columns.Add("yearmodel", "Year Model");
            EqpList.Columns.Add("description", "Descriptions");
            EqpList.Columns.Add("branch", "Branch");
            EqpList.Columns.Add("department", "Department");
            EqpList.Columns.Add("status", "Status");
            EqpList.Columns.Add("createdby", "Created By");
            EqpList.Columns.Add("datecreated", "Date Created");

            PopulateGrid(originalData);
        }

        private void PopulateGrid(DataTable dt)
        {
            EqpList.Rows.Clear();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string assetnumber = row["assetnumber"].ToString();
                    string serialnumber = row["serialnumber"].ToString();
                    string type = row["type"].ToString();
                    string manufacturer = row["manufacturer"].ToString();
                    string yearmodel = row["yearmodel"].ToString();
                    string description = row["description"].ToString();
                    string branch = row["branch"].ToString();
                    string department = row["department"].ToString();
                    string status = row["status"].ToString();
                    string createdby = string.IsNullOrWhiteSpace(row["createdby"].ToString()) ? "—" : row["createdby"].ToString();
                    string datecreated = string.IsNullOrWhiteSpace(row["datecreated"].ToString()) ? "—" : row["datecreated"].ToString();

                    EqpList.Rows.Add(assetnumber, serialnumber, type, manufacturer, yearmodel, description, branch, department, status, createdby, datecreated);
                }
            }
            else
            {
                MessageBox.Show("No equipment data found.");
            }
        }

        private void CustomizeDataGridView()
        {
            EqpList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            EqpList.AllowUserToOrderColumns = true;
            EqpList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EqpList.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            EqpList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            EqpList.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            EqpList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            EqpList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EqpList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            EqpList.RowTemplate.Height = 30;
            EqpList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EqpList.ColumnHeadersHeight = 40;
            EqpList.AllowUserToResizeRows = true;
            EqpList.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EqpList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EqpList.BorderStyle = BorderStyle.Fixed3D;

            EqpList.RowHeadersVisible = true;
            EqpList.RowPostPaint += (s, e) =>
            {
                var grid = (DataGridView)s;
                var rowIdx = (e.RowIndex + 1).ToString();
                var center = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString(rowIdx, grid.Font, Brushes.Black, e.RowBounds.Left + 15, e.RowBounds.Top + 10, center);
            };

            EqpList.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    EqpList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            };

            EqpList.CellMouseLeave += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    EqpList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            };
        }

        private void eqpsearchbox_TextChanged(object sender, EventArgs e)
        {
            string keyword = eqpsearchbox.Text.Trim().Replace("'", "''");

            if (string.IsNullOrWhiteSpace(keyword) || keyword == "Search by AssetNumber, SerialNumber, Type, Manufacturer, YearModel, Branch, or Department")
                return;

            if (originalData == null || originalData.Rows.Count == 0)
                return;

            string filter = $"assetnumber LIKE '%{keyword}%' OR " +
                            $"serialnumber LIKE '%{keyword}%' OR " +
                            $"type LIKE '%{keyword}%' OR " +
                            $"manufacturer LIKE '%{keyword}%' OR " +
                            $"yearmodel LIKE '%{keyword}%' OR " +
                            $"branch LIKE '%{keyword}%' OR " +
                            $"department LIKE '%{keyword}%'";

            try
            {
                DataView dv = originalData.DefaultView;
                dv.RowFilter = filter;
                PopulateGrid(dv.ToTable());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eqpsearchbox_Enter(object sender, EventArgs e)
        {
            if (eqpsearchbox.Text == "Search by AssetNumber, SerialNumber, Type, Manufacturer, YearModel, Branch, or Department")
            {
                eqpsearchbox.Text = "";
                eqpsearchbox.ForeColor = Color.Black;
            }
        }

        private void eqpsearchbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(eqpsearchbox.Text))
            {
                eqpsearchbox.Text = "Search by AssetNumber, SerialNumber, Type, Manufacturer, YearModel, Branch, or Department";
                eqpsearchbox.ForeColor = Color.Gray;
            }
        }

        private void addeqpbtn_Click(object sender, EventArgs e)
        {
            frmaddequipment addeqpform = new frmaddequipment(username, this);
            addeqpform.Show();
        }

        private int row = -1;
        private void EqpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    row = e.RowIndex;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error on Account List click: " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteeqpbtn_Click(object sender, EventArgs e)
        {
            if (row < 0 || row >= EqpList.Rows.Count)
            {
                MessageBox.Show("Please select a valid equipment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedEquipment = EqpList.Rows[row].Cells["assetnumber"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(selectedEquipment))
            {
                MessageBox.Show("Selected equipment has no assetnumber. Cannot proceed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Are you sure you want to delete the equipment? '{selectedEquipment}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = $"DELETE FROM tblequipments WHERE assetnumber = '{selectedEquipment}'";
                    equipments.executeSQL(deleteQuery);

                    if (equipments.rowAffected > 0)
                    {
                        string logQuery = $"INSERT INTO tblequipmentslog (datelog, timelog, assetnumber, performedby, action, module) " +
                                          $"VALUES ('{DateTime.Now:dd/MM/yyyy}', '{DateTime.Now:hh:mm tt}', '{selectedEquipment}', '{username}', 'DELETE EQUIPMENT', 'EQUIPMENT MANAGEMENT')";
                        equipments.executeSQL(logQuery);

                        MessageBox.Show("Equipment deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEquipmentData();
                        row = -1;
                    }
                    else
                    {
                        MessageBox.Show("No account was deleted. It may have already been removed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error during deletion: " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editeqpbtn_Click(object sender, EventArgs e)
        {
            if (row < 0 || row >= EqpList.Rows.Count)
            {
                MessageBox.Show("Please select a valid equipment to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string editassetnumber = EqpList.Rows[row].Cells["assetnumber"].Value?.ToString() ?? "";
                string editserialnumber = EqpList.Rows[row].Cells["serialnumber"].Value?.ToString() ?? "";
                string edittype = EqpList.Rows[row].Cells["type"].Value?.ToString() ?? "";
                string editmanufacturer = EqpList.Rows[row].Cells["manufacturer"].Value?.ToString() ?? "";
                string edityearmodel = EqpList.Rows[row].Cells["yearmodel"].Value?.ToString() ?? "";
                string editdescription = EqpList.Rows[row].Cells["description"].Value?.ToString() ?? "";
                string editbranch = EqpList.Rows[row].Cells["branch"].Value?.ToString() ?? "";
                string editdepartment = EqpList.Rows[row].Cells["department"].Value?.ToString() ?? "";
                string editstatus = EqpList.Rows[row].Cells["status"].Value?.ToString() ?? "";

                frmEqpUpdate updateEquipform = new frmEqpUpdate(editassetnumber, editserialnumber, edittype, editmanufacturer, edityearmodel, editdescription, editbranch, editdepartment, editstatus, username, this);
                updateEquipform.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error while opening edit form: " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshEqpBtn_Click(object sender, EventArgs e)
        {
            this.LoadEquipmentData();
        }
    }
}
