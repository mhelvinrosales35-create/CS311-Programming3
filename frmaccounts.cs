using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CS311_ETEEAP_Batch2_2025_Rosales
{
    public partial class frmaccounts : Form
    {
        private string username;
        private DataTable originalData;
        Class1 accounts = new Class1("127.0.0.1", "itc127-batch2-2025", "Melvin", "Rosales");

        public frmaccounts(string username)
        {
            InitializeComponent();
            this.username = username;

            // Set placeholder text in searchbox
            searchbox.ForeColor = Color.Gray;
            searchbox.Text = "Search by username, usertype, or status";

            // Attach placeholder events
            searchbox.Enter += searchbox_Enter;
            searchbox.Leave += searchbox_Leave;
            LoadAccountData();
        }

        public void LoadAccountData()
        {
            CustomizeDataGridView();

            string query = "SELECT * FROM tblaccounts";
            originalData = accounts.GetData(query);

            AccntList.Columns.Clear();
            AccntList.Columns.Add("username", "Username");
            AccntList.Columns.Add("password", "Password");
            AccntList.Columns.Add("usertype", "User Type");
            AccntList.Columns.Add("status", "Status");
            AccntList.Columns.Add("createdby", "Created By");
            AccntList.Columns.Add("datecreated", "Date Created");

            PopulateGrid(originalData);
        }

        private void PopulateGrid(DataTable dt)
        {
            AccntList.Rows.Clear();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string password = row["password"].ToString();
                    string usertype = row["usertype"].ToString();
                    string status = row["status"].ToString();
                    string createdby = string.IsNullOrWhiteSpace(row["createdby"].ToString()) ? "—" : row["createdby"].ToString();
                    string datecreated = string.IsNullOrWhiteSpace(row["datecreated"].ToString()) ? "—" : row["datecreated"].ToString();

                    AccntList.Rows.Add(row["username"], password, usertype, status, createdby, datecreated);
                }

                ApplyRowStyling();
            }
            else
            {
                MessageBox.Show("No account data found.");
            }
        }

        private void CustomizeDataGridView()
        {
            AccntList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            AccntList.AllowUserToOrderColumns = true;
            AccntList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AccntList.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            AccntList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            AccntList.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            AccntList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            AccntList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccntList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            AccntList.RowTemplate.Height = 30;
            AccntList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AccntList.ColumnHeadersHeight = 40;
            AccntList.AllowUserToResizeRows = true;
            AccntList.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AccntList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AccntList.BorderStyle = BorderStyle.Fixed3D;

            AccntList.RowHeadersVisible = true;
            AccntList.RowPostPaint += (s, e) =>
            {
                var grid = (DataGridView)s;
                var rowIdx = (e.RowIndex + 1).ToString();
                var center = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString(rowIdx, grid.Font, Brushes.Black, e.RowBounds.Left + 15, e.RowBounds.Top + 10, center);
            };

            AccntList.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    AccntList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            };

            AccntList.CellMouseLeave += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    AccntList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            };
        }

        private void ApplyRowStyling()
        {
            foreach (DataGridViewRow row in AccntList.Rows)
            {
                string status = row.Cells["status"].Value?.ToString() ?? "";
                string username = row.Cells["username"].Value?.ToString() ?? "";
                string usertype = row.Cells["usertype"].Value?.ToString() ?? "";

                if (status == "Active")
                {
                    row.Cells["status"].Style.BackColor = Color.Green;
                    row.Cells["status"].Style.ForeColor = Color.White;
                }
                else if (status == "Inactive")
                {
                    row.Cells["status"].Style.BackColor = Color.Red;
                    row.Cells["status"].Style.ForeColor = Color.White;
                }

                if (username.ToLower() == "admin" || usertype == "Administrator")
                {
                    row.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchbox.Text.Trim().ToLower();

            if (keyword == "search by username, usertype, or status".ToLower())
                return;

            if (originalData == null || originalData.Rows.Count == 0)
                return;

            DataView dv = originalData.DefaultView;
            dv.RowFilter = $"username LIKE '%{keyword}%' OR usertype LIKE '%{keyword}%' OR status LIKE '%{keyword}%'";

            PopulateGrid(dv.ToTable());
        }

        private void searchbox_Enter(object sender, EventArgs e)
        {
            if (searchbox.Text == "Search by username, usertype, or status")
            {
                searchbox.Text = "";
                searchbox.ForeColor = Color.Black;
            }
        }

        private void searchbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchbox.Text))
            {
                searchbox.Text = "Search by username, usertype, or status";
                searchbox.ForeColor = Color.Gray;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            frmAddAccount addaccountform = new frmAddAccount(username, this);
            addaccountform.Show();
        }

        private int row = -1;

        private void AccntList_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (row < 0 || row >= AccntList.Rows.Count)
            {
                MessageBox.Show("Please select a valid account to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedUsername = AccntList.Rows[row].Cells["username"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(selectedUsername))
            {
                MessageBox.Show("Selected account has no username. Cannot proceed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Are you sure you want to delete the account '{selectedUsername}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = $"DELETE FROM tblaccounts WHERE username = '{selectedUsername}'";
                    accounts.executeSQL(deleteQuery);

                    if (accounts.rowAffected > 0)
                    {
                        string logQuery = $"INSERT INTO tblaccountslogs(datelog, timelog, action, module, performedto, performedby) " +
                                          $"VALUES ('{DateTime.Now:dd/MM/yyyy}', '{DateTime.Now:hh:mm tt}', 'DELETE ACCOUNT', 'ACCOUNTS MANAGEMENT', '{selectedUsername}', '{username}')";
                        accounts.executeSQL(logQuery);

                        MessageBox.Show("Account deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccountData();
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

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (row < 0 || row >= AccntList.Rows.Count)
            {
                MessageBox.Show("Please select a valid account to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string editusername = AccntList.Rows[row].Cells["username"].Value?.ToString() ?? "";
                string editpassword = AccntList.Rows[row].Cells["password"].Value?.ToString() ?? "";
                string editusertype = AccntList.Rows[row].Cells["usertype"].Value?.ToString() ?? "";
                string editstatus = AccntList.Rows[row].Cells["status"].Value?.ToString() ?? "";

                frmUpdate updateaccountform = new frmUpdate(editusername, editpassword, editusertype, editstatus, username, this);
                updateaccountform.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error while opening edit form: " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.LoadAccountData();
        }
    }
}