using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace courcework
{
    public partial class RegisterClientForm : Form
    {
        public RegisterClientForm()
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
            /*Modifier mod = new Modifier();
            mod.MakeNiceButton(b_reg);
            mod.MakeNiceLabel(label1);
            mod.MakeNiceLabel(label2);
            mod.MakeNiceLabel(label3);
            mod.MakeNiceLabel(label5);*/

            label6.Font = new Font("Times New Roman", 16);
        }

        private void b_reg_Click(object sender, EventArgs e)
        {
            if (tb_login.Text.ToString() == "")
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
            OleDbCommand command = new OleDbCommand("EXEC GetPassword '" + tb_login.Text.ToString() + "'", cn);
            OleDbDataReader rdr = command.ExecuteReader();
            string pswd = "";
            try
            {
                rdr.Read();
                pswd = rdr.GetString(0);
                MessageBox.Show("This login already exist", "Error", MessageBoxButtons.OK);
                return;
            }
            catch (Exception) { }
            OleDbCommand command2 = new OleDbCommand("EXEC CreateUser '" + tb_fio.Text.ToString()
                + "', '" + tb_mail.Text.ToString() + "', '" + tb_login.Text.ToString()
                + "', '" + tb_pswd.Text.ToString() + "'", cn);
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
