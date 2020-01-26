using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace courcework
{
    public partial class ClientForm : Form
    {
        string nickname;
        string selected_type;
        public ClientForm(string nick)
        {
            InitializeComponent();
            nickname = nick;
            OleDbDataAdapter da = new OleDbDataAdapter("EXEC Pricelist", cn);
            da.Fill(ds, "Pricelist");
            dgv_pricelist.DataSource = ds.Tables["Pricelist"];
           // pricelist.
            
            Modifier mod = new Modifier();
            mod.MakeNiceTabPage(tp1);
            mod.MakeNiceTabPage(tp2);
            mod.MakeNiceTabControl(tc_user);
            mod.MakeNiceDataGridView(dgv_pricelist);
            mod.MakeNiceDataGridView(dgv_userinfo);
            mod.MakeNiceComboBox(cb_Halls);
            dgv_pricelist.Columns[0].Width = 160;
            dgv_pricelist.Columns[1].Width = 40;
            b_NewContent.Visible = false;
            cn.Open();
            OleDbCommand command = new OleDbCommand("SELECT Title FROM HallsCost", cn);
            OleDbDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                cb_Halls.Items.Add(rdr["Title"]);

            }
            rdr.Close();
            command.CommandText = "SELECT Title FROM InstrumentsCost";
            rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                lb_InstrumentsList.Items.Add(rdr["Title"]);

            }
            rdr.Close();
            command.CommandText = "SELECT Title FROM EquipmentCost";
            rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                lb_EquipmentList.Items.Add(rdr["Title"]);

            }
            rdr.Close();
            command.CommandText = "SELECT Post FROM Jobs";
            rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                lb_StaffList.Items.Add(rdr["Post"]);

            }
            rdr.Close();
            command.CommandText = "EXEC ShowDeals '"+nickname+"'";
            rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                string dd = rdr["DateOfDeal"].ToString();
                dd = dd.Substring(0, dd.Length - 8);
                string tb = rdr["TimeOfBegin"].ToString();
                tb = tb.Substring(0, tb.Length-11);
                string te = rdr["TimeOfEnd"].ToString();
                te = te.Substring(0, te.Length - 11);
                lb_deals.Items.Add(rdr["Number"]+" "+dd+" "+tb+"-"+te);
                

            }
            rdr.Close();
        }

        private void lb_InstrumentsList_DoubleClick(object sender, EventArgs e)
        {
            tb_SelectedItem.Text = lb_InstrumentsList.SelectedItem.ToString();
            selected_type = "1";
        }

        private void lb_EquipmentList_DoubleClick(object sender, EventArgs e)
        {
            tb_SelectedItem.Text = lb_EquipmentList.SelectedItem.ToString();
            selected_type = "2";
        }

        private void lb_StaffList_DoubleClick(object sender, EventArgs e)
        {
            tb_SelectedItem.Text = lb_StaffList.SelectedItem.ToString();
            selected_type = "3";
        }

        private void b_newDeal_Click(object sender, EventArgs e)
        {
            string date_of_deal = dtp_DealDate.Value.ToString("yyyy-MM-dd");
            string time_from = tb_TimeFrom.Text.ToString();
            string time_to = tb_TimeTo.Text.ToString();
            try
            {
                DateTime dt1 = DateTime.Parse(time_from);
                time_from = dt1.ToString("HH:mm");
                DateTime dt2 = DateTime.Parse(time_to);
                time_to = dt2.ToString("HH:mm");
                if(dt1>=dt2)
                {
                    MessageBox.Show("Time of begining must be less than time of end", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception) { MessageBox.Show("Wrong format of time", "Error", MessageBoxButtons.OK); return; }

            OleDbCommand command = new OleDbCommand("AddDeal '"+nickname+"', '"+date_of_deal+"', '"+time_from + "', '" +time_to+"'", cn);
            int rows = command.ExecuteNonQuery();
            if (rows<=0)
            {
                MessageBox.Show("Something went wrong 0", "Error", MessageBoxButtons.OK);
                return;
            }
            command.CommandText = "SELECT  max(Number) FROM Contracts";
            OleDbDataReader rdr = command.ExecuteReader();
            string number = "";
            try
            {
                rdr.Read();
                number = rdr.GetInt32(0).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong 1", "Error", MessageBoxButtons.OK);
                return;
            }
            rdr.Close();
            command.CommandText = "AddContent "+number+", 0, '"+cb_Halls.SelectedItem.ToString()+"'";
            rows = command.ExecuteNonQuery();
            if (rows <= 0)
            {
                MessageBox.Show("This hall is already booked, \nplease select another hall", "Error", MessageBoxButtons.OK);
                //command.CommandText = "DeleteDeal '" + "', '" + date_of_deal + "', '" + time_from +  "'";
                //command.ExecuteNonQuery();
                return;
            }
            else
            {
                MessageBox.Show("Deal is successfully created", "Info", MessageBoxButtons.OK);
                b_NewContent.Visible = true;
            }
        }

        private void b_NewContent_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("SELECT  max(Number) FROM Contracts", cn);
            OleDbDataReader rdr = command.ExecuteReader();
            string number = "";
            try
            {
                rdr.Read();
                number = rdr.GetInt32(0).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong with getting num of deal", "Error", MessageBoxButtons.OK);
                return;
            }
            rdr.Close();
            command.CommandText = "AddContent " + number + ", "+selected_type+", '" + tb_SelectedItem.Text.ToString() + "'";
            int rows = command.ExecuteNonQuery();
            if (rows <= 0)
            {
                MessageBox.Show("All this items is already employed :(", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Content is successfully created", "Info", MessageBoxButtons.OK);
            }
        }

        private void b_SeeContents_Click(object sender, EventArgs e)
        {
            DataTable DT = (DataTable)dgv_userinfo.DataSource;
            if (DT != null) DT.Clear();
            if (dtp_PeriodFrom.Value>dtp_PeriodTo.Value)
            {
                MessageBox.Show("Date from must be earlier than date to", "Error", MessageBoxButtons.OK);
                return;
            }
            
            string period_from = dtp_PeriodFrom.Value.ToString("yyyy-MM-dd");
            string period_to = dtp_PeriodTo.Value.ToString("yyyy-MM-dd");
            OleDbDataAdapter da = new OleDbDataAdapter("EXEC DealsPerTime '"+nickname+"', '"+period_from + "', '" +period_to+"'", cn);
            da.Fill(ds_info, "ContentsPetTime");
            dgv_userinfo.DataSource = ds_info.Tables["ContentsPetTime"];
            dgv_userinfo.Columns[1].HeaderText = "From";
            dgv_userinfo.Columns[2].HeaderText = "To";
            dgv_userinfo.Columns[1].DefaultCellStyle.Format = "HH:mm";
            dgv_userinfo.Columns[2].DefaultCellStyle.Format = "HH:mm";
            dgv_userinfo.Columns[0].Width = 90;
            dgv_userinfo.Columns[1].Width = 60;
            dgv_userinfo.Columns[2].Width = 60;
            dgv_userinfo.Columns[3].Width = 160;
            dgv_userinfo.Columns[4].Width = 40;
        }

        private void b_SeeContracts_Click(object sender, EventArgs e)
        {
            DataTable DT = (DataTable)dgv_userinfo.DataSource;
            if (DT != null) DT.Clear();
            if (dtp_PeriodFrom.Value > dtp_PeriodTo.Value)
            {
                MessageBox.Show("Date from must be earlier than date to", "Error", MessageBoxButtons.OK);
                return;
            }
            string period_from = dtp_PeriodFrom.Value.ToString("yyyy-MM-dd");
            string period_to = dtp_PeriodTo.Value.ToString("yyyy-MM-dd");
            OleDbDataAdapter da = new OleDbDataAdapter("EXEC DealsPerTimeV2 '" + nickname + "', '" + period_from + "', '" + period_to + "'", cn);
            da.Fill(ds_info, "ContractsPetTime");
            dgv_userinfo.DataSource = ds_info.Tables["ContractsPetTime"];
            dgv_userinfo.Columns[1].HeaderText = "From";
            dgv_userinfo.Columns[2].HeaderText = "To";
            
            DataGridViewCellStyle TimeStyle = new DataGridViewCellStyle();
            TimeStyle.Format = "t";
            dgv_userinfo.Columns[1].DefaultCellStyle = TimeStyle;
            dgv_userinfo.Columns[2].DefaultCellStyle = TimeStyle;
            dgv_userinfo.Columns[0].Width = 90;
            dgv_userinfo.Columns[1].Width = 60;
            dgv_userinfo.Columns[2].Width = 60;
            dgv_userinfo.Columns[3].Width = 70;
        }

        private void b_DeleteDeal_Click(object sender, EventArgs e)
        {
            string s;
            try
            {
                s = lb_deals.SelectedItem.ToString();
                s=s.Remove(s.IndexOf(" "), s.Length - s.IndexOf(" "));
            }
            catch (Exception) { MessageBox.Show("Nothing selected", "Error", MessageBoxButtons.OK); return; }
           
            OleDbCommand command = new OleDbCommand("EXEC DeleteDeal "+s, cn);
            int rows = command.ExecuteNonQuery();
            if (rows <= 0)
            {
                MessageBox.Show("Opps! Something went wrong", "Error", MessageBoxButtons.OK);
                return;
            } else
            {
                MessageBox.Show("Deal was successfully deleted", "Info", MessageBoxButtons.OK);
                lb_deals.Items.Clear();
            }
            command.CommandText = "EXEC ShowDeals '" + nickname + "'";
            OleDbDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                string dd = rdr["DateOfDeal"].ToString();
                dd = dd.Substring(0, dd.Length - 8);
                string tb = rdr["TimeOfBegin"].ToString();
                tb = tb.Substring(0, tb.Length - 11);
                string te = rdr["TimeOfEnd"].ToString();
                te = te.Substring(0, te.Length - 11);
                lb_deals.Items.Add(rdr["Number"] + " " + dd + " " + tb + "-" + te);
            }
            rdr.Close();
        }
    }
}
