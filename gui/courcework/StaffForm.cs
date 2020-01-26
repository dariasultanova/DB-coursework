using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace courcework
{
    public partial class StaffForm : Form
    {
        string nickname;
        public StaffForm(string nick)
        {
            InitializeComponent();
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }
            nickname = nick;
            Modifier mod = new Modifier();
            mod.MakeNiceTabControl(tc);
            mod.MakeNiceTabPage(tp_1);
            mod.MakeNiceTabPage(tp_2);
            mod.MakeNiceTabPage(tp_3);
            mod.MakeNiceComboBox(cb_type);
            mod.MakeNiceDataGridView(dgv_schedule);
            mod.MakeNiceDataGridView(dgv_clients);

            OleDbDataAdapter da = new OleDbDataAdapter("EXEC ClientsInfo '"+nickname+"'", cn);
            da.Fill(ds_clients, "MyClients");
            dgv_clients.DataSource = ds_clients.Tables["MyClients"];
            dgv_clients.Columns[0].Width = 180;
            dgv_clients.Columns[1].Width = 110;
            dgv_clients.Columns[2].Width = 40;
            dgv_clients.Columns[3].Width = 90;
            dgv_clients.Columns[4].Width = 60;
            dgv_clients.Columns[5].Width = 60;
            dgv_clients.Columns[4].HeaderText = "From";
            dgv_clients.Columns[5].HeaderText = "To";
            dgv_clients.Columns[3].HeaderText = "Date";
            dgv_clients.Columns[2].HeaderText = "№";
        }

        private void b_graphic_Click(object sender, EventArgs e)
        {
            DataTable DT = (DataTable)dgv_schedule.DataSource;
            if (DT != null) DT.Clear();
            if (dtp_PeriodFrom.Value > dtp_PeriodTo.Value)
            {
                MessageBox.Show("Date from must be earlier than date to", "Error", MessageBoxButtons.OK);
                return;
            }
            string period_from = dtp_PeriodFrom.Value.ToString("yyyy-MM-dd");
            string period_to = dtp_PeriodTo.Value.ToString("yyyy-MM-dd");
            OleDbDataAdapter da = new OleDbDataAdapter("EXEC WhenWork '" + nickname + "', '" + period_from + "', '" + period_to + "'", cn);
            da.Fill(ds_sch, "Schedule");
            dgv_schedule.DataSource = ds_sch.Tables["Schedule"];
            dgv_schedule.Columns[1].HeaderText = "From";
            dgv_schedule.Columns[2].HeaderText = "To";
            dgv_schedule.Columns[3].HeaderText = "№";
            DataGridViewCellStyle TimeStyle = new DataGridViewCellStyle();
            TimeStyle.Format = "t";
            dgv_schedule.Columns[1].DefaultCellStyle = TimeStyle;
            dgv_schedule.Columns[2].DefaultCellStyle = TimeStyle;
            dgv_schedule.Columns[0].Width = 90;
            dgv_schedule.Columns[1].Width = 60;
            dgv_schedule.Columns[2].Width = 60;
            dgv_schedule.Columns[3].Width = 40;
            dgv_schedule.Columns[4].Width = 180;
        }

        private void b_report_Click(object sender, EventArgs e)
        {
            string num = tb_num.Text.ToString();
            string type="";
            try
            {
                if (cb_type.SelectedItem.ToString() == "Hall") type = "0";
                if (cb_type.SelectedItem.ToString() == "Instrument") type = "1";
                if (cb_type.SelectedItem.ToString() == "Equipment") type = "2";

            }
            catch
            {
                MessageBox.Show("Object type is not selected", "Error", MessageBoxButtons.OK);
                return;
            }
            if (num=="")
            {
                MessageBox.Show("Object number is not entered", "Error", MessageBoxButtons.OK);
                return;
            }
            OleDbCommand command = new OleDbCommand("EXEC ObjectBreak " + num+", "+type, cn);
            int rows = command.ExecuteNonQuery();
            if (rows <= 0)
            {
                MessageBox.Show("Something went wrong while reporting\n Maybe such number of object is not exist", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Report was sended", "Info", MessageBoxButtons.OK);
            }
        }
    }
}
