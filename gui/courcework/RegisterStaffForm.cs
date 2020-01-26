using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace courcework
{
    public partial class RegisterStaffForm : Form
    {
        public RegisterStaffForm()
        {
            InitializeComponent();
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!", "Connection", MessageBoxButtons.OK);
            }
        }

        private void b_reg_Click(object sender, EventArgs e)
        {
            if (tb_login.Text.ToString()=="")
            {
                MessageBox.Show("Login field is empty", "Error", MessageBoxButtons.OK);
                return;
            }
            if (tb_pswd.Text.ToString() == "")
            {
                MessageBox.Show("Password field is empty", "Error", MessageBoxButtons.OK);
                return;
            }
            if (tb_fio.Text.ToString() == "")
            {
                MessageBox.Show("FIO field is empty", "Error", MessageBoxButtons.OK);
                return;
            }
            if (tb_mail.Text.ToString() == "")
            {
                MessageBox.Show("Mail field is empty", "Error", MessageBoxButtons.OK);
                return;
            }
            if (tb_post.Text.ToString() == "")
            {
                MessageBox.Show("Post field is empty", "Error", MessageBoxButtons.OK);
                return;
            }


            OleDbCommand command = new OleDbCommand("EXEC GetPasswordS '" + tb_login.Text.ToString() + "'", cn);
            OleDbDataReader rdr = command.ExecuteReader();
            string pswd = "";
            try
            {
                rdr.Read();
                pswd = rdr.GetString(0);
                MessageBox.Show("This login already exist", "Error", MessageBoxButtons.OK);
                return;
            }
            catch (Exception){}
            OleDbCommand command2 = new OleDbCommand("EXEC CreateNewWorker '" + tb_fio.Text.ToString()
                + "', '" + tb_mail.Text.ToString()+ "', '"+tb_login.Text.ToString()
                + "', '"+tb_pswd.Text.ToString()+"', '"+tb_post.Text.ToString()+"'", cn);
            int rows = command2.ExecuteNonQuery();
            if (rows <= 0)
            {
                MessageBox.Show("Oops! Something went wrong", "Error", MessageBoxButtons.OK);
                return;
            }
            else MessageBox.Show("Registration was successfull", "Info", MessageBoxButtons.OK);
        }
    }
}
