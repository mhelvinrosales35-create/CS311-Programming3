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
    public partial class frmlogs : Form
    {
        private DataTable originalData;
        Class1 logs = new Class1("127.0.0.1", "itc127-batch2-2025", "Melvin", "Rosales");
        private string username, usertype;
        public frmlogs(string username, string usertype)
        {
            InitializeComponent();
            this.username = username;
            this.usertype = usertype;

            this.Load += frmlogs_Load;
        }

        private void frmlogs_Load(object sender, EventArgs e)
        {
            LoadEquipmentLogsData();
            LoadAccountLogsData();
        }
        public void LoadEquipmentLogsData()
        {
            CustomizeEquipmentDataGridView();

            string equipmentquery = "SELECT * FROM tblequipmentslog ORDER BY datelog DESC, timelog DESC";
            originalData = logs.GetData(equipmentquery);

            EqpLogList.Columns.Clear();
            EqpLogList.Columns.Add("datelog", "Date Log");
            EqpLogList.Columns.Add("timelog", "Time Log");
            EqpLogList.Columns.Add("assetnumber", "Asset Number");
            EqpLogList.Columns.Add("performedby", "Performed By");
            EqpLogList.Columns.Add("action", "Action");
            EqpLogList.Columns.Add("module", "Module");

            PopulateGrid(originalData);
        }

        private void PopulateGrid(DataTable dt)
        {
            EqpLogList.Rows.Clear();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string datelog = row["datelog"].ToString();
                    string timelog = row["timelog"].ToString();
                    string assetnumber = row["assetnumber"].ToString();
                    string performedby = row["performedby"].ToString();
                    string action = row["action"].ToString();
                    string module = row["module"].ToString();

                    EqpLogList.Rows.Add(datelog, timelog, assetnumber, performedby, action, module);
                }
            }
            else
            {
                EqpLogList.Rows.Add("—", "—", "No log data found.", "—", "—", "—");

                DataGridViewRow messageRow = EqpLogList.Rows[0];
                messageRow.DefaultCellStyle.ForeColor = Color.DarkGray;
                messageRow.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
                messageRow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public void LoadAccountLogsData()
        {
            CustomizeAccountDataGridView();

            string query = "SELECT * FROM tblaccountslogs ORDER BY datelog DESC, timelog DESC";
            originalData = logs.GetData(query);

            AccntLogsList.Columns.Clear();
            AccntLogsList.Columns.Add("datelog", "Date Log");
            AccntLogsList.Columns.Add("timelog", "Time Log");
            AccntLogsList.Columns.Add("module", "Module");
            AccntLogsList.Columns.Add("action", "Action");
            AccntLogsList.Columns.Add("performedto", "Performed To");
            AccntLogsList.Columns.Add("performedby", "Performed By");

            PopulateAccountGrid(originalData);
        }

        private void PopulateAccountGrid(DataTable dt)
        {
            AccntLogsList.Rows.Clear();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string datelog = row["datelog"].ToString();
                    string timelog = row["timelog"].ToString();
                    string module = row["module"].ToString();
                    string action = row["action"].ToString();
                    string performedto = row["performedto"].ToString();
                    string performedby = row["performedby"].ToString();

                    AccntLogsList.Rows.Add(datelog, timelog, module, action, performedto, performedby);
                }
            }
            else
            {
                AccntLogsList.Rows.Add("—", "—", "No log data found.", "—", "—", "—");

                DataGridViewRow messageRow = AccntLogsList.Rows[0];
                messageRow.DefaultCellStyle.ForeColor = Color.DarkGray;
                messageRow.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Italic);
                messageRow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void CustomizeAccountDataGridView()
        {
            AccntLogsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            AccntLogsList.AllowUserToOrderColumns = true;
            AccntLogsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AccntLogsList.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            AccntLogsList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            AccntLogsList.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            AccntLogsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            AccntLogsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccntLogsList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            AccntLogsList.RowTemplate.Height = 30;
            AccntLogsList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AccntLogsList.ColumnHeadersHeight = 40;
            AccntLogsList.AllowUserToResizeRows = true;
            AccntLogsList.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AccntLogsList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AccntLogsList.BorderStyle = BorderStyle.Fixed3D;

            AccntLogsList.RowHeadersVisible = true;
            AccntLogsList.RowPostPaint += (s, e) =>
            {
                var grid = (DataGridView)s;
                var rowIdx = (e.RowIndex + 1).ToString();
                var center = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString(rowIdx, grid.Font, Brushes.Black, e.RowBounds.Left + 15, e.RowBounds.Top + 10, center);
            };

            AccntLogsList.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    AccntLogsList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            };

            AccntLogsList.CellMouseLeave += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    AccntLogsList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            };
        }

        private void deleteeqplogs_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete all equipment logs?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Class1 db = new Class1("127.0.0.1", "itc127-batch2-2025", "Melvin", "Rosales");
                    db.executeSQL("TRUNCATE TABLE tblequipmentslog");

                    string logQuery = $"INSERT INTO tblaccountslogs(datelog, timelog, module, action, performedto, performedby) VALUES (" +
                                      $"'{DateTime.Now:dd/MM/yyyy}', '{DateTime.Now:hh:mm tt}', 'EQUIPMENT LOGS', 'DELETE ALL LOGS', 'ALL RECORDS', '{username}')";
                    db.executeSQL(logQuery);

                    MessageBox.Show("All equipment logs have been deleted and action logged.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmlogs_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during log deletion: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete all account logs?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Class1 db = new Class1("127.0.0.1", "itc127-batch2-2025", "Melvin", "Rosales");

                    db.executeSQL("TRUNCATE TABLE tblaccountslogs");

                    string logQuery = $"INSERT INTO tblaccountslogs(datelog, timelog, module, action, performedto, performedby) VALUES (" +
                                      $"'{DateTime.Now:dd/MM/yyyy}', '{DateTime.Now:hh:mm tt}', 'ACCOUNT LOGS', 'DELETE ALL LOGS', 'ALL RECORDS', '{username}')";
                    db.executeSQL(logQuery);

                    MessageBox.Show("All account logs deleted. Action has been logged.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmlogs_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during log deletion: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomizeEquipmentDataGridView()
        {
            EqpLogList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            EqpLogList.AllowUserToOrderColumns = true;
            EqpLogList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EqpLogList.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            EqpLogList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            EqpLogList.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            EqpLogList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            EqpLogList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EqpLogList.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            EqpLogList.RowTemplate.Height = 30;
            EqpLogList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EqpLogList.ColumnHeadersHeight = 40;
            EqpLogList.AllowUserToResizeRows = true;
            EqpLogList.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EqpLogList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EqpLogList.BorderStyle = BorderStyle.Fixed3D;

            EqpLogList.RowHeadersVisible = true;
            EqpLogList.RowPostPaint += (s, e) =>
            {
                var grid = (DataGridView)s;
                var rowIdx = (e.RowIndex + 1).ToString();
                var center = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString(rowIdx, grid.Font, Brushes.Black, e.RowBounds.Left + 15, e.RowBounds.Top + 10, center);
            };

            EqpLogList.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    EqpLogList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            };

            EqpLogList.CellMouseLeave += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    EqpLogList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            };
        }
    }
}
