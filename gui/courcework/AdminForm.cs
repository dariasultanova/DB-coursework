using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace courcework
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            Modifier mod = new Modifier();
            OleDbDataAdapter da1 = new OleDbDataAdapter("EXEC InfoAboutWorkers", cn);
            da1.Fill(ds_staff, "Staff");
            dgv_staff.DataSource = ds_staff.Tables["Staff"];
            OleDbDataAdapter da2 = new OleDbDataAdapter("EXEC BrokenObjects", cn);
            da2.Fill(ds_broken, "Broken");
            dgv_broken.DataSource = ds_broken.Tables["Broken"];

            mod.MakeNiceTabPage(tp_1);
            mod.MakeNiceTabPage(tp_2);
            mod.MakeNiceTabPage(tp_3);
            mod.MakeNiceTabControl(tc_admin);
            mod.MakeNiceDataGridView(dgv_broken);
            mod.MakeNiceDataGridView(dgv_money);
            mod.MakeNiceDataGridView(dgv_staff);
            mod.MakeNiceComboBox(cb_typeAdd);
            mod.MakeNiceComboBox(cb_typeFix);
            mod.MakeNiceComboBox(cb_type2);

            dgv_staff.Columns[0].Width = 30;
            dgv_staff.Columns[1].Width = 240;
            dgv_staff.Columns[2].Width = 190;
            dgv_staff.Columns[3].Width = 40;
            dgv_staff.Columns[4].Width = 60;
            dgv_staff.Columns[7].Width = 60;
            dgv_broken.Columns[0].Width = 180;
            dgv_broken.Columns[1].Width = 50;

            cn.Open();
            OleDbCommand command = new OleDbCommand("SELECT Post FROM Jobs", cn);
            OleDbDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                lb_post.Items.Add(rdr["Post"]);

            }
            rdr.Close();
        }

        private void b_expenses_Click(object sender, EventArgs e)
        {
            DataTable DT = (DataTable)dgv_money.DataSource;
            if (DT != null) DT.Clear();
            if (dtp_from.Value > dtp_to.Value)
            {
                MessageBox.Show("Date from must be earlier than date to", "Error", MessageBoxButtons.OK);
                return;
            }

            string period_from = dtp_from.Value.ToString("yyyy-MM-dd");
            string period_to = dtp_to.Value.ToString("yyyy-MM-dd");
            OleDbDataAdapter da = new OleDbDataAdapter("EXEC LostPerTimeTable '" + period_from + "', '" + period_to + "'", cn);
            da.Fill(ds_money, "LostPetTime");           
            dgv_money.DataSource = ds_money.Tables["LostPetTime"];

            OleDbCommand command = new OleDbCommand("EXEC LostPerTime '" + period_from + "', '" + period_to + "'", cn);
            OleDbDataReader rdr = command.ExecuteReader();
            string sum = "";
            try
            {
                rdr.Read();
                sum = rdr.GetInt32(0).ToString();
               // rdr.Get
            }
            catch (Exception)
            {
               return;
            }
            tb_sum.Text = sum;
            dgv_money.Columns[1].Width = 70;
            dgv_money.Columns[2].Width = 60;
            dgv_money.Columns[3].Width = 180;
            dgv_money.Columns[0].HeaderText = "Date";
            dgv_money.Columns[2].HeaderText = "ID";
        }

        private void b_income_Click(object sender, EventArgs e)
        {
            DataTable DT = (DataTable)dgv_money.DataSource;
            if (DT != null) DT.Clear();
            if (dtp_from.Value > dtp_to.Value)
            {
                MessageBox.Show("Date from must be earlier than date to", "Error", MessageBoxButtons.OK);
                return;
            }

            string period_from = dtp_from.Value.ToString("yyyy-MM-dd");
            string period_to = dtp_to.Value.ToString("yyyy-MM-dd");
            OleDbDataAdapter da = new OleDbDataAdapter("EXEC IncomePerTimeTable '" + period_from + "', '" + period_to + "'", cn);
            da.Fill(ds_money, "IncomePetTime");
            dgv_money.DataSource = ds_money.Tables["IncomePetTime"];

            OleDbCommand command = new OleDbCommand("EXEC IncomePerTime '" + period_from + "', '" + period_to + "'", cn);
            OleDbDataReader rdr = command.ExecuteReader();
            string sum = "";
            try
            {
                rdr.Read();
                sum = rdr.GetInt32(0).ToString();
                // rdr.Get
            }
            catch (Exception)
            {
                return;
            }
            tb_sum.Text = sum;

            dgv_money.Columns[0].Width = 90;
            dgv_money.Columns[1].Width = 60;
            dgv_money.Columns[2].Width = 60;
            dgv_money.Columns[3].Width = 165;
            dgv_money.Columns[4].Width = 70;
            dgv_money.Columns[0].HeaderText = "Date";
            dgv_money.Columns[1].HeaderText="From";
            dgv_money.Columns[2].HeaderText = "To";

        }

        private void b_changeSalary_Click(object sender, EventArgs e)
        {
            
            try
            {
               int sal= Convert.ToInt32(tb_salary.Text);
                if(sal<=0)
                {
                    MessageBox.Show("Salary must be more than 0", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            catch {
                MessageBox.Show("Salary must be int", "Error", MessageBoxButtons.OK);
                return;
            }
            string s = "";
            try
            {
                s = lb_post.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Post is not selected", "Error", MessageBoxButtons.OK);
                return;
            }
            OleDbCommand command = new OleDbCommand("EXEC ChangeSalary '" + s + "', " + tb_salary.Text.ToString(), cn);
            int rows = command.ExecuteNonQuery();
            if(rows<=0)
            {
                MessageBox.Show("Opps! Something went wrong", "Error", MessageBoxButtons.OK);
                return;
            }
            DataTable DT = (DataTable)dgv_staff.DataSource;
            if (DT != null) DT.Clear();
            OleDbDataAdapter da1 = new OleDbDataAdapter("EXEC InfoAboutWorkers", cn);
            da1.Fill(ds_staff, "Staff");
            dgv_staff.DataSource = ds_staff.Tables["Staff"];
        }

        private void b_changePay_Click(object sender, EventArgs e)
        {
            try
            {
                int sal = Convert.ToInt32(tb_pay.Text);
                if (sal <= 0)
                {
                    MessageBox.Show("Pay must be more than 0", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Pay must be int", "Error", MessageBoxButtons.OK);
                return;
            }
            string s = "";
            try
            {
                s = lb_post.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Post is not selected", "Error", MessageBoxButtons.OK);
                return;
            }
            OleDbCommand command = new OleDbCommand("EXEC ChangePay '" + s + "', " + tb_pay.Text.ToString(), cn);
            int rows = command.ExecuteNonQuery();
            if (rows <= 0)
            {
                MessageBox.Show("Opps! Something went wrong", "Error", MessageBoxButtons.OK);
                return;
            }
            DataTable DT = (DataTable)dgv_staff.DataSource;
            if (DT != null) DT.Clear();
            OleDbDataAdapter da1 = new OleDbDataAdapter("EXEC InfoAboutWorkers", cn);
            da1.Fill(ds_staff, "Staff");
            dgv_staff.DataSource = ds_staff.Tables["Staff"];
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(tb_ID.Text);
            }
            catch
            {
                MessageBox.Show("Wrong format of ID", "Error", MessageBoxButtons.OK);
                return;
            }
            OleDbCommand command = new OleDbCommand("EXEC DeleteWorker "  + tb_ID.Text.ToString(), cn);
            int rows = command.ExecuteNonQuery();
            if (rows <= 0)
            {
                MessageBox.Show("Something went wrong while changing,\nmaybe this ID is not exist", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Worker was deleted", "Info", MessageBoxButtons.OK);
            }
            DataTable DT = (DataTable)dgv_staff.DataSource;
            if (DT != null) DT.Clear();
            OleDbDataAdapter da1 = new OleDbDataAdapter("EXEC InfoAboutWorkers", cn);
            da1.Fill(ds_staff, "Staff");
            dgv_staff.DataSource = ds_staff.Tables["Staff"];
        }

        private void b_register_Click(object sender, EventArgs e)
        {
            RegisterStaffForm reg = new RegisterStaffForm();
            reg.Show();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            try
            {
                int sal = Convert.ToInt32(tb_price.Text);
                if (sal <= 0)
                {
                    MessageBox.Show("Price couldn't be less than 0", "Error", MessageBoxButtons.OK);
                    return;
                }
                sal = Convert.ToInt32(tb_arenda.Text);
                if (sal <= 0)
                {
                    MessageBox.Show("Cost for arenda must be more than 0", "Error", MessageBoxButtons.OK);
                    return;
                }
               if (tb_title.Text.ToString()=="")
                {
                    MessageBox.Show("Wrong type of data", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Wrong type of data", "Error", MessageBoxButtons.OK);
                return;
            }
            string s = "";
            try
            {
                s = cb_typeAdd.SelectedItem.ToString();
                if (s == "Hall") s = "0";
                if (s == "Instrument") s = "1";
                if (s == "Equipment") s = "2";
            }
            catch
            {
                MessageBox.Show("Type is not selected", "Error", MessageBoxButtons.OK);
                return;
            }
            OleDbCommand command = new OleDbCommand("EXEC BuyNew " + s + ", "+tb_price.Text.ToString()+", '" + tb_title.Text.ToString()+"', "+tb_arenda.Text.ToString(), cn);
            int rows = command.ExecuteNonQuery();
            if (rows <= 0)
            {
                MessageBox.Show("Opps! Something went wrong", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("New item was added", "Info", MessageBoxButtons.OK);

            }
        }

        private void b_change_Click(object sender, EventArgs e)
        {
            try
            {
                int sal = Convert.ToInt32(tb_newCost.Text);
                if (sal <= 0)
                {
                    MessageBox.Show("Price couldn't be less than 0", "Error", MessageBoxButtons.OK);
                    return;
                }
               
                if (tb_title2.Text.ToString() == "")
                {
                    MessageBox.Show("Wrong type of data", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Wrong type of data", "Error", MessageBoxButtons.OK);
                return;
            }
            string s = "";
            try
            {
                s = cb_type2.SelectedItem.ToString();
                if (s == "Hall") s = "0";
                if (s == "Instrument") s = "1";
                if (s == "Equipment") s = "2";
            }
            catch
            {
                MessageBox.Show("Type is not selected", "Error", MessageBoxButtons.OK);
                return;
            }
            OleDbCommand command = new OleDbCommand("EXEC ChangeArenda '" + tb_title2.Text.ToString() + "', " + s + ", " + tb_newCost.Text.ToString() , cn);
            int rows = command.ExecuteNonQuery();
            if (rows <= 0)
            {
                MessageBox.Show("Something went wrong while changing, \nmaybe this title is not exist", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Cost of arenda was changed", "Info", MessageBoxButtons.OK);

            }
        }

        private void b_report_Click(object sender, EventArgs e)
        {
            try
            {
                int sal = Convert.ToInt32(tb_num.Text);
                sal= Convert.ToInt32(tb_cost.Text);
            }
            catch
            {
                MessageBox.Show("Wrong type of data", "Error", MessageBoxButtons.OK);
                return;
            }
            string s = "";
            try
            {
                s = cb_typeFix.SelectedItem.ToString();
                if (s == "Hall") s = "0";
                if (s == "Instrument") s = "1";
                if (s == "Equipment") s = "2";
            }
            catch
            {
                MessageBox.Show("Type is not selected", "Error", MessageBoxButtons.OK);
                return;
            }
            OleDbCommand command = new OleDbCommand("EXEC  ObjectRepair " + tb_num.Text.ToString() + ", " + s + ", " + tb_cost.Text.ToString(), cn);
            try
            {
                int rows = command.ExecuteNonQuery();
                if (rows <= 0)
                {
                    MessageBox.Show("Opps! Something went wrong", "Error", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Report was sended", "Info", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong while changing, \nmaybe this number is not exist", "Error", MessageBoxButtons.OK);
                return;
            }
            
            DataTable DT = (DataTable)dgv_broken.DataSource;
            if (DT != null) DT.Clear();
            OleDbDataAdapter da2 = new OleDbDataAdapter("EXEC BrokenObjects", cn);
            da2.Fill(ds_broken, "Broken");
            dgv_broken.DataSource = ds_broken.Tables["Broken"];
        }
    }
}
